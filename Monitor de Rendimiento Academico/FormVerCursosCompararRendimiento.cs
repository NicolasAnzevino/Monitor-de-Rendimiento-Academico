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
    public partial class FormVerCursosCompararRendimiento : Form
    {
        public FormVerCursosCompararRendimiento(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;
        BLL_Curso BLL_Curso;
        List<Curso> LC;
        FormVerAlumnosDelCursoCompRendimiento FormVerAlumnosDelCursoCompRendimiento;

        private void FormVerCursosCompararRendimiento_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Curso = new BLL_Curso();

            LC = BLL_Curso.Ver_Cursos_Activos();
            MostrarDatosEnGrilla(dgvCursosActivos, LC);
        }
        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Curso> LC)
        {
            try
            {
                if (LC.Count != 0)
                {
                    foreach (Curso C in LC)
                    {
                        pDGV.Rows.Add(C.Codigo, C.Nombre, C.Año, C.Turno);
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; MessageBox.Show("No hay Cursos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }


        public Curso ObtenerCurso(int pCodigo)
        {
            Curso C = LC.Find(X => X.Codigo == pCodigo);
            return C;
        }

        private void btnVerAlumnosDelCurso_Click(object sender, EventArgs e)
        {
            if (FormVerAlumnosDelCursoCompRendimiento == null)
            {
                if (dgvCursosActivos.Rows.Count > 0)
                {
                    Curso C = ObtenerCurso((int)dgvCursosActivos.SelectedRows[0].Cells[0].Value);
                    FormVerAlumnosDelCursoCompRendimiento = new FormVerAlumnosDelCursoCompRendimiento(ID, C);
                    FormVerAlumnosDelCursoCompRendimiento.FormClosed += FormVerAlumnosDelCursoCompRendimiento_FormClosed;
                    FormVerAlumnosDelCursoCompRendimiento.ShowDialog();
                }
            }
        }

        private void FormVerAlumnosDelCursoCompRendimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerAlumnosDelCursoCompRendimiento = null;
        }
    }
}
