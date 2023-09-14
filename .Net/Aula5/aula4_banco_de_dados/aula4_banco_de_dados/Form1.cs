using System.Data;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace aula4_banco_de_dados
{
    public partial class formAgenda : Form
    {
        public formAgenda()
        {
            InitializeComponent();
        }

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataset;


        private void Conectar()
        {
            mDataset = new DataSet();
            mConn = new MySqlConnection("Persist Security Info = False;" 
                + "Server = localhost;" 
                + "database = Cadastro;"
                + "uid = root; pwd = root;");

            try
            {
                mConn.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void mostrarResultados()
        {
            if(mConn.State  == ConnectionState.Open)
            {
                // Cria um adapter usando a instrução SQL a para acessar a tabela contatos
                mAdapter = new MySqlDataAdapter("SELECT ID,NOME,EMAIL FROM CONTATOS",mConn);
                // Preencher dataset via adapter
                mAdapter.Fill(mDataset, "Contatos");
                //Atribuir a resultado a propriedade DataSource e DataGrid
                dgvDados.DataSource = mDataset;
                dgvDados.DataMember = "Contatos";
                mConn.Close();
            }
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
        }

        

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtEmail.Text != "")
            {
                Conectar();
                // Query SQL
                MySqlCommand command = new MySqlCommand("INSERT INTO contatos (nome,email)"
                    + "VALUES('" + txtNome.Text + "','" + txtEmail.Text + "')", mConn);
                // Executar a Query SQL
                command.ExecuteNonQuery();
                // Mensagem Sucesso.
                MessageBox.Show("Gravado com Sucesso", "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                mostrarResultados();
                Limpar();
            }
            else
            {
                MessageBox.Show("Não é possivel inserir valores em Banco", "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }



        private void formAgenda_Load(object sender, EventArgs e)
        {
            Conectar();
            mostrarResultados();
            Limpar();  
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = this.dgvDados.CurrentRow.Cells["id"].Value.ToString();
            if(id != null)
            {
                this.txtNome.Text = Convert.ToString(this.dgvDados.CurrentRow.Cells["nome"].Value.ToString());
                this.txtEmail.Text = Convert.ToString(this.dgvDados.CurrentRow.Cells["email"].Value.ToString());
            }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            string valor_id = this.dgvDados.CurrentRow.Cells["id"].Value.ToString();


            if(valor_id != String.Empty)
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("DELETE FROM Contatos WHERE ID ='" + valor_id + "';", mConn);
                command.ExecuteNonQuery();
                MessageBox.Show("Registro Excluido com sucesso");
                mostrarResultados();
                Limpar();
            } else
            {
                MessageBox.Show("Insira um registro para excluir","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string valor_id = this.dgvDados.CurrentRow.Cells["id"].Value.ToString();
            string sql = "UPDATE Contatos SET nome = '" + txtNome.Text + "', email = '" + txtEmail.Text + "' WHERE id ='" + valor_id +
                "';";   
            if(valor_id != String.Empty)
            {
                Conectar();
                MySqlCommand command = new MySqlCommand(sql,mConn);
                command.ExecuteNonQuery();
                MessageBox.Show("Registro Alterado com sucesso");
                mostrarResultados();
                Limpar();

            } else
            {
                MessageBox.Show("Insira um registro para Atualizar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}