using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.DAO
{
    public interface CRUD<TEntity>
    {
        List<TEntity> GetAll();
        List<TEntity> GetbyID(long Id);
        List<TEntity> Buscar(string data);
        int update(TEntity entity);
        int delete(TEntity entity);
        int create(TEntity entity);
    }
}
