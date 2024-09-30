using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace Servicios
{
    public class BackupRestoreManager
    {
        public static void RealizarBackup(string pPath)
        {
            try
            {
                DAL_BackupRestore DAL_BR = new DAL_BackupRestore();
                DAL_BR.RealizarBackup(pPath);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }            
        }

        public static void RealizarRestore(string pRuta)
        {
            try
            {
                DAL_BackupRestore DAL_BR = new DAL_BackupRestore();
                DAL_BR.RealizarRestore(pRuta);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }            
        }
    }
}
