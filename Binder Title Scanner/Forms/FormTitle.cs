using System;
using System.ComponentModel;
using System.Windows.Forms;
using BTS.Engines;

namespace BTS.Forms
{
    public partial class FormTitle : Form
    {
        private readonly bool editing;
        private Title inputTitle;
        private FormProgress prgWindow;

        public FormTitle()
        {
            InitializeComponent();
            rdoPackage.Checked = true;
            packageEntry.Browse.Tag = 1;
        }

        public FormTitle(Title t)
        {
            inputTitle = t;
            editing = true;
            InitializeComponent();
            rdoManual.Visible = false;
            rdoPackage.Visible = false;
            packageEntry.Visible = false;
            manualEntry.TitleEntry = inputTitle;
        }

        private void rdoManual_CheckedChanged(object sender, EventArgs e)
        {
            packageEntry.Visible = false;
            manualEntry.Visible = true;
        }

        private void rdoPackage_CheckedChanged(object sender, EventArgs e)
        {
            packageEntry.Visible = true;
            manualEntry.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool pass = false;
            if (rdoPackage.Checked)
            {
                pass = SaveFromPackage();
            }
            else if (rdoManual.Checked)
            {
                pass = SaveManual();
            }

            if (pass &&
                MessageBox.Show("Would you like to enter another Title?", "Continue", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
            {
                Close();
            }
            else
            {
                manualEntry.ClearEntries();
            }
        }

        private bool SaveManual()
        {
            bool pass = false;
            if (manualEntry.ValidateTextControls())
            {
                Title newTitle = manualEntry.TitleEntry;
                if (editing)
                {
                    BTSEngine.DeleteTitle(inputTitle.Guid);
                    BTSEngine.AddTitle(newTitle, true);
                }
                else
                {
                    BTSEngine.AddTitle(newTitle, true);
                }
                pass = true;
            }
            return pass;
        }

        private bool SaveFromPackage()
        {
            bool pass = false;
            if (packageEntry.FileList != null && packageEntry.FileList.Length > 0)
            {
                prgWindow = new FormProgress(bgwSave);
                while (!prgWindow.Complete)
                {
                    prgWindow.ShowDialog();
                }
                prgWindow.Close();
                MessageBox.Show(BTSEngine.ImportLog, "Import Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pass = true;
            }
            else
            {
                if (packageEntry.PackageEval)
                {
                    BTSEngine.PullFromPackage(packageEntry.Path, true);
                    pass = true;
                }
            }
            return pass;
        }

        private void bgwSave_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string file in packageEntry.FileList)
            {
                Decimal percentProgress = ((decimal) Array.IndexOf(packageEntry.FileList, file) + 1)/
                                          packageEntry.FileList.Length;
                BTSEngine.PullFromPackage(file, false);
                bgwSave.ReportProgress(Convert.ToInt32(percentProgress*100), file);
            }
        }

        private void bgwSave_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgWindow.Progress = e.ProgressPercentage;
            prgWindow.EventText = e.UserState.ToString();
        }
    }
}