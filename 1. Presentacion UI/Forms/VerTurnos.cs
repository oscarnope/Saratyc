using Saratyc._2._Negocio.BL;
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
    public partial class VerTurnos : Form
    {
        string institucion;
        string restriccionAuxPreferido;
        string restriccionAuxRechazado;
        string tipoTurno;
        string fechaInicio;
        string fechaFin;
        string idPaciente;
        string asignado;

        List<string> lTurnos = new List<string>();
        BTurno bTurno = new();

        public VerTurnos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AsignarTurno_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            AsignarTurno at = new AsignarTurno(institucion, restriccionAuxPreferido, restriccionAuxRechazado, tipoTurno, fechaInicio, fechaFin, idPaciente, asignado);
            at.Activate();
            at.Show();
        }

        private void dataGridView1_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {

            institucion = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            restriccionAuxPreferido = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            restriccionAuxRechazado = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tipoTurno = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            fechaInicio = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fechaFin = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            idPaciente = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            asignado = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            this.Hide();
            AsignarTurno at = new AsignarTurno(institucion, restriccionAuxPreferido, restriccionAuxRechazado, tipoTurno, fechaInicio, fechaFin, idPaciente, asignado);
            at.Activate();
            at.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string theDate = dateTimePicker1.Value.ToString("dd-MMM-yy");

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            //dataGridView1.Columns.Add("asignado", "Asignado");

            lTurnos = bTurno.cargarTurnos();
            foreach (string turno in lTurnos)
            {
                var columns = turno.Split(',').ToList();
                institucion = columns[0].ToString();
                restriccionAuxPreferido = columns[1].ToString();
                restriccionAuxRechazado = columns[2].ToString();
                tipoTurno = columns[3].ToString();
                fechaInicio = columns[4].ToString();
                fechaFin = columns[5].ToString();
                idPaciente = columns[6].ToString();
                asignado = columns[7].ToString();
                if (fechaInicio.Equals(theDate))
                    {
                        dataGridView1.Rows.Add(institucion, restriccionAuxPreferido, restriccionAuxRechazado, tipoTurno, fechaInicio, fechaFin, idPaciente, asignado);
                    }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("dd-MMM-yy");

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            lTurnos = bTurno.cargarTurnos();
            foreach (string turno in lTurnos)
            {
                var columns = turno.Split(',').ToList();
                institucion = columns[0].ToString();
                restriccionAuxPreferido = columns[1].ToString();
                restriccionAuxRechazado = columns[2].ToString();
                tipoTurno = columns[3].ToString();
                fechaInicio = columns[4].ToString();
                fechaFin = columns[5].ToString();
                idPaciente = columns[6].ToString();
                asignado = columns[7].ToString();

                if (fechaInicio.Equals(theDate) && asignado.Equals("No"))
                {
                    dataGridView1.Rows.Add(institucion, restriccionAuxPreferido, restriccionAuxRechazado, tipoTurno, fechaInicio, fechaFin, idPaciente, asignado);
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("dd-MMM-yy");

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            lTurnos = bTurno.cargarTurnos();
            foreach (string turno in lTurnos)
            {
                var columns = turno.Split(',').ToList();
                institucion = columns[0].ToString();
                restriccionAuxPreferido = columns[1].ToString();
                restriccionAuxRechazado = columns[2].ToString();
                tipoTurno = columns[3].ToString();
                fechaInicio = columns[4].ToString();
                fechaFin = columns[5].ToString();
                idPaciente = columns[6].ToString();
                asignado = columns[7].ToString();

                if (fechaInicio.Equals(theDate) && asignado.Equals("Si"))
                {
                    dataGridView1.Rows.Add(institucion, restriccionAuxPreferido, restriccionAuxRechazado, tipoTurno, fechaInicio, fechaFin, idPaciente, asignado);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string theDate = dateTimePicker1.Value.ToString("dd-MMM-yy");

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            //dataGridView1.Columns.Add("asignado", "Asignado");

            lTurnos = bTurno.cargarTurnos();
            foreach (string turno in lTurnos)
            {
                var columns = turno.Split(',').ToList();
                institucion = columns[0].ToString();
                restriccionAuxPreferido = columns[1].ToString();
                restriccionAuxRechazado = columns[2].ToString();
                tipoTurno = columns[3].ToString();
                fechaInicio = columns[4].ToString();
                fechaFin = columns[5].ToString();
                idPaciente = columns[6].ToString();
                asignado = columns[7].ToString();
                if (fechaInicio.Equals(theDate))
                {
                    dataGridView1.Rows.Add(institucion, restriccionAuxPreferido, restriccionAuxRechazado, tipoTurno, fechaInicio, fechaFin, idPaciente, asignado);
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
