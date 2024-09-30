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
    public partial class FormAgregarCalificacion : Form
    {
        public FormAgregarCalificacion(int pKey, Alumno pAlumno, Curso pCurso, Materia pMateria, Evaluacion pEvaluacion)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Alumno = pAlumno;
            Curso = pCurso;
            Materia = pMateria;
            Evaluacion = pEvaluacion;
        }

        public int ID;
        public Docente Docente;
        public Alumno Alumno;
        public Curso Curso;
        public Materia Materia;
        public Evaluacion Evaluacion;
        public Cursada_de_Alumno Cursada_de_Alumno;

        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        public BLL_Docente BLL_Docente;

        private void FormAgregarCalificacion_Load(object sender, EventArgs e)
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

            SelectorFechaIngreso.Value = Evaluacion.Fecha.Date;
            txtBoxTituloEval.Text = Evaluacion.Codigo + " - " + Evaluacion.Titulo;
        }        

        private void btnAñadirCalificacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxCalificacion.Text != "")
                {
                    DateTime Fecha = SelectorFechaIngreso.Value.Date;
                    int Calificacion = int.Parse(txtBoxCalificacion.Text);

                    if (MessageBox.Show("¿Desea agregar la Calificación?\n\nDatos de la Evaluación:\n◉ Alumno: " + Alumno.Legajo + " - " + Alumno.DNI + " - " + Alumno.Apellido + ", " + Alumno.Nombre + "\n◉ Curso: " + Curso.Codigo + " - " + Curso.Nombre + "\n◉ Materia: " + Materia.Codigo.ToString() + " - " + Materia.Nombre + "\n◉ Evaluación: " + Evaluacion.Codigo + " - " + Evaluacion.Titulo  + " - " + Evaluacion.Fecha.ToShortDateString() + "\n\nDatos de la Calificación:" + "\n◉ Calificación: " + Calificacion.ToString() + "\n◉ Se evaluó al Alumno en la fecha: " + Fecha.ToShortDateString(), "Solicitud de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                    {
                        if (BLL_Cursada_de_Alumno.Verificar_Repeticion_Evaluacion(Fecha, Evaluacion, Cursada_de_Alumno)== false)
                        {
                            Agregar_Evaluacion(Fecha, Calificacion);
                            MessageBox.Show("Se ha agregado la Calificación correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LogManager.Escribir(ID, "Agregó una Calificación al Alumno " + Alumno.Legajo, 3);
                            this.Close();
                        }
                        else { throw new Exception("Ya se agregó una Evaluación en la misma fecha a este Alumno"); }
                    }                  
                }
                else { throw new Exception("Debe rellenar todos los Campos"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Agregar_Evaluacion(DateTime pFecha, int pCalificacion)
        {
            try
            {
                BLL_Cursada_de_Alumno.Agregar_Evaluacion_de_Alumno(pFecha, pCalificacion, Docente, Cursada_de_Alumno, Evaluacion);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void txtBoxCalificacion_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCalificacion.Text != "")
            {
                int Valor = int.Parse(txtBoxCalificacion.Text);

                if (Valor > 10)
                {
                    txtBoxCalificacion.Text = "10";
                }

                if (Valor < 1)
                {
                    txtBoxCalificacion.Text = "1";
                }
            }                    
        }

        private void txtBoxCalificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
