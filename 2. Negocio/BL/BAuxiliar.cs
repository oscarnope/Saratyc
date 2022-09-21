using Saratyc._4._Datos.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saratyc._2._Negocio.BL
{
    class BAuxiliar
    {
        public List<string> cargarAuxiliares()
        {
            Utilidades ut = new Utilidades();
            DAuxiliar dAuxiliar = new();

            string rutaArchivos = "C:\\Users\\Julian\\source\\repos\\Saratyc\\Resources";
            string archivoAuxiliares = "Auxiliares.txt";
            string ruta = rutaArchivos + "\\" + archivoAuxiliares;

            List<string> lAuxiliares = new List<string>();
            dAuxiliar.listaAuxiliares(ruta, lAuxiliares);
            return lAuxiliares;

        }

        public void mostrarPacientes()
        {

        }


    }
}
