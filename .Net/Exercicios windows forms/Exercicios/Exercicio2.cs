using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
            txtIdade.Focus();
        }

        public void VerificarIdade()
        {
            if (txtIdade.Text == String.Empty)
            {
                MessageBox.Show(
                    "Digite uma idade válida", "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
                txtIdade.Focus();
            }
            else
            {
                int idade = Convert.ToInt32(txtIdade.Text.Trim());

                if (idade <= 0)
                {
                    MessageBox.Show("Idade inválida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                    txtIdade.Focus();
                }
                else if (idade < 18)
                {
                    txtResult.Text = "Sem permissão!";
                    txtResult.ForeColor = Color.Red;
                    txtIdade.Clear();
                }
                else
                {
                    txtResult.Text = "“Permissão concedida!";
                    txtResult.ForeColor = Color.Green;
                    txtIdade.Clear();
                }
            }
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if(!int.TryParse(txtIdade.Text.Trim(),out int idade))
                {
                    MessageBox.Show(
                    "Digite uma idade válida", "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                    txtIdade.Focus();
                } else
                {
                    this.VerificarIdade();
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.VerificarIdade();

        }
    }
}
