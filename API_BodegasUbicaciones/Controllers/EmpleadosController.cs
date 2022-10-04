using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class EmpleadosController : ControllerBase
    {
        private readonly EmpleadosDAO EmpDAO;

        public EmpleadosController(EmpleadosDAO _EmpDAO)
        {
            EmpDAO = _EmpDAO;
        }

        [HttpGet]
        [Route("GetListEmpleados")]
        public IActionResult GetListEmpleados()
        {
            var ListEmpleados = EmpDAO.GetAll();
            return Ok(ListEmpleados);
        }

        [HttpGet]
        [Route("GetListEmpbyId")]
        public IActionResult GetListEmpbyId([FromBody] long Id)
        {
            var ListEmpleadosbyId = EmpDAO.GetbyID(Id);
            return Ok(ListEmpleadosbyId);
        }

        [HttpGet]
        [Route("BuscarEmpleado")]
        public IActionResult BuscarEmpleado([FromBody] string data)
        {
            var BuscarEmp = EmpDAO.Buscar(data);
            return Ok(BuscarEmp);
        }

        [HttpPost]
        [Route("CreateEmpleado")]
        public IActionResult CreateEmpleado([FromBody] EMPLEADOS entity)
        {
            var Id = EmpDAO.create(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("UpdateEmpleado")]
        public IActionResult UpdateEmpleado([FromBody] EMPLEADOS entity)
        {
            var Id = EmpDAO.update(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DeleteEmpleado")]
        public IActionResult DeleteEmpleado([FromBody] EMPLEADOS entity)
        {
            var Id = EmpDAO.delete(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("ActivarEmpleado")]
        public IActionResult ActivarEmpleado([FromBody] EMPLEADOS entity)
        {
            var Id = EmpDAO.ActivarEmpleado(entity);
            return Ok(Id);
        }

        [HttpPost]
        [Route("DesacEmpleado")]
        public IActionResult DesacEmpleado([FromBody] EMPLEADOS entity)
        {
            var Id = EmpDAO.DesactivarEmpleado(entity);
            return Ok(Id);
        }
    }
}
