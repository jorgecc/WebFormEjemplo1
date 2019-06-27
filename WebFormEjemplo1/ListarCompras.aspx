<%@ Page Title="" Language="C#" MasterPageFile="~/MaestraBootstrap.Master" AutoEventWireup="true" CodeBehind="ListarCompras.aspx.cs" Inherits="WebFormEjemplo1.ListarCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True">
        <Columns>
            <asp:BoundField DataField="Usuario.NombreCuenta" HeaderText="Usuario" />
            <asp:BoundField DataField="Producto" HeaderText="Producto" />
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
        </Columns>
    </asp:GridView>
    <p>
    </p>

</asp:Content>

