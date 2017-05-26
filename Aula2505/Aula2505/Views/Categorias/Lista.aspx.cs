using Aula2505.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2505.Views.Categorias
{
    public partial class Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //BaseDadosContainer contexto = new BaseDadosContainer();

            // gvCategorias.DataSource = categorias.ToList();

            // gvCategorias.DataBind();

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

            Session["Nome"] = txtNome.Text;
            Session["Descricao"] = txtDescricao.Text;
            Session["Ativo"] = ckbAtivo.Checked;

            BaseDadosContainer contexto = new BaseDadosContainer();

            Categoria categoria = new Categoria();

            categoria.Nome = Session["Nome"].ToString();
            categoria.Descricao = Session["Descricao"].ToString();
            categoria.Ativo = Convert.ToBoolean(Session["Ativo"].ToString());
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }
    }
}