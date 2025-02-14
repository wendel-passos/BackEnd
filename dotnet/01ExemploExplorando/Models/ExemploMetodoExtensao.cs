using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01ExemploExplorando.Models
{
    public static class ExemploMetodoExtensao
    {
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}