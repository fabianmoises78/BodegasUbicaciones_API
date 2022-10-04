using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.Implements
{
    public class EmpleadosImplement : EmpleadosDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public EmpleadosImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarEmpleado(EMPLEADOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<EMPLEADOS> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(EMPLEADOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(EMPLEADOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int DesactivarEmpleado(EMPLEADOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<EMPLEADOS> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<EMPLEADOS> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(EMPLEADOS entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
