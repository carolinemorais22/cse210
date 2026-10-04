using System;
using System.Collections.Generic;

public class AtividadeDeReflexao : Atividade
{
    private List<string> _reflexoes;
    private List<string> _perguntas;

    public AtividadeDeReflexao() 
        : base("Atividade de Reflexão", 
               "Esta atividade ajudará você a refletir sobre momentos da sua vida em que você demonstrou força e resiliência. Isso ajudará você a reconhecer o poder que você tem e como pode usá-lo em outros aspectos da sua vida.")
    {
        _reflexoes = new List<string>
        {
            "Pense em uma ocasião em que você defendeu outra pessoa.",
            "Pense em uma ocasião em que você fez algo realmente difícil.",
            "Pense em uma ocasião em que você ajudou alguém necessitado.",
            "Pense em uma ocasião em que você fez algo verdadeiramente altruísta."
        };

        _perguntas = new List<string>
        {
            "Por que essa experiência foi significativa para você?",
            "Você já fez algo assim antes?",
            "Como você começou?",
            "Como você se sentiu quando terminou?",
            "O que tornou esse momento diferente de outras vezes em que você não teve tanto sucesso?",
            "Qual é a sua coisa favorita sobre essa experiência?",
            "O que você pode aprender com essa experiência que se aplica a outras situações?",
            "O que você aprendeu sobre si mesmo por meio dessa experiência?",
            "Como você pode manter essa experiência em mente no futuro?"
        };
    }

    public void Executar()
    {
        ExibirMensagemInicial();
        ExibirReflexoes();
        ExibirPerguntas();
        ExibirMensagemFinal();
    }

    public string ObterReflexoesAleatorias()
    {
        Random random = new Random();
        int index = random.Next(_reflexoes.Count);
        return _reflexoes[index];
    }

    public string ObterPerguntasAleatorias()
    {
        Random random = new Random();
        int index = random.Next(_perguntas.Count);
        return _perguntas[index];
    }

    public void ExibirReflexoes()
    {
        Console.WriteLine("Considere o seguinte aviso:\n");
        Console.WriteLine($"--- {ObterReflexoesAleatorias()} ---");
        Console.WriteLine("\nQuando tiver algo em mente, pressione ENTER para continuar.");
        Console.ReadLine();
        Console.WriteLine("Agora reflita sobre cada uma das seguintes perguntas relativas a esta experiência:");
        Console.Write("Você pode começar em: ");
        ExibirContagemRegressiva(3);
        Console.Clear();
    }

    public void ExibirPerguntas()
    {
        DateTime horaInicio = DateTime.Now;
        DateTime horaFim = horaInicio.AddSeconds(_duracao);

        while (DateTime.Now < horaFim)
        {
            string pergunta = ObterPerguntasAleatorias();
            Console.Write($"> {pergunta} ");
            ExibirProgresso(10);
            Console.WriteLine();
        }
    }
}