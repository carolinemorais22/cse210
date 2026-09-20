using System;
using System.Collections.Generic;
using System.Linq;

namespace MemorizadorEscrituras
{
    public class Escritura
    {
        private Referencia _referencia;
        private List<Palavra> _palavras;

        public Escritura(Referencia referencia, string texto)
        {
            _referencia = referencia;
            _palavras = new List<Palavra>();

            string[] palavrasMatriz = texto.Split(' ');
            foreach (string palavraTexto in palavrasMatriz)
            {
                _palavras.Add(new Palavra(palavraTexto));
            }
        }

        public void OcultarPalavrasAleatorias(int numeroParaOcultar)
        {
            Random random = new Random();

            // DESAFIO ADICIONAL / CRIATIVIDADE:
            // Filtra apenas as palavras que ainda NÃO estão ocultas
            List<Palavra> palavrasVisiveis = _palavras.Where(p => !p.EstaOculta()).ToList();

            if (palavrasVisiveis.Count == 0)
            {
                return;
            }

            int ocultadas = 0;
            while (ocultadas < numeroParaOcultar && palavrasVisiveis.Count > 0)
            {
                int indiceAleatorio = random.Next(palavrasVisiveis.Count);
                palavrasVisiveis[indiceAleatorio].Ocultar();
                
                // Remove da lista temporária para não tentar ocultar a mesma palavra na mesma rodada
                palavrasVisiveis.RemoveAt(indiceAleatorio);
                ocultadas++;
            }
        }

        public string ObterTexto()
        {
            List<string> palavrasFormatadas = new List<string>();
            foreach (Palavra palavra in _palavras)
            {
                palavrasFormatadas.Add(palavra.ObterTexto());
            }

            return $"\n{_referencia.ObterTexto()} \n\n {string.Join(" ", palavrasFormatadas)}\n";
        }

        public bool EstaCompletamenteOculta()
        {
            return _palavras.All(p => p.EstaOculta());
        }
    }
}