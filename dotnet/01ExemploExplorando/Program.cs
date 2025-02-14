using _01ExemploExplorando.Models;
using Newtonsoft.Json;


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
DateTime dataAtual = DateTime.Now;
List<Venda> listaVendas = new();
Venda venda1 = new(1, "Material de escritorio", 25.00M,dataAtual);
Venda venda2 = new(2, "Material de contrucao", 200.00M, dataAtual);

listaVendas.Add(venda1);
listaVendas.Add(venda2);
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);


string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
List<VendaImportacao> listaVenda = JsonConvert.DeserializeObject<List<VendaImportacao>>(conteudoArquivo);

foreach (VendaImportacao venda in listaVenda)
{
    Console.WriteLine($"ID: {venda.Id}; Produto:{venda.Produto}; Preco:{venda.Preco}; " + 
                      $"{(venda.Desconto.HasValue ? $"Desconto de:{venda.Desconto}" : "") };Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")})");
}

var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

foreach (var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}

Email email = new();
email.ReceberEmail();

TiposAnonimos tp = new();
tp.ExemplosAnonimo();

ExemploArrayGenerico<int> arrayInteiro = new();

arrayInteiro.AdicionarElementoArray(30);
Console.WriteLine(arrayInteiro[0]);

int numero =  2;
bool par = false;

par = numero.EhPar();

string mensagem = ($"O número {numero} é {(par ? "par" : "impar")}");
Console.WriteLine(mensagem);