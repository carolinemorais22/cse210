namespace VideosYouTube
{
    public class Comentario
    {
        private string _nomePessoa;
        private string _texto;

        public Comentario(string nomePessoa, string texto)
        {
            _nomePessoa = nomePessoa;
            _texto = texto;
        }

        public string ObterNomePessoa()
        {
            return _nomePessoa;
        }

        public string ObterTexto()
        {
            return _texto;
        }
    }
}