using Aula2505.Models;
using System.Collections.Generic;
using System.Linq;

namespace Aula2505.Controllers
{
    public class CategoriasController
    {
        private BaseDadosContainer contexto = new BaseDadosContainer();

        public void AdicionarCategoria(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        public List<Categoria> ListarCategoria()
        {
            return contexto.Categorias.ToList();
        }

        public Categoria LocalizarCategoriaPorID(int id)
        {
            return contexto.Categorias.Find(id);
        }

        public void editarCategoria(Categoria categoria)
        {
            contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        } 

        public void excluirCategoria(Categoria categoria)
        {
            contexto.Entry(categoria).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

    }
}