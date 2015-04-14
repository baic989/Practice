<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserHeaderControl.ascx.cs" Inherits="WebShop.WebUserHeaderControl" %>
<asp:LoginView ID="LoginView1" runat="server">
    <AnonymousTemplate>
        You are not logged in.
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
    </AnonymousTemplate>
    <LoggedInTemplate>
        Hello, <asp:LoginName ID="LoginName1" runat="server" />&nbsp
        <asp:LoginStatus ID="LoginStatus2" runat="server" />&nbsp
        <asp:LinkButton ID="lbCart" runat="server" OnClick="lbCart_Click">See Cart</asp:LinkButton>
    </LoggedInTemplate>
</asp:LoginView>
&nbsp;&nbsp;&nbsp;
Total: <asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
