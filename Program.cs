using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    int numero;


Console.WriteLine("*-- Decomposição Decimal --*\n");
Console.WriteLine("Digite um número inteiro");
numero = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine();
Console.WriteLine("O número que você digitou possui:");

int restante = numero;

int unidades = restante % 10;
restante /= 10;

int dezenas = restante % 10;
restante /= 10;

int centenas = restante % 10;
restante /= 10;

int milhar = restante % 10;
restante /= 10;

int decimo_milhar = restante % 10;
restante /= 10;

Console.WriteLine($"\nO número {numero} possui:");
Console.WriteLine($"{unidades,10} unidade(s)");
Console.WriteLine($"{dezenas,10} dezenas(s)");
Console.WriteLine($"{centenas,10} centena(s).");
Console.WriteLine($"{milhar,10} milhar(es).");
Console.WriteLine($"{decimo_milhar,10} decimo(s)_milhar.");
  }
}
