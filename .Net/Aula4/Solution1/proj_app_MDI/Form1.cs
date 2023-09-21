namespace proj_app_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void mnuNovo_Click(object sender, EventArgs e)
        {   //Instanciando novo editor de texto.
            FrmEditorTexto editorTexto = new FrmEditorTexto();
            // Definir se ele é filho
            editorTexto.MdiParent = this;
            // Exibir formulario filho
            editorTexto.Show();
        }

        private void mnuFechar_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void mnuAbrir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Você clicou no botão abrir","Atenção!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void emCascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void ladoALadoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ladoALadoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}