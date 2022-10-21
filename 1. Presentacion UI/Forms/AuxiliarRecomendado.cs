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

            textBox55.Text = "Alerta/orientado";
            textBox54.Text = "Drenes";
            textBox53.Text = "Comatoso";
            textBox51.Text = "Paciente sin compañía";
            textBox49.Text = "Dependiente Moderado";

            textBox59.Text = "SI";
            textBox57.Text = "SI";
            textBox52.Text = "SI";
            textBox50.Text = "SI";
            textBox48.Text = "SI";

            textBox58.Text = "SI";
            textBox56.Text = "NO";

            textBox65.Text = "Ansioso (a)";
            textBox64.Text = "Domicilio";
            textBox63.Text = "Comatoso";
            textBox62.Text = "Paciente sin compañía";
            textBox49.Text = "Dependiente Moderado";

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
