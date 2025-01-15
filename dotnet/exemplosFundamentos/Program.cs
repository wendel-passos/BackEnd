using exemplosFundamentos.Models;

Pessoa pessoa1 = new Pessoa ();

pessoa1.Nome = "Wendel";
pessoa1.Idade = 26;
pessoa1.Apresentar();

//------------------ Exemplos Conversões ------------------------------
// Cast - Casting
int a = Convert.ToInt32("5");
Console.WriteLine ($"valor do cast:{a}");

// ToString
int inteiro = 10;
string aa = inteiro.ToString();
Console.WriteLine ($"valor do inteiro:{aa}");

// TryParse
string aaa = "15-";

int b = 0;

int.TryParse (aaa, out b );

Console.WriteLine (b);


//------------------ Exemplos Condicionais ------------------------------

int quantidadeEmEstoque = 3;
int quantidadeCompra =  0;
bool validaVenda = quantidadeEmEstoque >= quantidadeCompra && quantidadeCompra > 0;

Console.WriteLine ($"Quantidade em estoque {quantidadeEmEstoque}");
Console.WriteLine ($"Quantidade Comprada {quantidadeCompra}");
Console.WriteLine ($"É possível realizar a venda ? {validaVenda}");

if (!validaVenda)
{
        Console.WriteLine ("Venda Invalida");
}
else if (validaVenda)
{
    Console.WriteLine ("Venda Realizada.");
}
else
{
    Console.WriteLine ("Quantidade indisponível");
}


//--------Exemplo case------------------

Console.WriteLine ("Digite uma letra");
string letra = Console.ReadLine();

if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")
{
    Console.WriteLine ("É uma vogal");
}
else 
{
    Console.WriteLine ("Não é uma vogal");
}







