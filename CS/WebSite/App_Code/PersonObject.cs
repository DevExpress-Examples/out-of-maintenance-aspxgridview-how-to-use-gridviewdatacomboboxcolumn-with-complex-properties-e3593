using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

public class Person {
    public int Id { get; set; }

    [DisplayName("Contac Name")]
    public string ContactName { get; set; }

    [DisplayName("Company Name")]
    public string CompanyName { get; set; }

    public City City { get; set; }
}

public class City {
    public int Id { get; set; }

    [DisplayName("City")]
    public string Name { get; set; }
}