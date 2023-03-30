using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPOO2
{
    public class Pessoa
    {
        public string nome;
        public int cpf;
        public float dinheiro;
        public Carrinho carrinho;

        public Pessoa(string nome, int cpf, float dinheiro, Carrinho carrinho)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dinheiro = dinheiro;
            this.carrinho = carrinho;
        }


        public void listar()
        {
            float precoCarrinho = 0.00f;
            foreach (Produto produto in carrinho.produtos)
            {
                Console.WriteLine($@"{produto.nome} R${produto.preco}");
                precoCarrinho += produto.preco;
            }
            Console.WriteLine($@"Total atual do carrinho = {precoCarrinho}");

        }
        public void adicionar(Produto produto)
        {
            if (carrinho.pesoAtual + produto.peso > carrinho.pesoMax) { Console.WriteLine("Peso max atingido"); return; }
            else
            {
                carrinho.produtos.Add(produto);
                carrinho.pesoAtual += produto.peso;
                carrinho.precoTotal += produto.preco;
                Console.WriteLine($@"{produto.nome} adicionado com sucesso");
            }
        }
        public void remover(Produto produto)
        {
            if (carrinho.produtos.Count == 0) { Console.WriteLine("carrinho vazio"); return; }
            else if(carrinho.produtos.Contains(produto))
            {
                carrinho.produtos.Remove(produto);
                carrinho.pesoAtual -= produto.peso;
                carrinho.precoTotal -= produto.preco;
                Console.WriteLine($@"{produto.nome} removido com sucesso");
            }
            else Console.WriteLine("produto nao esta no carrinho");
          
         
        }
        public void finalizar()
        {
            if (this.dinheiro < carrinho.precoTotal) { Console.WriteLine("Dinheiro insuficiente"); return; }
            else
            {
                Console.WriteLine("obrigado por comprar com a gente, aqui esta um recibo: ");
                this.dinheiro -= carrinho.precoTotal;
                this.listar();
            }

        }

    }



}
