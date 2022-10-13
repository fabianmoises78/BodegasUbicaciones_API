using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    public class DetalleDocumentoSalidaController : ControllerBase
    {
        public readonly DetalleDocumentoSalidaDAO DetDocSalida;

        public DetalleDocumentoSalidaController(DetalleDocumentoSalidaDAO _DetDocSalida)
        {
            DetDocSalida = _DetDocSalida;
        }

        [HttpPost]
        [Route("CreateDetDocSalida")]
        public IActionResult CreateDetDocSalida([FromBody] DETALLEDOCUMENTOSALIDA entity)
        {
            var id = DetDocSalida.create(entity);
            return Ok(id);
        }

        [HttpPost]
        [Route("UpdateDetDocSalida")]
        public IActionResult UpdateDetDocSalida([FromBody] DETALLEDOCUMENTOSALIDA entity)
        {
            var id = DetDocSalida.update(entity);
            return Ok(id);
        }

        [HttpPost]
        [Route("DeleteDetDocSalida")]
        public IActionResult DeleteDetDocSalida([FromBody] DETALLEDOCUMENTOSALIDA entity)
        {

            var id = DetDocSalida.delete(entity);
            return Ok(id);
        }
    }
}
