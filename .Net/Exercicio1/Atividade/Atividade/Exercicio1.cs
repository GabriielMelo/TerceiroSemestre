using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade
{
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
            txtIdade.Focus();
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtIdade.Text.Trim() == String.Empty || !int.TryParse(txtIdade.Text, out int idade))
                {
                    MessageBox.Show(
                        "Digite um valor válido", "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
                else
                {
                    btnCalc.Focus();
                }
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtIdade.Text.Trim() == String.Empty)
            {
                MessageBox.Show(
                        "Digite um valor válido", "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
            }
            else
            {
                int idade = int.Parse(txtIdade.Text);
                idade = idade * 365;
                MessageBox.Show(
                    "A Sua idade é : " + idade + " Dias!!");
            }
        }

       
    }
}
