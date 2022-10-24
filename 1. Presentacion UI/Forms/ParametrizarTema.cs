using Microsoft.VisualBasic;
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
    public partial class ParametrizarTema : Form
    {
        public ParametrizarTema()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ParametrizarTema_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            MenuCapacitacion mc = new MenuCapacitacion();
            mc.Activate();
            mc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Catéter Periférico");
            dataGridView1.Rows.Add("Colostomía");
            dataGridView1.Rows.Add("Discapacidad auditiva");
            dataGridView1.Rows.Add("Discapacidad visual");
            dataGridView1.Rows.Add("Drenes");
            dataGridView1.Rows.Add("Glucometría");
            dataGridView1.Rows.Add("Habilidades blandas");
            dataGridView1.Rows.Add("Madre recién nacido");
            dataGridView1.Rows.Add("Medicación aplicación endovenosa");
            dataGridView1.Rows.Add("Medicina Interna");
            dataGridView1.Rows.Add("Nefrostomia");
            dataGridView1.Rows.Add("Neurológico");
            dataGridView1.Rows.Add("Oncológico ");
            dataGridView1.Rows.Add("Oxigeno");
            dataGridView1.Rows.Add("Psiquiátrico ");
            dataGridView1.Rows.Add("Quirúrgico ");
            dataGridView1.Rows.Add("Sonda Gastrostomía");
            dataGridView1.Rows.Add("Sonda Naso gástrica");
            dataGridView1.Rows.Add("Sonda Orogástrica");
            dataGridView1.Rows.Add("Sonda Vesical");
            dataGridView1.Rows.Add("Traqueostomía");

        }
    }
}
