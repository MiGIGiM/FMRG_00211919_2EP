using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.Controlador
{
    public static class ConnectionDB
    {
        private static string cadenaC = "Server=127.0.0.1;" +
                                        "Port=5432;" +
                                        "User Id=postgres;" +
                                        "Password=123456;" +
                                        "Database=Parcial;";


        public static DataTable EjecutarConsulta(string consulta)
        {
            var conn = new NpgsqlConnection(cadenaC);
            var ds = new DataSet();

            conn.Open();
            var da = new NpgsqlDataAdapter(consulta, conn);
            da.Fill(ds);
            conn.Close();

            return ds.Tables[0];
        }

        public static void EjecutarComando(string comando)
        {
            var conn = new NpgsqlConnection(cadenaC);

            conn.Open();
            var comm = new NpgsqlCommand(comando, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}
