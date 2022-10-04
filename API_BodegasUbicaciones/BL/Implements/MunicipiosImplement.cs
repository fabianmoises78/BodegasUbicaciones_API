using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.Implements
{
    public class MunicipiosImplement : MunicipiosDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public MunicipiosImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarMuni(MUNICIPIOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<MUNICIPIOS> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(MUNICIPIOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(MUNICIPIOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int DesactivarMuni(MUNICIPIOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<MUNICIPIOS> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<MUNICIPIOS> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(MUNICIPIOS entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
