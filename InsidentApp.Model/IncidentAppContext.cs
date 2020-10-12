using System;
using System.Collections.Generic;
using System.Text;
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
        public DbSet<HistorialIncidente> HistorialIncidente { get; set; }
        public DbSet<Incidente> Incidente { get; set; }

    }
}
