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
    public partial class FormInformeProblemaDocente : Form
    {
        public FormInformeProblemaDocente(int pKey, Docente pDocente)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Docente = pDocente;
        }

        public int ID, PromedioDocente;
        public Docente Docente;
        public BLL_Curso BLL_Curso;
        public BLL_Docente BLL_Docente;
        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        public Dictionary<Materia, List<Evaluacion_de_Alumno>> DiccionarioMateriaCalificaciones;
        public Dictionary<Curso, int> DiccionarioCursoPromedio;
        public List<Curso> Cursos;

        private void FormInformeProblemaDocente_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Curso = new BLL_Curso();
            BLL_Docente = new BLL_Docente();
            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            Cursos = new List<Curso>();
            DiccionarioCursoPromedio = new Dictionary<Curso, int>();

            PromedioDocente = BLL_Docente.Obtener_Promedio_Docente(Docente);
            DiccionarioMateriaCalificaciones = BLL_Cursada_de_Alumno.Obtener_Curso_Materia_Evaluacion_de_Docente(Docente);
            ObtenerPromedioCursos();
            GenerarInforme(SessionManager.getInstance(ID).Idioma);
        }

        public void GenerarInforme(int pIdioma)
        {
            try
            {
                if (pIdioma == 1)
                {
                    txtBoxInforme.Text += "Docente: " + Docente.Apellido + ", " + Docente.Nombre;
                    txtBoxInforme.Text += "\n\r\n\r";
                    txtBoxInforme.Text += "Legajo:" + Docente.Legajo;
                    txtBoxInforme.Text += "\n\r\n\r";
                    txtBoxInforme.Text += "DNI:" + Docente.DNI.ToString();
                    txtBoxInforme.Text += "\n\r\n\r";
                    txtBoxInforme.Text += "Promedio Actual del Docente: " + PromedioDocente.ToString();
                    txtBoxInforme.Text += "\n\r\n\r";
                    txtBoxInforme.Text += "\n\r\n\r";
                    txtBoxInforme.Text += "Rendimiento de últimos 5 Dictados: ";

                    txtBoxConclusion.Text += "Conclusión (Comparación Rendimiento Docente en Curso - Cursada):";
                    txtBoxConclusion.Text += "\n\r\n";

                    foreach (KeyValuePair<Materia, List<Evaluacion_de_Alumno>> item in DiccionarioMateriaCalificaciones)
                    {
                        txtBoxInforme.Text += "\n\r\n\r";
                        txtBoxInforme.Text += "———————————————————————————————————————————————————————————————————————\n\r\n\r";

                        txtBoxInforme.Text += "Curso: " + item.Key.RetornarCurso().Codigo + " - " + item.Key.RetornarCurso().Nombre + " - " + item.Key.RetornarCurso().Año + " - " + item.Key.RetornarCurso().Turno;
                        txtBoxInforme.Text += "\n\r\n\r";
                        txtBoxInforme.Text += "Materia: " + item.Key.Codigo + " - " + item.Key.Nombre;
                        txtBoxInforme.Text += "\n\r\n\r";
                        txtBoxInforme.Text += "\n\r";

                        txtBoxInforme.Text += "Cantidad de exámenes corregidos: " + item.Value.Count;
                        txtBoxInforme.Text += "\n\r\n\r";

                        txtBoxInforme.Text += "Cantidad de exámenes aprobados: " + BLL_Cursada_de_Alumno.Obtener_Cant_Aprobados(item.Value);

                        txtBoxInforme.Text += "\n\r\n\r";

                        txtBoxInforme.Text += "Cantidad de exámenes reprobados: " + BLL_Cursada_de_Alumno.Obtener_Cant_Reprobados(item.Value);

                        txtBoxInforme.Text += "\n\r\n\r\n\r";

                        txtBoxInforme.Text += "Promedio general del Curso: " + DiccionarioCursoPromedio[item.Key.RetornarCurso()].ToString();
                        txtBoxInforme.Text += "\n\r\n\r";
                        int PromedioMateria = BLL_Cursada_de_Alumno.Obtener_Promedio(item.Value);
                        txtBoxInforme.Text += "Promedio del Curso en la Materia: " + PromedioMateria.ToString();

                        txtBoxInforme.Text += "\n\r\n\r";

                        int PromedioDocente = BLL_Docente.Obtener_Promedio_Docente_Hasta_Fecha(Docente, BLL_Cursada_de_Alumno.ObtenerFechaMasReciente_Docente(Docente, item.Value));

                        txtBoxInforme.Text += "Promedio del Docente durante el dictado del Curso: " + PromedioDocente.ToString();

                        txtBoxConclusion.Text += "\n\r\n";
                        txtBoxConclusion.Text += "\nComparación con el Curso " + item.Key.RetornarCurso().Nombre + " en la Materia " + item.Key.Nombre + ": ";
                        txtBoxConclusion.Text += "\n\r\n";

                        txtBoxConclusion.Text += BLL_Cursada_de_Alumno.Comparar_Rendimientos_Curso_Docente(PromedioMateria, PromedioDocente  ,SessionManager.getInstance(ID).Idioma);

                        txtBoxConclusion.Text += "\n\r\n";
                    }      
                    
                    txtBoxInforme.Select(0, 0);
                    txtBoxConclusion.Select(0, 0);
                }
                else if (pIdioma == 2)
                {
                    txtBoxInforme.Text += "Teacher: " + Docente.Apellido + ", " + Docente.Nombre;
                    txtBoxInforme.Text += "\n\r\n\r";
                    txtBoxInforme.Text += "ID:" + Docente.Legajo;
                    txtBoxInforme.Text += "\n\r\n\r";
                    txtBoxInforme.Text += "Document Number:" + Docente.DNI.ToString();
                    txtBoxInforme.Text += "\n\r\n\r";
                    txtBoxInforme.Text += "Teacher's Actual Average: " + PromedioDocente.ToString();
                    txtBoxInforme.Text += "\n\r\n\r";
                    txtBoxInforme.Text += "\n\r\n\r";
                    txtBoxInforme.Text += "Performance of the last 5 Dictations: ";

                    txtBoxConclusion.Text += "Conclusion (Comparison of Teaching Performance in Course - Completed):";
                    txtBoxConclusion.Text += "\n\r\n";

                    foreach (KeyValuePair<Materia, List<Evaluacion_de_Alumno>> item in DiccionarioMateriaCalificaciones)
                    {
                        txtBoxInforme.Text += "\n\r\n\r";
                        txtBoxInforme.Text += "———————————————————————————————————————————————————————————————————————\n\r\n\r";

                        txtBoxInforme.Text += "Course: " + item.Key.RetornarCurso().Codigo + " - " + item.Key.RetornarCurso().Nombre + " - " + item.Key.RetornarCurso().Año + " - " + item.Key.RetornarCurso().Turno;
                        txtBoxInforme.Text += "\n\r\n\r";
                        txtBoxInforme.Text += "Matter: " + item.Key.Codigo + " - " + item.Key.Nombre;
                        txtBoxInforme.Text += "\n\r\n\r";
                        txtBoxInforme.Text += "\n\r";

                        txtBoxInforme.Text += "Number of corrected exams:" + item.Value.Count;
                        txtBoxInforme.Text += "\n\r\n\r";

                        txtBoxInforme.Text += "Number of passed exams:" + BLL_Cursada_de_Alumno.Obtener_Cant_Aprobados(item.Value);

                        txtBoxInforme.Text += "\n\r\n\r";

                        txtBoxInforme.Text += "Number of failed exams: " + BLL_Cursada_de_Alumno.Obtener_Cant_Reprobados(item.Value);

                        txtBoxInforme.Text += "\n\r\n\r\n\r";

                        txtBoxInforme.Text += "Course overall average: " + DiccionarioCursoPromedio[item.Key.RetornarCurso()].ToString();
                        txtBoxInforme.Text += "\n\r\n\r";
                        int PromedioMateria = BLL_Cursada_de_Alumno.Obtener_Promedio(item.Value);
                        txtBoxInforme.Text += "Course Average in the Subject: " + PromedioMateria.ToString();

                        txtBoxInforme.Text += "\n\r\n\r";

                        int PromedioDocente = BLL_Docente.Obtener_Promedio_Docente_Hasta_Fecha(Docente, BLL_Cursada_de_Alumno.ObtenerFechaMasReciente_Docente(Docente, item.Value));

                        txtBoxInforme.Text += "Average of the Teacher during the dictation of the Course:" + PromedioDocente.ToString();

                        txtBoxConclusion.Text += "\n\r\n";
                        txtBoxConclusion.Text += "\nComparison with the Course" + item.Key.RetornarCurso().Nombre + " in the Matter " + item.Key.Nombre + ": ";
                        txtBoxConclusion.Text += "\n\r\n";

                        txtBoxConclusion.Text += BLL_Cursada_de_Alumno.Comparar_Rendimientos_Curso_Docente(PromedioMateria, PromedioDocente, SessionManager.getInstance(ID).Idioma);

                        txtBoxConclusion.Text += "\n\r\n";
                    }

                    txtBoxInforme.Select(0, 0);
                    txtBoxConclusion.Select(0, 0);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void ObtenerPromedioCursos()
        {
            foreach (KeyValuePair<Materia, List<Evaluacion_de_Alumno>> item in DiccionarioMateriaCalificaciones)
            {
                if (!Cursos.Exists(X=> X.Codigo == item.Key.RetornarCurso().Codigo))
                {
                    Cursos.Add(item.Key.RetornarCurso());
                }
            }

            foreach (Curso C in Cursos)
            {
                DiccionarioCursoPromedio.Add(C, BLL_Curso.Obtener_Promedio_Curso(C));
            }
        }      
    }
}
