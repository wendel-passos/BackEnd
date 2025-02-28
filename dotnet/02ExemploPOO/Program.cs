using _02ExemploPOO.Models;

Pessoa p = new();

p.Nome = "Wendel";
p.Idade = 27;
p.Apresentar();

ContaCorrente c = new(numeroConta: 123, saldoInicial: 1000);
c.Sacar(1500);
c.ExibirSaldo();