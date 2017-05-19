using Aula1805.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula1805.DAL
{
    public class ProjetoDAO
    {
        Projeto projeto = new Projeto();

        public double CalcularNumeros(double valor1,double valor2)
        {
            double resultado = valor1 + valor2;
            return resultado;
        }
    }
}