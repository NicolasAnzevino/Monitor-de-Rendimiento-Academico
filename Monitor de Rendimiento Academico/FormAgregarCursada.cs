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
    public partial class FormAgregarCursada : Form
    {
        public FormAgregarCursada(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;
        List<Alumno> LA;
        List<Curso> LC;
        BLL_Alumno BLL_Alumno;
        BLL_Curso BLL_Curso;
        BLL_Cursada_de_Alumno BLL_Cursada_De_Alumno;

        private void FormAgregarCursada_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Alumno = new BLL_Alumno();
            BLL_Curso = new BLL_Curso();
            BLL_Cursada_De_Alumno = new BLL_Cursada_de_Alumno();

            LA = BLL_Alumno.Ver_Alumnos_Activos();
            LC = BLL_Curso.Ver_Cursos_Con_Inscripciones_Abiertas();

            MostrarDatosEnGrilla(dgvAlumnosActivos, LA);
            MostrarDatosEnGrilla(dgvCursosActivos, LC);

            lblBusquedaAlu.Visible = false;
            txtBoxBusquedaAlu.Visible = false;
            lblBusquedaCursos.Visible = false;
            txtBoxBusquedaCurso.Visible = false;

            if (dgvAlumnosActivos.Rows.Count > 0)
            {
                dgvAlumnosActivos_Click(null, null);
            }
            else { MessageBox.Show("No hay Alumnos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            if (dgvCursosActivos.Rows.Count > 0)
            {
                dgvCursosActivos_Click(null, null);
            }
            else { MessageBox.Show("No hay Cursos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Alumno> LA)
        {
            try
            {
                if (LA.Count != 0)
                {
                    foreach (Alumno A in LA)
                    {
                        pDGV.Rows.Add(A.Legajo, A.DNI, A.Apellido, A.Nombre, A.Turno);
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { }
        }

        public Alumno ObtenerAlumno(string pLegajo)
        {
            Alumno A = LA.Find(X => X.Legajo == pLegajo);
            return A;
        }

        private void dgvAlumnosActivos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnosActivos.Rows.Count > 0)
                {
                    Alumno A = ObtenerAlumno((string)dgvAlumnosActivos.SelectedRows[0].Cells[0].Value);                    
                }
            }
            catch (Exception ex) { }
        }

        private void rbAlumnosTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosTodos.Checked == true)
            {
                LA = BLL_Alumno.Ver_Alumnos_Activos();
                dgvAlumnosActivos.Rows.Clear();
                MostrarDatosEnGrilla(dgvAlumnosActivos, LA);

                lblBusquedaAlu.Visible = false;
                txtBoxBusquedaAlu.Visible = false;

                if (LA.Count != 0)
                {
                    dgvAlumnosActivos_Click(null, null);
                }                
            }
        }

        private void rbAlumnosLegajo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosLegajo.Checked == true)
            {
                if (lblBusquedaAlu.Visible == false)
                {
                    lblBusquedaAlu.Visible = true;
                }

                if (txtBoxBusquedaAlu.Visible == false)
                {
                    txtBoxBusquedaAlu.Visible = true;
                }
            }
        }

        private void rbAlumnosDNI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosDNI.Checked == true)
            {
                if (lblBusquedaAlu.Visible == false)
                {
                    lblBusquedaAlu.Visible = true;
                }

                if (txtBoxBusquedaAlu.Visible == false)
                {
                    txtBoxBusquedaAlu.Visible = true;
                }


            }
        }

        private void rbAlumnosApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosApellido.Checked == true)
            {
                if (lblBusquedaAlu.Visible == false)
                {
                    lblBusquedaAlu.Visible = true;
                }

                if (txtBoxBusquedaAlu.Visible == false)
                {
                    txtBoxBusquedaAlu.Visible = true;
                }


            }
        }

        private void rbAlumnosNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosNombre.Checked == true)
            {
                if (lblBusquedaAlu.Visible == false)
                {
                    lblBusquedaAlu.Visible = true;
                }

                if (txtBoxBusquedaAlu.Visible == false)
                {
                    txtBoxBusquedaAlu.Visible = true;
                }


            }
        }

        private void rbAlumnosTurno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosTurno.Checked == true)
            {
                if (lblBusquedaAlu.Visible == false)
                {
                    lblBusquedaAlu.Visible = true;
                }

                if (txtBoxBusquedaAlu.Visible == false)
                {
                    txtBoxBusquedaAlu.Visible = true;
                }


            }
        }


        private void txtBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbAlumnosLegajo.Checked == true)
                {
                    dgvAlumnosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnosActivos, BLL_Alumno.Ver_Alumnos_Legajo(LA, txtBoxBusquedaAlu.Text));
                    Actualizar_TextBox_Alumnos();
                }
                else if (rbAlumnosDNI.Checked == true)
                {
                    dgvAlumnosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnosActivos, BLL_Alumno.Ver_Alumnos_DNI(LA, int.Parse(txtBoxBusquedaAlu.Text)));
                    Actualizar_TextBox_Alumnos();
                }
                else if (rbAlumnosApellido.Checked == true)
                {
                    dgvAlumnosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnosActivos, BLL_Alumno.Ver_Alumnos_Apellido(LA, txtBoxBusquedaAlu.Text));
                    Actualizar_TextBox_Alumnos();
                }
                else if (rbAlumnosNombre.Checked == true)
                {
                    dgvAlumnosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnosActivos, BLL_Alumno.Ver_Alumnos_Nombre(LA, txtBoxBusquedaAlu.Text));
                    Actualizar_TextBox_Alumnos();
                }
                else if (rbAlumnosTurno.Checked == true)
                {
                    dgvAlumnosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnosActivos, BLL_Alumno.Ver_Alumnos_Turno(LA, txtBoxBusquedaAlu.Text));
                    Actualizar_TextBox_Alumnos();
                }

            }
            catch (Exception) { }
        }
        public void Actualizar_TextBox_Alumnos()
        {
            if (dgvAlumnosActivos.Rows.Count != 0)
            {
                dgvAlumnosActivos_Click(null, null);
            }            
        }
        public void Actualizar_TextBox_Cursos()
        {
            if (dgvCursosActivos.Rows.Count != 0)
            {
                dgvCursosActivos_Click(null, null);
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
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { }
        }
        public Curso ObtenerCurso(int pCodigo)
        {
            Curso C = LC.Find(X => X.Codigo == pCodigo);
            return C;
        }

        private void btnAgregarCursada_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnosActivos.Rows.Count > 0 && dgvCursosActivos.Rows.Count> 0)
                {
                    Alumno A = ObtenerAlumno((string)dgvAlumnosActivos.SelectedRows[0].Cells[0].Value);
                    Curso C = ObtenerCurso((int)dgvCursosActivos.SelectedRows[0].Cells[0].Value);

                    if (BLL_Curso.Verificar_Alumno_es_Docente_del_Curso(A, C) == false)
                    {
                        throw new Exception("El Alumno " + A.Apellido + ", " + A.Nombre + " dicta una Materia en ese Curso");
                    }

                    if (A.Turno.Nombre == C.Turno.Nombre)
                    {
                        AgregarCursada(A, C);
                    }
                    else { throw new Exception("Está intentando inscribir a un Alumno del Turno " + A.Turno + " a un Curso del Turno " + C.Turno); }
                }
                else { throw new Exception("Debe haber mínimamente un Alumno y un Curso"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void AgregarCursada(Alumno pAlumno, Curso pCurso)
        {
            try
            {
                if (BLL_Cursada_De_Alumno.Verficar_Existencia_Cursada(pAlumno,pCurso)==false)
                {
                    BLL_Cursada_De_Alumno.Agregar_Cursada(pAlumno, pCurso);
                    LogManager.Escribir(ID, "Inscribió al Alumno " + pAlumno.Legajo + " al Curso " + pCurso.Codigo, 3);
                    MessageBox.Show("Se ha inscrito al Alumno " + pAlumno.Legajo + " al Curso " + pCurso.Codigo, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { throw new Exception("Este Alumno ya está asignado a este Curso"); }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void rbCursosTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCursosTodos.Checked == true)
            {
                LC = BLL_Curso.Ver_Cursos_Con_Inscripciones_Abiertas();
                dgvCursosActivos.Rows.Clear();
                MostrarDatosEnGrilla(dgvCursosActivos, LC);

                lblBusquedaCursos.Visible = false;
                txtBoxBusquedaCurso.Visible = false;

                if (LC.Count != 0)
                {
                    dgvAlumnosActivos_Click(null, null);
                }
            }
        }

        private void rbCursosCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCursosCodigo.Checked == true)
            {
                if (lblBusquedaCursos.Visible == false)
                {
                    lblBusquedaCursos.Visible = true;
                }

                if (txtBoxBusquedaCurso.Visible == false)
                {
                    txtBoxBusquedaCurso.Visible = true;
                }
            }
        }

        private void rbCursosNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCursosNombre.Checked == true)
            {
                if (lblBusquedaCursos.Visible == false)
                {
                    lblBusquedaCursos.Visible = true;
                }

                if (txtBoxBusquedaCurso.Visible == false)
                {
                    txtBoxBusquedaCurso.Visible = true;
                }
            }
        }
    

        private void rbCursosAño_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCursosAño.Checked == true)
            {
                if (lblBusquedaCursos.Visible == false)
                {
                    lblBusquedaCursos.Visible = true;
                }

                if (txtBoxBusquedaCurso.Visible == false)
                {
                    txtBoxBusquedaCurso.Visible = true;
                }
            }
        }    

        private void rbCursosTurno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCursosTurno.Checked == true)
            {
                if (lblBusquedaCursos.Visible == false)
                {
                    lblBusquedaCursos.Visible = true;
                }

                if (txtBoxBusquedaCurso.Visible == false)
                {
                    txtBoxBusquedaCurso.Visible = true;
                }
            }
        }

        private void txtBoxBusquedaCurso_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbCursosCodigo.Checked == true)
                {
                    dgvCursosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvCursosActivos, BLL_Curso.Ver_Cursos_Codigo(LC, txtBoxBusquedaCurso.Text));
                    Actualizar_TextBox_Cursos();
                }
                else if (rbCursosNombre.Checked == true)
                {
                    dgvCursosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvCursosActivos, BLL_Curso.Ver_Cursos_Nombre(LC, txtBoxBusquedaCurso.Text));
                    Actualizar_TextBox_Cursos();
                }
                else if (rbCursosAño.Checked == true)
                {
                    dgvCursosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvCursosActivos, BLL_Curso.Ver_Cursos_Año(LC, txtBoxBusquedaCurso.Text));
                    Actualizar_TextBox_Cursos();
                }
                else if (rbCursosTurno.Checked == true)
                {
                    dgvCursosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvCursosActivos, BLL_Curso.Ver_Cursos_Turno(LC, txtBoxBusquedaCurso.Text));
                    Actualizar_TextBox_Cursos();
                }               

            }
            catch (Exception) { }
        }

        private void dgvCursosActivos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCursosActivos.Rows.Count > 0)
                {
                    Curso C = ObtenerCurso((int)dgvCursosActivos.SelectedRows[0].Cells[0].Value);
                }
            }
            catch (Exception ex) { }
        }
    }
}
