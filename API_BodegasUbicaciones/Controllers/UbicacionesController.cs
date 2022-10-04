using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class UbicacionesController : ControllerBase
    {
        private readonly UbicacionesDAO UbiDAO;

        public UbicacionesController(UbicacionesDAO _UbiDAO)
        {
            UbiDAO = _UbiDAO;
        }

        [HttpGet]
        [Route("GetListUbicaciones")]
        public IActionResult GetListUbicaciones()
        {
            var List = UbiDAO.GetAll();
            return Ok(List);
        }

        [HttpGet]
        [Route("GetUbicacionesbyId")]
        public IActionResult GetUbicacionesbyId([FromBody] long Id)
        {
            var UbicacionesbyId = UbiDAO.GetbyID(Id);
            return Ok(UbicacionesbyId);
        }

        [HttpGet]
        [Route("BuscarUbicaciones")]
        public IActionResult BuscarUbicaciones([FromBody] string data)
        {
            var BuscarUbicaciones = UbiDAO.Buscar(data);
            return Ok(BuscarUbicaciones);
        }
        [HttpPost]
        [Route("CreateUbicaciones")]
        public IActionResult CreateUbicaciones([FromBody] UBICACIONES entity)
        {
            var Id = UbiDAO.create(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("UpdateUbicaciones")]
        public IActionResult UpdateUbicaciones([FromBody] UBICACIONES entity)
        {
            var Id = UbiDAO.update(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DeleteUbicaciones")]
        public IActionResult DeleteUbicaciones([FromBody] UBICACIONES entity)
        {
            var Id = UbiDAO.delete(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("ActivarUbicaciones")]
        public IActionResult ActivarUbicaciones([FromBody] UBICACIONES entity)
        {
            var Id = UbiDAO.ActivarUbicaciones(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DesactivarUbicaciones")]
        public IActionResult DesactivarUbicaciones([FromBody] UBICACIONES entity)
        {
            var Id = UbiDAO.DesactivarUbicaciones(entity);
            return Ok(Id);
        }
    }
}
