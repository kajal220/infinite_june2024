<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="ValidatorApp.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Validator</title>
    <style>
        .error-label {
            color: red;
        }
        .input-label {
            width: 150px;
            display: inline-block;
        }
        .text-box {
            width: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Insert your details:</h3>
            <table>
                <tr>
                    <td class="input-label">Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" CssClass="text-box"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="*" CssClass="error-label" Display="Static"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="input-label">Family Name:</td>
                    <td>
                        <asp:TextBox ID="txtFamilyName" runat="server" CssClass="text-box"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvFamilyName" runat="server" ControlToValidate="txtFamilyName" ErrorMessage="*" CssClass="error-label" Display="Static"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cvFamilyName" runat="server" ControlToValidate="txtFamilyName" ControlToCompare="txtName" Operator="NotEqual" ErrorMessage="differs from name" CssClass="error-label" Display="Static"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="input-label">Address:</td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server" CssClass="text-box"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="*" CssClass="error-label" Display="Static"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="at least 2 chars" CssClass="error-label" ValidationExpression=".{2,}" Display="Static"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="input-label">City:</td>
                    <td>
                        <asp:TextBox ID="txtCity" runat="server" CssClass="text-box"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="txtCity" ErrorMessage="*" CssClass="error-label" Display="Static"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revCity" runat="server" ControlToValidate="txtCity" ErrorMessage="at least 2 chars" CssClass="error-label" ValidationExpression=".{2,}" Display="Static"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="input-label">Zip Code:</td>
                    <td>
                        <asp:TextBox ID="txtZipCode" runat="server" CssClass="text-box"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvZipCode" runat="server" ControlToValidate="txtZipCode" ErrorMessage="*" CssClass="error-label" Display="Static"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revZipCode" runat="server" ControlToValidate="txtZipCode" ErrorMessage="valid range is 1000-999999" CssClass="error-label" ValidationExpression="^[1-9][0-9]{3,5}$" Display="Static"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="input-label">Phone:</td>
                    <td>
                        <asp:TextBox ID="txtPhone" runat="server" CssClass="text-box"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="txtPhone" ErrorMessage="*" CssClass="error-label" Display="Static"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone" ErrorMessage="(xxx-xxxxxxx)" CssClass="error-label" ValidationExpression="^(\(\d{3}\)\s\d{3}-\d{4}|\d{3}-\d{7})$" Display="Static"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="input-label">E-Mail:</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="text-box"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="*" CssClass="error-label" Display="Static"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="example@example.com" CssClass="error-label" ValidationExpression="^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$" Display="Static"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <asp:ValidationSummary ID="vsSummary" runat="server" CssClass="error-label" HeaderText="Validation Summary:" ShowMessageBox="true" ShowSummary="false" />
        </div>
    </form>
</body>
</html>