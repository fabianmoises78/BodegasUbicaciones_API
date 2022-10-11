using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    public class DocumentoSalidaController : ControllerBase
    {
        private readonly DocumentoSalidaDAO DocSalidaDAO;

        public DocumentoSalidaController(DocumentoSalidaDAO _DocSalidaDAO)
        {
            DocSalidaDAO = _DocSalidaDAO;
        }

        [HttpPost]
        [Route("CreateDocSalida")]
        public IActionResult CreateDocSalida([FromBody] DOCUMENTOSALIDA entity)
        {
            if (entity.DCMS_CODIGO != null && entity.DCMS_CONCEPTO != null)
            {
                var id = DocSalidaDAO.create(entity);
                return Ok(id);
            }
            else
            {
                return BadRequest("Error 404");
            }
        }

        [HttpPost]
        [Route("UpdareDocSalida")]
        public IActionResult UpdareDocSalida([FromBody] DOCUMENTOSALIDA entity)
        {
            if (entity.DCMS_CODIGO != null && entity.DCMS_CONCEPTO != null)
            {
                var id = DocSalidaDAO.update(entity);
                return Ok(id);
            }
            else
            {
                return BadRequest("Error 404");
            }
        }

        [HttpPost]
        [Route("DocSalida_Finalizar")]
        public IActionResult DocSalida_Finalizar([FromBody] DOCUMENTOSALIDA entity)
        {
            var id = DocSalidaDAO.DocSalida_Anular(entity);
            return Ok(id);
        }

        [HttpPost]
        [Route("DocSalida_Del_All")]
        public IActionResult DocSalida_Del_All([FromBody] DOCUMENTOSALIDA entity)
        {
            if (entity.DCMS_ID != 0)
            {
                var id = DocSalidaDAO.DocSalida_Del_All(entity);
                return Ok(id);
            }
            else
            {
                return BadRequest("Error 404");
            }
        }

        [HttpPost]
        [Route("DocSalida_Anular")]
        public IActionResult DocSalida_Anular([FromBody] DOCUMENTOSALIDA entity)
        {
            if (entity.DCMS_ID != 0)
            {
                var id = DocSalidaDAO.DocSalida_Anular(entity);
                return Ok(id);
            }
            else
            {
                return BadRequest("Error 404");
            }
        }
    }
}
