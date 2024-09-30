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
    public partial class FormModificarDictado : Form
    {
        public FormModificarDictado(int pKey, Materia pMateria, Dictado pDictado, List<Docente> pDocentesDeDictado, bool pTieneEvaluaciones)
        {
            InitializeComponent();
            this.CenterToParent();
            ID = pKey;
            TieneEvaluaciones = pTieneEvaluaciones;
            Dictado = pDictado;
            Materia = pMateria;
            DocentesDeDictado = pDocentesDeDictado;
        }

        public int ID;
        public bool TieneEvaluaciones;
        public Dictado Dictado;
        public BLL_Docente BLL_Docente;
        public BLL_Dictado BLL_Dictado;
        public BLL_Materia BLL_Materia;
        public BLL_Curso BLL_Curso;

        List<Materia> LM;
        List<Docente> LD;
        List<Curso> LC;

        Materia Materia, NuevaMateria;
        Curso Curso;
        List<Docente> DocentesDeDictado;

        private void FormModificarDictado_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            btnDeseleccionarMateria.Enabled = false;
            btnDeseleccionarCurso.Enabled = false;
            btnQuitarDocente.Enabled = false;

            BLL_Docente = new BLL_Docente();
            BLL_Dictado = new BLL_Dictado();
            BLL_Materia = new BLL_Materia();
            BLL_Curso = new BLL_Curso();

            LM = BLL_Materia.Ver_Materias_Activas_Sin_Curso();
            LD = BLL_Docente.Ver_Docentes_Activos();
            LC = BLL_Curso.Ver_Cursos_Activos();

            Curso = BLL_Curso.Obtener_Curso_de_Dictado(Dictado);

            LM.Add(Materia);

            Verificar_Listas();            

            NuevaMateria = Materia;

            MostrarCursosEnGrilla(dgvCursos, LC);
            MostrarMateriasEnGrilla(dgvMaterias, LM);
            MostrarDocentesEnGrilla(dgvDocentes, LD);
            Mostrar_Docentes_de_Dictado();

            btnSeleccionarCurso.Enabled = false;
            btnDeseleccionarCurso.Enabled = true;

            btnSeleccionarMateria.Enabled = false;
            btnDeseleccionarMateria.Enabled = true;

            btnAgregarDocente.Enabled = true;
            btnQuitarDocente.Enabled = true;
            btnModificarDictado.Enabled = true;

            txtBoxCursoSelected.Text = Curso.Nombre;
            txtboxMateriaSelected.Text = Materia.Nombre;

            if (TieneEvaluaciones==true)
            {
                dgvMaterias.Enabled = false;
                dgvCursos.Enabled = false;
                btnSeleccionarCurso.Enabled = false;
                btnDeseleccionarCurso.Enabled = false;
                btnSeleccionarMateria.Enabled = false;
                btnDeseleccionarMateria.Enabled = false;

                MessageBox.Show("¡Atención!\n\nLa Materia seleccionada ya posee una o más Evaluaciones, por lo que solo se permitirá Agregar o Quitar Docentes de ella", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void MostrarMateriasEnGrilla(DataGridView pDGV, List<Materia> LM)
        {
            try
            {
                if (LM.Count != 0)
                {
                    foreach (Materia M in LM)
                    {
                        pDGV.Rows.Add(M.Codigo, M.Nombre, M.Cant_Horas_Semanales);
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Materia ObtenerMateria(int pCodigo)
        {
            Materia M = LM.Find(X => X.Codigo == pCodigo);
            return M;
        }

        public void MostrarDocentesEnGrilla(DataGridView pDGV, List<Docente> LD)
        {
            try
            {
                if (LD.Count != 0)
                {
                    foreach (Docente D in LD)
                    {
                        pDGV.Rows.Add(D.Legajo, D.DNI, D.Apellido, D.Nombre);
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Docente ObtenerDocente(string pLegajo)
        {
            Docente D = LD.Find(X => X.Legajo == pLegajo);
            return D;
        }

        public void MostrarCursosEnGrilla(DataGridView pDGV, List<Curso> LC)
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
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Curso ObtenerCurso(int pCodigo)
        {
            Curso C = LC.Find(X => X.Codigo == pCodigo);
            return C;
        }

        private void btnSeleccionarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (Curso == null)
                {
                    Curso = ObtenerCurso((int)dgvCursos.SelectedRows[0].Cells[0].Value);
                    txtBoxCursoSelected.Text = Curso.Nombre;
                    btnSeleccionarCurso.Enabled = false;
                    btnDeseleccionarCurso.Enabled = true;
                }
                else { throw new Exception("El Dictado ya posee un Curso seleccionado"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnDeseleccionarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (Curso != null)
                {
                    Curso = null;
                    txtBoxCursoSelected.Text = "";
                    btnSeleccionarCurso.Enabled = true;
                    btnDeseleccionarCurso.Enabled = false;
                }
                else { throw new Exception("El Dictado no posee algun Curso seleccionado"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSeleccionarMateria_Click(object sender, EventArgs e)
        {
            try
            {
                if (NuevaMateria == null)
                {
                    NuevaMateria = ObtenerMateria((int)dgvMaterias.SelectedRows[0].Cells[0].Value);
                    txtboxMateriaSelected.Text = NuevaMateria.Nombre;
                    btnSeleccionarMateria.Enabled = false;
                    btnDeseleccionarMateria.Enabled = true;
                }
                else { throw new Exception("El Dictado ya posee una Materia seleccionada"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDeseleccionarMateria_Click(object sender, EventArgs e)
        {
            try
            {
                if (NuevaMateria != null)
                {
                    NuevaMateria = null;
                    txtboxMateriaSelected.Text = "";
                    btnSeleccionarMateria.Enabled = true;
                    btnDeseleccionarMateria.Enabled = false;
                }
                else { throw new Exception("El Dictado no posee una Materia seleccionada"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            try
            {
                Docente D = ObtenerDocente((string)dgvDocentes.SelectedRows[0].Cells[0].Value);

                if (!(DocentesDeDictado.Exists(X => X.Legajo == D.Legajo)))
                {
                    DocentesDeDictado.Add(D);
                    lbDocentesSelected.Items.Add(D.Legajo + "-" + D.Apellido + ", " + D.Nombre);
                    btnQuitarDocente.Enabled = true;

                    if (lbDocentesSelected.SelectedIndex == -1)
                    {
                        lbDocentesSelected.SelectedIndex = 0;
                    }

                }
                else { throw new Exception("El Dictado ya posee al Docente seleccionado"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnQuitarDocente_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbDocentesSelected.Items.Count != 0)
                {
                    //Docente D = ObtenerDocente((string)dgvDocentes.SelectedRows[0].Cells[0].Value);
                    Docente D = ObtenerDocente(lbDocentesSelected.SelectedItem.ToString().Substring(0, lbDocentesSelected.SelectedItem.ToString().IndexOf("-")));

                    if (DocentesDeDictado.Exists(X => X.Legajo == D.Legajo))
                    {
                        DocentesDeDictado.Remove(DocentesDeDictado.SingleOrDefault(X => X.Legajo == D.Legajo));

                        lbDocentesSelected.Items.Clear();

                        if (DocentesDeDictado.Count != 0)
                        {
                            foreach (Docente d in DocentesDeDictado)
                            {
                                lbDocentesSelected.Items.Add(d.Legajo + "-" + d.Apellido + ", " + d.Nombre);
                            }
                        }

                        if (lbDocentesSelected.SelectedIndex == -1)
                        {
                            lbDocentesSelected.SelectedIndex = 0;
                        }
                    }
                    //else { throw new Exception("El Dictado no posee al Docente seleccionado"); }
                }
                else { btnQuitarDocente.Enabled = false; }

            }
            catch (Exception) { }
        }

        private void btnModificarDictado_Click(object sender, EventArgs e)
        {
            try
            {
                if (TieneEvaluaciones==false)
                {
                    if (Curso != null && NuevaMateria != null && DocentesDeDictado.Count > 0)
                    {
                        if (MessageBox.Show("¿Desea modificar el Dictado?\n\nEl Dictado será:\n\n" + "Del Curso " + Curso.Nombre + " Turno " + Curso.Turno + "\n" + "De la Materia " + Materia.Nombre, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            BLL_Dictado.Modificar_Dictado(Dictado, Curso, Materia, NuevaMateria, DocentesDeDictado);
                            LogManager.Escribir(ID, "Modificó el Dictado " + Dictado.Codigo, 2);
                            MessageBox.Show("El Dictado fue modificado correctamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else { throw new Exception("Debe rellenar todos los campos"); }
                }
                else
                {
                    if (DocentesDeDictado.Count > 0)
                    {
                        if (MessageBox.Show("¿Desea modificar el Dictado?\n\nEl Dictado será:\n\n" + "Del Curso " + Curso.Nombre + " Turno " + Curso.Turno + "\n" + "De la Materia " + Materia.Nombre, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            BLL_Dictado.Reasignar_Docentes_a_Dictado(Dictado, Curso, DocentesDeDictado);
                            LogManager.Escribir(ID, "Reasignó los Docentes del Dictado " + Dictado.Codigo, 2);
                            MessageBox.Show("El Dictado fue modificado correctamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else { throw new Exception("Debe rellenar todos los campos"); }
                }

                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Verificar_Listas()
        {
            if (LM.Count == 0)
            {
                MessageBox.Show("No hay Materias Activas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnAgregarDocente.Enabled = false;
                btnModificarDictado.Enabled = false;
                btnSeleccionarCurso.Enabled = false;
                btnDeseleccionarCurso.Enabled = false;
                btnDeseleccionarMateria.Enabled = false;
                btnQuitarDocente.Enabled = false;
                btnSeleccionarMateria.Enabled = false;
            }
            else if (LD.Count == 0)
            {
                MessageBox.Show("No hay Docentes Activos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnAgregarDocente.Enabled = false;
                btnModificarDictado.Enabled = false;
                btnSeleccionarCurso.Enabled = false;
                btnDeseleccionarCurso.Enabled = false;
                btnDeseleccionarMateria.Enabled = false;
                btnQuitarDocente.Enabled = false;
                btnSeleccionarMateria.Enabled = false;
            }
            else if (LC.Count == 0)
            {
                MessageBox.Show("No hay Cursos Activos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnAgregarDocente.Enabled = false;
                btnModificarDictado.Enabled = false;
                btnSeleccionarCurso.Enabled = false;
                btnDeseleccionarCurso.Enabled = false;
                btnDeseleccionarMateria.Enabled = false;
                btnQuitarDocente.Enabled = false;
                btnSeleccionarMateria.Enabled = false;
            }
        }

        public void Mostrar_Docentes_de_Dictado()
        {
            foreach (Docente D in DocentesDeDictado)
            {
                lbDocentesSelected.Items.Add(D.Legajo + "-" + D.Apellido + ", " + D.Nombre);
                btnQuitarDocente.Enabled = true;

                if (lbDocentesSelected.SelectedIndex == -1)
                {
                    lbDocentesSelected.SelectedIndex = 0;
                }
            }            
        }
    }
}
