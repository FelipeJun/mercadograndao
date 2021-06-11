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
    public partial class TelaPagamento : Form
    {
        float valorTotal;
        public TelaPagamento(string fatura, float valortotal,Funcionario funcionarioativo)
        {
            InitializeComponent();
            this.valorTotal = valortotal;
            lbl_valortotal.Text = string.Format("Valor Total: R${0}", valortotal.ToString("F"));
            rtb_fatura.Text = fatura;
            cmb_Pagamento.SelectedIndex = 0;
            rtb_fatura.Text += "\n---------------------------------------------------------";
            rtb_fatura.Text += string.Format("\n\tTotal: {0}\n\tAtendido por {1}",
                valorTotal.ToString("F"),funcionarioativo.Nome);
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            if (cmb_Pagamento.SelectedIndex == 2)
            {
                if((float)(nud_dinheiro.Value) < valorTotal)
                {
                    MessageBox.Show("Dinheiro insuficiente!");
                }
                else
                {
                    float troco = (float)(nud_dinheiro.Value) - valorTotal;
                    rtb_fatura.Text += string.Format("\n\tValor Recebido: R${0}\n\tTroco: R${1}", nud_dinheiro.Value.ToString("F"), troco.ToString("F"));
                    btn_finalizar.Enabled = false;
                    rtb_fatura.Text += string.Format("\n\tPagamento feito por: {0}", cmb_Pagamento.SelectedItem.ToString());
                    rtb_fatura.Text += "\n********* OBRIGADO E VOLTE SEMPRE **********";
                }
            }
            else
            {
                btn_finalizar.Enabled = false;
                rtb_fatura.Text += string.Format("\n\tPagamento feito por: {0}", cmb_Pagamento.SelectedItem.ToString());
                rtb_fatura.Text += "\n********* OBRIGADO E VOLTE SEMPRE **********";
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            if (btn_finalizar.Enabled)
            {
                MessageBox.Show("Finalize o pagamento!");
            }
            else
            {
                Application.Exit();
            }
            
        }

        private void cmb_Pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Pagamento.SelectedIndex == 2)
            {
                lbl_dinheiro.Visible = true;
                nud_dinheiro.Visible = true;
            }
            else
            {
                lbl_dinheiro.Visible = false;
                nud_dinheiro.Visible = false;
            }
        }
    }
}
