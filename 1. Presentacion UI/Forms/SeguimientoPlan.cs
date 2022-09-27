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
    public partial class SeguimientoPlan : Form
    {
        public SeguimientoPlan()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SeguimientoPlan_Load(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            Hide();
            MenuCapacitacion mc = new MenuCapacitacion();
            mc.Activate();
            mc.Show();
        }
    }
}
