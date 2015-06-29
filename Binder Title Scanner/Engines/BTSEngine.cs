using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using ComponentAce.Compression.Archiver;
using ComponentAce.Compression.ZipForge;

namespace BTS.Engines
{
    internal static class BTSEngine
    {
        public static string ImportLog;
        public static List<Title> Titles = new List<Title>();
        public static XmlDocument TitleDoc = new XmlDocument();
        public static string HomeDir = Environment.CurrentDirectory;

        #region Public

        public static void AddTitle(Title title, bool isSingle)
        {
            bool exists = Titles.Exists(t => title.Guid == t.Guid);
            if (!exists)
            {
                TitleDoc.DocumentElement.AppendChild(BuildNode(TitleDoc, title));
                CommitXML();
            }
            else
            {
                if (exists && !isSingle)
                {
                    ImportLog += title.Name.TrimEnd() + " already exists.\n";
                }
                else
                {
                        Messaging.ThrowException("Existing Title", new Exception("Title already exists."));
                }
            }
        }

        public static void DeleteTitle(string guid)
        {
            foreach (XmlNode node in TitleDoc.ChildNodes[0].ChildNodes)
            {
                if (node.Attributes[0].Value == guid)
                {
                    TitleDoc.ChildNodes[0].RemoveChild(node);
                    break;
                }
            }
            CommitXML();
        }

        public static void PullFromPackage(string path, bool isSingle)
        {
            string tmpDir = HomeDir + "\\tmpDir";
            var title = new XmlDocument();
            if (Directory.Exists(tmpDir))
            {
                Directory.Delete(tmpDir, true);
            }
            if (UnzipFile(path, "SyncZip", tmpDir, "KC.xml"))
            {
                try
                {
                    title.Load(tmpDir + "\\KC.xml");
                    XmlNode xmlTitleNodeFromKCP = title.DocumentElement.SelectSingleNode("Ecosystem.TitleVersion");
                    AddTitle(new Title(xmlTitleNodeFromKCP.SelectSingleNode("TitleVersionID").InnerText,
                        xmlTitleNodeFromKCP.SelectSingleNode("Name").InnerText,
                        xmlTitleNodeFromKCP.SelectSingleNode("CCHReleaseDate").InnerText.Substring(0, 10),
                        xmlTitleNodeFromKCP.SelectSingleNode("Year").InnerText), isSingle);
                }
                catch (DirectoryNotFoundException e)
                {
                    Messaging.ThrowException("PullFromPackage", e);
                    ImportLog += "File Failed: " + path;
                }
                catch (FileNotFoundException e)
                {
                    Messaging.ThrowException("PullFromPackage", e);
                    ImportLog += "File Failed: " + path;
                }
                catch (FileLoadException e)
                {
                    Messaging.ThrowException("PullFromPackage", e);
                    ImportLog += "File Failed: " + path;
                }
                catch (Exception e)
                {
                    Messaging.ThrowException("PullFromPackage", e);
                    ImportLog += "File Failed: " + path;
                }
                finally
                {
                    if (Directory.Exists("tmpDir"))
                    {
                        Directory.Delete("tmpDir", true);
                    }
                }
            }
        }

        public static bool UnzipFile(string path, string pass, string dir, string file)
        {
            try
            {
                using (var zpr = new ZipForge())
                {
                    zpr.FileName = path;
                    zpr.OpenArchive(FileMode.Open);
                    zpr.Password = pass;
                    zpr.BaseDir = dir;
                    zpr.ExtractFiles(file);
                }
            }
            catch (ArchiverException e)
            {
                Messaging.ThrowException("UnzipFile", e);
                return false;
            }
            catch (Exception e)
            {
                Messaging.ThrowException("UnzipFile", e);
                return false;
            }
            return true;
        }

        public static List<string> LoadBinderTitles(string path)
        {
            var titles = new List<string>();
            var doc = new XmlDocument();
            try
            {
                doc.Load(path);
                XmlNodeList workpapers = doc.DocumentElement.SelectNodes("BinderData.Workpaper");
                foreach (XmlElement element in workpapers)
                {
                    string title = element.SelectSingleNode("TitleVersionID").InnerText;
                    if (!titles.Contains(title.Trim()))
                    {
                        titles.Add(title);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Messaging.ThrowException("LoadBinderTitles", e);
            }
            catch (FileLoadException e)
            {
                Messaging.ThrowException("LoadBinderTitles", e);
            }
            catch (Exception e)
            {
                Messaging.ThrowException("LoadBinderTitles", e);
            }
            return titles;
        }

        public static DataTable SetResults(List<string> results)
        {
            DataTable set = BuildTable(true);
            if (results.Count > 0)
            {
                results.ForEach(r =>
                {
                    foreach (Title t in Titles)
                    {
                        if (r.ToUpper() == t.Guid.ToUpper())
                        {
                            set.Rows.Add(BuildRow(set.NewRow(), t, true, true));
                            break;
                        }
                        if (Titles.IndexOf(t) == Titles.Count - 1)
                        {
                            set.Rows.Add(BuildRow(set.NewRow(), new Title(r, null, null, null), false, true));
                        }
                    }
                });
            }
            else
            {
                MessageBox.Show("No KC Title record could be identified.");
            }
            return set;
        }

        #endregion

        #region Private

        internal static void LoadTitles()
        {
            if (Titles.Count > 0)
            {
                Titles.Clear();
            }
            var xmlTitles = new XmlDocument();
            try
            {
                xmlTitles.Load(HomeDir + "\\Titles.xml");
                foreach (XmlNode title in xmlTitles.ChildNodes[0].ChildNodes)
                {
                    Titles.Add(new Title(title.Attributes["guid"].Value,
                        title.Attributes["name"].Value,
                        title.Attributes["version"].Value,
                        title.Attributes["year"].Value));
                }
            }
            catch (FileNotFoundException e)
            {
                Messaging.ThrowException("File not found", e);
            }
            catch (FileLoadException e)
            {
                Messaging.ThrowException("Unable to load file", e);
            }
            catch (Exception e)
            {
                Messaging.ThrowException("Unhandled LoadTitles", e);
            }
        }

        private static void CommitXML()
        {
            using (
                var writer = new FileStream(HomeDir + "\\Titles.xml", FileMode.Truncate, FileAccess.Write,
                    FileShare.ReadWrite))
            {
                TitleDoc.Save(writer);
                writer.Close();
            }
            LoadTitles();
            TitleDoc.Load(HomeDir + "\\Titles.xml");
        }

        #endregion

        #region Builders

        public static string BuildConnector(string server)
        {
            return new SqlConnectionStringBuilder
            {
                DataSource = server + "\\ProFXEngagement",
                InitialCatalog = "master",
                UserID = "sa",
                Password = "banglapur"
            }.ConnectionString;
        }

        public static DataTable BuildTable(bool isScan)
        {
            return (isScan)
                ? new DataTable("Results")
                {
                    Columns =
                    {
                        new DataColumn("Year"),
                        new DataColumn("Name"),
                        new DataColumn("Version")
                    }
                }
                : new DataTable("Titles")
                {
                    Columns =
                    {
                        new DataColumn("Name"),
                        new DataColumn("GUID"),
                        new DataColumn("Year"),
                        new DataColumn("Version")
                    }
                };
        }

        public static DataRow BuildRow(DataRow row, Title title, bool found, bool isScan)
        {
            if (isScan)
            {
                row["Name"] = found ? title.Name : title.Guid;
                row["Version"] = found ? title.Version : null;
                row["Year"] = found ? title.Year : null;
            }
            else
            {
                row["Name"] = title.Name;
                row["GUID"] = title.Guid;
                row["Year"] = title.Year;
                row["Version"] = title.Version;
            }
            return row;
        }

        private static XmlNode BuildNode(XmlDocument doc, Title title)
        {
            XmlNode node = doc.CreateNode(XmlNodeType.Element, "Title", doc.NamespaceURI);
            node.Attributes.Append(doc.CreateAttribute("guid"));
            node.Attributes.Append(doc.CreateAttribute("name"));
            node.Attributes.Append(doc.CreateAttribute("version"));
            node.Attributes.Append(doc.CreateAttribute("year"));
            node.Attributes["guid"].Value = title.Guid.Trim();
            node.Attributes["name"].Value = title.Name.Trim();
            node.Attributes["version"].Value = title.Version.Trim();
            node.Attributes["year"].Value = title.Year.Trim();
            return node;
        }

        #endregion
    }
}