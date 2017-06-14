<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditaCliente.aspx.cs" Inherits="Aula0106.Views.Cliente.EditaCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
            <asp:Button ID="btnAlterarCliente" runat="server" Text="Alterar" />
    </div>

</asp:Content>
