Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit
Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraRichEdit.API.Native

Namespace DefaultDocumentSettingsExample
    Partial Public Class Form1
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
            AddHandler richEditControl1.EmptyDocumentCreated, AddressOf RichEditControl1_EmptyDocumentCreated
            AddHandler richEditControl1.DocumentClosing, AddressOf RichEditControl1_DocumentClosing
            AddHandler richEditControl1.DocumentLoaded, AddressOf RichEditControl1_DocumentLoaded
        End Sub

        Private Sub RichEditControl1_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl1.Document.DefaultCharacterProperties.FontName = "Arial"
            richEditControl1.Document.DefaultCharacterProperties.FontSize = 16
        End Sub

        Private Sub RichEditControl1_EmptyDocumentCreated(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl1.Document.DefaultCharacterProperties.ForeColor = Color.Red
            richEditControl1.Document.DefaultParagraphProperties.Alignment = ParagraphAlignment.Center
            richEditControl1.Document.AppendText("Document created at " & Date.Now.ToLongTimeString())
        End Sub

        Private Sub RichEditControl1_DocumentClosing(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = (MessageBox.Show("Discard the document?", "RichEditControl.DocumentClosing", MessageBoxButtons.YesNo) = DialogResult.No)
        End Sub


        Private Sub barBtnShowMoreForm_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barBtnShowNewForm.ItemClick
            Dim frm As New RichEditForm()
            frm.Show()
        End Sub

        Private Sub barBtnLoadDoc_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barBtnLoadDoc.ItemClick
            For Each item In Application.OpenForms
                Dim frm As XtraForm = TryCast(item, XtraForm)
                If frm IsNot Nothing Then
                    Dim rich As RichEditControl = TryCast(frm.Controls("richEditControl1"), RichEditControl)
                    If rich IsNot Nothing Then
                        rich.LoadDocument("richtext.txt")
                    End If
                End If
            Next item
        End Sub

        Private Sub barBtnNewDoc_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barBtnNewDoc.ItemClick
            richEditControl1.CreateNewDocument(True)
        End Sub
    End Class
End Namespace
