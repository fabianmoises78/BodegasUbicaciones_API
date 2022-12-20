using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Models;
using API_BodegasUbicaciones.BL.Models.ModelSP;
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

        public List<PRODUCTO_RESULT> AllGet()
        {
            List<PRODUCTO_RESULT> ListPRD = new List<PRODUCTO_RESULT>();

            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PRODUCTOS_lIST", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sql.Open();

                    using (var prd = cmd.ExecuteReader())
                    {
                        if (prd.FieldCount > 0)
                        {
                            while (prd.Read())
                            {
                                PRODUCTO_RESULT prd_result = new PRODUCTO_RESULT()
                                {
                                    PRD_ID = Convert.ToInt32(prd["PRD_ID"]),
                                    PRD_CODIGO = prd["PRD_CODIGO"].ToString(),
                                    PRD_NOMBRE = prd["PRD_NOMBRE"].ToString(),
                                    CTGPRD_ID = Convert.ToInt32(prd["CTGPRD_ID"]),
                                    CTGPRD_NOMBRE = prd["CTGPRD_NOMBRE"].ToString(),
                                    MARC_ID = Convert.ToInt32(prd["MARC_ID"]),
                                    MARC_NOMBRE = prd["MARC_NOMBRE"].ToString(),
                                    PRD_PRECIOVENTA = Convert.ToDouble(prd["PRD_PRECIOVENTA"]),
                                    PRD_COSTO = Convert.ToDouble(prd["PRD_COSTO"]),
                                    PRD_URLIMG = prd["PRD_URLIMG"].ToString(),
                                    PRD_PRCGANC = Convert.ToDouble(prd["PRD_PRCGANC"]),
                                    PRD_ACTIVO = Convert.ToBoolean(prd["PRD_ACTIVO"])
                                };
                                ListPRD.Add(prd_result);
                            }
                        }
                    }
                }
            }
            return ListPRD;
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
