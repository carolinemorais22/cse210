using System;

namespace PedidosOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco endereco1 = new Endereco("346", "Salt Lake City", "UT", "USA");
            Cliente cliente1 = new Cliente("Kathryn Johnson", endereco1);
            Pedido pedido1 = new Pedido(cliente1);

            pedido1.AdicionarProduto(new Produto("Gloss Labial", "PROD001", 75.00, 1));
            pedido1.AdicionarProduto(new Produto("Blusa xadrez", "PROD002", 25.00, 2));

            Endereco endereco2 = new Endereco("Av. Marechal Rondon 1000", "Brasília", "DF", "Brasil");
            Cliente cliente2 = new Cliente("Marcelo Rodrigues", endereco2);
            Pedido pedido2 = new Pedido(cliente2);

            pedido2.AdicionarProduto(new Produto("Barbeador elétrico", "PROD003", 150.00, 1));
            pedido2.AdicionarProduto(new Produto("Croscs", "PROD004", 10.00, 3));
            pedido2.AdicionarProduto(new Produto("Capinha para celular", "PROD005", 30.00, 1));

            Pedido[] pedidos = { pedido1, pedido2 };

            for (int i = 0; i < pedidos.Length; i++)
            {
                Console.WriteLine($"\n=================== PEDIDO {i + 1} ===================");
                Console.WriteLine(pedidos[i].ObterEtiquetaEmbalagem());
                Console.WriteLine(pedidos[i].ObterEtiquetaEnvio());
                Console.WriteLine($"\nTotal: ${pedidos[i].CalcularCustoTotal():F2}\n");
            }
        }
    }
}