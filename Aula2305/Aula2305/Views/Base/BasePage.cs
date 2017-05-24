using Aula2305.Models;

namespace Aula2305.Views.Base
{
    public class BasePage : System.Web.UI.Page
    {
        // contexto (referencia para o banco de dados)
        protected LojaEntities contexto = new LojaEntities();
        
    }
}