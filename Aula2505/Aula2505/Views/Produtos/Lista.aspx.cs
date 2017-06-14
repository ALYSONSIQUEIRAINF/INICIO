using Aula2505.Controllers;
using Aula2505.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2505.Views.Produtos
{
    public partial class Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //BaseDadosContainer contexto = new BaseDadosContainer();

            //var categorias = contexto.Categorias;
            if (!IsPostBack)
            {
                CategoriasController categorias = new CategoriasController();

                ddlCategoria.DataSource = categorias.ListarCategoria();

                ddlCategoria.DataBind();
            }


        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {


            Session["Nome"] = txtNome.Text;
            Session["Descricao"] = txtDescricao.Text;
            Session["Ativo"] = ckbAtivo.Checked;
            Session["CategoriaId"] = ddlCategoria.SelectedValue;

            BaseDadosContainer contexto = new BaseDadosContainer();

            //var ID = "Lista Carregada com sucesso";
            

            Produto produto = new Produto();

            produto.Nome = Session["Nome"].ToString();
            produto.Descricao = Session["Descricao"].ToString();
            produto.Ativo = Convert.ToBoolean(Session["Ativo"].ToString());
            produto.CategoriaId = Convert.ToInt32(Session["CategoriaId"].ToString());

            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }
    }
}