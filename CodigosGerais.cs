using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public class CodigosGerais
    {
        public bool CampoVazio(Control controle, string campo)
        {
            if (controle.Text == "")
            {
                MessageBox.Show("O campo " + campo + " é obrigatorio!");
                controle.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
