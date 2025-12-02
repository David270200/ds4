<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="Laboratorio202.Default" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Matriz N x N (diagonal inversa = 1)</h2>

    <p>Introduce N (entero positivo):</p>
    <asp:TextBox ID="txtN" runat="server" Width="100px"></asp:TextBox>
    <asp:Button ID="btnGenerar" runat="server" Text="Generar" OnClick="btnGenerar_Click" />

    <asp:Label ID="lblError" runat="server" Visible="false" ForeColor="Red"></asp:Label>

    <br /><br />

    <asp:Literal ID="litMatriz" runat="server"></asp:Literal>

    <!-- estilos para que la tabla se vea mejor -->
    <style>
        .matriz-table {
            border-collapse: collapse;
            margin-top: 10px;
        }
        .matriz-table td {
            border: 1px solid #444;
            padding: 6px 10px;
            text-align: center;
            min-width: 28px;
        }
        .matriz-table .uno {
            background: #e6f7ff;
            font-weight: bold;
        }
    </style>

</asp:Content>
