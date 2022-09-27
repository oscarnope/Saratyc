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
    public partial class AuxiliarRecomendado : Form
    {
        public AuxiliarRecomendado()
        {
            InitializeComponent();
        }

        private void AuxiliarRecomendado_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            textBox1.Text = "nombreAux1";
            textBox2.Text = "apellido1Aux1";
            textBox3.Text = "id1Aux1";
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerTurnos vt = new VerTurnos();
            vt.Activate();
            vt.Show();
        }
    }
}
