using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1805.View
{
    public partial class Calc2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Verificar se nao é um PostBack
            if (!IsPostBack)
            {
                if(Session["Valor1"]!= null && Session["Valor2"] != null)
                {
                    ViewState["ResultadoMais"] = Convert.ToDouble(Session["Valor1"]) + Convert.ToDouble(Session["Valor2"]);
                    ViewState["ResultadoMenos"] = Convert.ToDouble(Session["Valor1"]) - Convert.ToDouble(Session["Valor2"]);
                    ViewState["ResultadoVezes"] = Convert.ToDouble(Session["Valor1"]) * Convert.ToDouble(Session["Valor2"]);

                    lblValor1Mais.Text = Convert.ToString(Session["Valor1"]);
                    lblValor2Mais.Text = Convert.ToString(Session["Valor2"]);
                    lblResultadoMais.Text = Convert.ToString(ViewState["ResultadoMais"]);

                    lblValor1Menos.Text = Convert.ToString(Session["Valor1"]);
                    lblValor2Menos.Text = Convert.ToString(Session["Valor2"]);
                    lblResultadoMenos.Text = Convert.ToString(ViewState["ResultadoMenos"]);

                    lblValor1Vezes.Text = Convert.ToString(Session["Valor1"]);
                    lblValor2Vezes.Text = Convert.ToString(Session["Valor2"]);
                    lblResultadoVezes.Text = Convert.ToString(ViewState["ResultadoVezes"]);
                }
            }else
            {
                Response.Redirect("~/View/calc1.aspx");
            }

            
        }
    }
}