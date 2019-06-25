<%@ Page Title="" Language="C#" MasterPageFile="~/MaestraBootstrap.Master" AutoEventWireup="true" CodeBehind="WebListado.aspx.cs" Inherits="WebFormEjemplo1.WebListado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Listado de usuarios</h1>
    
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped">
</asp:GridView>
</asp:Content>
