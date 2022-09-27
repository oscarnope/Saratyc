using Microsoft.VisualBasic;
using Org.BouncyCastle.Utilities;
using Saratyc._1._Presentacion_UI.Forms;
using Saratyc._4._Datos.DL;
using System;
using System.Windows.Forms;

namespace Saratyc._1._Presentacion_UI.Forms
{
    public partial class Login : Form
    {
        ConexionMySQL conexion = new ConexionMySQL();

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void Login_Load(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {


            
        }

        private void Login_Load_1(object sender, System.EventArgs e)
        {

        }

        private void ingresar_Click(object sender, System.EventArgs e)
        {
            //string conectado;
            //string mensaje="";
            /*conectado =conexion.conectarEnferdata();

            //SE comprueba la conexion a la BD de enferdata y se muestra el mensaje correspondiente
            if (conectado.Equals("true"))
            {
                mensaje = "Conectado con Enferdata";
            }
            else if (conectado.Equals("false"))
            {
                mensaje = "No se pudo establecer conexión con Enferdata";
            }
            MessageBox.Show(mensaje);*/

            Hide();
            MenuServicios ms = new MenuServicios();
            ms.Activate();
            ms.Show();
        }
    }
}