using System;

class DIO {

  static void Main(string[] args) {

    double pi, raio, volume;
    pi = 3.14159;

    // Leitura do raio
    raio = double.Parse(Console.ReadLine());

    // Cálculo do volume da esfera
    volume = (4.0 / 3) * pi * Math.Pow(raio, 3);

    // Exibindo o resultado com 3 casas decimais
    Console.WriteLine($"VOLUME = {volume:F3}");
  }

}