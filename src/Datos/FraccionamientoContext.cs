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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapear tablas
            modelBuilder.Entity<Residente>().ToTable("Usuario");
            modelBuilder.Entity<Invitado>().ToTable("Invitado");
            modelBuilder.Entity<HistorialAcceso>().ToTable("Historial");

            // Residente → Invitados (1:N)
            modelBuilder.Entity<Residente>()
                        .HasMany(r => r.Invitados)
                        .WithRequired(i => i.Residente)
                        .HasForeignKey(i => i.UsuarioID);

            // Residente → Historiales (1:N)
            modelBuilder.Entity<Residente>()
                        .HasMany(r => r.Historiales)
                        .WithRequired(h => h.Residente)
                        .HasForeignKey(h => h.UsuarioID);

            // Historial → Invitado (N:1)
            modelBuilder.Entity<HistorialAcceso>()
                        .HasRequired(h => h.Invitado)
                        .WithMany()    // o define colección en Invitado si lo prefieres
                        .HasForeignKey(h => h.InvitadoID);
        }
    }
}
