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
            'set the default font for all RichEditControls in the application
            DevExpress.XtraRichEdit.RichEditControlCompatibility.UseThemeFonts = False
            DevExpress.XtraRichEdit.RichEditControlCompatibility.DefaultFontSize = 12
            DevExpress.XtraRichEdit.RichEditControlCompatibility.DefaultFontName = "Times New Roman"
            InitializeComponent()

            AddHandler richEditControl1.EmptyDocumentCreated, AddressOf RichEditControl1_EmptyDocumentCreated
            AddHandler richEditControl1.DocumentLoaded, AddressOf RichEditControl1_DocumentLoaded
        End Sub

        Private Sub RichEditControl1_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            'set the default font for the document loaded in the main RichEditControl
            richEditControl1.Document.DefaultCharacterProperties.FontName = "Arial"
            richEditControl1.Document.DefaultCharacterProperties.FontSize = 16
        End Sub

        Private Sub RichEditControl1_EmptyDocumentCreated(ByVal sender As Object, ByVal e As EventArgs)
            'change the formatting for the newly-created document
            richEditControl1.Document.DefaultCharacterProperties.ForeColor = Color.Red
            richEditControl1.Document.DefaultParagraphProperties.Alignment = ParagraphAlignment.Center
            richEditControl1.Document.AppendText("Document created at " & Date.Now.ToLongTimeString())
        End Sub

        Private Sub barBtnShowMoreForm_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barBtnShowNewForm.ItemClick
            Dim frm As New RichEditForm()
            frm.Show()
        End Sub

        Private Sub barBtnLoadDoc_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barBtnLoadDoc.ItemClick
            For Each form In Application.OpenForms
                If TypeOf form Is XtraForm Then
                    Dim richEditControl As RichEditControl = (TryCast(form, XtraForm)).Controls.OfType(Of RichEditControl)().FirstOrDefault()
                    If richEditControl IsNot Nothing Then richEditControl.LoadDocument("richtext.txt")
                End If
            Next form
        End Sub

        Private Sub barBtnNewDoc_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barBtnNewDoc.ItemClick
            richEditControl1.CreateNewDocument(True)
        End Sub
    End Class
End Namespace
