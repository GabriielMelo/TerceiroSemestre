
namespace Atividade
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuEx1_Click(object sender, EventArgs e)
        {
            Exercicio1 ex1 = new Exercicio1();
            ex1.MdiParent = this;
            ex1.Show();
        }

        private void mnuEx2_Click(object sender, EventArgs e)
        {
            Exercicio2 ex2 = new Exercicio2();
            ex2.MdiParent = this;
            ex2.Show();
        }

        private void mnuEx3_Click(object sender, EventArgs e)
        {
            Exercicio3 ex3 = new Exercicio3();  
            ex3.MdiParent = this;
            ex3.Show();
        }
    }
}