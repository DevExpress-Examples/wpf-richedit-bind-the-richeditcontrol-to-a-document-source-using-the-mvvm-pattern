<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128607440/17.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T611845)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Rich Text Editor for WPF - How to Bind the RichEditControl to a Document Source using the MVVM Pattern

The following code example shows how to use the MVVM pattern to bind RichEditControl to a data source.

## Implementation Details

The **Car** and **CarModel** classes represent the model. These classes are implemented using the Entity Framework Code First From the Database approach. The ViewModel provides the functionality to load the RTF content from the database and save the changes made to the text.

## Files to Review

| C# | Visual Basic |
|---------|----------|
| [MainWindow.xaml](./CS/DXRichEditMVVM/MainWindow.xaml) | [MainWindow.xaml](./VB/DXRichEditMVVM/MainWindow.xaml) |
| [MainWindow.xaml.cs](./CS/DXRichEditMVVM/MainWindow.xaml.cs) | [MainWindow.xaml.vb](./VB/DXRichEditMVVM/MainWindow.xaml.vb) |
| [Car.cs](./CS/DXRichEditMVVM/Model/Car.cs) | [Car.vb](./VB/DXRichEditMVVM/Model/Car.vb) |
| [MyModel.cs](./CS/DXRichEditMVVM/Model/MyModel.cs) | [MyModel.vb](./VB/DXRichEditMVVM/Model/MyModel.vb) |
| [ViewModel.cs](./CS/DXRichEditMVVM/ViewModel/ViewModel.cs) | [ViewModel.vb](./VB/DXRichEditMVVM/ViewModel/ViewModel.vb) |

## Documentation

* [Bind the Rich Text Editor to a Document Source using the MVVM pattern](https://docs.devexpress.com/WPF/118466/controls-and-libraries/rich-text-editor/getting-started/bind-the-rich-edit-control-to-a-document-source-using-the-mvvm-pattern)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-richedit-bind-the-richeditcontrol-to-a-document-source-using-the-mvvm-pattern&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-richedit-bind-the-richeditcontrol-to-a-document-source-using-the-mvvm-pattern&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
