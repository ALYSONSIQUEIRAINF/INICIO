using Oficina.Controllers;
using Oficina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Oficina.Views.CadastroCliente
{
    public partial class CadastroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            Session["Nome"] = txtNomeCliente.Text;
            Session["SobreNome"] = txtSobreNomeCliente.Text;
            Session["CPF"] = txtCpfCliente.Text;

            ClienteController clientes = new ClienteController();

            Cliente cliente = new Cliente();

            cliente.Nome = Session["Nome"].ToString();
            cliente.SobreNome = Session["SobreNome"].ToString();
            cliente.CPF = Session["CPF"].ToString();
            if(!string.IsNullOrEmpty(txtNomeCliente.Text) && 
                !string.IsNullOrEmpty(txtSobreNomeCliente.Text) &&
                !string.IsNullOrEmpty(txtCpfCliente.Text))
            {
                clientes.AdicionarCliente(cliente);
            }else
            {
                
            }
           
        }

        protected void btnListarClientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/CadastroCliente/ListaClientes.aspx");
        }
    }
}