using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saratyc._4._Datos.DL
{
    class DCapacitacion
    {
        internal string guardarPlanCapacitacion(string idAuxiliar, string temaCapacitacion, string nivel)
        {
            string OK = "";

            string query;
            ConexionMySQL conexionMySQL = new ConexionMySQL();

            //Se borran primero los datos del auxiliar
            //query = "DELETE FROM `saratyc`.`capacitacion` WHERE (`idauxiliar` = '" + idAuxiliar + "')";
            //OK = conexionMySQL.insertarSaratyc(query);

            //Se insertan el plan de capacitacion
            query = "INSERT INTO `saratyc`.`capacitacion` (`idauxiliar`, `tema`,`nivel`) VALUES ('" + idAuxiliar + "','" + temaCapacitacion + "','" + nivel + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            return OK;
        }
    }
}
