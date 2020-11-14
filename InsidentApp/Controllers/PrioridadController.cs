using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IncidentApp.Model.Dto;
using IncidentApp.Model.Model;
using IncidentApp.Repository.GenericRepository;
using IncidentApp.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IncidentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrioridadController : ControllerBase
    {
        private IRepositoryWrapper _repo;
        SlaController slaController;
        ServicePrioridad servicePrioridad;  
        public PrioridadController(IRepositoryWrapper repo)
        {
            _repo = repo;
            slaController = new SlaController(repo);
            servicePrioridad = new ServicePrioridad();
        }

        [HttpGet]
        [Route("GetAllPr")]
        //[EnableCors("AllowOrigin")] //Importante 3
        public IActionResult GetAll()
        {
            var prioridad = _repo.prioridad.GetAll();
            return Ok(prioridad);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            if (id > 0)
            {
                var prioridad = _repo.prioridad.GetByID(id);
                return Ok(prioridad);
            }
            else
            {
                return NotFound(id);
            }
        }

        [HttpPost]
        [Route("AddPriorida")]
        public IActionResult AddPrioridad(Prioridad prioridad)
        {
            _repo.prioridad.Add(prioridad);
            _repo.Save();
            return Ok(prioridad);
        }

        [HttpPatch]
        [Route("UpdatePriorida")]
        public IActionResult UpdatePrioridad(PrioridadDto prioridadDto)
        {
            var isSla = slaController.GetById(prioridadDto.SlaId);
            if (isSla != null)
            {
                if (prioridadDto != null)
                {
                    var isPrioridad = servicePrioridad.MapPrioridadUpdate(prioridadDto);
                    _repo.prioridad.Update(isPrioridad);
                    _repo.Save();
                    return Ok(isPrioridad);
                }
                else
                {
                    return StatusCode(StatusCodes.Status304NotModified);
                }
            }
            else
            {
                return NotFound(prioridadDto);
            }
        }

        [HttpDelete]
        [Route("DeletePrioridad/prioridadid/{prioridadid:int}/iduser/{iduser:int}")]
        public IActionResult DeletePrioridad(int prioridadid, int idUser)
        {
            if (prioridadid > 0)
            {
                var isPrioridad = servicePrioridad.MapPrioridadDelete(prioridadid, idUser);
                _repo.prioridad.Update(isPrioridad);
                _repo.Save();
                return Ok(isPrioridad);
            }
            else
            {
                return StatusCode(StatusCodes.Status304NotModified);
            }
        }

    }
}
