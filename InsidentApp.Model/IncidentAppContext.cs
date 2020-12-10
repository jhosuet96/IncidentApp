using System;
using IncidentApp.Model.Model;
using Microsoft.EntityFrameworkCore;



namespace IncidentApp.Model
{
    public class IncidentAppContext: DbContext
    {
      
        public IncidentAppContext(DbContextOptions<IncidentAppContext> options) : base(options){}
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

                entity.HasOne<Departamento>(p => p.Departamento).WithMany(d => d.Puestos).HasForeignKey(p => p.DepartamentoId).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UsuarioId);
                entity.Property<int>(e => e.UsuarioId);
                entity.Property<int>(e => e.PuestoID);
                entity.Property<string>(e => e.Nombre).HasMaxLength(100).IsRequired();
                entity.Property<string>(e => e.Apellido).HasMaxLength(100).IsRequired();
                entity.Property<string>(e => e.Cedula).HasMaxLength(11).IsRequired();
                entity.Property<string>(e => e.Correo).HasMaxLength(50).IsRequired();
                entity.Property<string>(e => e.Telefono).HasMaxLength(15);
                entity.Property<DateTime>(e => e.FechaNacimiento).IsRequired();
                entity.Property<string>(e => e.NombreUsuario).HasMaxLength(100).IsRequired();
                entity.Property<string>(e => e.Contrasena).HasMaxLength(500).IsRequired();
                entity.Property<string>(e => e.Estatus).HasMaxLength(2).IsRequired();
                entity.Property<bool>(e => e.Borrado).HasDefaultValue(false).IsRequired();
                entity.Property<DateTime>(e => e.FechaRegistro).HasDefaultValue(DateTime.Now);
                entity.Property<DateTime>(e => e.FechaModificacion);
                entity.Property<int>(e => e.CreadoPor).IsRequired();
                entity.Property<int>(e => e.ModificadoPor).IsRequired();

                //Departamento foreignkey
                entity.HasMany<Departamento>(x => x.DepartamentosC).WithOne(u => u.UsuarioC)
                        .HasForeignKey(u => u.CreadoPor).IsRequired();

                entity.HasMany(x => x.DepartamentosM).WithOne(u => u.UsuarioM)
                .HasForeignKey(u => u.ModificadoPor).OnDelete(DeleteBehavior.Cascade).IsRequired();

                //Puesto foreignkey
                entity.HasMany<Puesto>(u => u.PuestosC).WithOne(p => p.UsuarioC)
                        .HasForeignKey(u => u.CreadoPor).IsRequired();

                entity.HasMany<Puesto>(u => u.PuestosM).WithOne(p => p.UsuarioM)
                .HasForeignKey(u => u.ModificadoPor).OnDelete(DeleteBehavior.Cascade).IsRequired();

                entity.HasOne<Puesto>(u => u.Puesto).WithMany(p => p.Usuarios)
                        .HasForeignKey(u => u.PuestoID);

                //HistorialIncidentes foreignkey
                entity.HasMany<HistorialIncidente>(x => x.HistorialIncidentesC).WithOne(u => u.UsuarioC)
                        .HasForeignKey(u => u.CreadoPor).IsRequired();

                entity.HasMany<HistorialIncidente>(x => x.HistorialIncidentesM).WithOne(u => u.UsuarioM)
                        .HasForeignKey(u => u.ModificadoPor).OnDelete(DeleteBehavior.Cascade).IsRequired();


                //Incidentes foreignkey
                entity.HasMany<Incidente>(x => x.IncidentesC).WithOne(u => u.UsuarioC)
                        .HasForeignKey(u => u.CreadoPor).IsRequired();

                entity.HasMany<Incidente>(x => x.IncidentesM).WithOne(u => u.UsuarioM)
                        .HasForeignKey(u => u.ModificadoPor).OnDelete(DeleteBehavior.Cascade).IsRequired();

                entity.HasMany<Incidente>(x => x.IncidentesA).WithOne(u => u.UsuarioA)
                      .HasForeignKey(u => u.UsuarioAsignadoId).IsRequired();

                entity.HasMany<Incidente>(x => x.IncidentesR).WithOne(u => u.UsuarioR)
                       .HasForeignKey(u => u.UsuarioReportaId).OnDelete(DeleteBehavior.Cascade); 


                //Sla foreignkey
                entity.HasMany<Sla>(x => x.SlasC).WithOne(u => u.UsuarioC)
                       .HasForeignKey(u => u.CreadoPor).IsRequired();

                entity.HasMany<Sla>(x => x.SlasM).WithOne(u => u.UsuarioM)
                        .HasForeignKey(u => u.ModificadoPor).OnDelete(DeleteBehavior.Cascade).IsRequired();


                //Prioridades foreignkey
                entity.HasMany<Prioridad>(x => x.PrioridadesC).WithOne(u => u.UsuarioC)
                        .HasForeignKey(u => u.CreadoPor).IsRequired();

                entity.HasMany<Prioridad>(x => x.PrioridadesM).WithOne(u => u.UsuarioM)
                        .HasForeignKey(u => u.ModificadoPor).OnDelete(DeleteBehavior.Cascade).IsRequired();

               // Usuario foreignkey
                entity.HasMany<Usuario>(u=>u.IUsuariosC).WithOne(u=>u.UsuarioC)
                .HasForeignKey(u => u.CreadoPor).IsRequired();

                entity.HasMany<Usuario>(u => u.IUsuariosM).WithOne(u => u.UsuarioM)
                .HasForeignKey(u => u.ModificadoPor).OnDelete(DeleteBehavior.Cascade).IsRequired();

            });

            modelBuilder.Entity<Sla>(entity =>
            {
                entity.HasKey(e => e.SlaId);
                entity.Property<int>(e => e.SlaId);
                entity.Property<string>(e => e.Descripcion).HasMaxLength(200).IsRequired();
                entity.Property<int>(e => e.CantdadHoras).IsRequired();
                entity.Property<string>(e => e.Estatus).HasMaxLength(2).IsRequired();
                entity.Property<bool>(e => e.Borrado).HasDefaultValue(false).IsRequired();
                entity.Property<DateTime>(e => e.FechaRegistro).HasDefaultValue(DateTime.Now);
                entity.Property<DateTime>(e => e.FechaModificacion);
                entity.Property<int>(e => e.CreadoPor).IsRequired();
                entity.Property<int>(e => e.ModificadoPor).IsRequired();

            });

            modelBuilder.Entity<Prioridad>(entity =>
            {
                entity.HasKey(e => e.PrioridadId);
                entity.Property<int>(e => e.PrioridadId);
                entity.Property<int>(e => e.SlaId);
                entity.Property<string>(e => e.Nombre).HasMaxLength(100).IsRequired();
                entity.Property<string>(e => e.Estatus).HasMaxLength(2).IsRequired();
                entity.Property<bool>(e => e.Borrado).HasDefaultValue(false).IsRequired();
                entity.Property<DateTime>(e => e.FechaRegistro).HasDefaultValue(DateTime.Now);
                entity.Property<DateTime>(e => e.FechaModificacion);
                entity.Property<int>(e => e.CreadoPor).IsRequired();
                entity.Property<int>(e => e.ModificadoPor).IsRequired();

                entity.HasOne<Sla>(p => p.Sla).WithMany(d => d.Prioridades).HasForeignKey(p => p.SlaId).OnDelete(DeleteBehavior.Cascade);

            });

            modelBuilder.Entity<Incidente>(entity => 
            {
                entity.HasKey(e => e.IncidenteId);
                entity.Property<int>(e => e.IncidenteId); 
                entity.Property<int>(e => e.PrioridadId);
                entity.Property<int>(e => e.DepartamentoId);
                entity.Property<int>(e => e.UsuarioAsignadoId);
                entity.Property<int>(e => e.UsuarioReportaId);
                entity.Property<string>(e => e.Titulo).HasMaxLength(200).IsRequired();
                entity.Property<string>(e => e.Descripcion).HasColumnType("varchar(max)");
                entity.Property<DateTime>(e => e.FechaCierre);
                entity.Property<string>(e => e.CoemntarioCierrre).HasMaxLength(500);
                entity.Property<string>(e => e.Estatus).HasMaxLength(2).IsRequired();
                entity.Property<bool>(e => e.Borrado).HasDefaultValue(false).IsRequired();
                entity.Property<DateTime>(e => e.FechaRegistro).HasDefaultValue(DateTime.Now);
                entity.Property<DateTime>(e => e.FechaModificacion);
                entity.Property<int>(e => e.CreadoPor).IsRequired();
                entity.Property<int>(e => e.ModificadoPor).IsRequired();

                entity.HasOne<Departamento>(p => p.Departamento).WithMany(d => d.Incidentes).HasForeignKey(p => p.DepartamentoId);
                entity.HasOne<Prioridad>(p => p.Prioridad).WithMany(d => d.Incidentes).HasForeignKey(p => p.PrioridadId);


                entity.HasOne<Usuario>(x => x.UsuarioA).WithMany(u => u.IncidentesA).HasForeignKey(u => u.UsuarioAsignadoId).IsRequired();
                entity.HasOne<Usuario>(x => x.UsuarioR).WithMany(u => u.IncidentesR).HasForeignKey(u => u.UsuarioReportaId).IsRequired().OnDelete(DeleteBehavior.Cascade); ;

            });
        }

    }
}
