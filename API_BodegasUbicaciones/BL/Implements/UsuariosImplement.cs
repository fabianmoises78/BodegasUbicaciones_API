using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.Implements
{
    public class UsuariosImplement : UsuariosDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public UsuariosImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarUser(USUARIOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<USUARIOS> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(USUARIOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(USUARIOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int DesactivarUser(USUARIOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<USUARIOS> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<USUARIOS> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(USUARIOS entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
