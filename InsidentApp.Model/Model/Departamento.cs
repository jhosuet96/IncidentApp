using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Model.Model
{
   public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }
        public string Estatus { get; set; }
        public bool Borrado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int CreadoPor { get; set; }
        public int ModificadoPor { get; set; }

        public ICollection<Puesto> Puestos { get; set; }
        public ICollection<Incidente> Incidentes { get; set; }

        public Usuario UsuarioC { get; set; }

        public Usuario UsuarioM { get; set; }

    }
}
