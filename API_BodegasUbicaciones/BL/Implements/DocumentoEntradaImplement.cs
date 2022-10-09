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
    public class DocumentoEntradaImplement : DocumentoEntradaDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public DocumentoEntradaImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarDocEntrada(DOCUMENTOENTRADA entity)
        {
            throw new System.NotImplementedException();
        }

        public List<DOCUMENTOENTRADA> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(DOCUMENTOENTRADA entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DOC_ENTRADA_INS", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@DCME_CODIGO", entity.DCME_CODIGO));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@EMP_ID", entity.EMP_ID));
                        SqlParameter p3 = cmd.Parameters.Add(new SqlParameter("@PRV_ID", entity.PRV_ID));
                        SqlParameter p4 = cmd.Parameters.Add(new SqlParameter("@UBI_IDENTRADA", entity.UBI_IDENTRADA));
                        SqlParameter p5 = cmd.Parameters.Add(new SqlParameter("@UBI_IDSALIDA", entity.UBI_IDSALIDA));
                        SqlParameter p6 = cmd.Parameters.Add(new SqlParameter("@DCME_CONCEPTO", entity.DCME_CONCEPTO));
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

        public int delete(DOCUMENTOENTRADA entity)
        {
            throw new System.NotImplementedException();
        }

        public int DesactivarDocEntrada(DOCUMENTOENTRADA entity)
        {
            throw new System.NotImplementedException();
        }

        /*
            Este Implement recibe un ID para poder cambair de estado en la tabla de documentos de entrada
         */
        public int DocEntrada_Finalizado(DOCUMENTOENTRADA entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DOC_ENTRADA_FINALIZAR", sql))
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

        public List<DOCUMENTOENTRADA> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<DOCUMENTOENTRADA> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(DOCUMENTOENTRADA entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DOC_ENTRADA_UPD", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@DCME_ID INT", entity.DCME_ID));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@DCME_CODIGO", entity.DCME_CODIGO));
                        SqlParameter p3 = cmd.Parameters.Add(new SqlParameter("@EMP_ID", entity.EMP_ID));
                        SqlParameter p4 = cmd.Parameters.Add(new SqlParameter("@PRV_ID", entity.PRV_ID));
                        SqlParameter p5 = cmd.Parameters.Add(new SqlParameter("@DCME_CONCEPTO", entity.DCME_CONCEPTO));
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
