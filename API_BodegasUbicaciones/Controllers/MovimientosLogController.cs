using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class MovimientosLogController : ControllerBase
    {
        private readonly MovimientosLogDAO MovDAO;

        public MovimientosLogController(MovimientosLogDAO _MovDAO)
        {
            MovDAO = _MovDAO;
        }

        [HttpGet]
        [Route("GetListMovimientos")]
        public IActionResult GetListMovimientos()
        {
            var ListMov = MovDAO.GetAll();
            return Ok(ListMov);
        }

        [HttpGet]
        [Route("GetlistMovbyId")]
        public IActionResult GetlistMovbyId([FromBody] long Id)
        {
            var ListbyId = MovDAO.GetbyID(Id);
            return Ok(ListbyId);
        }

        [HttpGet]
        [Route("BuscarMovimiento")]
        public IActionResult BuscarMovimiento([FromBody] string data)
        {
            var BuscarMov = MovDAO.Buscar(data);
            return Ok(BuscarMov);
        }

        [HttpPost]
        [Route("CreateMovimiento")]
        public IActionResult CreateMovimiento([FromBody] MOVIMIENTOSLOG entity)
        {
            var Id = MovDAO.create(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("UpdateMovimiento")]
        public IActionResult UpdateMovimiento([FromBody] MOVIMIENTOSLOG entity)
        {
            var Id = MovDAO.update(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DeleteMovimiento")]
        public IActionResult DeleteMovimiento([FromBody] MOVIMIENTOSLOG entity)
        {
            var Id = MovDAO.delete(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("ActivarMovimiento")]
        public IActionResult ActivarMovimiento([FromBody] MOVIMIENTOSLOG entity)
        {
            var Id = MovDAO.ActivarMov(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DesacMovimiento")]
        public IActionResult DesacMovimiento([FromBody] MOVIMIENTOSLOG entity)
        {
            var Id = MovDAO.desactivarMov(entity);
            return Ok(Id);
        }
    }
}
