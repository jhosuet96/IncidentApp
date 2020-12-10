using IncidentApp.Repository.GenericRepository;
using Microsoft.AspNetCore.Mvc;
using IncidentApp.Model.Model;
using IncidentApp.Model.Dto;
using IncidentApp.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;
using System.Linq;

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
            var sla = _repo.sla.GetAll().Where(d => d.Borrado == false);
            return Ok(sla);
        }

        [HttpGet]
        [Route("GetById/{id:int}")]
        [EnableCors("AllowOrigin")]
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
        public IActionResult AddSla(SlaDto slaDto)
        {
            var issla = serviceSla.MapSlaAdd(slaDto);
            _repo.sla.Add(issla);
            _repo.Save();
            return Ok(issla);
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
        [Route("DeleteSla")]
        public IActionResult DeleteSla(SlaDto slaDto)
        {
            if (slaDto.SlaId > 0)
            {
                var isla = serviceSla.MapSlaDelete(slaDto);
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
