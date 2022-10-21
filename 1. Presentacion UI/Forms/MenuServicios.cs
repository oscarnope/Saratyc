using Saratyc._4._Datos.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saratyc._1._Presentacion_UI.Forms
{
    public partial class MenuServicios : Form
    {
        ConexionMySQL conexion = new ConexionMySQL();
        public MenuServicios()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerTurnos at = new VerTurnos();
            at.Activate();
            at.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuServicios_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuxiliarEnfermeria ae = new AuxiliarEnfermeria();
            ae.Activate();
            ae.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            MenuCapacitacion mc = new MenuCapacitacion();
            mc.Activate();
            mc.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            MenuServicios ms = new MenuServicios();
            ms.Activate();
            ms.Show();
        }
    }
}
