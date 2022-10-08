using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using API_BodegasUbicaciones.DTO;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace API_BodegasUbicaciones.BL.Implements
{
    public class DocumentoEntradaImplement : DocumentoEntradaDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public DocumentoEntradaImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarDocEntrada(DOCUMENTOENTRADA entity)
        {
            throw new System.NotImplementedException();
        }

        public List<DOCUMENTOENTRADA> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(DOCUMENTOENTRADA entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(DOCUMENTOENTRADA entity)
        {

        }

        public int DesactivarDocEntrada(DOCUMENTOENTRADA entity)
        {
            throw new System.NotImplementedException();
        }

        public List<DOCUMENTOENTRADA> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<DOCUMENTOENTRADA> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(DOCUMENTOENTRADA entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
