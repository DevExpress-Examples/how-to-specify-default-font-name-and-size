Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace DefaultDocumentSettingsExample
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        #Region "#main"
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            DevExpress.XtraRichEdit.RichEditControlCompatibility.DefaultFontSize = 8
            DevExpress.XtraRichEdit.RichEditControlCompatibility.DefaultFontName = "Tahoma"
            Application.Run(New Form1())
        End Sub
        #End Region ' #main
    End Class
End Namespace
