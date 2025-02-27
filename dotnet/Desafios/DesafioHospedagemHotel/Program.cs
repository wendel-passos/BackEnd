using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// // Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 100);

// Cria uma nova reserva, passando a suíte e os hóspedes
Console.WriteLine("Bem vindo a reserva de Hotel! \n" +
                  "Digite a quantidade de dias de reserva");
string diasReserva = Console.ReadLine();
Reserva reserva = new Reserva(diasReservados: Convert.ToInt32(diasReserva));
reserva.CadastrarSuite(suite);

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
Console.WriteLine("A reserva é para quantas pessoas ?");
int quantidadePessoas = Convert.ToInt32(Console.ReadLine());

for (int cont = 1; cont <= quantidadePessoas; cont++)
{
    Console.WriteLine("Digite os nomes dos hospedes:");
    string teste = Console.ReadLine();
    Pessoa p1 = new Pessoa(nome: teste);
    hospedes.Add(p1);

}
reserva.CadastrarHospedes(hospedes);



// // Cria uma nova reserva, passando a suíte e os hóspedes
// Reserva reserva = new Reserva(diasReservados: 10);
// reserva.CadastrarSuite(suite);
// reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Dias reservados: {reserva.DiasReservados}");
Console.WriteLine($"Valor total da reserva: {reserva.CalcularValorDiaria()}");



// // Cria os modelos de hóspedes e cadastra na lista de hóspedes
// List<Pessoa> hospedes = new List<Pessoa>();

// // Pessoa p1 = new Pessoa(nome: "Hóspede 1");
// // Pessoa p2 = new Pessoa(nome: "Hóspede 2");
// // Pessoa p3 = new Pessoa(nome: "Hóspede 3");

// for (int cont = 0; cont <= 2; cont ++)
// {
//     Console.WriteLine("Seja bem vindo a reservas de suite!\n" +
//     "Digite os nomes dos hospedes:");
//     string teste = Console.ReadLine();
//     Pessoa p1 = new Pessoa(nome: teste);
//     hospedes.Add(p1);
// }

// // Cria a suíte
// Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 100);

// // Cria uma nova reserva, passando a suíte e os hóspedes
// Reserva reserva = new Reserva(diasReservados: 10);
// reserva.CadastrarSuite(suite);
// reserva.CadastrarHospedes(hospedes);

// // Exibe a quantidade de hóspedes e o valor da diária
// Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
// Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");