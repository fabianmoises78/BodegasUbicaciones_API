using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface ProductosDAO : CRUD<PRODUCTOS>
    {
        int ActivarProd(PRODUCTOS entity);
        int DesactivarProd(PRODUCTOS entity);
    }
}
