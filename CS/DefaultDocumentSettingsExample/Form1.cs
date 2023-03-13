using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace DefaultDocumentSettingsExample
{
    public partial class Form1 : RibbonForm
    {

        public Form1() {
            InitializeComponent();
            richEditControl1.EmptyDocumentCreated += RichEditControl1_EmptyDocumentCreated;
            richEditControl1.DocumentClosing += RichEditControl1_DocumentClosing;
            richEditControl1.DocumentLoaded += RichEditControl1_DocumentLoaded;
        }

        private void RichEditControl1_DocumentLoaded(object sender, EventArgs e) {
            Document document = richEditControl1.Document;
            document.DefaultCharacterProperties.FontName = "Arial";
            document.DefaultCharacterProperties.FontSize = 16;
        }

        private void RichEditControl1_EmptyDocumentCreated(object sender, EventArgs e) {
            Document document = richEditControl1.Document;
            document.DefaultCharacterProperties.ForeColor = Color.Red;
            document.DefaultParagraphProperties.Alignment = ParagraphAlignment.Center;
            document.AppendText("Document created at " + DateTime.Now.ToLongTimeString());
        }

        private void RichEditControl1_DocumentClosing(object sender, CancelEventArgs e) {
            e.Cancel = (MessageBox.Show("Discard the document?", "RichEditControl.DocumentClosing", MessageBoxButtons.YesNo) == DialogResult.No);
        }

        private void barBtnShowMoreForm_ItemClick(object sender, ItemClickEventArgs e) {
            RichEditForm frm = new RichEditForm();
            frm.Show();
        }

        private void barBtnLoadDoc_ItemClick(object sender, ItemClickEventArgs e) {
            foreach (var item in Application.OpenForms) {
                XtraForm frm = item as XtraForm;
                if (frm != null) {
                    RichEditControl rich = frm.Controls["richEditControl1"] as RichEditControl;
                    if (rich != null) {
                        rich.LoadDocument("richtext.txt");
                    }
                }
            }
        }

        private void barBtnNewDoc_ItemClick(object sender, ItemClickEventArgs e) {
            richEditControl1.CreateNewDocument(true);
        }
    }
}
