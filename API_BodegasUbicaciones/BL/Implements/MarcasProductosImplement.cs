using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.Implements
{
    public class MarcasProductosImplement : MarcasProductosDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public MarcasProductosImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarMarProductos(MARCASPRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<MARCASPRODUCTOS> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(MARCASPRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(MARCASPRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int DesactivarMarProductos(MARCASPRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<MARCASPRODUCTOS> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<MARCASPRODUCTOS> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(MARCASPRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
