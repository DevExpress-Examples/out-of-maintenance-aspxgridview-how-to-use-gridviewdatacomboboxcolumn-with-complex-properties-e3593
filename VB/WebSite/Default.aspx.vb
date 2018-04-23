Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.Web.ASPxGridView

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private objPersons As New List(Of Person)()
	Private listCities As New List(Of City)()

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)

		Dim objPerson As New Person()
		objPerson.Id = 1
		objPerson.ContactName = "Maria Anders"
		objPerson.CompanyName = "Alfreds Futterkiste"
		objPerson.City = New City()
		objPerson.City.Id = 11
		objPerson.City.Name = "Berlin"

		listCities.Add(objPerson.City)
		objPersons.Add(objPerson)

		objPerson = New Person()
		objPerson.Id = 2
		objPerson.ContactName = "Thomas Hardy"
		objPerson.CompanyName = "Around the Horn"
		objPerson.City = New City()
		objPerson.City.Id = 12
		objPerson.City.Name = "	London"

		listCities.Add(objPerson.City)
		objPersons.Add(objPerson)

		ASPxGridView1.DataSource = objPersons
		TryCast(ASPxGridView1.Columns("City.Id"), GridViewDataComboBoxColumn).PropertiesComboBox.DataSource = listCities
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ASPxGridView1.DataBind()
		End If
	End Sub
End Class