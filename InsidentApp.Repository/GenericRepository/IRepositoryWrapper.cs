using IncidentApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Repository.GenericRepository
{
    public interface IRepositoryWrapper
    {
        IDepartamentoRepository departamento { get; }
        IHistorialIncidenteRepository historialIncidente { get; }
        IIncidenteRepository incidente { get; }
        IPrioridadRepository prioridad { get; }
        IPuestoRepository puesto { get; }
        ISlaRepository sla { get; }
        IUsuarioRepository usuario { get; }

        void Save();

    }
}
