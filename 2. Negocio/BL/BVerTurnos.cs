using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saratyc._2._Negocio.BL
{
    public class BVerTurnos
    {
        Utilidades utilidades = new();
        public int obtenerAño(string fecha)
        {
            int slash = utilidades.PosicionDe(fecha,'/',2);
            int año= int.Parse(fecha.Substring(slash + 1,4));
            return año;
        }

        public int obtenerMes(string fecha)
        {
            int slash1 = utilidades.PosicionDe(fecha, '/', 1);
            int slash2 = utilidades.PosicionDe(fecha, '/', 2);
            int mes = int.Parse(fecha.Substring(slash1 + 1, slash2- slash1-1));
            return mes;
        }

        public int obtenerDia(string fecha)
        {
            int slash = utilidades.PosicionDe(fecha, '/', 1);
            int dia = int.Parse(fecha.Substring(0,slash));
            return dia;
        }
    }
}
