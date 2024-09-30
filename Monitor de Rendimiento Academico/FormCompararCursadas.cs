using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq.SqlClient;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;
using Entidades;
using BLL;

namespace Monitor_de_Rendimiento_Academico
{
    public partial class FormCompararCursadas : Form
    {
        public FormCompararCursadas(int pKey, Alumno pAlumno, Cursada_de_Alumno pCur1, Cursada_de_Alumno pCur2)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Alumno = pAlumno;
            Cursada_de_Alumno1 = pCur1;
            Cursada_de_Alumno2 = pCur2;
        }

        public int ID, counter;
        public string SerieAprobada, SerieReprobada;
        public decimal FaltasCursada1, FaltasCursada2;
        public Alumno Alumno;
        public Cursada_de_Alumno Cursada_de_Alumno1, Cursada_de_Alumno2;
        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        public List<Evaluacion_de_Alumno> EvaAlu1, EvaAlu2;

        private void FormCompararCursadas_Load(object sender, EventArgs e)
        {
            counter = 0;

            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            lblGraficoRendimientoCursada1.Text += " " + Cursada_de_Alumno1.Curso.Nombre + " - " + Cursada_de_Alumno1.Curso.Año;
            lblGraficoRendimientoCursada2.Text += " " + Cursada_de_Alumno2.Curso.Nombre + " - " + Cursada_de_Alumno2.Curso.Año;

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            FaltasCursada1 = BLL_Cursada_de_Alumno.Obtener_Total_Inasistencias_de_Cursada(Cursada_de_Alumno1);
            FaltasCursada2 = BLL_Cursada_de_Alumno.Obtener_Total_Inasistencias_de_Cursada(Cursada_de_Alumno2);

            EvaAlu1 = BLL_Cursada_de_Alumno.Obtener_Eva_Alu_Rendimiento(Cursada_de_Alumno1);
            EvaAlu2 = BLL_Cursada_de_Alumno.Obtener_Eva_Alu_Rendimiento(Cursada_de_Alumno2);

            if (EvaAlu1.Count > 0)
            {
                if (EvaAlu2.Count > 0 )
                {
                    if (SessionManager.getInstance(ID).Idioma==1)
                    {
                        SerieAprobada = "Evaluaciones Aprobadas";
                        SerieReprobada = "Evaluaciones Reprobadas";
                    }
                    else if (SessionManager.getInstance(ID).Idioma == 2)
                    {
                        SerieAprobada = "Approved Evaluations";
                        SerieReprobada = "Failed Evaluations";
                    }

                    Configurar_Graficos(chartRendimientoCursada1);
                    Configurar_Graficos(chartRendimientoCursada2);

                    MostrarRendimiento(SessionManager.getInstance(ID).Idioma,Cursada_de_Alumno1, EvaAlu1, FaltasCursada1);
                    MostrarRendimiento(SessionManager.getInstance(ID).Idioma,Cursada_de_Alumno2, EvaAlu2, FaltasCursada2);

                    foreach (Evaluacion_de_Alumno EA in EvaAlu1)
                    {
                        Generar_Grafico(chartRendimientoCursada1, EA, counter);
                        counter++;
                    }

                    counter = 0;

                    foreach (Evaluacion_de_Alumno EA in EvaAlu2)
                    {
                        Generar_Grafico(chartRendimientoCursada2, EA, counter);
                        counter++;
                    }

                    Obtener_Conclusion(SessionManager.getInstance(ID).Idioma);
                    MostrarRendimiento(SessionManager.getInstance(ID).Idioma, EvaAlu1, txtBoxRendC1);
                    MostrarRendimiento(SessionManager.getInstance(ID).Idioma, EvaAlu2, txtBoxRendC2);

                    lblRC1.Text += Cursada_de_Alumno1.Codigo + " - " + Cursada_de_Alumno1.Curso.Nombre;
                    lblRC2.Text += Cursada_de_Alumno2.Codigo + " - " + Cursada_de_Alumno2.Curso.Nombre;
                }
                else
                {
                    MessageBox.Show("La Cursada " + Cursada_de_Alumno2.Codigo + " - " + Cursada_de_Alumno2.Curso.Nombre + " no posee Evaluaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La Cursada " + Cursada_de_Alumno1.Codigo + " - " + Cursada_de_Alumno1.Curso.Nombre  + " no posee Evaluaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void MostrarRendimiento(int pIdioma, Cursada_de_Alumno pCursada, List<Evaluacion_de_Alumno> pEvaAlu, decimal pFaltas)
        {
            try
            {
                if (pIdioma==1)
                {
                    txtBoxRendimiento.Text += "\n\r" + "Cursada: " + pCursada.Curso.Codigo.ToString() + " - " + pCursada.Curso.Nombre + " - " + pCursada.Curso.Año.ToString() + " - " + pCursada.Curso.Turno + "\r\n\r\n";

                    string State = "";

                    if (pCursada.Libre == false)
                    {
                        State = "Regular";
                    }
                    else
                    {
                        State = "Libre";
                    }

                    txtBoxRendimiento.Text += "\n\rEstado de Cursada: " + State;
                    txtBoxRendimiento.Text += "\n\r";
                    txtBoxRendimiento.Text += "\n\rTotal de Faltas: " + pFaltas.ToString();

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\n\rMaterias aprobadas: ";

                    List<string> LM = BLL_Cursada_de_Alumno.Obtener_Materias_Mejor_Rendimiento(pEvaAlu);

                    if (LM.Count > 0)
                    {
                        foreach (string S in LM)
                        {
                            txtBoxRendimiento.Text += S + "-";
                        }

                        txtBoxRendimiento.Text = txtBoxRendimiento.Text.TrimEnd('-');
                    }
                    else
                    {
                        txtBoxRendimiento.Text += "-";
                    }

                    int CantAprobadas = LM.Count;

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\n\rMaterias reprobadas: ";

                    LM = null;

                    LM = BLL_Cursada_de_Alumno.Obtener_Materias_Peor_Rendimiento(pEvaAlu);

                    if (LM.Count > 0)
                    {
                        foreach (string S in LM)
                        {
                            txtBoxRendimiento.Text += S + "-";
                        }

                        txtBoxRendimiento.Text = txtBoxRendimiento.Text.TrimEnd('-');
                    }
                    else
                    {
                        txtBoxRendimiento.Text += "-";
                    }

                    int CantReprobadas = LM.Count;

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\n\r" + "Cantidad de Materias Total: " + BLL_Cursada_de_Alumno.Obtener_Cant_Materias(pEvaAlu) + "\r\n\r\n";
                    txtBoxRendimiento.Text += "\n\r" + "Cantidad de Materias Aprobadas: " + CantAprobadas.ToString() + "\r\n\r\n";
                    txtBoxRendimiento.Text += "\n\r" + "Cantidad de Materias Reprobadas: " + CantReprobadas.ToString() + "\r\n\r\n";

                    txtBoxRendimiento.Text += "\n\rTotal Evaluaciones: " + pEvaAlu.Count.ToString() + "\n\r\n\r";
                    txtBoxRendimiento.Text += "\n\rEvaluaciones Aprobadas: " + BLL_Cursada_de_Alumno.Obtener_Cant_Aprobados(pEvaAlu) + "\n\r\n\r";
                    txtBoxRendimiento.Text += "\n\rEvaluaciones Reprobadas: " + BLL_Cursada_de_Alumno.Obtener_Cant_Reprobados(pEvaAlu) + "\n\r\n\r";

                    txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";


                    txtBoxRendimiento.Select(0, 0);
                }
                else if (pIdioma==2)
                {
                    txtBoxRendimiento.Text += "\n\r" + "Course: " + pCursada.Curso.Codigo.ToString() + " - " + pCursada.Curso.Nombre + " - " + pCursada.Curso.Año.ToString() + " - " + pCursada.Curso.Turno + "\r\n\r\n";
                    
                    string State = "";

                    if (pCursada.Libre == false)
                    {
                        State = "Regular";
                    }
                    else
                    {
                        State = "Free";
                    }

                    txtBoxRendimiento.Text += "\n\rCourse State: " + State;
                    txtBoxRendimiento.Text += "\n\r";
                    txtBoxRendimiento.Text += "\n\rTotal absences: " + pFaltas.ToString();

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\n\rApproved Matters: ";

                    List<string> LM = BLL_Cursada_de_Alumno.Obtener_Materias_Mejor_Rendimiento(pEvaAlu);

                    if (LM.Count > 0)
                    {
                        foreach (string S in LM)
                        {
                            txtBoxRendimiento.Text += S + "-";
                        }

                        txtBoxRendimiento.Text = txtBoxRendimiento.Text.TrimEnd('-');
                    }
                    else
                    {
                        txtBoxRendimiento.Text += "-";
                    }

                    int CantAprobadas = LM.Count;

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\n\rFailed Matters: ";

                    LM = null;

                    LM = BLL_Cursada_de_Alumno.Obtener_Materias_Peor_Rendimiento(pEvaAlu);

                    if (LM.Count > 0)
                    {
                        foreach (string S in LM)
                        {
                            txtBoxRendimiento.Text += S + "-";
                        }

                        txtBoxRendimiento.Text = txtBoxRendimiento.Text.TrimEnd('-');
                    }
                    else
                    {
                        txtBoxRendimiento.Text += "-";
                    }

                    int CantReprobadas = LM.Count;

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\n\r" + "Total Matters Amount: " + BLL_Cursada_de_Alumno.Obtener_Cant_Materias(pEvaAlu) + "\r\n\r\n";
                    txtBoxRendimiento.Text += "\n\r" + "Total Approved Matters Amount: " + CantAprobadas.ToString() + "\r\n\r\n";
                    txtBoxRendimiento.Text += "\n\r" + "Total Failed Matters Amount:  " + CantReprobadas.ToString() + "\r\n\r\n";

                    txtBoxRendimiento.Text += "\n\rTotal Evaluations: " + pEvaAlu.Count.ToString() + "\n\r\n\r";
                    txtBoxRendimiento.Text += "\n\rEvaluaciones Approved: " + BLL_Cursada_de_Alumno.Obtener_Cant_Aprobados(pEvaAlu) + "\n\r\n\r";
                    txtBoxRendimiento.Text += "\n\rEvaluaciones Failed: " + BLL_Cursada_de_Alumno.Obtener_Cant_Reprobados(pEvaAlu) + "\n\r\n\r";

                    txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";

                    txtBoxRendimiento.Select(0, 0);
                }                             
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Obtener_Conclusion(int pIdioma)
        {
            int PromedioCur1 = BLL_Cursada_de_Alumno.Obtener_Promedio(EvaAlu1);
            int PromedioCur2 = BLL_Cursada_de_Alumno.Obtener_Promedio(EvaAlu2);

            if (pIdioma==1)
            {
                txtBoxConclusion.Text += "Promedio de la Cursada " + Cursada_de_Alumno1.Curso.Nombre + " - " + Cursada_de_Alumno1.Curso.Año.ToString() + ": " + PromedioCur1.ToString() + "\n\r";
                txtBoxConclusion.Text += "Promedio de la Cursada " + Cursada_de_Alumno2.Curso.Nombre + " - " + Cursada_de_Alumno2.Curso.Año.ToString() + ": " + PromedioCur2.ToString() + "\n\r";

                if (PromedioCur1 > PromedioCur2)
                {
                    txtBoxConclusion.Text += "El rendimiento de la Cursada " + Cursada_de_Alumno1.Curso.Nombre + " - " + Cursada_de_Alumno1.Curso.Año.ToString() + " es superior";
                }
                else if (PromedioCur1 < PromedioCur2)
                {
                    txtBoxConclusion.Text += "El rendimiento de la Cursada " + Cursada_de_Alumno2.Curso.Nombre + " - " + Cursada_de_Alumno2.Curso.Año.ToString() + " es superior";
                }
                else
                {
                    txtBoxConclusion.Text += "El rendimiento de ambas cursadas es igual";
                }
            }
            else if (pIdioma==2)
            {
                txtBoxConclusion.Text += "Average of the Course " + Cursada_de_Alumno1.Curso.Nombre + " - " + Cursada_de_Alumno1.Curso.Año.ToString() + ": " + PromedioCur1.ToString() + "\n\r";
                txtBoxConclusion.Text += "Average of the Course " + Cursada_de_Alumno2.Curso.Nombre + " - " + Cursada_de_Alumno2.Curso.Año.ToString() + ": " + PromedioCur2.ToString() + "\n\r";

                if (PromedioCur1 > PromedioCur2)
                {
                    txtBoxConclusion.Text += "The performance of the Student in the Course " + Cursada_de_Alumno1.Curso.Nombre + " - " + Cursada_de_Alumno1.Curso.Año.ToString() + " is superior";
                }
                else if (PromedioCur1 < PromedioCur2)
                {
                    txtBoxConclusion.Text += "The performance of the Student in the Course " + Cursada_de_Alumno2.Curso.Nombre + " - " + Cursada_de_Alumno2.Curso.Año.ToString() + " is superior";
                }
                else
                {
                    txtBoxConclusion.Text += "The performance of both courses is the same";
                }
            }            

            txtBoxConclusion.Select(0, 0);
        }
        
        public void Configurar_Graficos(System.Windows.Forms.DataVisualization.Charting.Chart pChart)
        {
            pChart.Series.Add(SerieAprobada);
            pChart.Series.Add(SerieReprobada);

            pChart.Series[SerieAprobada].Color = Color.FromArgb(27, 49, 192);
            pChart.Series[SerieReprobada].Color = Color.FromArgb(229, 20, 20);

            pChart.ChartAreas[0].AxisX.IsMarginVisible = false;
            pChart.ChartAreas[0].AxisY.IsMarginVisible = false;

            pChart.ChartAreas[0].AxisY.Interval = 1;
        }

        public void Generar_Grafico(System.Windows.Forms.DataVisualization.Charting.Chart pChart, Evaluacion_de_Alumno pEA, int pos)
        {
            pChart.Series[SerieAprobada].XValueMember = "Fecha";
            pChart.Series[SerieAprobada].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            pChart.Series[SerieAprobada].YValueMembers = "Calificación";
            pChart.Series[SerieAprobada].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            pChart.Series[SerieAprobada].Points.AddXY(pEA.Fecha.ToShortDateString() + "\n" + pEA.Evaluacion.Materia.Nombre, pEA.Calificacion);

            if (pEA.Calificacion >= 6) { pChart.Series[SerieAprobada].Points[pos].Color = Color.FromArgb(27, 49, 192); }
            else
            {
                pChart.Series[SerieAprobada].Points[pos].Color = Color.FromArgb(229, 20, 20);
            }
        }

        public void MostrarRendimiento(int pIdioma, List<Evaluacion_de_Alumno> pLEA, TextBox pTextBox)
        {
            try
            {
                if (pIdioma == 1)
                {

                    foreach (Evaluacion_de_Alumno EA in pLEA)
                    {
                        pTextBox.Text += "\n\r" + "Materia: " + EA.Evaluacion.Codigo + " - " + EA.Evaluacion.Materia.Nombre + "\n\r\n\r";
                        pTextBox.Text += "\n\r" + "Evaluación: " + EA.Evaluacion.Codigo.ToString() + " - " + EA.Evaluacion.Titulo + " - " + EA.Fecha.ToShortDateString() + "\n\r\n\r";
                        pTextBox.Text += "\n\r" + "Calificación: " + EA.Calificacion.ToString() + "\n\r\n\r";
                        pTextBox.Text += "\n\r" + "Temas: ";

                        foreach (Tema T in EA.Evaluacion.VerTemas())
                        {
                            pTextBox.Text += T.Nombre + "-";
                        }

                        pTextBox.Text = pTextBox.Text.TrimEnd('-');
                        pTextBox.Text += "\n\r\n\r";

                        pTextBox.Text += "\n\r" + "Docente: " + EA.Docente.Legajo + " - " + EA.Docente.Apellido + ", " + EA.Docente.Nombre + "\n\r\n\r";

                        pTextBox.Text += "————————————————————————————————————————————————\n\r\n\r";
                    }

                    pTextBox.Text += "Detalles:\n\r\n\r";
                    pTextBox.Text += "\n\rTotal Evaluaciones: " + pLEA.Count.ToString() + "\n\r\n\r";
                    pTextBox.Text += "\n\rEvaluaciones Aprobadas: " + BLL_Cursada_de_Alumno.Obtener_Cant_Aprobados(pLEA) + "\n\r\n\r";
                    pTextBox.Text += "\n\rEvaluaciones Reprobadas: " + BLL_Cursada_de_Alumno.Obtener_Cant_Reprobados(pLEA) + "\n\r\n\r";
                    pTextBox.Text += "\n\rMaterias aprobadas: ";

                    List<string> LM = BLL_Cursada_de_Alumno.Obtener_Materias_Mejor_Rendimiento(pLEA);

                    if (LM.Count > 0)
                    {
                        foreach (string S in LM)
                        {
                            pTextBox.Text += S + "-";
                        }

                        pTextBox.Text = pTextBox.Text.TrimEnd('-');
                    }
                    else
                    {
                        pTextBox.Text += "-";
                    }

                    int CantAprobadas = LM.Count;
                    int CMatAprobadas = LM.Count;

                    pTextBox.Text += "\n\r\n\r";

                    pTextBox.Text += "\n\rMaterias reprobadas: ";

                    LM = null;

                    LM = BLL_Cursada_de_Alumno.Obtener_Materias_Peor_Rendimiento(pLEA);

                    if (LM.Count > 0)
                    {
                        foreach (string S in LM)
                        {
                            pTextBox.Text += S + "-";
                        }

                        pTextBox.Text = pTextBox.Text.TrimEnd('-');
                    }
                    else
                    {
                        pTextBox.Text += "-";
                    }

                    int CantReprobadas = LM.Count;
                    int CMatReprobadas = LM.Count;

                    pTextBox.Text += "\n\r\n\r";

                    pTextBox.Text += "\n\rCantidad de Materias Total: " + BLL_Cursada_de_Alumno.Obtener_Cant_Materias(pLEA).ToString();

                    pTextBox.Text += "\n\r\n\r";

                    pTextBox.Text += "\n\rCantidad de Materias Aprobadas: " + CantAprobadas.ToString();

                    pTextBox.Text += "\n\r\n\r";

                    pTextBox.Text += "\n\rCantidad de Materias Reprobadas: " + CantReprobadas.ToString();

                    pTextBox.Text += "\n\r\n\r";

                    pTextBox.Select(0, 0);
                }
                else if (pIdioma == 2)
                {

                    foreach (Evaluacion_de_Alumno EA in pLEA)
                    {
                        pTextBox.Text += "\n\r" + "Matter: " + EA.Evaluacion.Codigo + " - " + EA.Evaluacion.Materia.Nombre + "\n\r\n\r";
                        pTextBox.Text += "\n\r" + "Evaluation: " + EA.Evaluacion.Codigo.ToString() + " - " + EA.Evaluacion.Titulo + " - " + EA.Fecha.ToShortDateString() + "\n\r\n\r";
                        pTextBox.Text += "\n\r" + "Calification: " + EA.Calificacion.ToString() + "\n\r\n\r";
                        pTextBox.Text += "\n\r" + "Topics: ";

                        foreach (Tema T in EA.Evaluacion.VerTemas())
                        {
                            pTextBox.Text += T.Nombre + "-";
                        }

                        pTextBox.Text = pTextBox.Text.TrimEnd('-');
                        pTextBox.Text += "\n\r\n\r";

                        pTextBox.Text += "\n\r" + "Teacher: " + EA.Docente.Legajo + " - " + EA.Docente.Apellido + ", " + EA.Docente.Nombre + "\n\r\n\r";

                        pTextBox.Text += "————————————————————————————————————————————————\n\r\n\r";
                    }

                    pTextBox.Text += "Detalles:\n\r\n\r";
                    pTextBox.Text += "\n\rTotal Evaluations: " + pLEA.Count.ToString() + "\n\r\n\r";
                    pTextBox.Text += "\n\rTotal Approved Evaluations:  " + BLL_Cursada_de_Alumno.Obtener_Cant_Aprobados(pLEA) + "\n\r\n\r";
                    pTextBox.Text += "\n\rTotal Failed Evaluations: " + BLL_Cursada_de_Alumno.Obtener_Cant_Reprobados(pLEA) + "\n\r\n\r";
                    pTextBox.Text += "\n\rApproved Matters: ";

                    List<string> LM = BLL_Cursada_de_Alumno.Obtener_Materias_Mejor_Rendimiento(pLEA);

                    if (LM.Count > 0)
                    {
                        foreach (string S in LM)
                        {
                            pTextBox.Text += S + "-";
                        }

                        pTextBox.Text = pTextBox.Text.TrimEnd('-');
                    }
                    else
                    {
                        pTextBox.Text += "-";
                    }

                    int CantAprobadas = LM.Count;
                    int CMatAprobadas = LM.Count;

                    pTextBox.Text += "\n\r\n\r";

                    pTextBox.Text += "\n\rFailed Matters:  ";

                    LM = null;

                    LM = BLL_Cursada_de_Alumno.Obtener_Materias_Peor_Rendimiento(pLEA);

                    if (LM.Count > 0)
                    {
                        foreach (string S in LM)
                        {
                            pTextBox.Text += S + "-";
                        }

                        pTextBox.Text = pTextBox.Text.TrimEnd('-');
                    }
                    else
                    {
                        pTextBox.Text += "-";
                    }

                    int CantReprobadas = LM.Count;
                    int CMatReprobadas = LM.Count;

                    pTextBox.Text += "\n\r\n\r";

                    pTextBox.Text += "\n\rTotal Amount of Matters: " + BLL_Cursada_de_Alumno.Obtener_Cant_Materias(pLEA).ToString();

                    pTextBox.Text += "\n\r\n\r";

                    pTextBox.Text += "\n\rTotal Amount of Matters Approved: " + CantAprobadas.ToString();

                    pTextBox.Text += "\n\r\n\r";

                    pTextBox.Text += "\n\rTotal Amount of Matters Failed: " + CantReprobadas.ToString();

                    pTextBox.Text += "\n\r\n\r";

                    pTextBox.Select(0, 0);
                }

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
