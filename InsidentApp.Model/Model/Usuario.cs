using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Model.Model
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public int PuestoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Estatus { get; set; }
        public bool Borrado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int CreadoPor { get; set; }
        public int ModificadoPor { get; set; }
        public virtual Puesto Puesto { get; set; }
        public virtual Usuario UsuarioC { get; set; }
        public virtual Usuario UsuarioM { get; set; }

        //public virtual Incidente IncidenteA { get; set; }
        //public virtual Incidente IncidenteR { get; set; }

        public ICollection<Departamento> DepartamentosC { get; set; }
        public ICollection<Departamento> DepartamentosM { get; set; }
        public ICollection<Puesto> PuestosC { get; set; }
        public ICollection<Puesto> PuestosM { get; set; }
        public ICollection<HistorialIncidente> HistorialIncidentesC { get; set; }
        public ICollection<HistorialIncidente> HistorialIncidentesM { get; set; }
        public ICollection<Incidente> IncidentesA { get; set; }
        public ICollection<Incidente> IncidentesR { get; set; }
        public ICollection<Incidente> IncidentesM { get; set; }
        public ICollection<Incidente> IncidentesC { get; set; }
        public ICollection<Sla> SlasC { get; set; }
        public ICollection<Sla> SlasM { get; set; }
        public ICollection<Prioridad> PrioridadesC { get; set; }
        public ICollection<Prioridad> PrioridadesM { get; set; }

        public ICollection<Usuario> IUsuariosC { get; set; }
        public ICollection<Usuario> IUsuariosM { get; set; }

    }
}
