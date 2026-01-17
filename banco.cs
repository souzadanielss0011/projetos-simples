using System;
using System.Collections.Generic;

static class BancoDeDados
{
    private static List<Produto> produtos = new List<Produto>();

    public static void Cadastra(Produto produto)
    {
        produtos.Add(produto);
        Console.WriteLine("Produto cadastrado com sucesso!");
    }

    public static void MostraTodos()
    {
        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
            return;
        }

        Console.WriteLine("====== LISTA DE PRODUTOS ======");
        foreach (Produto p in produtos)
        {
            Console.WriteLine($"Código: {p.Codigo}");
            Console.WriteLine($"Nome: {p.Nome}");
            Console.WriteLine($"Preço: {p.Preco:C}");
            Console.WriteLine($"Quantidade: {p.Quantidade}");
            Console.WriteLine("-------------------------------");
        }
    }

    public static void Excluir(int codigo)
    {
        Produto produto = produtos.Find(p => p.Codigo == codigo);

        if (produto != null)
        {
            produtos.Remove(produto);
            Console.WriteLine("Produto removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }
}
