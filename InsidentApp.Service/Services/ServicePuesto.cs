using IncidentApp.Model.Dto;
using IncidentApp.Model.Enum;
using IncidentApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Service
{
     public  class ServicePuesto
    {
        Puesto _Puesto;
        public ServicePuesto()
        {
            _Puesto = new Puesto();
        }
        public Puesto MapPuestoUpdate(PuestoDto puestoDto)
        {
            _Puesto.Nombre = puestoDto.Nombre;
            _Puesto.DepartamentoId = puestoDto.DepartamentoId;
            _Puesto.Estatus = puestoDto.Estatus;
            _Puesto.Borrado = puestoDto.Borrado;
            _Puesto.FechaModificacion= DateTime.Now;
            _Puesto.FechaRegistro = puestoDto.FechaRegistro;
            _Puesto.CreadoPor = puestoDto.CreadoPor;
            _Puesto.ModificadoPor = puestoDto.ModificadoPor;
            _Puesto.PuestoId = puestoDto.PuestoId;
            return _Puesto;
        }
        public Puesto MapPuestoDelete(PuestoDto puestoDto)
        {
            _Puesto.Nombre = puestoDto.Nombre;
            _Puesto.DepartamentoId = puestoDto.DepartamentoId;
            _Puesto.Estatus = "I";
            _Puesto.Borrado = Convert.ToBoolean(Borrar.Borrado);
            _Puesto.FechaModificacion = DateTime.Now;
            _Puesto.FechaRegistro = puestoDto.FechaRegistro;
            _Puesto.CreadoPor = puestoDto.CreadoPor;
            _Puesto.ModificadoPor = puestoDto.ModificadoPor;
            _Puesto.PuestoId = puestoDto.PuestoId;
            return _Puesto;
        }

        public Puesto MapPuestoAdd(PuestoDto puestoDto)
        {
            _Puesto.Nombre = puestoDto.Nombre;
            _Puesto.DepartamentoId = puestoDto.DepartamentoId;
            _Puesto.Estatus = puestoDto.Estatus;
            _Puesto.Borrado = puestoDto.Borrado;
            _Puesto.FechaModificacion = DateTime.Now;
            _Puesto.FechaRegistro = puestoDto.FechaRegistro;
            _Puesto.CreadoPor = puestoDto.CreadoPor;
            _Puesto.ModificadoPor = puestoDto.CreadoPor;
           // _Puesto.PuestoId = _Puesto.PuestoId;
            return _Puesto;
        }
    }
}
