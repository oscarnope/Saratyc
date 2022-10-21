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
    public partial class AuxiliarEnfermeria : Form
    {
        string idEnferdata;
        string nombre ;
        string apellido;
        string identificacion ;
        string fechaNacimiento ;
        string genero ;
        string ciudad ;
        string localidad ;
        string barrio ;
        string nacionalidad ;
        string disponibilidad ;
        string personalidad ;

        BAuxiliar bAuxiliar = new BAuxiliar();
        List<string> lAuxiliar = new List<string>();

        public AuxiliarEnfermeria()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AuxiliarEnfermeria_Load(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            Hide();
            MenuServicios ms = new MenuServicios();
            ms.Activate();
            ms.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string identificacionAuxiliar = TextIdentificacion.Text;
            lAuxiliar=bAuxiliar.buscarAuxiliar(identificacionAuxiliar);

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
                nacionalidad = columns[9].ToString();
                disponibilidad = columns[10].ToString();
                personalidad = columns[11].ToString();

                textNombre.Text = nombre;
                textApellido.Text = apellido;
                textFechaNacimiento.Text = fechaNacimiento; 
                textGenero.Text = genero;
                textLocalidad.Text = localidad;
                textBarrio.Text = barrio;
                //textContextura.Text = contextura;
            }
        }
    }
}
