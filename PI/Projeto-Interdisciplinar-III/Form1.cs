namespace Projeto_Interdisciplinar_III
   

{
    using System.Data;
    using MySql;
    using MySql.Data;
    using MySql.Data.MySqlClient;


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Conectar();
        }

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        private void Conectar()
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection("Persist Security Info=false;"+ 
                                        "server = localhost;" +
                                        "database = estacionamento;" +
                                        "uid = root; pwd = root; ");
            
            try
            {
                mConn.Open();
                MessageBox.Show("Conex�o bem-sucedida!");
            } catch(System.Exception ex)
            {
                MessageBox.Show("Conex�o falhou " , ex.ToString());
            }

        }

    }
}