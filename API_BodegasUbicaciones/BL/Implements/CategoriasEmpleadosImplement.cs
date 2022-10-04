using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.Implements
{
    public class CategoriasEmpleadosImplement : CategoriasEmpleadosDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public CategoriasEmpleadosImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarCatEmple(CATEGORIASEMPLEADOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<CATEGORIASEMPLEADOS> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(CATEGORIASEMPLEADOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(CATEGORIASEMPLEADOS entity)
        {
            throw new System.NotImplementedException();
        }

        public int DesacCatEmple(CATEGORIASEMPLEADOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<CATEGORIASEMPLEADOS> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<CATEGORIASEMPLEADOS> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(CATEGORIASEMPLEADOS entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
