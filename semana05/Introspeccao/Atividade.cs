using System;
using System.Collections.Generic;
using System.Threading;

public class Atividade
{
    private string _nome;
    private string _descricao;
    protected int _duracao;

    public Atividade(string nome, string descricao)
    {
        _nome = nome;
        _descricao = descricao;
        _duracao = 0;
    }

    public void ExibirMensagemInicial()
    {
        Console.Clear();
        Console.WriteLine($"--- Bem-vindo à {_nome} ---\n");
        Console.WriteLine(_descricao);
        Console.WriteLine();
        Console.Write("Quanto tempo, em segundos, você gostaria para esta sessão? ");
        
        while (!int.TryParse(Console.ReadLine(), out _duracao) || _duracao <= 0)
        {
            Console.Write("Por favor, insira um número inteiro válido maior que zero: ");
        }

        Console.Clear();
        Console.WriteLine("Prepare-se para começar...");
        ExibirProgresso(5);
        Console.WriteLine();
    }

    public void ExibirMensagemFinal()
    {
        Console.WriteLine();
        Console.WriteLine("Muito bem!! Você fez um ótimo trabalho!");
        ExibirProgresso(3);
        Console.WriteLine($"\nVocê concluiu {_duracao} segundos da atividade: {_nome}.");
        ExibirProgresso(5);
    }

    public void ExibirProgresso(int segundos)
    {
        List<string> animacao = new List<string> { "|", "/", "-", "\\" };
        DateTime horaInicio = DateTime.Now;
        DateTime horaFim = horaInicio.AddSeconds(segundos);

        int i = 0;
        while (DateTime.Now < horaFim)
        {
            string frame = animacao[i];
            Console.Write(frame);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % animacao.Count;
        }
    }

    public void ExibirContagemRegressiva(int segundos)
    {
        for (int i = segundos; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            
            // Trata o apagar de números com mais de 1 dígito
            int digitos = i.ToString().Length;
            for (int j = 0; j < digitos; j++)
            {
                Console.Write("\b \b");
            }
        }
    }
}