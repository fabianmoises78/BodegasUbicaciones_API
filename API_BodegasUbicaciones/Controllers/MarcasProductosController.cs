using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class MarcasProductosController : ControllerBase
    {
        private readonly MarcasProductosDAO MarcProducDAO;

        public MarcasProductosController(MarcasProductosDAO _MarcProducDAO)
        {
            MarcProducDAO = _MarcProducDAO;
        }

        [HttpGet]
        [Route("GetListMarcasProd")]
        public IActionResult GetListMarcasProd()
        {
            var ListMarcProd = MarcProducDAO.GetAll();
            return Ok(ListMarcProd);
        }

        [HttpGet]
        [Route("GetListMarcProdbyId")]
        public IActionResult GetListMarcProdbyId([FromBody] long Id)
        {
            var ListbyId = MarcProducDAO.GetbyID(Id);
            return Ok(ListbyId);
        }

        [HttpGet]
        [Route("BuscarMarcProd")]
        public IActionResult BuscarMarcProd([FromBody] string data)
        {
            var BuscarMaProd = MarcProducDAO.Buscar(data);
            return Ok(BuscarMaProd);
        }

        [HttpPost]
        [Route("CreateMarcProd")]
        public IActionResult CreateMarcProd([FromBody] MARCASPRODUCTOS entity)
        {
            var Id = MarcProducDAO.create(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("UpdateMarcProd")]
        public IActionResult UpdateMarcProd([FromBody] MARCASPRODUCTOS entity)
        {
            var Id = MarcProducDAO.update(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DeleteMarcProd")]
        public IActionResult DeleteMarcProd([FromBody] MARCASPRODUCTOS entity)
        {
            var Id = MarcProducDAO.delete(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("ActivarMarcProd")]
        public IActionResult ActivarMarcProd([FromBody] MARCASPRODUCTOS entity)
        {
            var Id = MarcProducDAO.ActivarMarProductos(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DesacMarcProd")]
        public IActionResult DesacMarcProd([FromBody] MARCASPRODUCTOS entity)
        {
            var Id = MarcProducDAO.DesactivarMarProductos(entity);
            return Ok(Id);
        }
    }
}
