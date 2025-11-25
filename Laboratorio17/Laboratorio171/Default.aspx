<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio171._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

        <div class="row">
           <div>
               <asp:GridView id="MyGridView" DataSourceID="MyDataSource1"
                   AllowSorting="true" AllowPaging="true"
                   DataKeyNames="ProductID"
                   AutoGenerateEditButton="true"
                   Runat="server" />

               <asp:SqlDataSource ID="MyDataSource1" runat="server"
                   ConnectionString="Data source=localhost\SQLEXPRESS;initial catalog=northwind;persist security info=true;Integrated Security=SSPI;"
                   ProviderName="System.Data.SqlClient"
                   SelectCommand="SELECT ProductId, ProductName, UnitPrice From Products"
                   UpdateCommand="Update products Set [ProductName]=@ProductName, [UnitPrice]=@UnitPrice where [ProductId]=@ProductId">
               </asp:SqlDataSource>
           </div>
        </div>
</asp:Content>
