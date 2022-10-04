using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface DocumentoSalidaDAO : CRUD<DOCUMENTOSALIDA>
    {
        int ActivarDocSalida(DOCUMENTOSALIDA entity);
        int DesactivarDocSalida(DOCUMENTOSALIDA entity);
    }
}
