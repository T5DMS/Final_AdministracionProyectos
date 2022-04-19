using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_formMatricula_Click(object sender, EventArgs e)
        {
            Matricula matricula = new Matricula();
            matricula.ShowDialog();
        }

        private void btn_formConsultas_Click(object sender, EventArgs e)
        {
            PantallaGeneral general = new PantallaGeneral();
            general.ShowDialog();
        }
    }
}
