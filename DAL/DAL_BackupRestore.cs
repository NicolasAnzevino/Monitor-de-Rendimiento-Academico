using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using Entidades;

namespace DAL
{
    public class DAL_BackupRestore : SQLKit
    {
        public DAL_BackupRestore() : base()
        {

        }
        
        public void RealizarBackup(string pPath)
        {
            try
            {
                Conectarse();

                string pFecha = DateTime.Today.ToString("dd-MM-yyyy");

                string path = pPath;

                Comando.CommandText = $@"BACKUP DATABASE [Monitor de Rendimiento Academico] TO  DISK = N'{path}\Monitor de Rendimiento Academico {pFecha}.bak' WITH NOFORMAT, NOINIT,  NAME = N'Monitor de Rendimiento Academico-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                //Comando.CommandText = $@"BACKUP DATABASE [Monitor de Rendimiento Academico] TO  DISK = N'D:\SQL Server 2019\MSSQL15.MSSQLSERVER\MSSQL\Backup\Monitor de Rendimiento Academico.bak' WITH NOFORMAT, NOINIT,  NAME = N'Monitor de Rendimiento Academico-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
                Comando.Parameters.Clear();

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public void RealizarRestore(string pRuta)
        {
            try
            {
                Conectarse();

                string pFecha = DateTime.Today.ToString("dd-MM-yyyy HH-mm-ss");

                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                Comando.CommandText = $@"USE [master]  ALTER DATABASE [Monitor de Rendimiento Academico] SET SINGLE_USER WITH ROLLBACK IMMEDIATE BACKUP LOG [Monitor de Rendimiento Academico] TO  DISK = N'{path}\Monitor de Rendimiento Academico_LogBackup_{pFecha}.bak' WITH NOFORMAT, NOINIT,  NAME = N'Monitor de Rendimiento Academico_LogBackup_{pFecha}', NOSKIP, NOREWIND, NOUNLOAD,  NORECOVERY ,  STATS = 5 RESTORE DATABASE [Monitor de Rendimiento Academico] FROM  DISK = N'{pRuta}' WITH  FILE = 1,  NOUNLOAD,  STATS = 5 ALTER DATABASE [Monitor de Rendimiento Academico] SET MULTI_USER";
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }


    }
}
