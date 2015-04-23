<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MzPage.aspx.cs" Inherits="CachePractice.MzPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <asp:BulletedList ID="blArtikli" runat="server">
    </asp:BulletedList>

    <asp:Label ID="lblVrijeme" runat="server" Text="Label"></asp:Label>
</asp:Content>
