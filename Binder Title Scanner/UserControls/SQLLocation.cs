using System;
using System.Windows.Forms;
using BTS.Engines;

namespace BTS.UserControls
{
    public partial class SQLLocation : UserControl
    {
        public SQLLocation()
        {
            InitializeComponent();
            rdoLocal.Checked = true;
        }

        public bool SQLEval
        {
            get
            {
                if (rdoRemote.Checked && txtOfficeServer.Text.Equals(string.Empty))
                {
                    Messaging.ThrowException("Invalid Location", new Exception("Please enter a valid server Location."));
                    return false;
                }
                return true;
            }
        }

        public bool isCFR
        {
            get { return rdoCFR.Checked; }
        }

        public bool isRemote
        {
            get { return rdoRemote.Checked; }
        }

        public string Server
        {
            get { return (txtOfficeServer.Text == string.Empty) ? Environment.MachineName : txtOfficeServer.Text; }
        }

        private void rdoLocal_CheckedChanged(object sender, EventArgs e)
        {
            txtOfficeServer.Enabled = false;
        }

        private void rdoRemote_CheckedChanged(object sender, EventArgs e)
        {
            txtOfficeServer.Enabled = true;
        }
    }
}