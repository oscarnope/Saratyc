using Saratyc._4._Datos.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saratyc._2._Negocio.BL
{
    public class BPaciente
    {
        public List<string> cargarPacientes()
        {
            Utilidades ut = new Utilidades();
            DPaciente dPaciente = new();
            
            string rutaArchivos = "C:\\Users\\Julian\\source\\repos\\Saratyc\\Resources";
            string archivoPacientes = "Pacientes.txt";
            string ruta = rutaArchivos + "\\" + archivoPacientes;

            List<string> lPacientes = new List<string>();
            dPaciente.listaPacientes(ruta, lPacientes);
            return lPacientes;

        }

        public void mostrarPacientes()
        {

        }



    }
}
