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
    public class BLL_Docente
    {
        MAP_Docente MAP_Docente;
        public BLL_Docente()
        {
            MAP_Docente = new MAP_Docente();
        }

        public void Agregar_Docente(string pLegajo, int pDNI, string pNombre, string pApellido, int pUserID)
        {
            try
            {
                Docente D = new Docente(pLegajo, true, pNombre, pApellido, pDNI);
                MAP_Docente.Agregar_Docente(D, pUserID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Docente(Docente pDocente, int pID)
        {
            try
            {
                MAP_Docente.Modificar_Docente(pDocente, pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Docente(Usuario pUsuario)
        {
            try
            {
                MAP_Docente.Modificar_Docente(pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Modificar_Docente(Alumno pAlumno, int pID)
        {
            try
            {
                MAP_Docente.Modificar_Docente(pAlumno, pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public bool Verificar_Unicidad_Legajo(string pLegajo)
        {
            try
            {
                return MAP_Docente.Verificar_Unicidad_Legajo(pLegajo);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Docente> Ver_Docentes_Activos()
        {
            try
            {
                return MAP_Docente.Ver_Docentes_Activos();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Docente> Ver_Docentes_Inactivos()
        {
            try
            {
                return MAP_Docente.Ver_Docentes_Inactivos();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Docente> Ver_Docentes_Legajo(List<Docente> pLD, string pLegajo)
        {
            IEnumerable<Docente> IED = from X in pLD
                                       where X.Legajo == pLegajo
                                       select X;

            List<Docente> ListaDeConsulta = IED.ToList();

            return ListaDeConsulta;
        }
        public List<Docente> Ver_Docentes_DNI(List<Docente> pLD, string pDNI)
        {
            IEnumerable<Docente> IED = from X in pLD
                                       where X.DNI.ToString().StartsWith(pDNI)
                                       select X;

            List<Docente> ListaDeConsulta = IED.ToList();

            return ListaDeConsulta;
        }
        public List<Docente> Ver_Docentes_Apellido(List<Docente> pLD, string pApellido)
        {
            IEnumerable<Docente> IED = from X in pLD
                                       where X.Apellido.StartsWith(pApellido)
                                       select X;

            List<Docente> ListaDeConsulta = IED.ToList();

            return ListaDeConsulta;
        }

        public List<Docente> Ver_Docentes_Nombre(List<Docente> pLD, string pNombre)
        {
            IEnumerable<Docente> IED = from X in pLD
                                      where X.Nombre.StartsWith(pNombre)
                                      select X;

            List<Docente> ListaDeConsulta = IED.ToList();

            return ListaDeConsulta;
        }
        public void Dar_De_Baja_Docente(Docente pDocente)
        {
            try
            {
                MAP_Docente.Dar_De_Baja_Docente(pDocente);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Alta_Docente(Docente pDocente)
        {
            try
            {
                MAP_Docente.Dar_De_Alta_Docente(pDocente);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public int Obtener_ID_Usuario_Docente(Docente pDocente)
        {
            try
            {
                return MAP_Docente.Obtener_ID_Usuario_Docente(pDocente);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Docente Obtener_Docente_Por_ID_Usuario(int pID)
        {
            try
            {
                return MAP_Docente.Obtener_Docente_Por_ID_Usuario(pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public string Obtener_Conclusion(Docente pDocente, List<Evaluacion_de_Alumno> pEvaluaciones, int pIdioma)
        {
            try
            {
                int total = 0;
                string Conclusion = "";

                foreach (Evaluacion_de_Alumno EVAL in pEvaluaciones)
                {
                    total += EVAL.Calificacion;
                }

                total = total / pEvaluaciones.Count();

                if (pIdioma == 1)
                {
                    if (total <= 5)
                    {
                        Conclusion = "El docente, en este dictado, posee un Promedio Total de: " + (total * 10).ToString() + "%" + "\r\nRendimiento: Bajo";
                    }
                    else if (total == 6 || total == 7)
                    {
                        Conclusion = "El docente, en este dictado, posee un Promedio Total de: " + (total * 10).ToString() + "%" + "\r\nRendimiento: Suficiente";
                    }
                    else if (total == 8)
                    {
                        Conclusion = "El docente, en este dictado, posee un Promedio Total de: " + (total * 10).ToString() + "%" + "\r\nRendimiento: Satisfactorio";
                    }
                    else
                    {
                        Conclusion = "El docente, en este dictado, posee un Promedio Total de: " + (total * 10).ToString() + "%" + "\r\nRendimiento: Destacado";
                    }
                }
                else if (pIdioma == 2)
                {
                    if (total <= 5)
                    {
                        Conclusion = "The teacher, in this dictation, has a Total Average of: " + (total * 10).ToString() + "%" + "\r\nPerformance: Low";
                    }
                    else if (total == 6 || total == 7)
                    {
                        Conclusion = "The teacher, in this dictation, has a Total Average of: " + (total * 10).ToString() + " %" + "\r\nPerformance: Enough";
                    }
                    else if (total == 8)
                    {
                        Conclusion = "The teacher, in this dictation, has a Total Average of: " + (total * 10).ToString() + "%" + "\r\nPerformance: Satisfactory";
                    }
                    else
                    {
                        Conclusion = "The teacher, in this dictation, has a Total Average of: " + (total * 10).ToString() + "%" + "\r\nPerformance: Outstanding";
                    }
                }

                

                return Conclusion;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Docente> Ver_Docentes_Evaluaron_Tema(Tema pTema)
        {
            try
            {
                return MAP_Docente.Ver_Docentes_Evaluaron_Tema(pTema);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public string Obtener_Conclusion_Comparacion_Docentes(Docente pDocente, List<Evaluacion_de_Alumno> pEvaluaciones)
        {
            try
            {
                int total = 0;
                string Conclusion = "";

                foreach (Evaluacion_de_Alumno EVAL in pEvaluaciones)
                {
                    total += EVAL.Calificacion;
                }

                total = total / pEvaluaciones.Count();

                if (total <= 5)
                {
                    Conclusion = "El docente " + pDocente.Apellido + " " + pDocente.Nombre + ", en este dictado, posee un Promedio Total de: " + (total * 10).ToString() + "%" + "\r\nRendimiento: Bajo";
                }
                else if (total == 6 || total == 7)
                {
                    Conclusion = "El docente " + pDocente.Apellido + " " + pDocente.Nombre + ", posee un Promedio Total de: " + (total * 10).ToString() + "%" + "\r\nRendimiento: Suficiente";
                }
                else if (total == 8)
                {
                    Conclusion = "El docente " + pDocente.Apellido + " " + pDocente.Nombre + ", posee un Promedio Total de: " + (total * 10).ToString() + "%" + "\r\nRendimiento: Satisfactorio";
                }
                else
                {
                    Conclusion = "El docente " + pDocente.Apellido + " " + pDocente.Nombre + ", posee un Promedio Total de: " + (total * 10).ToString() + "%" + "\r\nRendimiento: Destacado";
                }

                return Conclusion;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Baja_Docente(Usuario pUsuario)
        {
            try
            {
                MAP_Docente.Dar_De_Baja_Docente(pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Alta_Docente(Usuario pUsuario)
        {
            try
            {
                MAP_Docente.Dar_De_Alta_Docente(pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Obtener_Promedio_Docente(Docente pDocente)
        {
            try
            {
                return MAP_Docente.Obtener_Promedio_Docente(pDocente);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Obtener_Cant_Evaluaciones_Corregidas(Docente pDocente)
        {
            try
            {
                return MAP_Docente.Obtener_Cant_Evaluaciones_Corregidas(pDocente);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Obtener_Promedio_Docente_Hasta_Fecha(Docente pDocente, DateTime pDateTime)
        {
            try
            {
                return MAP_Docente.Obtener_Promedio_Docente_Hasta_Fecha(pDocente, pDateTime);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }


    }
}
