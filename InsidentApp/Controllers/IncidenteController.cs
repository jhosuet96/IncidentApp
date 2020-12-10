using IncidentApp.Model.Dto;
using IncidentApp.Model.Model;
using IncidentApp.Repository.GenericRepository;
using IncidentApp.Service.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
//using System.Web.Http;

namespace IncidentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidenteController : ControllerBase
    {
        private IRepositoryWrapper _repo;
        ServiceIncidente serviceIncidente;

        public IncidenteController(IRepositoryWrapper repo)
        {
            _repo = repo;
            serviceIncidente = new ServiceIncidente(repo);
        }

        [HttpGet]
        [Route("GetAllIn")]
        [EnableCors("AllowOrigin")]
        public IActionResult GetAll()
        {
            var incidente = serviceIncidente.MapIncidentesList(); ;
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
        [EnableCors("AllowOrigin")]
        public IActionResult AddIncidente(IncidenteDto incidenteDto)
        {
            var isincidente = serviceIncidente.MapPrioridadAdd(incidenteDto);
            _repo.incidente.Add(isincidente);
            _repo.Save();
            return Ok(isincidente);
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

        [HttpPatch]
        [Route("DeleteIncidente")]
        public IActionResult DeleteIncidente(IncidenteDto incidenteDto)
        {
            if (incidenteDto.IncidenteId > 0)
            {
                var isIncidente = serviceIncidente.MapPrioridadDelete(incidenteDto);
                _repo.incidente.Update(isIncidente);
                _repo.Save();
                return Ok(isIncidente);
            }
            else
            {
                return StatusCode(StatusCodes.Status304NotModified);
            }
        }

        [Route("FillDropDownPrioridad")]
        [HttpGet]
        public IActionResult FillDropDownPrioridad()
        {
            var prioridad = _repo.prioridad.GetAll().Select(p => new { p.PrioridadId, p.Nombre });
            return Ok(prioridad);
        }
        [Route("FillDropDownDepartamento")]
        [HttpGet]
        public IActionResult FillDropDownDepartamento()
        {
            var departamento = _repo.departamento.GetAll().Select(d => new { d.DepartamentoId, d.Nombre });
            return Ok(departamento);
        }
        [Route("FillDropDownUsuario")]
        [HttpGet]
        public IActionResult FillDropDownUsuario()
        {
            var usuario = _repo.usuario.GetAll().Select(d => new { d.UsuarioId, d.NombreUsuario });
            return Ok(usuario);
        }

    }
}
