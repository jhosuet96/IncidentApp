using System;

namespace IncidentApp.Model.Dto
{
    public class HistorialIncidenteDto
    {
        public int HistorialIncidenteId { get; set; }
        public int IncidenteId { get; set; }
        public string Comentario { get; set; }
        public string Estatus { get; set; }
        public bool Borrado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int CreadoPor { get; set; }
        public int ModificadoPor { get; set; }
    }
}
