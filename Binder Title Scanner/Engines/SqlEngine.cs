using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BTS.Enums;

namespace BTS.Engines
{
    internal static class SqlEngine
    {
        private static object PullSql(string conn, string db, string query, string error, SQLReturn type)
        {
            var result = new object();
            try
            {
                using (var c = new SqlConnection(conn))
                {
                    c.Open();
                    c.ChangeDatabase(db);
                    SqlDataReader reader = new SqlCommand(query, c).ExecuteReader();
                    switch (type)
                    {
                        case SQLReturn.Bool:
                            result = false;
                            while (reader.Read())
                            {
                                if (reader != null)
                                {
                                    result = true;
                                    break;
                                }
                            }
                            break;
                        case SQLReturn.Item:
                            result = String.Empty;
                            while (reader.Read())
                            {
                                if (reader != null)
                                {
                                    result = reader[0].ToString();
                                    break;
                                }
                            }
                            break;
                        case SQLReturn.List:
                            var Results = new List<string>();
                            while (reader.Read())
                            {
                                Results.Add(reader[0].ToString());
                            }
                            result = Results;
                            break;
                    }
                }
            }
            catch (SqlException e)
            {
                Messaging.ThrowException(error, e);
            }
            catch (Exception e)
            {
                Messaging.ThrowException(error, e);
            }
            return result;
        }

        public static bool CheckBin(string conn, string db, string id, bool isKc)
        {
            string query = isKc
                ? "SELECT * FROM BinderData.Binder WHERE KCBinderGuid = '" + id + "'"
                : "SELECT * FROM Binder WHERE bid = '" + id + "'";
            return (bool) PullSql(conn, db, query, "Failed Checking Bins", SQLReturn.Bool);
        }

        public static string GetID(string conn, string db, string id1, string id2, string error, bool isKc, bool isCfr)
        {
            string query = isKc
                ? "SELECT KCBid FROM KnowledgeCoach WHERE Bid = '" + id1 + "' AND LfrGuid = '" + id2 + "'"
                : isCfr
                    ? "SELECT CFR.cfrguid from CFR join CFRServer on CFR.ServerGuid = CFRServer.serverguid where CFR.cfrname = '" +
                      id2 + "' and CFRServer.Servername = '" + id1 + "'"
                    : "SELECT LFR.lfrguid FROM LFR JOIN Binder ON Binder.lfrguid = LFR.lfrguid WHERE LFR.staffguid = '" +
                      id2 + "' AND Binder.bid = '" + id1 + "'";
            return (string) PullSql(conn, db, query, error, SQLReturn.Item);
        }

        public static List<string> LoadBins(string conn, string db, bool isKc)
        {
            string query = isKc ? "SELECT DatabaseName FROM BIN" : "SELECT BinDBName FROM BIN";
            return (List<string>) PullSql(conn, db, query, "Loading Bins", SQLReturn.List);
        }

        public static List<string> LoadBinderTitles(string conn, string db, string kcId)
        {
            string query = "SELECT DISTINCT TitleVersionID FROM BINDERDATA.WORKPAPER WHERE KCBinderGuid = '" + kcId +
                           "'";
            return (List<string>) PullSql(conn, db, query, "Loading Binder Titles", SQLReturn.List);
        }
    }
}
