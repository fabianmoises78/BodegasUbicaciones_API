using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace API_BodegasUbicaciones.BL.Implements
{
    public class ProveedoresImplement : ProveedoresDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public ProveedoresImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }
        public int ActivarProveedor(PROVEEDORES entity)
        {
            throw new System.NotImplementedException();
        }

        public List<PROVEEDORES> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(PROVEEDORES entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(PROVEEDORES entity)
        {
            throw new System.NotImplementedException();
        }

        public int DesactivarProveedor(PROVEEDORES entity)
        {
            throw new System.NotImplementedException();
        }

        public List<PROVEEDORES> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<PROVEEDORES> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(PROVEEDORES entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
