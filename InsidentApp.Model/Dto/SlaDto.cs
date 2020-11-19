using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Model.Dto
{
    public class SlaDto
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
    }
}
