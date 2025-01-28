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

Arquivos arquivo = new();
arquivo.LeituraDeArquivos();

ExemploExcecao exemploExcecao = new();
exemploExcecao.Metodo1();

ExemploFila exemploFila = new();
exemploFila.FilaDeInteiros();

ExemploPilha exemploPilha = new();
exemploPilha.PilhaDeInteiro();

ExemploDictionary exemploDictionary = new();
exemploDictionary.DictionaryDeString();

ExemploDeTupla exemploDeTupla = new();
exemploDeTupla.TuplaNaVariavel();
exemploDeTupla.TuplaChamandoClasse();
exemploDeTupla.TuplaNaVariavelDeInicializacao();

LeituraArquivo arquivo2 = new();

var (sucesso, linhasArquivo, _) = arquivo2.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    //Console.WriteLine($"Quantidade linhas do arquivo:{quantidadelinhas}");
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);  
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}

Pessoa p5 = new (nome: "Wendel", sobrenome: "Passos", idade: 27);

(string nome, string sobrenome) = p5;

Console.WriteLine($"{nome} {sobrenome}");

ExemploIfTernario exemploIfTernario = new();
exemploIfTernario.Ternario();