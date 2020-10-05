using Microsoft.EntityFrameworkCore;
using JordyP1_Apl.Entidades;

namespace JordyP1_Apl.DAL{

    public class Contexto : DbContext{

        public DbSet<Ciudades> Ciudades {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            optionsBuilder.UseSqlite(@" Data Source = Data/Ciudades");
        }
    }
}