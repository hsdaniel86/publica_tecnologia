using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PLACAR
{
    public partial class Inserir : Form
    {
        public Inserir()
        {
            InitializeComponent();
        }

        // metodo que inicializa codigo fonte
        private void Form1_Load(object sender, EventArgs e)
        {
            Funcaosql.carrega(this.dataGridView1);
        }

        // button que ao click insere dados na tabela
        private void btninserir_Click(object sender, EventArgs e)
        {
            try
            {
                // classe que abre conexão com banco de dados
                Funcaosql.cn.Open();
                // comando que insere dados do usuario na tabela
                SqlCommand command = new SqlCommand("insert into Temporada values(" + txtplacar.Text + "," + txtmintemp.Text + "," + txtmaxtemp.Text + "," + txtrecmin.Text + "," + txtrecmax.Text + ")", Funcaosql.cn);
                // comando que executa registro na tabela
                command.ExecuteNonQuery();
                // apaga dados digitados no text.box ao inserir dados
                txtplacar.Clear();
                txtmaxtemp.Clear();
                txtmintemp.Clear();
                txtrecmax.Clear();
                txtrecmin.Clear();
            }
            catch (Exception ex)
            {
                // caso o codigo não execute retorna o motivo da falha 
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // campo que encerra conexão com banco de dados
                Funcaosql.cn.Close();
            }
            // classe que exibe tabela no dataGridView
            Funcaosql.carrega(this.dataGridView1);
        }

        // button que ao click encerra a interface 
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
