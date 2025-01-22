using operadoresAritmeticos.Models;

Calculadora calc = new();

calc.Somar(5,5);
calc.Subtrair(5,5);
calc.Multiplicar(5,5);
calc.Dividir(5,5);
calc.Potencia (9,9);
calc.Seno (30);
calc.Coseno (30);
calc.Tangente (30);

//-------------Incremento-------------------
int numero = 10;
Console.WriteLine (numero);
Console.WriteLine ("Mais 1");
numero++;
Console.WriteLine (numero);
numero--;
Console.WriteLine ("Menos 1");
Console.WriteLine (numero);
calc.RaizQuadrada (9);
