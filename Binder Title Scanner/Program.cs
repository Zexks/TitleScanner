using System;
using System.Windows.Forms;
using BTS.Engines;
using BTS.Forms;

namespace BTS
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            BTSEngine.LoadTitles();
            BTSEngine.TitleDoc.Load(BTSEngine.HomeDir + "\\Titles.xml");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
