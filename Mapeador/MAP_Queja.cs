using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Entidades;
using Servicios;
using DAL;

namespace Mapeador
{
    public class MAP_Queja
    {
        DAL_Queja DAL_Queja;

        public MAP_Queja()
        {
            DAL_Queja = new DAL_Queja();
        }

        public void Crear_Queja(Queja pQueja)
        {
            try
            {
                DAL_Queja.Crear_Queja(pQueja);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }            
        }

        public void Actualizar_Estado_Queja(int pID)
        {
            try
            {
                DAL_Queja.Actualizar_Estado_Queja(pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Queja> Ver_Quejas_Usuario(int pID)
        {
            try
            {
                List<Queja> LQ = new List<Queja>();

                DataTable DT = DAL_Queja.Ver_Quejas_Usuario(pID);

                foreach (DataRow DR in DT.Rows)
                {
                    LQ.Add(new Queja(DR.Field<int>(0), DR.Field<string>(1), DR.Field<string>(2), DR.Field<DateTime>(3), DR.Field<bool>(4)));                    
                }

                return LQ;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Queja> Ver_Quejas_Activas()
        {
            try
            {
                List<Queja> LQ = new List<Queja>();

                DataTable DT = DAL_Queja.Ver_Quejas_Activas();

                foreach (DataRow DR in DT.Rows)
                {
                    Queja Q = new Queja(DR.Field<int>(0), DR.Field<string>(1), DR.Field<string>(2), DR.Field<DateTime>(3));
                    Q.Usuario = new Usuario(); Q.Usuario.Nombre = DR.Field<string>(5); Q.Usuario.NombreReal = DR.Field<string>(6); Q.Usuario.Apellido = DR.Field<string>(7); Q.Usuario.DNI = DR.Field<int>(8);
                    LQ.Add(Q);
                }

                return LQ;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
