using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Model.Model
{
    public class Sla
    {
        public int SlaId { get; set; }
        public string Descripcion { get; set; }
        public int CantdadHoras { get; set; }
        public string Estatus { get; set; }
        public bool Borrado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int CreadoPor { get; set; }
        public int ModificadoPor { get; set; }
        public Usuario UsuarioC { get; set; }

        public Usuario UsuarioM { get; set; }
        public ICollection<Prioridad> Prioridades { get; set; }


    }
}
