using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface ProveedoresDAO : CRUD<PROVEEDORES>
    {
        int ActivarProveedor(PROVEEDORES entity);
        int DesactivarProveedor(PROVEEDORES entity);
    }
}
