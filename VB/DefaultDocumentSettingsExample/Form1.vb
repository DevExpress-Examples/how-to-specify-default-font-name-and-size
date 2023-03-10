Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DefaultDocumentSettingsExample

    Public Partial Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            AddHandler richEditControl1.EmptyDocumentCreated, AddressOf RichEditControl1_EmptyDocumentCreated
            AddHandler richEditControl1.DocumentClosing, AddressOf RichEditControl1_DocumentClosing
            AddHandler richEditControl1.DocumentLoaded, AddressOf RichEditControl1_DocumentLoaded
        End Sub

#Region "#DocumentLoaded"
        Private Sub RichEditControl1_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl1.Document.DefaultCharacterProperties.FontName = "Arial"
            richEditControl1.Document.DefaultCharacterProperties.FontSize = 16
        End Sub

#End Region  ' #DocumentLoaded
#Region "#EmptyDocumentCreated"
        Private Sub RichEditControl1_EmptyDocumentCreated(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl1.Document.DefaultCharacterProperties.ForeColor = Color.Red
            richEditControl1.Document.DefaultParagraphProperties.Alignment = API.Native.ParagraphAlignment.Center
            richEditControl1.Document.AppendText("Document created at " & Date.Now.ToLongTimeString())
        End Sub

#End Region  ' #EmptyDocumentCreated
        Private Sub RichEditControl1_DocumentClosing(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = MessageBox.Show("Discard the document?", "RichEditControl.DocumentClosing", MessageBoxButtons.YesNo) = DialogResult.No
        End Sub

#Region "ButtonActions"
        Private Sub barBtnShowMoreForm_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Dim frm As RichEditForm = New RichEditForm()
            frm.Show()
        End Sub

        Private Sub barBtnLoadDoc_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            For Each item In Application.OpenForms
                Dim frm As XtraForm = TryCast(item, XtraForm)
                If frm IsNot Nothing Then
                    Dim rich As RichEditControl = TryCast(frm.Controls("richEditControl1"), RichEditControl)
                    If rich IsNot Nothing Then
                        rich.LoadDocument("richtext.txt")
                    End If
                End If
            Next
        End Sub

        Private Sub barBtnNewDoc_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            richEditControl1.CreateNewDocument(True)
        End Sub
#End Region  ' ButtonActions
    End Class
End Namespace
