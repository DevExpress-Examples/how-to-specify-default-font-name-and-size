<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DefaultDocumentSettingsExample/Form1.cs) (VB: [Form1.vb](./VB/DefaultDocumentSettingsExample/Form1.vb))
* [Program.cs](./CS/DefaultDocumentSettingsExample/Program.cs) (VB: [Program.vb](./VB/DefaultDocumentSettingsExample/Program.vb))
<!-- default file list end -->
# How to specify default document formatting


This example illustrates two methods to specify default document formatting.<br> 1. The <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraRichEditRichEditControlCompatibility_DefaultFontSizetopic">RichEditControlCompatibility.DefaultFontSize</a>, <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraRichEditRichEditControlCompatibility_DefaultFontNametopic">RichEditControlCompatibility.DefaultFontName</a> properties to specify default font settings for all RichEditControl  instances in the application.<br>2.  The <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeDocument_DefaultCharacterPropertiestopic">Document.DefaultCharacterProperties</a> and <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeDocument_DefaultParagraphPropertiestopic">Document.DefaultParagraphProperties</a> settings used in the <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_EmptyDocumentCreatedtopic">RichEditControl.EmptyDocumentCreated</a> and <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_DocumentLoadedtopic">RichEditControl.DocumentLoaded</a> event handlers to set default formatting for a document individually. 

<br/>


