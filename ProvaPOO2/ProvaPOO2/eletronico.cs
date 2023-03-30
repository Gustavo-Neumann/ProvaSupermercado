using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPOO2
{
    internal class eletronico : Produto
    {
        public int tempoGarantia;

        public eletronico(string nome, string marca, float preco, float peso, int tempoGarantia) : base(nome, marca, preco, peso)
        {
            this.tempoGarantia = tempoGarantia;
        }
    }
}
