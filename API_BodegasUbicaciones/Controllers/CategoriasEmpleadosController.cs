using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class CategoriasEmpleadosController : ControllerBase
    {
        private readonly CategoriasEmpleadosDAO CatEmplDAO;

        public CategoriasEmpleadosController(CategoriasEmpleadosDAO _CatEmplDAO)
        {
            CatEmplDAO = _CatEmplDAO;
        }

        [HttpGet]
        [Route("GetListCatEmp")]
        public IActionResult GetListCatEmp()
        {
            var ListCatEmp = CatEmplDAO.GetAll();
            return Ok(ListCatEmp);
        }

        [HttpGet]
        [Route("GetListCatEmpbyID")]
        public IActionResult GetListCatEmpbyID([FromBody] long Id)
        {
            var ListCatEmpId = CatEmplDAO.GetbyID(Id);
            return Ok(ListCatEmpId);
        }

        [HttpGet]
        [Route("BuscarCatEmp")]
        public IActionResult BuscarCatEmp([FromBody] string data)
        {
            var ListBuscar = CatEmplDAO.Buscar(data);
            return Ok(ListBuscar);
        }

        [HttpPost]
        [Route("CreateCatEmp")]
        public IActionResult CreateCatEmp([FromBody] CATEGORIASEMPLEADOS entity)
        {
            var Id = CatEmplDAO.create(entity);
            return Ok(Id);
        }

        public IActionResult UpdateCatEmp([FromBody] CATEGORIASEMPLEADOS entity)
        {
            var Id = CatEmplDAO.update(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DeleteCatEmp")]
        public IActionResult DeleteCatEmp([FromBody] CATEGORIASEMPLEADOS entity)
        {
            var Id = CatEmplDAO.delete(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("ActivarCatEmp")]
        public IActionResult ActivarCatEmp([FromBody] CATEGORIASEMPLEADOS entity)
        {
            var Id = CatEmplDAO.ActivarCatEmple(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DesacCatEmp")]
        public IActionResult DesacCatEmp([FromBody] CATEGORIASEMPLEADOS entity)
        {
            var Id = CatEmplDAO.DesacCatEmple(entity);
            return Ok(Id);
        }
    }
}
