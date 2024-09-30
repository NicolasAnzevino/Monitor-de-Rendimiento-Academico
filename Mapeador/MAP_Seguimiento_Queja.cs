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
    public class MAP_Seguimiento_Queja
    {
        DAL_Seguimiento_Queja DAL_Seguimiento_Queja;

        public MAP_Seguimiento_Queja()
        {
            DAL_Seguimiento_Queja = new DAL_Seguimiento_Queja();
        }

        public void Agregar_Seguimiento(int pID, Seguimiento_Queja pSeguimiento_Queja)
        {
            try
            {
               DAL_Seguimiento_Queja.Agregar_Seguimiento(pID, pSeguimiento_Queja);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }           
        }

        public List<Seguimiento_Queja> Ver_Seguimiento_de_Queja(int pID)
        {
            DataTable DT = DAL_Seguimiento_Queja.Ver_Seguimiento_de_Queja(pID);
            List<Seguimiento_Queja> LQ = new List<Seguimiento_Queja>();

            foreach (DataRow DR in DT.Rows)
            {
                LQ.Add(new Seguimiento_Queja(DR.Field<string>(0), DR.Field<DateTime>(1)));
            }

            return LQ;
        }

    }
}
