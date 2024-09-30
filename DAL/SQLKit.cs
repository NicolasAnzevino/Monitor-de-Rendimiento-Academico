using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Entidades;

namespace DAL
{
    public abstract class SQLKit
    {
        protected SqlConnection Conexion;
        protected SqlCommand Comando;
        protected string NombreServidor;

        public SQLKit()
        {
            NombreServidor = File.ReadAllText("ServerName.txt");
            //Conexion = new SqlConnection("Data Source=DESKTOP-ICCJCO5;Initial Catalog=Monitor de Rendimiento Academico;Integrated Security=True");
            Conexion = new SqlConnection("Data Source="+NombreServidor+";Initial Catalog=Monitor de Rendimiento Academico;Integrated Security=True");
            //Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Monitor de Rendimiento Academico"].ConnectionString);
            Comando = new SqlCommand("", Conexion);
        }

        public void Conectarse()
        {
            try
            {
                Conexion.Open();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }            
        }

        
        public void Desconectarse()
        {
            try
            {
                Conexion.Close();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }            
        }
    }
}
