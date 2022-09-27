using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using Saratyc._1._Presentacion_UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saratyc._4._Datos.DL
{
    //Conexion a una base de datos MYSQL
    public partial class ConexionMySQL
    {
        //string conexion;
        public string conectarEnferdata()
        {
            MySqlConnection sqlConexion = new MySqlConnection("Server=74.208.41.234; Database=enferdata-web; user=enferdata_consulta; password=4f&l$9p01A;");
            try
            {
                sqlConexion.Open();
                //conexion.Text = "Conectados!!";
                sqlConexion.Close();
                return "true";
            }
            catch (System.Exception ex)
            {
                return "false";
                //conexion.Text = ex.Message;
            }
        }

        public string consultarEnferdata()
        {
            string idnumber ="";
            MySqlConnection sqlConexion = new MySqlConnection("Server=74.208.41.234; Database=enferdata-web; user=enferdata_consulta; password=4f&l$9p01A;");

            MySqlCommand cmd = sqlConexion.CreateCommand();
            cmd.CommandText = "select * from `enferdata-web`.`Paciente` where id =4047 order by id;"; 

            try
            {
                sqlConexion.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
                //this.Close();
            }

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                idnumber = reader.GetString(1).ToString();
            }

            MessageBox.Show(idnumber);

            return idnumber;
        }
    }
}
