using Aula0106.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula0106.Controllers
{
    public class VeiculoController
    {
        private MecanicaContainer contexto = new MecanicaContainer();

        public void InserirVeiculo(Carro carro)
        {
            contexto.Carros.Add(carro);
            contexto.SaveChanges();

        }
    }
}