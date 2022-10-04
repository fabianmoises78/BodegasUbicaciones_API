using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface UbicacionesDAO : CRUD<UBICACIONES>
    {
        int ActivarUbicaciones(UBICACIONES entity);
        int DesactivarUbicaciones(UBICACIONES entity);
    }
}
