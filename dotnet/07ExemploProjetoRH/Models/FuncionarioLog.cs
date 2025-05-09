using System;
using System.Text.Json;

namespace _07ExemploProjetoRH.Models
{
    public class FuncionarioLog
    {
        public FuncionarioLog() { }

        public FuncionarioLog(Funcionario funcionario, TipoAcao tipoAcao)
        {
            FuncionarioId = funcionario.Id;
            Nome = funcionario.Nome;
            Endereco = funcionario.Endereco;
            Ramal = funcionario.Ramal;
            EmailProfissional = funcionario.EmailProfissional;
            Departamento = funcionario.Departamento;
            Salario = funcionario.Salario;
            DataAdmissao = funcionario.DataAdmissao;
            TipoAcao = tipoAcao;
            JSON = JsonSerializer.Serialize(funcionario);
            Timestamp = DateTimeOffset.UtcNow;
        }

        public int Id { get; set; } // ID único do log
        public int FuncionarioId { get; set; } // FK para Funcionario

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Ramal { get; set; }
        public string EmailProfissional { get; set; }
        public string Departamento { get; set; }
        public decimal Salario { get; set; }
        public DateTimeOffset? DataAdmissao { get; set; }

        public TipoAcao TipoAcao { get; set; }
        public string JSON { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
    }
}
