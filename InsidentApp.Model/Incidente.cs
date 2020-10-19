using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Model
{
    public class Incidente
    {
        public int IncidenteId { get; set; }
        public int UsuarioReportaId { get; set; }
        public int UsuarioAsignadoId { get; set; }
        public int PrioridadId { get; set; }
        public int DepartamentoId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCierre { get; set; }
        public string CoemntarioCierrre { get; set; }
        public string Estatus { get; set; }
        public bool Borrado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int CreadoPor { get; set; }
        public int ModificadoPor { get; set; }
        public virtual Prioridad Prioridad  { get; set; }
        public virtual Departamento Departamento  { get; set; }
        public virtual Usuario Usuario  { get; set; }

    }
}
