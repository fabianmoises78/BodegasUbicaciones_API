using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface DetalleDocumentoEntradaDAO : CRUD<DETALLEDOCUMENTOENTRADA>
    {
        int ActivarDetDocEntrada(DETALLEDOCUMENTOENTRADA entity);
        int DesactivarDetDocEntrada(DETALLEDOCUMENTOENTRADA entity);
        int DeleteDocEntradaAll(DETALLEDOCUMENTOENTRADA entity); //Esta interfaz recibe un ID para borrar los registros de 2 tablas
    }
}
