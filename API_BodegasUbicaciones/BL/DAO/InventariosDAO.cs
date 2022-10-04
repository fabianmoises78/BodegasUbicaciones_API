using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface InventariosDAO : CRUD<INVENTARIOS>
    {
        int ActivarInventario(INVENTARIOS entity);
        int DesactivarInventario(INVENTARIOS entity);
    }
}
