using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface EmpleadosDAO : CRUD<EMPLEADOS>
    {
        int ActivarEmpleado(EMPLEADOS entity);
        int DesactivarEmpleado(EMPLEADOS entity);
    }
}
