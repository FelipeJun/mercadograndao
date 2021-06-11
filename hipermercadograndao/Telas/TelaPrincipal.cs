using hipermercadograndao.Funcionarios;
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
        string Fatura= "********** GRANDÃO SUPERMECADO **********\nNome\tTotal\t\tQuantidade\tValor";
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
                Atualizar();
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
                Produto produto = new Produto(txt_nomeProduto.Text, (float)(nud_valor.Value), (float)(nud_quantidade.Value));
                string retorno = funcionarioativo.AdicionarCarrinho(Carrinho, produto,chb_porkg.Checked);
                string[] split = retorno.Split('|');
                Fatura += split[0];
                ValorTotal += float.Parse(split[1]);
                Atualizar();
            }
        }
        private void btn_remover_Click(object sender, EventArgs e)
        {
            if(funcionarioativo is IAcessoPrivilegiado privilegiado)
            {
                try
                {
                    string itemremover = cmb_Produtos.SelectedItem.ToString();
                    foreach (Produto item in Carrinho)
                    {
                        if (item.Nome == itemremover)
                        {
                            Carrinho.Remove(item);
                            ValorTotal -= item.ValorTotal;
                            Fatura += string.Format("\nRemovido pelo {0}: {1}", funcionarioativo.GetType().Name, item.Nome);
                            break;
                        }
                    }
                    privilegiado.Remover();
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
            if (Carrinho.Any())
            {
                TelaPagamento form = new TelaPagamento(Fatura, ValorTotal, funcionarioativo);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Coloque pelo menos 1 item no carrinho!");
            }

        }

    }
}
