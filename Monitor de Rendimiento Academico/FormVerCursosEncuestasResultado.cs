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
    public partial class FormVerCursosEncuestasResultado : Form
    {
        public FormVerCursosEncuestasResultado(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;
        BLL_Curso BLL_Curso;
        List<Curso> LC;
        FormVerEncuestasDeCurso FormVerEncuestasDeCurso;

        private void FormVerCursosEncuestasResultado_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Curso = new BLL_Curso();

            LC = BLL_Curso.Ver_Cursos_Con_Inscripciones_Cerradas();
            MostrarDatosEnGrilla(dgvCursosActivos, LC);
            lblBusqueda.Visible = false;
            txtBoxBusqueda.Visible = false;

            if (LC.Count == 0)
            {
                MessageBox.Show("No hay Cursos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                else { pDGV.Rows.Clear(); pDGV.DataSource = null;}
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }


        public Curso ObtenerCurso(int pCodigo)
        {
            Curso C = LC.Find(X => X.Codigo == pCodigo);
            return C;
        }

        private void btnVerEncuestasDeCurso_Click(object sender, EventArgs e)
        {
            if (FormVerEncuestasDeCurso == null)
            {
                if (dgvCursosActivos.Rows.Count > 0)
                {
                    Curso C = ObtenerCurso((int)dgvCursosActivos.SelectedRows[0].Cells[0].Value);
                    FormVerEncuestasDeCurso = new FormVerEncuestasDeCurso(ID, C);
                    FormVerEncuestasDeCurso.FormClosed += FormVerEncuestasDeCurso_FormClosed;
                    FormVerEncuestasDeCurso.ShowDialog();
                }
            }
        }

        private void FormVerEncuestasDeCurso_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerEncuestasDeCurso = null;
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked == true)
            {
                dgvCursosActivos.Rows.Clear();
                LC = BLL_Curso.Ver_Cursos_Con_Inscripciones_Cerradas();
                MostrarDatosEnGrilla(dgvCursosActivos, LC);
                lblBusqueda.Visible = false;
                txtBoxBusqueda.Visible = false;
            }
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCodigo.Checked == true)
            {
                if (lblBusqueda.Visible == false)
                {
                    lblBusqueda.Visible = true;
                }

                if (txtBoxBusqueda.Visible == false)
                {
                    txtBoxBusqueda.Visible = true;
                }
            }
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNombre.Checked == true)
            {
                if (lblBusqueda.Visible == false)
                {
                    lblBusqueda.Visible = true;
                }

                if (txtBoxBusqueda.Visible == false)
                {
                    txtBoxBusqueda.Visible = true;
                }
            }
        }

        private void rbAño_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAño.Checked == true)
            {
                if (lblBusqueda.Visible == false)
                {
                    lblBusqueda.Visible = true;
                }

                if (txtBoxBusqueda.Visible == false)
                {
                    txtBoxBusqueda.Visible = true;
                }
            }
        }

        private void rbTurno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTurno.Checked == true)
            {
                if (lblBusqueda.Visible == false)
                {
                    lblBusqueda.Visible = true;
                }

                if (txtBoxBusqueda.Visible == false)
                {
                    txtBoxBusqueda.Visible = true;
                }
            }
        }

        private void txtBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbCodigo.Checked == true)
                {
                    dgvCursosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvCursosActivos, BLL_Curso.Ver_Cursos_Codigo(LC, txtBoxBusqueda.Text));
                }
                else if (rbNombre.Checked == true)
                {
                    dgvCursosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvCursosActivos, BLL_Curso.Ver_Cursos_Nombre(LC, txtBoxBusqueda.Text));
                }
                else if (rbAño.Checked == true)
                {
                    dgvCursosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvCursosActivos, BLL_Curso.Ver_Cursos_Año(LC, txtBoxBusqueda.Text));
                }
                else if (rbTurno.Checked == true)
                {
                    dgvCursosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvCursosActivos, BLL_Curso.Ver_Cursos_Turno(LC, txtBoxBusqueda.Text));
                }

            }
            catch (Exception) { }
        }
    }
}
