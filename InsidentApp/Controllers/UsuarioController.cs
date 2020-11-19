using IncidentApp.Repository.GenericRepository;
using Microsoft.AspNetCore.Mvc;
using IncidentApp.Service;
using IncidentApp.Model.Model;
using System.Runtime.InteropServices.ComTypes;
using IncidentApp.Model.Dto;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.AspNetCore.Http;

namespace IncidentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IRepositoryWrapper _repo;
        ServiceUsuario serviceUsuario;
        PuestoController puestoController;
        public UsuarioController(IRepositoryWrapper repo)
        {
            _repo = repo;
            serviceUsuario = new ServiceUsuario();
            puestoController = new PuestoController(_repo);
        }

        [HttpGet]
        [Route("GetAllU")]
        public IActionResult GetAll()
        {
            var usurio = _repo.usuario.GetAll();
            return Ok(usurio);
        }

        [HttpGet]

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
        [Route("DeleteUsuario/usuarioid/{usuarioid:int}/iduser/{iduser:int}")]
        public IActionResult DeleteUsuario(int usuarioid,int idUser)
        {
            if (usuarioid > 0)
            {
                var isusuario = serviceUsuario.MapUsuarioDelete(usuarioid,idUser);
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
