namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            float n1;
            float n2;

            if (!float.TryParse(txtNum1.Text, out float result1))
            {
                MessageBox.Show(
                    "Apenas numeros são aceitos", "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                txtNum1.Text = "";
                return;
            } else
            {
              n1 = float.Parse(txtNum1.Text);
            }
            if(!    float.TryParse(txtNum2.Text, out float result2)) 
            {
                MessageBox.Show(
                     "Apenas numeros são aceitos", "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }else
            {
                n2 = float.Parse(txtNum2.Text);
            }

            switch (comboBox1.Text.Trim())

            {
                case "+":
                    lblResult.Text = (n1 + n2).ToString();
                    break;
            }
        }
    }
}