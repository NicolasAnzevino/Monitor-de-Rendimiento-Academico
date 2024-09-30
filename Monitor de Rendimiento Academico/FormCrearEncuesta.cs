using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;
using Servicios;
using BLL;

namespace Monitor_de_Rendimiento_Academico
{
    public partial class FormCrearEncuesta : Form
    {
        public FormCrearEncuesta(int pKey, Curso pCurso)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Curso = pCurso;
        }

        public int ID;
        public List<string> Preguntas;
        public List<Alumno> Alumnos;
        public Curso Curso;
        public BLL_Curso BLL_Curso;
        public BLL_Encuesta BLL_Encuesta;
        public BLL_Encuesta_de_Alumno BLL_Encuesta_de_Alumno;

        private void FormCrearEncuesta_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Curso = new BLL_Curso();
            BLL_Encuesta = new BLL_Encuesta();
            BLL_Encuesta_de_Alumno = new BLL_Encuesta_de_Alumno();

            Preguntas = new List<string>();
            Alumnos = BLL_Curso.Ver_Alumnos_del_Curso(Curso);

            if (Alumnos.Count == 0)
            {
                MessageBox.Show("El Curso no posee Alumnos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            txtBoxCurso.Text = Curso.Codigo.ToString() + " - " + Curso.Nombre + " - " + Curso.Turno;
        }

        private void btnEnviarPregunta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxPregunta.Text != "")
                {
                    Preguntas.Add(txtBoxPregunta.Text);

                    if (MessageBox.Show("¿Desea seguir agregando preguntas?", "Solicitud de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        Crear_Encuesta(Preguntas, Alumnos, Curso);
                        LogManager.Escribir(ID, "Creó una Encuesta y la envió al Curso " + Curso.Codigo.ToString() + " - " + Curso.Nombre, 3);
                        MessageBox.Show("La Encuesta fue creada y enviada correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        txtBoxPregunta.Text = "";
                    }
                }
                else throw new Exception("Debe rellenar todos los campos");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Crear_Encuesta(List<string> pPreguntas, List<Alumno> pAlumnos, Curso pCurso)
        {
            try
            {
                int IDEncuesta = BLL_Encuesta.Crear_Encuesta(pPreguntas, pCurso);
                BLL_Encuesta_de_Alumno.Enviar_Encuesta_a_Curso(pAlumnos, IDEncuesta);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
