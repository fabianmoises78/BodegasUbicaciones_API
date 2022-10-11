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
    public class EmpleadosImplement : EmpleadosDAO
    {
        private readonly ApplicationDBContext context;
        private readonly IConfiguration configuration;
        private readonly string _connectionString;

        public EmpleadosImplement(ApplicationDBContext context, IConfiguration IConfig)
        {
            this.context = context;
            this.configuration = IConfig;
            _connectionString = IConfig.GetConnectionString("GESTIONUBICACIONES");
        }

        public int ActivarEmpleado(EMPLEADOS entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("EMPLEADOS_ACT_DESC", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@EMP_ID", entity.EMP_ID));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@EMP_ACTIVO", entity.EMP_ACTIVO));
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

        public List<EMPLEADOS> Buscar(string data)
        {
            throw new System.NotImplementedException();
        }

        public int create(EMPLEADOS entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("EMPLEADOS_INS", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@EMP_CODIGO", entity.EMP_CODIGO));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@EMP_NOMBRES", entity.EMP_NOMBRES));
                        SqlParameter p3 = cmd.Parameters.Add(new SqlParameter("@EMP_APELLIDOS", entity.EMP_APELLIDOS));
                        SqlParameter p4 = cmd.Parameters.Add(new SqlParameter("@MUN_ID", entity.MUN_ID));
                        SqlParameter p5 = cmd.Parameters.Add(new SqlParameter("@UBI_ID", entity.UBI_ID));
                        SqlParameter p6 = cmd.Parameters.Add(new SqlParameter("@CTGEMP_ID", entity.CTGEMP_ID));
                        SqlParameter p7 = cmd.Parameters.Add(new SqlParameter("@EMP_TELEFONO", entity.EMP_TELEFONO));
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

        public int delete(EMPLEADOS entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("EMPLEADOS_DEL", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@EMP_ID", entity.EMP_ID));
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

        public int DesactivarEmpleado(EMPLEADOS entity)
        {
            throw new System.NotImplementedException();
        }

        public List<EMPLEADOS> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<EMPLEADOS> GetbyID(long Id)
        {
            throw new System.NotImplementedException();
        }

        public int update(EMPLEADOS entity)
        {
            GenericDTO response = new GenericDTO();

            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("EMPLEADOS_UPD", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter p1 = cmd.Parameters.Add(new SqlParameter("@EMP_ID", entity.EMP_ID));
                        SqlParameter p2 = cmd.Parameters.Add(new SqlParameter("@EMP_CODIGO", entity.EMP_CODIGO));
                        SqlParameter p3 = cmd.Parameters.Add(new SqlParameter("@EMP_NOMBRES", entity.EMP_NOMBRES));
                        SqlParameter p4 = cmd.Parameters.Add(new SqlParameter("@EMP_APELLIDOS", entity.EMP_APELLIDOS));
                        SqlParameter p5 = cmd.Parameters.Add(new SqlParameter("@MUN_ID", entity.MUN_ID));
                        SqlParameter p6 = cmd.Parameters.Add(new SqlParameter("@UBI_ID", entity.UBI_ID));
                        SqlParameter p7 = cmd.Parameters.Add(new SqlParameter("@CTGEMP_ID", entity.CTGEMP_ID));
                        SqlParameter p8 = cmd.Parameters.Add(new SqlParameter("@EMP_TELEFONO", entity.EMP_TELEFONO));
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
