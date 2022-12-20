using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly ProductosDAO ProdDAO;

        public ProductosController(ProductosDAO _ProdDAO)
        {
            ProdDAO = _ProdDAO;
        }

        [HttpGet]
        [Route("GetListProductos")]
        public IActionResult GetListProductos()
        {
            var ListProductos = ProdDAO.AllGet();
            return Ok(ListProductos);
        }

        [HttpGet]
        [Route("GetListbyId")]
        public IActionResult GetListbyId([FromBody] long Id)
        {
            var ListbyId = ProdDAO.GetbyID(Id);
            return Ok(ListbyId);
        }

        [HttpGet]
        [Route("BuscarProductos")]
        public IActionResult BuscarProductos([FromBody] string data)
        {
            var BuscarProd = ProdDAO.Buscar(data);
            return Ok(BuscarProd);
        }

        [HttpPost]
        [Route("CreateProductos")]
        public IActionResult CreateProductos([FromBody] PRODUCTOS entity)
        {
            
            if (entity.PRD_CODIGO != null && entity.PRD_NOMBRE != null && entity.PRD_URLIMG != null)
            {
                var Id = ProdDAO.create(entity);
                return Ok(Id);
            }
            else
            {
                return BadRequest("Error 404");
            }
        }

        [HttpPost]
        [Route("UpdateProducto")]
        public IActionResult UpdateProducto([FromBody] PRODUCTOS entity)
        {
            if (entity.PRD_CODIGO != null && entity.PRD_NOMBRE != null && entity.PRD_URLIMG != null)
            {
                var Id = ProdDAO.update(entity);
                return Ok(Id);
            }
            else
            {
                return BadRequest("Error 404");
            }
        }

        [HttpPost]
        [Route("DeleteProducto")]
        public IActionResult DeleteProducto([FromBody] PRODUCTOS entity)
        {
            var Id = ProdDAO.delete(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("ActivarProducto")]
        public IActionResult ActivarProducto([FromBody] PRODUCTOS entity)
        {
            var Id = ProdDAO.ActivarProd(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DesactivarProducto")]
        public IActionResult DesactivarProducto([FromBody] PRODUCTOS entity)
        {
            var Id = ProdDAO.DesactivarProd(entity);
            return Ok(Id);
        }
    }
}
