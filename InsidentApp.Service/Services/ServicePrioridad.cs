using IncidentApp.Model.Dto;
using IncidentApp.Model.Enum;
using IncidentApp.Model.Model;
using IncidentApp.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IncidentApp.Service.Services
{
    public class ServicePrioridad
    {
        private IRepositoryWrapper _repo;

        Prioridad _Prioridad;
        public ServicePrioridad(IRepositoryWrapper repo)
        {
            _repo = repo;
            _Prioridad = new Prioridad();
        }

        public Prioridad MapPrioridadUpdate(PrioridadDto prioridadDto)
        {
            _Prioridad.SlaId = prioridadDto.SlaId;
            _Prioridad.Nombre = prioridadDto.Nombre;
            _Prioridad.Estatus = prioridadDto.Estatus;
            _Prioridad.Borrado = prioridadDto.Borrado;
            _Prioridad.FechaRegistro = prioridadDto.FechaRegistro;
            _Prioridad.FechaModificacion = DateTime.Now;
            _Prioridad.CreadoPor = prioridadDto.CreadoPor;
            _Prioridad.ModificadoPor = prioridadDto.ModificadoPor;
            _Prioridad.PrioridadId = prioridadDto.PrioridadId;
            return _Prioridad;
        }

        public Prioridad MapPrioridadDelete(PrioridadDto prioridadDto)
        {
            _Prioridad.SlaId = prioridadDto.SlaId;
            _Prioridad.Nombre = prioridadDto.Nombre;
            _Prioridad.Estatus = "I";
            _Prioridad.Borrado = Convert.ToBoolean(Borrar.Borrado);
            _Prioridad.FechaRegistro = prioridadDto.FechaRegistro;
            _Prioridad.FechaModificacion = DateTime.Now;
            _Prioridad.CreadoPor = prioridadDto.CreadoPor;
            _Prioridad.ModificadoPor = prioridadDto.ModificadoPor;
            _Prioridad.PrioridadId = prioridadDto.PrioridadId;
            return _Prioridad;
        }

        public Prioridad MapPrioridadAdd(PrioridadDto prioridadDto)
        {
            _Prioridad.SlaId = prioridadDto.SlaId;
            _Prioridad.Nombre = prioridadDto.Nombre;
            _Prioridad.Estatus = prioridadDto.Estatus;
            _Prioridad.Borrado = prioridadDto.Borrado;
            _Prioridad.FechaRegistro = prioridadDto.FechaRegistro;
            _Prioridad.FechaModificacion = DateTime.Now;
            _Prioridad.CreadoPor = prioridadDto.CreadoPor;
            _Prioridad.ModificadoPor = prioridadDto.CreadoPor;
            //  _Prioridad.PrioridadId = prioridadDto.PrioridadId;
            return _Prioridad;
        }

        public List<Prioridad> MapPrioridadList()        {            return _repo.prioridad.GetAll()                              .Where(_Prioridad => _Prioridad.Borrado == false &&                                     _Prioridad.Estatus == "A")                              .Select(p => new Prioridad                              {                                  PrioridadId = p.PrioridadId,                                  SlaId = p.SlaId,                                  Nombre = p.Nombre,                                  Estatus = p.Estatus,                                  Borrado = p.Borrado,                                  FechaRegistro = p.FechaRegistro,                                  FechaModificacion = p.FechaModificacion,                                  CreadoPor = p.CreadoPor,                                  ModificadoPor = p.ModificadoPor,

                                  Sla = new Sla                                  {                                      SlaId = p.SlaId,                                      Descripcion = p.Sla.Descripcion,                                      CantdadHoras = p.Sla.CantdadHoras,                                      Estatus = p.Sla.Estatus,                                      Borrado = p.Sla.Borrado,                                      FechaRegistro = p.Sla.FechaRegistro,                                      FechaModificacion = p.Sla.FechaModificacion,                                      CreadoPor = p.Sla.CreadoPor,                                      ModificadoPor = p.Sla.ModificadoPor                                  },

                                  UsuarioC = new Usuario
                                  {
                                      UsuarioId = p.UsuarioC.CreadoPor,
                                      Nombre = p.UsuarioC.Nombre
                                  },

                                  UsuarioM = new Usuario
                                  {
                                      UsuarioId = p.UsuarioM.ModificadoPor,
                                      Nombre = p.UsuarioM.Nombre
                                  },
                              }).ToList();
        }
    }
}
