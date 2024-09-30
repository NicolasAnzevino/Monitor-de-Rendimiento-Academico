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
    public partial class FormVerMateria : Form
    {
        public FormVerMateria(int pKey, Curso pCurso, Materia pMateria, Dictado pDictado)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Curso = pCurso;
            Materia = pMateria;
            Dictado = pDictado;
        }

        public int ID;
        public Curso Curso;
        public Materia Materia;
        public Dictado Dictado;
        public BLL_Curso BLL_Curso;
        public BLL_Materia BLL_Materia;
        public BLL_Alumno BLL_Alumno;
        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        public List<Alumno> LA;
        public List<Evaluacion> LE;
        FormAgregarEvaluacion FormAgregarEvaluacion;
        FormModificarEvaluacion FormModificarEvaluacion;
        FormAgregarCalificacion FormAgregarCalificacion;
        FormVerCalificacionesDeAlumnoDeMateria FormVerCalificacionesDeAlumnoDeMateria;
        FormAgregarClase FormAgregarClase;
        FormVerClasesDeDictado FormVerClasesDeDictado;

        private void FormVerMateria_Load(object sender, EventArgs e)
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

            if (LE.Count>0)
            {
                dgvEvaluaciones_Click(null, null);
            }

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

        private void btnAgregarEvaluacion_Click(object sender, EventArgs e)
        {
            if (FormAgregarEvaluacion is null)
            {
                FormAgregarEvaluacion = new FormAgregarEvaluacion(ID, Materia);
                FormAgregarEvaluacion.FormClosed += FormAgregarEvaluacion_FormClosed;
                FormAgregarEvaluacion.ShowDialog();
            }            
        }

        private void FormAgregarEvaluacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAgregarEvaluacion = null;
            LE = BLL_Materia.Ver_Evaluaciones_de_Materia(Materia);
            dgvEvaluaciones.Rows.Clear();
            MostrarDatosEnGrilla(dgvEvaluaciones, LE);
            dgvEvaluaciones_Click(null, null);
        }

        private void btnAgregarCalificacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormAgregarCalificacion is null)
                {
                    if (LE.Count > 0 && LA.Count > 0)
                    {
                        Alumno A = ObtenerAlumno((string)dgvAlumnos.SelectedRows[0].Cells[0].Value);
                        Evaluacion E = ObtenerEvaluacion((int)dgvEvaluaciones.SelectedRows[0].Cells[0].Value);

                        FormAgregarCalificacion = new FormAgregarCalificacion(ID, A, Curso, Materia, E);
                        FormAgregarCalificacion.FormClosed += FormAgregarCalificacion_FormClosed;
                        FormAgregarCalificacion.ShowDialog();
                    }
                    else
                    {
                        throw new Exception("Debe haber mínimamente un Alumno y una Evaluación en el Dictado para poder agregar una Calificación");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormAgregarCalificacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAgregarCalificacion = null;
        }

        private void btnEliminarEvaluacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (LE.Count > 0)
                {
                    Evaluacion E = ObtenerEvaluacion((int)dgvEvaluaciones.SelectedRows[0].Cells[0].Value);

                    if (BLL_Cursada_de_Alumno.Verificar_Existencia_Evaluaciones_Alumno(E.Codigo) == false)
                    {
                        LogManager.Escribir(ID, "Eliminó la Evaluación con ID " + E.Codigo + " - " + E.Fecha.ToShortDateString(), 3);
                        Borrar_Evaluacion(E);
                        MessageBox.Show("La Evaluación fue eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { throw new Exception("Ya hay Calificaciones asignadas a esta Evaluación, por lo que no se permite eliminarla o modificarla"); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnModificarEvaluacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (LE.Count > 0)
                {
                    Evaluacion E = ObtenerEvaluacion((int)dgvEvaluaciones.SelectedRows[0].Cells[0].Value);

                    if (BLL_Cursada_de_Alumno.Verificar_Existencia_Evaluaciones_Alumno(E.Codigo) == false)
                    {
                        Modificar_Evaluacion(E);                        
                    }
                    else { throw new Exception("Ya hay Calificaciones asignadas a esta Evaluación, por lo que no se permite eliminarla o modificarla"); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Modificar_Evaluacion(Evaluacion pEvaluacion)
        {
            try
            {
                try
                {
                    if (FormModificarEvaluacion is null)
                    {
                        if (LE.Count > 0)
                        {
                            Evaluacion E = ObtenerEvaluacion((int)dgvEvaluaciones.SelectedRows[0].Cells[0].Value);

                            FormModificarEvaluacion = new FormModificarEvaluacion(ID, Materia, E);
                            FormModificarEvaluacion.FormClosed += FormModificarEvaluacion_FormClosed;
                            FormModificarEvaluacion.ShowDialog();
                        }
                        else
                        {
                            throw new Exception("Debe haber mínimamente una Evaluación en el Dictado para poder modificarla");
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void FormModificarEvaluacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormModificarEvaluacion = null;
            LE = BLL_Materia.Ver_Evaluaciones_de_Materia(Materia);
            dgvEvaluaciones.Rows.Clear();
            MostrarDatosEnGrilla(dgvEvaluaciones, LE);
            dgvEvaluaciones_Click(null, null);
        }

        public void Borrar_Evaluacion(Evaluacion pEvaluacion)
        {
            try
            {
                BLL_Materia.Borrar_Evaluacion(pEvaluacion);
                LE = BLL_Materia.Ver_Evaluaciones_de_Materia(Materia);
                dgvEvaluaciones.Rows.Clear();
                MostrarDatosEnGrilla(dgvEvaluaciones, LE);
                dgvEvaluaciones_Click(null, null);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void btnVerCalificaciones_Click(object sender, EventArgs e)
        {
            if (FormVerCalificacionesDeAlumnoDeMateria is null)
            {
                if (LA.Count>0)
                {
                    Alumno A = ObtenerAlumno((string)dgvAlumnos.SelectedRows[0].Cells[0].Value);
                    Cursada_de_Alumno CA = BLL_Cursada_de_Alumno.Buscar_Cursada_de_Alumno(A, Curso);

                    FormVerCalificacionesDeAlumnoDeMateria = new FormVerCalificacionesDeAlumnoDeMateria(ID, CA, Materia);
                    FormVerCalificacionesDeAlumnoDeMateria.FormClosed += FormVerCalificacionesDeAlumnoDeMateria_FormClosed;
                    FormVerCalificacionesDeAlumnoDeMateria.ShowDialog();
                }               
            }
        }

        private void FormVerCalificacionesDeAlumnoDeMateria_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerCalificacionesDeAlumnoDeMateria = null;
        }

        private void btnAgregarClase_Click(object sender, EventArgs e)
        {
            if (FormAgregarClase is null)
            {
                if (LA.Count > 0)
                {
                    FormAgregarClase FormAgregarClase = new FormAgregarClase(ID, Dictado, Materia);
                    FormAgregarClase.FormClosed += FormAgregarClase_FormClosed;
                    FormAgregarClase.ShowDialog();
                }
                else { MessageBox.Show("Debe haber mínimamente un Alumno en el curso para que se dicte una clase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }          
            
        }

        private void FormAgregarClase_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAgregarClase = null;
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
