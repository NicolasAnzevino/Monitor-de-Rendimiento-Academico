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
    public partial class FormCompararDocente : Form
    {
        public FormCompararDocente(int pKey, Docente pDocente1, Docente pDocente2, Tema pTema)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Docente1 = pDocente1;
            Docente2 = pDocente2;
            Tema = pTema;
        }

        public int ID;
        public string SerieAprobada, SerieReprobada;
        public Docente Docente1, Docente2;
        public Tema Tema;

        public BLL_Docente BLL_Docente;
        public BLL_Dictado BLL_Dictado;
        public BLL_Materia BLL_Materia;
        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        List<Evaluacion_de_Alumno> EvaluacionesDeAlumno1, EvaluacionesDeAlumno2;
        List<Evaluacion> EvaluacionesDocente1, EvaluacionesDocente2;


        private void FormCompararDocente_Load(object sender, EventArgs e)
        {
            try
            {
                TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

                this.MaximizeBox = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;

                lblGraficoRendimiento.Text += Docente1.Apellido + ", " + Docente1.Nombre;
                lblInfoRendimiento.Text += Docente1.Apellido + ", " + Docente1.Nombre;
                lblGraficoRendimiento2.Text += Docente2.Apellido + ", " + Docente2.Nombre;
                lblInfoRendimiento2.Text += Docente2.Apellido + ", " + Docente2.Nombre;

                BLL_Docente = new BLL_Docente();
                BLL_Dictado = new BLL_Dictado();
                BLL_Materia = new BLL_Materia();
                BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

                EvaluacionesDeAlumno1 = new List<Evaluacion_de_Alumno>();
                EvaluacionesDeAlumno2 = new List<Evaluacion_de_Alumno>();

                EvaluacionesDocente1 = BLL_Materia.Obtener_Evaluaciones_Docente_Tema(Docente1, Tema);
                EvaluacionesDocente2 = BLL_Materia.Obtener_Evaluaciones_Docente_Tema(Docente2, Tema);

                if (EvaluacionesDocente1.Count > 0 && EvaluacionesDocente2.Count > 0)
                {
                    foreach (Evaluacion E in EvaluacionesDocente1)
                    {
                        foreach (Evaluacion_de_Alumno item in BLL_Cursada_de_Alumno.Obtener_Calificacciones_Docente_Tema(Docente1, E))
                        {
                            EvaluacionesDeAlumno1.Add(item);
                            item.Evaluacion = E;
                        }
                    }
                    foreach (Evaluacion E in EvaluacionesDocente2)
                    {
                        foreach (Evaluacion_de_Alumno item in BLL_Cursada_de_Alumno.Obtener_Calificacciones_Docente_Tema(Docente2, E))
                        {
                            EvaluacionesDeAlumno2.Add(item);
                            item.Evaluacion = E;
                        }
                    }

                    Asignar_Docente_a_Calificaciones(EvaluacionesDeAlumno1, Docente1);
                    Asignar_Docente_a_Calificaciones(EvaluacionesDeAlumno2, Docente2);

                    if (SessionManager.getInstance(ID).Idioma == 1)
                    {
                        SerieAprobada = "Resultado Positivo";
                        SerieReprobada = "Resultado Negativo";
                    }
                    else if (SessionManager.getInstance(ID).Idioma == 2)
                    {
                        SerieAprobada = "Positive Result";
                        SerieReprobada = "Negative Result";
                    }

                    Ajustar_Graficos(chartRendimiento);
                    Ajustar_Graficos(chartRendimiento2);

                    MostrarRendimiento(txtBoxRendimiento, Docente1, EvaluacionesDocente1, EvaluacionesDeAlumno1, SessionManager.getInstance(ID).Idioma);
                    MostrarRendimiento(txtBoxRendimiento2, Docente2, EvaluacionesDocente2, EvaluacionesDeAlumno2, SessionManager.getInstance(ID).Idioma);

                    Generar_Grafico_Docente(chartRendimiento, EvaluacionesDocente1, EvaluacionesDeAlumno1, Docente1, 0);
                    Generar_Grafico_Docente(chartRendimiento2, EvaluacionesDocente2, EvaluacionesDeAlumno2, Docente2, 0);

                    Obtener_Conclusion(SessionManager.getInstance(ID).Idioma);
                }
                else
                {
                    MessageBox.Show("Alguno de los dos Dictados no posee Evaluaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Se ha producido un Error Inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
        }        

        public void MostrarRendimiento(TextBox pTextBox, Docente pDocente, List<Evaluacion> pLE, List<Evaluacion_de_Alumno> pLEA, int pIdioma)
        {
            try
            {
                if (pIdioma == 1)
                {
                    foreach (Evaluacion Evaluacion in pLE)
                    {
                        List<Evaluacion_de_Alumno> LAUX = BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente_de_Evaluacion(pLEA, pDocente, Evaluacion);

                        pTextBox.Text += "\n\r" + "Materia: " + Evaluacion.Materia.Codigo + " - " + Evaluacion.Materia.Nombre + "\n\r\n\r";
                        pTextBox.Text += "Curso: " + Evaluacion.Materia.RetornarCurso().Codigo + " - " + Evaluacion.Materia.RetornarCurso().Nombre + " " + Evaluacion.Materia.RetornarCurso().Año + " - " + Evaluacion.Materia.RetornarCurso().Turno + "\n\r\n\r";
                        pTextBox.Text += "Evaluación: " + Evaluacion.Titulo + " - " + Evaluacion.Fecha.ToShortDateString() + "\n\r\n\r";
                        pTextBox.Text += "Cantidad de Exámenes Realizados: " + LAUX.Count.ToString() + "\n\r\n\r";
                        pTextBox.Text += "Cantidad de Exámenes Aprobados: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(LAUX) + "\n\r\n\r";
                        pTextBox.Text += "Cantidad de Exámenes Reprobados: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(LAUX) + "\n\r\n\r";

                        pTextBox.Text += "\n\r";
                        pTextBox.Text += "—————————————————————————————————————————————————\n\r\n\r";
                    }
                }
                else if (pIdioma == 2)
                {
                    foreach (Evaluacion Evaluacion in pLE)
                    {
                        List<Evaluacion_de_Alumno> LAUX = BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente_de_Evaluacion(pLEA, pDocente, Evaluacion);

                        pTextBox.Text += "\n\r" + "Matter: " + Evaluacion.Materia.Codigo + " - " + Evaluacion.Materia.Nombre + "\n\r\n\r";
                        pTextBox.Text += "Course: " + Evaluacion.Materia.RetornarCurso().Codigo + " - " + Evaluacion.Materia.RetornarCurso().Nombre + " " + Evaluacion.Materia.RetornarCurso().Año + " - " + Evaluacion.Materia.RetornarCurso().Turno + "\n\r\n\r";
                        pTextBox.Text += "Evaluation: " + Evaluacion.Titulo + " - " + Evaluacion.Fecha.ToShortDateString() + "\n\r\n\r";
                        pTextBox.Text += "Amount of exams performed: " + LAUX.Count.ToString() + "\n\r\n\r";
                        pTextBox.Text += "Amount of exams approved: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(LAUX) + "\n\r\n\r";
                        pTextBox.Text += "Amount of exams failed: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(LAUX) + "\n\r\n\r";

                        pTextBox.Text += "\n\r";
                        pTextBox.Text += "—————————————————————————————————————————————————\n\r\n\r";
                    }
                }

                

                pTextBox.Select(0, 0);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Generar_Grafico_Docente(System.Windows.Forms.DataVisualization.Charting.Chart pChart, List<Evaluacion> pLE, List<Evaluacion_de_Alumno> pLEA, Docente pDocente ,int pos)
        {
            chartRendimiento.Series[SerieAprobada].XValueMember = "Fecha";
            chartRendimiento.Series[SerieAprobada].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            chartRendimiento.Series[SerieAprobada].YValueMembers = "Promedio";
            chartRendimiento.Series[SerieAprobada].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            int Promedio = 0;

            foreach (Evaluacion Eva in pLE)
            {
                List<Evaluacion_de_Alumno> EvaluacionesDocente = BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(pLEA, pDocente);
                List<Evaluacion_de_Alumno> LevaAlu = BLL_Materia.Obtener_Calificaciones_de_Evaluacion(EvaluacionesDocente, Eva);

                Promedio = 0;

                foreach (Evaluacion_de_Alumno evaluacion_De_Alumno in LevaAlu)
                {
                    Promedio += evaluacion_De_Alumno.Calificacion;
                }

                Promedio = Promedio / LevaAlu.Count;

                Promedio *= 10;

                pChart.Series[SerieAprobada].Points.AddXY(Eva.Fecha.ToShortDateString() + "\n" + Eva.Titulo, Promedio);

                if (Promedio >= 60) { pChart.Series[SerieAprobada].Points[pos].Color = Color.FromArgb(27, 49, 192); }
                else
                {
                    pChart.Series[SerieAprobada].Points[pos].Color = Color.FromArgb(229, 20, 20);
                }

                pos++;
            }
        }

        public void Asignar_Docente_a_Calificaciones(List<Evaluacion_de_Alumno> pEvalAlu, Docente pDocente)
        {
            foreach (Evaluacion_de_Alumno EvaAlu in pEvalAlu)
            {
                EvaAlu.Docente = pDocente;
            }
        }

        public void Obtener_Conclusion(int pIdioma)
        {
            if (pIdioma == 1)
            {
                txtBoxConclusion.Font = new Font(txtBoxConclusion.Font, FontStyle.Bold);

                txtBoxConclusion.Text = "";

                txtBoxConclusion.Text += "El Docente " + Docente1.Apellido + " " + Docente1.Nombre + " evaluó " + EvaluacionesDocente1.Count() + " veces el Tema '" + Tema.Nombre + "' en distintos exámenes";
                txtBoxConclusion.Text += "\n\rEvaluaciones corregidas en total: " + EvaluacionesDeAlumno1.Count();
                txtBoxConclusion.Text += "\n\rEvaluaciones aprobadas en total: " + BLL_Cursada_de_Alumno.Obtener_Cant_Aprobados(EvaluacionesDeAlumno1).ToString();
                txtBoxConclusion.Text += "\n\rEvaluaciones reprobadas en total: " + BLL_Cursada_de_Alumno.Obtener_Cant_Reprobados(EvaluacionesDeAlumno1).ToString();

                txtBoxConclusion.Text += "\n\r\n\r";

                txtBoxConclusion.Text += "El Docente " + Docente2.Apellido + " " + Docente2.Nombre + " evaluó " + EvaluacionesDocente2.Count() + " veces el Tema '" + Tema.Nombre + "' en distintos exámenes";
                txtBoxConclusion.Text += "\n\rEvaluaciones corregidas en total: " + EvaluacionesDeAlumno2.Count();
                txtBoxConclusion.Text += "\n\rEvaluaciones aprobadas en total: " + BLL_Cursada_de_Alumno.Obtener_Cant_Aprobados(EvaluacionesDeAlumno2).ToString();
                txtBoxConclusion.Text += "\n\rEvaluaciones reprobadas en total: " + BLL_Cursada_de_Alumno.Obtener_Cant_Reprobados(EvaluacionesDeAlumno2).ToString();
            }
            else if (pIdioma == 2)
            {
                txtBoxConclusion.Font = new Font(txtBoxConclusion.Font, FontStyle.Bold);

                txtBoxConclusion.Text = "";

                txtBoxConclusion.Text += "The teacher " + Docente1.Apellido + " " + Docente1.Nombre + " evaluated " + EvaluacionesDocente1.Count() + " times the Topic '" + Tema.Nombre + "' in diferent exams";
                txtBoxConclusion.Text += "\n\rTotal Evaluations corrected: " + EvaluacionesDeAlumno1.Count();
                txtBoxConclusion.Text += "\n\rApproved Evaluations corrected: " + BLL_Cursada_de_Alumno.Obtener_Cant_Aprobados(EvaluacionesDeAlumno1).ToString();
                txtBoxConclusion.Text += "\n\rFailed Evaluations corrected: " + BLL_Cursada_de_Alumno.Obtener_Cant_Reprobados(EvaluacionesDeAlumno1).ToString();

                txtBoxConclusion.Text += "\n\r\n\r";

                txtBoxConclusion.Text += "The teacher " + Docente2.Apellido + " " + Docente2.Nombre + " evaluated " + EvaluacionesDocente2.Count() + " times the Topic '" + Tema.Nombre + "' in diferent exams";
                txtBoxConclusion.Text += "\n\rTotal Evaluations corrected: " + EvaluacionesDeAlumno2.Count();
                txtBoxConclusion.Text += "\n\rApproved Evaluations corrected: " + BLL_Cursada_de_Alumno.Obtener_Cant_Aprobados(EvaluacionesDeAlumno2).ToString();
                txtBoxConclusion.Text += "\n\rFailed Evaluations corrected: " + BLL_Cursada_de_Alumno.Obtener_Cant_Reprobados(EvaluacionesDeAlumno2).ToString();
            }
        }
        
        public void Ajustar_Graficos(System.Windows.Forms.DataVisualization.Charting.Chart pChart)
        {
            pChart.Series.Add(SerieAprobada);
            pChart.Series.Add(SerieReprobada);

            pChart.Series[SerieAprobada].Color = Color.FromArgb(27, 49, 192);
            pChart.Series[SerieReprobada].Color = Color.FromArgb(229, 20, 20);

            pChart.ChartAreas[0].AxisX.IsMarginVisible = false;
            pChart.ChartAreas[0].AxisY.IsMarginVisible = false;

            pChart.ChartAreas[0].AxisY.LabelStyle.Format = "{00} %";
            pChart.ChartAreas[0].AxisY.Maximum = 100;
        }
    }
}
