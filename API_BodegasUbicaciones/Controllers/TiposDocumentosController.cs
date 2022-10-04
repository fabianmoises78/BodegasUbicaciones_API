using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class TiposDocumentosController : ControllerBase
    {
        public readonly TiposDocumentosDAO TipoDocDAO;

        public TiposDocumentosController(TiposDocumentosDAO _TipoDocDAO)
        {
            TipoDocDAO = _TipoDocDAO;
        }

        [HttpGet]
        [Route("GetListTipoDoc")]
        public IActionResult GetListTipoDoc()
        {
            var Listtipodoc = TipoDocDAO.GetAll();
            return Ok(Listtipodoc);
        }

        [HttpGet]
        [Route("GetListTipoDocbyId")]
        public IActionResult GetListTipoDocbyId([FromBody] long Id)
        {
            var ListbyId = TipoDocDAO.GetbyID(Id);
            return Ok(ListbyId);
        }

        [HttpGet]
        [Route("BuscarTipoDoc")]
        public IActionResult BuscarTipoDoc([FromBody] string datos)
        {
            var Buscar = TipoDocDAO.Buscar(datos);
            return Ok(Buscar);
        }

        [HttpPost]
        [Route("CreateTipoDoc")]
        public IActionResult CreateTipoDoc([FromBody] TIPOSDOCUMENTOS entity)
        {
            var Id = TipoDocDAO.create(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("UpdateTipoDoc")]
        public IActionResult UpdateTipoDoc([FromBody] TIPOSDOCUMENTOS entity)
        {
            var Id = TipoDocDAO.update(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DeleteTipoDoc")]
        public IActionResult DeleteTipoDoc([FromBody] TIPOSDOCUMENTOS entity)
        {
            var Id = TipoDocDAO.delete(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("ActivarTipoDoc")]
        public IActionResult ActivarTipoDoc([FromBody] TIPOSDOCUMENTOS entity)
        {
            var Id = TipoDocDAO.ActivarTipoDoc(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DesactivarTipoDoc")]
        public IActionResult DesactivarTipoDoc([FromBody] TIPOSDOCUMENTOS entity)
        {
            var Id = TipoDocDAO.DesactivarTipoDoc(entity);
            return Ok(Id);
        }
    }
}
