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

            //string rutaArchivos = "C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources";
            //string archivoTurnos= "Turnos.txt";
            //string ruta = rutaArchivos + "\\" + archivoTurnos;

            List<string> lTurnos = new List<string>();
            //dTurno.listaTurnos(ruta, lTurnos);
            lTurnos = dTurno.listaTurnos();
            return lTurnos;

        }

        public void mostrarPacientes()
        {

        }

    }
}
