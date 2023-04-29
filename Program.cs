// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
int quantidadeDeFaces;
Console.WriteLine("---Rolagem de Dados!---");
Console.WriteLine("Insira a quantidade de faces do dado");
quantidadeDeFaces = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("inciando O PROCESOO...");


int Rolagem = RandomNumberGenerator.GetInt32(1, quantidadeDeFaces);

Console.WriteLine($"{Rolagem}");

