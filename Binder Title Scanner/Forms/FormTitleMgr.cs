using System;
using System.Data;
using System.Windows.Forms;
using BTS.Engines;

namespace BTS.Forms
{
    public partial class FormTitleMgr : Form
    {
        public FormTitleMgr()
        {
            InitializeComponent();
            DisplayTitles();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addTitle = new FormTitle();
            addTitle.ShowDialog();
            DisplayTitles();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var editTitle = new FormTitle(SelectedTitle());
            editTitle.ShowDialog();
            DisplayTitles();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Are you sure you wish to delete this title?", "Delete Title", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                BTSEngine.DeleteTitle(SelectedTitle().Guid);
                DisplayTitles();
            }
        }

        private Title SelectedTitle()
        {
            return new Title(dgvTitles.SelectedRows[0].Cells["GUID"].Value.ToString(),
                dgvTitles.SelectedRows[0].Cells["Name"].Value.ToString(),
                dgvTitles.SelectedRows[0].Cells["Version"].Value.ToString(),
                dgvTitles.SelectedRows[0].Cells["Year"].Value.ToString());
        }

        private void DisplayTitles()
        {
            dgvTitles.DataSource = null;
            DataTable tblTitles = BTSEngine.BuildTable(false);
            BTSEngine.Titles.ForEach(t => tblTitles.Rows.Add(BTSEngine.BuildRow(tblTitles.NewRow(), t, false, false)));
            dgvTitles.DataSource = tblTitles;
        }
    }
}