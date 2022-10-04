using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface CategoriasEmpleadosDAO : CRUD<CATEGORIASEMPLEADOS>
    {
        int ActivarCatEmple(CATEGORIASEMPLEADOS entity);
        int DesacCatEmple(CATEGORIASEMPLEADOS entity);
    }
}
