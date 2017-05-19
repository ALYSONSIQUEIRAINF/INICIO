<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calc2.aspx.cs" Inherits="Aula1805.View.Calc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="row">
            <div class="col-md-4"><asp:Label ID="lblValor1" runat="server" Text="Valor 1"></asp:Label></div>
            <div class="col-md-4"><asp:Label ID="lblValor2" runat="server" Text="Valor 2"></asp:Label></div>
            <div class="col-md-4"><asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label></div>

        </div>
        <div class="row">
            <div class="col-md-3"><asp:Label ID="lblValor1Mais" runat="server" Text=""></asp:Label></div>
            <div class="col-md-2"><asp:Label ID="lblMais" runat="server" Text="+"></asp:Label></div>
            <div class="col-md-3"><asp:Label ID="lblValor2Mais" runat="server" Text=""></asp:Label></div>
            <div class="col-md-1"><asp:Label ID="lblIgualMais" runat="server" Text="="></asp:Label></div>
            <div class="col-md-3"><asp:Label ID="lblResultadoMais" runat="server" Text=""></asp:Label></div>

        </div>
        <div class="row">
            <div class="col-md-3"><asp:Label ID="lblValor1Menos" runat="server" Text=""></asp:Label></div>
            <div class="col-md-2"><asp:Label ID="lblMenos" runat="server" Text="-"></asp:Label></div>
            <div class="col-md-3"><asp:Label ID="lblValor2Menos" runat="server" Text=""></asp:Label></div>
            <div class="col-md-1"><asp:Label ID="lblIgualMenos" runat="server" Text="="></asp:Label></div>
            <div class="col-md-3"><asp:Label ID="lblResultadoMenos" runat="server" Text=""></asp:Label></div>
        </div>

        <div class="row">
            <div class="col-md-3"><asp:Label ID="lblValor1Vezes" runat="server" Text=""></asp:Label></div>
            <div class="col-md-2"><asp:Label ID="lblVezes" runat="server" Text="*"></asp:Label></div>
            <div class="col-md-3"><asp:Label ID="lblValor2Vezes" runat="server" Text=""></asp:Label></div>
            <div class="col-md-1"><asp:Label ID="lblIgualVezes" runat="server" Text="="></asp:Label></div>
            <div class="col-md-3"><asp:Label ID="lblResultadoVezes" runat="server" Text=""></asp:Label></div>
        </div>

    </div>
</asp:Content>
