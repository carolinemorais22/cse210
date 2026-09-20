/*===================================================================================
 * Aluna: Caroline Marques Morais
 *
 * DEMONSTRAÇÃO DE CRIATIVIDADE:
 * 1. Biblioteca de Escrituras: O programa carrega uma lista com várias escrituras 
 *    diferentes e seleciona uma aleatoriamente a cada execução do programa.
 * 2. Ocultação Inteligente: O método OcultarPalavrasAleatorias seleciona e oculta 
 *    apenas as palavras que ainda permanecem visíveis na tela.
 * ===================================================================================*/

using System;
using System.Collections.Generic;

namespace MemorizadorEscrituras
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criatividade: Lista de escrituras para seleção aleatória
            List<Escritura> bibliotecaEscrituras = new List<Escritura>
            {
                new Escritura(
                    new Referencia("Provérbios", 3, 5, 6),
                    "Confia no Senhor de todo o teu coração, e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas."

                ),
                new Escritura(
                    new Referencia("João", 3, 16),
                    "Porque Deus amou o mundo de tal maneira, que deu o seu Filho Unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna."
                ),
                new Escritura(
                    new Referencia("Néfi", 3, 7),
                    "E aconteceu que eu, Néfi, disse a meu pai: Eu irei e cumprirei as ordens do Senhor, porque sei que o Senhor nunca dá ordens aos filhos dos homens sem antes preparar um caminho pelo qual suas ordens possam ser cumpridas."
                ),
                new Escritura(
                    new Referencia("Doutrina e Convênios", 6, 36),
                    "Buscai-me em cada pensamento; não duvideis, não temais."
                )
            };

            Random random = new Random();
            int indiceAleatorio = random.Next(bibliotecaEscrituras.Count);
            Escritura escrituraSelecionada = bibliotecaEscrituras[indiceAleatorio];

            while (true)
            {
                Console.Clear();
                Console.WriteLine(escrituraSelecionada.ObterTexto());
                Console.WriteLine();

                if (escrituraSelecionada.EstaCompletamenteOculta())
                {
                    break;
                }

                Console.WriteLine("Pressione Enter para continuar ou digite 'sair' para encerrar:");
                string entrada = Console.ReadLine()?.Trim().ToLower();

                if (entrada == "sair")
                {
                    break;
                }

                // Oculta 2 palavras a cada Enter
                escrituraSelecionada.OcultarPalavrasAleatorias(2);
            }
        }
    }
}