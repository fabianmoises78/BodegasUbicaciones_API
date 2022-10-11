using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.DAL;
using API_BodegasUbicaciones.DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("PROVEEDORES_ACT_DESC", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@PRV_ID", entity.PRV_ID));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@PRV_ACTIVO", entity.PRV_ACTIVO));
                        sql.Open();
                        cmd.ExecuteReader();
                        sql.Close();
                    }
                }
                return response.Status = 1;
            }
            catch (Exception)
            {
                return response.Status = 0;
            }
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
