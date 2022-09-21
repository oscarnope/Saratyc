using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saratyc._2._Negocio.BL
{
    class BAsignarTurno
    {
        public void CalcularRanking(string institucion, string restriccion, string tipoTurno, string fechaInicio, string fechaFin)
        {
            int puntajeInstitucion,puntajeRestriccion, puntajeTipoTurno,puntajeDuracion;
            puntajeInstitucion = calcularPuntajeInstitucion(institucion);
            puntajeRestriccion = calcularPuntajeRestriccion(restriccion);
            puntajeTipoTurno = calcularPuntajeTipoTurno(tipoTurno);
            puntajeDuracion = calcularpuntajeDuracion(fechaInicio, fechaFin);
        }

        public int calcularPuntajeInstitucion(string institucion)
        {
            switch (institucion)
            {               
                case "Especialidad Mama":
                    return 10;
                    //break;
                case "Domicilio":
                    return 9;
                    //break; 
                case "Nogales":
                    return 8;
                    //break;
            default:
                    return 0;
                    //break;
            }
        }

        public int calcularPuntajeRestriccion(string restriccion)
        {
            switch (restriccion)
            {
                case "Especialidad Mama":
                    return 10;
                //break;
                case "Domicilio":
                    return 9;
                //break; 
                case "Nogales":
                    return 8;
                //break;
                default:
                    return 0;
                    //break;
            }
        }

        public int calcularPuntajeTipoTurno(string tipoTurno)
        {
            switch (tipoTurno)
            {
                case "Especialidad Mama":
                    return 10;
                //break;
                case "Domicilio":
                    return 9;
                //break; 
                case "Nogales":
                    return 8;
                //break;
                default:
                    return 0;
                    //break;
            }
        }

        public int calcularpuntajeDuracion(string fechaInicio, string fechaFin)
        {
            string duracion="10";
            //int duracion = fechaFin - fechaInicio;
            switch (duracion)
            {
                case "Especialidad Mama":
                    return 10;
                //break;
                case "Domicilio":
                    return 9;
                //break; 
                case "Nogales":
                    return 8;
                //break;
                default:
                    return 0;
                    //break;
            }
        }

    }


}
