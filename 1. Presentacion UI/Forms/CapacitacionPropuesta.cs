using MySqlX.XDevAPI.Relational;
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
    public partial class CapacitacionPropuesta : Form
    {
        private List<string> lcapacitaciones;

        public CapacitacionPropuesta(List<string> lcapacitaciones, string idAux)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.lcapacitaciones = lcapacitaciones;
            idAuxiliar.Text = idAux;
        }

        private void CapacitacionPropuesta_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;


            string tema;
            string nivel;
            int numeroFila = 0;
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

            foreach (var lcapacitacion in lcapacitaciones)
            {
                numeroFila++;
                var columns = lcapacitacion.Split(',').Where(c => c.Trim() != string.Empty).ToList();
                tema = columns[0].ToString();
                nivel = columns[1].ToString();


                    if (numeroFila == 1)
                    {
                        row.CreateCells(dataGridView1);
                        row.Cells[0].Value = tema;
                        row.Cells[1].Value = nivel;
                        dataGridView1.Rows.Add(row);
                    }
                    else if (numeroFila == 2)
                    {
                        row2.CreateCells(dataGridView1);
                        row2.Cells[0].Value = tema;
                        row2.Cells[1].Value = nivel;
                        dataGridView1.Rows.Add(row2);

                    }
                    else if (numeroFila == 3)
                    {

                        row3.CreateCells(dataGridView1);
                        row3.Cells[0].Value = tema;
                        row3.Cells[1].Value = nivel;
                        dataGridView1.Rows.Add(row3);
                     }
                    else if (numeroFila == 4)
                    {
                        row4.CreateCells(dataGridView1);
                        row4.Cells[0].Value = tema;
                        row4.Cells[1].Value = nivel;
                        dataGridView1.Rows.Add(row4);

                }
                    else if (numeroFila == 5)
                    {
                        row5.CreateCells(dataGridView1);
                        row5.Cells[0].Value = tema;
                        row5.Cells[1].Value = nivel;
                    dataGridView1.Rows.Add(row5);

                }
                    else if (numeroFila == 6)
                    {
                        row6.CreateCells(dataGridView1);
                        row6.Cells[0].Value = tema;
                        row6.Cells[1].Value = nivel;
                    dataGridView1.Rows.Add(row6);

                }
                    else if (numeroFila == 7)
                    {
                        row7.CreateCells(dataGridView1);
                        row7.Cells[0].Value = tema;
                        row7.Cells[1].Value = nivel;
                    dataGridView1.Rows.Add(row7);

                }
                    else if (numeroFila == 8)
                    {
                        row8.CreateCells(dataGridView1);
                        row8.Cells[0].Value = tema;
                        row8.Cells[1].Value = nivel;
                    dataGridView1.Rows.Add(row8);

                }
                    else if (numeroFila == 9)
                    {
                        row9.CreateCells(dataGridView1);
                        row9.Cells[0].Value = tema;
                        row9.Cells[1].Value = nivel;
                    dataGridView1.Rows.Add(row9);

                }
                    else if (numeroFila == 10)
                    {
                        row10.CreateCells(dataGridView1);
                        row10.Cells[0].Value = tema;
                        row10.Cells[1].Value = nivel;
                    dataGridView1.Rows.Add(row10);

                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int filasMostradas = dataGridView1.DisplayedRowCount(true);
            int currentRow = 0;
            string temaSeleccionado = "";
            string nivel = "";
            string idAux = idAuxiliar.Text;
            List<string> lCapacitacion = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                currentRow = row.Index;
                if (currentRow < filasMostradas - 1)
                {
                    temaSeleccionado = row.Cells[0].Value.ToString();
                    nivel = row.Cells[1].Value.ToString();

                    if (!temaSeleccionado.Equals(null))
                    {
                        lCapacitacion.Add(temaSeleccionado + "," + nivel);
                    }
                    
                }

            }
            BCapacitacion bcapacitacion = new BCapacitacion();

            bcapacitacion.guardarPlanCapacitacion(lCapacitacion, idAux);
            
            indicador.ForeColor = Color.Blue;
            indicador.Text = "Se guardo el plan de capacitación";
        }
    }
}
