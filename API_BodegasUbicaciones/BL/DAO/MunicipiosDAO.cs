using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface MunicipiosDAO : CRUD<MUNICIPIOS>
    {
        int ActivarMuni(MUNICIPIOS entity);
        int DesactivarMuni(MUNICIPIOS entity);
    }
}
