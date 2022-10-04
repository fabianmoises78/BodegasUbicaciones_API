using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.Implements
{
    public class TiposMovimientosImplement : TiposMovimientosDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public TiposMovimientosImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarTipoMov(TIPOSMOVIMIENTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<TIPOSMOVIMIENTOS> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(TIPOSMOVIMIENTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(TIPOSMOVIMIENTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int DesactivarTipoMov(TIPOSMOVIMIENTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<TIPOSMOVIMIENTOS> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<TIPOSMOVIMIENTOS> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(TIPOSMOVIMIENTOS entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
