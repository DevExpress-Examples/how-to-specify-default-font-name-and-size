<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611284/19.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1398)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# How to Specify Default Document Formatting

This example illustrates two methods to specify default document formatting. The project contains two RichEditControl instances that use different default formatting options.

The main RichEditControl uses parameters specified by the [Document.DefaultCharacterProperties](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.Document.DefaultCharacterProperties) and [Document.DefaultParagraphProperties](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.Document.DefaultParagraphProperties) options in the [RichEditControl.DocumentLoaded](https://docs.devexpress.com/WindowsForms/DevExpress.XtraRichEdit.RichEditControl.DocumentLoaded) event handler.

The **New Document** button executes the [CreateNewDocument](https://docs.devexpress.com/WindowsForms/DevExpress.XtraRichEdit.RichEditControl.CreateNewDocument(System.Boolean)) method that, in turn, raises the [EmptyDocumentCreated](https://docs.devexpress.com/WindowsForms/DevExpress.XtraRichEdit.RichEditControl.EmptyDocumentCreated) event. In the event handler, the document is generated with another set of default settings specified by the [Document.DefaultCharacterProperties](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.Document.DefaultCharacterProperties) and [Document.DefaultParagraphProperties](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.Document.DefaultParagraphProperties) properties.

The **Show New Editor** button invokes the other RichEditControl instance that uses default settings specified by the [RichEditControlCompatibility.DefaultFontName](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.RichEditControlCompatibility.DefaultFontName) and [RichEditControlCompatibility.DefaultFontSize](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.RichEditControlCompatibility.DefaultFontSize) properties on application startup.

> **Warning**
>
> Starting with v19.2, the `RichEditControl` uses document themes to retrieve default document font information. As such, the `RichEditControlCompatibility.DefaultFontName` property will no longer affect the default document font.
>
> Set the [RichEditControlCompatibility.UseThemeFonts](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.RichEditControlCompatibility.UseThemeFonts) property to `false` when starting the application to restore the previous behavior in all instances of the RichEdit components. Set the [RichEditBehaviorOptions.UseThemeFonts](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.RichEditBehaviorOptions.UseThemeFonts) property to `false` before loading a new document to disable themes for a specific component.

The **Load Text Document** button loads a document to both RichEditControl instances. As a result, the document has different format options in each instance.

![result](./media/image.png)

## Files to Look At

* [Form1.cs](./CS/DefaultDocumentSettingsExample/Form1.cs) (VB: [Form1.vb](./VB/DefaultDocumentSettingsExample/Form1.vb))
* [Program.cs](./CS/DefaultDocumentSettingsExample/Program.cs) (VB: [Program.vb](./VB/DefaultDocumentSettingsExample/Program.vb))

## Documentation

* [Text Formatting](https://docs.devexpress.com/WindowsForms/117433/controls-and-libraries/rich-text-editor/text-formatting)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-specify-default-font-name-and-size&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-specify-default-font-name-and-size&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
