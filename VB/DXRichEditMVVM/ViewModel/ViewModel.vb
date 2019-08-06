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
        Private modified As Boolean

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

#Region "#UpdateModified"
        Public Sub UpdateModified(ByVal Modified As Boolean)
            Me.modified = Modified
        End Sub
#End Region ' #UpdateModified

#Region "#SaveCommand"
        Public Sub Save(ByVal rtfText As String)
            'Access the table entry by its model name
            Dim newCar As Car = carsModel.Cars.Where(Function(d) d.Model = "SL500 Roadster").First()

            'Set its Rtf property to the current content
            newCar.RtfContent = rtfText
            
            carsModel.SaveChanges()
			
			modified = False

        End Sub
        Public Function CanSave(ByVal rtfText As String) As Boolean
            Return modified <> False
        End Function
#End Region ' #SaveCommand
    End Class
End Namespace
