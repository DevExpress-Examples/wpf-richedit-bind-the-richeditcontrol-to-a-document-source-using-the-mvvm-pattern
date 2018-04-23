Imports DXRichEditMVVM.Model
Imports System
Imports System.Collections.Generic
Imports System.Data.Entity
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DXRichEditMVVM.ViewModel
    Public Class ViewModel
        #Region "#ViewModel"
        Private carsModel As MyModel
        Private car As Car

        Public Overridable Property DataBaseDocumentSource() As Object
        Public Sub New()
            'Load the database
            carsModel = New MyModel()
            carsModel.Cars.Load()
            'Use the rtf content from the first database entry
            'and pass it to the DataBaseDocumentSource property
            car = carsModel.Cars.Local(0)
            DataBaseDocumentSource = car.RtfContent
        End Sub
        #End Region ' #ViewModel

        #Region "#UpdateRtfText"
        Private currentText As String
        Public Sub UpdateRtfText(ByVal text As String)
            Me.currentText = text
        End Sub
        #End Region ' #UpdateRtfText

        #Region "#SaveCommand"
        Public Sub Save()
            'Access the table entry by its model name
            Dim newCar As Car = carsModel.Cars.Where(Function(d) d.Model = "SL500 Roadster").First()

            'Set its Rtf property to the current content
            newCar.RtfContent = currentText
            carsModel.SaveChanges()

            'Reset the current content
            currentText = Nothing
        End Sub
        Public Function CanSave() As Boolean
            Return currentText IsNot Nothing
        End Function
        #End Region ' #SaveCommand
    End Class
End Namespace
