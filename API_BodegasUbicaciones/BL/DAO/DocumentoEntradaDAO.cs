using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface DocumentoEntradaDAO : CRUD<DOCUMENTOENTRADA>
    {
        int ActivarDocEntrada(DOCUMENTOENTRADA entity);
        int DesactivarDocEntrada(DOCUMENTOENTRADA entity);
        int DocEntrada_Finalizado(DOCUMENTOENTRADA entity); //Esta interfaz recibe un ID para cambiar de estado a finalizado
    }
}
