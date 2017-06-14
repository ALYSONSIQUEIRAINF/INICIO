<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="Aula0106.Views.Lista.Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    </br>

    <asp:GridView ID="grvClientes" runat="server" OnRowCommand="grvClientes_RowCommand" OnSelectedIndexChanged="grvClientes_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField CommandName="Excluir" Text="Excluir" />
            <asp:ButtonField CommandName="Editar" Text="Editar" />

        </Columns>
    </asp:GridView>

</asp:Content>
