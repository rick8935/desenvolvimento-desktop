﻿using MultiApps.Models.Entidades.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiApps.Models.Entidades
{
    public class Usuario : EntidadeBase
    {

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

    }
}
