using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nQual o percentual da sua nota? ");
        string resposta = Console.ReadLine();
        int percentual = int.Parse(resposta);

        string letra = "";

        if (percentual >= 90)
        {
            letra = "A";
        }
        else if (percentual >= 80)
        {
            letra = "B";
        }
        else if (percentual >= 70)
        {
            letra = "C";
        }
        else if (percentual >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }

        Console.WriteLine($"\nSua nota é: {letra}");
        
        if (percentual >= 70)
        {
            Console.WriteLine("Você passou! Parabéns!\n");
        }
        else
        {
            Console.WriteLine("Você não passou.\n");
        }
    }
}