using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class DetalleDocumentoEntradaController : ControllerBase
    {
        private readonly DetalleDocumentoEntradaDAO DetDocEntrada;

        public DetalleDocumentoEntradaController(DetalleDocumentoEntradaDAO _DetDocEntrada)
        {
            DetDocEntrada = _DetDocEntrada;
        }

        [HttpPost]
        [Route("UpdateDetDocEntrada")]
        public IActionResult UpdateDetDocEntrada([FromBody] DETALLEDOCUMENTOENTRADA entity)
        {
            if (entity.DCME_ID != 0 && entity.DTDE_ID != 0 && entity.PRD_ID != 0)
            {
                var id = DetDocEntrada.update(entity);
                return Ok(id);
            }
            else
            {
                return BadRequest("Error 404");
            }
        }

        [HttpPost]
        [Route("CreateDetDocEntrada")]
        public IActionResult CreateDetDocEntrada([FromBody] DETALLEDOCUMENTOENTRADA entity)
        {
            if (entity.DCME_ID != 0 && entity.PRD_ID != 0)
            {
                var id = DetDocEntrada.create(entity);
                return Ok(id);
            }
            else
            {
                return BadRequest("Error 404");
            }
        }

        [HttpPost]
        [Route("DeleteDetDocEntrada")]
        public IActionResult DeleteDetDocEntrada([FromBody] DETALLEDOCUMENTOENTRADA entity)
        {
            if (entity.DTDE_ID != 0)
            {
                var id = DetDocEntrada.delete(entity);
                return Ok(id);
            }
            else
            {
                return BadRequest("error 404");
            }
        }
    }
}
