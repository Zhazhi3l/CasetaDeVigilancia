using CasetaDeVigilancia.src.Datos.Datos.Modelos;
using System.Data.Entity;

namespace CasetaDeVigilancia.src.Datos
{
    public class FraccionamientoContext : DbContext
    {
        public FraccionamientoContext() : base("name=FraccionamientoContext") { }

        public DbSet<Residente> Residentes { get; set; }
        public DbSet<Invitado> Invitados { get; set; }
        public DbSet<HistorialAcceso> HistorialAccesos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HistorialAcceso>()
                        .ToTable("Historial");

            // Historial → Usuario
            modelBuilder.Entity<HistorialAcceso>()
                        .HasRequired(h => h.Usuario)
                        .WithMany(u => u.Historiales)
                        .HasForeignKey(h => h.UsuarioID);

            // Historial → Invitado
            modelBuilder.Entity<HistorialAcceso>()
                        .HasRequired(h => h.Invitado)
                        .WithMany()   // Invitado no necesita colecc. de historial, o define una si quieres
                        .HasForeignKey(h => h.InvitadoID);
        }
    }
}
