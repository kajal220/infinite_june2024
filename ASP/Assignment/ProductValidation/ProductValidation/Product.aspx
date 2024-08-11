<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="ProductValidation.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Car Selector</title>
    <style>
        .error { color: red; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <div>
               <h1>Car Selector</h1>
            <asp:DropDownList ID="ddlCars" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCars_SelectedIndexChanged">
                <asp:ListItem Text="--Select--" Value="" />
                <asp:ListItem Text="Tesla Model S" Value="1" DataValueField="79999" DataImageUrl="~/images/C:\Batch_june2024\ASP\Tesla.jpg" />
                <asp:ListItem Text="Ford Mustang" Value="2" DataValueField="55999" DataImageUrl="~/images/C:\Batch_june2024\ASP\Ford Mustang.jpg" />
                <asp:ListItem Text="BMW M3" Value="3" DataValueField="69999" DataImageUrl="~/images/C:\Batch_june2024\ASP\BMW.jpg" />
            </asp:DropDownList>
            <br /><br />
            <asp:Image ID="imgCar" runat="server" Width="400px" Height="250px" />
            <br /><br />
            <asp:Label ID="lblPrice" runat="server" Text="Price: $" />
            <br /><br />
            <asp:TextBox ID="txtName" runat="server" Placeholder="Name" />
            <br /><br />
            <asp:TextBox ID="txtFamilyName" runat="server" Placeholder="Family Name" />
            <br /><br />
            <asp:TextBox ID="txtAddress" runat="server" Placeholder="Address" />
            <br /><br />
            <asp:TextBox ID="txtCity" runat="server" Placeholder="City" />
            <br /><br />
            <asp:TextBox ID="txtZipCode" runat="server" Placeholder="Zip-Code" />
            <br /><br />
            <asp:TextBox ID="txtPhone" runat="server" Placeholder="Phone" />
            <br /><br />
            <asp:TextBox ID="txtEmail" runat="server" Placeholder="Email" />
            <br /><br />
            <asp:Button ID="btnGetPrice" runat="server" Text="Get Price" OnClick="btnGetPrice_Click" />
            <br /><br />
            <asp:Label ID="lblValidationErrors" runat="server" CssClass="error" />
        </div>
    </form>
</body>
</html>
