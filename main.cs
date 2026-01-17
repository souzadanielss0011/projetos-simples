using System;

class Program
{
    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.Clear();

            Console.WriteLine("============ MENU PRINCIPAL ============");
            Console.WriteLine("1. Cadastrar Produto");
            Console.WriteLine("2. Mostrar Todos os Produtos");
            Console.WriteLine("3. Excluir Produto");
            Console.WriteLine("4. Finalizar Sistema");
            Console.Write("Digite a opção desejada: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Código: ");
                    int codigo = int.Parse(Console.ReadLine());

                    Console.Write("Nome do Produto: ");
                    string nomeProduto = Console.ReadLine();

                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine());

                    Console.Write("Quantidade: ");
                    int quantidade = int.Parse(Console.ReadLine());

                    Produto produto = new Produto(codigo, nomeProduto, preco, quantidade);
                    BancoDeDados.Cadastra(produto);

                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;

                case 2:
                    BancoDeDados.MostraTodos();
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Write("Digite o código do produto a ser excluído: ");
                    int codigoExcluir = int.Parse(Console.ReadLine());

                    BancoDeDados.Excluir(codigoExcluir);

                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("Finalizando sistema...");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
            }

        } while (opcao != 4);
    }
}
