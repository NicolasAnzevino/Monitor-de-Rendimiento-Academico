using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FormModificarCalificacion : Form
    {
        public FormModificarCalificacion(int pKey, Alumno pAlumno, Curso pCurso, Materia pMateria, Evaluacion pEvaluacion, Evaluacion_de_Alumno pEvaALu)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Alumno = pAlumno;
            Curso = pCurso;
            Materia = pMateria;
            Evaluacion = pEvaluacion;
            EvaAlu = pEvaALu;
        }

        public int ID;
        public Docente Docente;
        public Alumno Alumno;
        public Curso Curso;
        public Materia Materia;
        public Evaluacion Evaluacion;
        public Cursada_de_Alumno Cursada_de_Alumno;
        public Evaluacion_de_Alumno EvaAlu;

        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        public BLL_Docente BLL_Docente;

        private void FormModificarCalificacion_Load(object sender, EventArgs e)
        {
            txtBoxCalificacion.MaxLength = 2;

            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();
            BLL_Docente = new BLL_Docente();

            Docente = BLL_Docente.Obtener_Docente_Por_ID_Usuario(ID);
            Cursada_de_Alumno = BLL_Cursada_de_Alumno.Buscar_Cursada_de_Alumno(Alumno, Curso);

            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            txtBoxAlumno.Text = Alumno.Legajo + " - " + Alumno.DNI.ToString() + " - " + Alumno.Apellido + ", " + Alumno.Nombre;
            txtBoxMateria.Text = Curso.Nombre + " - " + Materia.Nombre;
            txtBoxEvaluacion.Text = Evaluacion.Fecha.ToShortDateString();
            

            txtBoxCalificacion.Text = EvaAlu.Calificacion.ToString();
            SelectorFechaIngreso.Value = EvaAlu.Fecha;
            txtBoxTituloEval.Text = Evaluacion.Codigo + " - " + Evaluacion.Titulo;            
        }

        private void btnAñadirCalificacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxCalificacion.Text != "")
                {
                    DateTime Fecha = SelectorFechaIngreso.Value;
                    int Calificacion = int.Parse(txtBoxCalificacion.Text);

                    if (MessageBox.Show("¿Desea modificar la Calificación?\n\nDatos de la Evaluación:\n◉ Alumno: " + Alumno.Legajo + " - " + Alumno.DNI + " - " + Alumno.Apellido + ", " + Alumno.Nombre + "\n◉ Curso: " + Curso.Codigo + " - " + Curso.Nombre + "\n◉ Materia: " + Materia.Codigo.ToString() + " - " + Materia.Nombre + "\n◉ Evaluación: " + Evaluacion.Codigo + " - " + Evaluacion.Titulo + " - " + Evaluacion.Fecha.ToShortDateString() + "\n\nDatos de la Calificación:" + "\n◉ Calificación: " + Calificacion.ToString() + "\n◉ Se evaluó al Alumno en la fecha: " + Fecha.ToShortDateString(), "Solicitud de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Modificar_Calificacion(Fecha, Calificacion);
                        MessageBox.Show("Se ha modificado la Calificación correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogManager.Escribir(ID, "Se modificó la Calificación " + EvaAlu.Codigo.ToString() + " del Alumno " + Alumno.Legajo, 3);
                        this.Close();
                    }
                }
                else { throw new Exception("Debe rellenar todos los Campos"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Modificar_Calificacion(DateTime pFecha, int pCalificacion)
        {
            try
            {
                EvaAlu.Calificacion = pCalificacion;
                EvaAlu.Fecha = pFecha;
                BLL_Cursada_de_Alumno.Modificar_Evaluacion_de_Alumno(EvaAlu);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
