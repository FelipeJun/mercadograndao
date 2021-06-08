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
        public TelaPagamento(string fatura, float valortotal,Funcionario funcionarioativo)
        {
            InitializeComponent();
            lbl_valortotal.Text = string.Format("Valor Total: R${0}", valortotal.ToString("F"));
            rtb_fatura.Text = fatura;
            cmb_Pagamento.SelectedIndex = 0;
            rtb_fatura.Text += "\n---------------------------------------------------------";
            rtb_fatura.Text += string.Format("\n\tTotal: {0}\n\tAtendido por {1}",
                valortotal.ToString("F"),funcionarioativo.Nome);
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            btn_finalizar.Enabled = false;
            rtb_fatura.Text += string.Format("\n\tPagamento feito por: {0}",cmb_Pagamento.SelectedItem.ToString());
            rtb_fatura.Text += "\n********* OBRIGADO E VOLTE SEMPRE **********";
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
