using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSaratyc.DBContexts
{
    //Conexion a una base de datos MYSQL
    public partial class ConexionMySQL
    {

        public string conectarsaratyc()
        {
            MySqlConnection sqlConexion = new MySqlConnection("Server=construmedios; Database=saratyc; user=admin; password=admin;");
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
    }
}
