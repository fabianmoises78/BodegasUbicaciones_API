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
    public class UsuariosImplement : UsuariosDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public UsuariosImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarUser(USUARIOS entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("USUARIOS_ACT_DESC", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@USR_ID", entity.USR_ID));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@USR_ACTIVO", entity.USR_ACTIVO));
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

        public List<USUARIOS> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(USUARIOS entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("USUARIOS_INS", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@USR_EMAIL", entity.USR_EMAIL));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@USR_USRACCESO", entity.USR_USRACCESO));
                        SqlParameter p3 = cmd.Parameters.Add(new SqlParameter("@USR_PASSWRD", entity.USR_PASSWORD));
                        SqlParameter p4 = cmd.Parameters.Add(new SqlParameter("@EMP_ID", entity.EMP_ID));
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

        public int delete(USUARIOS entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("USUARIOS_DEL", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@USR_ID", entity.USR_ID));
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

        public int DesactivarUser(USUARIOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<USUARIOS> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<USUARIOS> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(USUARIOS entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("USUARIOS_UPD", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p0 = cmd.Parameters.Add(new SqlParameter("@USR_ID", entity.USR_ID));
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@USR_EMAIL", entity.USR_EMAIL));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@USR_USRACCESO", entity.USR_USRACCESO));
                        SqlParameter p3 = cmd.Parameters.Add(new SqlParameter("@USR_PASSWRD", entity.USR_PASSWORD));
                        SqlParameter p4 = cmd.Parameters.Add(new SqlParameter("@EMP_ID", entity.EMP_ID));
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
