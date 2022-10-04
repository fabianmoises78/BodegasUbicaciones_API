using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface DepartamentosDAO : CRUD<DEPARTAMENTOS>
    {
        int ActivarDepartamentos(DEPARTAMENTOS entity);
        int DesacDepartamentos(DEPARTAMENTOS entity);
    }
}
