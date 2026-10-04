/*
==================================================================================
Implementação da superação de requisitos:
==================================================================================
Validação de Entrada: O programa impede que o usuário digite letras ou números 
inválidos ao escolher o tempo da atividade, evitando que o código feche com erro. 
==================================================================================*/

using System;

class Program
{
    static void Main(string[] args)
    {
        bool executar = true;

        while (executar)
        {
            Console.Clear();
            Console.WriteLine("Opções do Menu:");
            Console.WriteLine("  1. Iniciar atividade de respiração");
            Console.WriteLine("  2. Iniciar atividade de reflexão");
            Console.WriteLine("  3. Iniciar atividade de listagem");
            Console.WriteLine("  4. Sair");
            Console.Write("Selecione uma opção do menu: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AtividadeDeRespiracao respiração = new AtividadeDeRespiracao();
                    respiração.Executar();
                    break;
                case "2":
                    AtividadeDeReflexao reflexao = new AtividadeDeReflexao();
                    reflexao.Executar();
                    break;
                case "3":
                    AtividadeDeListagem listagem = new AtividadeDeListagem();
                    listagem.Executar();
                    break;
                case "4":
                    executar = false;
                    Console.WriteLine("\nObrigado por usar o Programa de Introspecção. Até logo!");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Pressione ENTER para tentar novamente.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}