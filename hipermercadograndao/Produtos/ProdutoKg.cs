using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hipermercadograndao.Produtos
{
    public class ProdutoKg : Produto
    {
        public float Kilo { get; set; }

        public ProdutoKg(string nome, float valor, float kilo) : base(nome, valor)
        {
            this.Kilo = kilo;
        }

        public override float CalcularPreco()
        {
            return Kilo * Valor;
        }
    }
}
