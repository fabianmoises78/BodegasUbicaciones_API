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
    public class DetalleDocumentoEntradaImplement : DetalleDocumentoEntradaDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public DetalleDocumentoEntradaImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarDetDocEntrada(DETALLEDOCUMENTOENTRADA entity)
        {
            throw new System.NotImplementedException();
        }

        public List<DETALLEDOCUMENTOENTRADA> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(DETALLEDOCUMENTOENTRADA entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DET_DOC_ENTRADA_INS", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter sqlparameter1 = cmd.Parameters.Add(new SqlParameter("@DCME_ID", entity.DCME_ID));
                        SqlParameter sqlparameter2 = cmd.Parameters.Add(new SqlParameter("@PRD_ID", entity.PRD_ID));
                        SqlParameter sqlparameter3 = cmd.Parameters.Add(new SqlParameter("@DTDE_CANTIDAD", entity.DTDE_CANTIDAD));
                        SqlParameter sqlparameter4 = cmd.Parameters.Add(new SqlParameter("@DTDE_PRECIOUNITARIO", entity.DTDE_PRECIOUNITARIO));
                        SqlParameter sqlparameter5 = cmd.Parameters.Add(new SqlParameter("@DTDE_DESCUENTO", entity.DTDE_DESCUENTO));
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

        public int delete(DETALLEDOCUMENTOENTRADA entity)
        {

            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DET_DOC_ENTRADA_DEL", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter sqlparameter = cmd.Parameters.Add(new SqlParameter("@DTDE_ID", entity.DTDE_ID));

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

        public int DeleteDocEntradaAll(DETALLEDOCUMENTOENTRADA entity) //Este Implement recibe un ID para borrar un registro de dos tablas en la base de datos
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DOC_ENTRADA_DEL_ALL", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@DCME_ID", entity.DCME_ID));
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

        public int DesactivarDetDocEntrada(DETALLEDOCUMENTOENTRADA entity)
        {
            throw new System.NotImplementedException();
        }

        public List<DETALLEDOCUMENTOENTRADA> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<DETALLEDOCUMENTOENTRADA> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(DETALLEDOCUMENTOENTRADA entity)
        {
            GenericDTO responde = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DET_DOC_ENTRADA_UPD", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter sqlparameter1 = cmd.Parameters.Add(new SqlParameter("@DCME_ID", entity.DCME_ID));
                        SqlParameter sqlparameter2 = cmd.Parameters.Add(new SqlParameter("@DTDE_ID", entity.DTDE_ID));
                        SqlParameter sqlparameter3 = cmd.Parameters.Add(new SqlParameter("@PRD_ID", entity.PRD_ID));
                        SqlParameter sqlparameter4 = cmd.Parameters.Add(new SqlParameter("@DTDE_CANTIDAD", entity.DTDE_CANTIDAD));
                        SqlParameter sqlparameter5 = cmd.Parameters.Add(new SqlParameter("@DTDE_PRECIOUNITARIO", entity.DTDE_PRECIOUNITARIO));
                        SqlParameter sqlparameter6 = cmd.Parameters.Add(new SqlParameter("@DTDE_DESCUENTO", entity.DTDE_DESCUENTO));
                        sql.Open();
                        cmd.ExecuteReader();
                        sql.Close();
                    }
                }
                return responde.Status = 1;
            }
            catch (Exception)
            {
                return responde.Status = 0;
            }
        }
    }
}
