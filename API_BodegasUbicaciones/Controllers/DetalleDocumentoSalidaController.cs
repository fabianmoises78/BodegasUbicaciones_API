using API_BodegasUbicaciones.BL.DAO;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    public class DetalleDocumentoSalidaController : ControllerBase
    {
        public readonly DetalleDocumentoSalidaDAO DetDocSalida;

        public DetalleDocumentoSalidaController(DetalleDocumentoSalidaDAO _DetDocSalida)
        {
            DetDocSalida = _DetDocSalida;
        }
    }
}
