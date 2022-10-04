using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface DetalleDocumentoSalidaDAO : CRUD<DETALLEDOCUMENTOSALIDA>
    {
        int ActivarDetDocSalida(DETALLEDOCUMENTOSALIDA entity);
        int DesactivarDetDocSalida(DETALLEDOCUMENTOSALIDA entity);
    }
}
