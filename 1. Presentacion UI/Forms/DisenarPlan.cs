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

    public partial class DisenarPlan : Form
    {
        string idEnferdata;
        string nombre;
        string apellido;
        string idAuxiliar;
        string ccAuxiliar;
        string tema;
        string conocimientoTema;
        string experienciaTema;
        string interesTema;
        string nivel;
        string publicada;
        string fechaPublicacion;
        string fechaPresentacion;
        string fechaEvaluacion;
        string resultado;
        string idTema;
        string porcentajeDemanda;


        BAuxiliar bAuxiliar = new BAuxiliar();
        List<string> lAuxiliar = new List<string>();

        public DisenarPlan()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void DisenarPlan_Load(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            Hide();
            MenuCapacitacion mc = new MenuCapacitacion();
            mc.Show();
            mc.Activate();
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
                lAuxiliar = bAuxiliar.buscarAuxiliar(identificacionAuxiliar);

                foreach (string auxiliar in lAuxiliar)
                {
                    var columns = auxiliar.Split(',').ToList();
                    idEnferdata = columns[0].ToString();
                    nombre = columns[1].ToString();
                    apellido = columns[2].ToString();

                    textNombre.Text = nombre;
                    textApellido.Text = apellido;

                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();

                    dataGridView2.Rows.Clear();
                    dataGridView2.Refresh();

                    dataGridView3.Rows.Clear();
                    dataGridView3.Refresh();

                    dataGridView4.Rows.Clear();
                    dataGridView4.Refresh();

                    dataGridView5.Rows.Clear();
                    dataGridView5.Refresh();

                    dataGridView6.Rows.Clear();
                    dataGridView6.Refresh();

                    poblarConocimientos(identificacionAuxiliar);
                    poblarExperiencias(identificacionAuxiliar);
                    poblarIntereses(identificacionAuxiliar);
                    poblarEvaluaciones(identificacionAuxiliar);
                    poblarDemanda();

                    indicador.ForeColor = Color.Black;
                    indicador.Text = "Se encontró la información del auxiliar";
                }
            }
        }


        private void poblarConocimientos(string identificacion)
        {
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

            var conocimientos = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Conocimientos.csv");

            foreach (var conocimiento in conocimientos)
            {
                var columns = conocimiento.Split(';').Where(c => c.Trim() != string.Empty).ToList();
                idAuxiliar = columns[0].ToString();
                ccAuxiliar = columns[1].ToString();
                tema = columns[2].ToString();
                conocimientoTema = columns[3].ToString();

                //Añade la fila si encuentra al auxiliar buscado    
                if (identificacion.Equals(ccAuxiliar.ToString()))
                {

                    //Pregunta por el numero de la fila
                    if (numFila.Equals(0))
                    {
                        row.CreateCells(dataGridView1);
                        row.Cells[0].Value = tema;
                        row.Cells[1].Value = conocimientoTema;
                        if (conocimientoTema.Equals("NO"))
                        {
                            DataGridViewCheckBoxCell chkcon1 = (DataGridViewCheckBoxCell)row.Cells[2];
                            chkcon1.Value = true;
                            dataGridView1.EndEdit();
                        }
                        dataGridView1.Rows.Add(row);
                        numFila++;
                    }

                    else if (numFila.Equals(1))
                    {
                        row2.CreateCells(dataGridView1);
                        row2.Cells[0].Value = tema;
                        row2.Cells[1].Value = conocimientoTema;
                        if (conocimientoTema.Equals("NO"))
                        {
                            DataGridViewCheckBoxCell chkcon2 = (DataGridViewCheckBoxCell)row2.Cells[2];
                            chkcon2.Value = true;
                            dataGridView1.EndEdit();
                        }
                        dataGridView1.Rows.Add(row2);
                        numFila++;
                    }

                    else if (numFila.Equals(2))
                    {
                        row3.CreateCells(dataGridView1);
                        row3.Cells[0].Value = tema;
                        row3.Cells[1].Value = conocimientoTema;
                        if (conocimientoTema.Equals("NO"))
                        {
                            DataGridViewCheckBoxCell chkcon3 = (DataGridViewCheckBoxCell)row3.Cells[2];
                            chkcon3.Value = true;
                            dataGridView1.EndEdit();
                        }
                        dataGridView1.Rows.Add(row3);
                        numFila++;
                    }

                }
            }
        }

        private void poblarExperiencias(string identificacion)
        {
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

            var experiencias = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Experiencias.csv");

            foreach (var experiencia in experiencias)
            {
                var columns = experiencia.Split(';').Where(c => c.Trim() != string.Empty).ToList();
                idAuxiliar = columns[0].ToString();
                ccAuxiliar = columns[1].ToString();
                tema = columns[2].ToString();
                experienciaTema = columns[3].ToString();

                //Añade la fila si encuentra al auxiliar buscado    
                if (identificacion.Equals(ccAuxiliar.ToString()))
                {

                    //Pregunta por el numero de la fila
                    if (numFila.Equals(0))
                    {
                        row.CreateCells(dataGridView1);
                        row.Cells[0].Value = tema;
                        row.Cells[1].Value = experienciaTema;
                        if (experienciaTema.Equals("NO"))
                        {
                            DataGridViewCheckBoxCell chkexp1 = (DataGridViewCheckBoxCell)row.Cells[2];
                            chkexp1.Value = true;
                            dataGridView2.EndEdit();
                        }
                        dataGridView2.Rows.Add(row);
                        numFila++;
                    }

                    else if (numFila.Equals(1))
                    {
                        row2.CreateCells(dataGridView1);
                        row2.Cells[0].Value = tema;
                        row2.Cells[1].Value = experienciaTema;
                        if (experienciaTema.Equals("NO"))
                        {
                            DataGridViewCheckBoxCell chkexp2 = (DataGridViewCheckBoxCell)row.Cells[2];
                            chkexp2.Value = true;
                            dataGridView2.EndEdit();
                        }
                        dataGridView2.Rows.Add(row2);
                        numFila++;
                    }

                    else if (numFila.Equals(2))
                    {
                        row3.CreateCells(dataGridView1);
                        row3.Cells[0].Value = tema;
                        row3.Cells[1].Value = experienciaTema;
                        if (experienciaTema.Equals("NO"))
                        {
                            DataGridViewCheckBoxCell chkexp3 = (DataGridViewCheckBoxCell)row.Cells[2];
                            chkexp3.Value = true;
                            dataGridView2.EndEdit();
                        }
                        dataGridView2.Rows.Add(row3);
                        numFila++;
                    }

                }
            }
        }

        private void poblarIntereses(string identificacion)
        {
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

            var intereses = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Intereses.csv");

            foreach (var interes in intereses)
            {
                var columns = interes.Split(';').Where(c => c.Trim() != string.Empty).ToList();
                idAuxiliar = columns[0].ToString();
                ccAuxiliar = columns[1].ToString();
                tema = columns[2].ToString();
                interesTema = columns[3].ToString();

                //Añade la fila si encuentra al auxiliar buscado    
                if (identificacion.Equals(ccAuxiliar.ToString()))
                {

                    //Pregunta por el numero de la fila
                    if (numFila.Equals(0))
                    {
                        row.CreateCells(dataGridView1);
                        row.Cells[0].Value = tema;
                        row.Cells[1].Value = interesTema;
                        if (interesTema.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chkint1 = (DataGridViewCheckBoxCell)row.Cells[2];
                            chkint1.Value = true;
                            dataGridView3.EndEdit();
                        }
                        dataGridView3.Rows.Add(row);
                        numFila++;
                    }

                    else if (numFila.Equals(1))
                    {
                        row2.CreateCells(dataGridView1);
                        row2.Cells[0].Value = tema;
                        row2.Cells[1].Value = interesTema;
                        if (interesTema.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chkint2 = (DataGridViewCheckBoxCell)row2.Cells[2];
                            chkint2.Value = true;
                            dataGridView3.EndEdit();
                        }
                        dataGridView3.Rows.Add(row2);
                        numFila++;
                    }

                    else if (numFila.Equals(2))
                    {
                        row3.CreateCells(dataGridView1);
                        row3.Cells[0].Value = tema;
                        row3.Cells[1].Value = interesTema;
                        if (interesTema.Equals("SI"))
                        {
                            DataGridViewCheckBoxCell chkint3 = (DataGridViewCheckBoxCell)row3.Cells[2];
                            chkint3.Value = true;
                            dataGridView3.EndEdit();
                        }
                        dataGridView3.Rows.Add(row3);
                        numFila++;
                    }

                }
            }
        }

        private void poblarEvaluaciones(string identificacion)
        {
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
                        row.CreateCells(dataGridView4);
                        row.Cells[0].Value = tema;
                        row.Cells[1].Value = nivel;
                        row.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev1 = (DataGridViewCheckBoxCell)row.Cells[3];
                            chkev1.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row);
                        numFila++;
                    }

                    else if (numFila.Equals(1))
                    {
                        row2.CreateCells(dataGridView4);
                        row2.Cells[0].Value = tema;
                        row2.Cells[1].Value = nivel;
                        row2.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev2 = (DataGridViewCheckBoxCell)row2.Cells[3];
                            chkev2.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row2);
                        numFila++;
                    }

                    else if (numFila.Equals(2))
                    {
                        row3.CreateCells(dataGridView4);
                        row3.Cells[0].Value = tema;
                        row3.Cells[1].Value = nivel;
                        row3.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev3 = (DataGridViewCheckBoxCell)row3.Cells[3];
                            chkev3.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row3);
                        numFila++;
                    }

                    else if (numFila.Equals(3))
                    {
                        row4.CreateCells(dataGridView4);
                        row4.Cells[0].Value = tema;
                        row4.Cells[1].Value = nivel;
                        row4.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev4 = (DataGridViewCheckBoxCell)row4.Cells[3];
                            chkev4.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row4);
                        numFila++;
                    }

                    else if (numFila.Equals(4))
                    {
                        row5.CreateCells(dataGridView4);
                        row5.Cells[0].Value = tema;
                        row5.Cells[1].Value = nivel;
                        row5.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev5 = (DataGridViewCheckBoxCell)row5.Cells[3];
                            chkev5.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row5);
                        numFila++;
                    }

                    else if (numFila.Equals(5))
                    {
                        row6.CreateCells(dataGridView4);
                        row6.Cells[0].Value = tema;
                        row6.Cells[1].Value = nivel;
                        row6.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev6 = (DataGridViewCheckBoxCell)row6.Cells[3];
                            chkev6.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row6);
                        numFila++;
                    }

                    else if (numFila.Equals(6))
                    {
                        row7.CreateCells(dataGridView4);
                        row7.Cells[0].Value = tema;
                        row7.Cells[1].Value = nivel;
                        row7.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev7 = (DataGridViewCheckBoxCell)row7.Cells[3];
                            chkev7.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row7);
                        numFila++;
                    }

                    else if (numFila.Equals(7))
                    {
                        row8.CreateCells(dataGridView4);
                        row8.Cells[0].Value = tema;
                        row8.Cells[1].Value = nivel;
                        row8.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev8 = (DataGridViewCheckBoxCell)row8.Cells[3];
                            chkev8.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row8);
                        numFila++;
                    }

                    else if (numFila.Equals(8))
                    {
                        row9.CreateCells(dataGridView4);
                        row9.Cells[0].Value = tema;
                        row9.Cells[1].Value = nivel;
                        row9.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev9 = (DataGridViewCheckBoxCell)row9.Cells[3];
                            chkev9.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row9);
                        numFila++;
                    }

                    else if (numFila.Equals(9))
                    {
                        row10.CreateCells(dataGridView4);
                        row10.Cells[0].Value = tema;
                        row10.Cells[1].Value = nivel;
                        row10.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev10 = (DataGridViewCheckBoxCell)row10.Cells[3];
                            chkev10.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row10);
                        numFila++;
                    }

                    else if (numFila.Equals(10))
                    {
                        row11.CreateCells(dataGridView4);
                        row11.Cells[0].Value = tema;
                        row11.Cells[1].Value = nivel;
                        row11.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev11 = (DataGridViewCheckBoxCell)row11.Cells[3];
                            chkev11.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row11);
                        numFila++;
                    }

                    else if (numFila.Equals(11))
                    {
                        row12.CreateCells(dataGridView4);
                        row12.Cells[0].Value = tema;
                        row12.Cells[1].Value = nivel;
                        row12.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev12 = (DataGridViewCheckBoxCell)row12.Cells[3];
                            chkev12.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row12);
                        numFila++;
                    }

                    else if (numFila.Equals(12))
                    {
                        row13.CreateCells(dataGridView4);
                        row13.Cells[0].Value = tema;
                        row13.Cells[1].Value = nivel;
                        row13.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev13 = (DataGridViewCheckBoxCell)row13.Cells[3];
                            chkev13.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row13);
                        numFila++;
                    }

                    else if (numFila.Equals(13))
                    {
                        row14.CreateCells(dataGridView4);
                        row14.Cells[0].Value = tema;
                        row14.Cells[1].Value = nivel;
                        row14.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev14 = (DataGridViewCheckBoxCell)row14.Cells[3];
                            chkev14.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row14);
                        numFila++;
                    }

                    else if (numFila.Equals(14))
                    {
                        row15.CreateCells(dataGridView4);
                        row15.Cells[0].Value = tema;
                        row15.Cells[1].Value = nivel;
                        row15.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev15 = (DataGridViewCheckBoxCell)row15.Cells[3];
                            chkev15.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row15);
                        numFila++;
                    }

                    else if (numFila.Equals(15))
                    {
                        row16.CreateCells(dataGridView4);
                        row16.Cells[0].Value = tema;
                        row16.Cells[1].Value = nivel;
                        row16.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev16 = (DataGridViewCheckBoxCell)row16.Cells[3];
                            chkev16.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row16);
                        numFila++;
                    }

                    else if (numFila.Equals(16))
                    {
                        row17.CreateCells(dataGridView4);
                        row17.Cells[0].Value = tema;
                        row17.Cells[1].Value = nivel;
                        row17.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev17 = (DataGridViewCheckBoxCell)row17.Cells[3];
                            chkev17.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row17);
                        numFila++;
                    }

                    else if (numFila.Equals(17))
                    {
                        row18.CreateCells(dataGridView4);
                        row18.Cells[0].Value = tema;
                        row18.Cells[1].Value = nivel;
                        row18.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev18 = (DataGridViewCheckBoxCell)row18.Cells[3];
                            chkev18.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row18);
                        numFila++;
                    }

                    else if (numFila.Equals(18))
                    {
                        row19.CreateCells(dataGridView4);
                        row19.Cells[0].Value = tema;
                        row19.Cells[1].Value = nivel;
                        row19.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev19 = (DataGridViewCheckBoxCell)row19.Cells[3];
                            chkev19.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row19);
                        numFila++;
                    }


                    else if (numFila.Equals(19))
                    {
                        row20.CreateCells(dataGridView4);
                        row20.Cells[0].Value = tema;
                        row20.Cells[1].Value = nivel;
                        row20.Cells[2].Value = resultado;
                        if (resultado.Equals("NO APROBADO"))
                        {
                            DataGridViewCheckBoxCell chkev20 = (DataGridViewCheckBoxCell)row20.Cells[3];
                            chkev20.Value = true;
                            dataGridView4.EndEdit();
                        }
                        dataGridView4.Rows.Add(row20);
                        numFila++;
                    }
                }

            }


        }

        private void poblarDemanda()
        {
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

            var demandas = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Demanda.csv");

            int intPorcentajeDemanda = 0;
            int totalPorcentajeDemanda = 0;

            foreach (var demanda in demandas)
            {
                var columns = demanda.Split(';').ToList();
                idTema = columns[0].ToString();
                tema = columns[1].ToString();
                porcentajeDemanda = columns[2].ToString();

                if (!porcentajeDemanda.Equals("PORCENTAJE DEMANDA"))
                {
                    intPorcentajeDemanda = Int32.Parse(porcentajeDemanda);
                    totalPorcentajeDemanda = totalPorcentajeDemanda + intPorcentajeDemanda;

                    //Pregunta por el numero de la fila
                    if (numFila.Equals(0))
                    {
                        row.CreateCells(dataGridView5);
                        row.Cells[0].Value = tema;
                        row.Cells[1].Value = porcentajeDemanda;
                        DataGridViewCheckBoxCell chdem1 = (DataGridViewCheckBoxCell)row.Cells[2];
                        chdem1.Value = true;
                        dataGridView5.EndEdit();
                        dataGridView5.Rows.Add(row);
                        numFila++;
                    }

                    else if (numFila.Equals(1))
                    {
                        row2.CreateCells(dataGridView5);
                        row2.Cells[0].Value = tema;
                        row2.Cells[1].Value = porcentajeDemanda;
                        DataGridViewCheckBoxCell chdem2 = (DataGridViewCheckBoxCell)row2.Cells[2];
                        chdem2.Value = true;
                        dataGridView5.EndEdit();
                        dataGridView5.Rows.Add(row2);
                        numFila++;
                    }

                    else if (numFila.Equals(2))
                    {
                        row3.CreateCells(dataGridView5);
                        row3.Cells[0].Value = tema;
                        row3.Cells[1].Value = porcentajeDemanda;
                        DataGridViewCheckBoxCell chdem3 = (DataGridViewCheckBoxCell)row3.Cells[2];
                        chdem3.Value = true;
                        dataGridView5.EndEdit();
                        dataGridView5.Rows.Add(row3);
                        numFila++;
                    }

                    else if (numFila.Equals(3))
                    {
                        row4.CreateCells(dataGridView5);
                        row4.Cells[0].Value = tema;
                        row4.Cells[1].Value = porcentajeDemanda;
                        DataGridViewCheckBoxCell chdem4 = (DataGridViewCheckBoxCell)row4.Cells[2];
                        chdem4.Value = true;
                        dataGridView5.EndEdit();
                        dataGridView5.Rows.Add(row4);
                        numFila++;
                    }

                    else if (numFila.Equals(4))
                    {
                        row5.CreateCells(dataGridView5);
                        row5.Cells[0].Value = tema;
                        row5.Cells[1].Value = porcentajeDemanda;
                        DataGridViewCheckBoxCell chdem5 = (DataGridViewCheckBoxCell)row5.Cells[2];
                        chdem5.Value = true;
                        dataGridView5.EndEdit();
                        dataGridView5.Rows.Add(row5);
                        numFila++;
                    }

                    else if (numFila.Equals(5))
                    {
                        row6.CreateCells(dataGridView5);
                        row6.Cells[0].Value = tema;
                        row6.Cells[1].Value = porcentajeDemanda;
                        dataGridView5.Rows.Add(row6);
                        numFila++;
                    }

                    else if (numFila.Equals(6))
                    {
                        row7.CreateCells(dataGridView5);
                        row7.Cells[0].Value = tema;
                        row7.Cells[1].Value = porcentajeDemanda;
                        dataGridView5.Rows.Add(row7);
                        numFila++;
                    }

                    else if (numFila.Equals(7))
                    {
                        row8.CreateCells(dataGridView5);
                        row8.Cells[0].Value = tema;
                        row8.Cells[1].Value = porcentajeDemanda;
                        dataGridView5.Rows.Add(row8);
                        numFila++;
                    }

                    else if (numFila.Equals(8))
                    {
                        row9.CreateCells(dataGridView5);
                        row9.Cells[0].Value = tema;
                        row9.Cells[1].Value = porcentajeDemanda;
                        dataGridView5.Rows.Add(row9);
                        numFila++;
                    }

                    else if (numFila.Equals(9))
                    {
                        row10.CreateCells(dataGridView5);
                        row10.Cells[0].Value = tema;
                        row10.Cells[1].Value = porcentajeDemanda;
                        dataGridView5.Rows.Add(row10);
                        numFila++;
                    }

                    else if (numFila.Equals(10))
                    {
                        row11.CreateCells(dataGridView5);
                        row11.Cells[0].Value = tema;
                        row11.Cells[1].Value = porcentajeDemanda;
                        dataGridView5.Rows.Add(row11);
                        numFila++;
                    }

                    else if (numFila.Equals(11))
                    {
                        row12.CreateCells(dataGridView5);
                        row12.Cells[0].Value = tema;
                        row12.Cells[1].Value = porcentajeDemanda;
                        dataGridView5.Rows.Add(row12);
                        numFila++;
                    }

                    else if (numFila.Equals(12))
                    {
                        row13.CreateCells(dataGridView5);
                        row13.Cells[0].Value = tema;
                        row13.Cells[1].Value = porcentajeDemanda;
                        dataGridView5.Rows.Add(row13);
                        numFila++;
                    }
                }




            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> lTemas = new List<string>();
            
            int filasMostradas = dataGridView1.DisplayedRowCount(true);
            bool seleccion = false;
            string temaSeleccionado ="";
            int currentRow = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                currentRow = row.Index;
                if (currentRow < filasMostradas-1)
                {
                    temaSeleccionado = row.Cells[0].Value.ToString();

                    if (!temaSeleccionado.Equals(null))
                    {
                        DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["Considerar"];
                        if (Convert.ToBoolean(cell.Value))
                        {
                            //esta seleccionada
                            seleccion = true;
                            lTemas.Add(temaSeleccionado);

                        }
                        else
                        {
                            //no esta seleccionada
                            seleccion = false;
                        }
                    }
                }

            }


        }
    }
}
