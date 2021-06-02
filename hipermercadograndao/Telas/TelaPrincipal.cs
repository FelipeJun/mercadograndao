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
        string Fatura= "**** GRANDÃO SUPERMECADO ****";

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
            if(chb_porkg.Checked == true)
            {
                nud_kilo.Visible = true;
                lbl_kilo.Visible = true;
            }
            else
            {
                nud_kilo.Visible = false;
                lbl_kilo.Visible = false;
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (chb_porkg.Checked == true)
            {
                ProdutoKg produtokg = new ProdutoKg(txt_nomeProduto.Text,Convert.ToDouble(nud_valor.Value),Convert.ToDouble(nud_kilo.Value));
                Carrinho.Add(produtokg);
                Fatura += "\n" + produtokg.Nome + "\tR$ " + "\tKG: " + produtokg.Kilo +"\t"+produtokg.Valor +"/KG" ;
            }
            else
            {
                ProdutoUnitario produto = new ProdutoUnitario(txt_nomeProduto.Text, Convert.ToDouble(nud_valor.Value));
                Carrinho.Add(produto);
                Fatura += "\n" + produto.Nome +"\tR$ " + produto.Valor;
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
    }
}
