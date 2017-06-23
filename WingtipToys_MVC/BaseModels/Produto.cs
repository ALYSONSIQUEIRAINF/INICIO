using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModels
{
    class Produto
    {
        public int ProdutoID { get; set; }
        [Required]
        [StringLength(20)]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        [Required]
        public bool Ativo { get; set; }

        //--Relacionando Categoria --> Produto
        public int CategoriaID { get; set; }
        public virtual Categoria _Categoria { get; set; }
    }
}
