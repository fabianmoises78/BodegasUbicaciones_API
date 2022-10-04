using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface TiposMovimientosDAO : CRUD<TIPOSMOVIMIENTOS>
    {
        int ActivarTipoMov(TIPOSMOVIMIENTOS entity);
        int DesactivarTipoMov(TIPOSMOVIMIENTOS entity);
    }
}
