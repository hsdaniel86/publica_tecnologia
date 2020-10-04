using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PLACAR
{
    class Funcaosql
    {
        // metodo sql que conecta ao banco de dados
        public static SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hilton\Source\Repos\hsdaniel86\publica_tecnologia\PLACAR\PLACAR\publicabd.mdf;Integrated Security=True");

        public static void carrega(DataGridView grid)
        {
            try
            {
                // campo que abre conexão com banco de dados
                cn.Open();
                // comando sql que selciona colunas e tabela do banco de dados
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Temporada", cn);
                // biblioteca que preenche dataGridView
                DataTable table = new DataTable();
                // variavel que adapta tabela na biblioteca dataTable
                adapter.Fill(table);
                // comando de carrega variavel table no dataDridView
                grid.DataSource = table;
            }
            catch (FormatException fex)
            {
                // caso o usuario inserir dado
                MessageBox.Show(fex.ToString());
            }
            catch (Exception ex)
            {
                // caso o codigo não execute retorna o motivo da falha 
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // campo que encerra conexão com banco de dados
                cn.Close();
            }
        }
    }
}
