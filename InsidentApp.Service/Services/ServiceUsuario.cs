using IncidentApp.Model.Dto;
using IncidentApp.Model.Enum;
using IncidentApp.Model.Model;
using IncidentApp.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IncidentApp.Service
{
   public class ServiceUsuario
    {
        private IRepositoryWrapper _repo;

        Usuario _Usuario;
        public ServiceUsuario(IRepositoryWrapper repo)
        {
            _repo = repo;
            _Usuario = new Usuario();
        }
        public Usuario MapUsuarioUpdate(UsuarioDto usuarioDto)
        {
            _Usuario.Nombre = usuarioDto.Nombre;
            _Usuario.PuestoID = usuarioDto.PuestoID;
            _Usuario.Apellido = usuarioDto.Apellido;
            _Usuario.Cedula = usuarioDto.Cedula;
            _Usuario.Correo = usuarioDto.Correo;
            _Usuario.Telefono = usuarioDto.Telefono;
            _Usuario.FechaNacimiento = usuarioDto.FechaNacimiento;
            _Usuario.NombreUsuario = usuarioDto.NombreUsuario;
            _Usuario.Contrasena = usuarioDto.Contrasena;
            _Usuario.Estatus = usuarioDto.Estatus;
            _Usuario.Borrado = usuarioDto.Borrado;
            _Usuario.FechaModificacion = DateTime.Now;
            _Usuario.FechaRegistro = usuarioDto.FechaRegistro;
            _Usuario.CreadoPor = usuarioDto.CreadoPor;
            _Usuario.ModificadoPor = usuarioDto.ModificadoPor;
            _Usuario.UsuarioId = usuarioDto.UsuarioId;
            return _Usuario;
        }

        public Usuario MapUsuarioDelete(UsuarioDto usuarioDto)
        {
            _Usuario.Nombre = usuarioDto.Nombre;
            _Usuario.Apellido = usuarioDto.Apellido;
            _Usuario.Cedula = usuarioDto.Cedula;
            _Usuario.Correo = usuarioDto.Correo;
            _Usuario.Telefono = usuarioDto.Telefono;
            _Usuario.FechaNacimiento = usuarioDto.FechaNacimiento;
            _Usuario.NombreUsuario = usuarioDto.NombreUsuario;
            _Usuario.Contrasena = usuarioDto.Contrasena;
            _Usuario.PuestoID = usuarioDto.PuestoID;
            _Usuario.Estatus = "I";
            _Usuario.Borrado = usuarioDto.Borrado;
            _Usuario.FechaModificacion = DateTime.Now;
            _Usuario.FechaRegistro = usuarioDto.FechaRegistro;
            _Usuario.CreadoPor = usuarioDto.CreadoPor;
            _Usuario.ModificadoPor = usuarioDto.ModificadoPor;
            _Usuario.UsuarioId = usuarioDto.UsuarioId;
            return _Usuario;
        }


        public Usuario MapUsuarioAdd(UsuarioDto usuarioDto)
        {
            _Usuario.Nombre = usuarioDto.Nombre;
            _Usuario.Apellido = usuarioDto.Apellido;
            _Usuario.Cedula = usuarioDto.Cedula;
            _Usuario.Correo = usuarioDto.Correo;
            _Usuario.Telefono = usuarioDto.Telefono;
            _Usuario.FechaNacimiento = usuarioDto.FechaNacimiento;
            _Usuario.NombreUsuario = usuarioDto.NombreUsuario;
            _Usuario.Contrasena = usuarioDto.Contrasena;
            _Usuario.PuestoID = usuarioDto.PuestoID;
            _Usuario.Estatus = "I";
            _Usuario.Borrado = usuarioDto.Borrado;
            _Usuario.FechaModificacion = DateTime.Now;
            _Usuario.FechaRegistro = usuarioDto.FechaRegistro;
            _Usuario.CreadoPor = usuarioDto.CreadoPor;
            _Usuario.ModificadoPor = usuarioDto.CreadoPor;
           // _Usuario.UsuarioId = usuarioDto.UsuarioId;
            return _Usuario;
        }

        public List<Usuario> MapUsuarioList()
        {
            return _repo.usuario.GetAll()
                              .Where(_Usuario => _Usuario.Borrado == false &&
                                     _Usuario.Estatus =="A")
                              .Select(_Usuario => new Usuario
                              {
                                  UsuarioId = _Usuario.UsuarioId,
                                  PuestoID = _Usuario.PuestoID,
                                  Nombre = _Usuario.Nombre,
                                  Apellido = _Usuario.Apellido,
                                  Cedula = _Usuario.Cedula,
                                  Correo = _Usuario.Correo,
                                  Telefono = _Usuario.Telefono,
                                  FechaNacimiento = _Usuario.FechaNacimiento,
                                  NombreUsuario = _Usuario.NombreUsuario,
                                  Contrasena = _Usuario.Contrasena,
                                  Estatus = _Usuario.Estatus,
                                  Borrado = _Usuario.Borrado,
                                  FechaRegistro = _Usuario.FechaRegistro,
                                  FechaModificacion = _Usuario.FechaModificacion,
                                  CreadoPor = _Usuario.CreadoPor,
                                  ModificadoPor = _Usuario.ModificadoPor,
                                  Puesto = new Puesto
                                  {
                                      PuestoId = _Usuario.Puesto.PuestoId,
                                      DepartamentoId = _Usuario.Puesto.DepartamentoId,
                                      Nombre = _Usuario.Puesto.Nombre,
                                      Estatus = _Usuario.Puesto.Estatus,
                                      Borrado = _Usuario.Puesto.Borrado,
                                      FechaRegistro = _Usuario.Puesto.FechaRegistro,
                                      FechaModificacion = _Usuario.Puesto.FechaModificacion,
                                      CreadoPor = _Usuario.Puesto.CreadoPor,
                                      ModificadoPor = _Usuario.Puesto.ModificadoPor,

                                      Departamento = new Departamento
                                      {
                                          DepartamentoId = _Usuario.Puesto.Departamento.DepartamentoId,
                                          Nombre = _Usuario.Puesto.Departamento.Nombre,
                                          Borrado = _Usuario.Puesto.Departamento.Borrado,
                                          Estatus = _Usuario.Puesto.Departamento.Estatus,
                                          FechaRegistro = _Usuario.Puesto.Departamento.FechaRegistro.ToUniversalTime(),
                                          FechaModificacion = _Usuario.Puesto.Departamento.FechaModificacion.ToUniversalTime(),
                                      }
                                  },

                                    UsuarioC = new Usuario
                                    {
                                        UsuarioId = _Usuario.UsuarioC.CreadoPor,
                                        Nombre = _Usuario.UsuarioC.Nombre
                                    },

                                  UsuarioM = new Usuario
                                  {
                                      UsuarioId = _Usuario.UsuarioM.ModificadoPor,
                                      Nombre = _Usuario.UsuarioM.Nombre
                                  }
                              }).ToList();
        }
    }
}
