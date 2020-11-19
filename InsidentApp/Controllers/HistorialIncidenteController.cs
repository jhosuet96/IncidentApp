using IncidentApp.Model.Dto;
using IncidentApp.Model.Model;
using IncidentApp.Repository.GenericRepository;
using IncidentApp.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncidentApp.Controllers
{
    public class HistorialIncidenteController : Controller
    {
        private IRepositoryWrapper _repo;
        ServiceHistorialIncidente serviceHistorialIncidente;

        public HistorialIncidenteController(IRepositoryWrapper repo)
        {
            _repo = repo;
            serviceHistorialIncidente = new ServiceHistorialIncidente();
        }

        [HttpGet]
        [Route("GetAllH")]
        public IActionResult GetAll()
        {
           var historial = _repo.historialIncidente.GetAll();
            return Ok(historial);
        }


        [HttpGet]
        public IActionResult GetById(int id)
        {
            if (id>0)
            {
                var historial = _repo.historialIncidente.GetByID(id);
                return Ok(historial);
            }
            else
            {
                return NotFound(id);
            }
        }

        [HttpPost]
        [Route("AddHistorialIncidente")]
        public IActionResult AddHistorialIncidente(HistorialIncidente historialIncidente)
        {
            _repo.historialIncidente.Add(historialIncidente);
            _repo.Save();
            return Ok(historialIncidente);
        }


        [HttpPatch]
        [Route("UpdateHistorialIncidente")]
        public IActionResult UpdateHistorialIncidente(HistorialIncidenteDto historialIncidenteDto)
        {
            if (historialIncidenteDto != null)
            {
                var historial = serviceHistorialIncidente.MapHistorialIncidenteUpdate(historialIncidenteDto);
                _repo.historialIncidente.Update(historial);
                _repo.Save();
                return Ok(historial);
            }
            else
            {
                return StatusCode(StatusCodes.Status304NotModified);
            }
        }

        [HttpDelete]
        [Route("DeleteHistorialIncidente/historialincidenteid/{historialincidenteid:int}/iduser/{iduser:int}")]
        public IActionResult DeleteHistorialIncidente(int historialincidenteid, int idUser)
        {
            if (historialincidenteid > 0)
            {
                var historial = serviceHistorialIncidente.MapHistorialIncidenteDelete(historialincidenteid,idUser);
                _repo.historialIncidente.Update(historial);
                _repo.Save();
                return Ok(historial);
            }
            else
            {
                return StatusCode(StatusCodes.Status304NotModified);
            }
        }
    }
}
