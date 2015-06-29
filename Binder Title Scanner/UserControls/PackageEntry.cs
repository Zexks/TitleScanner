using System;
using System.IO;
using System.Windows.Forms;
using BTS.Engines;

namespace BTS.UserControls
{
    public partial class PackageEntry : UserControl
    {
        private string[] fileList;

        public PackageEntry()
        {
            InitializeComponent();
        }

        //private string dirPath;

        public string[] FileList
        {
            get { return fileList; }
        }

        public string Path
        {
            get { return txtPath.Text; }
        }

        public Button Browse
        {
            get { return btnBrowse; }
        }

        public bool PackageEval
        {
            get
            {
                if (txtPath.Text.Equals(string.Empty) || !File.Exists(Path))
                {
                    Messaging.ThrowException("Invalid Path", new FileNotFoundException());
                    return false;
                }
                return true;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            fileList = new string[0];
            string filter = (Convert.ToInt32((sender as Button).Tag) == 0)
                ? "AZP Files (*.AZP)|*.azp|All Files (*.*)|*.*"
                : "KCP Files (*.KCP)|*.kcp|All Files (*.*)|*.*";

            var browseDialog = new OpenFileDialog {Multiselect = true, Filter = filter};

            if (browseDialog.ShowDialog() == DialogResult.OK)
            {
                if (browseDialog.FileNames.Length > 1)
                {
                    txtPath.Text = @"Multiple Files Selected";
                    fileList = browseDialog.FileNames;
                }
                else
                {
                    txtPath.Text = browseDialog.FileName;
                }
            }
        }
    }
}