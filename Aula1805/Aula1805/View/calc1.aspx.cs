using Aula1805.DAL;
using Aula1805.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1805.View
{
    public partial class calc1 : System.Web.UI.Page
    {
        public string NomeUsuario {

            get
            {
                return ViewState["NomeUsuario"].ToString();
            }
            set
            {
                ViewState["NomeUsuario"] = value;
            }
        }      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NomeUsuario = "Godofredo";
            }
        }

        protected void btnResultado_Click(object sender, EventArgs e)
        {
            Session["Valor1"] = txtValor1.Text;
            Session["Valor2"] = txtValor2.Text;
            Response.Redirect("~/View/Calc2.aspx");

            
        }

        protected void btnMais_Click(object sender, EventArgs e)
        {

            ViewState["valor1"] = Convert.ToDouble(txtValor1.Text);
            ViewState["valor2"] = Convert.ToDouble(txtValor2.Text);


            double res = Convert.ToDouble(ViewState["valor1"]) + Convert.ToDouble(ViewState["valor2"]);
            lblResultado.Text = NomeUsuario + "  O resultado é " + res.ToString();


        }
    }
}