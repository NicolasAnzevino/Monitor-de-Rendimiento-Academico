using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inasistencia
    {
        public Inasistencia()
        {

        }
        public Inasistencia(int pCodigo, DateTime pFecha, string pDescripcion, decimal pValor, string pJustificacion)
        {
            Codigo = pCodigo;
            Fecha = pFecha;
            Descripcion = pDescripcion;
            Valor = pValor;
            Justificacion = pJustificacion;
        }
        public Inasistencia(DateTime pFecha, string pDescripcion, decimal pValor, string pJustificacion)
        {
            Fecha = pFecha;
            Descripcion = pDescripcion;
            Valor = pValor;
            Justificacion = pJustificacion;
        }

        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; }
        public string Justificacion { get; set; }
    }
}
