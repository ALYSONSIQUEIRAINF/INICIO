using Oficina.Controllers;
using Oficina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Oficina.Views.CadastroVeiculo
{
    public partial class ListaVeiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VeiculoController veiculos = new VeiculoController();

            grvVeiculos.DataSource = veiculos.ListarVeiculos();

            grvVeiculos.DataBind();
        }

        protected void grvVeiculos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int linha = Convert.ToInt32(e.CommandArgument);

            // Recuperando o id do Objeto (lembrando que 2, do Cells[2], é a coluna onde esta o id)
            int idObjeto = Convert.ToInt32(grvVeiculos.Rows[linha].Cells[2].Text);

            // Nome do comando para saber a acao
            string command = e.CommandName;

            // Proximos passos

            // adicionar id na Session

            if (command.Equals("Excluir"))
            {
                // Redirecionando para tela de exclusao
                //Response.Redirect("Excluir.aspx");

                VeiculoController veiculos = new VeiculoController();
                Carro carro = veiculos.BuscarCarroPorId(idObjeto);
                veiculos.ExcluirVeiculo(carro);
                //clientes.ExcluirCliente(idObjeto);
            }
            else
            {
                if (command.Equals("Editar"))
                {
                    // Redirecionando para tela de edicao

                    VeiculoController veiculos = new VeiculoController();
                    Carro carro = veiculos.BuscarCarroPorId(idObjeto);

                    Session["CarroId"] = carro.Id;
                    Session["Marca"] = carro.Marca;
                    Session["Placa"] = carro.Placa;
                    Session["Defeito"] = carro.Defeito;
                    Session["Descricao"] = carro.Descricao;
                    Session["ClienteId"] = carro.ClienteId;
                    Response.Redirect("~/Views/Edita/EditaVeiculo.aspx");
                }
            }
        }
    

        protected void grvVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}