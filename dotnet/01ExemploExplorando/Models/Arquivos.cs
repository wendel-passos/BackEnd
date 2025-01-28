using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01ExemploExplorando.Models
{
    public class Arquivos
    {
        public void LeituraDeArquivos ()
        {

            try
            {
                string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Ocorreu uma exceção genérica. Diretório não encontrado {ex.Message}"); 
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ocorreu uma exceção genérica. Arquivo não encontrado {ex.Message}"); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}"); 
            }
            finally
            {
                Console.WriteLine("Chegou até aqui");
            }
        }
    }
}