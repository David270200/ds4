<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" 
    Inherits="Laboratorio201.Default" 
    MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Tabla de Multiplicar hasta 25</h2>

    Número:
    <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>

    <asp:Button ID="btnGenerar" runat="server" Text="Generar" OnClick="btnGenerar_Click" />

    <br /><br />

    <asp:Literal ID="litResultado" runat="server"></asp:Literal>

</asp:Content>