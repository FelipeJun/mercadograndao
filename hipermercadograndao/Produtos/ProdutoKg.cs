using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hipermercadograndao.Produtos
{
    public class ProdutoKg : Produto
    {
        public double Kilo { get; set; }

        public ProdutoKg(string nome, double valor, double kilo) : base(nome, valor)
        {
            this.Kilo = kilo;
        }

    }
}
