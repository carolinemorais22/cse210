using System;
using System.Collections.Generic;

public class AtividadeDeListagem : Atividade
{
    private int _contador;
    private List<string> _perguntas;

    public AtividadeDeListagem() 
        : base("Atividade de Listagem", 
               "Esta atividade ajudará você a refletir sobre as coisas boas da sua vida, fazendo com que você liste o máximo de coisas que puder em uma determinada área.")
    {
        _contador = 0;
        _perguntas = new List<string>
        {
            "Quem são as pessoas que você aprecia?",
            "Quais são seus pontos fortes pessoais?",
            "Quem são as pessoas que você ajudou esta semana?",
            "Quando você sentiu paz ou gratidão este mês?",
            "Quem são alguns dos seus heróis pessoais?"
        };
    }

    public void Executar()
    {
        ExibirMensagemInicial();
        ObterPerguntaAleatoria();
        List<string> lista = ObterListaDoUsuario();
        _contador = lista.Count;
        Console.WriteLine($"Você listou {_contador} itens!");
        ExibirMensagemFinal();
    }

    public void ObterPerguntaAleatoria()
    {
        Random random = new Random();
        int index = random.Next(_perguntas.Count);
        Console.WriteLine("Liste o máximo de itens que puder sobre a seguinte pergunta:");
        Console.WriteLine($"--- {_perguntas[index]} ---");
        Console.Write("Você pode começar em: ");
        ExibirContagemRegressiva(3);
        Console.WriteLine();
    }

    public List<string> ObterListaDoUsuario()
    {
        List<string> itens = new List<string>();
        DateTime horaInicio = DateTime.Now;
        DateTime horaFim = horaInicio.AddSeconds(_duracao);

        while (DateTime.Now < horaFim)
        {
            Console.Write("> ");
            
            string entrada = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entrada))
            {
                itens.Add(entrada);
            }
        }

        return itens;
    }
}