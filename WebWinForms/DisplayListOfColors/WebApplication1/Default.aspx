<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Koliko boja: "></asp:Label>
        <asp:TextBox ID="txtBrojBoja" runat="server" TextMode="Number"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator" runat="server" ControlToValidate="txtBrojBoja" Display="Dynamic" ErrorMessage="Unesti broj od 1 - 10" ForeColor="Red" MaximumValue="10" MinimumValue="1" Type="Integer"></asp:RangeValidator>
        <asp:Button ID="btnPrikaziPoljaZaUnosBoja" runat="server" Text="Prikaži polja" OnClick="btnPrikaziPoljaZaUnosBoja_Click" />
        <br />
        <br />
        <asp:PlaceHolder ID="ph" runat="server"></asp:PlaceHolder>
    </div>
        <asp:BulletedList ID="blUneseneBoje" runat="server">
        </asp:BulletedList>
    </form>
</body>
</html>
