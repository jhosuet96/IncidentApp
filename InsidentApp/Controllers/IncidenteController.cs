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
    public class IncidenteController : Controller
    {
        private IRepositoryWrapper _repo;
        ServiceIncidente serviceIncidente;

        public IncidenteController(IRepositoryWrapper repo)
        {
            _repo = repo;
            serviceIncidente = new ServiceIncidente();
        }

        [HttpGet]
        [Route("GetAllI")]
        public IActionResult GetAll()
        {
            var incidente = _repo.incidente.GetAll();
            return Ok(incidente);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            if (id>0)
            {
                var incidente = _repo.incidente.GetByID(id);
                return Ok(incidente);
            }
            else
            {
                return NotFound(id);
            }
        }

        [HttpPost]
        [Route("AddIncidente")]
        public IActionResult AddIncidente(Incidente incidente)
        {
            _repo.incidente.Add(incidente);
            _repo.Save();
            return Ok(incidente);
        }


        [HttpPatch]
        [Route("UpdateIncidente")]
        public IActionResult UpdateIncidente(IncidenteDto incidenteDto)
        {
            if (incidenteDto != null)
            {
                var isIncidente = serviceIncidente.MapIncidenteUpdate(incidenteDto);
                _repo.incidente.Update(isIncidente);
                _repo.Save();
                return Ok(isIncidente);
            }
            else
            {
                return StatusCode(StatusCodes.Status304NotModified);
            }
        }

        [HttpDelete]
        [Route("DeleteIncidente/incidenteid/{incidenteid:int}/iduser/{iduser:int}")]
        public IActionResult DeleteIncidente(int incidenteId, int idUser)
        {
            if (incidenteId > 0)
            {
                var isIncidente = serviceIncidente.MapPrioridadDelete(incidenteId, idUser);
                _repo.incidente.Update(isIncidente);
                _repo.Save();
                return Ok(isIncidente);
            }
            else
            {
                return StatusCode(StatusCodes.Status304NotModified);
            }
        }
    }
}
