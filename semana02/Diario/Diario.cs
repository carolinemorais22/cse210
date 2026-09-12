using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    public List<Registro> _registros = new List<Registro>();

    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
    }

    public void ExibirTodos()
    {
        if (_registros.Count == 0)
        {
            Console.WriteLine("\nNão há nada no diário ainda. Por favor, adicione um registro primeiro.\n");
            return;
        }
        Console.WriteLine("\n---- O que foi registrado até agora: ----\n\n");
        foreach (Registro registro in _registros)
        {
            registro.Exibir();
        }
    }

    public void SalvarNoArquivo(string arquivo)
    {
        using (StreamWriter arquivoSaida = new StreamWriter(arquivo))
        {
            foreach (Registro registro in _registros)
            {
                arquivoSaida.WriteLine($"{registro._data},{registro._textoPergunta},{registro._textoResposta}");
            }
        }
        Console.WriteLine($"\nDiário salvo com sucesso!");
    }

    public void CarregarDoArquivo(string arquivo)
    {
        if (!File.Exists(arquivo))
        {
            Console.WriteLine("\nArquivo não encontrado.");
            return;
        }
        _registros.Clear();
        string[] linhas = File.ReadAllLines(arquivo);

        foreach (string linha in linhas)
        {
            string[] partes = linha.Split(",");
            if (partes.Length == 3)
            {
                Registro registro = new Registro(partes[0], partes[1], partes[2]);
                _registros.Add(registro);
            }
        }
        Console.WriteLine("\nDiário carregado!");
    }

    public void BuscarRegistros(string termo)
{
    if (_registros.Count == 0)
    {
        Console.WriteLine("\nNão há nada no diário ainda. Por favor, adicione um registro primeiro.");
        return;
    }

    var resultados = _registros.FindAll(r => 
        r._textoResposta.Contains(termo, StringComparison.OrdinalIgnoreCase) ||
        r._textoPergunta.Contains(termo, StringComparison.OrdinalIgnoreCase)
    );

    if (resultados.Count == 0)
    {
        Console.WriteLine($"\nNenhum registro encontrado contendo: '{termo}'");
        return;
    }

    Console.WriteLine($"\n---- RESULTADOS PARA '{termo}' ----\n\n");
    foreach (var registro in resultados)
    {
        registro.Exibir();
    }
}
}