namespace Tabuada
{
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            int num = Convert.ToInt32(txtNumero.Text);
            for(int i = 1; i <= 10; i++)
            {
                lstResultado.Items.Add(txtNumero.Text.ToString() + "x" + i.ToString() + " = " + num*i);
            }
        }
    }
}