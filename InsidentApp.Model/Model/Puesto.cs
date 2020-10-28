using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Model.Model
{
    public class Puesto
    {
        public int PuestoId { get; set; }
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }
        public string Estatus { get; set; }
        public bool Borrado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int CreadoPor { get; set; }
        public int ModificadoPor { get; set; }
        public Usuario Usuario { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }

        public virtual Departamento Departamento { get; set; }
        public Usuario UsuarioC { get; set; }

        public Usuario UsuarioM { get; set; }

    }
}
