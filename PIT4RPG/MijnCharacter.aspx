<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MijnCharacter.aspx.cs" Inherits="PIT4RPG.MijnCharacter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Naam: <asp:Label ID="lbNaam" runat="server" Text="Label"></asp:Label><br/>
        Leeftijd: <asp:Label ID="lbLeeftijd" runat="server" Text="Label"></asp:Label>
        <br />
        Levens: <asp:Label ID="lbLevens" runat="server" Text="Label"></asp:Label>
        <br/>
        Uitrusting:<br/>
        <asp:ListBox ID="lbxUitrusting" runat="server" Width="300px"></asp:ListBox>
    </div>
    </form>
</body>
</html>
