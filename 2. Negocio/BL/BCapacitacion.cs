using Saratyc._4._Datos.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saratyc._2._Negocio.BL
{
    class BCapacitacion
    {
        internal string guardarPlanCapacitacion(List<string> lCapacitacion, string idAuxiliar)
        {
            string temaCapacitacion;
            string nivel;
            string OK="";

            DCapacitacion dCapacitacion = new DCapacitacion();

            foreach (var capacitacion in lCapacitacion)
            {
                var columns = capacitacion.Split(',').Where(c => c.Trim() != string.Empty).ToList();
                temaCapacitacion = columns[0].ToString();
                nivel = columns[1].ToString();

                OK = dCapacitacion.guardarPlanCapacitacion(idAuxiliar, temaCapacitacion, nivel);
            }

            return OK;

        }
    }
}
