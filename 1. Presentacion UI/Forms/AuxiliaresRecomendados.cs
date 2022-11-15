using Saratyc._2._Negocio.BL;
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
    public partial class AuxiliaresRecomendados : Form
    {
        public AuxiliaresRecomendados(int idPaciente, int idTurno, string institucion, string tipoTurno)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textPaciente.Text = idPaciente.ToString();
            textTurno.Text = idTurno.ToString();
            textInst.Text = institucion.ToString();
            textTipoTurno.Text = tipoTurno.ToString();
        }

        private void AsignarAuxiliar_Load(object sender, EventArgs e)
        {
            
            Utilidades utilidades = new Utilidades();
            List<string> lRecomendados = new List<string>();
            int idPacienteTrabajo = Int32.Parse(textPaciente.Text);


            string id = "";
            string idPaciente = "";
            string idAuxiliar1 = "";
            string idAuxiliar2 = "";
            string idAuxiliar3 = "";
            string idAuxiliar4 = ""; 
            string idAuxiliar5 = "";
            string idAuxiliar6 = "";
            string idAuxiliar7 = "";
            string idAuxiliar8 = "";
            string idAuxiliar9 = "";
            string idAuxiliar10 = "";

            string ranking1 = "";
            string ranking2 = "";
            string ranking3 = "";
            string ranking4 = "";
            string ranking5 = "";
            string ranking6 = "";
            string ranking7 = "";
            string ranking8 = "";
            string ranking9 = "";
            string ranking10 = "";

            DataGridViewRow row = new DataGridViewRow();
            DataGridViewRow row2 = new DataGridViewRow();
            DataGridViewRow row3 = new DataGridViewRow();
            DataGridViewRow row4 = new DataGridViewRow();
            DataGridViewRow row5 = new DataGridViewRow();
            DataGridViewRow row6 = new DataGridViewRow();
            DataGridViewRow row7 = new DataGridViewRow();
            DataGridViewRow row8 = new DataGridViewRow();
            DataGridViewRow row9 = new DataGridViewRow();
            DataGridViewRow row10 = new DataGridViewRow();

            var recomendaciones = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Turnos.csv");
            //var recomendaciones = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Turnos2.csv");

            var rankings = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Rankings.csv");
            foreach (var ranking in rankings)
            {
                var columns = ranking.Split(';').Where(c => c.Trim() != string.Empty).ToList();
                ranking1 = columns[0].ToString();
                ranking2 = columns[1].ToString();
                ranking3 = columns[2].ToString();
                ranking4 = columns[3].ToString();
                ranking5 = columns[4].ToString();
                ranking6 = columns[5].ToString();
                ranking7 = columns[6].ToString();
                ranking8 = columns[7].ToString();
                ranking9 = columns[8].ToString();
                ranking10 = columns[9].ToString();
            }


            foreach (var recomendacion in recomendaciones)
            {
                var columns = recomendacion.Split(';').Where(c => c.Trim() != string.Empty).ToList();
                id = columns[0].ToString();
                idPaciente = columns[1].ToString();
                idAuxiliar1 = columns[2].ToString();
                idAuxiliar2 = columns[3].ToString();
                idAuxiliar3 = columns[5].ToString();
                idAuxiliar4 = columns[6].ToString();
                idAuxiliar5 = columns[7].ToString();
                idAuxiliar6 = columns[8].ToString();
                idAuxiliar7 = columns[9].ToString();
                idAuxiliar8 = columns[10].ToString();
                idAuxiliar9 = columns[11].ToString();
                idAuxiliar10 = columns[12].ToString();

                string nombreGenerico = "Nombre";
                string apellidoGenerico = "Apellido";

                if (idPaciente.Equals(idPacienteTrabajo.ToString()))
                {
                    row.CreateCells(dataGridView1);
                    row.Cells[0].Value = 1;
                    row.Cells[1].Value = idAuxiliar1;
                    //row.Cells[2].Value = obtenerNombreAuxiliar(idAuxiliar1);
                    //row.Cells[3].Value = obtenerApellidoAuxiliar(idAuxiliar1);
                    row.Cells[2].Value = nombreGenerico;
                    row.Cells[3].Value = apellidoGenerico;  
                    row.Cells[4].Value = ranking1;
                    //row.Cells[4].Value = obtenerPorcentajeCompatibilidad(1);
                    dataGridView1.Rows.Add(row);

                    row2.CreateCells(dataGridView1);
                    row2.Cells[0].Value = 2;
                    row2.Cells[1].Value = idAuxiliar2;
                    //row2.Cells[2].Value = obtenerNombreAuxiliar(idAuxiliar2);
                    //row2.Cells[3].Value = obtenerApellidoAuxiliar(idAuxiliar2);
                    row2.Cells[2].Value = nombreGenerico;
                    row2.Cells[3].Value = apellidoGenerico;
                    row2.Cells[4].Value = ranking2;
                    //row2.Cells[4].Value = obtenerPorcentajeCompatibilidad(2);
                    dataGridView1.Rows.Add(row2);

                    row3.CreateCells(dataGridView1);
                    row3.Cells[0].Value = 3;
                    row3.Cells[1].Value = idAuxiliar3;
                    //row3.Cells[2].Value = obtenerNombreAuxiliar(idAuxiliar3);
                    //row3.Cells[3].Value = obtenerApellidoAuxiliar(idAuxiliar3);
                    row3.Cells[2].Value = nombreGenerico;
                    row3.Cells[3].Value = apellidoGenerico;
                    row3.Cells[4].Value = ranking3;
                    //row3.Cells[4].Value = obtenerPorcentajeCompatibilidad(3);
                    dataGridView1.Rows.Add(row3);

                    row4.CreateCells(dataGridView1);
                    row4.Cells[0].Value = 4;
                    row4.Cells[1].Value = idAuxiliar4;
                    //row4.Cells[2].Value = obtenerNombreAuxiliar(idAuxiliar4);
                    //row4.Cells[3].Value = obtenerApellidoAuxiliar(idAuxiliar4);
                    row4.Cells[2].Value = nombreGenerico;
                    row4.Cells[3].Value = apellidoGenerico;
                    row4.Cells[4].Value = ranking4;
                    //row4.Cells[4].Value = obtenerPorcentajeCompatibilidad(4);
                    dataGridView1.Rows.Add(row4);

                    row5.CreateCells(dataGridView1);
                    row5.Cells[0].Value = 5;
                    row5.Cells[1].Value = idAuxiliar5;
                    //row5.Cells[2].Value = obtenerNombreAuxiliar(idAuxiliar5);
                    //row5.Cells[3].Value = obtenerApellidoAuxiliar(idAuxiliar5);
                    row5.Cells[2].Value = nombreGenerico;
                    row5.Cells[3].Value = apellidoGenerico;
                    row5.Cells[4].Value = ranking5;
                    //row5.Cells[4].Value = obtenerPorcentajeCompatibilidad(5);
                    dataGridView1.Rows.Add(row5);

                    row6.CreateCells(dataGridView1);
                    row6.Cells[0].Value = 6;
                    row6.Cells[1].Value = idAuxiliar6;
                    //row6.Cells[2].Value = obtenerNombreAuxiliar(idAuxiliar6);
                    //row6.Cells[3].Value = obtenerApellidoAuxiliar(idAuxiliar6);
                    row6.Cells[2].Value = nombreGenerico;
                    row6.Cells[3].Value = apellidoGenerico;
                    row6.Cells[4].Value = ranking6;
                    //row6.Cells[4].Value = obtenerPorcentajeCompatibilidad(6);
                    dataGridView1.Rows.Add(row6);

                    row7.CreateCells(dataGridView1);
                    row7.Cells[0].Value = 7;
                    row7.Cells[1].Value = idAuxiliar7;
                    //row7.Cells[2].Value = obtenerNombreAuxiliar(idAuxiliar7);
                    //row7.Cells[3].Value = obtenerApellidoAuxiliar(idAuxiliar7);
                    row7.Cells[2].Value = nombreGenerico;
                    row7.Cells[3].Value = apellidoGenerico;
                    row7.Cells[4].Value = ranking7;
                    //row7.Cells[4].Value = obtenerPorcentajeCompatibilidad(7);
                    dataGridView1.Rows.Add(row7);

                    row8.CreateCells(dataGridView1);
                    row8.Cells[0].Value = 8;
                    row8.Cells[1].Value = idAuxiliar8;
                    //row8.Cells[2].Value = obtenerNombreAuxiliar(idAuxiliar8);
                    //row8.Cells[3].Value = obtenerApellidoAuxiliar(idAuxiliar8);
                    row8.Cells[2].Value = nombreGenerico;
                    row8.Cells[3].Value = apellidoGenerico;
                    row8.Cells[4].Value = ranking8;
                    //row8.Cells[4].Value = obtenerPorcentajeCompatibilidad(8);
                    dataGridView1.Rows.Add(row8);

                    row9.CreateCells(dataGridView1);
                    row9.Cells[0].Value = 9;
                    row9.Cells[1].Value = idAuxiliar9;
                    //row9.Cells[2].Value = obtenerNombreAuxiliar(idAuxiliar9);
                    //row9.Cells[3].Value = obtenerApellidoAuxiliar(idAuxiliar9);
                    row9.Cells[2].Value = nombreGenerico;
                    row9.Cells[3].Value = apellidoGenerico;
                    row9.Cells[4].Value = ranking9;
                    //row9.Cells[4].Value = obtenerPorcentajeCompatibilidad(9);
                    dataGridView1.Rows.Add(row9);

                    row10.CreateCells(dataGridView1);
                    row10.Cells[0].Value = 10;
                    row10.Cells[1].Value = idAuxiliar10;
                    //row10.Cells[2].Value = obtenerNombreAuxiliar(idAuxiliar10);
                    //row10.Cells[3].Value = obtenerApellidoAuxiliar(idAuxiliar10);
                    row10.Cells[2].Value = nombreGenerico;
                    row10.Cells[3].Value = apellidoGenerico;
                    row10.Cells[4].Value = ranking10;
                    //row10.Cells[4].Value = obtenerPorcentajeCompatibilidad(10);
                    dataGridView1.Rows.Add(row10);
                }
                


                
            }


        }



        private int obtenerPorcentajeCompatibilidad(int id)
        {
            Random rd = new Random();
            int porcentaje=0;

            if (id.Equals(1))
            {
                porcentaje = rd.Next(50, 60);
            }
            else if (id.Equals(2))
            {
                porcentaje = rd.Next(40, 50);
            }
            else if (id.Equals(3))
            {
                porcentaje = rd.Next(35, 40);
            }
            else if (id.Equals(4))
            {
                porcentaje = rd.Next(30, 35);
            }
            else if (id.Equals(5))
            {
                porcentaje = rd.Next(25, 30);
            }
            else if (id.Equals(6))
            {
                porcentaje = rd.Next(20, 25);
            }
            else if (id.Equals(7))
            {
                porcentaje = rd.Next(15, 20);
            }
            else if (id.Equals(8))
            {
                porcentaje = rd.Next(10, 15);
            }
            else if (id.Equals(9))
            {
                porcentaje = rd.Next(5, 10);
            }
            else if (id.Equals(10))
            {
                porcentaje = rd.Next(0, 5);
            }

            return porcentaje;


        }

        private string obtenerNombreAuxiliar(string idAuxiliar)
        {
            var Auxiliares = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Auxiliares.csv");

            string nombre="";

            foreach (var auxiliar in Auxiliares)
            {
                var columns = auxiliar.Split(';').Where(c => c.Trim() != string.Empty).ToList();
                string id = columns[0].ToString();

                if(id.Equals(idAuxiliar))
                {
                    nombre = columns[1].ToString();
                }
            }
            return nombre;
        }

        private string obtenerApellidoAuxiliar(string idAuxiliar)
        {
            var Auxiliares = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Auxiliares.csv");

            string apellido = "";

            foreach (var auxiliar in Auxiliares)
            {
                var columns = auxiliar.Split(';').Where(c => c.Trim() != string.Empty).ToList();
                string id = columns[0].ToString();

                if (id.Equals(idAuxiliar))
                {
                    apellido = columns[2].ToString();
                }
            }
            return apellido;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {

            string idpaciente = textPaciente.Text;
            string idAuxiliar = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string idTurno = textTurno.Text;
            string nombres = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string apellidos = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //string nombres = "Nombres";
            //string apellidos = "Apellidos";
            string porcentaje = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string tipoTurno = textTipoTurno.Text;

            //this.Hide();
            AuxiliarRecomendado ar = new AuxiliarRecomendado(idpaciente, idAuxiliar, nombres, apellidos, porcentaje, idTurno, tipoTurno);
            ar.Activate();
            ar.Show();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //AsignarAuxiliar aa = new AsignarAuxiliar();
            //aa.Activate();
            //aa.Show();
        }
    }
}
