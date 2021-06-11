using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hipermercadograndao
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public Funcionario(string nome)
        {
            this.Nome = nome;
        }

        public string AdicionarCarrinho(List<Produto>carrinho,Produto produto,bool Kg)
        {
            carrinho.Add(produto);
            string retorno;
            if (Kg)
            {
                string Fatura = string.Format("\n{0}\tR${1}\t{2}Kg\tR${3}/KG",
                produto.Nome, produto.ValorTotal.ToString("F"), produto.Quantidade.ToString("F"), produto.Valor.ToString("F"));
                string ValorTotal = produto.ValorTotal.ToString();
                retorno = string.Format(Fatura + "|" + ValorTotal);
            }
            else
            {
                string Fatura = string.Format("\n{0}\tR${1}\t{2}Uni.\t\tR${3}Uni.",
                        produto.Nome, produto.ValorTotal.ToString("F"), produto.Quantidade, produto.Valor.ToString("F"));
                string ValorTotal = produto.ValorTotal.ToString();
                retorno = string.Format(Fatura + "|" + ValorTotal);
            }
            return retorno;
        }
    }
} 
