using IncidentApp.Model.Dto;
using IncidentApp.Model.Enum;
using IncidentApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentApp.Service.Services
{
    public class ServiceHistorialIncidente
    {
        HistorialIncidente _HistorialIncidente;
        public ServiceHistorialIncidente()
        {
            _HistorialIncidente = new HistorialIncidente();
        }
        public HistorialIncidente MapHistorialIncidenteUpdate(HistorialIncidenteDto historialIncidenteDto)
        {
            _HistorialIncidente.IncidenteId = historialIncidenteDto.IncidenteId;
            _HistorialIncidente.Comentario = historialIncidenteDto.Comentario;
            _HistorialIncidente.Estatus = historialIncidenteDto.Estatus;
            _HistorialIncidente.Borrado = historialIncidenteDto.Borrado;
            _HistorialIncidente.FechaRegistro = _HistorialIncidente.FechaRegistro;
            _HistorialIncidente.FechaModificacion = DateTime.Now;
            _HistorialIncidente.CreadoPor = _HistorialIncidente.CreadoPor;
            _HistorialIncidente.ModificadoPor = historialIncidenteDto.ModificadoPor;
            _HistorialIncidente.HistorialIncidenteId = historialIncidenteDto.HistorialIncidenteId;

            return _HistorialIncidente;
        }
        public HistorialIncidente MapHistorialIncidenteDelete(int historialIncidenteId, int idUser)
        {
            //_HistorialIncidente.IncidenteId = historialIncidenteDto.IncidenteId;
            //_HistorialIncidente.Comentario = historialIncidenteDto.Comentario;
            _HistorialIncidente.Estatus = Convert.ToString(Estatus.Inactivo);
            _HistorialIncidente.Borrado = Convert.ToBoolean(Borrar.Borrado);
            _HistorialIncidente.FechaRegistro = _HistorialIncidente.FechaRegistro;
            _HistorialIncidente.FechaModificacion = DateTime.Now;
            _HistorialIncidente.CreadoPor = _HistorialIncidente.CreadoPor;
            _HistorialIncidente.ModificadoPor = idUser;
            _HistorialIncidente.HistorialIncidenteId = historialIncidenteId;

            return _HistorialIncidente;
        }
    }
}
