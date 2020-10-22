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
        //public virtual Usuario User { get; set; }
        public virtual Puesto Puesto { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }

       //public ICollection<Puesto> Puestos { get; set; }

    }
}
