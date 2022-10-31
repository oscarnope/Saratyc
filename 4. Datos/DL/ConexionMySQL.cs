using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.X509;
using Saratyc._1._Presentacion_UI.Forms;
using Saratyc._2._Negocio.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saratyc._4._Datos.DL
{
    //Conexion a una base de datos MYSQL
    public partial class ConexionMySQL
    {
        List<object> datos;
        List<string> datosConsulta = new List<string>();

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

        public List<string> consultarEnferdata(string query)
        {

            int error = 0;

            MySqlConnection sqlConexion = new MySqlConnection("Server=74.208.41.234; Database=enferdata-web; user=enferdata_consulta; password=4f&l$9p01A;");

            MySqlCommand cmd = sqlConexion.CreateCommand();
            //cmd.CommandText = "select * from `enferdata-web`.`Paciente` where id =4047 order by id;"; 
            cmd.CommandText = query;

            try
            {
                sqlConexion.Open();
            }
            catch (Exception erro)
            {
                //MessageBox.Show("Erro" + erro);
                error = 1;
                MessageBox.Show("No se pudo establecer conexión con Enferdata, intente nuevamente","Error Conectando");
                //Close();

                //datosConsulta.Add(lineaError);
            }


            if (error != 1)
            {

                //Se ejecuta el comando de lectura
                MySqlDataReader reader = cmd.ExecuteReader();

                string a;
                string linea = "";
                int campo = 0;

                while (reader.Read())
                {

                    var values = new Object[reader.FieldCount];
                    reader.GetValues(values);

                    datos = values.ToList();

                    foreach (var registro in datos)
                    {
                        campo++;
                        a = registro.ToString();

                        if (campo < reader.FieldCount)
                        {
                            linea += a + ",";
                        }
                        else
                        {
                            linea += a;
                        }
                    }

                    datosConsulta.Add(linea);
                    linea = "";
                    campo = 0;
                }
            }

            sqlConexion.Close();
            //Se retorna la lista de resultados
            return datosConsulta;
        }

        public string conectarsaratyc()
        {
            MySqlConnection sqlConexion = new MySqlConnection("Server=127.0.0.1; Database=saratyc; user=admin; password=admin;");
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

        public string insertarSaratyc(string query)
        {
            int errorConexion = 0;
            int OK = 0;
            string estado = "OK";

            MySqlConnection sqlConexion = new MySqlConnection("Server=127.0.0.1; Database=saratyc; user=root; password=admin;");

            MySqlCommand cmd = sqlConexion.CreateCommand();
            cmd.CommandText = query;

            try
            {
                sqlConexion.Open();
            }
            catch (Exception erro)
            {
                errorConexion = 1;
                MessageBox.Show("No se pudo establecer conexión con Saratyc, intente nuevamente", "Error Conectando");
            }


            if (errorConexion != 1)
            {

                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //Se ejecuta el comando de insercion
                    OK = 1;
                    while (reader.Read())
                    {

                    }
                }
                catch (Exception erro)
                {
                    OK = 0;
                    estado = erro.ToString();
                }



            }

            sqlConexion.Close();
            //Se retorna el resultado            

            return estado;
        }

        internal List<string> consultarSaratyc(string query)
        {
            int error = 0;

            MySqlConnection sqlConexion = new MySqlConnection("Server=127.0.0.1; Database=saratyc; user=root; password=admin;");

            MySqlCommand cmd = sqlConexion.CreateCommand(); 
            cmd.CommandText = query;

            try
            {
                sqlConexion.Open();
            }
            catch (Exception erro)
            {
                //MessageBox.Show("Erro" + erro);
                error = 1;
                MessageBox.Show("No se pudo establecer conexión con Saratyc, intente nuevamente", "Error Conectando");
                //Close();

                //datosConsulta.Add(lineaError);
            }

            if (error != 1)
            {

                //Se ejecuta el comando de lectura
                MySqlDataReader reader = cmd.ExecuteReader();

                string a;
                string linea = "";
                int campo = 0;

                while (reader.Read())
                {

                    var values = new Object[reader.FieldCount];
                    reader.GetValues(values);

                    datos = values.ToList();

                    foreach (var registro in datos)
                    {
                        campo++;
                        a = registro.ToString();

                        if (campo < reader.FieldCount)
                        {
                            linea += a + ",";
                        }
                        else
                        {
                            linea += a;
                        }
                    }

                    datosConsulta.Add(linea);
                    linea = "";
                    campo = 0;
                }
            }

            sqlConexion.Close();
            //Se retorna la lista de resultados
            return datosConsulta;
        }
    }
}
