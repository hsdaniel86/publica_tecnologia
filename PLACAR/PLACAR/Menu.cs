using System;
using System.Windows.Forms;

namespace PLACAR
{
    // metodo que inicializa codigo fonte
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        // button que ao click abre a interface para calcular
        private void btncalcular_Click(object sender, EventArgs e)
        {
            Calcular calcular = new Calcular();
            calcular.ShowDialog();
        }

        // button que ao click abre a interface para inserir dados
        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            consultar.ShowDialog();
        }

        // button que ao click abre a interface para consultar dados
        private void btninserir_Click(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir();
            inserir.ShowDialog();
        }

        // button que ao click encerra a interface 
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
