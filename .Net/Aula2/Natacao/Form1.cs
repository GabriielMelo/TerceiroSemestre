namespace Natacao
{
    public partial class Form1 : Form
    {
        int idade;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtAnoAtual.Focus();
            }
        }

        private void txtAnoAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnEnviar.Focus();
            }
        }

        private void txtAnoAtual_Enter(object sender, EventArgs e)
        {   
            if(txtNascimento.Text.Trim().Length !=4)
            {
                MessageBox.Show(
                    "Ano de nascimento deve conter 4 digitos", "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                txtNascimento.Focus();
            }
        }

        private void txtAnoAtual_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int anoNascimento = Convert.ToInt32(txtNascimento.Text);
            int anoAtual = Convert.ToInt32(txtAnoAtual.Text);

            if (anoNascimento >= anoAtual)
            { 
                MessageBox.Show(
                    "Ano ATUAL deve ser superior ao ano de NASCIMENTO", "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                e.Cancel = true;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == String.Empty ||
               txtNascimento.Text == String.Empty ||
               txtAnoAtual.Text == String.Empty
                )
            {
                MessageBox.Show(
                    "É necessário preencher todos os campos", "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information

                    );
            } else
            {
                int idade = Convert.ToInt32(txtAnoAtual.Text) - Convert.ToInt32(txtNascimento.Text);

                if (idade > 7)
                {
                    lblCategoriaValue.Text = "Adulto";
                } else if(idade > 13)
                {
                    lblCategoriaValue.Text = "Juvenil B";
                } else if(idade > 10)
                {
                    lblCategoriaValue.Text = "Juvenil A";
                } else if (idade > 7)
                {
                    lblCategoriaValue.Text = "Infantil B";
                } else if(idade >= 5)
                {
                    lblCategoriaValue.Text = "Infantil A";
                } else
                {
                    lblCategoriaValue.Text = "Não possui categoria";
                }

            }
        }
    }
}