using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class TiposMovimientosController : ControllerBase
    {
        private readonly TiposMovimientosDAO TiposMovDAO;

        public TiposMovimientosController(TiposMovimientosDAO _TiposMovDAO)
        {
            TiposMovDAO = _TiposMovDAO;
        }

        [HttpGet]
        [Route("GetListTipoMov")]
        public IActionResult GetListTipoMov()
        {
            var ListTMov = TiposMovDAO.GetAll();
            return Ok(ListTMov);
        }

        [HttpGet]
        [Route("GetListTipoMovbyId")]
        public IActionResult GetListTipoMovbyId([FromBody] long Id)
        {
            var ListbyId = TiposMovDAO.GetbyID(Id);
            return Ok(ListbyId);
        }

        [HttpGet]
        [Route("BuscarTipoMov")]
        public IActionResult BuscarTipoMov([FromBody] string data)
        {
            var ListBuscar = TiposMovDAO.Buscar(data);
            return Ok(ListBuscar);
        }

        [HttpPost]
        [Route("CreateTipoMov")]
        public IActionResult CreateTipoMov([FromBody] TIPOSMOVIMIENTOS entity)
        {
            var Id = TiposMovDAO.create(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("UpdateTipoMov")]
        public IActionResult UpdateTipoMov([FromBody] TIPOSMOVIMIENTOS entity)
        {
            var Id = TiposMovDAO.update(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DeleteTipoMov")]
        public IActionResult DeleteTipoMov([FromBody] TIPOSMOVIMIENTOS entity)
        {
            var Id = TiposMovDAO.delete(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("ActivarTIpoMov")]
        public IActionResult ActivarTIpoMov([FromBody] TIPOSMOVIMIENTOS entity)
        {
            var Id = TiposMovDAO.ActivarTipoMov(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DesacTipoMov")]
        public IActionResult DesacTipoMov([FromBody] TIPOSMOVIMIENTOS entity)
        {
            var Id = TiposMovDAO.DesactivarTipoMov(entity);
            return Ok(Id);
        }
    }
}
