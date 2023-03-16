using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System.Linq;

namespace DefaultDocumentSettingsExample
{
    public partial class Form1 : RibbonForm
    {

        public Form1()
        {
            //set the default font for all RichEditControls in the application
            RichEditControlCompatibility.UseThemeFonts = false;
            RichEditControlCompatibility.DefaultFontSize = 12;
            RichEditControlCompatibility.DefaultFontName = "Times New Roman";
            InitializeComponent();

            richEditControl1.EmptyDocumentCreated += RichEditControl1_EmptyDocumentCreated;
            richEditControl1.DocumentLoaded += RichEditControl1_DocumentLoaded;
        }

        private void RichEditControl1_DocumentLoaded(object sender, EventArgs e)
        {
            //set the default font for the document loaded in the main RichEditControl
            Document document = richEditControl1.Document;
            document.DefaultCharacterProperties.FontName = "Arial";
            document.DefaultCharacterProperties.FontSize = 16;
        }

        private void RichEditControl1_EmptyDocumentCreated(object sender, EventArgs e)
        {
            //change the formatting for the newly-created document
            Document document = richEditControl1.Document;
            document.DefaultCharacterProperties.ForeColor = Color.Red;
            document.DefaultParagraphProperties.Alignment = ParagraphAlignment.Center;
            document.AppendText("Document created at " + DateTime.Now.ToLongTimeString());
        }
        private void barBtnShowMoreForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            RichEditForm frm = new RichEditForm();
            frm.Show();
        }

        private void barBtnLoadDoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var form in Application.OpenForms)
            {
                if (form is XtraForm)
                {
                    RichEditControl richEditControl = (form as XtraForm).Controls.OfType<RichEditControl>().FirstOrDefault();
                    if (richEditControl != null)
                        richEditControl.LoadDocument("richtext.txt");
                }
            }
        }

        private void barBtnNewDoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            richEditControl1.CreateNewDocument(true);
        }
    }
}
