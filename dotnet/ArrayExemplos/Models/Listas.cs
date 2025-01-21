using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayExemplos.Models
{
    public class Listas
    {
        
        public void ListaString ()
        {
            List<string> listaString = new ();
            
            listaString.Add ("SP");
            listaString.Add ("RJ");
            listaString.Add ("MG");

            for (int contador = 0; contador < listaString.Count; contador++)
            {
                Console.WriteLine ($"Posião N° {contador} - {listaString[contador]}");
            }

            int contadorForeach = 0;
            foreach (string lista in listaString)
            {
            Console.WriteLine ($"Posião N° {contadorForeach} - {lista}");  
            contadorForeach++;
            }

            Console.WriteLine ($"Itens da minha lista: {listaString.Count}  - Capacidade: {listaString.Capacity}");
            listaString.Add ("RS");
            listaString.Add ("MT");
            Console.WriteLine ($"Itens da minha lista: {listaString.Count}  - Capacidade: {listaString.Capacity}");
            listaString.Remove ("SP");
            Console.WriteLine ($"Itens da minha lista: {listaString.Count}  - Capacidade: {listaString.Capacity}");            
        }

    }
}