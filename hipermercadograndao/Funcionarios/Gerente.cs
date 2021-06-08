using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hipermercadograndao.Funcionarios
{
    public class Gerente : Funcionario, IAcessoPrivilegiado
    {
        public Gerente(string nome) : base( nome)
        {

        }
        public void Remover()
        {
            System.Windows.Forms.MessageBox.Show("Removido com sucesso!");
        }
    }
}
