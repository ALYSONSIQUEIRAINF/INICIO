using Oficina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Oficina.Controllers
{
    public class ClienteController
    {
        private MecanicaContainer contexto = new MecanicaContainer();

        public void AdicionarCliente(Cliente cliente)
        {
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();
        }

        public Cliente BuscarClientePorId(int id)
        {
            return contexto.Clientes.Find(id);
        }

        public List<Cliente> ListarClientes()
        {
            return contexto.Clientes.ToList();
        }

        public bool EditarCliente(Cliente cliente)
        {
            try
            {
                contexto.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void ExcluirCliente(Cliente cliente)
        {
            contexto.Entry(cliente).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }
        
    }
}