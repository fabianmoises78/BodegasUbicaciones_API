using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class InventariosController : ControllerBase
    {
        private readonly InventariosDAO InvDAO;

        public InventariosController(InventariosDAO _InvDAO)
        {
            InvDAO = _InvDAO;
        }

        [HttpGet]
        [Route("GetListInventario")]
        public IActionResult GetListInventario()
        {
            var ListInventario = InvDAO.GetAll();
            return Ok(ListInventario);
        }

        [HttpGet]
        [Route("GetInventariobyId")]
        public IActionResult GetInventariobyId([FromBody] long Id)
        {
            var ListbyId = InvDAO.GetbyID(Id);
            return Ok(ListbyId);
        }

        [HttpGet]
        [Route("BuscarInventario")]
        public IActionResult BuscarInventario([FromBody] string data)
        {
            var BuscarInventario = InvDAO.Buscar(data);
            return Ok(BuscarInventario);
        }

        [HttpPost]
        [Route("CreateInventario")]
        public IActionResult CreateInventario([FromBody] INVENTARIOS entity)
        {
            var Id = InvDAO.create(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("UpdateInventario")]
        public IActionResult UpdateInventario([FromBody] INVENTARIOS entity)
        {
            var Id = InvDAO.update(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DeleteInventario")]
        public IActionResult DeleteInventario([FromBody] INVENTARIOS entity)
        {
            var Id = InvDAO.delete(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("ActivarInventario")]
        public IActionResult ActivarInventario([FromBody] INVENTARIOS entity)
        {
            var Id = InvDAO.ActivarInventario(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DesacInventario")]
        public IActionResult DesacInventario([FromBody] INVENTARIOS entity)
        {
            var Id = InvDAO.DesactivarInventario(entity);
            return Ok(Id);
        }
    }
}
