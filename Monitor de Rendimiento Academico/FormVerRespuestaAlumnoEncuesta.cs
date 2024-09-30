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
    public partial class FormVerRespuestaAlumnoEncuesta : Form
    {
        public FormVerRespuestaAlumnoEncuesta(int pKey, Curso pCurso, Encuesta pEncuesta)
        {
            InitializeComponent();
            this.CenterToScreen();
            ID = pKey;
            Curso = pCurso;
            Encuesta = pEncuesta;
        }

        public int ID;
        public Curso Curso;
        public Encuesta Encuesta;
        public BLL_Curso BLL_Curso;
        public BLL_Pregunta_de_Encuesta BLL_Pregunta_de_Encuesta;
        public BLL_Encuesta_de_Alumno BLL_Encuesta_de_Alumno;
        public List<Alumno> LA;
        public Dictionary<string, bool> DiccionarioEstadoEncuesta;
        public Dictionary<string, List<Pregunta_de_Encuesta>> DiccionarioPreguntaRespuesta;

        private void VerRespuestaAlumnoEncuesta_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Curso = new BLL_Curso();
            BLL_Encuesta_de_Alumno = new BLL_Encuesta_de_Alumno();
            BLL_Pregunta_de_Encuesta = new BLL_Pregunta_de_Encuesta();

            LA = BLL_Curso.Ver_Alumnos_del_Curso(Curso);
            DiccionarioEstadoEncuesta = BLL_Encuesta_de_Alumno.Ver_Estado_Resolucion_Alumnos(Encuesta.Codigo);
            DiccionarioPreguntaRespuesta = BLL_Pregunta_de_Encuesta.Ver_Preguntas_de_Encuesta_con_Respuesta(Encuesta, LA);

            MostrarDatosEnGrilla(dgvAlumnos, LA, DiccionarioEstadoEncuesta);

            if (LA.Count>0)
            {
                dgvAlumnos_Click(null, null);
            }
        }
        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Alumno> LA, Dictionary<string, bool> pDiccionario)
        {
            try
            {
                if (LA.Count != 0)
                {
                    foreach (Alumno A in LA)
                    {
                        bool EncuestaCompletada = pDiccionario[A.Legajo];
                        pDGV.Rows.Add(A.Legajo, A.DNI, A.Apellido + ", " + A.Nombre, EncuestaCompletada);
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Alumno ObtenerAlumno(string pLegajo)
        {
            Alumno A = LA.Find(X => X.Legajo == pLegajo);
            return A;
        }
        public void Mostrar_Informacion_Respuesta(Alumno pAlumno, int pIdioma)
        {
            try
            {
                txtBoxEstadoEncuesta.Clear();

                List<Pregunta_de_Encuesta> LP = DiccionarioPreguntaRespuesta[pAlumno.Legajo];

                if (pIdioma == 1)
                {
                    foreach (Pregunta_de_Encuesta P in LP)
                    {
                        if (txtBoxEstadoEncuesta.Text == "")
                        {
                            txtBoxEstadoEncuesta.Text += "PREGUNTA: " + P.Pregunta + "\r\n\r\nVALORACIÓN: " + P.Respuestas[0].Respuesta.ToString() + "\r\n\r\nDESCRIPCIÓN:  " + P.Respuestas[0].Descripcion;
                        }
                        else
                        {
                            txtBoxEstadoEncuesta.Text += "\r\n\r\nPREGUNTA: " + P.Pregunta + "\r\n\r\nVALORACIÓN: " + P.Respuestas[0].Respuesta.ToString() + "\r\n\r\nDESCRIPCIÓN:  " + P.Respuestas[0].Descripcion;
                        }

                        txtBoxEstadoEncuesta.Text += "\n\r————————————————————————————————————————————————————————————";
                    }
                }
                else if (pIdioma == 2)
                {
                    foreach (Pregunta_de_Encuesta P in LP)
                    {
                        if (txtBoxEstadoEncuesta.Text == "")
                        {
                            txtBoxEstadoEncuesta.Text += "QUESTION: " + P.Pregunta + "\r\n\r\nVALORATION: " + P.Respuestas[0].Respuesta.ToString() + "\r\n\r\nDESCRIPTION:  " + P.Respuestas[0].Descripcion;
                        }
                        else
                        {
                            txtBoxEstadoEncuesta.Text += "\r\n\r\nQUESTION: " + P.Pregunta + "\r\n\r\nVALORATION: " + P.Respuestas[0].Respuesta.ToString() + "\r\n\r\nDESCRIPTION:  " + P.Respuestas[0].Descripcion;
                        }

                        txtBoxEstadoEncuesta.Text += "\n\r————————————————————————————————————————————————————————————";
                    }
                }                

                txtBoxEstadoEncuesta.Text.TrimStart();
                txtBoxEstadoEncuesta.Select(0, 0);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void dgvAlumnos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnos.Rows.Count>0)
                {
                    txtBoxEstadoEncuesta.Clear();

                    Alumno A = ObtenerAlumno((string)dgvAlumnos.SelectedRows[0].Cells[0].Value);

                    if ((bool)dgvAlumnos.SelectedRows[0].Cells[3].Value == false)
                    {
                        Mostrar_Informacion_Respuesta(A, SessionManager.getInstance(ID).Idioma);
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Escribir_TextBox(Pregunta_de_Encuesta pPregunta)
        {
           
            txtBoxEstadoEncuesta.Font = new Font(txtBoxEstadoEncuesta.Font, FontStyle.Bold);

            txtBoxEstadoEncuesta.Text += "\r\n\r\nPREGUNTA: ";

            txtBoxEstadoEncuesta.Font = new Font(txtBoxEstadoEncuesta.Font, FontStyle.Regular);

            txtBoxEstadoEncuesta.Text += pPregunta.Pregunta;

            txtBoxEstadoEncuesta.Font = new Font(txtBoxEstadoEncuesta.Font, FontStyle.Bold);

            txtBoxEstadoEncuesta.Text += "\r\n\r\nVALORACIÓN: ";

            txtBoxEstadoEncuesta.Font = new Font(txtBoxEstadoEncuesta.Font, FontStyle.Regular);

            txtBoxEstadoEncuesta.Text += pPregunta.Respuestas[0].Respuesta.ToString();

            txtBoxEstadoEncuesta.Font = new Font(txtBoxEstadoEncuesta.Font, FontStyle.Bold);

            txtBoxEstadoEncuesta.Text += "\r\n\r\nDESCRIPCIÓN: ";

            txtBoxEstadoEncuesta.Font = new Font(txtBoxEstadoEncuesta.Font, FontStyle.Regular);

            if (pPregunta.Respuestas[0].Descripcion== "")
            {
                txtBoxEstadoEncuesta.Text += "-";
            }
            else
            {
                txtBoxEstadoEncuesta.Text += pPregunta.Respuestas[0].Descripcion.ToString();
            }
            
            
        }
    }
}
