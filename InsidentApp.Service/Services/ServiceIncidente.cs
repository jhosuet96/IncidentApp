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
    public class ServiceIncidente
    {
        private IRepositoryWrapper _repo;

        Incidente _Incidente;
        public ServiceIncidente(IRepositoryWrapper repo)
        {
            _repo = repo;
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
            _Incidente.FechaRegistro = incidenteDto.FechaRegistro;
            _Incidente.FechaModificacion = DateTime.Now;    
            _Incidente.CreadoPor = incidenteDto.CreadoPor;
            _Incidente.ModificadoPor = incidenteDto.ModificadoPor;
            _Incidente.IncidenteId = incidenteDto.IncidenteId;

            return _Incidente;
        }

        public Incidente MapPrioridadDelete(IncidenteDto incidenteDto)
        {
            _Incidente.UsuarioReportaId = incidenteDto.UsuarioReportaId;
            _Incidente.UsuarioAsignadoId = incidenteDto.UsuarioAsignadoId;
            _Incidente.PrioridadId = incidenteDto.PrioridadId;
            _Incidente.DepartamentoId = incidenteDto.DepartamentoId;
            _Incidente.Titulo = incidenteDto.Titulo;
            _Incidente.Descripcion = incidenteDto.Descripcion;
            _Incidente.FechaCierre = incidenteDto.FechaCierre;
            _Incidente.CoemntarioCierrre = incidenteDto.CoemntarioCierrre;
            _Incidente.Estatus = "I";
            _Incidente.Borrado = incidenteDto.Borrado;
            _Incidente.FechaRegistro = incidenteDto.FechaRegistro;
            _Incidente.FechaModificacion = DateTime.Now;
            _Incidente.CreadoPor = incidenteDto.CreadoPor;
            _Incidente.ModificadoPor = incidenteDto.ModificadoPor;
            _Incidente.IncidenteId = incidenteDto.IncidenteId;
            return _Incidente;
        }

        public Incidente MapPrioridadAdd(IncidenteDto incidenteDto)
        {
            _Incidente.UsuarioAsignadoId = incidenteDto.UsuarioAsignadoId;
            _Incidente.UsuarioReportaId = incidenteDto.UsuarioAsignadoId;
            _Incidente.PrioridadId = incidenteDto.PrioridadId;
            _Incidente.DepartamentoId = incidenteDto.DepartamentoId;
            _Incidente.Titulo = incidenteDto.Titulo;
            _Incidente.Descripcion = incidenteDto.Descripcion;
            _Incidente.FechaCierre = incidenteDto.FechaCierre;
            _Incidente.CoemntarioCierrre = incidenteDto.CoemntarioCierrre;
            _Incidente.Estatus = incidenteDto.Estatus;
            _Incidente.Borrado = incidenteDto.Borrado;
            _Incidente.FechaRegistro = incidenteDto.FechaRegistro;
            _Incidente.FechaModificacion = DateTime.Now;
            _Incidente.CreadoPor = incidenteDto.CreadoPor;
            _Incidente.ModificadoPor = incidenteDto.CreadoPor;
          //  _Incidente.IncidenteId = incidenteDto.IncidenteId;
            return _Incidente;
        }


        public List<Incidente> MapIncidentesList()
        {
            return _repo.incidente.GetAll()
                              .Where(inc => inc.Borrado == false &&
                                     inc.Estatus =="A")
                              .Select(_Incidente => new Incidente
                              {
                                  IncidenteId = _Incidente.IncidenteId,
                                  UsuarioReportaId = _Incidente.UsuarioReportaId,
                                  UsuarioAsignadoId = _Incidente.UsuarioAsignadoId,
                                  PrioridadId = _Incidente.PrioridadId,
                                  DepartamentoId = _Incidente.DepartamentoId,
                                  Titulo = _Incidente.Titulo,
                                  Descripcion = _Incidente.Descripcion,
                                  FechaCierre = _Incidente.FechaCierre,
                                  CoemntarioCierrre = _Incidente.CoemntarioCierrre,
                                  Estatus = _Incidente.Estatus,
                                  Borrado = _Incidente.Borrado,
                                  FechaRegistro = _Incidente.FechaRegistro,
                                  FechaModificacion = _Incidente.FechaModificacion,
                                  CreadoPor = _Incidente.CreadoPor,
                                  ModificadoPor = _Incidente.ModificadoPor,
                                  Prioridad = new Prioridad
                                  {
                                      PrioridadId = _Incidente.Prioridad.PrioridadId,
                                      SlaId = _Incidente.Prioridad.SlaId,
                                      Nombre = _Incidente.Prioridad.Nombre,
                                      Estatus = _Incidente.Prioridad.Estatus,
                                      Borrado = _Incidente.Prioridad.Borrado,
                                      FechaRegistro = _Incidente.Prioridad.FechaRegistro,
                                      FechaModificacion = _Incidente.Prioridad.FechaModificacion,
                                      CreadoPor = _Incidente.Prioridad.CreadoPor,
                                      ModificadoPor = _Incidente.Prioridad.ModificadoPor,
                                  },
                                  Departamento = new Departamento
                                  {
                                      DepartamentoId = _Incidente.Departamento.DepartamentoId,
                                      Nombre = _Incidente.Departamento.Nombre,
                                      Borrado = _Incidente.Departamento.Borrado,
                                      Estatus = _Incidente.Departamento.Estatus,
                                      FechaRegistro = _Incidente.Departamento.FechaRegistro.ToLocalTime(),
                                      FechaModificacion = _Incidente.Departamento.FechaModificacion.ToLocalTime(),
                                  },

                                  UsuarioC = new Usuario
                                  {
                                      UsuarioId = _Incidente.UsuarioC.CreadoPor,
                                      Nombre = _Incidente.UsuarioC.Nombre
                                  },

                                  UsuarioM = new Usuario
                                  {
                                      UsuarioId = _Incidente.UsuarioM.ModificadoPor,
                                      Nombre = _Incidente.UsuarioM.Nombre
                                  }
                              }).ToList();
        }



    }

}
