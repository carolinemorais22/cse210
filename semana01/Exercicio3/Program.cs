using System;

class Program
{
    static void Main(string[] args)
    {

        Random geradorRandomico = new Random();
        int numeroRandom = geradorRandomico.Next(1, 101);

        int palpite;

        Console.Write("\nAdvinhe o número entre 1 e 100!\n");
        // Estrutura do-while
        do
        {
            Console.Write("\nQual o seu palpite? ");
            palpite = int.Parse(Console.ReadLine());

            if (numeroRandom > palpite)
            {
                Console.WriteLine("Diga um número maior");
            }
            else if (numeroRandom < palpite)
            {
                Console.WriteLine("Diga um número menor");
            }
            else
            {
                Console.WriteLine("\nVocê adivinhou!\n");
            }

        } while (palpite != numeroRandom);
    }
}