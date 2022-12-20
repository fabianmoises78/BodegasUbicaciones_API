using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.BL.Models.ModelSP;
using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface ProductosDAO : CRUD<PRODUCTOS>
    {
        int ActivarProd(PRODUCTOS entity);
        int DesactivarProd(PRODUCTOS entity);
        List<PRODUCTO_RESULT> AllGet();
    }
}
