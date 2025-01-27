using _01ExemploExplorando.Models;


Pessoa pessoa1 = new (nome: "Wendel", sobrenome: "Passos", idade: 27);
Console.WriteLine("Cadastro de pessoas:");
pessoa1.Apresentar();

Pessoa pessoa2 = new(nome: "Giovanna",sobrenome: "Petrica", idade: 27);
pessoa2.Apresentar();

Curso cursoDeSi = new();
cursoDeSi.Nome = "SI";
cursoDeSi.Alunos = new List<Pessoa>();
cursoDeSi.AdicionarAluno(pessoa1);
cursoDeSi.AdicionarAluno(pessoa2);
cursoDeSi.ListarAlunos();

Formatacao formatacao = new();
formatacao.ValorMonetario(valor: 1500.50M);
formatacao.ValorMonetarioCultura(valor: 1700.50M);
formatacao.Porcentagem(valor: .494);
formatacao.ConcatenacaoPersonalizada(valor: 13345678);
formatacao.FormatacaoData();
formatacao.FormatacaoDataValidada("2022-12-17 18:00");