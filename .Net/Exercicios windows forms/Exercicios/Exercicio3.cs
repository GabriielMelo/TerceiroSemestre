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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if(!Double.TryParse(txtNum1.Text.Trim(), out double num))
                {
                    MessageBox.Show(
                    "Digite um numero válido", "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                    txtNum1.Focus();
                    txtNum1.Clear();
                }
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if (!Double.TryParse(txtNum1.Text.Trim(), out double num))
                {
                    MessageBox.Show(
                    "Digite um numero válido", "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                    txtNum2.Focus();
                    txtNum2.Clear();
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtNum1.Text == String.Empty || txtNum2.Text == String.Empty)
            {
                MessageBox.Show(
                    "Digite um numero válido", "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
                txtNum1.Focus();
            } else
            {
                double n1 = Double.Parse(txtNum1.Text.Trim());
                double n2 = Double.Parse(txtNum2.Text.Trim());
                switch (txtOperacao.Text.Trim())
                {
                    case "Somar":
                        txtResult.Text = "Resultado : " + (n1 + n2).ToString();
                        break;
                    case "Subtrair":
                        txtResult.Text = "Resultado : " + (n1 - n2).ToString();
                        break;
                    case "Multiplicar":
                        txtResult.Text = "Resultado : " + (n1 * n2).ToString();
                        break;
                    case "Dividir":
                     txtResult.Text = "Resultado : " + (n1 / n2).ToString();
                        break;
                    default:
                        MessageBox.Show("Selecione a Operação!");
                        break;
                }
                txtNum1.Clear();
                txtNum2.Clear();
            }
        }
    }
}
