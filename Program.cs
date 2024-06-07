using System;

namespace MeuCadastroProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaCadastroDeProdutos sistema = new SistemaCadastroDeProdutos();

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Escolha a opção desejada:");
                Console.WriteLine("1 - Adicionar Produto");
                Console.WriteLine("2 - Buscar Produto por ID");
                Console.WriteLine("3 - Listar Produtos");
                Console.WriteLine("4 - Atualizar Produto");
                Console.WriteLine("5 - Deletar Produto");
                Console.WriteLine("6 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe o Id do Produto:");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o nome do Produto");
                        string Nome = Console.ReadLine();
                        Console.WriteLine("Informe o Preço do Produto");
                        double Preco = double.Parse(Console.ReadLine());

                        Produto p1 = new Produto(Id, Nome, Preco);

                        sistema.AdicionarProduto(p1);
                        Console.WriteLine("Produto adicionado com sucesso!");
                        break;
                    case 2:
                        Console.WriteLine("Digite o ID do produto que deseja buscar:");
                        int idBusca = int.Parse(Console.ReadLine());
                        Produto produtoBuscado = sistema.BuscarProdutoPorId(idBusca);
                        if (produtoBuscado != null)
                        {
                            Console.WriteLine($"Produto encontrado - Nome: {produtoBuscado.Nome} - Preço: {produtoBuscado.Preco}");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Listando Produtos:");
                        var produtos = sistema.ListarProdutos();
                        foreach (var produto in produtos)
                        {
                            Console.WriteLine($"ID: {produto.Id} - Nome: {produto.Nome} - Preço: {produto.Preco}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Digite o ID do produto que deseja atualizar:");
                        int idAtualizar = int.Parse(Console.ReadLine());
                        Produto produtoAtualizar = sistema.BuscarProdutoPorId(idAtualizar);
                        if (produtoAtualizar != null)
                        {
                            Console.WriteLine("Informe o novo nome do Produto:");
                            string novoNome = Console.ReadLine();
                            Console.WriteLine("Informe o novo preço do Produto:");
                            double novoPreco = double.Parse(Console.ReadLine());

                            Produto novoProduto = new Produto(idAtualizar, novoNome, novoPreco);
                            sistema.AtualizarProduto(idAtualizar, novoProduto);
                            Console.WriteLine("Produto atualizado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Digite o ID do produto que deseja deletar:");
                        int idDeletar = int.Parse(Console.ReadLine());
                        Produto produtoDeletar = sistema.BuscarProdutoPorId(idDeletar);
                        if (produtoDeletar != null)
                        {
                            sistema.DeletarProduto(idDeletar);
                            Console.WriteLine("Produto deletado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado.");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Saindo do programa...");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}








     