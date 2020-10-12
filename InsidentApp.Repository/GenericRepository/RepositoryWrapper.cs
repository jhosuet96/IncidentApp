using IncidentApp.Model;
using IncidentApp.Repository.Interface;
using IncidentApp.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Repository.GenericRepository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private IncidentAppContext _repoContext;
        private IDepartamentoRepository _departamento;

        private IHistorialIncidenteRepository _historialIncidente;

        private IIncidenteRepository _incidente;

        private IPrioridadRepository _prioridad;

        private IPuestoRepository _puesto;

        private ISlaRepository _sla;

        private IUsuarioRepository _usuario;

        public IDepartamentoRepository departamento
        {
            get
            {
                if (_departamento == null)
                {
                    _departamento = new DepartamentoRepository(_repoContext);
                }
                return _departamento;
            }
        }

        public IHistorialIncidenteRepository historialIncidente
        {

            get
            {
                if (_historialIncidente == null)
                {
                    _historialIncidente = new HistorialIncidenteRepository(_repoContext);
                }
                return _historialIncidente;
            }
        }

        public IIncidenteRepository incidente
        {
            get
            {
                if (_incidente == null)
                {
                    _incidente = new IncidenteRepository(_repoContext);
                }
                return _incidente;
            }

        }

        public IPrioridadRepository prioridad
        {
            get
            {
                if (_prioridad == null)
                {
                    _prioridad = new PrioridadRepository(_repoContext);
                }
                return _prioridad;
            }

        }
        public IPuestoRepository puesto
        {
            get
            {
                if (_puesto == null)
                {
                    _puesto = new PuestoRepository(_repoContext);
                }
                return _puesto;
            }

        }
        public ISlaRepository sla
        {
            get
            {
                if (_sla == null)
                {
                    _sla = new SlaRepository(_repoContext);
                }
                return _sla;
            }

        }
        public IUsuarioRepository usuario
        {
            get
            {
                if (_usuario == null)
                {
                    _usuario = new UsuarioRepository(_repoContext);
                }
                return _usuario;
            }

        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
