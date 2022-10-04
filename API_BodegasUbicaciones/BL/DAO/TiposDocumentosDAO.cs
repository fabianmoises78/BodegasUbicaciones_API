using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface TiposDocumentosDAO : CRUD<TIPOSDOCUMENTOS>
    {
        int ActivarTipoDoc(TIPOSDOCUMENTOS entity);
        int DesactivarTipoDoc(TIPOSDOCUMENTOS entity);
    }
}
