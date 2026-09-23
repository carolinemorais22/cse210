using System.Collections.Generic;

namespace VideosYouTube
{
    public class Video
    {
        private string _titulo;
        private string _autor;
        private int _duracaoSegundos;
        private List<Comentario> _comentarios;

        public Video(string titulo, string autor, int duracaoSegundos)
        {
            _titulo = titulo;
            _autor = autor;
            _duracaoSegundos = duracaoSegundos;
            _comentarios = new List<Comentario>();
        }

        public void AdicionarComentario(Comentario comentario)
        {
            _comentarios.Add(comentario);
        }

        public int ObterNumeroComentarios()
        {
            return _comentarios.Count;
        }

        public string ObterTitulo()
        {
            return _titulo;
        }

        public string ObterAutor()
        {
            return _autor;
        }

        public int ObterDuracaoSegundos()
        {
            return _duracaoSegundos;
        }

        public List<Comentario> ObterComentarios()
        {
            return _comentarios;
        }
    }
}