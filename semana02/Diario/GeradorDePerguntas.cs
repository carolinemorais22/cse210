using System;
using System.Collections.Generic;
public class GeradorDePerguntas
{
    public List<string> _perguntas = new List<string>
    {
      "Que pequeno aprendizado eu levo do dia de hoje?",
      "O que funcionou bem hoje e como posso repetir amanhã?",
      "Como cuidei de mim mesmo(a) no dia de hoje?",
      "Qual foi o pequeno avanço que fiz hoje em direção aos meus objetivos?",
      "Eu ajudei ou incentivei alguém hoje? Como foi essa experiência?",
      "O que eu fiz hoje que me tirou da zona de conforto?",
      "Qual foi o momento mais gratificante do meu dia?",
      "Quem me fez sorrir ou se sentir acolhido(a) hoje?"
    };

    public string ObterPerguntaAleatoria()
    {
        Random random = new Random();
        int indice = random.Next(_perguntas.Count);
        return _perguntas[indice];
    }
}