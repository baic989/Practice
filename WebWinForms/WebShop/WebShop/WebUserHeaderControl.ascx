<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserHeaderControl.ascx.cs" Inherits="WebShop.WebUserHeaderControl" %>
<asp:LoginView ID="LoginView1" runat="server">
    <AnonymousTemplate>
        You are not logged in.
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
    </AnonymousTemplate>
    <LoggedInTemplate>
        Hello, <asp:LoginName ID="LoginName1" runat="server" />&nbsp
        <asp:LoginStatus ID="LoginStatus2" runat="server" />
    </LoggedInTemplate>
</asp:LoginView>
