using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefaultDocumentSettingsExample {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.XtraRichEdit.RichEditControlCompatibility.UseThemeFonts = false;
            DevExpress.XtraRichEdit.RichEditControlCompatibility.DefaultFontSize = 8;
            DevExpress.XtraRichEdit.RichEditControlCompatibility.DefaultFontName = "Tahoma";
            Application.Run(new Form1());
        }
    }
}
