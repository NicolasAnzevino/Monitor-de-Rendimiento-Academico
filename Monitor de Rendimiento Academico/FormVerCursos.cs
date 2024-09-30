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
    public partial class FormVerCursos : Form
    {
        public FormVerCursos(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;
        BLL_Curso BLL_Curso;
        BLL_Materia BLL_Materia;
        List<Curso> LC;
        FormModificarCurso FormModificarCurso;
        FormVerAlumnosDelCurso FormVerAlumnosDelCurso;
        FormVerDictadosDelCurso FormVerDictadosDelCurso;

        private void FormVerCursos_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Curso = new BLL_Curso();
            BLL_Materia = new BLL_Materia();

            LC = BLL_Curso.Ver_Cursos_Activos();
            MostrarDatosEnGrilla(dgvCursosActivos, LC);

            lblBusqueda.Visible = false;
            txtBoxBusqueda.Visible = false;

            if (dgvCursosActivos.Rows.Count>0)
            {
                dgvCursosActivos_Click(null, null);
            }
            else { MessageBox.Show("No hay Cursos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Curso> LC)
        {
            try
            {
                if (LC.Count != 0)
                {
                    foreach (Curso C in LC)
                    {
                        pDGV.Rows.Add(C.Codigo, C.Nombre, C.Año, C.Turno, C.InscripcionAbierta);
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

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbActivo.Checked == true)
                {
                    LC = BLL_Curso.Ver_Cursos_Activos();
                    dgvCursosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvCursosActivos, LC);

                    if (btnDarDeBajaCurso.Enabled == false)
                    {
                        btnDarDeBajaCurso.Enabled = true;
                    }
                    if (btnModificarCurso.Enabled == false)
                    {
                        btnModificarCurso.Enabled = true;
                    }

                    btnCerrarInscripcionCurso.Enabled = true;
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }           
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbInactivo.Checked == true)
                {
                    LC = BLL_Curso.Ver_Cursos_Inactivos();
                    dgvCursosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvCursosActivos, LC);
                    btnDarDeBajaCurso.Enabled = false;
                    btnModificarCurso.Enabled = false;
                    btnCerrarInscripcionCurso.Enabled = false;
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void btnDarDeBajaCurso_Click(object sender, EventArgs e)
        {
            if (dgvCursosActivos.Rows.Count>0)
            {
                Curso C = ObtenerCurso((int)dgvCursosActivos.SelectedRows[0].Cells[0].Value);
                if (MessageBox.Show("¿Está Seguro de dar de Baja al Curso " + C.Nombre + "?\n\nAl dar de baja el Curso, también se darán de baja las Materias que formen parte del mismo", "Solicitud de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    BLL_Curso.Dar_De_Baja_Curso(C);
                    List<Dictado> LD = BLL_Curso.Ver_Dictados_del_Curso(C);
                    BLL_Materia.Dar_De_Baja_Materias_de_Curso(LD);
                    MessageBox.Show("Se ha dado de baja el Curso " + C.Nombre, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogManager.Escribir(ID, "Dio de baja el Curso " + C.Nombre, 3);
                    dgvCursosActivos.Rows.Clear();
                    LC = BLL_Curso.Ver_Cursos_Activos();
                    MostrarDatosEnGrilla(dgvCursosActivos, LC);
                }                
            }
        }

        private void btnModificarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormModificarCurso == null)
                {
                    if (dgvCursosActivos.Rows.Count>0)
                    {
                        Curso C = ObtenerCurso((int)dgvCursosActivos.SelectedRows[0].Cells[0].Value);
                        FormModificarCurso = new FormModificarCurso(ID, C);
                        FormModificarCurso.FormClosed += FormModificarCurso_FormClosed;
                        FormModificarCurso.ShowDialog();
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void FormModificarCurso_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormModificarCurso = null;
            dgvCursosActivos.Rows.Clear();
            LC = BLL_Curso.Ver_Cursos_Activos();
            MostrarDatosEnGrilla(dgvCursosActivos, LC);
        }

        private void btnVerAlumnosDeCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormVerAlumnosDelCurso == null)
                {
                    if (dgvCursosActivos.Rows.Count > 0)
                    {
                        Curso C = ObtenerCurso((int)dgvCursosActivos.SelectedRows[0].Cells[0].Value);
                        FormVerAlumnosDelCurso = new FormVerAlumnosDelCurso(ID, C);
                        FormVerAlumnosDelCurso.FormClosed += FormVerAlumnosDelCurso_FormClosed;
                        FormVerAlumnosDelCurso.ShowDialog();
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
          
        }

        private void FormVerAlumnosDelCurso_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerAlumnosDelCurso = null;
        }

        private void btnVerMateriasDeCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormVerDictadosDelCurso == null)
                {
                    if (dgvCursosActivos.Rows.Count > 0)
                    {
                        Curso C = ObtenerCurso((int)dgvCursosActivos.SelectedRows[0].Cells[0].Value);
                        FormVerDictadosDelCurso = new FormVerDictadosDelCurso(ID, C);
                        FormVerDictadosDelCurso.FormClosed += FormVerDictadosDelCurso_FormClosed;
                        FormVerDictadosDelCurso.ShowDialog();
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void FormVerDictadosDelCurso_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerDictadosDelCurso = null;
        }

        private void dgvCursosActivos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCursosActivos.Rows.Count>0)
                {
                    Curso C = ObtenerCurso((int)dgvCursosActivos.SelectedRows[0].Cells[0].Value);
                    if (C.InscripcionAbierta == true && rbActivo.Checked == true)
                    {
                        btnCerrarInscripcionCurso.Enabled = true;
                    }
                    else
                    {
                        btnCerrarInscripcionCurso.Enabled = false;
                    }
                }
            }
            catch (Exception) {}
        }

        private void btnCerrarInscripcionCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (LC.Count>0)
                {
                    Curso C = ObtenerCurso((int)dgvCursosActivos.SelectedRows[0].Cells[0].Value);

                    if (MessageBox.Show("¿Está seguro de cerrar la Inscripción de Alumnos al Curso " + C.Nombre + " " + C.Año.ToString() + " " + C.Turno + "?", "Solicitud de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BLL_Curso.Cerrar_Inscripcion_Curso(C);
                        dgvCursosActivos.Rows.Clear();

                        if (rbActivo.Checked == true)
                        {
                            LC = BLL_Curso.Ver_Cursos_Activos();
                            MostrarDatosEnGrilla(dgvCursosActivos, LC);
                            dgvCursosActivos_Click(null, null);
                        }
                        else
                        {
                            LC = BLL_Curso.Ver_Cursos_Inactivos();
                            MostrarDatosEnGrilla(dgvCursosActivos, LC);
                            dgvCursosActivos_Click(null, null);
                        }
                    }
                }  
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked == true)
            {
                if (rbActivo.Checked == true)
                {
                    LC = BLL_Curso.Ver_Cursos_Activos();
                    dgvCursosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvCursosActivos, LC);
                }
                else if (rbInactivo.Checked == true)
                {
                    LC = BLL_Curso.Ver_Cursos_Inactivos();
                    dgvCursosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvCursosActivos, LC);
                }

                lblBusqueda.Visible = false;
                txtBoxBusqueda.Visible = false;

                if (LC.Count != 0)
                {
                    dgvCursosActivos_Click(null, null);
                }
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

        private void rbInscAb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInscAb.Checked == true)
            {
                lblBusqueda.Visible = false;
                txtBoxBusqueda.Visible = false;

                dgvCursosActivos.Rows.Clear();
                MostrarDatosEnGrilla(dgvCursosActivos, BLL_Curso.Ver_Cursos_Insc_Abierta(LC));
            }
        }

        private void rbInscCer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInscCer.Checked == true)
            {
                lblBusqueda.Visible = false;
                txtBoxBusqueda.Visible = false;

                dgvCursosActivos.Rows.Clear();
                MostrarDatosEnGrilla(dgvCursosActivos, BLL_Curso.Ver_Cursos_Insc_Cerrada(LC));
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
