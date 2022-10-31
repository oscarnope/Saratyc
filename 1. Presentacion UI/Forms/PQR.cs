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
    public partial class PQR : Form
    {
        public PQR()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void PQR_Load(object sender, EventArgs e)        {


            List<string> listaTemas = new List<string> { "Colostomía", "Discapacidad visual", "Drenes", "Glucometría", "Medicación aplicación endovenosa", "Nefrostomia", "Oxigeno", "Sonda Gastrostomía", "Sonda Naso gástrica", "Sonda Orogástrica", "Sonda Vesical", "Traqueostomía", "Medicina Interna", "Quirúrgico", "Oncológico", "Psiquiátrico", "Madre recién nacido", "Neurológico", "Paciente acompañado de empleada", "Paciente acompañado de familiar", "Paciente sin compañía" };
            comboTemas.DataSource = listaTemas;
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
