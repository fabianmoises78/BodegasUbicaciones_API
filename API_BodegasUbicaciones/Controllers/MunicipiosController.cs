using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class MunicipiosController : ControllerBase
    {
        private readonly MunicipiosDAO MunDAO;

        public MunicipiosController(MunicipiosDAO _MunDAO)
        {
            MunDAO = _MunDAO;
        }

        [HttpGet]
        [Route("GetlisMunicipios")]
        public IActionResult GetlisMunicipios()
        {
            var ListMuni = MunDAO.GetAll();
            return Ok(ListMuni);
        }

        [HttpGet]
        [Route("GetMunbyId")]
        public IActionResult GetMunbyId([FromBody] long Id)
        {
            var ListbyID = MunDAO.GetbyID(Id);
            return Ok(ListbyID);
        }

        [HttpGet]
        [Route("BuscarMuninicpio")]
        public IActionResult BuscarMuninicpio([FromBody] string data)
        {
            var BuscarMun = MunDAO.Buscar(data);
            return Ok(data);
        }

        [HttpPost]
        [Route("CreateMunicipio")]
        public IActionResult CreateMunicipio([FromBody] MUNICIPIOS entity)
        {
            var Id = MunDAO.create(entity);
            return Ok(entity);
        }

        [HttpPost]
        [Route("UpdateMunicipio")]
        public IActionResult UpdateMunicipio([FromBody] MUNICIPIOS entity)
        {
            var Id = MunDAO.update(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DeleteMunicipio")]
        public IActionResult DeleteMunicipio([FromBody] MUNICIPIOS entity)
        {
            var Id = MunDAO.delete(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("ActivarMunicipio")]
        public IActionResult ActivarMunicipio([FromBody] MUNICIPIOS entity)
        {
            var Id = MunDAO.ActivarMuni(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DesacMunicipio")]
        public IActionResult DesacMunicipio([FromBody] MUNICIPIOS entity)
        {
            var Id = MunDAO.DesactivarMuni(entity);
            return Ok(Id);
        }
    }
}
