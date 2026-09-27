namespace PedidosOnline
{
    public class Cliente
    {
        private string _nome;
        private Endereco _endereco;

        public Cliente(string nome, Endereco endereco)
        {
            _nome = nome;
            _endereco = endereco;
        }

        public bool MoraNosEua()
        {
            return _endereco.EhEua();
        }

        public string ObterNome()
        {
            return _nome;
        }

        public Endereco ObterEndereco()
        {
            return _endereco;
        }
    }
}