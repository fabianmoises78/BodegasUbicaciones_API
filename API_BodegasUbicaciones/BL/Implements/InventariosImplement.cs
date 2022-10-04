using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.Implements
{
    public class InventariosImplement : InventariosDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public InventariosImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarInventario(INVENTARIOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<INVENTARIOS> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(INVENTARIOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(INVENTARIOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int DesactivarInventario(INVENTARIOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<INVENTARIOS> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<INVENTARIOS> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(INVENTARIOS entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
