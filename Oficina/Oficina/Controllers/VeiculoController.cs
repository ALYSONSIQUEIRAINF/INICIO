using Oficina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Oficina.Controllers
{
    public class VeiculoController
    {
        private MecanicaContainer contexto = new MecanicaContainer();

        public void InserirVeiculo(Carro carro)
        {
            contexto.Carros.Add(carro);
            contexto.SaveChanges();

        }

        public List<Carro> ListarVeiculos()
        {
            return contexto.Carros.ToList();
        }

        public Carro BuscarCarroPorId(int id)
        {
            return contexto.Carros.Find(id);
        }

        public void ExcluirVeiculo(Carro carro)
        {
            contexto.Entry(carro).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

        public bool EditarVeiculo(Carro carro)
        {
            try
            {
                contexto.Entry(carro).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}