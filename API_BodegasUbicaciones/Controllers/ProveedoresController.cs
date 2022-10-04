using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class ProveedoresController : ControllerBase
    {
        private readonly ProveedoresDAO ProvDAO;

        public ProveedoresController(ProveedoresDAO _ProvDAO)
        {
            ProvDAO = _ProvDAO;
        }

        [HttpGet]
        [Route("GetListProveedores")]
        public IActionResult GetListProveedores()
        {
            var ListProvee = ProvDAO.GetAll();
            return Ok(ListProvee);
        }

        [HttpGet]
        [Route("GetProveedoresbyId")]
        public IActionResult GetProveedoresbyId([FromBody] long Id)
        {
            var ListbyId = ProvDAO.GetbyID(Id);
            return Ok(ListbyId);
        }

        [HttpGet]
        [Route("BuscarProveedores")]
        public IActionResult BuscarProveedores([FromBody] string data)
        {
            var Buscar = ProvDAO.Buscar(data);
            return Ok(Buscar);
        }

        [HttpPost]
        [Route("CreateProveedores")]
        public IActionResult CreateProveedores([FromBody] PROVEEDORES entity)
        {
            var Id = ProvDAO.create(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("UpdateProveedores")]
        public IActionResult UpdateProveedores([FromBody] PROVEEDORES entity)
        {
            var Id = ProvDAO.update(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DeleteProveedores")]
        public IActionResult DeleteProveedores([FromBody] PROVEEDORES entity)
        {
            var Id = ProvDAO.delete(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("ActivarProveedor")]
        public IActionResult ActivarProveedor([FromBody] PROVEEDORES entity)
        {
            var Id = ProvDAO.ActivarProveedor(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DesacProveedor")]
        public IActionResult DesacProveedor([FromBody] PROVEEDORES entity)
        {
            var Id = ProvDAO.DesactivarProveedor(entity);
            return Ok(Id);
        }
    }
}
