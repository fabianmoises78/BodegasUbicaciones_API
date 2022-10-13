using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    public class DocumentoEntradaController : ControllerBase
    {
        public readonly DocumentoEntradaDAO DocEntrada;

        public DocumentoEntradaController(DocumentoEntradaDAO _DocEntrada)
        {
            DocEntrada = _DocEntrada;
        }

        [HttpPost]
        [Route("CreateDocEntrada")]
        public IActionResult CreateDocEntrada([FromBody] DOCUMENTOENTRADA entity)
        {
            if (entity.DCME_CODIGO != null && entity.DCME_CONCEPTO != null)
            {
                var id = DocEntrada.create(entity);
                return Ok(id);
            }
            else
            {
                return BadRequest("Error 404");
            }
        }

        [HttpPost]
        [Route("UpdateDocEntrada")]
        public IActionResult UpdateDocEntrada([FromBody] DOCUMENTOENTRADA entity)
        {
            if (entity.DCME_CODIGO != null && entity.DCME_CONCEPTO != null)
            {
                var id = DocEntrada.update(entity);
                return Ok(id);
            }
            else
            {
                return BadRequest("Error 404");
            }
        }
        /*
            Este EndPoint recibe la Id para cambiar a estado finalizado
            de la tabla DocumentoEntrada
         */
        [HttpPost]
        [Route("DocEntrada_Finalizado")]
        public IActionResult DocEntrada_Finalizado([FromBody] DOCUMENTOENTRADA entity)
        {
            var id = DocEntrada.DocEntrada_Finalizado(entity);
            return Ok(id);
        }
    }
}
