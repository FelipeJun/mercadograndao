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
    public partial class TelaUsuario : Form
    {
        public Funcionario funcionarioativo;
        public TelaUsuario()
        {
            InitializeComponent();
        }

        private void btn_atendente_Click(object sender, EventArgs e)
        {
            funcionarioativo = new Atendente("Atendente");
            this.Hide();
        }

        private void btn_diretor_Click(object sender, EventArgs e)
        {
            funcionarioativo = new Diretor("Diretor");
            this.Hide();
            
        }

        private void btn_gerente_Click(object sender, EventArgs e)
        {
            funcionarioativo = new Gerente("Gerente");
            this.Hide();
        }
    }
}
