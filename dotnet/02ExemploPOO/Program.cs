using _02ExemploPOO.Models;
using _02ExemploPOO.Models.Interfaces;

Pessoa p = new("Wendel");
p.Idade = 27;
p.Apresentar();

ContaCorrente c = new(numeroConta: 123, saldoInicial: 1000);
c.Sacar(1500);
c.ExibirSaldo();

Aluno aluno = new ("Giovanna");
aluno.Idade = 27;
aluno.Nota = 10;
aluno.Apresentar();

Professor professor = new ("Sidnei");
professor.Idade = 46;
professor.Salario = 5000;
professor.Apresentar();

Corrente cc = new();

cc.Creditar(500);
cc.ExibirSaldo();

ICalculadora calc = new Calculadora();
Console.WriteLine (calc.Dividir(2, 2));