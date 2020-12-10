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
            _Departamento.FechaRegistro = departamentoDto.FechaRegistro;
            _Departamento.FechaModificacion = DateTime.Now;
            _Departamento.CreadoPor = departamentoDto.CreadoPor;
            _Departamento.ModificadoPor = departamentoDto.ModificadoPor;
            _Departamento.DepartamentoId = departamentoDto.DepartamentoId;
            return _Departamento;
        }

        public Departamento MapDepartamentoDelete(DepartamentoDto departamentoDto)
        {
            _Departamento.Nombre = departamentoDto.Nombre;
            _Departamento.Estatus = "I";
            _Departamento.Borrado = Convert.ToBoolean(Borrar.Borrado);
            _Departamento.FechaRegistro = departamentoDto.FechaRegistro;
            _Departamento.FechaModificacion = DateTime.Now;
            _Departamento.CreadoPor = departamentoDto.CreadoPor;        
            _Departamento.ModificadoPor = departamentoDto.ModificadoPor;
            _Departamento.DepartamentoId = departamentoDto.DepartamentoId;
            return _Departamento;
        }

        public Departamento MapDepartamentoAdd(DepartamentoDto departamentoDto)
        {
            _Departamento.Nombre = departamentoDto.Nombre;
            _Departamento.Estatus = departamentoDto.Estatus;
            _Departamento.Borrado = departamentoDto.Borrado;
            _Departamento.FechaRegistro = departamentoDto.FechaRegistro;
            _Departamento.FechaModificacion = DateTime.Now;
            _Departamento.CreadoPor = departamentoDto.CreadoPor;
            _Departamento.ModificadoPor = departamentoDto.CreadoPor;
            //  _Departamento.DepartamentoId = departamentoDto.DepartamentoId;
            return _Departamento;

        }

        //public class CountriesMapper : Profile
        //{
        //    public CountriesMapper()
        //    {
        //        CreateMap<Countries, CountriesDTO>().ReverseMap();
        //    }
        //}

    }
}
