using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayExemplos.Models
{
    public class Arrays
    {
        public void ArraysInteiros (){

            int [] arrayInt = new int [4];
            arrayInt[0] = 72;
            arrayInt[1] = 64;
            arrayInt[2] = 50;
            arrayInt[3] = 3;
            int contadorForeach = 0;

            //Redimencionamento temporário do Array
            //Array.Resize(ref arrayInt, arrayInt.Length * 2);

            int [] arrayIntDobrado = new int [arrayInt.Length * 2];
            Array.Copy (arrayInt,arrayIntDobrado, arrayInt.Length);

            //Percorrendo array com FOR
            for (int contador = 0; contador < arrayInt.Length; contador++)
            {
                Console.WriteLine($"Posição N° {contador} - {arrayInt [contador]}");
            }

            //Percorrendo array com FOREACH
            foreach (int valor in arrayIntDobrado)
            {
            Console.WriteLine ($"Posião N° {contadorForeach} - {valor}");
            contadorForeach++;
            }

        }
    }
}