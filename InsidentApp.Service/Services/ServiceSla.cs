using IncidentApp.Model.Dto;
using IncidentApp.Model.Enum;
using IncidentApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Service.Services
{
    public class ServiceSla
    {
        Sla _Sla;
        public ServiceSla()
        {
            _Sla = new Sla();
        }

        public Sla MapSlaUpdate(SlaDto slaDto)
        {
            _Sla.Descripcion = slaDto.Descripcion;
            _Sla.CantdadHoras = slaDto.CantdadHoras;
            _Sla.Estatus = slaDto.Estatus;
            _Sla.Borrado = slaDto.Borrado;
            _Sla.FechaRegistro = slaDto.FechaRegistro;
            _Sla.FechaModificacion = DateTime.Now;
            _Sla.CreadoPor = slaDto.CreadoPor;
            _Sla.ModificadoPor = slaDto.ModificadoPor;
            _Sla.SlaId = slaDto.SlaId;
            return _Sla;
        }

        public Sla MapSlaDelete(SlaDto slaDto)
        {
            _Sla.Descripcion = slaDto.Descripcion;
            _Sla.CantdadHoras = slaDto.CantdadHoras;
            _Sla.Estatus = "I";
            _Sla.Borrado = Convert.ToBoolean(Borrar.Borrado);
            _Sla.FechaRegistro = slaDto.FechaRegistro;
            _Sla.FechaModificacion = DateTime.Now;
            _Sla.CreadoPor = slaDto.CreadoPor;
            _Sla.ModificadoPor = slaDto.ModificadoPor;
            _Sla.SlaId = slaDto.SlaId;
            return _Sla;
        }

        public Sla MapSlaAdd(SlaDto slaDto)
        {
            _Sla.Descripcion = slaDto.Descripcion;
            _Sla.CantdadHoras = slaDto.CantdadHoras;
            _Sla.Estatus = slaDto.Estatus;
            _Sla.Borrado = slaDto.Borrado;
            _Sla.FechaRegistro = slaDto.FechaRegistro;
            _Sla.FechaModificacion = DateTime.Now;
            _Sla.CreadoPor = slaDto.CreadoPor;
            _Sla.ModificadoPor = slaDto.CreadoPor;
            //_Sla.SlaId = _Sla.SlaId;
            return _Sla;
        }
    }
}
