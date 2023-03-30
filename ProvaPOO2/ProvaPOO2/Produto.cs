using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPOO2
{
    public class Produto
    {
        public string nome;
        public string marca;
        public float preco;
        public float peso;

        public Produto(string nome, string marca, float preco, float peso)
        {
            this.nome = nome;
            this.marca = marca;
            this.preco = preco;
            this.peso = peso;
        }
    }
}
