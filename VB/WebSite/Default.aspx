﻿<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>How to use GridViewDataComboBoxColumn with complex properties</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" EnableRowsCache="false"
			KeyFieldName="Id">
			<Columns>
				 <dx:GridViewDataTextColumn FieldName="ContactName" ShowInCustomizationForm="True"
					VisibleIndex="0">
				</dx:GridViewDataTextColumn>
				<dx:GridViewDataTextColumn FieldName="CompanyName" ShowInCustomizationForm="True"
					VisibleIndex="1">
				</dx:GridViewDataTextColumn>
				<dx:GridViewDataComboBoxColumn FieldName="City.Id" VisibleIndex="2">
					<PropertiesComboBox TextField="Name" ValueField="Id" ValueType="System.Int32" DropDownStyle="DropDown">
					</PropertiesComboBox>
				</dx:GridViewDataComboBoxColumn>
			</Columns>
			<Settings ShowFilterRow="true" />
		</dx:ASPxGridView>
	</div>
	</form>
</body>
</html>