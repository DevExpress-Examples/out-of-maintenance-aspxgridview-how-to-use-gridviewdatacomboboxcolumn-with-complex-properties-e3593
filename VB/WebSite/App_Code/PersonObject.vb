Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.ComponentModel

Public Class Person
	Private privateId As Integer
	Public Property Id() As Integer
		Get
			Return privateId
		End Get
		Set(ByVal value As Integer)
			privateId = value
		End Set
	End Property

	Private privateContactName As String
	<DisplayName("Contac Name")> _
	Public Property ContactName() As String
		Get
			Return privateContactName
		End Get
		Set(ByVal value As String)
			privateContactName = value
		End Set
	End Property

	Private privateCompanyName As String
	<DisplayName("Company Name")> _
	Public Property CompanyName() As String
		Get
			Return privateCompanyName
		End Get
		Set(ByVal value As String)
			privateCompanyName = value
		End Set
	End Property

	Private privateCity As City
	Public Property City() As City
		Get
			Return privateCity
		End Get
		Set(ByVal value As City)
			privateCity = value
		End Set
	End Property
End Class

Public Class City
	Private privateId As Integer
	Public Property Id() As Integer
		Get
			Return privateId
		End Get
		Set(ByVal value As Integer)
			privateId = value
		End Set
	End Property

	Private privateName As String
	<DisplayName("City")> _
	Public Property Name() As String
		Get
			Return privateName
		End Get
		Set(ByVal value As String)
			privateName = value
		End Set
	End Property
End Class