<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P01PrzetwarzanieAsynchroniczne.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="jquery-3.6.0.min.js"></script>
    <script src="DefaultJS.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <p>Podjeście standardowe bez asynchronicznosci </p>
        
        <asp:Button ID="btnPrzeslijNaSerwer" OnClick="btnPrzeslijNaSerwer_Click" runat="server" Text="Prześlij" />
       
        <asp:TextBox ID="txtLiczba1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtLiczba2" runat="server"></asp:TextBox>


        <asp:TextBox ID="txtWynik" runat="server"></asp:TextBox>

        <p>Podejscie asynchroniczne</p>

        <input type="button" id="btnPrzyciskHTML" value="Prześli na serwer asynchronicznie" />
        <input type="text" id="txtLiczba1HTML" />
        <input type="text" id="txtLiczba2HTML" />

        <input type="text" id="txtWynikHTML" />

    </form>
</body>
</html>
