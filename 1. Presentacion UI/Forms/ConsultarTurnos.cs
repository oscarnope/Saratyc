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
    public partial class ConsultarTurnos : Form
    {
        string idTurno;
        string institucion;
        string restriccionAuxPreferido;
        string restriccionAuxRechazado;
        string tipoTurno;
        string fechaInicio;
        string fechaFin;
        string idPaciente;
        string idAuxiliarEnferdata;
        string idAuxiliarSaratyc;




        List<string> lTurnos = new List<string>();
        BTurno bTurno = new();
        BVerTurnos bVerTurnos = new();

        public ConsultarTurnos()
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
            //this.Hide();
            //AsignarTurno at = new AsignarTurno(institucion, restriccionAuxPreferido, restriccionAuxRechazado, tipoTurno, fechaInicio, fechaFin, idPaciente, idAuxiliarEnferdata,idAuxiliarSaratyc);
            //at.Activate();
            //at.Show();
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
            idAuxiliarEnferdata = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            idAuxiliarSaratyc = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            //this.Hide();
            AsignarTurno at = new AsignarTurno(institucion, restriccionAuxPreferido, restriccionAuxRechazado, tipoTurno, fechaInicio, fechaFin, idPaciente, idAuxiliarEnferdata,idAuxiliarSaratyc);
            at.Activate();
            at.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Se muestran todos los turnos que dan inicio en la fecha seleccionada y aun no finalizan

            Indicador.ForeColor = Color.Blue;
            Indicador.Text = "Buscando Turnos...";

            string fechaSeleccionada = dateTimePicker1.Value.ToString("dd-MMM-yy");//Se guarda la fecha seleccionada
            dataGridView1.Rows.Clear(); //Se limpia el datagrid
            dataGridView1.Refresh(); // Se refresca el dataGrid

            lTurnos = bTurno.cargarTurnos();
            foreach (string turno in lTurnos)
            {
                var columns = turno.Split(',').ToList();
                idTurno = columns[0].ToString();
                institucion = columns[1].ToString();
                restriccionAuxPreferido = columns[2].ToString();
                restriccionAuxRechazado = columns[3].ToString();
                tipoTurno = columns[4].ToString();
                fechaInicio = columns[5].ToString();
                fechaFin = columns[6].ToString();
                idPaciente = columns[7].ToString();
                idAuxiliarEnferdata = columns[8].ToString();
                idAuxiliarSaratyc = columns[9].ToString();


                int año = bVerTurnos.obtenerAño(fechaInicio);
                int mes = bVerTurnos.obtenerMes(fechaInicio);
                int dia = bVerTurnos.obtenerDia(fechaInicio);

                DateTime datefechaInicio = new DateTime(año,dia,mes);
                string SfechaInicio = datefechaInicio.ToString("dd-MMM-yy");

                if (SfechaInicio.Equals(fechaSeleccionada) && idAuxiliarEnferdata.Equals(""))
                {
                    //Si la fecha de inicio del turno es igual a la seleccionada lo muestra
                    dataGridView1.Rows.Add(institucion, restriccionAuxPreferido, restriccionAuxRechazado, tipoTurno, fechaInicio, fechaFin, idPaciente, idAuxiliarEnferdata, idAuxiliarSaratyc);
                }
            }

            //Si no se encuentra ningun turno, solo existira una fila, vacia, por eso se preguinta por el numero 1
            string registros = dataGridView1.Rows.Count.ToString();
            if (registros.Equals("1"))
            {
                Indicador.ForeColor = Color.Red;
                Indicador.Text = "No se encontraron turnos sin asignar";
            }
            else
            {
                Indicador.ForeColor = Color.Blue;
                Indicador.Text = "Búsqueda Finalizada";
            }


            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //dataGridView1.AllowUserToOrderColumns = true;
            //dataGridView1.AllowUserToResizeColumns = true;


        }



        private void button1_Click(object sender, EventArgs e)
        {
            //Se muestran todos los turnos que no tienen asignacion en enferdata y aun no finalizan

            Indicador.ForeColor = Color.Blue;
            Indicador.Text = "Buscando Turnos...";


            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            lTurnos = bTurno.cargarTurnos();

            foreach (string turno in lTurnos)
            {
                var columns = turno.Split(',').ToList();
                idTurno = columns[0].ToString();
                institucion = columns[1].ToString();
                restriccionAuxPreferido = columns[2].ToString();
                restriccionAuxRechazado = columns[3].ToString();
                tipoTurno = columns[4].ToString();
                fechaInicio = columns[5].ToString();
                fechaFin = columns[6].ToString();
                idPaciente = columns[7].ToString();
                idAuxiliarEnferdata = columns[8].ToString();
                idAuxiliarSaratyc = columns[9].ToString();

                //Se elimina la hora de las fechas
                fechaInicio = fechaInicio.Substring(0,fechaInicio.IndexOf(" "));
                fechaFin = fechaFin.Substring(0, fechaFin.IndexOf(" "));


                if (idAuxiliarEnferdata.Equals(""))
                {
                    dataGridView1.Rows.Add(institucion, restriccionAuxPreferido, restriccionAuxRechazado, tipoTurno, fechaInicio, fechaFin, idPaciente, idAuxiliarEnferdata, idAuxiliarSaratyc);
                }
            }

            //Si no se encuentra ningun turno, solo existira una fila, vacia, por eso se pregunta por el numero 1
            string registros = dataGridView1.Rows.Count.ToString();
            if (registros.Equals("1"))
            {
                Indicador.ForeColor = Color.Red;
                Indicador.Text = "No se encontraron turnos sin asignar";
            }
            else
            {
                Indicador.ForeColor = Color.Blue;
                Indicador.Text = "Búsqueda Finalizada";
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Se muestran todos los turnos que no tienen asignacion en Saratyc y aun no finalizan

            Indicador.ForeColor = Color.Blue;
            Indicador.Text = "Buscando Turnos...";

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            lTurnos = bTurno.cargarTurnos();
            foreach (string turno in lTurnos)
            {
                var columns = turno.Split(',').ToList();
                idTurno = columns[0].ToString();
                institucion = columns[1].ToString();
                restriccionAuxPreferido = columns[2].ToString();
                restriccionAuxRechazado = columns[3].ToString();
                tipoTurno = columns[4].ToString();
                fechaInicio = columns[5].ToString();
                fechaFin = columns[6].ToString();
                idPaciente = columns[7].ToString();
                idAuxiliarEnferdata = columns[8].ToString();
                idAuxiliarSaratyc = columns[9].ToString();

                //Se elimina la hora de las fechas
                fechaInicio = fechaInicio.Substring(0, fechaInicio.IndexOf(" "));
                fechaFin = fechaFin.Substring(0, fechaFin.IndexOf(" "));

                //if (idAuxiliarSaratyc.Equals("") && (fechaInicio.Equals("10/10/2022 12:00:00 AM") || fechaInicio.Equals("10/10/2022 12:00:00 AM") || fechaInicio.Equals("10/10/2022 12:00:00 AM")))
                if (idAuxiliarSaratyc.Equals(""))
                {
                    dataGridView1.Rows.Add(institucion, restriccionAuxPreferido, restriccionAuxRechazado, tipoTurno, fechaInicio, fechaFin, idPaciente, idAuxiliarEnferdata, idAuxiliarSaratyc);
                }
            }

            //Si no se encuentra ningun turno, solo existira una fila, vacia, por eso se pregunta por el numero 1
            string registros = dataGridView1.Rows.Count.ToString();
            if (registros.Equals("1"))
            {
                Indicador.ForeColor = Color.Red;
                Indicador.Text = "No se encontraron turnos sin asignar";
            }
            else
            {
                Indicador.ForeColor = Color.Blue;
                Indicador.Text = "Búsqueda Finalizada";
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Se muestran todos los turnos de cualquier ficha de inicio que aun no finalizan

            string fechaSeleccionada = dateTimePicker1.Value.ToString("dd-MMM-yy");//Se guarda la fecha seleccionada
            dataGridView1.Rows.Clear(); //Se limpia el datagrid
            dataGridView1.Refresh(); // Se refresca el dataGrid

            lTurnos = bTurno.cargarTurnos();
            foreach (string turno in lTurnos)
            {
                var columns = turno.Split(',').ToList();
                idTurno = columns[0].ToString();
                institucion = columns[1].ToString();
                restriccionAuxPreferido = columns[2].ToString();
                restriccionAuxRechazado = columns[3].ToString();
                tipoTurno = columns[4].ToString();
                fechaInicio = columns[5].ToString();
                fechaFin = columns[6].ToString();
                idPaciente = columns[7].ToString();
                idAuxiliarEnferdata = columns[8].ToString();
                idAuxiliarSaratyc = columns[9].ToString();

                dataGridView1.Rows.Add(institucion, restriccionAuxPreferido, restriccionAuxRechazado, tipoTurno, fechaInicio, fechaFin, idPaciente, idAuxiliarEnferdata, idAuxiliarSaratyc);

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
