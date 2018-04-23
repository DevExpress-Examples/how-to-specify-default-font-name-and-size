using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DefaultDocumentSettingsExample {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {

        public Form1() {
            InitializeComponent();
            richEditControl1.EmptyDocumentCreated += RichEditControl1_EmptyDocumentCreated;
            richEditControl1.DocumentClosing += RichEditControl1_DocumentClosing;
            richEditControl1.DocumentLoaded += RichEditControl1_DocumentLoaded;
        }

        #region #DocumentLoaded
        private void RichEditControl1_DocumentLoaded(object sender, EventArgs e) {
            richEditControl1.Document.DefaultCharacterProperties.FontName = "Arial";
            richEditControl1.Document.DefaultCharacterProperties.FontSize = 16;
        }
        #endregion #DocumentLoaded

        #region #EmptyDocumentCreated
        private void RichEditControl1_EmptyDocumentCreated(object sender, EventArgs e) {
            richEditControl1.Document.DefaultCharacterProperties.ForeColor = Color.Red;
            richEditControl1.Document.DefaultParagraphProperties.Alignment = DevExpress.XtraRichEdit.API.Native.ParagraphAlignment.Center;
            richEditControl1.Document.AppendText("Document created at " + DateTime.Now.ToLongTimeString());
        }
        #endregion #EmptyDocumentCreated

        private void RichEditControl1_DocumentClosing(object sender, CancelEventArgs e) {
            e.Cancel = (MessageBox.Show("Discard the document?", "RichEditControl.DocumentClosing", MessageBoxButtons.YesNo) == DialogResult.No);
        }


        #region ButtonActions
        private void barBtnShowMoreForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            RichEditForm frm = new RichEditForm();
            frm.Show();
        }

        private void barBtnLoadDoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
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

        private void barBtnNewDoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            richEditControl1.CreateNewDocument(true);
        }
        #endregion ButtonActions
    }
}
