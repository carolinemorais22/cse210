using System.Collections.Generic;

namespace PedidosOnline
{
    public class Pedido
    {
        private List<Produto> _produtos;
        private Cliente _cliente;

        public Pedido(Cliente cliente)
        {
            _cliente = cliente;
            _produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public double CalcularCustoTotal()
        {
            double totalProdutos = 0;
            foreach (Produto produto in _produtos)
            {
                totalProdutos += produto.CalcularCustoTotal();
            }

            double frete = _cliente.MoraNosEua() ? 5.0 : 35.0;
            return totalProdutos + frete;
        }

        public string ObterEtiquetaEmbalagem()
        {
            string etiqueta = "ETIQUETA DE EMBALAGEM:\n";
            foreach (Produto produto in _produtos)
            {
                etiqueta += $"- {produto.ObterNome()} (ID: {produto.ObterIdProduto()})\n";
            }
            return etiqueta;
        }

        public string ObterEtiquetaEnvio()
        {
            return $"ETIQUETA DE ENVIO:\n{_cliente.ObterNome()}\n{_cliente.ObterEndereco().ObterEnderecoFormatado()}";
        }
    }
}