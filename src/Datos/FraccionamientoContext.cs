using CasetaDeVigilancia.src.Datos.Datos.Modelos;
using System.Data.Entity;

namespace CasetaDeVigilancia.src.Datos
{
    public class FraccionamientoContext : DbContext
    {
        public FraccionamientoContext()
            : base("name=FraccionamientoContext") { }

        public DbSet<Residente> Residentes { get; set; }
        public DbSet<Invitado> Invitados { get; set; }
        public DbSet<HistorialAcceso> Historiales { get; set; }

        
    }
}
