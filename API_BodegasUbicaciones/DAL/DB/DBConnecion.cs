using System.Data.SqlClient;

namespace API_BodegasUbicaciones.DAL.DB
{
    public class DBConnecion
    {
        private static DBConnecion objConnection;
        private SqlConnection sqlConnection;

        private DBConnecion()
        {
            sqlConnection = new SqlConnection("Data Source=DESKTOP-36990T1\\MSSQLSERVER2019;Initial Catalog=GESTIONUBICACIONES;Integrated Security=True");
        }

        public static DBConnecion CreateConnection()
        {
            if (objConnection == null)
            {
                objConnection = new DBConnecion();
            }
            return objConnection;
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }

        public void CloseConnectio()
        {
            objConnection = null;
        }
    }
}
