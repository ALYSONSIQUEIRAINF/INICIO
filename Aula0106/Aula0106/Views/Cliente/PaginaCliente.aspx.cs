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
    public partial class PaginaCliente : System.Web.UI.Page
    {

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

            clientes.AdicionarCliente(cliente);


        }
        
    }
}