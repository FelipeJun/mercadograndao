using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hipermercadograndao
{
    public class Produto
    {
        public string Nome{ get; set; }
        public float Valor { get; set; }
        //Quantidade serve para quantos produtos unitarios for comprar e para o Kilo do produto,
        //pois os 2 irão multiplicar pelo valor do produto
        public float Quantidade { get; set; }
        public float ValorTotal { get; set; }
        
        public Produto(string nome, float valor,float quantidadeOuKIlo)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Quantidade = quantidadeOuKIlo;
            this.ValorTotal = CalcularPreco();
        }

        public float CalcularPreco()
        {
            return Quantidade * Valor;
        }
    }
}
