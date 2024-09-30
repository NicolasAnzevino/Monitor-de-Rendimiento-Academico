using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Queja
    {
        public Queja()
        {

        }

        public Queja(int pID, string pAsunto, string pDescripcion, Usuario pUsuario)
        {
            ID = pID;
            Activo = true;
            Asunto = pAsunto;
            Descripcion = pDescripcion;
            Estados = new List<Seguimiento_Queja>();
            Usuario = pUsuario;
        }

        public Queja(int pID, string pAsunto, string pDescripcion, DateTime pFecha)
        {
            ID = pID;
            Activo = true;
            Asunto = pAsunto;
            Descripcion = pDescripcion;
            Fecha = pFecha;
            Estados = new List<Seguimiento_Queja>();
        }
        public Queja(int pID, string pAsunto, string pDescripcion, DateTime pFecha, bool pActivo)
        {
            ID = pID;
            Activo = pActivo;
            Fecha = pFecha;
            Asunto = pAsunto;
            Descripcion = pDescripcion;
            Estados = new List<Seguimiento_Queja>();
        }

        public Queja(string pAsunto, string pDescripcion, int pIDUsuario) //pa crear
        {
            Activo = true;
            Asunto = pAsunto;
            Descripcion = pDescripcion;
            Fecha = DateTime.Today;
            Estados = new List<Seguimiento_Queja>();
            IDUsuario = pIDUsuario;
        }
        public Queja(string pAsunto, string pDescripcion, DateTime pFecha, int pIDUsuario) //pa crear
        {
            Activo = true;
            Asunto = pAsunto;
            Descripcion = pDescripcion;
            Fecha = pFecha;
            Estados = new List<Seguimiento_Queja>();
            IDUsuario = pIDUsuario;
        }

        public Queja(int pID, string pAsunto, string pDescripcion, bool pActivo)
        {
            ID = pID;
            Activo = pActivo;
            Asunto = pAsunto;
            Descripcion = pDescripcion;
            Estados = new List<Seguimiento_Queja>();
        }

        public Queja(object[] pO)
        {
            ID = (int)pO[0];
            Activo = (bool)pO[1];
            Asunto = (string)pO[2];
            Descripcion = (string)pO[3];

            Estados = new List<Seguimiento_Queja>();
            Usuario = new Usuario();            
        }

        public int ID { get; set; }
        private bool Activo { get; set; }
        public string Asunto { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public List<Seguimiento_Queja> Estados { get; set; }
        public Usuario Usuario { get; set; }

        private int IDUsuario { get; set; }
       
        public int Retornar_IDUsuario()
        {
            return this.IDUsuario;
        }

        public bool Retornar_Activo()
        {
            return this.Activo;
        }
    }
}
