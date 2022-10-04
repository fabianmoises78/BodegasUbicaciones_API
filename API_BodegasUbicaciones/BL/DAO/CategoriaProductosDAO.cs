using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface CategoriaProductosDAO : CRUD<CATEGORIAPRODUCTOS>
    {
        int DesactivarCatProd(CATEGORIAPRODUCTOS entity);
        int ActivarCatProd(CATEGORIAPRODUCTOS entity);
    }
}