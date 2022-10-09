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
    public class DocumentoSalidaImplement : DocumentoSalidaDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public DocumentoSalidaImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }
        public int ActivarDocSalida(DOCUMENTOSALIDA entity)
        {
            throw new System.NotImplementedException();
        }

        public List<DOCUMENTOSALIDA> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(DOCUMENTOSALIDA entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(DOCUMENTOSALIDA entity)
        {
            throw new System.NotImplementedException();
        }

        public int DesactivarDocSalida(DOCUMENTOSALIDA entity)
        {
            throw new System.NotImplementedException();
        }

        public int DocSalida_Anular(DOCUMENTOSALIDA entity) //Este Implement es donde recibe un ID para anular un documento de salida
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DOC_SALIDA_ANULAR", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@DCMS_ID", entity.DCMS_ID));
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

        /*
            Este implement recibe 1 solo ID para poder desactivar 2 tablas en el mismo SP de la base de datos
         */
        public int DocSalida_Del_All(DOCUMENTOSALIDA entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DOC_SALIDA_DEL_ALL", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@DCMS_ID", entity.DCMS_ID));
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

        public int DocSalida_Finalizar(DOCUMENTOSALIDA entity)
        {
            throw new NotImplementedException();
        }

        public List<DOCUMENTOSALIDA> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<DOCUMENTOSALIDA> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(DOCUMENTOSALIDA entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
