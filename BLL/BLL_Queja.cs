using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Servicios;
using Mapeador;

namespace BLL
{
    public class BLL_Queja
    {
        MAP_Queja MAP_Queja;
        MAP_Seguimiento_Queja MAP_Seguimiento_Queja;

        public BLL_Queja()
        {
            MAP_Queja = new MAP_Queja();
            MAP_Seguimiento_Queja = new MAP_Seguimiento_Queja();
        }

        public void Crear_Queja(string pAsunto, string pDescripcion, int pUsuarioID)
        {
            try
            {
                Queja Queja = new Queja(pAsunto, pDescripcion, pUsuarioID);

                MAP_Queja.Crear_Queja(Queja);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Actualizar_Estado_Queja(int pID)
        {
            try
            {
                MAP_Queja.Actualizar_Estado_Queja(pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Queja> Ver_Quejas_Usuario(int pID)
        {
            try
            {
                return MAP_Queja.Ver_Quejas_Usuario(pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Queja> Ver_Quejas_Activas()
        {
            try
            {
                return MAP_Queja.Ver_Quejas_Activas();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Seguimiento_Queja> Ver_Seguimiento_de_Queja(int pID)
        {
            try
            {
                return MAP_Seguimiento_Queja.Ver_Seguimiento_de_Queja(pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Agregar_Seguimiento(int pID, string pRespuesta, DateTime pFecha)
        {
            try
            {
                Seguimiento_Queja SQ = new Seguimiento_Queja(pRespuesta, pFecha);

                MAP_Seguimiento_Queja.Agregar_Seguimiento(pID, SQ);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }


    }
}
