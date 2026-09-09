using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        int numeroEscolhido;

        do
        {
            Console.Write("\nDigite um número (Caso desejar sair, digite 0): ");

            string respostaUsuario = Console.ReadLine();
            numeroEscolhido = int.Parse(respostaUsuario);

            if (numeroEscolhido != 0)
            {
                numeros.Add(numeroEscolhido);
            }

        } while (numeroEscolhido != 0);

        int soma = 0;
        foreach (int numero in numeros)
        {
            soma += numero;
        }

        Console.WriteLine($"\nA soma é: {soma}\n");


        float media = ((float)soma) / numeros.Count;
        Console.WriteLine($"\nA média é: {media}\n");


        int maior = numeros[0];

        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }

        Console.WriteLine($"\nO maior valor é: {maior}\n");
    }
}