using Aula0106.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula0106.Controllers
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

        public void EditarCliente(Cliente cliente)
        {
            contexto.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void ExcluirCliente(Cliente cliente)
        {
            contexto.Entry(cliente).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }
    }
}