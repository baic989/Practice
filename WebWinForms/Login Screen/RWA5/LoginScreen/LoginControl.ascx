<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="LoginScreen.LoginControl" %>

<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 120px;
    }
</style>


<table cellpadding="0.5" cellspacing="0" class="auto-style1">
    <tr>
        <td class="auto-style2" style="text-align: right">Username: </td>
        <td>
            <asp:TextBox ID="txtUsername" runat="server" Width="180px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" Display="Dynamic" ErrorMessage="Username is required!" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style2" style="text-align: right">Password: </td>
        <td>
            <asp:TextBox ID="txtPass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPass" Display="Dynamic" ErrorMessage="Password is required!" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style2" style="text-align: right">Repeat Password: </td>
        <td>
            <asp:TextBox ID="txtRepeatPass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtRepeatPass" Display="Dynamic" ErrorMessage="Password is required!" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPass" ControlToValidate="txtRepeatPass" Display="Dynamic" ErrorMessage="Passwords do not match!" ForeColor="Red">*</asp:CompareValidator>
        </td>
    </tr>
</table>


<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
</p>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />



