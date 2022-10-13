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
    public class UbicacionesImplement : UbicacionesDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public UbicacionesImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarUbicaciones(UBICACIONES entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("UBICACIONES_ACT_DESC", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@UBI_ID", entity.UBI_ID));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@UBI_ACTIVA", entity.UBI_ACTIVA));
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

        public List<UBICACIONES> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(UBICACIONES entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("UBICACIONES_INS", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@UBI_CODIGO", entity.UBI_CODIGO));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@UBI_NOMBRE", entity.UBI_NOMBRE));
                        SqlParameter p3 = cmd.Parameters.Add(new SqlParameter("@MUN_ID", entity.MUN_ID));
                        SqlParameter p4 = cmd.Parameters.Add(new SqlParameter("@UBI_DIRECCION", entity.UBI_DIRECCION));
                        SqlParameter p5 = cmd.Parameters.Add(new SqlParameter("@UBI_ESPRINCIPAL", entity.UBI_ESPRINCIPAL));
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

        public int delete(UBICACIONES entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("UBICACIONES_DEL", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@UBI_ID", entity.UBI_ID));
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

        public int DesactivarUbicaciones(UBICACIONES entity)
        {
            throw new System.NotImplementedException();
        }

        public List<UBICACIONES> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<UBICACIONES> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(UBICACIONES entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("UBICACIONES_UPD", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p0 = cmd.Parameters.Add(new SqlParameter("@UBI_ID", entity.UBI_ID));
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@UBI_CODIGO", entity.UBI_CODIGO));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@UBI_NOMBRE", entity.UBI_NOMBRE));
                        SqlParameter p3 = cmd.Parameters.Add(new SqlParameter("@MUN_ID", entity.MUN_ID));
                        SqlParameter p4 = cmd.Parameters.Add(new SqlParameter("@UBI_DIRECCION", entity.UBI_DIRECCION));
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
    }
}
