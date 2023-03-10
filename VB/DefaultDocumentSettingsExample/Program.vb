Imports System
Imports System.Windows.Forms

Namespace DefaultDocumentSettingsExample

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
#Region "#main"
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            DevExpress.XtraRichEdit.RichEditControlCompatibility.DefaultFontSize = 8
            DevExpress.XtraRichEdit.RichEditControlCompatibility.DefaultFontName = "Tahoma"
            Call Application.Run(New Form1())
        End Sub
#End Region  ' #main
    End Module
End Namespace
