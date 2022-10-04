using API_BodegasUbicaciones.BL.DAO;
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
    }
}
