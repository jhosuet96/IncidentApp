﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Model.Model
{
    public class Prioridad
    {
        public int PrioridadId  { get; set; }
        public int SlaId { get; set; }
        public string Nombre { get; set; }
        public string Estatus { get; set; }
        public bool Borrado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int CreadoPor { get; set; }
        public int ModificadoPor { get; set; }
        public virtual Sla Sla { get; set; }
    }
}
