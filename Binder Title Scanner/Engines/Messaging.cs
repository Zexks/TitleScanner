using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTS.Engines
{
    public static class Messaging
    {
        public static void ThrowException(string title, Exception e)
        {
            MessageBox.Show(e.Message + ((e.TargetSite == null) ? string.Empty : "\nSource:" + e.TargetSite) +
                            ((e.InnerException == null) ? string.Empty : "\nInner Exception:" + e.InnerException),
                title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ThrowException(string title, SqlException e)
        {
            for (int i = 0; i < e.Errors.Count; i++)
            {
                MessageBox.Show("Error #" + i +
                                "\nMessage: " + e.Errors[i].Message +
                                ((e.Errors[i].Source == string.Empty) ? string.Empty : "\nSource: " + e.Errors[i].Source) +
                                ((e.Errors[i].Procedure == string.Empty)
                                    ? string.Empty
                                    : "\nProceedure: " + e.Errors[i].Procedure),
                    title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}