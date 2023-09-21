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
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
            txtNum.Focus();
        }

        private void Calcular()
        {
            int num = Convert.ToInt32(txtNum.Text.Trim());

            if (num % 2 == 0)
            {
                txtResult.Text = "Este é um numero Par";
                txtNum.Clear();
            }
            else
            {
                txtResult.Text = "Este é um numero Impar";
                txtNum.Clear();
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if(!int.TryParse(txtNum.Text.Trim(), out int numt)){
                    MessageBox.Show("Favor inserir um numero inteiro","Atenção!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txtNum.Focus();
                    return;
                }else
                {
                    int num = Convert.ToInt32(txtNum.Text.Trim());

                    if (num % 2 == 0)
                    {
                        txtResult.Text = "Este é um numero Par";
                        txtNum.Clear();
                    }
                    else
                    {
                        this.Calcular();
                    }

                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Calcular();
        }
    }
}
