using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPOO2
{
    public class alimenticio : Produto
    {
        public int dataValidade;

        public alimenticio(string nome, string marca, float preco, float peso, int dataValidade) : base(nome, marca, preco, peso)
        {
            this.dataValidade = dataValidade; 
        }
    }
}
