using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class ValidacoesString
    {
        public int ContaCaracteres(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return 0;
            }
            return texto.Length;
        }
    }
}