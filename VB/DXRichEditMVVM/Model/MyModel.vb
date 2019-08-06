Imports System.Data.Entity

Namespace DXRichEditMVVM.Model

	Partial Public Class MyModel
		Inherits DbContext

		Public Sub New()
			MyBase.New("name=MyModel")
		End Sub

		Public Overridable Property Cars() As DbSet(Of Car)

		Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
			modelBuilder.Entity(Of Car)().Property(Function(e) e.Price).HasPrecision(19, 4)
		End Sub
	End Class
End Namespace
