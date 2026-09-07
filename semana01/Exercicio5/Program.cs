using System;

class Program
{
    static void Main(string[] args)
    {
        MostrarMensagemBoasVindas();

        string nome = PerguntarNomeUsuario();
        int numero = PerguntarNumeroUsuario();

        int quadrado = NumeroAoQuadrado(numero);

        MostrarResultado(nome, quadrado);
    }

    static void MostrarMensagemBoasVindas()
    {
        Console.WriteLine("\nBem-vindo ao programa de cálculo de quadrados!");
    }

    static string PerguntarNomeUsuario()
    {
        Console.Write("\nPor favor, digite seu nome: ");
        string nome = Console.ReadLine();

        return nome;
    }

    static int PerguntarNumeroUsuario()
    {
        Console.Write("Por favor, digite seu numero favorito: ");
        int numero = int.Parse(Console.ReadLine());

        return numero;
    }

    static int NumeroAoQuadrado(int numero)
    {
        int quadrado = numero * numero;
        return quadrado;
    }

    static void MostrarResultado(string nome, int quadrado)
    {
        Console.WriteLine($"\n{nome}, o seu número ao quadrado é {quadrado}.\n");
    }
}