using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class CategoriaProductosController : ControllerBase
    {
        private readonly CategoriaProductosDAO CatProdDAO;

        public CategoriaProductosController(CategoriaProductosDAO _catProdDAO)
        {
            CatProdDAO = _catProdDAO;
        }

        [HttpGet]
        [Route("GetListCatProd")]
        public IActionResult GetListCatProd()
        {
            var list = CatProdDAO.GetAll();

            return Ok(list);
        }

        [HttpGet]
        [Route("GetLisCatProdbyId")]
        public IActionResult GetLisCatProdbyId([FromBody] long Id)
        {
            var listbyId = CatProdDAO.GetbyID(Id);
            return Ok(listbyId);
        }

        [HttpPost]
        [Route("BuscarCatProd")]
        public IActionResult BuscarCatProd([FromBody] string data)
        {
            var ListBuscar = CatProdDAO.Buscar(data);
            return Ok(ListBuscar);
        }

        [HttpPost]
        [Route("CreateCatProd")]
        public IActionResult CreateCatProd([FromBody] CATEGORIAPRODUCTOS CatProd)
        {
            var Id = CatProdDAO.create(CatProd);
            return Ok(Id);
        }

        [HttpPost]
        [Route("EditarCatProd")]
        public IActionResult UpdateCatProd([FromBody] CATEGORIAPRODUCTOS Catprod)
        {
            var Id = CatProdDAO.update(Catprod);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DeleteCatProd")]
        public IActionResult DeleteCatProd([FromBody] CATEGORIAPRODUCTOS CatProd)
        {
            var Id = CatProdDAO.delete(CatProd);
            return Ok(Id);
        }

        [HttpPost]
        [Route("ActivarCatProd")]
        public IActionResult ActivarCatProd([FromBody] CATEGORIAPRODUCTOS CatProd)
        {
            var Id = CatProdDAO.ActivarCatProd(CatProd);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DesacCatProd")]
        public IActionResult DesacCatProd([FromBody] CATEGORIAPRODUCTOS CatProd)
        {
            var Id = CatProdDAO.DesactivarCatProd(CatProd);
            return Ok(Id);
        }
    }
}
