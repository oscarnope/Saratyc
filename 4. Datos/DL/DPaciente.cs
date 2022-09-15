using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saratyc._4._Datos.DL
{
    public class DPaciente
    {
        private string nombres;
        private string apellidos;
        private string identificacion;
        private string fechaNacimiento;
        private string genero;
        private string localidad;
        private string barrio;
        private string nivelConciencia;
        private string autonomia;
        private string condicionSalud;
        private string contexturaFisica;
        private string temperamento;
        private string grupoDiagnostico;
        private string personaAcompaña;
        private string prefGenero;
        private string prefEdad;
        private string prefNacionalidad;
        private string prefIdioma;
        private string prefMascotas;


        public DPaciente()
        {

        }

        public List<string> listaPacientes(string rutaArchivo, List<string> listaPacientes)
        {
            var pacientes = File.ReadAllLines(rutaArchivo);

            foreach (var paciente in pacientes)
            {
                var columns = paciente.Split(',').Where(c => c.Trim() != string.Empty).ToList();
                DPaciente P = new();
                P.nombres = columns[0].ToString();
                P.apellidos = columns[1].ToString();
                P.identificacion = columns[2].ToString();
                P.fechaNacimiento = columns[3].ToString();
                P.genero = columns[4].ToString();
                P.localidad = columns[5].ToString();
                P.barrio = columns[6].ToString();
                P.nivelConciencia = columns[7].ToString();
                P.autonomia = columns[8].ToString();
                P.condicionSalud = columns[9].ToString();
                P.contexturaFisica = columns[10].ToString();
                P.temperamento = columns[11].ToString();
                P.grupoDiagnostico = columns[12].ToString();
                P.personaAcompaña = columns[13].ToString();
                P.prefGenero = columns[14].ToString();
                P.prefEdad = columns[15].ToString();
                P.prefNacionalidad = columns[16].ToString();
                P.prefIdioma = columns[17].ToString();
                P.prefMascotas = columns[18].ToString();

                listaPacientes.Add(P.nombres +"," + P.apellidos +","+P.identificacion +","+ P.fechaNacimiento + "," + P.genero + "," +  P.localidad + "," + P.barrio + "," + P.nivelConciencia + "," + P.autonomia + "," + P.condicionSalud + "," + P.contexturaFisica + "," + P.temperamento + "," + P.grupoDiagnostico + "," + P.personaAcompaña + "," + P.prefGenero + "," + P.prefEdad + "," + P.prefNacionalidad + "," + P.prefIdioma + "," + P.prefMascotas);
            }
        return listaPacientes;
        }
    }
}
