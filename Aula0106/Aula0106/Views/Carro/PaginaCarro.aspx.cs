using Aula0106.Controllers;
using Aula0106.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula0106.Views
{
    public partial class PaginaCarro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClienteController clientes = new ClienteController();

                ddlCliente.DataSource = clientes.ListarClientes();

                ddlCliente.DataBind();
            }
        }

        protected void btnSalvarVeiculo_Click(object sender, EventArgs e)
        {
            Session["ClienteId"] = ddlCliente.SelectedValue;
            Session["Defeito"] = txtDefeitoVeiculo.Text;
            Session["Descricao"] = txtDescricao.Text;
            Session["Marca"] = txtMarcaVeiculo.Text;
            Session["Placa"] = txtPlacaVeiculo.Text;

            VeiculoController carros = new VeiculoController();

            Carro carro = new Carro();


            carro.Marca = Session["Marca"].ToString();
            carro.Defeito = Session["Defeito"].ToString();
            carro.Placa = Session["Placa"].ToString();
            carro.ClienteId = Convert.ToInt32(Session["ClienteId"].ToString());
            carro.Descricao = Session["Descricao"].ToString();
            //carro.Clientes.Id???
            carros.InserirVeiculo(carro);
        }
    }
}