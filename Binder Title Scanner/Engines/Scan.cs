using System;
using System.Data;
using System.IO;

namespace BTS.Engines
{
    public class Scan
    {
        public string Admin;
        public string Bid;
        public string Bin;
        public string Connection;
        public string FileRoom;
        public string Path;
        public DataTable Results;
        public string Server;
        public bool failed;
        private bool isCfr;
        public bool isLive;
        public string kcAdmin;
        public string kcBid;
        public string kcBin;

        public bool IsCfr
        {
            get { return isCfr; }
            set
            {
                isCfr = value;
                Admin = isCfr ? "CentralAdmin" : "LocalAdmin";
                kcAdmin = isCfr ? "KC_CentralAdmin" : "KC_LocalAdmin";
            }
        }

        public void Invoke()
        {
            if (isLive)
            {
                InvokeLive();
            }
            else
            {
                InvokeOffline();
            }
        }

        private void InvokeOffline()
        {
            string tmpDir = BTSEngine.HomeDir + "\\tmpDir", kcXML = tmpDir + "\\KC_Bin.xml";
            if (Directory.Exists(tmpDir))
            {
                Directory.Delete(tmpDir, true);
            }
            try
            {
                Directory.CreateDirectory(tmpDir);

                if (BTSEngine.UnzipFile(Path, "MagicRun", tmpDir, "KC_Bin.xml"))
                {
                    File.SetAttributes(kcXML, File.GetAttributes(kcXML) & ~FileAttributes.ReadOnly);
                    Results = BTSEngine.SetResults(BTSEngine.LoadBinderTitles(kcXML));
                }
            }
            catch (Exception e)
            {
                failed = true;
                Messaging.ThrowException("Scan Unhandled Package", e);
            }
            finally
            {
                if (Directory.Exists(tmpDir))
                {
                    Directory.Delete(tmpDir, true);
                }
            }
        }

        private void InvokeLive()
        {
            Connection = BTSEngine.BuildConnector(Server);
            Bin =
                SqlEngine.LoadBins(Connection, Admin, false)
                    .Find(b => SqlEngine.CheckBin(Connection, b, Bid, false));
            FileRoom = (isCfr)
                ? SqlEngine.GetID(Connection, Admin, Server, FileRoom, "File Room GUID", false, isCfr)
                : SqlEngine.GetID(Connection, Admin, Bid, FileRoom, "File Room GUID", false, isCfr);
            if (Bin != null)
            {
                kcBid = SqlEngine.GetID(Connection, Bin, Bid, FileRoom, "KC GUID", true, isCfr);
                if (kcBid != string.Empty)
                {
                    kcBin =
                        SqlEngine.LoadBins(Connection, kcAdmin, true)
                            .Find(b => SqlEngine.CheckBin(Connection, b, kcBid, true));

                    if (kcBin != null)
                    {
                        Results = BTSEngine.SetResults(SqlEngine.LoadBinderTitles(Connection, kcBin, kcBid));
                    }
                    else
                    {
                        Messaging.ThrowException("Scan", new Exception("Unable to determine KC Bin GUID"));
                    }
                }
                else
                {
                    Messaging.ThrowException("Scan", new Exception("Unable to determine KC Binder ID"));
                }
            }
            else
            {
                Messaging.ThrowException("Scan", new Exception("Unable to determine Bin GUID"));
            }
        }
    }
}