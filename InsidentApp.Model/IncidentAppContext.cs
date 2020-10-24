using System;
using IncidentApp.Model.Model;
using Microsoft.EntityFrameworkCore;



namespace IncidentApp.Model
{
    public class IncidentAppContext: DbContext
    {
        public IncidentAppContext(DbContextOptions<IncidentAppContext> options) : base(options) { }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Puesto> Puesto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Sla> Sla { get; set; }
        public DbSet<Prioridad> Prioridad { get; set; } 
        public DbSet<Incidente> Incidente { get; set; }
        public DbSet<HistorialIncidente> HistorialIncidente { get; set; }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.DepartamentoId);
                entity.Property<int>(e => e.DepartamentoId);
                entity.Property<string>(e => e.Nombre).HasMaxLength(100).IsRequired();
                entity.Property<string>(e => e.Estatus).HasMaxLength(2).IsRequired();
                entity.Property<bool>(e => e.Borrado).HasDefaultValue(false).IsRequired();
                entity.Property<DateTime>(e => e.FechaRegistro).HasDefaultValue(DateTime.Now);
                entity.Property<DateTime>(e => e.FechaModificacion);
                entity.Property<int>(e => e.CreadoPor).IsRequired();
                entity.Property<int>(e => e.ModificadoPor).IsRequired();

                //entity.HasOne<Usuario>(x => x.Usuario).WithMany(u=>u.Departamentos).HasForeignKey(d => d.CreadoPor)
                //.HasForeignKey(d => d.ModificadoPor); 

                
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UsuarioId);
                entity.Property<int>(e => e.UsuarioId);
                entity.Property<int>(e => e.PuestoId);
                entity.Property<string>(e => e.Nombre).HasMaxLength(100).IsRequired();
                entity.Property<string>(e => e.Apellido).HasMaxLength(100).IsRequired();
                entity.Property<string>(e => e.Cedula).HasMaxLength(11).IsRequired();
                entity.Property<string>(e => e.Correo).HasMaxLength(50).IsRequired();
                entity.Property<string>(e => e.Telefono).HasMaxLength(15);
                entity.Property<DateTime>(e => e.FechaNacimiento).IsRequired();
                entity.Property<string>(e => e.NombreUsuario).HasMaxLength(100).IsRequired();
                entity.Property<string>(e => e.Contraseña).HasMaxLength(500).IsRequired();
                entity.Property<string>(e => e.Estatus).HasMaxLength(2).IsRequired();
                entity.Property<bool>(e => e.Borrado).HasDefaultValue(false).IsRequired();
                entity.Property<DateTime>(e => e.FechaRegistro).HasDefaultValue(DateTime.Now);
                entity.Property<DateTime>(e => e.FechaModificacion);
                entity.Property<int>(e => e.CreadoPor).IsRequired();
                entity.Property<int>(e => e.ModificadoPor).IsRequired();

                entity.HasOne<Puesto>(u => u.Puesto).WithMany(p => p.Usuarios)
                        .HasForeignKey(u => u.PuestoId);

                entity.HasMany(x=>x.Departamentos).WithOne(u => u.Usuario)
                        .HasForeignKey(u=>u.CreadoPor).IsRequired(false)
                        .HasForeignKey(u=>u.ModificadoPor).OnDelete(DeleteBehavior.NoAction);


                entity.HasMany(x => x.HistorialIncidentes).WithOne(u => u.Usuario)
                        .HasForeignKey(u => u.CreadoPor).IsRequired(false)
                        .HasForeignKey(u => u.ModificadoPor).OnDelete(DeleteBehavior.NoAction);

                entity.HasMany(x => x.Incidentes).WithOne(u => u.Usuario)
                        .HasForeignKey(u => u.CreadoPor).IsRequired(false)
                        .HasForeignKey(u => u.ModificadoPor).OnDelete(DeleteBehavior.NoAction);


                entity.HasMany(x => x.Prioridades).WithOne(u => u.Usuario)
                        .HasForeignKey(u => u.CreadoPor).IsRequired(false)
                        .HasForeignKey(u => u.ModificadoPor).OnDelete(DeleteBehavior.NoAction);


                entity.HasMany(x => x.Puesto).WithOne(u => u.Usuario)
                        .HasForeignKey(u => u.CreadoPor).IsRequired(false)
                        .HasForeignKey(u => u.ModificadoPor).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Puesto>(entity =>
            {
                entity.HasKey(e => e.PuestoId); 
                entity.Property<int>(e => e.PuestoId);
                entity.Property<int>(e => e.DepartamentoId);
                entity.Property<string>(e => e.Nombre).HasMaxLength(100).IsRequired();
                entity.Property<string>(e => e.Estatus).HasMaxLength(2).IsRequired();
                entity.Property<bool>(e => e.Borrado).HasDefaultValue(false).IsRequired();
                entity.Property<DateTime>(e => e.FechaRegistro).HasDefaultValue(DateTime.Now);
                entity.Property<DateTime>(e => e.FechaModificacion);
                entity.Property<int>(e => e.CreadoPor).IsRequired();
                entity.Property<int>(e => e.ModificadoPor).IsRequired();

                entity.HasOne<Departamento>(p => p.Departamento).WithMany(d => d.Puestos).HasForeignKey(p => p.DepartamentoId);
            });
        }

    }
}
