﻿using System;
using System.Collections;
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
        private string idauxiliarEnferdata;
        private string idauxiliarSaratyc;

        public DTurno()
        {

        }

        //public List<string> listaTurnos(string rutaArchivo, List<string> listaTurnos)
        public List<string> listaTurnos()
        {
            string id = "";
            string institucion;
            string restriccionAuxPreferido;
            string restriccionAuxRechazado;
            string tipoTurno;
            string fechaInicio;
            string fechaFin;
            string idPaciente;
            string idAuxiliarEnferdata;
            string idAuxiliarSaratyc;

            List<string> lTurnos = new List<string>();
            //var turnos = File.ReadAllLines(rutaArchivo);
            string query;
            List<string> listaTurnos = new List<string>();


            ConexionMySQL conexionMySQL = new ConexionMySQL();

            //Consulta los turnos que aun no han finalizado con fecha de inicio inferior a 6 meses a partir de la fecha
            query = "SELECT DISTINCT\r\n    Servicio.id,\r\n    ServicioTipo.nombre AS Institucion,\r\n    \"\" as restriccionAuxPreferido,\r\n    \"\" as restriccionAuxRechazado,\r\n    Turno.nombre AS 'Tipo Turno',\r\n    Servicio.fechaIni AS 'Fecha Inicio',\r\n    Servicio.fechaFin AS 'Fecha Fin',\r\n    Servicio.pacienteId AS IdPaciente,\r\n    ServicioTurnoDiaEnfermera.enfermeraId AS 'IdAuxiliar Enferdata',\r\n\t'' AS 'IdAuxiliar Saratyc'\r\nFROM\r\n    `enferdata-web`.`Servicio` Servicio,\r\n    `enferdata-web`.`ServicioTipo` ServicioTipo,\r\n    `enferdata-web`.`ServicioTurno` ServicioTurno,\r\n    `enferdata-web`.`Turno` Turno,\r\n    `enferdata-web`.`ServicioTurnoDia` ServicioTurnoDia,\r\n    `enferdata-web`.`ServicioTurnoDiaEnfermera` ServicioTurnoDiaEnfermera\r\nWHERE\r\n    Servicio.servicioTipoId = ServicioTipo.id\r\n        AND Servicio.id = ServicioTurno.id\r\n        AND ServicioTurno.TurnoId = Turno.id\r\n        AND ServicioTurno.ServicioId = ServicioTurnoDia.servicioTurnoId\r\n        AND ServicioTurnoDia.ID = ServicioTurnoDiaEnfermera.servicioTurnoDiaId\r\n        AND Servicio.Finalizado <> 1\r\n        AND Servicio.fechaIni >= (SELECT \r\n            DATE_SUB(DATE_FORMAT(NOW(), '%Y-%m-%d'),\r\n                    INTERVAL '6' MONTH)\r\n        )\r\nORDER BY id DESC";

            listaTurnos = conexionMySQL.consultarEnferdata(query);
            
            /*
            foreach (var turno in listaTurnos)
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
                T.auxiliarAsignado = columns[7].ToString();
                listaTurnos.Add(T.institucion + "," + T.restriccionAuxPreferido + "," + T.restriccionAuxRechazado + "," + T.tipoTurno + "," + T.fechaInicio + "," + T.fechaFin + "," + T.idPaciente + "," + T.auxiliarAsignado);
            }
            */

            return listaTurnos;
        }
    }
}
