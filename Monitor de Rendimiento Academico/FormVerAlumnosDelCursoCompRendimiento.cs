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
    public partial class FormVerAlumnosDelCursoCompRendimiento : Form
    {
        public FormVerAlumnosDelCursoCompRendimiento(int pKey, Curso pCurso)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Curso = pCurso;
        }

        public int ID;
        public Curso Curso;
        public BLL_Curso BLL_Curso = new BLL_Curso();
        public BLL_Alumno BLL_Alumno = new BLL_Alumno();
        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();
        public List<Alumno> LA;
        FormVerCursadasCompararRendimiento FormVerCursadasCompararRendimiento;

        private void FormVerAlumnosDelCursoCompararRendimiento_Load(object sender, EventArgs e)
        {
            this.Name = "FormVerAlumnosDelCursoCompRendimiento";

            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Curso = new BLL_Curso();
            BLL_Alumno = new BLL_Alumno();
            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            LA = BLL_Curso.Ver_Alumnos_del_Curso(Curso);
            MostrarDatosEnGrilla(dgvAlumnos, LA);

            BLL_Cursada_de_Alumno.Ver_Cursadas_de_Curso(LA);

            if (dgvAlumnos.Rows.Count > 0)
            {
                dgvAlumnos_Click(null, null);
            }
            else { MessageBox.Show("No hay Alumnos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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
        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Cursada_de_Alumno> LC)
        {
            try
            {
                if (LC.Count != 0)
                {
                    foreach (Cursada_de_Alumno C in LC)
                    {
                        pDGV.Rows.Add(C.Codigo, C.Curso.Codigo, C.Curso.Nombre, C.Curso.Año, C.Curso.Turno, C.Curso.RetornarActivo());
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public Cursada_de_Alumno ObtenerCursada(int pCodigo, Alumno pAlumno)
        {
            Cursada_de_Alumno CA = pAlumno.VerCursadas().Find(X => X.Codigo == pCodigo);
            return CA;
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

        private void btnSeleccionarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormVerCursadasCompararRendimiento == null)
                {
                    if (dgvAlumnos.Rows.Count > 0)
                    {
                        Alumno A = ObtenerAlumno((string)dgvAlumnos.SelectedRows[0].Cells[0].Value);

                        FormVerCursadasCompararRendimiento = new FormVerCursadasCompararRendimiento(ID, A);
                        FormVerCursadasCompararRendimiento.FormClosed += FormVerCursadasCompararRendimiento_FormClosed;
                        FormVerCursadasCompararRendimiento.ShowDialog();
                    }
                }                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerCursadasCompararRendimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerCursadasCompararRendimiento = null;
        }
    }


}
