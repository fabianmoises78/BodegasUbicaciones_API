using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.Implements
{
    public class CategoriaProductosImplement : CategoriaProductosDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public CategoriaProductosImplement(ApplicationDBContext context, IConfiguration iConfig)
        {
            this.context = context;
            this.configuration = iConfig;
            _connectionString = iConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarCatProd(CATEGORIAPRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<CATEGORIAPRODUCTOS> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(CATEGORIAPRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(CATEGORIAPRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int DesactivarCatProd(CATEGORIAPRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<CATEGORIAPRODUCTOS> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<CATEGORIAPRODUCTOS> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(CATEGORIAPRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
