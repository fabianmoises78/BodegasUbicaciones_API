using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuariosDAO UserDAO;

        public UsuariosController(UsuariosDAO _UserDAO)
        {
            UserDAO = _UserDAO;
        }

        [HttpGet]
        [Route("GetListUser")]
        public IActionResult GetListUser()
        {
            var ListUser = UserDAO.GetAll();
            return Ok(ListUser);
        }

        [HttpGet]
        [Route("GetUserbyID")]
        public IActionResult GetUserbyID([FromBody] long Id)
        {
            var ListbyId = UserDAO.GetbyID(Id);
            return Ok(ListbyId);
        }

        [HttpGet]
        [Route("BuscarUser")]
        public IActionResult BuscarUser([FromBody] string data)
        {
            var Buscaruser = UserDAO.Buscar(data);
            return Ok(Buscaruser);
        }

        [HttpPost]
        [Route("CreateUser")]
        public IActionResult CreateUser([FromBody] USUARIOS entity)
        {
            if (entity.USR_EMAIL != null && entity.USR_USRACCESO != null && entity.USR_PASSWORD != null)
            {
                var Id = UserDAO.create(entity);
                return Ok(Id);
            }
            else
            {
                return BadRequest("Error 404");
            }
        }

        [HttpPost]
        [Route("UpdateUser")]
        public IActionResult UpdateUser([FromBody] USUARIOS entity)
        {
            if (entity.USR_EMAIL != null && entity.USR_USRACCESO != null && entity.USR_PASSWORD != null)
            {
                var Id = UserDAO.update(entity);
                return Ok(Id);
            }
            else
            {
                return BadRequest("Error 404");
            }
        }

        [HttpPost]
        [Route("DeleteUser")]
        public IActionResult DeleteUser([FromBody] USUARIOS entity)
        {
            var Id = UserDAO.delete(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("ActivarUser")]
        public IActionResult ActivarUser([FromBody] USUARIOS entity)
        {
            var Id = UserDAO.ActivarUser(entity);
            return Ok(Id);
        }

        /*
        [HttpPost]
        [Route("DesactivarUser")]
        public IActionResult DesactivarUser([FromBody] USUARIOS entity)
        {
            var Id = UserDAO.DesactivarUser(entity);
            return Ok(Id);
        }
        */
    }
}
