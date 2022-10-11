using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface DocumentoSalidaDAO : CRUD<DOCUMENTOSALIDA>
    {
        int ActivarDocSalida(DOCUMENTOSALIDA entity);
        int DesactivarDocSalida(DOCUMENTOSALIDA entity);
        int DocSalida_Anular(DOCUMENTOSALIDA entity); //Esta interfaz es para anular un documento de salida
        int DocSalida_Del_All(DOCUMENTOSALIDA entity); //Esta interfaz recibe una ID para anular dos tablas de la base de datos
        int DocSalida_Finalizar(DOCUMENTOSALIDA entity); //Esta interfaz recibe una ID para finalizar un documento de salida
    }
}