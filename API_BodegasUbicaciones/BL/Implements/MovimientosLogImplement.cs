using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.Implements
{
    public class MovimientosLogImplement : MovimientosLogDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public MovimientosLogImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarMov(MOVIMIENTOSLOG entity)
        {
            throw new System.NotImplementedException();
        }

        public List<MOVIMIENTOSLOG> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(MOVIMIENTOSLOG entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(MOVIMIENTOSLOG entity)
        {
            throw new System.NotImplementedException();
        }

        public int desactivarMov(MOVIMIENTOSLOG entity)
        {
            throw new System.NotImplementedException();
        }

        public List<MOVIMIENTOSLOG> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<MOVIMIENTOSLOG> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(MOVIMIENTOSLOG entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
