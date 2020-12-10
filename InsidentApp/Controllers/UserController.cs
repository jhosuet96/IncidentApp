using Microsoft.AspNetCore.Http;
using IncidentApp.Repository.GenericRepository;
using Microsoft.AspNetCore.Mvc;
using IncidentApp.Service;
using IncidentApp.Model.Model;
using IncidentApp.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;

namespace IncidentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IRepositoryWrapper _repo;
        ServiceUsuario serviceUsuario;
        PuestoController puestoController;
        public UserController(IRepositoryWrapper repo)
        {
            _repo = repo;
            serviceUsuario = new ServiceUsuario(repo);
            puestoController = new PuestoController(_repo);
        }

        [HttpGet]
        [Route("GetAllU")]
        [EnableCors("AllowOrigin")]
        public IActionResult GetAll()
        {
            var usuario = _repo.usuario.GetAll();
            return Ok(usuario);
        }

        [HttpGet]
        [Route("GetById/{id:int}")]
        [EnableCors("AllowOrigin")]
        public IActionResult GetById(int id)
        {
            if (id > 0)
            {
                var usuario = _repo.usuario.GetByID(id);
                return Ok(usuario);
            }
            else
            {
                return NotFound(id);
            }
        }
        [HttpGet]
        [Route("getId/{id:int}")]
        [EnableCors]
        public IActionResult GetId(int id)
        {
            var usuario = _repo.usuario.GetByID(id);
            return Ok(usuario);
        }


        [HttpPost]
        [Route("AddUsuario")]
        public IActionResult AddUsuario(Usuario usuario)
        {
            _repo.usuario.Add(usuario);
            _repo.Save();
            return Ok(usuario);
        }

        [HttpPatch]
        [Route("UpdateUsuario")]
        public IActionResult UpdateUsuario(UsuarioDto usuarioDto)
        {
            var isvalue = puestoController.GetById(usuarioDto.PuestoID);
            if (isvalue != null)
            {
                if (usuarioDto != null)
                {
                    var isusuario = serviceUsuario.MapUsuarioUpdate(usuarioDto);
                    _repo.usuario.Update(isusuario);
                    _repo.Save();
                    return Ok(isusuario);
                }
                else
                {
                    return StatusCode(StatusCodes.Status304NotModified);
                }
            }
            else
            {
                return NotFound();
            }

        }

        [HttpDelete]
        [Route("DeleteUsuario")]
        public IActionResult DeleteUsuario(UsuarioDto usuarioDto)
        {
            if (usuarioDto.UsuarioId > 0)
            {
                var isusuario = serviceUsuario.MapUsuarioDelete(usuarioDto);
                _repo.usuario.Update(isusuario);
                _repo.Save();
                return Ok(isusuario);
            }
            else
            {
                return StatusCode(StatusCodes.Status304NotModified);
            }
        }

    }
}
