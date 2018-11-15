<!-- default file list -->
*Files to look at*:

* [PersonObject.cs](./CS/WebSite/App_Code/PersonObject.cs) (VB: [PersonObject.vb](./VB/WebSite/App_Code/PersonObject.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - How to use GridViewDataComboBoxColumn with complex properties 


<p>When GridViewDataComboBoxColumn uses complex properties, it is necessary to define the following properties:<br />
 - GridViewDataComboBoxColumn.FieldName - Object.ID;<br />
 - PropertiesComboBox.TextField - an object's name;<br />
- PropertiesComboBox.ValueField - an object's ID;<br />
 - PropertiesComboBox.ValueType should be set according to the <a href="http://msdn.microsoft.com/en-us/library/cc716729.aspx"><u>Data Type Mappings (ADO.NET) table</u></a>.</p><p><strong>See also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E171">How to show a complex property value in a column's DataItemTemplate</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E3591">ASPxGridView - How to bind GridViewDataComboBoxColumn at runtime</a></p>

<br/>


