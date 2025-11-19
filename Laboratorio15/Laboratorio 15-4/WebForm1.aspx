<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_15_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 185px">
    <form id="form1" runat="server">
        <div style="height: 35px">
            Introduzca 2 numeros</div>
        <asp:TextBox ID="TextBox1" runat="server" Width="60px"></asp:TextBox>
&nbsp;&nbsp; +&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="60px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sumar" />
        <p id="Label2"  runat="server" style="height: 67px; width: 260px">
            &nbsp;</p>
    </form>
</body>
</html>
