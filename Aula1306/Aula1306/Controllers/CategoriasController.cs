using Aula1306.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Aula1306.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            //usando viewbag
            //List<string> categorias = new List<string>();
            //categorias.Add("Carros");
            //categorias.Add("Motos");
            //categorias.Add("Barcos");
            //categorias.Add("Avioes");
            //categorias.Add("Caminhoes");

            //ViewBag.ListaCategorias = categorias;

            List<Categoria> categorias = new List<Categoria>();
            categorias.Add(new Categoria() { Nome = "Carros"});
            categorias.Add(new Categoria() { Nome = "Motos" });
            categorias.Add(new Categoria() { Nome = "Barcos" });
            categorias.Add(new Categoria() { Nome = "Caminhoes" });
            categorias.Add(new Categoria() { Nome = "Avioes" });

            return View(categorias);
        }
    }
}