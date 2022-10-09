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
            if (entity.DCMS_ID != 0 && entity.PRD_ID != 0)
            {
                var id = DetDocSalida.create(entity);
                return Ok(id);
            }
            else
            {
                return BadRequest("Error 404");
            }
        }

        [HttpPost]
        [Route("UpdateDetDocSalida")]
        public IActionResult UpdateDetDocSalida([FromBody] DETALLEDOCUMENTOSALIDA entity)
        {
            if(entity.DTDS_ID != 0 && entity.DCMS_ID != 0 && entity.PRD_ID != 0)
            {
                var id = DetDocSalida.update(entity);
                return Ok(id);
            }
            else
            {
                return BadRequest("Error 404");
            }
        }

        [HttpPost]
        [Route("DeleteDetDocSalida")]
        public IActionResult DeleteDetDocSalida([FromBody] DETALLEDOCUMENTOSALIDA entity)
        {
            if(entity.DTDS_ID != 0)
            {
                var id = DetDocSalida.delete(entity);
                return Ok(id);
            }
            else
            {
                return BadRequest("Error 404");
            }
        }
    }
}
