using IncidentApp.Model.Dto;
using IncidentApp.Model.Enum;
using IncidentApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Service.Services
{
    public class ServicePrioridad
    {
        Prioridad _Prioridad;
        public ServicePrioridad()
        {
            _Prioridad = new Prioridad();
        }

        public Prioridad MapPrioridadUpdate(PrioridadDto prioridadDto)
        {
            _Prioridad.SlaId = prioridadDto.SlaId;
            _Prioridad.Nombre = prioridadDto.Nombre;
            _Prioridad.Estatus = prioridadDto.Estatus;
            _Prioridad.Borrado = prioridadDto.Borrado;
            _Prioridad.FechaRegistro = _Prioridad.FechaRegistro;
            _Prioridad.FechaModificacion = DateTime.Now;
            _Prioridad.CreadoPor = _Prioridad.CreadoPor;
            _Prioridad.ModificadoPor = prioridadDto.ModificadoPor;
            _Prioridad.PrioridadId = _Prioridad.PrioridadId;
            return _Prioridad;
        }

        public Prioridad MapPrioridadDelete(int Id, int idUser)
        {
           // _Prioridad.SlaId = prioridadDto.SlaId;
           // _Prioridad.Nombre = prioridadDto.Nombre;
            _Prioridad.Estatus = Convert.ToString(Estatus.Inactivo);
            _Prioridad.Borrado = Convert.ToBoolean(Borrar.Borrado);
            _Prioridad.FechaRegistro = _Prioridad.FechaRegistro;
            _Prioridad.FechaModificacion = DateTime.Now;
            _Prioridad.CreadoPor = _Prioridad.CreadoPor;
            _Prioridad.ModificadoPor = idUser;
            _Prioridad.PrioridadId = Id;
            return _Prioridad;
        }
    }
}
