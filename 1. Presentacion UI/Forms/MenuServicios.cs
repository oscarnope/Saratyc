using Saratyc._4._Datos.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            ConsultarTurnos at = new ConsultarTurnos();
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
            DatosAuxiliar ae = new DatosAuxiliar();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            PQR pqr = new PQR();
            pqr.Activate();
            pqr.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://datastudio.google.com/reporting/62f6561c-4151-4c5f-8a75-a0284a1eb234/page/qgR";
                myProcess.Start();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }


        }
    }
}
