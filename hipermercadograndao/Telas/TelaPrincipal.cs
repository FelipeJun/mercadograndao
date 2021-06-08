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
        string Fatura= "********** GRANDÃO SUPERMECADO **********\nNome\tTotal\tQuantidade\t\tValor";

        public void Atualizar()
        {
            this.funcionarioativo = telausuario.funcionarioativo;
            lbl_Usuario.Text = "Usuario: " + funcionarioativo.Nome;
            rtb_fatura.Text = Fatura;
            lbl_valortotal.Text = string.Format("Valor Total: R${0}",ValorTotal.ToString("F"));
            txt_nomeProduto.Text = "";
            nud_quantidade.Value = 0;
            nud_valor.Value = 0;
            cmb_Produtos.Items.Clear();
            foreach (Produto item in Carrinho)
            {
                cmb_Produtos.Items.Add(item.Nome);
            }
        }
        public TelaPrincipal()
        {
            InitializeComponent();
            if(funcionarioativo == null)
            {
                telausuario.ShowDialog();
            }
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
            if (lbl_nomeproduto.Text == "" || nud_quantidade.Value == 0 || nud_valor.Value == 0)
            {
                MessageBox.Show("Alguns dos campos não foi preenchido Corretamente.");
            }
            else
            {
                if (chb_porkg.Checked)
                {
                    ProdutoKg produtokg = new ProdutoKg(txt_nomeProduto.Text, (float)(nud_valor.Value), (float)(nud_quantidade.Value));
                    Carrinho.Add(produtokg);
                    Fatura += string.Format("\n{0}\tR${1}\t{2}Kg  R${3}/KG",
                        produtokg.Nome, produtokg.ValorTotalP.ToString("F"), produtokg.Kilo.ToString("F"), produtokg.Valor.ToString("F"));
                    ValorTotal += produtokg.ValorTotalP;
                }
                else
                {
                    ProdutoUnitario produto = new ProdutoUnitario(txt_nomeProduto.Text, (float)(nud_valor.Value), (int)(nud_quantidade.Value));
                    Carrinho.Add(produto);
                    Fatura += string.Format("\n{0}\tR${1}\tQtd:{2} \tR${3}Uni.",
                        produto.Nome, produto.ValorTotalP.ToString("F"), produto.Quantidade, produto.Valor.ToString("F"));
                    ValorTotal += produto.ValorTotalP;
                }
                Atualizar();
            }
        }
        private void btn_remover_Click(object sender, EventArgs e)
        {
            if(funcionarioativo is IAcessoPrivilegiado)
            {
                try
                {
                    string itemremover = cmb_Produtos.SelectedItem.ToString();
                    IAcessoPrivilegiado IAP = (IAcessoPrivilegiado)funcionarioativo;
                    foreach (Produto item in Carrinho)
                    {
                        if (item.Nome == itemremover)
                        {
                            Carrinho.Remove(item);
                            ValorTotal -= item.ValorTotalP;
                            Fatura += string.Format("\nRemovido pelo {0}: {1}", funcionarioativo.GetType().Name, item.Nome);
                            break;
                        }
                    }
                    IAP.Remover();
                    Atualizar();
                }
                catch(NullReferenceException)
                {
                    MessageBox.Show("Selecione um produto para Remover.");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: "+ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Você não tem acesso à esta função!");
            }

        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            TelaPagamento form = new TelaPagamento(Fatura, ValorTotal,funcionarioativo);
            form.Show();
            this.Hide();
        }
    }
}
