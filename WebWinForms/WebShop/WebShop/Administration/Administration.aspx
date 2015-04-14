<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administration.aspx.cs" Inherits="WebShop.Administration.Administration" %>

<%@ Register Src="~/WebUserHeaderControl.ascx" TagPrefix="uc1" TagName="WebUserHeaderControl" %>
<%@ Register Src="~/WebProductControl.ascx" TagPrefix="uc1" TagName="WebProductControl" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:WebUserHeaderControl runat="server" ID="WebUserHeaderControl" />
        <asp:Panel ID="pnlAdd" runat="server"></asp:Panel>
        <asp:Panel ID="pnlEdit" runat="server"></asp:Panel>
    </div>
    </form>
</body>
</html>
