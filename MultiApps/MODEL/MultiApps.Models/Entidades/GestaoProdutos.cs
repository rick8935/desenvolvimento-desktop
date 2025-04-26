using MultiApps.Models.Entidades.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiApps.Models.Entidades
{
    public class GestaoProdutos : EntidadeBase
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public string ImagemLink { get; set; }
        public string Preco { get; set; }
        public string Estoque { get; set; }
    }
}
