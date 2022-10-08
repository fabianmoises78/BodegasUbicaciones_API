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
