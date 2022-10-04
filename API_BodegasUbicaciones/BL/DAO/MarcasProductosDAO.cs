using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface MarcasProductosDAO : CRUD<MARCASPRODUCTOS>
    {
        int ActivarMarProductos(MARCASPRODUCTOS entity);
        int DesactivarMarProductos(MARCASPRODUCTOS entity);
    }
}
