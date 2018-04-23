using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Web.ASPxGridView;

public partial class _Default : System.Web.UI.Page {
    List<Person> objPersons = new List<Person>();
    List<City> listCities = new List<City>();

    protected void Page_Init (object sender, EventArgs e) {

        Person objPerson = new Person();
        objPerson.Id = 1;
        objPerson.ContactName = "Maria Anders";
        objPerson.CompanyName = "Alfreds Futterkiste";
        objPerson.City = new City();
        objPerson.City.Id = 11;
        objPerson.City.Name = "Berlin";

        listCities.Add(objPerson.City);
        objPersons.Add(objPerson);

        objPerson = new Person();
        objPerson.Id = 2;
        objPerson.ContactName = "Thomas Hardy";
        objPerson.CompanyName = "Around the Horn";
        objPerson.City = new City();
        objPerson.City.Id = 12;
        objPerson.City.Name = "	London";

        listCities.Add(objPerson.City);
        objPersons.Add(objPerson);

        ASPxGridView1.DataSource = objPersons;
        (ASPxGridView1.Columns["City.Id"] as GridViewDataComboBoxColumn).PropertiesComboBox.DataSource = listCities;
    }

    protected void Page_Load (object sender, EventArgs e) {
        if (!IsPostBack)
            ASPxGridView1.DataBind();
    }
}