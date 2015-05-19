<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaakCharacter.aspx.cs" Inherits="PIT4RPG.MaakCharacter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Klasse: <asp:DropDownList ID="ddlKlasse" runat="server"></asp:DropDownList><br/>
        Naam: <asp:TextBox ID="tbNaam" runat="server"></asp:TextBox><br/>
        <asp:Button ID="btMaakCharacter" runat="server" Text="Maak aan" OnClick="btMaakCharacter_Click" />
    </div>
    </form>
</body>
</html>
