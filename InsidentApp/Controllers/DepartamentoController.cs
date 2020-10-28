using IncidentApp.Model.Model;
using IncidentApp.Repository.GenericRepository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace IncidentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private IRepositoryWrapper _repo;
        Departamento _Departamento;
        public DepartamentoController(IRepositoryWrapper repo)
        {
            _Departamento = new Departamento();
            _repo = repo;
        }

        [HttpGet]
        [Route("GetAllActive")]
        //[EnableCors("AllowOrigin")] //Importante 3
        public IActionResult GetAll()
        {
            var departamento = _repo.departamento.GetAll();            
            return Ok(new { departamento });
        }

    }
}
