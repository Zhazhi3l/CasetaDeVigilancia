﻿using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CasetaDeVigilancia.src.Datos
{
    public static class DbHelper
    {
        private static readonly string _connString =
            ConfigurationManager.ConnectionStrings["FraccionamientoConnection"].ConnectionString;

        // Crea la conexión con la BD.
        public static SqlConnection GetConnection()
        {
            var conn = new SqlConnection(_connString);
            conn.Open();
            return conn;
        }

        // Ejecuta el Select y devuelve un DataTabel, se puede usar con DataGrid
        public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
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


        // Insert/Update
        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
        }
    }
}
