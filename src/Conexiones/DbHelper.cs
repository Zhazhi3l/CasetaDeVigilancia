using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CasetaDeVigilancia.src.Datos
{
    public static class DbHelper
    {
        private static readonly string _connString =
            "Server = tcp:servidorpruebas-sql.database.windows.net,1433;Initial Catalog = CasetaDeVigilanciaBD; Persist Security Info=False;User ID = JuanPerez; Password=root12345$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";

        // Crea la conexión con la BD.
        public static SqlConnection GetConnection()
        {
            try
            {
                var conn = new SqlConnection(_connString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al abrir la conexión con la base de datos.", ex);
            }
        }

        // Ejecuta el Select y devuelve un DataTable, se puede usar con DataGrid
        public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la consulta SELECT.", ex);
            }
        }

        // Insert/Update
        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la consulta INSERT/UPDATE/DELETE.", ex);
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la consulta ESCALAR.", ex);
            }
        }
    }
}
