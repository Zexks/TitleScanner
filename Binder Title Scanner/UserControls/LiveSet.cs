using System;
using System.Windows.Forms;
using BTS.Engines;

namespace BTS.UserControls
{
    public partial class LiveSet : UserControl
    {
        public LiveSet()
        {
            InitializeComponent();
        }

        public bool LiveEval
        {
            get
            {
                if (txtBid.Text.Equals(string.Empty))
                {
                    Messaging.ThrowException("Binder GUID", new Exception("Please enter a valid Binder GUID."));
                    return false;
                }
                if (txtFileRoom.Text.Equals(string.Empty))
                {
                    Messaging.ThrowException("File Room GUID", new Exception("Please enter a valid File Room GUID."));
                    return false;
                }
                return true;
            }
        }

        public string FileRoom
        {
            get { return txtFileRoom.Text; }
        }

        public string BID
        {
            get { return txtBid.Text; }
        }
    }
}