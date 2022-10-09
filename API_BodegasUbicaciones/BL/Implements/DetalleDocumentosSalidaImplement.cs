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
    public class DetalleDocumentosSalidaImplement : DetalleDocumentoSalidaDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public DetalleDocumentosSalidaImplement(ApplicationDBContext context, IConfiguration iConfig)
        {
            this.context = context;
            this.configuration = iConfig;
            _connectionString = iConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarDetDocSalida(DETALLEDOCUMENTOSALIDA entity)
        {
            throw new System.NotImplementedException();
        }

        public List<DETALLEDOCUMENTOSALIDA> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(DETALLEDOCUMENTOSALIDA entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DET_DOC_SALIDA_INS", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@DCMS_ID", entity.DCMS_ID));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@PRD_ID", entity.PRD_ID));
                        SqlParameter p3 = cmd.Parameters.Add(new SqlParameter("@DTDS_CANTIDAD", entity.DTDS_CANTIDAD));
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

        public int delete(DETALLEDOCUMENTOSALIDA entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DET_DOC_SALIDA_DEL", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter sqlparameter1 = cmd.Parameters.Add(new SqlParameter("@DTDS_ID", entity.DTDS_ID));
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

        public int DesactivarDetDocSalida(DETALLEDOCUMENTOSALIDA entity)
        {
            throw new System.NotImplementedException();
        }

        public List<DETALLEDOCUMENTOSALIDA> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<DETALLEDOCUMENTOSALIDA> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(DETALLEDOCUMENTOSALIDA entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DET_DOC_SALIDA_UPD", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@DTDS_ID", entity.DTDS_ID));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@DCMS_ID", entity.DCMS_ID));
                        SqlParameter p3 = cmd.Parameters.Add(new SqlParameter("@PRD_ID", entity.PRD_ID));
                        SqlParameter p4 = cmd.Parameters.Add(new SqlParameter("@DTDS_CANTIDAD", entity.DTDS_CANTIDAD));
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
