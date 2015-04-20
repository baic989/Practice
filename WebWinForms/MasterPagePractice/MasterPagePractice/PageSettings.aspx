<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PageSettings.aspx.cs" Inherits="MasterPagePractice.PageSettings" Culture="auto" meta:resourcekey="PageResource1" UICulture="auto" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div>
        <asp:Label ID="lblTheme" runat="server" Text="Theme:" meta:resourcekey="lblThemeResource1"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlTheme" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTheme_SelectedIndexChanged" meta:resourcekey="ddlThemeResource1">
            <asp:ListItem Value="-" meta:resourcekey="ListItemResource1">Select theme</asp:ListItem>
            <asp:ListItem Value="blue" meta:resourcekey="ListItemResource2">Blue</asp:ListItem>
            <asp:ListItem Value="red" meta:resourcekey="ListItemResource3">Red</asp:ListItem>
        </asp:DropDownList>

        <br />
        <asp:Label ID="lblLang" runat="server" Text="Language:" meta:resourcekey="lblLangResource1"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlLang" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLang_SelectedIndexChanged" meta:resourcekey="ddlLangResource1">
            <asp:ListItem Value="-" meta:resourcekey="ListItemResource4">--- Select ---</asp:ListItem>
            <asp:ListItem Value="hr" meta:resourcekey="ListItemResource5">Croatian</asp:ListItem>
            <asp:ListItem Value="en" meta:resourcekey="ListItemResource6">English</asp:ListItem>
        </asp:DropDownList>
    </div>
</asp:Content>
