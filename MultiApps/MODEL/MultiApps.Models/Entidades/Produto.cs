﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiApps.Models.Entidades;
using MultiApps.Models.Entidades.Abstract;

namespace MultiApps.Models.Entidades
{
    internal class Produto : EntidadeBase
    {
        public int categoriaId { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public Categoria Categoria { get; set; }
    }
}
