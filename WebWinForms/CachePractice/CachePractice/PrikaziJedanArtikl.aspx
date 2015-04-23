<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PrikaziJedanArtikl.aspx.cs" Inherits="CachePractice.PrikaziJedanArtikl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
    <asp:Button ID="btnPrikazi" runat="server" Text="Button" OnClick="btnPrikazi_Click" />
</asp:Content>
