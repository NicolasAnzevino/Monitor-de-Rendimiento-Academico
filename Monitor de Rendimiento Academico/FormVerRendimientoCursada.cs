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
    public partial class FormVerRendimientoCursada : Form
    {
        public FormVerRendimientoCursada(int pKey, Alumno pAlumno, Cursada_de_Alumno pCursada_de_Alumno)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Alumno = pAlumno;
            Cursada_de_Alumno = pCursada_de_Alumno;
        }

        public int ID, CMatAprobadas, CMatReprobadas;
        public decimal Faltas;
        public string SerieAprobada, SerieReprobada;
        public Alumno Alumno;
        public Cursada_de_Alumno Cursada_de_Alumno;
        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        public List<Evaluacion_de_Alumno> EvaAlu;

        private void FormVerRendimientoCursada_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            txtBoxFecha1.Mask = "00/00/0000";
            txtBoxFecha2.Mask = "00/00/0000";

            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            Faltas = BLL_Cursada_de_Alumno.Obtener_Total_Inasistencias_de_Cursada(Cursada_de_Alumno);

            EvaAlu = BLL_Cursada_de_Alumno.Obtener_Eva_Alu_Rendimiento(Cursada_de_Alumno);


            if(EvaAlu.Count>0)
            {
                if (SessionManager.getInstance(ID).Idioma == 1)
                {
                    SerieAprobada = "Evaluaciones Aprobadas";
                    SerieReprobada = "Evaluaciones Reprobadas";
                }
                else if (SessionManager.getInstance(ID).Idioma == 2)
                {
                    SerieAprobada = "Approved Evaluations";
                    SerieReprobada = "Failed Evaluations";
                }

                chartRendimiento.Series.Add(SerieAprobada);
                chartRendimiento.Series.Add(SerieReprobada);

                chartRendimiento.Series[SerieAprobada].Color = Color.FromArgb(27, 49, 192);
                chartRendimiento.Series[SerieReprobada].Color = Color.FromArgb(229, 20, 20);

                chartRendimiento.ChartAreas[0].AxisX.IsMarginVisible = false;
                chartRendimiento.ChartAreas[0].AxisY.IsMarginVisible = false;

                chartRendimiento.ChartAreas[0].AxisY.Interval = 1;

                MostrarRendimiento(SessionManager.getInstance(ID).Idioma);
            }
            else
            {
                MessageBox.Show("Esta Cursada no posee Evaluaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            lblMateria.Visible = false;
            lblFecha1.Visible = false;
            lblFecha2.Visible = false;

            txtBoxMateria.Visible = false;
            txtBoxFecha1.Visible = false;
            txtBoxFecha2.Visible = false;
        }        

        public void MostrarRendimiento(int pIdioma)
        {
            try
            {
                if (pIdioma==1)
                {
                    int counter = 0;

                    foreach (Evaluacion_de_Alumno EA in EvaAlu)
                    {
                        txtBoxRendimiento.Text += "\n\r" + "Materia: " + EA.Evaluacion.Codigo + " - " + EA.Evaluacion.Materia.Nombre + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Evaluación: " + EA.Evaluacion.Codigo.ToString() + " - " + EA.Evaluacion.Titulo + " - " + EA.Fecha.ToShortDateString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Calificación: " + EA.Calificacion.ToString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Temas: ";

                        foreach (Tema T in EA.Evaluacion.VerTemas())
                        {
                            txtBoxRendimiento.Text += T.Nombre + "-";
                        }

                        txtBoxRendimiento.Text = txtBoxRendimiento.Text.TrimEnd('-');
                        txtBoxRendimiento.Text += "\n\r\n\r";

                        txtBoxRendimiento.Text += "\n\r" + "Docente: " + EA.Docente.Legajo + " - " + EA.Docente.Apellido + ", " + EA.Docente.Nombre + "\n\r\n\r";

                        txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";

                        Generar_Grafico(EA, counter);
                        counter++;
                    }

                    txtBoxRendimiento.Text += "Detalles:\n\r\n\r";
                    txtBoxRendimiento.Text += "\n\rTotal Evaluaciones: " + EvaAlu.Count.ToString() + "\n\r\n\r";
                    txtBoxRendimiento.Text += "\n\rEvaluaciones Aprobadas: " + BLL_Cursada_de_Alumno.Obtener_Cant_Aprobados(EvaAlu) + "\n\r\n\r";
                    txtBoxRendimiento.Text += "\n\rEvaluaciones Reprobadas: " + BLL_Cursada_de_Alumno.Obtener_Cant_Reprobados(EvaAlu) + "\n\r\n\r";
                    txtBoxRendimiento.Text += "\n\rMaterias aprobadas: ";

                    List<string> LM = BLL_Cursada_de_Alumno.Obtener_Materias_Mejor_Rendimiento(EvaAlu);

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
                    CMatAprobadas = LM.Count;

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\n\rMaterias reprobadas: ";

                    LM = null;

                    LM = BLL_Cursada_de_Alumno.Obtener_Materias_Peor_Rendimiento(EvaAlu);

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
                    CMatReprobadas = LM.Count;

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\n\rCantidad de Materias Total: " + BLL_Cursada_de_Alumno.Obtener_Cant_Materias(EvaAlu).ToString();

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\n\rCantidad de Materias Aprobadas: " + CantAprobadas.ToString();

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\n\rCantidad de Materias Reprobadas: " + CantReprobadas.ToString();

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\nTotal de Faltas: " + Faltas.ToString() + "\n\r";

                    string State = "";

                    if (Cursada_de_Alumno.Libre == false)
                    {
                        State = "Regular";
                    }
                    else
                    {
                        State = "Libre";
                    }

                    txtBoxRendimiento.Text += "\n\rEstado de Cursada: " + State.ToString();

                    txtBoxConclusion.Font = new Font(txtBoxConclusion.Font, FontStyle.Bold);

                    txtBoxConclusion.Text = BLL_Cursada_de_Alumno.Obtener_Conclusion(EvaAlu, SessionManager.getInstance(ID).Idioma);

                    txtBoxRendimiento.Select(0, 0);
                    txtBoxConclusion.Select(0, 0);
                }
                else if (pIdioma == 2)
                {
                    int counter = 0;

                    foreach (Evaluacion_de_Alumno EA in EvaAlu)
                    {
                        txtBoxRendimiento.Text += "\n\r" + "Matter: " + EA.Evaluacion.Codigo + " - " + EA.Evaluacion.Materia.Nombre + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Evaluation: " + EA.Evaluacion.Codigo.ToString() + " - " + EA.Evaluacion.Titulo + " - " + EA.Fecha.ToShortDateString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Calification: " + EA.Calificacion.ToString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Topics: ";

                        foreach (Tema T in EA.Evaluacion.VerTemas())
                        {
                            txtBoxRendimiento.Text += T.Nombre + "-";
                        }

                        txtBoxRendimiento.Text = txtBoxRendimiento.Text.TrimEnd('-');
                        txtBoxRendimiento.Text += "\n\r\n\r";

                        txtBoxRendimiento.Text += "\n\r" + "Teacher: " + EA.Docente.Legajo + " - " + EA.Docente.Apellido + ", " + EA.Docente.Nombre + "\n\r\n\r";

                        txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";

                        Generar_Grafico(EA, counter);
                        counter++;
                    }

                    txtBoxRendimiento.Text += "Detalles:\n\r\n\r";
                    txtBoxRendimiento.Text += "\n\rTotal Evaluations: " + EvaAlu.Count.ToString() + "\n\r\n\r";
                    txtBoxRendimiento.Text += "\n\rTotal Approved Evaluations:  " + BLL_Cursada_de_Alumno.Obtener_Cant_Aprobados(EvaAlu) + "\n\r\n\r";
                    txtBoxRendimiento.Text += "\n\rTotal Failed Evaluations: " + BLL_Cursada_de_Alumno.Obtener_Cant_Reprobados(EvaAlu) + "\n\r\n\r";
                    txtBoxRendimiento.Text += "\n\rApproved Matters: ";

                    List<string> LM = BLL_Cursada_de_Alumno.Obtener_Materias_Mejor_Rendimiento(EvaAlu);

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
                    CMatAprobadas = LM.Count;

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\n\rFailed Matters:  ";

                    LM = null;

                    LM = BLL_Cursada_de_Alumno.Obtener_Materias_Peor_Rendimiento(EvaAlu);

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
                    CMatReprobadas = LM.Count;

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\n\rTotal Amount of Matters: " + BLL_Cursada_de_Alumno.Obtener_Cant_Materias(EvaAlu).ToString();

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\n\rTotal Amount of Matters Approved: " + CantAprobadas.ToString();

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\n\rTotal Amount of Matters Failed: " + CantReprobadas.ToString();

                    txtBoxRendimiento.Text += "\n\r\n\r";

                    txtBoxRendimiento.Text += "\n\rTotal absences: " + Faltas.ToString() + "\n\r";

                    string State = "";

                    if (Cursada_de_Alumno.Libre == false)
                    {
                        State = "Regular";
                    }
                    else
                    {
                        State = "Free";
                    }

                    txtBoxRendimiento.Text += "\nCourse State: " + State.ToString();

                    txtBoxConclusion.Font = new Font(txtBoxConclusion.Font, FontStyle.Bold);

                    txtBoxConclusion.Text = BLL_Cursada_de_Alumno.Obtener_Conclusion(EvaAlu, SessionManager.getInstance(ID).Idioma);          

                    txtBoxRendimiento.Select(0, 0);
                    txtBoxConclusion.Select(0, 0);
                }

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Imprimir_Reporte(e, SessionManager.getInstance(ID).Idioma);
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked==true)
            {
                foreach (var series in chartRendimiento.Series)
                {
                    series.Points.Clear();
                }

                txtBoxRendimiento.Text = "";
                txtBoxConclusion.Text = "";
                
                MostrarRendimiento(SessionManager.getInstance(ID).Idioma);

                btnGenerarInforme.Enabled = true;
                lblMateria.Visible = false;
                lblFecha1.Visible = false;
                lblFecha2.Visible = false;

                txtBoxMateria.Visible = false;
                txtBoxFecha1.Visible = false;
                txtBoxFecha2.Visible = false;
            }
        }

        private void rbMateria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMateria.Checked==true)
            {
                foreach (var series in chartRendimiento.Series)
                {
                    series.Points.Clear();
                }

                txtBoxMateria.Text = "";
                txtBoxRendimiento.Text = "";
                txtBoxConclusion.Text = "";

                btnGenerarInforme.Enabled = false;
                lblMateria.Visible = true;
                txtBoxMateria.Visible = true;
                lblFecha1.Visible = false;
                lblFecha2.Visible = false;
                txtBoxFecha1.Visible = false;
                txtBoxFecha2.Visible = false;
            }
        }
        private void txtBoxMateria_TextChanged(object sender, EventArgs e)
        {
            List<Evaluacion_de_Alumno> LEA = BLL_Cursada_de_Alumno.Ver_Califiaciones_de_Materia(EvaAlu, txtBoxMateria.Text);
            txtBoxRendimiento.Text = "";

            if (LEA.Count > 0)
            {
                MostrarRendimientoMateria(SessionManager.getInstance(ID).Idioma, LEA);
            }

            else
            {
                foreach (var series in chartRendimiento.Series)
                {
                    series.Points.Clear();
                }
            }
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFecha.Checked == true)
            {
                foreach (var series in chartRendimiento.Series)
                {
                    series.Points.Clear();
                }

                txtBoxFecha1.Text = "";
                txtBoxFecha2.Text = "";
                txtBoxRendimiento.Text = "";
                txtBoxConclusion.Text = "";

                btnGenerarInforme.Enabled = false;
                lblFecha1.Visible = true;
                lblFecha2.Visible = true;
                txtBoxFecha1.Visible = true;
                txtBoxFecha2.Visible = true;
            }
        }        

        private void Imprimir_Reporte(PrintPageEventArgs e, int pIdioma)
        {
            if (pIdioma==1)
            {
                int Fila = 10, Columna = 0;
                Font F = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);

                e.Graphics.DrawString("Legajo: ", F, Brushes.Black, Columna, Fila);
                e.Graphics.DrawString(Alumno.Legajo, F, Brushes.DarkBlue, Columna + 55, Fila);
                e.Graphics.DrawString("DNI: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Alumno.DNI.ToString(), F, Brushes.DarkBlue, Columna + 35, Fila);
                e.Graphics.DrawString("Apellido: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Alumno.Apellido, F, Brushes.DarkBlue, Columna + 60, Fila);
                e.Graphics.DrawString("Nombre: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Alumno.Nombre, F, Brushes.DarkBlue, Columna + 60, Fila);
                e.Graphics.DrawString("Curso: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Cursada_de_Alumno.Curso.Nombre + " - " + Cursada_de_Alumno.Curso.Año.ToString() + " - " + Cursada_de_Alumno.Curso.Turno, F, Brushes.DarkBlue, Columna + 50, Fila);

                Columna = 727;

                e.Graphics.DrawString(DateTime.Now.ToShortDateString(), F, Brushes.Black, Columna, Fila - 120);

                Fila += 35;
                e.Graphics.DrawString(DateTime.Now.ToShortTimeString(), F, Brushes.Black, Columna, Fila - 120);

                Fila += 2;
                Columna = 300;

                e.Graphics.DrawLine(Pens.Black, new Point(100, Fila += 25), new Point(727, Fila));

                F = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
                Columna = 100;
                Fila += 5;

                e.Graphics.DrawString("Materia", F, Brushes.DarkBlue, Columna += 20, Fila);
                e.Graphics.DrawString("Fecha de Evaluación", F, Brushes.DarkBlue, Columna += 153, Fila);
                e.Graphics.DrawString("Calificación", F, Brushes.DarkBlue, Columna += 195, Fila);
                e.Graphics.DrawString("Docente", F, Brushes.DarkBlue, Columna += 168, Fila);

                F = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);

                Fila += 5;

                foreach (Evaluacion_de_Alumno EVA in EvaAlu)
                {
                    Columna = 100;
                    Fila += 30;

                    e.Graphics.DrawString($"{EVA.Evaluacion.Materia.Nombre} ", F, Brushes.Black, Columna, Fila);
                    e.Graphics.DrawString($"{EVA.Fecha.ToShortDateString()} ", F, Brushes.Black, Columna += 201, Fila);
                    e.Graphics.DrawString($"{EVA.Calificacion.ToString()} ", F, Brushes.Black, Columna += 200, Fila);
                    e.Graphics.DrawString($"{EVA.Docente.Apellido}, {EVA.Docente.Nombre} ", F, Brushes.Black, Columna += 110, Fila);
                }

                F = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);

                Fila += 100;
                Columna = 100;

                e.Graphics.DrawString("Cantidad de Materias Total: ", F, Brushes.Black, Columna, Fila);
                e.Graphics.DrawString(BLL_Cursada_de_Alumno.Obtener_Cant_Materias(EvaAlu).ToString(), F, Brushes.DarkBlue, Columna + 192, Fila);

                e.Graphics.DrawString("Cantidad de Materias Aprobadas: ", F, Brushes.Black, Columna, Fila += 45);
                e.Graphics.DrawString(CMatAprobadas.ToString(), F, Brushes.DarkBlue, Columna + 233, Fila);

                e.Graphics.DrawString("Cantidad de Materias Reprobadas: ", F, Brushes.Black, Columna, Fila += 45);
                e.Graphics.DrawString(CMatReprobadas.ToString(), F, Brushes.DarkBlue, Columna + 237, Fila);

                e.Graphics.DrawString("Materias Aprobadas: ", F, Brushes.Black, Columna, Fila += 45);

                List<string> LM = BLL_Cursada_de_Alumno.Obtener_Materias_Mejor_Rendimiento(EvaAlu);

                string MateriasAprobadas = "";

                if (LM.Count > 0)
                {
                    foreach (string S in LM)
                    {
                        MateriasAprobadas += S + "-";
                    }

                    MateriasAprobadas = MateriasAprobadas.TrimEnd('-');
                }
                else
                {
                    MateriasAprobadas += "-";
                }

                e.Graphics.DrawString(MateriasAprobadas.ToString(), F, Brushes.DarkBlue, Columna + 145, Fila);

                e.Graphics.DrawString("Materias Reprobadas: ", F, Brushes.Black, Columna, Fila += 45);

                LM = BLL_Cursada_de_Alumno.Obtener_Materias_Peor_Rendimiento(EvaAlu);

                MateriasAprobadas = "";

                if (LM.Count > 0)
                {
                    foreach (string S in LM)
                    {
                        MateriasAprobadas += S + "-";
                    }

                    MateriasAprobadas = MateriasAprobadas.TrimEnd('-');
                }
                else
                {
                    MateriasAprobadas += "-";
                }

                e.Graphics.DrawString(MateriasAprobadas.ToString(), F, Brushes.DarkBlue, Columna + 148, Fila);

                F = new Font("Arial", 10, FontStyle.Underline | FontStyle.Bold, GraphicsUnit.Point);

                e.Graphics.DrawString("Conclusión: ", F, Brushes.DarkBlue, Columna, Fila += 45);

                F = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);

                e.Graphics.DrawString(BLL_Cursada_de_Alumno.Obtener_Conclusion(EvaAlu, SessionManager.getInstance(ID).Idioma), F, Brushes.DarkBlue, Columna, Fila += 35);
            }
            else if (pIdioma==2)
            {
                int Fila = 10, Columna = 0;
                Font F = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);

                e.Graphics.DrawString("ID: ", F, Brushes.Black, Columna, Fila);
                e.Graphics.DrawString(Alumno.Legajo, F, Brushes.DarkBlue, Columna + 24, Fila);
                e.Graphics.DrawString("Document: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Alumno.DNI.ToString(), F, Brushes.DarkBlue, Columna + 77, Fila);
                e.Graphics.DrawString("Surname: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Alumno.Apellido, F, Brushes.DarkBlue, Columna + 65, Fila);
                e.Graphics.DrawString("Name: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Alumno.Nombre, F, Brushes.DarkBlue, Columna + 50, Fila);
                e.Graphics.DrawString("Course: ", F, Brushes.Black, Columna, Fila += 30);
                e.Graphics.DrawString(Cursada_de_Alumno.Curso.Nombre + " - " + Cursada_de_Alumno.Curso.Año.ToString() + " - " + Cursada_de_Alumno.Curso.Turno, F, Brushes.DarkBlue, Columna + 54, Fila);

                Columna = 727;

                e.Graphics.DrawString(DateTime.Now.ToShortDateString(), F, Brushes.Black, Columna, Fila - 120);

                Fila += 35;
                e.Graphics.DrawString(DateTime.Now.ToShortTimeString(), F, Brushes.Black, Columna, Fila - 120);

                Fila += 2;
                Columna = 300;

                e.Graphics.DrawLine(Pens.Black, new Point(100, Fila += 25), new Point(727, Fila));

                F = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
                Columna = 100;
                Fila += 5;

                e.Graphics.DrawString("Matter", F, Brushes.DarkBlue, Columna += 20, Fila);
                e.Graphics.DrawString("Evaluation Date", F, Brushes.DarkBlue, Columna += 158, Fila);
                e.Graphics.DrawString("Calification", F, Brushes.DarkBlue, Columna += 195, Fila);
                e.Graphics.DrawString("Teacher", F, Brushes.DarkBlue, Columna += 168, Fila);

                F = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);

                Fila += 5;

                foreach (Evaluacion_de_Alumno EVA in EvaAlu)
                {
                    Columna = 100;
                    Fila += 30;

                    e.Graphics.DrawString($"{EVA.Evaluacion.Materia.Nombre} ", F, Brushes.Black, Columna, Fila);
                    e.Graphics.DrawString($"{EVA.Fecha.ToShortDateString()} ", F, Brushes.Black, Columna += 201, Fila);
                    e.Graphics.DrawString($"{EVA.Calificacion.ToString()} ", F, Brushes.Black, Columna += 200, Fila);
                    e.Graphics.DrawString($"{EVA.Docente.Apellido}, {EVA.Docente.Nombre} ", F, Brushes.Black, Columna += 110, Fila);
                }

                F = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);

                Fila += 100;
                Columna = 100;

                e.Graphics.DrawString("Total Matters: ", F, Brushes.Black, Columna, Fila);
                e.Graphics.DrawString(BLL_Cursada_de_Alumno.Obtener_Cant_Materias(EvaAlu).ToString(), F, Brushes.DarkBlue, Columna + 100, Fila);

                e.Graphics.DrawString("Total Matters Approved: ", F, Brushes.Black, Columna, Fila += 45);
                e.Graphics.DrawString(CMatAprobadas.ToString(), F, Brushes.DarkBlue, Columna + 165, Fila);

                e.Graphics.DrawString("Total Matters Failed: ", F, Brushes.Black, Columna, Fila += 45);
                e.Graphics.DrawString(CMatReprobadas.ToString(), F, Brushes.DarkBlue, Columna + 140, Fila);

                e.Graphics.DrawString("Matters Approved: ", F, Brushes.Black, Columna, Fila += 45);

                List<string> LM = BLL_Cursada_de_Alumno.Obtener_Materias_Mejor_Rendimiento(EvaAlu);

                string MateriasAprobadas = "";

                if (LM.Count > 0)
                {
                    foreach (string S in LM)
                    {
                        MateriasAprobadas += S + "-";
                    }

                    MateriasAprobadas = MateriasAprobadas.TrimEnd('-');
                }
                else
                {
                    MateriasAprobadas += "-";
                }

                e.Graphics.DrawString(MateriasAprobadas.ToString(), F, Brushes.DarkBlue, Columna + 130, Fila);

                e.Graphics.DrawString("Matters Failed: ", F, Brushes.Black, Columna, Fila += 45);

                LM = BLL_Cursada_de_Alumno.Obtener_Materias_Peor_Rendimiento(EvaAlu);

                MateriasAprobadas = "";

                if (LM.Count > 0)
                {
                    foreach (string S in LM)
                    {
                        MateriasAprobadas += S + "-";
                    }

                    MateriasAprobadas = MateriasAprobadas.TrimEnd('-');
                }
                else
                {
                    MateriasAprobadas += "-";
                }

                e.Graphics.DrawString(MateriasAprobadas.ToString(), F, Brushes.DarkBlue, Columna + 107, Fila);

                F = new Font("Arial", 10, FontStyle.Underline | FontStyle.Bold, GraphicsUnit.Point);

                e.Graphics.DrawString("Conclution: ", F, Brushes.DarkBlue, Columna, Fila += 45);

                F = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);

                e.Graphics.DrawString(BLL_Cursada_de_Alumno.Obtener_Conclusion(EvaAlu, SessionManager.getInstance(ID).Idioma), F, Brushes.DarkBlue, Columna, Fila += 35);
            }
        }     

        private void txtBoxFecha1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime Fecha1 = DateTime.Parse(txtBoxFecha1.Text);

                if (txtBoxFecha2.Text != "  /  /")
                {
                    DateTime Fecha2 = DateTime.Parse(txtBoxFecha2.Text);

                    List<Evaluacion_de_Alumno> LEA = BLL_Cursada_de_Alumno.Ver_Califiaciones_por_Fecha(EvaAlu, Fecha1, Fecha2);
                    txtBoxRendimiento.Text = "";

                    if (LEA.Count > 0)
                    {
                        MostrarRendimientoMateria(SessionManager.getInstance(ID).Idioma, LEA);
                    }
                    else
                    {
                        foreach (var series in chartRendimiento.Series)
                        {
                            series.Points.Clear();
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void txtBoxFecha2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime Fecha2 = DateTime.Parse(txtBoxFecha2.Text);

                if (txtBoxFecha1.Text != "  /  /")
                {
                    DateTime Fecha1 = DateTime.Parse(txtBoxFecha1.Text);

                    List<Evaluacion_de_Alumno> LEA = BLL_Cursada_de_Alumno.Ver_Califiaciones_por_Fecha(EvaAlu, Fecha1, Fecha2);
                    txtBoxRendimiento.Text = "";

                    if (LEA.Count > 0)
                    {
                        MostrarRendimientoMateria(SessionManager.getInstance(ID).Idioma, LEA);
                    }
                    else
                    {
                        foreach (var series in chartRendimiento.Series)
                        {
                            series.Points.Clear();
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();                
            }
        }

        public void Generar_Grafico(Evaluacion_de_Alumno pEA, int pos)
        {
            chartRendimiento.Series[SerieAprobada].XValueMember = "Fecha";
            chartRendimiento.Series[SerieAprobada].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            chartRendimiento.Series[SerieAprobada].YValueMembers = "Calificación";
            chartRendimiento.Series[SerieAprobada].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            chartRendimiento.Series[SerieAprobada].Points.AddXY(pEA.Fecha.ToShortDateString() + "\n" + pEA.Evaluacion.Materia.Nombre, pEA.Calificacion);

            if (pEA.Calificacion >= 6) { chartRendimiento.Series[SerieAprobada].Points[pos].Color = Color.FromArgb(27, 49, 192); }
            else
            {
                chartRendimiento.Series[SerieAprobada].Points[pos].Color = Color.FromArgb(229, 20, 20);
            }
        }
        public void MostrarRendimientoMateria(int pIdioma, List<Evaluacion_de_Alumno> pLEAMateria)
        {
            try
            {
                if (pIdioma == 1)
                {
                    int counter = 0;

                    foreach (Evaluacion_de_Alumno EA in pLEAMateria)
                    {
                        txtBoxRendimiento.Text += "\n\r" + "Materia: " + EA.Evaluacion.Codigo + " - " + EA.Evaluacion.Materia.Nombre + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Evaluación: " + EA.Evaluacion.Codigo.ToString() + " - " + EA.Evaluacion.Titulo + " - " + EA.Fecha.ToShortDateString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Calificación: " + EA.Calificacion.ToString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Temas: ";

                        foreach (Tema T in EA.Evaluacion.VerTemas())
                        {
                            txtBoxRendimiento.Text += T.Nombre + "-";
                        }

                        txtBoxRendimiento.Text = txtBoxRendimiento.Text.TrimEnd('-');
                        txtBoxRendimiento.Text += "\n\r\n\r";

                        txtBoxRendimiento.Text += "\n\r" + "Docente: " + EA.Docente.Legajo + " - " + EA.Docente.Apellido + ", " + EA.Docente.Nombre + "\n\r\n\r";

                        txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";

                        Generar_Grafico(EA, counter);
                        counter++;
                    }
                    
                }
                else if (pIdioma == 2)
                {
                    int counter = 0;

                    foreach (Evaluacion_de_Alumno EA in pLEAMateria)
                    {
                        txtBoxRendimiento.Text += "\n\r" + "Matter: " + EA.Evaluacion.Codigo + " - " + EA.Evaluacion.Materia.Nombre + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Evaluation: " + EA.Evaluacion.Codigo.ToString() + " - " + EA.Evaluacion.Titulo + " - " + EA.Fecha.ToShortDateString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Calification: " + EA.Calificacion.ToString() + "\n\r\n\r";
                        txtBoxRendimiento.Text += "\n\r" + "Topics: ";

                        foreach (Tema T in EA.Evaluacion.VerTemas())
                        {
                            txtBoxRendimiento.Text += T.Nombre + "-";
                        }

                        txtBoxRendimiento.Text = txtBoxRendimiento.Text.TrimEnd('-');
                        txtBoxRendimiento.Text += "\n\r\n\r";

                        txtBoxRendimiento.Text += "\n\r" + "Teacher: " + EA.Docente.Legajo + " - " + EA.Docente.Apellido + ", " + EA.Docente.Nombre + "\n\r\n\r";

                        txtBoxRendimiento.Text += "————————————————————————————————————————————————————————————\n\r\n\r";

                        Generar_Grafico(EA, counter);
                        counter++;
                    }                    
                }

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

    }
}
