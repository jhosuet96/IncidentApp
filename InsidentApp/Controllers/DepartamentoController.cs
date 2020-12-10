using IncidentApp.Model.Dto;
using IncidentApp.Model.Model;
using IncidentApp.Repository.GenericRepository;
using IncidentApp.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;
using System.Linq;

namespace IncidentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private IRepositoryWrapper _repo;
       // Departamento _Departamento;
        ServiceDepartamento serviceDepartment;
        public DepartamentoController(IRepositoryWrapper repo)
        {
            serviceDepartment = new ServiceDepartamento();
           // _Departamento = new Departamento();
            _repo = repo;
        }

        [HttpGet]
        [Route("GetAllD")]
        //[EnableCors("AllowOrigin")] //Importante 3
        public IActionResult GetAll()
        {
            var departamento = _repo.departamento.GetAll().Where(d => d.Borrado == false);            
            return Ok( departamento );
        }

        [HttpGet]
        [Route("GetById/{id:int}")]
        [EnableCors("AllowOrigin")]
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
        [Route("AddDepartamento")]
        public IActionResult AddDepartamento(DepartamentoDto departamentDto)
        {
            var isdepartment = serviceDepartment.MapDepartamentoAdd(departamentDto);
            _repo.departamento.Add(isdepartment);
            _repo.Save();
            return Ok(isdepartment);
        }

        [HttpPatch]
        [Route("UpdateDepartamento")]
        public IActionResult UpdateDepartment(DepartamentoDto departamentDto)
        {
            if (departamentDto != null)
            {
               var isdepartment = serviceDepartment.MapDepartamentoUpdate(departamentDto);
                isdepartment.DepartamentoId = departamentDto.DepartamentoId;
                _repo.departamento.Update(isdepartment);
                _repo.Save();
                return Ok(isdepartment);
            }
            else
            {
                return StatusCode(StatusCodes.Status304NotModified);
            }
        }

        [HttpPatch]
        [Route("DeleteDepartmento")]
        public IActionResult DeleteDepartmento(DepartamentoDto departamento)
        {
            if (departamento.DepartamentoId > 0)
            {
                var isdepartment = serviceDepartment.MapDepartamentoDelete(departamento);
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
