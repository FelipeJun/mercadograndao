using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hipermercadograndao
{
    public abstract class Produto
    {
        public string Nome{ get; set; }
        public float Valor { get; set; }
        public Produto(string nome, float valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }

        public abstract float CalcularPreco();
    }
}
