

using WebApiSaratyc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApiSaratyc.Repository;
using WebApiSaratyc.DBContexts;
using MySql.Data.MySqlClient;

namespace WebApiSaratyc.Repository
{
    public class TurnoAuxiliarRepository : ITurnoAuxiliarRepository
    {
        private readonly TurnoAuxiliarContexts _dbContext;

        public TurnoAuxiliarRepository()
        {
            //_dbContext = new TurnoAuxiliarContexts();


        }

        public TurnoAuxiliar GetTurnoAuxiliar(int id)
        {
            try
            {


                MySqlConnection sqlConexion = new MySqlConnection("Server=construmedios; Database=saratyc; user=admin; password=admin;");

                sqlConexion.Open();
                List<TurnoAuxiliar> TurnoAuxiliares = new List<TurnoAuxiliar>();

                var command = new MySqlCommand("SELECT idauxiliar, idturno FROM turnoauxiliar;", sqlConexion);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                    reader.GetValue(0);
                    TurnoAuxiliar r = new TurnoAuxiliar { idpaciente = id, idauxiliar = reader.GetInt32(0), idturno = reader.GetInt32(1) };
                    TurnoAuxiliares.Add(r);
                };

                reader.Close();
                command.Dispose();
                sqlConexion.Close();

                return TurnoAuxiliares.Find(z => z.idpaciente == id);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex);
                return null;
            }


        }
    }
}