using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PLACAR
{
    public partial class Consultar : Form
    {
        // metodo que inicializa codigo fonte
        public Consultar()
        {
            InitializeComponent();
        }


        private void Consultar_Load(object sender, EventArgs e)
        {
            // metodo que inicializa codigo fonte
            Funcaosql.carrega(this.dataGridView1);
        }

        // button que com um click retorna maior numero de pontos no textbox
        private void btnmax_Click(object sender, EventArgs e)
        {
            try
            {
                // classe que abre conexão com banco de dados
                Funcaosql.cn.Open();
                // comando sql que retorna maior valor da coluna placar na tabela painel
                SqlCommand command = new SqlCommand("select max (Placar) from Temporada", Funcaosql.cn);
                // comando que exibe resultado da consulta no textbox
                txtconsulta.Text = command.ExecuteScalar().ToString();
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
        }

        // button que com um click retorna menor numero de pontos no textbox
        private void btnminimo_Click(object sender, EventArgs e)
        {
            try
            {
                // classe que abre conexão com banco de dados
                Funcaosql.cn.Open();
                // comando sql que retorna menor valor da coluna placar na tabela painel
                SqlCommand command = new SqlCommand("select min (Placar) from Temporada", Funcaosql.cn);
                // comando que exibe resultado da consulta no textbox
                txtconsulta.Text = command.ExecuteScalar().ToString();
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
        }

        // button que com um click retorna total de jogos no textbox
        private void btnjogos_Click(object sender, EventArgs e)
        {
            try
            {
                // classe que abre conexão com banco de dados
                Funcaosql.cn.Open();
                // comando sql que retorna total de linhas coluna jogo na tabela painel
                SqlCommand command = new SqlCommand("select max (Jogo) from Temporada", Funcaosql.cn);
                // comando que exibe resultado da consulta no textbox
                txtconsulta.Text = command.ExecuteScalar().ToString();
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
        }

        // button que ao click encerra a interface 
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
