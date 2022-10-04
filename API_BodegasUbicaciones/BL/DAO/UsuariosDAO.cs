using API_BodegasUbicaciones.BL.Models;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface UsuariosDAO : CRUD<USUARIOS>
    {
        int ActivarUser(USUARIOS entity);
        int DesactivarUser(USUARIOS entity);
    }
}
