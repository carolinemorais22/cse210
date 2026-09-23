using System;
using System.Collections.Generic;

namespace VideosYouTube
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando Lista de Vídeos
            List<Video> listaVideos = new List<Video>();

            // --- VÍDEO 1 ---
            Video video1 = new Video("Aprenda C# do Zero", "Dev Academy", 900);
            video1.AdicionarComentario(new Comentario("Carlos", "Excelente aula, muito bem explicada!"));
            video1.AdicionarComentario(new Comentario("Mariana", "Ajudou bastante no meu trabalho da faculdade."));
            video1.AdicionarComentario(new Comentario("João", "Poderia fazer uma continuação?"));
            listaVideos.Add(video1);

            // --- VÍDEO 2 ---
            Video video2 = new Video("Orientação a Objetos na Prática", "Codigo Certo", 1200);
            video2.AdicionarComentario(new Comentario("Beatriz", "Abstração sempre foi um conceito confuso, mas agora entendi!"));
            video2.AdicionarComentario(new Comentario("Lucas", "Ótimos exemplos práticos."));
            video2.AdicionarComentario(new Comentario("Fernanda", "Muito didático, parabéns pelo conteúdo!"));
            video2.AdicionarComentario(new Comentario("Rafael", "Vídeo top demais!"));
            listaVideos.Add(video2);

            // --- VÍDEO 3 ---
            Video video3 = new Video("Dicas de Produtividade no VS Code", "Tech Mastery", 450);
            video3.AdicionarComentario(new Comentario("Ana", "Uso esses atalhos todos os dias!"));
            video3.AdicionarComentario(new Comentario("Pedro", "O atalho de seleção múltipla mudou minha vida."));
            video3.AdicionarComentario(new Comentario("Sofia", "Muito rápido e direto ao ponto."));
            listaVideos.Add(video3);

            // --- EXIBIÇÃO DOS DADOS ---
            foreach (Video video in listaVideos)
            {
                Console.WriteLine("==================================================");
                Console.WriteLine($"Título: {video.ObterTitulo()}");
                Console.WriteLine($"Autor: {video.ObterAutor()}");
                Console.WriteLine($"Duração: {video.ObterDuracaoSegundos()} segundos");
                Console.WriteLine($"Número de Comentários: {video.ObterNumeroComentarios()}");
                Console.WriteLine("\nComentários:");

                foreach (Comentario comentario in video.ObterComentarios())
                {
                    Console.WriteLine($" - {comentario.ObterNomePessoa()}: \"{comentario.ObterTexto()}\"");
                }
                Console.WriteLine();
            }
        }
    }
}