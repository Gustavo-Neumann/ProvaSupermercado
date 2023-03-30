using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPOO2
{
    public class Carrinho
    {
       public float pesoMax;
        public float pesoAtual;
        public float precoTotal;
       public List<Produto> produtos = new List<Produto>();

        public Carrinho()
        {
            this.pesoMax = 100;
            this.pesoAtual = 0;
            this.precoTotal = 0;
        }
    }


}
