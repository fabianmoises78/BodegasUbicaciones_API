using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface DetalleDocumentoEntradaDAO : CRUD<DETALLEDOCUMENTOENTRADA>
    {
        int ActivarDetDocEntrada(DETALLEDOCUMENTOENTRADA entity);
        int DesactivarDetDocEntrada(DETALLEDOCUMENTOENTRADA entity);
    }
}
