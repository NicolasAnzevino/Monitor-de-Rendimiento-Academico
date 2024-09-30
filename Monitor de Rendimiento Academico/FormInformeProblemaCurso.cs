using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;
using Entidades;
using BLL;


namespace Monitor_de_Rendimiento_Academico
{
    public partial class FormInformeProblemaCurso : Form
    {
        public FormInformeProblemaCurso(int pKey, Curso pCurso)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Curso = pCurso;
        }

        public int ID;
        public Curso Curso;
        public BLL_Curso BLL_Curso;
        public BLL_Docente BLL_Docente;
        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        public Dictionary<Materia, List<Evaluacion_de_Alumno>> DiccionarioMateriaCalificaciones;
        public Dictionary<Docente, int> DiccionarioDocentePromedio;
        public List<Docente> Docentes;

        private void FormInformeProblemaCurso_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Curso = new BLL_Curso();
            BLL_Docente = new BLL_Docente();
            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            Docentes = new List<Docente>();

            DiccionarioMateriaCalificaciones = BLL_Curso.Obtener_Docente_Materia_Evaluacion_de_Curso(Curso);

            if (DiccionarioMateriaCalificaciones.Count>0)
            {
                DiccionarioDocentePromedio = new Dictionary<Docente, int>();
                ObtenerDocentesDeDiccionario();
                ObtenerPromediosDeDocentes();
                GenerarInforme(SessionManager.getInstance(ID).Idioma);
            }
            else { MessageBox.Show("Este Curso no posee Evaluaciones", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }

            
        }

        public void GenerarInforme(int pIdioma)
        {
            try
            {
                if (pIdioma==1)
                {
                    int PromedioCurso = 0;
                    
                    txtBoxInforme.Text += "Curso: " + Curso.Nombre;
                    txtBoxInforme.Text += "\n\r\n\r";
                    txtBoxInforme.Text += "Año: " + Curso.Año.ToString();
                    txtBoxInforme.Text += "\n\r\n\r";
                    txtBoxInforme.Text += "Turno: " + Curso.Turno;

                    txtBoxInforme.Text += "\n\r\n\r";

                    List<Docente> DocentesDeMateria = new List<Docente>();

                    foreach (KeyValuePair<Materia, List<Evaluacion_de_Alumno>> item in DiccionarioMateriaCalificaciones)
                    {
                        DocentesDeMateria.Clear();

                        foreach (Evaluacion_de_Alumno Eva in item.Value)
                        {
                            if (!DocentesDeMateria.Exists(X=> X.Legajo == Eva.Docente.Legajo))
                            {
                                DocentesDeMateria.Add(Eva.Docente);
                            }
                        }

                        txtBoxInforme.Text += "———————————————————————————————————————————————————————————————————————\n\r\n\r";

                        txtBoxInforme.Text += "Materia: " + item.Key.Nombre;

                        txtBoxInforme.Text += "\n\r\n\r\n\r";

                        txtBoxInforme.Text += "Cantidad de exámenes corregidos: " + item.Value.Count;

                        txtBoxInforme.Text += "\n\r\n\r";

                        txtBoxInforme.Text += "Cantidad de exámenes aprobados: " + BLL_Cursada_de_Alumno.Obtener_Cant_Aprobados(item.Value);

                        txtBoxInforme.Text += "\n\r\n\r";

                        txtBoxInforme.Text += "Cantidad de exámenes reprobados: " + BLL_Cursada_de_Alumno.Obtener_Cant_Reprobados(item.Value);

                        txtBoxInforme.Text += "\n\r\n\r";

                        PromedioCurso += BLL_Cursada_de_Alumno.Obtener_Promedio(item.Value);

                        txtBoxInforme.Text += "Promedio del Curso en la Materia: " + BLL_Cursada_de_Alumno.Obtener_Promedio(item.Value).ToString(); ;

                        txtBoxInforme.Text += "\n\r\n\r";
                        txtBoxInforme.Text += "\n\r\n\r";

                        txtBoxInforme.Text += "Docente/s: ";

                        txtBoxInforme.Text += "\n\r\n\r\n\r";

                        foreach (Docente Docente in DocentesDeMateria)
                        {
                            txtBoxInforme.Text += "🔘 " + Docente.Legajo + " - " + Docente.Apellido + ", " + Docente.Nombre + "\n\r";
                            txtBoxInforme.Text += "\n\r";
                            txtBoxInforme.Text += "Promedio General: " + DiccionarioDocentePromedio[Docente];
                            txtBoxInforme.Text += "\n\r\n\r\n\r";
                        }
                    }

                    txtBoxInforme.Text +=  "———————————————————————————————————————————————————————————————————————\n\r\n\r";

                    txtBoxConclusion.Text += "Promedio General del Curso: " + PromedioCurso / DiccionarioMateriaCalificaciones.Values.Count();
                    txtBoxConclusion.Text += "\n\r\n\r\n\r";
                    txtBoxConclusion.Text += "Conclusión (Comparación Curso - Docentes):";
                    txtBoxConclusion.Text += "\n\r\n";

                    foreach (Docente Docente in Docentes)
                    {
                        txtBoxConclusion.Text += "\n\r\n";

                        txtBoxConclusion.Text += "\nComparación con " + Docente.Apellido + " " + Docente.Nombre + ": ";

                        txtBoxConclusion.Text += BLL_Cursada_de_Alumno.Comparar_Rendimientos_Curso_Docente(PromedioCurso / DiccionarioMateriaCalificaciones.Values.Count, DiccionarioDocentePromedio[Docente], SessionManager.getInstance(ID).Idioma);

                        txtBoxConclusion.Text += "\n\r\n";
                    }                   

                    txtBoxInforme.Select(0, 0);
                    txtBoxConclusion.Select(0, 0);
                }
                else if (pIdioma == 2)
                {
                    int PromedioCurso = 0;

                    txtBoxInforme.Text += "Course: " + Curso.Nombre;
                    txtBoxInforme.Text += "\n\r\n\r";
                    txtBoxInforme.Text += "Year: " + Curso.Año.ToString();
                    txtBoxInforme.Text += "\n\r\n\r";
                    txtBoxInforme.Text += "Turn: " + Curso.Turno;

                    txtBoxInforme.Text += "\n\r\n\r";

                    List<Docente> DocentesDeMateria = new List<Docente>();

                    foreach (KeyValuePair<Materia, List<Evaluacion_de_Alumno>> item in DiccionarioMateriaCalificaciones)
                    {
                        DocentesDeMateria.Clear();

                        foreach (Evaluacion_de_Alumno Eva in item.Value)
                        {
                            if (!DocentesDeMateria.Exists(X => X.Legajo == Eva.Docente.Legajo))
                            {
                                DocentesDeMateria.Add(Eva.Docente);
                            }
                        }

                        txtBoxInforme.Text += "———————————————————————————————————————————————————————————————————————\n\r\n\r";

                        txtBoxInforme.Text += "Matter: " + item.Key.Nombre;

                        txtBoxInforme.Text += "\n\r\n\r\n\r";

                        txtBoxInforme.Text += "Number of corrected exams: " + item.Value.Count;

                        txtBoxInforme.Text += "\n\r\n\r";

                        txtBoxInforme.Text += "Number of passed exams: " + BLL_Cursada_de_Alumno.Obtener_Cant_Aprobados(item.Value);

                        txtBoxInforme.Text += "\n\r\n\r";

                        txtBoxInforme.Text += "Number of failed exams: " + BLL_Cursada_de_Alumno.Obtener_Cant_Reprobados(item.Value);

                        txtBoxInforme.Text += "\n\r\n\r";

                        PromedioCurso += BLL_Cursada_de_Alumno.Obtener_Promedio(item.Value);

                        txtBoxInforme.Text += "Course Average in the Matter: " + BLL_Cursada_de_Alumno.Obtener_Promedio(item.Value).ToString(); ;

                        txtBoxInforme.Text += "\n\r\n\r";
                        txtBoxInforme.Text += "\n\r\n\r";

                        txtBoxInforme.Text += "Teacher/s: ";

                        txtBoxInforme.Text += "\n\r\n\r\n\r";

                        foreach (Docente Docente in DocentesDeMateria)
                        {
                            txtBoxInforme.Text += "🔘 " + Docente.Legajo + " - " + Docente.Apellido + ", " + Docente.Nombre + "\n\r";
                            txtBoxInforme.Text += "\n\r";
                            txtBoxInforme.Text += "General Average: " + DiccionarioDocentePromedio[Docente];
                            txtBoxInforme.Text += "\n\r\n\r\n\r";
                        }
                    }

                    txtBoxInforme.Text += "———————————————————————————————————————————————————————————————————————\n\r\n\r";

                    txtBoxConclusion.Text += "General Average of the Course: " + PromedioCurso / DiccionarioMateriaCalificaciones.Values.Count();
                    txtBoxConclusion.Text += "\n\r\n\r\n\r";
                    txtBoxConclusion.Text += "Conclusion (Comparison Course - Teachers):";
                    txtBoxConclusion.Text += "\n\r\n";

                    foreach (Docente Docente in Docentes)
                    {
                        txtBoxConclusion.Text += "\n\r\n";

                        txtBoxConclusion.Text += "\nComparison with " + Docente.Apellido + " " + Docente.Nombre + ": ";

                        txtBoxConclusion.Text += BLL_Cursada_de_Alumno.Comparar_Rendimientos_Curso_Docente(PromedioCurso / DiccionarioMateriaCalificaciones.Values.Count, DiccionarioDocentePromedio[Docente], SessionManager.getInstance(ID).Idioma);

                        txtBoxConclusion.Text += "\n\r\n";
                    }

                    txtBoxInforme.Select(0, 0);
                    txtBoxConclusion.Select(0, 0);
                }


            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void ObtenerDocentesDeDiccionario()
        {
            foreach (KeyValuePair<Materia, List<Evaluacion_de_Alumno>> item in DiccionarioMateriaCalificaciones)
            {
                foreach (Evaluacion_de_Alumno Eva in item.Value)
                {
                    if (!Docentes.Exists(X=>X.Legajo == Eva.Docente.Legajo))
                    {
                        Docentes.Add(Eva.Docente);
                        DiccionarioDocentePromedio.Add(Eva.Docente, 0);
                    }
                }
            }
        }

        public void ObtenerPromediosDeDocentes()
        {
            foreach (Docente D in Docentes)
            {
                foreach (KeyValuePair<Materia, List<Evaluacion_de_Alumno>> item in DiccionarioMateriaCalificaciones)
                {
                    if (DiccionarioDocentePromedio[D] == 0)
                    {
                        DiccionarioDocentePromedio[D] = BLL_Docente.Obtener_Promedio_Docente_Hasta_Fecha(D, BLL_Cursada_de_Alumno.ObtenerFechaMasReciente_Docente(D, item.Value));
                    }                    
                }                               
            }
        }      


    }
}
