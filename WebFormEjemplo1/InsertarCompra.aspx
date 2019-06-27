<%@ Page Title="" Language="C#" MasterPageFile="~/MaestraBootstrap.Master" AutoEventWireup="true" CodeBehind="InsertarCompra.aspx.cs" Inherits="WebFormEjemplo1.InsertarCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 

    Producto:<asp:TextBox ID="TextBoxProducto" runat="server"></asp:TextBox><br />
    Cantidad:<asp:TextBox ID="TextBoxCantidad" runat="server"></asp:TextBox><br />
    Precio:<asp:TextBox ID="TextBoxPrecioUnitario" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <br />


</asp:Content>
