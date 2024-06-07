using System;
using System.Collections.Generic;
using System.Linq;

namespace MeuCadastroProdutos
{
    public class SistemaCadastroDeProdutos
    {
        private List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public List<Produto> ListarProdutos()
        {
            return produtos;
        }

        public Produto BuscarProdutoPorId(int id)
        {
            return produtos.FirstOrDefault(p => p.Id == id);
        }

        public void AtualizarProduto(int id, Produto novoProduto)
        {
            Produto produtoExistente = produtos.FirstOrDefault(p => p.Id == id);
            if (produtoExistente != null)
            {
                produtos[produtos.IndexOf(produtoExistente)] = novoProduto;
                Console.WriteLine($"Produto com ID {id} atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        public void DeletarProduto(int id)
        {
            Produto produtoParaDeletar = produtos.FirstOrDefault(p => p.Id == id);
            if (produtoParaDeletar != null)
            {
                produtos.Remove(produtoParaDeletar);
                Console.WriteLine($"Produto com ID {id} deletado com sucesso.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
    }
}



