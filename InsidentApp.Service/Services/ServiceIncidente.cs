using IncidentApp.Model.Dto;
using IncidentApp.Model.Enum;
using IncidentApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Service.Services
{
    public class ServiceIncidente
    {
        Incidente _Incidente;
        public ServiceIncidente()
        {
            _Incidente = new Incidente();
        }

        public Incidente MapIncidenteUpdate(IncidenteDto incidenteDto)
        {
            _Incidente.UsuarioReportaId = incidenteDto.UsuarioReportaId;
            _Incidente.UsuarioAsignadoId = incidenteDto.UsuarioAsignadoId;
            _Incidente.PrioridadId = incidenteDto.PrioridadId;
            _Incidente.DepartamentoId = incidenteDto.DepartamentoId;
            _Incidente.Titulo = incidenteDto.Titulo;
            _Incidente.Descripcion = incidenteDto.Descripcion;
            _Incidente.FechaCierre = incidenteDto.FechaCierre;
            _Incidente.CoemntarioCierrre = incidenteDto.CoemntarioCierrre;
            _Incidente.Estatus = incidenteDto.Estatus;
            _Incidente.Borrado = incidenteDto.Borrado;
            _Incidente.FechaRegistro = _Incidente.FechaRegistro;
            _Incidente.FechaModificacion = DateTime.Now;    
            _Incidente.CreadoPor = _Incidente.CreadoPor;
            _Incidente.ModificadoPor = incidenteDto.ModificadoPor;
            _Incidente.IncidenteId = _Incidente.IncidenteId;

            return _Incidente;
        }

        public Incidente MapPrioridadDelete(int incidenteId, int idUser)
        {
            //_Incidente.UsuarioReportaId = incidenteDto.UsuarioReportaId;
            //_Incidente.UsuarioAsignadoId = incidenteDto.UsuarioAsignadoId;
            //_Incidente.PrioridadId = incidenteDto.PrioridadId;
            //_Incidente.DepartamentoId = incidenteDto.DepartamentoId;
            //_Incidente.Titulo = incidenteDto.Titulo;
            //_Incidente.Descripcion = incidenteDto.Descripcion;
            //_Incidente.FechaCierre = incidenteDto.FechaCierre;
            //_Incidente.CoemntarioCierrre = incidenteDto.CoemntarioCierrre;
            _Incidente.Estatus = Convert.ToString(Estatus.Inactivo);
            _Incidente.Borrado = Convert.ToBoolean(Borrar.Borrado);
            _Incidente.FechaRegistro = _Incidente.FechaRegistro;
            _Incidente.FechaModificacion = DateTime.Now;
            _Incidente.CreadoPor = _Incidente.CreadoPor;
            _Incidente.ModificadoPor = idUser;
            _Incidente.IncidenteId = incidenteId;
            return _Incidente;
        }
    }
}
