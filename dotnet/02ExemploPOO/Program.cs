using _02ExemploPOO.Models;

Pessoa p = new();

p.Nome = "Wendel";
p.Idade = 27;
p.Apresentar();

ContaCorrente c = new(numeroConta: 123, saldoInicial: 1000);
c.Sacar(1500);
c.ExibirSaldo();

Aluno aluno = new ();

aluno.Nome = "Giovanna";
aluno.Idade = 27;
aluno.Nota = 10;
aluno.Apresentar();

Professor professor = new();
professor.Nome = "Sidnei";
professor.Idade = 46;
professor.Salario = 5000;
professor.Apresentar();