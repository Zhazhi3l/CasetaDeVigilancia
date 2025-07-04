using CasetaDeVigilancia.src.Datos.Datos.Modelos;
using System.Data.Entity;

namespace CasetaDeVigilancia.src.Datos
{
    public class FraccionamientoContext : DbContext
    {
        public FraccionamientoContext() : base("name=FraccionamientoContext") { }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Residente> Residentes { get; set; }
        public DbSet<Invitado> Invitados { get; set; }
        public DbSet<HistorialAcceso> HistorialAccesos { get; set; }


    }
}
