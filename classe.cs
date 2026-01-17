class Produto
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(int codigo, string nome, double preco, int quantidade)
    {
        Codigo = codigo;
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
}
