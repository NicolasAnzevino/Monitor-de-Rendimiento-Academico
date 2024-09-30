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
    public partial class FormVerRendimientoDocente : Form
    {
        public FormVerRendimientoDocente(int pKey, Docente pDocente, Dictado pDictado)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Docente = pDocente;
            Dictado = pDictado;
        }

        public int ID;
        public string SerieAprobada, SerieReprobada;
        public Docente Docente;
        public Dictado Dictado;

        public BLL_Docente BLL_Docente;
        public BLL_Dictado BLL_Dictado;
        public BLL_Materia BLL_Materia;
        List<Evaluacion_de_Alumno> EvaluacionesDeAlumno;
        List<Evaluacion> Evaluaciones;

        private void FormVerRendimientoDocente_Load(object sender, EventArgs e)
        {
            try
            {
                TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

                this.MaximizeBox = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;

                BLL_Docente = new BLL_Docente();
                BLL_Dictado = new BLL_Dictado();
                BLL_Materia = new BLL_Materia();

                EvaluacionesDeAlumno = BLL_Materia.Ver_Evaluaciones_de_Alumno_de_Materia(Dictado.Materia);
                Evaluaciones = BLL_Materia.Obtener_Evaluaciones_de_Calificacion(EvaluacionesDeAlumno);

                if (EvaluacionesDeAlumno.Count > 0 && Evaluaciones.Count > 0)
                {
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

                    chartRendimiento.Series.Add(SerieAprobada);
                    chartRendimiento.Series.Add(SerieReprobada);

                    chartRendimiento.Series[SerieAprobada].Color = Color.FromArgb(27, 49, 192);
                    chartRendimiento.Series[SerieReprobada].Color = Color.FromArgb(229, 20, 20);

                    chartRendimiento.ChartAreas[0].AxisX.IsMarginVisible = false;
                    chartRendimiento.ChartAreas[0].AxisY.IsMarginVisible = false;

                    chartRendimiento.ChartAreas[0].AxisY.LabelStyle.Format = "{00} %";
                    chartRendimiento.ChartAreas[0].AxisY.Maximum = 100;

                    MostrarRendimiento(1, SessionManager.getInstance(ID).Idioma);
                    Generar_Grafico_Docente(EvaluacionesDeAlumno, 0);
                }
                else
                {
                    MessageBox.Show("Este Dictado no posee Evaluaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex) { this.Close(); }       
        }

        public void MostrarRendimiento(int pValor, int pIdioma)
        {
            try
            {
                if (pIdioma==1)
                {
                    if (pValor == 1)
                    {
                        txtBoxRendimiento.Text += "\n\r" + "Materia: " + Dictado.Materia.Nombre + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Curso: " + Dictado.Curso.Nombre + " - " + Dictado.Curso.Año.ToString() + " - " + Dictado.Curso.Turno + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Cantidad de Evaluaciones: " + Evaluaciones.Count().ToString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Total de Evaluaciones Corregidas por el Docente: " + BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente).Count().ToString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Total de Evaluaciones Corregidas por el Docente Aprobadas: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente)) + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Total de Evaluaciones Corregidas por el Docente Reprobadas: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente)) + "\n\r\n\r";

                        foreach (Evaluacion evaluacion in Evaluaciones)
                        {
                            txtBoxRendimiento.Text += "\n\r\n\r";

                            txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";

                            List<Evaluacion_de_Alumno> EvaAux = BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente_de_Evaluacion(EvaluacionesDeAlumno, Docente, evaluacion);

                            if (EvaAux.Count > 0)
                            {

                                txtBoxRendimiento.Text += "\n\r" + evaluacion.Codigo + " - " + evaluacion.Titulo + " - " + evaluacion.Fecha.ToShortDateString() + "\n\r\n\r";
                                txtBoxRendimiento.Text += "\n\r" + "Cantidad de Evaluaciones Corregidas por el Docente: " + EvaAux.Count.ToString() + "\n\r\n\r";
                                txtBoxRendimiento.Text += "\n\r" + "Total de Evaluaciones Corregidas por el Docente Aprobadas: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(EvaAux) + "\n\r\n\r";
                                txtBoxRendimiento.Text += "\n\r" + "Total de Evaluaciones Corregidas por el Docente Reprobadas: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(EvaAux) + "\n\r\n\r";
                            }
                            else { txtBoxRendimiento.Text = ""; this.Close(); throw new Exception("Este Docente no posee Evaluaciones corregidas en este Dictado"); }

                        }

                        txtBoxConclusion.Font = new Font(txtBoxConclusion.Font, FontStyle.Bold);

                        txtBoxConclusion.Text = BLL_Docente.Obtener_Conclusion(Docente, BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente), SessionManager.getInstance(ID).Idioma);

                        txtBoxRendimiento.Select(0, 0);
                        txtBoxConclusion.Select(0, 0);
                    }
                    else
                    {
                        txtBoxRendimiento.Text += "\n\r" + "Materia: " + Dictado.Materia.Nombre + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Curso: " + Dictado.Curso.Nombre + " - " + Dictado.Curso.Año.ToString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Cantidad de Evaluaciones: " + Evaluaciones.Count().ToString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Total de Evaluaciones Corregidas: " + EvaluacionesDeAlumno.Count().ToString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Total de Evaluaciones Corregidas Aprobadas: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(EvaluacionesDeAlumno) + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Total de Evaluaciones Corregidas Reprobadas: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(EvaluacionesDeAlumno) + "\n\r\n\r";

                        foreach (Evaluacion evaluacion in Evaluaciones)
                        {
                            txtBoxRendimiento.Text += "\n\r\n\r";

                            txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";

                            List<Evaluacion_de_Alumno> EvaAux = BLL_Materia.Obtener_Calificaciones_de_Evaluacion(EvaluacionesDeAlumno, evaluacion);

                            txtBoxRendimiento.Text += "\n\r" + evaluacion.Codigo + " - " + evaluacion.Titulo + " - " + evaluacion.Fecha.ToShortDateString() + "\n\r\n\r";
                            txtBoxRendimiento.Text += "\n\r" + "Cantidad de Evaluaciones Corregidas: " + EvaAux.Count.ToString() + "\n\r\n\r";
                            txtBoxRendimiento.Text += "\n\r" + "Total de Evaluaciones Corregidas Aprobadas: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(EvaAux) + "\n\r\n\r";
                            txtBoxRendimiento.Text += "\n\r" + "Total de Evaluaciones Corregidas Reprobadas: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(EvaAux) + "\n\r\n\r";
                        }

                        txtBoxConclusion.Font = new Font(txtBoxConclusion.Font, FontStyle.Bold);

                        txtBoxConclusion.Text = "";

                        txtBoxRendimiento.Select(0, 0);
                        txtBoxConclusion.Select(0, 0);
                    }
                }
                else if (pIdioma==2)
                {
                    if (pValor == 1)
                    {
                        txtBoxRendimiento.Text += "\n\r" + "Matter: " + Dictado.Materia.Nombre + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Course: " + Dictado.Curso.Nombre + " - " + Dictado.Curso.Año.ToString() + " - " + Dictado.Curso.Turno + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Evaluation Amount: " + Evaluaciones.Count().ToString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Total Evaluation corrected by the Teacher: " + BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente).Count().ToString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Total Evaluation corrected by the Teacher Approved: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente)) + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Total Evaluation corrected by the Teacher Failed: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente)) + "\n\r\n\r";

                        foreach (Evaluacion evaluacion in Evaluaciones)
                        {
                            txtBoxRendimiento.Text += "\n\r\n\r";

                            txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";

                            List<Evaluacion_de_Alumno> EvaAux = BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente_de_Evaluacion(EvaluacionesDeAlumno, Docente, evaluacion);

                            if (EvaAux.Count > 0)
                            {

                                txtBoxRendimiento.Text += "\n\r" + evaluacion.Codigo + " - " + evaluacion.Titulo + " - " + evaluacion.Fecha.ToShortDateString() + "\n\r\n\r";
                                txtBoxRendimiento.Text += "\n\r" + "Total Evaluation corrected by the Teacher: " + EvaAux.Count.ToString() + "\n\r\n\r";
                                txtBoxRendimiento.Text += "\n\r" + "Total Evaluation corrected by the Teacher Approved: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(EvaAux) + "\n\r\n\r";
                                txtBoxRendimiento.Text += "\n\r" + "Total Evaluation corrected by the Teacher Failed: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(EvaAux) + "\n\r\n\r";
                            }
                            else { txtBoxRendimiento.Text = ""; this.Close(); throw new Exception("Este Docente no posee Evaluaciones corregidas en este Dictado"); }

                        }

                        txtBoxConclusion.Font = new Font(txtBoxConclusion.Font, FontStyle.Bold);

                        txtBoxConclusion.Text = BLL_Docente.Obtener_Conclusion(Docente, BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente), SessionManager.getInstance(ID).Idioma);

                        txtBoxRendimiento.Select(0, 0);
                        txtBoxConclusion.Select(0, 0);
                    }
                    else
                    {
                        txtBoxRendimiento.Text += "\n\r" + "Matter: " + Dictado.Materia.Nombre + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Course: " + Dictado.Curso.Nombre + " - " + Dictado.Curso.Año.ToString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Evaluation Amount: " + Evaluaciones.Count().ToString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Total Evaluation corrected by the Teacher: " + EvaluacionesDeAlumno.Count().ToString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Total Evaluation corrected by the Teacher Approved: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(EvaluacionesDeAlumno) + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Total Evaluation corrected by the Teacher Failed: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(EvaluacionesDeAlumno) + "\n\r\n\r";

                        foreach (Evaluacion evaluacion in Evaluaciones)
                        {
                            txtBoxRendimiento.Text += "\n\r\n\r";

                            txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";

                            List<Evaluacion_de_Alumno> EvaAux = BLL_Materia.Obtener_Calificaciones_de_Evaluacion(EvaluacionesDeAlumno, evaluacion);

                            txtBoxRendimiento.Text += "\n\r" + evaluacion.Codigo + " - " + evaluacion.Titulo + " - " + evaluacion.Fecha.ToShortDateString() + "\n\r\n\r";
                            txtBoxRendimiento.Text += "\n\r" + "Total Evaluation corrected by the Teacher: " + EvaAux.Count.ToString() + "\n\r\n\r";
                            txtBoxRendimiento.Text += "\n\r" + "Total Evaluation corrected by the Teacher Approved: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(EvaAux) + "\n\r\n\r";
                            txtBoxRendimiento.Text += "\n\r" + "Total Evaluation corrected by the Teacher Failed: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(EvaAux) + "\n\r\n\r";
                        }

                        txtBoxConclusion.Font = new Font(txtBoxConclusion.Font, FontStyle.Bold);

                        txtBoxConclusion.Text = "";

                        txtBoxRendimiento.Select(0, 0);
                        txtBoxConclusion.Select(0, 0);
                    }
                }

                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public void Generar_Grafico_Dictado(List<Evaluacion_de_Alumno> pLEA, int pos)
        {
            chartRendimiento.Series[SerieAprobada].XValueMember = "Fecha";
            chartRendimiento.Series[SerieAprobada].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            chartRendimiento.Series[SerieAprobada].YValueMembers = "Promedio";
            chartRendimiento.Series[SerieAprobada].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            int Promedio = 0;

            foreach (Evaluacion Eva in Evaluaciones)
            {
                List<Evaluacion_de_Alumno> LevaAlu = BLL_Materia.Obtener_Calificaciones_de_Evaluacion(pLEA, Eva);

                Promedio = 0;

                foreach (Evaluacion_de_Alumno evaluacion_De_Alumno in LevaAlu)
                {
                    Promedio += evaluacion_De_Alumno.Calificacion;
                }

                Promedio = Promedio / LevaAlu.Count;

                Promedio *= 10;
               
                chartRendimiento.Series[SerieAprobada].Points.AddXY(Eva.Fecha.ToShortDateString() + "\n" + Eva.Titulo, Promedio);

                if (Promedio >= 60) { chartRendimiento.Series[SerieAprobada].Points[pos].Color = Color.FromArgb(27, 49, 192); }
                else
                {
                    chartRendimiento.Series[SerieAprobada].Points[pos].Color = Color.FromArgb(229, 20, 20);
                }

                pos++;
            }
        }

        public void Generar_Grafico_Docente(List<Evaluacion_de_Alumno> pLEA, int pos)
        {
            chartRendimiento.Series[SerieAprobada].XValueMember = "Fecha";
            chartRendimiento.Series[SerieAprobada].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            chartRendimiento.Series[SerieAprobada].YValueMembers = "Promedio";
            chartRendimiento.Series[SerieAprobada].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            int Promedio = 0;

            foreach (Evaluacion Eva in Evaluaciones)
            {
                List<Evaluacion_de_Alumno> EvaluacionesDocente = BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(pLEA, Docente);
                List<Evaluacion_de_Alumno> LevaAlu = BLL_Materia.Obtener_Calificaciones_de_Evaluacion(EvaluacionesDocente, Eva);

                Promedio = 0;

                foreach (Evaluacion_de_Alumno evaluacion_De_Alumno in LevaAlu)
                {
                    Promedio += evaluacion_De_Alumno.Calificacion;
                }

                Promedio = Promedio / LevaAlu.Count;

                Promedio *= 10;

                chartRendimiento.Series[SerieAprobada].Points.AddXY(Eva.Fecha.ToShortDateString() + "\n" + Eva.Titulo, Promedio);

                if (Promedio >= 60) { chartRendimiento.Series[SerieAprobada].Points[pos].Color = Color.FromArgb(27, 49, 192); }
                else
                {
                    chartRendimiento.Series[SerieAprobada].Points[pos].Color = Color.FromArgb(229, 20, 20);
                }

                pos++;
            }
        }

        private void rbRendimientoDocente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRendimientoDocente.Checked == true)
            {
                btnGenerarInforme.Enabled = true;

                txtBoxRendimiento.Text = "";
                txtBoxConclusion.Text = "";

                foreach (var series in chartRendimiento.Series)
                {
                    series.Points.Clear();
                }

                Generar_Grafico_Docente(EvaluacionesDeAlumno, 0);
                MostrarRendimiento(1, SessionManager.getInstance(ID).Idioma);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (SessionManager.getInstance(ID).Idioma == 1)
            {
                int Fila = 10, Columna = 0;
                Font F = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);

                e.Graphics.DrawString("Legajo: ", F, Brushes.Black, Columna, Fila);
                e.Graphics.DrawString(Docente.Legajo, F, Brushes.DarkBlue, Columna + 55, Fila);
                e.Graphics.DrawString("DNI: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Docente.DNI.ToString(), F, Brushes.DarkBlue, Columna + 35, Fila);
                e.Graphics.DrawString("Apellido: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Docente.Apellido, F, Brushes.DarkBlue, Columna + 60, Fila);
                e.Graphics.DrawString("Nombre: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Docente.Nombre, F, Brushes.DarkBlue, Columna + 60, Fila);
                e.Graphics.DrawString("Curso: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Dictado.Curso.Nombre + " - " + Dictado.Curso.Año.ToString() + " - " + Dictado.Curso.Turno, F, Brushes.DarkBlue, Columna + 50, Fila);
                e.Graphics.DrawString("Materia: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Dictado.Materia.Nombre, F, Brushes.DarkBlue, Columna + 58, Fila);

                Columna = 727;

                e.Graphics.DrawString(DateTime.Now.ToShortDateString(), F, Brushes.Black, Columna, Fila - 140);

                Fila += 35;
                e.Graphics.DrawString(DateTime.Now.ToShortTimeString(), F, Brushes.Black, Columna, Fila - 140);

                Fila += 10;
                e.Graphics.DrawLine(Pens.Black, new Point(35, Fila += 25), new Point(787, Fila));

                F = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);

                Fila += 5;
                e.Graphics.DrawString("Cantidad de Evaluaciones total: " + Evaluaciones.Count().ToString(), F, Brushes.Black, 45, Fila);

                Fila += 35;

                e.Graphics.DrawString("Cantidad de Evaluaciones corregidas por el Docente: " + BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente).Count().ToString(), F, Brushes.Black, 45, Fila);

                Fila += 35;

                e.Graphics.DrawString("Cantidad de Evaluaciones corregidas por el Docente Aprobadas: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente)).ToString(), F, Brushes.Black, 45, Fila);

                Fila += 35;

                e.Graphics.DrawString("Cantidad de Evaluaciones corregidas por el Docente Reprobadas: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente)).ToString(), F, Brushes.Black, 45, Fila);

                foreach (Evaluacion evaluacion in Evaluaciones)
                {
                    e.Graphics.DrawLine(Pens.Black, new Point(35, Fila += 25), new Point(787, Fila));

                    List<Evaluacion_de_Alumno> EvaAux = BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente_de_Evaluacion(EvaluacionesDeAlumno, Docente, evaluacion);

                    e.Graphics.DrawString(evaluacion.Codigo + " - " + evaluacion.Titulo + " - " + evaluacion.Fecha.ToShortDateString(), F, Brushes.Black, 45, Fila += 35);
                    e.Graphics.DrawString("Cantidad de Evaluaciones Corregidas por el Docente: " + EvaAux.Count.ToString(), F, Brushes.Black, 45, Fila += 35);
                    e.Graphics.DrawString("Total de Evaluaciones Corregidas por el Docente Aprobadas: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(EvaAux), F, Brushes.Black, 45, Fila += 35);
                    e.Graphics.DrawString("Total de Evaluaciones Corregidas por el Docente Reprobadas: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(EvaAux), F, Brushes.Black, 45, Fila += 35);

                    Fila += 10;
                }

                e.Graphics.DrawLine(Pens.Black, new Point(35, Fila += 25), new Point(787, Fila));

                Columna = 45;

                F = new Font("Arial", 10, FontStyle.Underline | FontStyle.Bold, GraphicsUnit.Point);

                e.Graphics.DrawString("Conclusión: ", F, Brushes.DarkBlue, Columna, Fila += 45);

                F = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);

                e.Graphics.DrawString(BLL_Docente.Obtener_Conclusion(Docente, BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente), 1), F, Brushes.DarkBlue, Columna, Fila += 35);
            }

            else if (SessionManager.getInstance(ID).Idioma == 2)
            {
                int Fila = 10, Columna = 0;
                Font F = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);

                e.Graphics.DrawString("ID: ", F, Brushes.Black, Columna, Fila);
                e.Graphics.DrawString(Docente.Legajo, F, Brushes.DarkBlue, Columna + 30, Fila);
                e.Graphics.DrawString("Document Number: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Docente.DNI.ToString(), F, Brushes.DarkBlue, Columna + 135, Fila);
                e.Graphics.DrawString("Surname: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Docente.Apellido, F, Brushes.DarkBlue, Columna + 67, Fila);
                e.Graphics.DrawString("Name: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Docente.Nombre, F, Brushes.DarkBlue, Columna + 60, Fila);
                e.Graphics.DrawString("Course: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Dictado.Curso.Nombre + " - " + Dictado.Curso.Año.ToString() + " - " + Dictado.Curso.Turno, F, Brushes.DarkBlue, Columna + 57, Fila);
                e.Graphics.DrawString("Matter: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Dictado.Materia.Nombre, F, Brushes.DarkBlue, Columna + 58, Fila);

                Columna = 727;

                e.Graphics.DrawString(DateTime.Now.ToShortDateString(), F, Brushes.Black, Columna, Fila - 140);

                Fila += 35;
                e.Graphics.DrawString(DateTime.Now.ToShortTimeString(), F, Brushes.Black, Columna, Fila - 140);

                Fila += 10;
                e.Graphics.DrawLine(Pens.Black, new Point(35, Fila += 25), new Point(787, Fila));

                F = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);

                Fila += 5;
                e.Graphics.DrawString("Total Number of Evaluations: " + Evaluaciones.Count().ToString(), F, Brushes.Black, 45, Fila);

                Fila += 35;

                e.Graphics.DrawString("Total Number of Evaluations corrected by the Teacher: " + BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente).Count().ToString(), F, Brushes.Black, 45, Fila);

                Fila += 35;

                e.Graphics.DrawString("Total Number of approved Evaluations corrected by the Teacher: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente)).ToString(), F, Brushes.Black, 45, Fila);

                Fila += 35;

                e.Graphics.DrawString("Total Number of failed Evaluations corrected by the Teacher:  " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente)).ToString(), F, Brushes.Black, 45, Fila);

                foreach (Evaluacion evaluacion in Evaluaciones)
                {
                    e.Graphics.DrawLine(Pens.Black, new Point(35, Fila += 25), new Point(787, Fila));

                    List<Evaluacion_de_Alumno> EvaAux = BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente_de_Evaluacion(EvaluacionesDeAlumno, Docente, evaluacion);

                    e.Graphics.DrawString(evaluacion.Codigo + " - " + evaluacion.Titulo + " - " + evaluacion.Fecha.ToShortDateString(), F, Brushes.Black, 45, Fila += 35);
                    e.Graphics.DrawString("Total Number of Evaluations corrected by the Teacher: " + EvaAux.Count.ToString(), F, Brushes.Black, 45, Fila += 35);
                    e.Graphics.DrawString("Total Number of approved Evaluations corrected by the Teacher: " + BLL_Materia.Obtener_Cant_Calificaciones_Aprobadas(EvaAux), F, Brushes.Black, 45, Fila += 35);
                    e.Graphics.DrawString("Total Number of failed Evaluations corrected by the Teacher: " + BLL_Materia.Obtener_Cant_Calificaciones_Reprobadas(EvaAux), F, Brushes.Black, 45, Fila += 35);

                    Fila += 10;
                }

                e.Graphics.DrawLine(Pens.Black, new Point(35, Fila += 25), new Point(787, Fila));

                Columna = 45;

                F = new Font("Arial", 10, FontStyle.Underline | FontStyle.Bold, GraphicsUnit.Point);

                e.Graphics.DrawString("Conclution: ", F, Brushes.DarkBlue, Columna, Fila += 45);

                F = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);

                e.Graphics.DrawString(BLL_Docente.Obtener_Conclusion(Docente, BLL_Materia.Obtener_Calificaciones_corregidas_por_Docente(EvaluacionesDeAlumno, Docente), 2), F, Brushes.DarkBlue, Columna, Fila += 35);
            }            
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void rbRendimientoDictado_CheckedChanged(object sender, EventArgs e)
        {
            btnGenerarInforme.Enabled = false;

            txtBoxRendimiento.Text = "";
            txtBoxConclusion.Text = "";

            foreach (var series in chartRendimiento.Series)
            {
                series.Points.Clear();
            }

            Generar_Grafico_Dictado(EvaluacionesDeAlumno, 0);
            MostrarRendimiento(0, SessionManager.getInstance(ID).Idioma);
        }  
    }
}
