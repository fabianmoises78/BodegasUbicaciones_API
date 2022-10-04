using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.Implements
{
    public class TiposDocumentosImplement : TiposDocumentosDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public TiposDocumentosImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarTipoDoc(TIPOSDOCUMENTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<TIPOSDOCUMENTOS> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(TIPOSDOCUMENTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(TIPOSDOCUMENTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int DesactivarTipoDoc(TIPOSDOCUMENTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<TIPOSDOCUMENTOS> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<TIPOSDOCUMENTOS> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(TIPOSDOCUMENTOS entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
