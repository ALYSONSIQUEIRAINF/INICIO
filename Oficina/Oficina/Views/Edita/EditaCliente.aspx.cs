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
    public partial class EditaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtCpfCliente.Text = Convert.ToString(Session["CPF"]);
                txtNomeCliente.Text = Convert.ToString(Session["Nome"]);
                txtSobreNomeCliente.Text = Convert.ToString(Session["SobreNome"]);
            }
            

        }

        protected void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(Session["ClienteId"]);
            
            ClienteController clientes = new ClienteController();

            Cliente c = clientes.BuscarClientePorId(idCliente);


            c.CPF = txtCpfCliente.Text;
            c.Nome = txtNomeCliente.Text;
            c.SobreNome = txtSobreNomeCliente.Text;
            
            clientes.EditarCliente(c);
        }
    }
}