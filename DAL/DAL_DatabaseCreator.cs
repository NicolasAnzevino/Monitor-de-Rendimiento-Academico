using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System.IO;
using Entidades;

namespace DAL
{
    public class DAL_DatabaseCreator : SQLKit
    {
        public DAL_DatabaseCreator() : base()
        {

        }

        public bool VerificarExistenciaBD()
        {
            bool B = false; //FALSE -> NO ||TRUE -> SÍ
            SqlConnection LocalConexion = new SqlConnection("Data Source=" + NombreServidor + ";Integrated Security=True");
            SqlCommand LocalComando = new SqlCommand("", LocalConexion);

            try
            {
                LocalConexion.Open();
                LocalComando.CommandText = "SELECT COUNT(name) FROM master.sys.databases WHERE name = N'Monitor de Rendimiento Academico'";

                if ((int)LocalComando.ExecuteScalar() == 1)
                {
                    B = true;
                }

                LocalConexion.Close();

                return B;
            }
            catch (Exception ex) { LocalConexion.Close(); throw new Exception(ex.Message); }
        }

        public static void CrearBD()
        {
            string NombreServidor = File.ReadAllText("ServerName.txt");
            SqlConnection LocalConexion = new SqlConnection("Data Source=" + NombreServidor + ";Integrated Security=True");
            SqlCommand LocalComando = new SqlCommand("", LocalConexion);
            try
            {
                LocalConexion.Open();

                string ContenidoDeScript = File.ReadAllText("ScriptMonitorDeRendimientoAcademico.sql");
                string[] ConsultasSQL = ContenidoDeScript.Split(new string[] { "GO\r\n", "GO ", "GO\t", "\r\nGO" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string Consulta in ConsultasSQL)
                {
                    LocalComando.CommandText = Consulta;
                    LocalComando.ExecuteNonQuery();
                }
                LocalConexion.Close();
            }
            catch (Exception ex) { LocalConexion.Close(); throw new Exception(ex.Message); }
        }
        public static DataTable ObtenerServidores()
        {
            try
            {
                System.Data.Sql.SqlDataSourceEnumerator instance = System.Data.Sql.SqlDataSourceEnumerator.Instance;
                return instance.GetDataSources();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

    }
}
