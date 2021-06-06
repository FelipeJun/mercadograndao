using hipermercadograndao.Funcionarios;
using hipermercadograndao.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hipermercadograndao.Telas
{
    public partial class TelaPrincipal : Form
    {
        Funcionario funcionarioativo;
        TelaUsuario telausuario = new TelaUsuario();
        List<Produto> Carrinho = new List<Produto>();
        float ValorTotal;
        string Fatura= "********** GRANDÃO SUPERMECADO **********\nNome\tTotal\tQuantidade\tValor";

        public void Atualizar()
        {
            this.funcionarioativo = telausuario.funcionarioativo;
            lbl_Usuario.Text = "Usuario: " + funcionarioativo.Nome;
            rtb_fatura.Text = Fatura;
        }
        public TelaPrincipal()
        {
            InitializeComponent();
            if(funcionarioativo == null)
            {
                telausuario.ShowDialog();
            }
            Atualizar();
        }

        private void lbl_TrocarUsuario_Click(object sender, EventArgs e)
        {
            telausuario.ShowDialog();
            Atualizar();
        }

        private void chb_porkg_CheckedChanged(object sender, EventArgs e)
        {
            if(chb_porkg.Checked)
            {
                lbl_valor.Text = "Valor por Kg";
                lbl_quantidade.Text = "Quantos Kilos?";
                nud_quantidade.DecimalPlaces = 1;
            }
            else
            {
                lbl_valor.Text = "Valor produto";
                lbl_quantidade.Text = "Quantidade";
                nud_quantidade.DecimalPlaces = 0;
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (chb_porkg.Checked)
            {
                ProdutoKg produtokg = new ProdutoKg(txt_nomeProduto.Text,(float)(nud_valor.Value), (float)(nud_quantidade.Value));
                Carrinho.Add(produtokg);
                Fatura += string.Format("\n{0}\tR${1}\t{2}Kg  R${3}/KG",
                    produtokg.Nome, produtokg.CalcularPreco().ToString("F"), produtokg.Kilo.ToString("F"), produtokg.Valor.ToString("F"));
                ValorTotal += produtokg.CalcularPreco();
            }
            else
            {
                ProdutoUnitario produto = new ProdutoUnitario(txt_nomeProduto.Text, (float)(nud_valor.Value), (int)(nud_quantidade.Value)) ;
                Carrinho.Add(produto);
                Fatura += string.Format("\n{0}\tR${1}\tQtd:{2} \tR${3}Uni.", produto.Nome,produto.CalcularPreco().ToString("F"), produto.Quantidade, produto.Valor.ToString("F"));
                ValorTotal += produto.Valor;
            }
            foreach (Produto item in Carrinho)
            {
                cmb_Produtos.Items.Add(item.Nome);
            }
            Atualizar();
        }
        private void btn_remover_Click(object sender, EventArgs e)
        {

        }
        private void btn_finalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
