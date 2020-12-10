using IncidentApp.Model.Dto;
using IncidentApp.Model.Model;
using IncidentApp.Repository.GenericRepository;
using IncidentApp.Service.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
            servicePrioridad = new ServicePrioridad(repo);
        }

        [HttpGet]
        [Route("GetAllPr")]
        //[EnableCors("AllowOrigin")] //Importante 3
        public IActionResult GetAll()
        {
            var prioridad = servicePrioridad.MapPrioridadList();
            return Ok(prioridad);
        }

        [HttpGet]
        [Route("GetById/{id:int}")]
        [EnableCors("AllowOrigin")]
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
        [Route("AddPrioridad")]
        [EnableCors("AllowOrigin")]
        public IActionResult AddPrioridad(PrioridadDto prioridadDto)
        {
            var isprioridad = servicePrioridad.MapPrioridadAdd(prioridadDto);
            _repo.prioridad.Add(isprioridad);
            _repo.Save();
            return Ok(isprioridad);
        }

        [HttpPatch]
        [Route("UpdatePrioridad")]
        [EnableCors("AllowOrigin")]
        public IActionResult UpdatePrioridad([FromBody] PrioridadDto prioridadDto)
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

        [HttpPatch]
        [Route("DeletePrioridad")]
        public IActionResult DeletePrioridad(PrioridadDto prioridadDto)
        {
            if (prioridadDto.PrioridadId > 0)
            {
                var isPrioridad = servicePrioridad.MapPrioridadDelete(prioridadDto);
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
