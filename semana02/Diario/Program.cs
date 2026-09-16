/*Implementei o método de buscar registros por palavra-chave para ir além dos requisitos exigidos*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Diario meuDiario = new Diario();
        GeradorDePerguntas gerador = new GeradorDePerguntas();
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\nPor favor, escolha uma das seguintes opções:");
            Console.WriteLine("1. Escrever um novo registro");
            Console.WriteLine("2. Exibir o diário");
            Console.WriteLine("3. Carregar o diário a partir de um arquivo");
            Console.WriteLine("4. Salvar o diário em um arquivo");
            Console.WriteLine("5. Buscar registro por palavra-chave");
            Console.WriteLine("6. Sair");
            Console.Write("O que você gostaria de fazer?\n");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    string pergunta = gerador.ObterPerguntaAleatoria();
                    Console.WriteLine($"\nPergunta: {pergunta}");
                    Console.Write("> ");
                    string resposta = Console.ReadLine();
                    string dataAtual = DateTime.Now.ToShortDateString();

                    Registro novoRegistro = new Registro(dataAtual, pergunta, resposta);
                    meuDiario.AdicionarRegistro(novoRegistro);
                    break;

                case "2":
                    meuDiario.ExibirTodos();
                    break;

                case "3":
                    Console.Write("Qual é o nome do arquivo? ");
                    string arquivoLeitura = Console.ReadLine();
                    meuDiario.CarregarDoArquivo(arquivoLeitura);
                    break;

                case "4":
                    Console.Write("Qual é o nome do arquivo? ");
                    string arquivoEscrita = Console.ReadLine();
                    meuDiario.SalvarNoArquivo(arquivoEscrita);
                    break;

                case "5":
                    Console.Write("Digite um termo para buscar o registro: ");
                    string termo = Console.ReadLine();
                    meuDiario.BuscarRegistros(termo);
                    break;

                case "6":
                    executando = false;
                    Console.WriteLine("\nObrigado por usar o diário! Até a próxima!\n");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}