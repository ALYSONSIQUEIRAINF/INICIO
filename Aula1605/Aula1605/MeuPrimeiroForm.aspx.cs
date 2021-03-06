﻿using Aula1605.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1605
{
    public partial class MeuPrimeiroForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            chkAtivo.Checked = false;

            if (ViewState["controle"] == null)

                ViewState.Add("Controle", "1");

            else
            {
                int quantidadeClique = Convert.ToInt32(ViewState["controle"]);
                quantidadeClique++;
                ViewState["controle"] = quantidadeClique;
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Projeto projeto = new Projeto();
            projeto.Nome = txtNome.Text;
            projeto.Descricao = txtDescricao.Text;
            projeto.Ativo = chkAtivo.Checked;

            ViewState.Remove("controle");

        }
    }
}