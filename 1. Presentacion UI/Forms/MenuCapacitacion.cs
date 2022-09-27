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
    public partial class MenuCapacitacion : Form
    {
        public MenuCapacitacion()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MenuCapacitacion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            DisenarPlan mc = new DisenarPlan();
            mc.Activate();
            mc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            SeguimientoPlan sp = new SeguimientoPlan();
            sp.Show();
            sp.Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            ParametrizarTema pt = new ParametrizarTema();
            pt.Activate();
            pt.Show();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            Hide();
            MenuServicios ms = new MenuServicios();
            ms.Activate();
            ms.Show();
        }
    }
}
