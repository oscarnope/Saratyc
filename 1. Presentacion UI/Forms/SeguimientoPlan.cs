using MySqlX.XDevAPI.Relational;
using Saratyc._2._Negocio.BL;
using Saratyc._4._Datos.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saratyc._1._Presentacion_UI.Forms
{
    public partial class SeguimientoPlan : Form
    {
        string idEnferdata;
        string nombre;
        string apellido;
        string identificacion;
        string fechaNacimiento;
        string genero;
        string ciudad;
        string localidad;
        string barrio;
        string nacionalidad;
        string disponibilidad;
        string personalidad;
        string contextura;
        string desplazamiento;
        string levantarObjetos;

        string idAuxiliar;
        string ccAuxiliar;
        string tema;
        string nivel;
        string publicada;
        string fechaPublicacion;
        string fechaEvaluacion;
        string fechaPresentacion;
        string fechaExpiracion;
        string resultado;



        BAuxiliar bAuxiliar = new BAuxiliar();
        List<string> lAuxiliar = new List<string>();

        BSeguimientoPlan bSeguimientoPlan = new BSeguimientoPlan();

        public SeguimientoPlan()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SeguimientoPlan_Load(object sender, EventArgs e)
        {
            //textIdentificacion.Text = "1015396096";
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            Hide();
            MenuCapacitacion mc = new MenuCapacitacion();
            mc.Activate();
            mc.Show();
        }

        private void Disenar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string identificacionAuxiliar = textIdentificacion.Text;

            if (string.IsNullOrEmpty(identificacionAuxiliar))
            {
                indicador.ForeColor = Color.Red;
                indicador.Text = "No se diligencio la identificación del auxiliar";
            }

            else
            {            
                lAuxiliar = bAuxiliar.buscarAuxiliarEnferdata(identificacionAuxiliar);

                foreach (string auxiliar in lAuxiliar)
                {
                    var columns = auxiliar.Split(',').ToList();
                    idEnferdata = columns[0].ToString();
                    nombre = columns[1].ToString();
                    apellido = columns[2].ToString();
                    identificacion = columns[3].ToString();
                    fechaNacimiento = columns[4].ToString();
                    genero = columns[5].ToString();
                    ciudad = columns[6].ToString();
                    localidad = columns[7].ToString();
                    barrio = columns[8].ToString();
                    contextura = columns[9].ToString();
                    nacionalidad = columns[10].ToString();
                    disponibilidad = columns[11].ToString();
                    personalidad = columns[12].ToString();
                    desplazamiento = columns[13].ToString();
                    //levantarObjetos = columns[14].ToString();

                    textNombre.Text = nombre;
                    textApellido.Text = apellido;

                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();

                    dataGridView2.Rows.Clear();
                    dataGridView2.Refresh();

                    dataGridView3.Rows.Clear();
                    dataGridView3.Refresh();

                    poblarCapacitaciones(identificacion);
                    poblarEvaluaciones(identificacion);
                    poblarCursosObligatorios(identificacion);
                    //poblarPreferencias(listaValoresPref);

                    indicador.ForeColor = Color.Black;
                    indicador.Text = "Se encontró la información del auxiliar";
                }
            }
        }

        private void poblarCapacitaciones(string identificacion)
        {
            //bSeguimientoPlan.poblarConocimiento(identificacion);

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
            DataGridViewRow row11 = new DataGridViewRow();
            DataGridViewRow row12 = new DataGridViewRow();
            DataGridViewRow row13 = new DataGridViewRow();
            DataGridViewRow row14 = new DataGridViewRow();
            DataGridViewRow row15 = new DataGridViewRow();
            DataGridViewRow row16 = new DataGridViewRow();
            DataGridViewRow row17 = new DataGridViewRow();
            DataGridViewRow row18 = new DataGridViewRow();
            DataGridViewRow row19 = new DataGridViewRow();
            DataGridViewRow row20 = new DataGridViewRow();

            int numFila = 0;
            
            var capacitaciones = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Capacitaciones.csv");

            foreach (var capacitacion in capacitaciones)
            {
                var columns = capacitacion.Split(';').Where(c => c.Trim() != string.Empty).ToList();
                idAuxiliar = columns[0].ToString();
                ccAuxiliar = columns[1].ToString();
                tema = columns[2].ToString();
                publicada = columns[3].ToString();
                if (publicada.Equals("SI"))
                {
                    fechaPublicacion = columns[4].ToString();
                }
                else
                {
                    fechaPublicacion = "";
                }

                //Añade la fila si encuentra al auxiliar buscado    
                if (identificacion.Equals(ccAuxiliar.ToString()))
                {
                    
                    //Pregunta por el numero de la fila
                    if (numFila.Equals(0))
                    {
                        row.CreateCells(dataGridView1);
                        row.Cells[0].Value = tema;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
                            chk.Value = true;
                            dataGridView1.EndEdit();
                        }
                        row.Cells[2].Value = fechaPublicacion;
                        dataGridView1.Rows.Add(row);
                        numFila++;
                    }  
                    
                    else if (numFila.Equals(1))
                        {
                        row2.CreateCells(dataGridView1);
                        row2.Cells[0].Value = tema;
                            if (publicada.Equals("SI"))
                            {
                            DataGridViewCheckBoxCell chk2 = (DataGridViewCheckBoxCell)row2.Cells[1];
                            chk2.Value =true;
                            dataGridView1.EndEdit();
                            }
                        row2.Cells[2].Value = fechaPublicacion;
                        dataGridView1.Rows.Add(row2);
                        numFila++;
                        }

                    else if (numFila.Equals(2))
                    {
                        row3.CreateCells(dataGridView1);
                        row3.Cells[0].Value = tema;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chk3 = (DataGridViewCheckBoxCell)row3.Cells[1];
                            chk3.Value = true;
                            dataGridView1.EndEdit();
                        }
                        row3.Cells[2].Value = fechaPublicacion;
                        dataGridView1.Rows.Add(row3);
                        numFila++;
                    }

                    else if (numFila.Equals(3))
                    {
                        row4.CreateCells(dataGridView1);
                        row4.Cells[0].Value = tema;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chk4 = (DataGridViewCheckBoxCell)row4.Cells[1];
                            chk4.Value = true;
                            dataGridView1.EndEdit();
                        }
                        row4.Cells[2].Value = fechaPublicacion;
                        dataGridView1.Rows.Add(row4);
                        numFila++;
                    }

                    else if (numFila.Equals(4))
                    {
                        row5.CreateCells(dataGridView1);
                        row5.Cells[0].Value = tema;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chk5 = (DataGridViewCheckBoxCell)row5.Cells[1];
                            chk5.Value = true;
                            dataGridView1.EndEdit();
                        }
                        row5.Cells[2].Value = fechaPublicacion;
                        dataGridView1.Rows.Add(row5);
                        numFila++;
                    }

                    else if (numFila.Equals(5))
                    {
                        row6.CreateCells(dataGridView1);
                        row6.Cells[0].Value = tema;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chk6 = (DataGridViewCheckBoxCell)row6.Cells[1];
                            chk6.Value = true;
                            dataGridView1.EndEdit();
                        }
                        row6.Cells[2].Value = fechaPublicacion;
                        dataGridView1.Rows.Add(row6);
                        numFila++;
                    }

                    else if (numFila.Equals(6))
                    {
                        row7.CreateCells(dataGridView1);
                        row7.Cells[0].Value = tema;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chk7 = (DataGridViewCheckBoxCell)row7.Cells[1];
                            chk7.Value = true;
                            dataGridView1.EndEdit();
                        }
                        row7.Cells[2].Value = fechaPublicacion;
                        dataGridView1.Rows.Add(row7);
                        numFila++;
                    }

                    else if (numFila.Equals(7))
                    {
                        row8.CreateCells(dataGridView1);
                        row8.Cells[0].Value = tema;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chk8 = (DataGridViewCheckBoxCell)row8.Cells[1];
                            chk8.Value = true;
                            dataGridView1.EndEdit();
                        }
                        row8.Cells[2].Value = fechaPublicacion;
                        dataGridView1.Rows.Add(row8);
                        numFila++;
                    }

                    else if (numFila.Equals(8))
                    {
                        row9.CreateCells(dataGridView1);
                        row9.Cells[0].Value = tema;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chk9 = (DataGridViewCheckBoxCell)row9.Cells[1];
                            chk9.Value = true;
                            dataGridView1.EndEdit();
                        }
                        row9.Cells[2].Value = fechaPublicacion;
                        dataGridView1.Rows.Add(row9);
                        numFila++;
                    }

                    else if (numFila.Equals(9))
                    {
                        row10.CreateCells(dataGridView1);
                        row10.Cells[0].Value = tema;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chk10 = (DataGridViewCheckBoxCell)row10.Cells[1];
                            chk10.Value = true;
                            dataGridView1.EndEdit();
                        }
                        row10.Cells[2].Value = fechaPublicacion;
                        dataGridView1.Rows.Add(row10);
                        numFila++;
                    }
                }




            }
        }

        private void poblarEvaluaciones(string identificacion)
        {
            //bSeguimientoPlan.poblarConocimiento(identificacion);

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
            DataGridViewRow row11 = new DataGridViewRow();
            DataGridViewRow row12 = new DataGridViewRow();
            DataGridViewRow row13 = new DataGridViewRow();
            DataGridViewRow row14 = new DataGridViewRow();
            DataGridViewRow row15 = new DataGridViewRow();
            DataGridViewRow row16 = new DataGridViewRow();
            DataGridViewRow row17 = new DataGridViewRow();
            DataGridViewRow row18 = new DataGridViewRow();
            DataGridViewRow row19 = new DataGridViewRow();
            DataGridViewRow row20 = new DataGridViewRow();

            int numFila = 0;

            var evaluaciones = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Evaluaciones.csv");

            foreach (var evaluacion in evaluaciones)
            {
                var columns = evaluacion.Split(';').ToList();
                idAuxiliar = columns[0].ToString();
                ccAuxiliar = columns[1].ToString();
                tema = columns[2].ToString();
                nivel = columns[3].ToString();
                publicada = columns[4].ToString();
                if (publicada.Equals("SI"))
                {
                    fechaPublicacion = columns[5].ToString();

                    /*if(!string.IsNullOrEmpty(columns[5].ToString()))
                    {
                        fechaPublicacion = columns[5].ToString();
                    }*/
                }
                else
                {
                    fechaPublicacion = "";
                }

                fechaPresentacion = columns[6].ToString();
                fechaEvaluacion = columns[7].ToString();

                if (!string.IsNullOrEmpty(fechaEvaluacion))
                {
                    resultado = columns[8];
                }
                else
                {
                    resultado = "";
                }



                //Añade la fila si encuentra al auxiliar buscado    
                if (identificacion.Equals(ccAuxiliar.ToString()))
                {

                    //Pregunta por el numero de la fila
                    if (numFila.Equals(0))
                    {
                        row.CreateCells(dataGridView2);
                        row.Cells[0].Value = tema;
                        row.Cells[1].Value = nivel;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chkev1 = (DataGridViewCheckBoxCell)row.Cells[2];
                            chkev1.Value = true;
                            dataGridView2.EndEdit();
                        }
                        row.Cells[3].Value = fechaPublicacion;
                        row.Cells[4].Value = fechaPresentacion;
                        row.Cells[5].Value = fechaEvaluacion;
                        row.Cells[6].Value = resultado;

                        dataGridView2.Rows.Add(row);
                        numFila++;
                    }

                    else if (numFila.Equals(1))
                    {
                        row2.CreateCells(dataGridView2);
                        row2.Cells[0].Value = tema;
                        row2.Cells[1].Value = nivel;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chkev2 = (DataGridViewCheckBoxCell)row2.Cells[2];
                            chkev2.Value = true;
                            dataGridView2.EndEdit();
                        }
                        row2.Cells[3].Value = fechaPublicacion;
                        row2.Cells[4].Value = fechaPresentacion;
                        row2.Cells[5].Value = fechaEvaluacion;
                        row2.Cells[6].Value = resultado;

                        dataGridView2.Rows.Add(row2);
                        numFila++;
                    }

                    else if (numFila.Equals(2))
                    {
                        row3.CreateCells(dataGridView2);
                        row3.Cells[0].Value = tema;
                        row3.Cells[1].Value = nivel;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chkev3 = (DataGridViewCheckBoxCell)row3.Cells[2];
                            chkev3.Value = true;
                            dataGridView2.EndEdit();
                        }
                        row3.Cells[3].Value = fechaPublicacion;
                        row3.Cells[4].Value = fechaPresentacion;
                        row3.Cells[5].Value = fechaEvaluacion;
                        row3.Cells[6].Value = resultado;

                        dataGridView2.Rows.Add(row3);
                        numFila++;
                    }

                    else if (numFila.Equals(3))
                    {
                        row4.CreateCells(dataGridView2);
                        row4.Cells[0].Value = tema;
                        row4.Cells[1].Value = nivel;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chkev4 = (DataGridViewCheckBoxCell)row4.Cells[2];
                            chkev4.Value = true;
                            dataGridView2.EndEdit();
                        }
                        row4.Cells[3].Value = fechaPublicacion;
                        row4.Cells[4].Value = fechaPresentacion;
                        row4.Cells[5].Value = fechaEvaluacion;
                        row4.Cells[6].Value = resultado;

                        dataGridView2.Rows.Add(row4);
                        numFila++;
                    }

                    else if (numFila.Equals(4))
                    {
                        row5.CreateCells(dataGridView2);
                        row5.Cells[0].Value = tema;
                        row5.Cells[1].Value = nivel;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chkev5 = (DataGridViewCheckBoxCell)row5.Cells[2];
                            chkev5.Value = true;
                            dataGridView2.EndEdit();
                        }
                        row5.Cells[3].Value = fechaPublicacion;
                        row5.Cells[4].Value = fechaPresentacion;
                        row5.Cells[5].Value = fechaEvaluacion;
                        row5.Cells[6].Value = resultado;

                        dataGridView2.Rows.Add(row5);
                        numFila++;
                    }

                    else if (numFila.Equals(5))
                    {
                        row6.CreateCells(dataGridView2);
                        row6.Cells[0].Value = tema;
                        row6.Cells[1].Value = nivel;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chkev6 = (DataGridViewCheckBoxCell)row6.Cells[2];
                            chkev6.Value = true;
                            dataGridView2.EndEdit();
                        }
                        row6.Cells[3].Value = fechaPublicacion;
                        row6.Cells[4].Value = fechaPresentacion;
                        row6.Cells[5].Value = fechaEvaluacion;
                        row6.Cells[6].Value = resultado;

                        dataGridView2.Rows.Add(row6);
                        numFila++;
                    }

                    else if (numFila.Equals(6))
                    {
                        row7.CreateCells(dataGridView2);
                        row7.Cells[0].Value = tema;
                        row7.Cells[1].Value = nivel;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chkev7 = (DataGridViewCheckBoxCell)row7.Cells[2];
                            chkev7.Value = true;
                            dataGridView2.EndEdit();
                        }
                        row7.Cells[3].Value = fechaPublicacion;
                        row7.Cells[4].Value = fechaPresentacion;
                        row7.Cells[5].Value = fechaEvaluacion;
                        row7.Cells[6].Value = resultado;

                        dataGridView2.Rows.Add(row7);
                        numFila++;
                    }

                    else if (numFila.Equals(7))
                    {
                        row8.CreateCells(dataGridView2);
                        row8.Cells[0].Value = tema;
                        row8.Cells[1].Value = nivel;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chkev8 = (DataGridViewCheckBoxCell)row8.Cells[2];
                            chkev8.Value = true;
                            dataGridView2.EndEdit();
                        }
                        row8.Cells[3].Value = fechaPublicacion;
                        row8.Cells[4].Value = fechaPresentacion;
                        row8.Cells[5].Value = fechaEvaluacion;
                        row8.Cells[6].Value = resultado;

                        dataGridView2.Rows.Add(row8);
                        numFila++;
                    }

                    else if (numFila.Equals(8))
                    {
                        row9.CreateCells(dataGridView2);
                        row9.Cells[0].Value = tema;
                        row9.Cells[1].Value = nivel;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chkev9 = (DataGridViewCheckBoxCell)row9.Cells[2];
                            chkev9.Value = true;
                            dataGridView2.EndEdit();
                        }
                        row9.Cells[3].Value = fechaPublicacion;
                        row9.Cells[4].Value = fechaPresentacion;
                        row9.Cells[5].Value = fechaEvaluacion;
                        row9.Cells[6].Value = resultado;

                        dataGridView2.Rows.Add(row9);
                        numFila++;
                    }

                    else if (numFila.Equals(9))
                    {
                        row10.CreateCells(dataGridView2);
                        row10.Cells[0].Value = tema;
                        row10.Cells[1].Value = nivel;
                        if (publicada.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chkev10 = (DataGridViewCheckBoxCell)row10.Cells[2];
                            chkev10.Value = true;
                            dataGridView2.EndEdit();
                        }
                        row10.Cells[3].Value = fechaPublicacion;
                        row10.Cells[4].Value = fechaPresentacion;
                        row10.Cells[5].Value = fechaEvaluacion;
                        row10.Cells[6].Value = resultado;

                        dataGridView2.Rows.Add(row10);
                        numFila++;
                    }



                }
            }




            
        }

        private void poblarCursosObligatorios(string identificacion)
        {
            //bSeguimientoPlan.poblarConocimiento(identificacion);

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
            DataGridViewRow row11 = new DataGridViewRow();
            DataGridViewRow row12 = new DataGridViewRow();
            DataGridViewRow row13 = new DataGridViewRow();
            DataGridViewRow row14 = new DataGridViewRow();
            DataGridViewRow row15 = new DataGridViewRow();
            DataGridViewRow row16 = new DataGridViewRow();
            DataGridViewRow row17 = new DataGridViewRow();
            DataGridViewRow row18 = new DataGridViewRow();
            DataGridViewRow row19 = new DataGridViewRow();
            DataGridViewRow row20 = new DataGridViewRow();

            int numFila = 0;

            var cursosObligatorios = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\CursosObligatorios.csv");

            string fechaExpiracion;

            foreach (var cursoObligatorio in cursosObligatorios)
            {
                var columns = cursoObligatorio.Split(';').ToList();
                idAuxiliar = columns[0].ToString();
                ccAuxiliar = columns[1].ToString();
                tema = columns[2].ToString();
                nivel = columns[3].ToString();
                fechaExpiracion = columns[4].ToString();
                fechaPresentacion = columns[5].ToString();


                //Añade la fila si encuentra al auxiliar buscado    
                if (identificacion.Equals(ccAuxiliar.ToString()))
                {

                    //Pregunta por el numero de la fila
                    if (numFila.Equals(0))
                    {
                        row.CreateCells(dataGridView3);
                        row.Cells[0].Value = tema;
                        row.Cells[1].Value = nivel;
                        if (!fechaPresentacion.Equals(""))
                        {
                            DataGridViewCheckBoxCell chkcur1 = (DataGridViewCheckBoxCell)row.Cells[2];
                            chkcur1.Value = true;
                            dataGridView3.EndEdit();
                        }
                        row.Cells[3].Value = fechaPresentacion;
                        row.Cells[4].Value = fechaExpiracion;

                        dataGridView3.Rows.Add(row);
                        numFila++;
                    }

                    else if (numFila.Equals(1))
                    {
                        row2.CreateCells(dataGridView3);
                        row2.Cells[0].Value = tema;
                        row2.Cells[1].Value = nivel;
                        if (!fechaPresentacion.Equals(""))
                        {
                            DataGridViewCheckBoxCell chkcur2 = (DataGridViewCheckBoxCell)row2.Cells[2];
                            chkcur2.Value = true;
                            dataGridView3.EndEdit();
                        }
                        row2.Cells[3].Value = fechaPresentacion;
                        row2.Cells[4].Value = fechaExpiracion;

                        dataGridView3.Rows.Add(row2);
                        numFila++;
                    }

                    else if (numFila.Equals(2))
                    {
                        row3.CreateCells(dataGridView3);
                        row3.Cells[0].Value = tema;
                        row3.Cells[1].Value = nivel;
                        if (!fechaPresentacion.Equals(""))
                        {
                            DataGridViewCheckBoxCell chkcur3 = (DataGridViewCheckBoxCell)row3.Cells[2];
                            chkcur3.Value = true;
                            dataGridView3.EndEdit();
                        }
                        row3.Cells[3].Value = fechaPresentacion;
                        row3.Cells[4].Value = fechaExpiracion;

                        dataGridView3.Rows.Add(row3);
                        numFila++;
                    }




                }
            }





        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
