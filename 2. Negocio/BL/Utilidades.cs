using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saratyc._2._Negocio.BL
{
    public class Utilidades
    {
        public void leerArchivoTexto(string ruta)
        {
            // Read the file as one string.
            string[] lines = System.IO.File.ReadAllLines(ruta);
        }

        public int PosicionDe(string source, char toFind, int position)
        {
            int index = -1;
            for (int i = 0; i < position; i++)
            {
                index = source.IndexOf(toFind, index + 1);

                if (index == -1)
                    break;
            }

            return index;
        }

        public void escribirArchivoTurnos(string[] arrayEscribir, string nombreArchivo, string ruta)
        {
            //System.IO.File.WriteAllLines(ruta + nombreArchivo, listaEscribir);
            using (StreamWriter sw = new StreamWriter(ruta+nombreArchivo))
            {
                foreach (string s in arrayEscribir)
                    sw.Write(s + ";");
            }
        }

        void cargarLista()
        {

        }
    }


}
