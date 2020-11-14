using IncidentApp.Model.Dto;
using IncidentApp.Model.Model;
using IncidentApp.Repository.GenericRepository;
using IncidentApp.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace IncidentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private IRepositoryWrapper _repo;
       // Departamento _Departamento;
        ServiceDepartment serviceDepartment;
        public DepartamentoController(IRepositoryWrapper repo)
        {
            serviceDepartment = new ServiceDepartment();
           // _Departamento = new Departamento();
            _repo = repo;
        }

        [HttpGet]
        [Route("GetAllD")]
        //[EnableCors("AllowOrigin")] //Importante 3
        public IActionResult GetAll()
        {
            var departamento = _repo.departamento.GetAll();            
            return Ok( departamento );
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            if (id > 0)
            {
                var department = _repo.departamento.GetByID(id);
                return Ok(department);
            }
            else
            {
                return NotFound(id);
            }
        }

        [HttpPost]
        [Route("AddDepartment")]
        public IActionResult AddDepartment(Departamento departamento)
        {
            _repo.departamento.Add(departamento);
            _repo.Save();
            return Ok(departamento);
        }

        [HttpPatch]
        [Route("UpdateDepartment")]
        public IActionResult UpdateDepartment(DepartamentoDto departamentDto)
        {
            if (departamentDto != null)
            {
               var isdepartment = serviceDepartment.MapDepartamentoUpdate(departamentDto);
                _repo.departamento.Update(isdepartment);
                _repo.Save();
                return Ok(isdepartment);
            }
            else
            {
                return StatusCode(StatusCodes.Status304NotModified);
            }
        }

        [HttpDelete]
        [Route("DeleteDepartment/departamentoid/{departamentoid:int}/iduser/{iduser:int}")]
        public IActionResult DeleteDepartment(int departamentoId,int idUser)
        {
            if (departamentoId > 0)
            {
                var isdepartment = serviceDepartment.MapDepartamentoDelete(departamentoId, idUser);
                _repo.departamento.Update(isdepartment);
                _repo.Save();
                return Ok(isdepartment);
            }
            else
            {
                return StatusCode(StatusCodes.Status304NotModified);
            }
        }
    }
}
