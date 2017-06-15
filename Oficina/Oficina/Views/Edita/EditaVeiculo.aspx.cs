using Oficina.Controllers;
using Oficina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Oficina.Views.Edita
{
    public partial class EditaVeiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClienteController clientes = new ClienteController();

                ddlCliente.DataSource = clientes.ListarClientes();

                ddlCliente.DataBind();

                txtDefeitoVeiculo.Text = Convert.ToString(Session["Defeito"]);
                txtDescricao.Text = Convert.ToString(Session["Descricao"]);
                txtMarcaVeiculo.Text = Convert.ToString(Session["Marca"]);
                txtPlacaVeiculo.Text = Convert.ToString(Session["Placa"]);
                     

            }

        }

        protected void btnSalvarVeiculo_Click(object sender, EventArgs e)
        {
            //Session["ClienteId"] = ddlCliente.SelectedValue;

            int idVeiculo = Convert.ToInt32(Session["CarroId"]);

            VeiculoController veiculo = new VeiculoController();

            Carro c = veiculo.BuscarCarroPorId(idVeiculo);

            c.ClienteId = Convert.ToInt32(ddlCliente.SelectedValue);
            c.Defeito = txtDefeitoVeiculo.Text;
            c.Marca = txtMarcaVeiculo.Text;
            c.Descricao = txtDescricao.Text;
            c.Placa = txtPlacaVeiculo.Text;

            veiculo.EditarVeiculo(c);
        }
    }
}