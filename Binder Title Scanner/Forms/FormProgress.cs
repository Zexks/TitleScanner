using System.ComponentModel;
using System.Windows.Forms;

namespace BTS.Forms
{
    public partial class FormProgress : Form
    {
        public FormProgress(BackgroundWorker bgw)
        {
            InitializeComponent();
            bgw.RunWorkerAsync();
        }

        public int Progress
        {
            get { return pbarTitleProgress.Value; }
            set { pbarTitleProgress.Value = value; }
        }

        public string EventText
        {
            get { return lblEventText.Text; }
            set { lblEventText.Text = value; }
        }

        public bool Complete
        {
            get
            {
                if (pbarTitleProgress.Value >= 100)
                {
                    return true;
                }
                return false;
            }
        }
    }
}