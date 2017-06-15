<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaVeiculos.aspx.cs" Inherits="Oficina.Views.CadastroVeiculo.ListaVeiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="grvVeiculos" runat="server" OnRowCommand="grvVeiculos_RowCommand" OnSelectedIndexChanged="grvVeiculos_SelectedIndexChanged" Width="341px">
        <Columns>
            <asp:ButtonField CommandName="Excluir" Text="Excluir" />
            <asp:ButtonField CommandName="Editar" Text="Editar" />

        </Columns>
    </asp:GridView>

</asp:Content>
