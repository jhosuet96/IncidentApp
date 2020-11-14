using IncidentApp.Repository.GenericRepository;
using Microsoft.AspNetCore.Mvc;
using IncidentApp.Model.Model;
using IncidentApp.Model.Dto;
using IncidentApp.Service.Services;
using Microsoft.AspNetCore.Http;

namespace IncidentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlaController : ControllerBase
    {

        private IRepositoryWrapper _repo;
        ServiceSla serviceSla;
        public SlaController(IRepositoryWrapper repo)
        {
            serviceSla = new ServiceSla();
            _repo = repo;
        }

        [HttpGet]
        [Route("GetAllS")]
        public IActionResult GetAll()
        {
            var sla = _repo.sla.GetAll();
            return Ok(sla);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            if (id>0)
            {
                var sla = _repo.sla.GetByID(id);
                return Ok(sla);
            }
            else
            {
                return NotFound(id);
            }
        }

        [HttpPost]
        [Route("AddSla")]
        public IActionResult AddSla(Sla sla)
        {
            _repo.sla.Add(sla);
            _repo.Save();
            return Ok(sla);
        }

        [HttpPatch]
        [Route("UpdateSla")]
        public IActionResult UpdateSla(SlaDto slaDto)
        {
            if (slaDto !=null)
            {
                var isla = serviceSla.MapSlaUpdate(slaDto);
                _repo.sla.Update(isla);
                _repo.Save();
                return Ok(isla);
            }
            else
            {
                return StatusCode(StatusCodes.Status304NotModified);
            }
        }

        [HttpDelete]
        [Route("DeleteSla/slaid/{slaid:int}/iduser/{iduser:int}")]
        public IActionResult DeleteSla(int slaId, int idUser)
        {
            if (slaId > 0)
            {
                var isla = serviceSla.MapSlaDelete(slaId,idUser);
                _repo.sla.Update(isla);
                _repo.Save();
                return Ok(isla);
            }
            else
            {
                return StatusCode(StatusCodes.Status304NotModified);
            }
        }
    }
}
