<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="Oficina.Views.CadastroCliente.CadastroCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <div class="row">
        <div class="col-md-2">
            <asp:Label ID="lblNomeCliente" runat="server" Text="Nome"></asp:Label></div>
        <div class="col-md-2">
            <asp:TextBox ID="txtNomeCliente" runat="server"></asp:TextBox></div>
        <div class="col-md-2">
            <asp:Label ID="lblSobreNomeCliente" runat="server" Text="SobreNome"></asp:Label></div>
        <div class="col-md-2">
            <asp:TextBox ID="txtSobreNomeCliente" runat="server"></asp:TextBox></div>
        <div class="col-md-2">
            <asp:Label ID="lblCpfCliente" runat="server" Text="CPF"></asp:Label></div>
        <div class="col-md-2">
            <asp:TextBox ID="txtCpfCliente" runat="server"></asp:TextBox></div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:Button ID="btnSalvarCliente" runat="server" Text="Salvar" OnClick="btnSalvarCliente_Click" /></div>
    </div>
    </br>
    <div class="row">
        <div class="col-md-12">
            <asp:Button ID="btnListarClientes" runat="server" Text="Listar" OnClick="btnListarClientes_Click" /></div>
    </div>

</asp:Content>
