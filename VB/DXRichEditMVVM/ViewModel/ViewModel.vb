Imports DXRichEditMVVM.Model
Imports System.Data.Entity
Imports System.Linq

Namespace DXRichEditMVVM.ViewModel

    Public Class ViewModel

#Region "#ViewModel"
        Private carsModel As MyModel

        Private car As Car

        Public Overridable Property DataBaseDocumentSource As Object

        Public Sub New()
            'Load the database
            carsModel = New MyModel()
            carsModel.Cars.Load()
            'Use the rtf content from the first database entry
            'and pass it to the DataBaseDocumentSource property
            car = carsModel.Cars.Local(0)
            DataBaseDocumentSource = car.RtfContent
        End Sub

#End Region  ' #ViewModel
#Region "#UpdateRtfText"
        Private modified As Boolean

        Public Sub UpdateModified(ByVal Modified As Boolean)
            Me.modified = Modified
        End Sub

#End Region  ' #UpdateRtfText
#Region "#SaveCommand"
        Public Sub Save(ByVal rtfText As String)
            'Access the table entry by its model name
            Dim newCar As Car = carsModel.Cars.Where(Function(d) Equals(d.Model, "SL500 Roadster")).First()
            'Set its Rtf property to the current content
            newCar.RtfContent = rtfText
            carsModel.SaveChanges()
            'Reset the current content
            modified = False
        End Sub

        Public Function CanSave(ByVal rtfText As String) As Boolean
            Return modified <> False
        End Function
#End Region  ' #SaveCommand
    End Class
End Namespace
