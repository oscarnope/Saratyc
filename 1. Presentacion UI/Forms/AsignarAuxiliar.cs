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
    public partial class AsignarAuxiliar : Form
    {
        public AsignarAuxiliar()
        {
            InitializeComponent();
        }

        private void AsignarAuxiliar_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewRow row2 = new DataGridViewRow();
            DataGridViewRow row3 = new DataGridViewRow();

            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "0.998";
            row.Cells[1].Value = "idAux1";
            row.Cells[2].Value = "NombreAux1";
            row.Cells[3].Value = "ApellidoAux1";

            row2.CreateCells(dataGridView1);
            row2.Cells[0].Value = "0.326";
            row2.Cells[1].Value = "idAux2";
            row2.Cells[2].Value = "NombreAux2";
            row2.Cells[3].Value = "ApellidoAux2";

            row3.CreateCells(dataGridView1);
            row3.Cells[0].Value = "0.189";
            row3.Cells[1].Value = "idAux3";
            row3.Cells[2].Value = "NombreAux3";
            row3.Cells[3].Value = "ApellidoAux3";
            dataGridView1.Rows.Add(row);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {

            this.Hide();
            AuxiliarRecomendado ar = new AuxiliarRecomendado();
            ar.Activate();
            ar.Show();
        }
    }
}
