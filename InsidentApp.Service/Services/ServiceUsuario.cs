using IncidentApp.Model.Dto;
using IncidentApp.Model.Enum;
using IncidentApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Service
{
   public class ServiceUsuario
    {
        Usuario _Usuario;
        public ServiceUsuario()
        {
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
            _Usuario.Contraseña = usuarioDto.Contraseña;
            _Usuario.Estatus = usuarioDto.Estatus;
            _Usuario.Borrado = usuarioDto.Borrado;
            _Usuario.FechaModificacion = DateTime.Now;
            _Usuario.FechaRegistro = _Usuario.FechaRegistro;
            _Usuario.CreadoPor = _Usuario.CreadoPor;
            _Usuario.ModificadoPor = usuarioDto.ModificadoPor;
            _Usuario.UsuarioId = _Usuario.UsuarioId;
            return _Usuario;
        }

        public Usuario MapUsuarioDelete(int id, int idUser)
        {
            //_Usuario.Nombre = usuarioDto.Nombre;
            //_Usuario.Apellido = usuarioDto.Apellido;
            // _Usuario.Cedula = usuarioDto.Cedula;
            // _Usuario.Correo = usuarioDto.Correo;
            // _Usuario.Telefono = usuarioDto.Telefono;
            // _Usuario.FechaNacimiento = usuarioDto.FechaNacimiento;
            // _Usuario.NombreUsuario = usuarioDto.NombreUsuario;
            // _Usuario.Contraseña = usuarioDto.Contraseña;
            _Usuario.PuestoID = _Usuario.PuestoID;
            _Usuario.Estatus = Convert.ToString(Estatus.Inactivo);
            _Usuario.Borrado = Convert.ToBoolean(Borrar.Borrado);
            _Usuario.FechaModificacion = DateTime.Now;
            _Usuario.FechaRegistro = _Usuario.FechaRegistro;
            _Usuario.CreadoPor = _Usuario.CreadoPor;
            _Usuario.ModificadoPor = idUser;
            _Usuario.UsuarioId = id;
            return _Usuario;
        }
    }
}
