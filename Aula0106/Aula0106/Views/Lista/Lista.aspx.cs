using Aula0106.Controllers;
using Aula0106.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula0106.Views.Lista
{
    public partial class Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteController clientes = new ClienteController();

            grvClientes.DataSource = clientes.ListarClientes();

            grvClientes.DataBind();
        }

        protected void grvClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int linha = Convert.ToInt32(e.CommandArgument);

            // Recuperando o id do Objeto (lembrando que 2, do Cells[2], é a coluna onde esta o id)
            int idObjeto = Convert.ToInt32(grvClientes.Rows[linha].Cells[2].Text);

            // Nome do comando para saber a acao
            string command = e.CommandName;

            // Proximos passos

            // adicionar id na Session

            if (command.Equals("Excluir"))
            {
                // Redirecionando para tela de exclusao
                Response.Redirect("Excluir.aspx");

                ClienteController clientes = new ClienteController();
                Cliente cliente = clientes.BuscarClientePorId(idObjeto);
                clientes.ExcluirCliente(cliente);
                //clientes.ExcluirCliente(idObjeto);
            }
            else
            {
                if (command.Equals("Editar"))
                {
                    // Redirecionando para tela de edicao
                    ClienteController clientes = new ClienteController();
                    Cliente cliente = clientes.BuscarClientePorId(idObjeto);
                    Session["cliente"] = cliente;
                    Response.Redirect("~/Views/Cliente/EditaCliente.aspx");
                }
            }
        }

        protected void grvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}