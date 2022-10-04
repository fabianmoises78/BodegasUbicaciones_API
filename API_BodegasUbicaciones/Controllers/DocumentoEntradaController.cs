using API_BodegasUbicaciones.BL.DAO;
using Microsoft.AspNetCore.Mvc;

namespace API_BodegasUbicaciones.Controllers
{
    public class DocumentoEntradaController : ControllerBase
    {
        public readonly DocumentoEntradaDAO DocEntrada;

        public DocumentoEntradaController(DocumentoEntradaDAO _DocEntrada)
        {
            DocEntrada = _DocEntrada;
        }
    }
}
