using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual o seu primeiro nome? ");
        string nome = Console.ReadLine();

        Console.Write("Qual o seu sobrenome? ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"Seu nome é {sobrenome}, {nome} {sobrenome}.");
    }
}