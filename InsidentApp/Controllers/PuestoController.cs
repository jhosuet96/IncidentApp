using IncidentApp.Model.Dto;
using IncidentApp.Model.Model;
using IncidentApp.Repository.GenericRepository;
using IncidentApp.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IncidentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PuestoController : ControllerBase
    {
        private IRepositoryWrapper _repo;
        //Puesto _Puesto;
        DepartamentoController departamentoController;
        ServicePuesto servicePuesto;
        public PuestoController(IRepositoryWrapper repo)
        {
            _repo = repo;
          //_Puesto = new Puesto();
            servicePuesto = new ServicePuesto();
            departamentoController = new DepartamentoController(repo);
        }

        [HttpGet]
        [Route("GetAllP")]
        //[EnableCors("AllowOrigin")] //Importante 3
        public IActionResult GetAll()
        {
            var puesto = _repo.puesto.GetAll();
            return Ok(puesto);
        }


        [HttpGet]
        public IActionResult GetById(int id)
        {
            if (id > 0)
            {
                var puesto = _repo.puesto.GetByID(id);
                return Ok(puesto);
            }
            else
            {
                return NotFound(id);
            }
        }

        [HttpPost]
        
        public IActionResult AddPuesto(Puesto puesto)
        {
            _repo.puesto.Add(puesto);
            _repo.Save();
            return Ok(puesto);
        }

        [HttpPatch]
        [Route("UpdatePuesto")]
        public IActionResult UpdatePuesto(PuestoDto puestoDto)
        {
            var isvalue = departamentoController.GetById(puestoDto.DepartamentoId);
            if (isvalue != null)
            {
                if (puestoDto != null)
                {
                    var ispuesto = servicePuesto.MapPuestoUpdate(puestoDto);
                    _repo.puesto.Update(ispuesto);
                    _repo.Save();
                    return Ok(ispuesto);
                }
                else
                {
                    return StatusCode(StatusCodes.Status304NotModified);
                }
            }
            else
            {
                return NotFound(puestoDto);
            }           
        }

        [HttpDelete]
        [Route("DeletePuesto/puestoid/{puestoid:int}/usuarioid/{iduser:int}")]
        public IActionResult DeletePuesto(int puestoId, int idUser)
        {
            if (puestoId > 0)
            {
                var ispuesto = servicePuesto.MapPuestoDelete(puestoId, idUser);
                _repo.puesto.Update(ispuesto);
                _repo.Save();
                return Ok(ispuesto);
            }
            else
            {
                return StatusCode(StatusCodes.Status304NotModified);
            }
        }
    }
}
