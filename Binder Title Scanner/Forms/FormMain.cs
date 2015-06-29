using System;
using System.Data;
using System.Windows.Forms;
using BTS.Engines;

namespace BTS.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            rdoPkg.Checked = true;
            setPackage.Browse.Tag = 0;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            var scan = new Scan();

            if (rdoLive.Checked && setLive.LiveEval && setLocation.SQLEval)
            {
                scan.isLive = true;
                scan.IsCfr = setLocation.isCFR;
                scan.Bid = setLive.BID;
                scan.FileRoom = setLive.FileRoom;
                scan.Server = setLocation.Server;
            }
            else
            {
                if (rdoPkg.Checked && setPackage.PackageEval)
                {
                    scan.Path = setPackage.Path;
                }
                else
                {
                    scan.failed = true;
                }
            }
            if (!scan.failed)
            {
                scan.Invoke();
                dgvResults.DataSource = (scan.failed != true) ? scan.Results : new DataTable();
            }
        }

        private void btnTitleMgr_Click(object sender, EventArgs e)
        {
            var titles = new FormTitleMgr();
            titles.ShowDialog();
        }

        private void rdoLive_CheckedChanged(object sender, EventArgs e)
        {
            setPackage.Visible = false;
            setLive.Visible = true;
            setLocation.Enabled = true;
        }

        private void rdoPkg_CheckedChanged(object sender, EventArgs e)
        {
            setPackage.Visible = true;
            setLive.Visible = false;
            setLocation.Enabled = false;
        }
    }
}