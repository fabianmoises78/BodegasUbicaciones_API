using API_BodegasUbicaciones.BL.DAO;
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
    }
}
