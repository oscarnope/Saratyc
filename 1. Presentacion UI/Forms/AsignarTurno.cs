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
    public partial class AsignarTurno : Form
    {
        public AsignarTurno(string institucion, string restriccionAuxPreferido, string restriccionAuxRechazado, string tipoTurno, string fechaInicio, string fechaFin, string idPaciente, string asignado, string? idAuxiliarSaratyc)
        {
            InitializeComponent();
            textBox1.Text = institucion;
            textBox2.Text = restriccionAuxPreferido;
            textBox3.Text = tipoTurno;
            textBox4.Text = fechaInicio;
            textBox5.Text = fechaFin;
            textBox6.Text = asignado;
            textBox7.Text = restriccionAuxRechazado;
            textBox8.Text = idPaciente;
        }

        private void AsignarTurno_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            //this.tbl_alunosBindingSource.Filter = string.Format("Nome LIKE '{0}%'", Variables.RecordName);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AsignarAuxiliar au = new AsignarAuxiliar();
            au.Activate();
            au.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //VerTurnos vt = new VerTurnos();
            //vt.Activate();
            //vt.Show();
        }
    }
    
}
