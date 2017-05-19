<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="calc1.aspx.cs" Inherits="Aula1805.View.calc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
    <div class="row">
        <div class="row">
            <div class="col-md-6"> <asp:Label ID="lblValor1" runat="server" Text="Valor1"></asp:Label> </div>
            <div class="col-md-6"> <asp:Label ID="lblValor2" runat="server" Text="Valor2"></asp:Label> </div> 
        </div>

        <div class="row">
            <div class="col-md-6"> <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox> </div>
            <div class="col-md-6"> <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox> </div>
        </div>

        <div class="row">
            <div class="col-md-8"> <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label> </div>
            <div class="col-md-2"> <asp:Button ID="btnMais" runat="server" Text="+" OnClick="btnMais_Click" /> </div>
            <div class="col-md-2"> <asp:Button ID="btnResultado" runat="server" Text="=" OnClick="btnResultado_Click" /> </div>
        </div>

    </div>
</asp:Content>
