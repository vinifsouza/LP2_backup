﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTesteClasses
{
    class Mensalista : Empregado
    {
        public double SalarioMensal { get; set; }

        // sobreescrendo o método
        public override double SalarioBruto()
        {
            return (SalarioMensal);
        }
    }
    
}