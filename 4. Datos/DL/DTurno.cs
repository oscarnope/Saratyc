using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saratyc._4._Datos.DL
{
    class DTurno
    {
        private string institucion;
        private string restriccionAuxPreferido;
        private string restriccionAuxRechazado;
        private string tipoTurno;
        private string fechaInicio;
        private string fechaFin;
        private string idPaciente;
        private string asignado;

        public DTurno()
        {

        }

        public List<string> listaTurnos(string rutaArchivo, List<string> listaTurnos)
        {
            var turnos = File.ReadAllLines(rutaArchivo);

            foreach (var turno in turnos)
            {
                //var columns = turno.Split(',').Where(c => c.Trim() != string.Empty).ToList();
                var columns = turno.Split(',').ToList();
                DTurno T = new();
                T.institucion = columns[0].ToString();
                T.restriccionAuxPreferido = columns[1].ToString();
                T.restriccionAuxRechazado = columns[2].ToString();
                T.tipoTurno = columns[3].ToString();
                T.fechaInicio = columns[4].ToString();
                T.fechaFin = columns[5].ToString();
                T.idPaciente = columns[6].ToString();
                T.asignado = columns[7].ToString();
                listaTurnos.Add(T.institucion + "," + T.restriccionAuxPreferido + "," + T.restriccionAuxRechazado + "," + T.tipoTurno + "," + T.fechaInicio + "," + T.fechaFin + "," + T.idPaciente + "," + T.asignado);
            }
            return listaTurnos;
        }
    }
}
