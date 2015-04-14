<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebProductControl.ascx.cs" Inherits="WebShop.WebProductControl" %>

<fieldset>
    <asp:Label ID="lblID" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is required" ControlToValidate="txtName"></asp:RequiredFieldValidator>
    <br />
    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Date is required" ControlToValidate="txtDate"></asp:RequiredFieldValidator>
    &nbsp;&nbsp;&nbsp;
    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Wrong date format" Type="Date" ControlToValidate="txtDate" Operator="DataTypeCheck"></asp:CompareValidator>
    <br />
    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Price is required" ControlToValidate="txtPrice"></asp:RequiredFieldValidator>
    
    <br />
    
    <asp:Button ID="btnAction" runat="server" Text="Button" />

    <br />
    <br />
</fieldset>

<asp:ValidationSummary ID="ValidationSummary1" runat="server" />


