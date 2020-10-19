using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

using Microsoft.EntityFrameworkCore.Metadata.Builders;



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
                entity.HasOne(x => x.Usuario).WithOne().HasForeignKey<Departamento>(d => d.CreadoPor)
                .HasForeignKey<Departamento>(d => d.ModificadoPor); 

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
                entity.HasOne(x => x.Departamento).WithOne().HasForeignKey<Puesto>(d => d.CreadoPor)
                .HasForeignKey<Puesto>(d => d.ModificadoPor);
            });
        }

    }
}
