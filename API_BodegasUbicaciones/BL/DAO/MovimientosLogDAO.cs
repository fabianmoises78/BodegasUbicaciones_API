using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface MovimientosLogDAO : CRUD<MOVIMIENTOSLOG>
    {
        int ActivarMov(MOVIMIENTOSLOG entity);
        int desactivarMov(MOVIMIENTOSLOG entity);
    }
}
