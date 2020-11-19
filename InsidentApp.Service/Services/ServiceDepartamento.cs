using IncidentApp.Model.Dto;
using IncidentApp.Model.Enum;
using IncidentApp.Model.Model;
using System;

namespace IncidentApp.Service
{
    public class ServiceDepartamento
    {
        Departamento _Departamento;

        public ServiceDepartamento()
        {
            _Departamento = new Departamento();
        }
        public Departamento MapDepartamentoUpdate(DepartamentoDto departamentoDto)
        {
            _Departamento.Nombre = departamentoDto.Nombre;
            _Departamento.Estatus = departamentoDto.Estatus;
            _Departamento.Borrado = departamentoDto.Borrado;
            _Departamento.FechaRegistro = _Departamento.FechaRegistro;
            _Departamento.FechaModificacion = DateTime.Now;
            _Departamento.CreadoPor = _Departamento.CreadoPor;
            _Departamento.ModificadoPor = departamentoDto.ModificadoPor;
            _Departamento.DepartamentoId = _Departamento.DepartamentoId;
            return _Departamento;
        }

        public Departamento MapDepartamentoDelete(int Id,int idUser)
        {
          //_Departamento.Nombre = _Departamento.Nombre;
            _Departamento.Estatus = Convert.ToString(Estatus.Inactivo);
            _Departamento.Borrado = Convert.ToBoolean(Borrar.Borrado);
            _Departamento.FechaRegistro = _Departamento.FechaRegistro;
            _Departamento.FechaModificacion = DateTime.Now;
            _Departamento.CreadoPor = _Departamento.CreadoPor;        
            _Departamento.ModificadoPor = idUser;
            _Departamento.DepartamentoId = Id;
            return _Departamento;
        }

    }
}
