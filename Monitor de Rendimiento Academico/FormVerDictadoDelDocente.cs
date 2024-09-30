using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FormVerDictadoDelDocente : Form
    {
        public FormVerDictadoDelDocente(int pKey, Materia pMateria, Dictado pDictado)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Materia = pMateria;
            Dictado = pDictado;
        }

        public int ID;
        public Materia Materia;
        public Dictado Dictado;
        public Curso Curso;
        public BLL_Curso BLL_Curso;
        public BLL_Materia BLL_Materia;
        public BLL_Alumno BLL_Alumno;
        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        public List<Alumno> LA;
        public List<Evaluacion> LE;
        public List<Tema> Temas;
        FormVerCalificacionesDeCursadaVerDictado FormVerCalificacionesDeCursadaVerDictado;
        FormVerClasesDeDictado FormVerClasesDeDictado;

        private void FormVerDictadoDelDocente_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Curso = new BLL_Curso();
            BLL_Materia = new BLL_Materia();
            BLL_Alumno = new BLL_Alumno();
            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            LA = BLL_Alumno.Ver_Alumnos_de_Materia(Materia);
            MostrarDatosEnGrilla(dgvAlumnos, LA);

            LE = BLL_Materia.Ver_Evaluaciones_de_Materia(Materia);
            MostrarDatosEnGrilla(dgvEvaluaciones, LE);

            Temas = BLL_Materia.Ver_Temas_De_Materia(Materia);
            Curso = BLL_Curso.Obtener_Curso_de_Materia(Materia);

            if (LE.Count > 0)
            {
                dgvEvaluaciones_Click(null, null);
            }

            Ver_Temas_Materia();

            this.Text = Materia.Nombre;
        }
        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Alumno> LA)
        {
            try
            {
                if (LA.Count != 0)
                {
                    foreach (Alumno A in LA)
                    {
                        pDGV.Rows.Add(A.Legajo, A.DNI, A.Apellido, A.Nombre);
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
        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Evaluacion> LE)
        {
            try
            {
                if (LE.Count != 0)
                {
                    foreach (Evaluacion E in LE)
                    {
                        pDGV.Rows.Add(E.Codigo, E.Titulo, E.Fecha.ToShortDateString());
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Evaluacion ObtenerEvaluacion(int pCodigo)
        {
            Evaluacion E = LE.Find(X => X.Codigo == pCodigo);
            return E;
        }

        private void dgvAlumnos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnos.Rows.Count > 0)
                {

                    Alumno A = ObtenerAlumno((string)dgvAlumnos.SelectedRows[0].Cells[0].Value);
                }
            }
            catch (Exception) { }
        }

        private void dgvEvaluaciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEvaluaciones.Rows.Count > 0)
                {
                    lbTemas.Items.Clear();

                    Evaluacion E = ObtenerEvaluacion((int)dgvEvaluaciones.SelectedRows[0].Cells[0].Value);

                    foreach (Tema T in E.VerTemas())
                    {
                        lbTemas.Items.Add("◉ " + T.Nombre);
                    }
                }
            }
            catch (Exception) { }
        }

        public void Ver_Temas_Materia()
        {
            foreach (Tema T in Temas)
            {
                lbTemasMateria.Items.Add("◉ " + T.Nombre);
            }
        }

        private void btnVerCalificaciones_Click(object sender, EventArgs e)
        {
            if (FormVerCalificacionesDeCursadaVerDictado is null)
            {
                if (LA.Count > 0)
                {
                    Alumno A = ObtenerAlumno((string)dgvAlumnos.SelectedRows[0].Cells[0].Value);
                    Cursada_de_Alumno CA = BLL_Cursada_de_Alumno.Buscar_Cursada_de_Alumno(A, Curso);

                    FormVerCalificacionesDeCursadaVerDictado = new FormVerCalificacionesDeCursadaVerDictado(ID, CA, Materia);
                    FormVerCalificacionesDeCursadaVerDictado.FormClosed += FormVerCalificacionesDeCursadaVerDictado_FormClosed;
                    FormVerCalificacionesDeCursadaVerDictado.ShowDialog();
                }
            }
        }

        private void FormVerCalificacionesDeCursadaVerDictado_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerCalificacionesDeCursadaVerDictado = null;
        }

        private void btnVerClases_Click(object sender, EventArgs e)
        {
            if (FormVerClasesDeDictado is null)
            {
                FormVerClasesDeDictado FormVerClasesDeDictado = new FormVerClasesDeDictado(ID, Dictado);
                FormVerClasesDeDictado.FormClosed += FormVerClasesDeDictado_FormClosed;
                FormVerClasesDeDictado.ShowDialog();
            }
        }

        private void FormVerClasesDeDictado_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerClasesDeDictado = null;
        }
    }
}
