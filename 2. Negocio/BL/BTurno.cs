using Saratyc._4._Datos.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saratyc._2._Negocio.BL
{
    public class BTurno
    {
        public List<string> cargarTurnos()
        {
            Utilidades ut = new Utilidades();
            DTurno dTurno = new();
            List<string> lTurnos = new List<string>();
            lTurnos = dTurno.listaTurnos();
            return lTurnos;

        }

        public void mostrarPacientes()
        {

        }

        internal void asignarTurno(string idTurno, string idPaciente, string idAuxiliar)
        {
            DTurno dTurno = new();
            dTurno.asignarTurno(idTurno, idPaciente, idAuxiliar);
        }
    }
}
