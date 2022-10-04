using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class DepartamentosController : ControllerBase
    {
        private readonly DepartamentosDAO DepaDAO;

        public DepartamentosController(DepartamentosDAO _DepaDAO)
        {
            DepaDAO = _DepaDAO;
        }

        [HttpGet]
        [Route("GetListDepa")]
        public IActionResult GetListDepa()
        {
            var list = DepaDAO.GetAll();
            return Ok(list);
        }

        [HttpGet]
        [Route("GetListDepabyId")]
        public IActionResult GetListDepabyId([FromBody] long Id)
        {
            var ListaDepabyId = DepaDAO.GetbyID(Id);
            return Ok(ListaDepabyId);
        }

        [HttpGet]
        [Route("BuscarDepa")]
        public IActionResult BuscarDepa([FromBody] string data)
        {
            var ListBuscar = DepaDAO.Buscar(data);
            return Ok(ListBuscar);
        }

        [HttpPost]
        [Route("CreateDepa")]
        public IActionResult CreateDepa([FromBody] DEPARTAMENTOS entity)
        {
            var Id = DepaDAO.create(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("UpdateDepa")]
        public IActionResult UpdateDepa([FromBody] DEPARTAMENTOS entity)
        {
            var Id = DepaDAO.update(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DeleteDepa")]
        public IActionResult DeleteDepa([FromBody] DEPARTAMENTOS entity)
        {
            var Id = DepaDAO.delete(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("ActiDepa")]
        public IActionResult ActiDepa([FromBody] DEPARTAMENTOS entity)
        {
            var Id = DepaDAO.ActivarDepartamentos(entity);
            return Ok(Id);
        }

        public IActionResult DesacDepa([FromBody] DEPARTAMENTOS entity)
        {
            var Id = DepaDAO.DesacDepartamentos(entity);
            return Ok(Id);
        }
    }
}
