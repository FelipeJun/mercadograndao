using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hipermercadograndao.Produtos
{
    public class ProdutoUnitario : Produto
    {
        public int Quantidade { get; set; }
        public ProdutoUnitario(string nome, float valor,int quantidade) : base( nome, valor)
        {
            this.Quantidade = quantidade;
        }

        public override float CalcularPreco()
        {
            return Quantidade * Valor;
        }
    }
}
