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
    public partial class EditarPlan : Form
    {
        public EditarPlan()
        {
            InitializeComponent();
        }

        private void DisenarPlan_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            /*
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
            */
        }
    }
}
