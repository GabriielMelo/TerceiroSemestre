namespace Aula3_Formularios
{
    public partial class frmAula3 : Form
    {
        public frmAula3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            while (contador <= 10)
            {
                lstWhile.Items.Add(contador);
                contador++;
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 10; i++){
                lstFor.Items.Add(i);
            }
        }

        private void btnforeach_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[5] {"Avril Lavigne","Rihanna",
                "Beyonce","Billie Eillish","Taylor Swift"};
            foreach(string nome in nomes)
            {
                lstForeach.Items.Add(nome); 
            }
        }
    }
}