using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.Implements
{
    public class DepartamentosImplement : DepartamentosDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public DepartamentosImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarDepartamentos(DEPARTAMENTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<DEPARTAMENTOS> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(DEPARTAMENTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(DEPARTAMENTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int DesacDepartamentos(DEPARTAMENTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<DEPARTAMENTOS> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<DEPARTAMENTOS> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(DEPARTAMENTOS entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
