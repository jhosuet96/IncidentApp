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
            _Puesto.FechaRegistro = _Puesto.FechaRegistro;
            _Puesto.CreadoPor = _Puesto.CreadoPor;
            _Puesto.ModificadoPor = puestoDto.ModificadoPor;
            _Puesto.PuestoId = _Puesto.PuestoId;
            return _Puesto;
        }
        public Puesto MapPuestoDelete(int Id, int idUser)
        {
          //_Puesto.Nombre = puestoDto.Nombre;
            _Puesto.DepartamentoId = _Puesto.DepartamentoId;
            _Puesto.Estatus = Convert.ToString(Estatus.Inactivo);
            _Puesto.Borrado = Convert.ToBoolean(Borrar.Borrado);
            _Puesto.FechaModificacion = DateTime.Now;
            _Puesto.FechaRegistro = _Puesto.FechaRegistro;
            _Puesto.CreadoPor = _Puesto.CreadoPor;
            _Puesto.ModificadoPor = idUser;
            _Puesto.PuestoId = Id;
            return _Puesto;
        }
     }
}
