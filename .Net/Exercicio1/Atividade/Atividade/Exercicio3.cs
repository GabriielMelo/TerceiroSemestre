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
    public partial class Exercicio3 : Form
    {
        public List<String> nomes = new List<string>();
        public List<Double> nota1 = new List<Double>();
        public List<Double> nota2 = new List<Double>();
        public int count = 0;

        public Exercicio3()
        {
            InitializeComponent();
            btnCalcular.Enabled = false;

        }

        private void txtNomes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtNomes.Text == String.Empty)
                {
                    MessageBox.Show("Digite um nome válido", "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    txtNomes.Clear();
                    txtNomes.Focus();
                }
                else
                {
                    txtNota1.Focus();
                }
            }
        }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!double.TryParse(txtNota1.Text, out double nota1))
                {
                    MessageBox.Show("Valor Inválido", "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    txtNota1.Clear();
                    txtNota1.Focus();
                }
                else
                {
                    txtNota2.Focus();
                }
            }
        }

        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!double.TryParse(txtNota2.Text, out double nota1))
                {
                    MessageBox.Show("Valor Inválido", "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    txtNota2.Clear();
                    txtNota2.Focus();
                }
                else
                {
                    btnAdd.Focus();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (count == 10)
            {
                btnAdd.Enabled = false;
                btnCalcular.Enabled = true;
                btnCalcular.Focus();
            }
            else
            {

                if (txtNomes.Text == String.Empty
                    || txtNota1.Text == String.Empty
                    || txtNota2.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Todos Campos devem ser Preenchidos", "Atenção!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    return;
                }
                else
                {
                    String auxNomes = txtNomes.Text;
                    Double auxNota1 = Convert.ToDouble(txtNota1.Text.Trim());
                    Double auxNota2 = Convert.ToDouble(txtNota2.Text.Trim());

                    nomes.Add(auxNomes);
                    nota1.Add(auxNota1);
                    nota2.Add(auxNota2);

                    txtNomes.Clear();
                    txtNota1.Clear();
                    txtNota2.Clear();
                    txtNomes.Focus();
                    count++;
                    txtResult.Text = count.ToString();
                }

            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double somaNotas = 0;
            int aprovados = 0;
            int exames = 0;
            int reprovados = 0;

            for (int i = 0; i < nomes.Count; i++)
            {
                double media = (nota1[i] + nota2[i]) / 2;
                somaNotas += media;

                if (media >= 7.0)
                {
                    aprovados++;
                }
                else if (media >= 4.0)
                {
                    exames++;
                }
                else
                {
                    reprovados++;
                }
            }

            double mediaClasse = somaNotas / nomes.Count;

            string resultado = $"Resultados:\n\n";
            resultado += $"Média da classe: {mediaClasse:F2}\n";
            resultado += $"Quantidade de aprovados: {aprovados}\n";
            resultado += $"Quantidade de alunos de exame: {exames}\n";
            resultado += $"Quantidade de reprovados: {reprovados}\n";

            MessageBox.Show(resultado, "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNomes.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNomes.Focus();
            btnAdd.Enabled = true;
            btnCalcular.Enabled = false;

        }
    }
}

