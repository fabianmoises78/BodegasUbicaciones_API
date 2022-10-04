using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.Implements
{
    public class ProductosImplement : ProductosDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public ProductosImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarProd(PRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<PRODUCTOS> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(PRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(PRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int DesactivarProd(PRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<PRODUCTOS> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<PRODUCTOS> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(PRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
