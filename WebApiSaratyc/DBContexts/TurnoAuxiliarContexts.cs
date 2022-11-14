using System.Data.Entity;
using WebApiSaratyc.Models;

namespace WebApiSaratyc.DBContexts
{

    public class TurnoAuxiliarContexts : DbContext
    {

        public TurnoAuxiliarContexts() 
        {
        }
        public DbSet<TurnoAuxiliar> TurnoAuxiliares { get; set; }
      

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TurnoAuxiliar>().ToTable("turnoauxiliar");
        }*/




    }
}