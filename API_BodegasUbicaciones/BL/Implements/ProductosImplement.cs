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
    public class ProductosImplement : ProductosDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public ProductosImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarProd(PRODUCTOS entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("PRODUCTOS_ACT_DESC", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@PRD_ID", entity.PRD_ID));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@PRD_ACTIVO", entity.PRD_ACTIVO));
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

        public List<PRODUCTOS> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(PRODUCTOS entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("PRODUCTOS_INS", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@PRD_CODIGO", entity.PRD_CODIGO));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@PRD_NOMBRE", entity.PRD_NOMBRE));
                        SqlParameter p3 = cmd.Parameters.Add(new SqlParameter("@CTGPRD_ID", entity.CTGPRD_ID));
                        SqlParameter p4 = cmd.Parameters.Add(new SqlParameter("@MARC_ID", entity.MARC_ID));
                        SqlParameter p5 = cmd.Parameters.Add(new SqlParameter("@PRD_PRECIOVENTA", entity.PRD_PRECIOVENTA));
                        SqlParameter p6 = cmd.Parameters.Add(new SqlParameter("@PRD_URLIMG", entity.PRD_URLIMG));
                        SqlParameter p7 = cmd.Parameters.Add(new SqlParameter("@PRD_PRCGANC", entity.PRD_PRCGANC));
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

        public int delete(PRODUCTOS entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("PRODUCTOS_DEL", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@PRD_ID", entity.PRD_ID));
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

        public int DesactivarProd(PRODUCTOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<PRODUCTOS> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<PRODUCTOS> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(PRODUCTOS entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("PRODUCTOS_UPD", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@PRD_ID", entity.PRD_ID));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@PRD_CODIGO", entity.PRD_CODIGO));
                        SqlParameter p3 = cmd.Parameters.Add(new SqlParameter("@PRD_NOMBRE", entity.PRD_NOMBRE));
                        SqlParameter p4 = cmd.Parameters.Add(new SqlParameter("@CTGPRD_ID", entity.CTGPRD_ID));
                        SqlParameter p5 = cmd.Parameters.Add(new SqlParameter("@MARC_ID", entity.MARC_ID));
                        SqlParameter p6 = cmd.Parameters.Add(new SqlParameter("@PRD_PRECIOVENTA", entity.PRD_PRECIOVENTA));
                        SqlParameter p7 = cmd.Parameters.Add(new SqlParameter("@PRD_URLIMG", entity.PRD_URLIMG));
                        SqlParameter p8 = cmd.Parameters.Add(new SqlParameter("@PRD_PRCGANC", entity.PRD_PRCGANC));
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
