using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PLACAR
{
    // metodo que inicializa codigo fonte
    public partial class Calcular : Form
    {
        public Calcular()
        {
            InitializeComponent();
        }
        
        // button que ao click calcula dados coluna Placar
        private void btncalpla_Click(object sender, EventArgs e)
        {
            try
            {
                // classe que abre conexão com banco de dados
                Funcaosql.cn.Open();
                // comando sql que retorna calculo da coluna placar  na tabela painel
                SqlCommand command = new SqlCommand("select sum (Placar) from Temporada", Funcaosql.cn);
                // comando que exibe resultado da consulta no textbox
                txttotal.Text = command.ExecuteScalar().ToString();
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

        // button que ao click calcula dados coluna máximo da temporada
        private void btncalmax_Click(object sender, EventArgs e)
        {
            try
            {
                // classe que abre conexão com banco de dados
                Funcaosql.cn.Open();
                // comando sql que retorna calculo da somente as vezes que foi alterado coluna maximo temporada na tabela painel
                SqlCommand command = new SqlCommand("select sum (distinct Maximo_temporada) from Temporada", Funcaosql.cn);
                // comando que exibe resultado da consulta no textbox
                txttotal.Text = command.ExecuteScalar().ToString();
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

        // button que ao click calcula dados coluna minimo da temporada
        private void btncalmin_Click(object sender, EventArgs e)
        {
            try
            {
                // classe que abre conexão com banco de dados
                Funcaosql.cn.Open();
                // comando sql que retorna calculo da somente as vezes que foi alterado coluna minimo temporada na tabela painel
                SqlCommand command = new SqlCommand("select sum (distinct Minimo_temporada) from Temporada", Funcaosql.cn);
                // comando que exibe resultado da consulta no textbox
                txttotal.Text = command.ExecuteScalar().ToString();
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

        // button que ao click busca total de vezes que foi quebrado o recorde máximo
        private void btnrecmax_Click(object sender, EventArgs e)
        {
            try
            {
                // classe que abre conexão com banco de dados
                Funcaosql.cn.Open();
                // comando sql que retorna quantidade de vezes que foi quebrado o recorde na coluna recorde minimo da temporada na tabela painel
                SqlCommand command = new SqlCommand("select max (Quebra_de_recorde_maximo) from Temporada", Funcaosql.cn);
                // comando que exibe resultado da consulta no textbox
                txttotal.Text = command.ExecuteScalar().ToString();
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

        // button que ao click busca total de vezes que foi quebrado o recorde minimo 
        private void btncamin_Click(object sender, EventArgs e)
        {
            try
            {
                // classe que abre conexão com banco de dados
                Funcaosql.cn.Open();
                // comando sql que retorna quantidade de vezes que foi quebrado o recorde na coluna recorde minimo da temporada na tabela painel
                SqlCommand command = new SqlCommand("select max (Quebra_de_recorde_minimo) from Temporada", Funcaosql.cn);
                // comando que exibe resultado da consulta no textbox
                txttotal.Text = command.ExecuteScalar().ToString();
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
        private void btncancela_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
