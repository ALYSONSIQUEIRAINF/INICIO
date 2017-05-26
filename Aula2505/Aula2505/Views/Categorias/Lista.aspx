<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="Aula2505.Views.Categorias.Lista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <div class="row">
            </br>
        <div class="col-md-2">
            <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
            </div>
            <div class="col-md-3">
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-2">
                <asp:Label ID="lblDescricao" runat="server" Text="Descricao:"></asp:Label>
            </div>
            <div class="col-md-3">
                <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-1">
                <asp:Label ID="lvlAtivo" runat="server" Text="Ativo?"></asp:Label>
            </div>
            <div class="col-md-1">
                <asp:CheckBox ID="ckbAtivo" runat="server" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" /></div>
        </div>
    </asp:UpdatePanel>

</asp:Content>
