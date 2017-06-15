<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditaVeiculo.aspx.cs" Inherits="Oficina.Views.Edita.EditaVeiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    </br>
    <div class="row">
        <div class="col-md-3">
            <asp:Label ID="lblCliente" runat="server" Text="Cliente"></asp:Label>
        </div>
        <div class="col-md-9">
            <asp:DropDownList ID="ddlCliente" runat="server" DataTextField="Nome" DataValueField="Id"></asp:DropDownList>
        </div>
    </div>
    </br>
    <div class="row">
        <div class="col-md-3">
            <asp:Label ID="lblMarcaVeiculo" runat="server" Text="Marca Veiculo"></asp:Label>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtMarcaVeiculo" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:Label ID="lblPlacaVeiculo" runat="server" Text="Placa Veiculo"></asp:Label>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtPlacaVeiculo" runat="server"></asp:TextBox>
        </div>
    </div>
    </br>
    <div class="row">
        <div class="col-md-6">
            <asp:Label ID="lblDescricao" runat="server" Text="Descricao"></asp:Label></div>

        <div class="col-md-6">
            <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox></div>
    </div>
    <div class="row">
        <div class="col-md-2">
            <asp:Label ID="lblDefeitoVeiculo" runat="server" Text="Defeito Veiculo"></asp:Label>
        </div>
        <div class="col-md-10">
            <asp:TextBox ID="txtDefeitoVeiculo" runat="server" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12"></div>
        <asp:Button ID="btnSalvarVeiculo" runat="server" Text="Alterar" OnClick="btnSalvarVeiculo_Click" />
    </div>

</asp:Content>
