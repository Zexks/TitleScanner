using System;
using System.Windows.Forms;
using BTS.Engines;

namespace BTS.UserControls
{
    public partial class ManualEntry : UserControl
    {
        public ManualEntry()
        {
            InitializeComponent();
        }

        public Title TitleEntry
        {
            get { return new Title(txtGuid.Text, txtTitle.Text, txtVersion.Text, txtYear.Text); }
            set
            {
                Title t = value;
                txtGuid.Text = t.Guid;
                txtTitle.Text = t.Name;
                txtVersion.Text = t.Version;
                txtYear.Text = t.Year;
            }
        }

        public bool ValidateTextControls()
        {
            if (txtTitle.Text.Equals(string.Empty))
            {
                Messaging.ThrowException("Invalid Title", new Exception("Please enter a valid Title name"));
                return false;
            }
            if (txtGuid.Text.Equals(string.Empty))
            {
                Messaging.ThrowException("Invalid GUID", new Exception("Please enter a valid GUID"));
                return false;
            }
            if (txtVersion.Text.Equals(string.Empty))
            {
                Messaging.ThrowException("Invalid Version", new Exception("Please enter a valid Version"));
                return false;
            }
            if (txtYear.Text.Equals(string.Empty))
            {
                Messaging.ThrowException("Invalid Year", new Exception("Please enter a valid Year"));
                return false;
            }
            return true;
        }

        public void ClearEntries()
        {
            txtGuid.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtVersion.Text = string.Empty;
            txtYear.Text = string.Empty;
        }
    }
}