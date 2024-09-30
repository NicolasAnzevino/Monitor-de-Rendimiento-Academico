using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using Entidades;
using DAL;

namespace Servicios
{
    public class DatabaseCreatorManager
    {
        public static bool VerificarExistenciaBD()
        {
            try
            {
                DAL_DatabaseCreator DAL_DatabaseCreator = new DAL_DatabaseCreator();
                return DAL_DatabaseCreator.VerificarExistenciaBD();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public static void CrearBD()
        {
            try
            {
                DAL_DatabaseCreator DAL_DatabaseCreator = new DAL_DatabaseCreator();
                DAL_DatabaseCreator.CrearBD();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }        
        
        public static DataTable ObtenerServidores()
        {
            try
            {
                return DAL_DatabaseCreator.ObtenerServidores();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
  
        public static bool VerificarExistenciaArchivo()
        {
            try
            {
                bool Existe = false;

                FileStream FS = new FileStream("ServerName.txt", FileMode.Open, FileAccess.Read);
              
                if (FS.Length != 0)
                {
                    Existe = true;
                }

                FS.Close();

                return Existe;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
