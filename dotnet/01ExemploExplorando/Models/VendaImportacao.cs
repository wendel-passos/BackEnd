using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _01ExemploExplorando.Models
{
    public class VendaImportacao
    {
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public decimal? Desconto { get; set; }
        public DateTime DataVenda { get; set; }
        public VendaImportacao(int id, string produto, decimal preco, decimal? desconto, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            Desconto = desconto;
            DataVenda = dataVenda;
        }

    }
}
