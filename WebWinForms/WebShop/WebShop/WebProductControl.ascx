<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebProductControl.ascx.cs" Inherits="WebShop.WebProductControl" %>

<fieldset>
    <asp:Label ID="lblID" runat="server" Text="Label"></asp:Label>
    <asp:TextBox required ID="txtName" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
    <asp:Button ID="btnAction" runat="server" Text="Button" />
</fieldset>

<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
