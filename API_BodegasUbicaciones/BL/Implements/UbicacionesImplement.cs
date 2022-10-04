using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.Implements
{
    public class UbicacionesImplement : UbicacionesDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public UbicacionesImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarUbicaciones(UBICACIONES entity)
        {
            throw new System.NotImplementedException();
        }

        public List<UBICACIONES> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(UBICACIONES entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(UBICACIONES entity)
        {
            throw new System.NotImplementedException();
        }

        public int DesactivarUbicaciones(UBICACIONES entity)
        {
            throw new System.NotImplementedException();
        }

        public List<UBICACIONES> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<UBICACIONES> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(UBICACIONES entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
