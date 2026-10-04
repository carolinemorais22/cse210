using System;
using System.Threading;

public class AtividadeDeRespiracao : Atividade
{
    public AtividadeDeRespiracao() 
        : base("Atividade de Respiração", 
               "Esta atividade ajudará você a relaxar, inspirando e expirando lentamente. Limpe sua mente e concentre-se na sua respiração.")
    {
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        DateTime horaInicio = DateTime.Now;
        DateTime horaFim = horaInicio.AddSeconds(_duracao);

        while (DateTime.Now < horaFim)
        {
            Console.Write("Inspire... ");
            ExibirContagemRegressiva(5);
            Console.WriteLine();

            Console.Write("Expire... ");
            ExibirContagemRegressiva(5);
            Console.WriteLine();
            Console.WriteLine();
        }

        ExibirMensagemFinal();
    }
}