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
            _Sla.FechaRegistro = _Sla.FechaRegistro;
            _Sla.FechaModificacion = DateTime.Now;
            _Sla.CreadoPor = _Sla.CreadoPor;
            _Sla.ModificadoPor = slaDto.ModificadoPor;
            _Sla.SlaId = _Sla.SlaId;
            return _Sla;
        }

        public Sla MapSlaDelete(int slaId, int idUser)
        {
            //_Sla.Descripcion = slaDto.Descripcion;
            //_Sla.CantdadHoras = slaDto.CantdadHoras;
            _Sla.Estatus = Convert.ToString(Estatus.Inactivo);
            _Sla.Borrado = Convert.ToBoolean(Borrar.Borrado);
            _Sla.FechaRegistro = _Sla.FechaRegistro;
            _Sla.FechaModificacion = DateTime.Now;
            _Sla.CreadoPor = _Sla.CreadoPor;
            _Sla.ModificadoPor = idUser;
            _Sla.SlaId = slaId;
            return _Sla;
        }
    }
}
