namespace Exercicio1
{
    public partial class Exercicio : Form
    {
        public Exercicio()
        {
            InitializeComponent();
        }

        private void mnuExercicio2_Click(object sender, EventArgs e)
        {
            Exercicio2 ex2 = new Exercicio2();  
            ex2.MdiParent = this;
            ex2.Show();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}