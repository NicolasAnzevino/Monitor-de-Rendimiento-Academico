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
    public partial class FormVerRendimientoCurso : Form
    {
        public FormVerRendimientoCurso(int pKey, Curso pCurso)
        {
            InitializeComponent();
            ID = pKey;
            Curso = pCurso;
        }

        public int ID;
        public string SerieAprobada, SerieReprobada;
        public Curso Curso;
        public BLL_Curso BLL_Curso;
        public BLL_Materia BLL_Materia;
        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        public List<Alumno> Alumnos;
        public List<Evaluacion> Evaluaciones;
        public Dictionary<Evaluacion, List<Evaluacion_de_Alumno>> EvaluacionCalificaciones;
        public Dictionary<Evaluacion, bool> VerificadorCalificaciones;

        //Explicación: Cada Evaluación va a tener true o false. Si tiene false, es porque no tiene calificaciones cargadas. Si tiene true és pq sí.

        private void FormVerRendimientoCurso_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            bool HayAlmenosUnaEvaluacionConCorrecciones = false;
            EvaluacionCalificaciones = new Dictionary<Evaluacion, List<Evaluacion_de_Alumno>>();

            BLL_Curso = new BLL_Curso();
            BLL_Materia = new BLL_Materia();
            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            lblMateria.Visible = false;
            txtBoxMateria.Visible = false;

            Alumnos = BLL_Curso.Ver_Alumnos_del_Curso(Curso);            

            if (Alumnos.Count>0)
            {
                BLL_Cursada_de_Alumno.Ver_Cursadas_de_Curso(Alumnos);
                Evaluaciones = BLL_Curso.Obtener_Evaluaciones_de_Curso(Curso);

                if (Evaluaciones.Count>0)
                {
                    VerificadorCalificaciones = new Dictionary<Evaluacion, bool>();

                    foreach (Evaluacion E in Evaluaciones)
                    {
                        VerificadorCalificaciones.Add(E, false);
                    }

                    VerificadorCalificaciones = BLL_Curso.ObtenerEvaluacionesRealizadas(Evaluaciones);

                    foreach (KeyValuePair<Evaluacion,bool> item in VerificadorCalificaciones)
                    {
                        if (item.Value == true)
                        {
                            HayAlmenosUnaEvaluacionConCorrecciones = true;
                            EvaluacionCalificaciones.Add(item.Key, new List<Evaluacion_de_Alumno>());
                        }
                    }

                    if (HayAlmenosUnaEvaluacionConCorrecciones == true)
                    {
                        BLL_Cursada_de_Alumno.Obtener_Calificaciones_de_Evaluacion(EvaluacionCalificaciones);

                        if (SessionManager.getInstance(ID).Idioma == 1)
                        {
                            SerieAprobada = "Promedio de Evaluacion con buen resultado";
                            SerieReprobada = "Promedio de Evaluacion con mal resultado";
                        }
                        else if (SessionManager.getInstance(ID).Idioma == 2)
                        {
                            SerieAprobada = "Evaluation average with good result";
                            SerieReprobada = "Evaluation average with bad result";
                        }

                        chartRendimiento.Series.Add(SerieAprobada);
                        chartRendimiento.Series.Add(SerieReprobada);

                        chartRendimiento.Series[SerieAprobada].Color = Color.FromArgb(27, 49, 192);
                        chartRendimiento.Series[SerieReprobada].Color = Color.FromArgb(229, 20, 20);

                        chartRendimiento.ChartAreas[0].AxisX.IsMarginVisible = false;
                        chartRendimiento.ChartAreas[0].AxisY.IsMarginVisible = false;

                        chartRendimiento.ChartAreas[0].AxisY.Interval = 1;

                        MostrarRendimiento(SessionManager.getInstance(ID).Idioma);

                        Generar_Grafico(0);

                    }
                    else { MessageBox.Show("El Curso seleccionado no tiene Evaluaciones corregidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
                }
                else { MessageBox.Show("El Curso seleccionado no tiene Evaluaciones cargadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
            }
            else { MessageBox.Show("El Curso seleccionado no tiene Alumnos inscriptos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
        }

        public void MostrarRendimiento(int pIdioma)
        {
            try
            {
                if (pIdioma == 1)
                {
                    txtBoxRendimiento.Text += "\n\r" + "Curso: " + Curso.Nombre + " " + Curso.Año.ToString() + " - " + Curso.Turno;

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    int PromedioCurso = BLL_Curso.Obtener_Promedio_Curso(Curso);

                    txtBoxRendimiento.Text += "\n\r" + "Promedio del Curso: " + PromedioCurso.ToString();
                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";

                    foreach (KeyValuePair<Evaluacion, List<Evaluacion_de_Alumno>> item in EvaluacionCalificaciones)
                    {
                        txtBoxRendimiento.Text += "\n\r" + "Materia: " + item.Key.Materia.Nombre;
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Evaluación: " + item.Key.Titulo;
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Fecha: " + item.Key.Fecha.ToShortDateString();
                        txtBoxRendimiento.Text += "\n\r\n\r";

                        txtBoxRendimiento.Text += "\n\r" + "Total de Exámenes Corregidos: " + item.Value.Count.ToString();
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Cantidad de Aprobados: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(item.Value).ToString();
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Cantidad de Reprobados: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(item.Value).ToString();
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Promedio de la Evaluación: " + BLL_Materia.Obtener_Promedio_Evaluacion(item.Value).ToString();

                        txtBoxRendimiento.Text += "\n\r\n\r";

                        txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";
                    }

                    txtBoxRendimiento.Text += "\n\r" + "Promedio de los Alumnos en el Curso: " + "\n\r";
                    txtBoxRendimiento.Text += "\n\r";

                    foreach (Alumno alumno in Alumnos)
                    {
                        txtBoxRendimiento.Text += "\n\r" + alumno.Legajo + " - " + alumno.Apellido + ", " + alumno.Nombre + ": " + BLL_Cursada_de_Alumno.ObtenerPromedioDeCursada(alumno.VerCursadas().Find(X=> X.Curso.Codigo == Curso.Codigo)).ToString();
                        txtBoxRendimiento.Text += "\n\r";
                    }

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxConclusion.Text += BLL_Curso.Obtener_Conclusion(PromedioCurso, pIdioma);

                    txtBoxRendimiento.Select(0, 0);
                    txtBoxConclusion.Select(0, 0);
                }
                else if (pIdioma == 2)
                {
                    txtBoxRendimiento.Text += "\n\r" + "Course: " + Curso.Nombre + " " + Curso.Año.ToString() + " - " + Curso.Turno;

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    int PromedioCurso = BLL_Curso.Obtener_Promedio_Curso(Curso);

                    txtBoxRendimiento.Text += "\n\r" + "Course Average: " + PromedioCurso.ToString();
                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";

                    foreach (KeyValuePair<Evaluacion, List<Evaluacion_de_Alumno>> item in EvaluacionCalificaciones)
                    {
                        txtBoxRendimiento.Text += "\n\r" + "Matter: " + item.Key.Materia.Nombre;
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Evaluation: " + item.Key.Titulo;
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Date: " + item.Key.Fecha.ToShortDateString();
                        txtBoxRendimiento.Text += "\n\r\n\r";

                        txtBoxRendimiento.Text += "\n\r" + "Total Corrected Exams: " + item.Value.Count.ToString();
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Number of Approved: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(item.Value).ToString();
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Number of Failures: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(item.Value).ToString();
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Evaluation Average: " + BLL_Materia.Obtener_Promedio_Evaluacion(item.Value).ToString();

                        txtBoxRendimiento.Text += "\n\r\n\r";

                        txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";
                    }

                    txtBoxRendimiento.Text += "\n\r" + "Average of Students in the Course: " + "\n\r";
                    txtBoxRendimiento.Text += "\n\r";

                    foreach (Alumno alumno in Alumnos)
                    {
                        txtBoxRendimiento.Text += "\n\r" + alumno.Legajo + " - " + alumno.Apellido + ", " + alumno.Nombre + ": " + BLL_Cursada_de_Alumno.ObtenerPromedioDeCursada(alumno.VerCursadas().Find(X => X.Curso.Codigo == Curso.Codigo)).ToString();
                        txtBoxRendimiento.Text += "\n\r";
                    }

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxConclusion.Text += BLL_Curso.Obtener_Conclusion(PromedioCurso, pIdioma);

                    txtBoxRendimiento.Select(0, 0);
                    txtBoxConclusion.Select(0, 0);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public void MostrarRendimientoMateria(int pIdioma, Dictionary<Evaluacion, List<Evaluacion_de_Alumno>> pDiccionario)
        {
            try
            {
                if (pIdioma == 1)
                {
                    txtBoxRendimiento.Text += "\n\r" + "Curso: " + Curso.Nombre + " " + Curso.Año.ToString() + " - " + Curso.Turno;

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    int PromedioCurso = BLL_Curso.Obtener_Promedio_Curso(Curso);

                    txtBoxRendimiento.Text += "\n\r" + "Promedio del Curso: " + PromedioCurso.ToString();
                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";

                    foreach (KeyValuePair<Evaluacion, List<Evaluacion_de_Alumno>> item in pDiccionario)
                    {
                        txtBoxRendimiento.Text += "\n\r" + "Materia: " + item.Key.Materia.Nombre;
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Evaluación: " + item.Key.Titulo;
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Fecha: " + item.Key.Fecha.ToShortDateString();
                        txtBoxRendimiento.Text += "\n\r\n\r";

                        txtBoxRendimiento.Text += "\n\r" + "Total de Exámenes Corregidos: " + item.Value.Count.ToString();
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Cantidad de Aprobados: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(item.Value).ToString();
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Cantidad de Reprobados: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(item.Value).ToString();
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Promedio de la Evaluación: " + BLL_Materia.Obtener_Promedio_Evaluacion(item.Value).ToString();

                        txtBoxRendimiento.Text += "\n\r\n\r";

                        txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";
                    }

                    txtBoxRendimiento.Select(0, 0);
                    txtBoxConclusion.Select(0, 0);
                }
                else if (pIdioma == 2)
                {
                    txtBoxRendimiento.Text += "\n\r" + "Course: " + Curso.Nombre + " " + Curso.Año.ToString() + " - " + Curso.Turno;

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    int PromedioCurso = BLL_Curso.Obtener_Promedio_Curso(Curso);

                    txtBoxRendimiento.Text += "\n\r" + "Course Average: " + PromedioCurso.ToString();
                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";

                    foreach (KeyValuePair<Evaluacion, List<Evaluacion_de_Alumno>> item in pDiccionario)
                    {
                        txtBoxRendimiento.Text += "\n\r" + "Matter: " + item.Key.Materia.Nombre;
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Evaluation: " + item.Key.Titulo;
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Date: " + item.Key.Fecha.ToShortDateString();
                        txtBoxRendimiento.Text += "\n\r\n\r";

                        txtBoxRendimiento.Text += "\n\r" + "Total Corrected Exams: " + item.Value.Count.ToString();
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Number of Approved: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(item.Value).ToString();
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Number of Failures: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(item.Value).ToString();
                        txtBoxRendimiento.Text += "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Evaluation Average: " + BLL_Materia.Obtener_Promedio_Evaluacion(item.Value).ToString();

                        txtBoxRendimiento.Text += "\n\r\n\r";

                        txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";
                    }

                    txtBoxRendimiento.Select(0, 0);
                    txtBoxConclusion.Select(0, 0);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked == true)
            {
                foreach (var series in chartRendimiento.Series)
                {
                    series.Points.Clear();
                }

                txtBoxRendimiento.Text = "";
                txtBoxConclusion.Text = "";

                lblMateria.Visible = false;
                txtBoxMateria.Visible = false;

                Generar_Grafico(0);
                MostrarRendimiento(SessionManager.getInstance(ID).Idioma);
            }
        }

        private void rbMateria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMateria.Checked == true)
            {
                foreach (var series in chartRendimiento.Series)
                {
                    series.Points.Clear();
                }

                txtBoxMateria.Text = "";
                txtBoxRendimiento.Text = "";
                txtBoxConclusion.Text = "";

                lblMateria.Visible = true;
                txtBoxMateria.Visible = true;
            }
        }

        private void txtBoxMateria_TextChanged(object sender, EventArgs e)
        {
            txtBoxRendimiento.Text = "";

            Dictionary<Evaluacion, List<Evaluacion_de_Alumno>> DiccionarioAux = new Dictionary<Evaluacion, List<Evaluacion_de_Alumno>>();

            foreach (KeyValuePair<Evaluacion, List<Evaluacion_de_Alumno>> item in EvaluacionCalificaciones)
            {
                if (item.Key.Materia.Nombre == txtBoxMateria.Text)
                {
                    DiccionarioAux.Add(item.Key, item.Value);
                }
            }

            foreach (var series in chartRendimiento.Series)
            {
                series.Points.Clear();
            }
            if (DiccionarioAux.Count > 0)
            {
                MostrarRendimientoMateria(SessionManager.getInstance(ID).Idioma, DiccionarioAux);
                Generar_GraficoMateria(0, DiccionarioAux);
            }

        }

        public void Generar_Grafico(int pos)
        {
            chartRendimiento.Series[SerieAprobada].XValueMember = "Fecha";
            chartRendimiento.Series[SerieAprobada].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            chartRendimiento.Series[SerieAprobada].YValueMembers = "Promedio";
            chartRendimiento.Series[SerieAprobada].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            foreach (KeyValuePair<Evaluacion, List<Evaluacion_de_Alumno>> item in EvaluacionCalificaciones)
            {
                int Promedio = 0;

                foreach (Evaluacion_de_Alumno Eval in item.Value)
                {
                    Promedio += Eval.Calificacion;
                }

                Promedio = Promedio / item.Value.Count;

                chartRendimiento.Series[SerieAprobada].Points.AddXY(item.Key.Fecha.ToShortDateString() + "\n" + item.Key.Materia.Nombre + "\n" + item.Key.Titulo, Promedio);
                if (Promedio >= 6) { chartRendimiento.Series[SerieAprobada].Points[pos].Color = Color.FromArgb(27, 49, 192); }
                else
                {
                    chartRendimiento.Series[SerieAprobada].Points[pos].Color = Color.FromArgb(229, 20, 20);
                }
                pos++;
            }           
            
        }
        public void Generar_GraficoMateria(int pos, Dictionary<Evaluacion, List<Evaluacion_de_Alumno>> pDiccionario)
        {
            chartRendimiento.Series[SerieAprobada].XValueMember = "Fecha";
            chartRendimiento.Series[SerieAprobada].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            chartRendimiento.Series[SerieAprobada].YValueMembers = "Promedio";
            chartRendimiento.Series[SerieAprobada].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            foreach (KeyValuePair<Evaluacion, List<Evaluacion_de_Alumno>> item in pDiccionario)
            {
                int Promedio = 0;

                foreach (Evaluacion_de_Alumno Eval in item.Value)
                {
                    Promedio += Eval.Calificacion;
                }

                Promedio = Promedio / item.Value.Count;

                chartRendimiento.Series[SerieAprobada].Points.AddXY(item.Key.Fecha.ToShortDateString() + "\n" + item.Key.Materia.Nombre + "\n" + item.Key.Titulo, Promedio);
                if (Promedio >= 6) { chartRendimiento.Series[SerieAprobada].Points[pos].Color = Color.FromArgb(27, 49, 192); }
                else
                {
                    chartRendimiento.Series[SerieAprobada].Points[pos].Color = Color.FromArgb(229, 20, 20);
                }
                pos++;
            }

        }

    }
}
