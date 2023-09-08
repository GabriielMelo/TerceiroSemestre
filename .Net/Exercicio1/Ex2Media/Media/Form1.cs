namespace Media
{
    public partial class Form1 : Form
    {
        public List<String> nomes = new List<string>();
        public List<Double> salarios = new List<Double>();
        public List<int> filhos = new List<int>();
        public int count = 0;

        public Form1()
        {
            InitializeComponent();
            btnCalcular.Enabled = false;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtNome.Text == String.Empty)
                {
                    MessageBox.Show("Digite um nome válido", "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    txtNome.Clear();
                    txtNome.Focus();
                }
                else
                {
                    txtSalario.Focus();
                }
            }
        }



        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!double.TryParse(txtSalario.Text, out double salario))
                {
                    MessageBox.Show("Valor Inválido", "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    txtSalario.Clear();
                    txtSalario.Focus();
                }
                else
                {
                    txtFilhos.Focus();
                }
            }
        }

        private void txtFilhos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!Int32.TryParse(txtFilhos.Text, out int filhos)
                    || txtFilhos.Text.Trim().Length > 2)
                {
                    MessageBox.Show("Quantidade inválida", "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    txtFilhos.Clear();
                    txtFilhos.Focus();
                }
                else
                {
                    btnAdd.Focus();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 20)
            {
                btnAdd.Enabled = false;
                btnCalcular.Enabled = true;
                btnCalcular.Focus();
            }
            else
            {

                if (txtNome.Text == String.Empty
                    || txtSalario.Text == String.Empty
                    || txtFilhos.Text == String.Empty)
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
                    String auxNome = txtNome.Text;
                    Double auxSalario = Convert.ToDouble(txtSalario.Text.Trim());
                    int auxFilhos = Convert.ToInt32(txtFilhos.Text.Trim());

                    nomes.Add(auxNome);
                    salarios.Add(auxSalario);
                    filhos.Add(auxFilhos);

                    txtNome.Clear();
                    txtSalario.Clear();
                    txtFilhos.Clear();
                    txtNome.Focus();

                }

            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String formato = "0.00";
            Double mediaSalario = salarios.Average();
            string salario = mediaSalario.ToString(formato);
            int mediaFilhos = (int)filhos.Average();

            MessageBox.Show(
                "Média Salarial das familias : " + salario +
                "\nMédia de filhos : " + mediaFilhos
                );
            count = 0;
            btnAdd.Enabled = true;
            btnCalcular.Enabled = false;
        }
    }
}
