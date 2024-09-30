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
    public partial class FormCrearDictado : Form
    {
        public FormCrearDictado(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();
            ID = pKey;
        }

        public int ID;
        public BLL_Docente BLL_Docente;
        public BLL_Dictado BLL_Dictado;
        public BLL_Materia BLL_Materia;
        public BLL_Curso BLL_Curso;

        List<Materia> LM;
        List<Docente> LD;
        List<Curso> LC;

        Materia Materia;
        Curso Curso;
        List<Docente> DocentesDeDictado;

        private void FormCrearDictado_Load(object sender, EventArgs e)
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

            Verificar_Listas();

            DocentesDeDictado = new List<Docente>();

            MostrarCursosEnGrilla(dgvCursos, LC);
            MostrarMateriasEnGrilla(dgvMaterias, LM);
            MostrarDocentesEnGrilla(dgvDocentes, LD);
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
                if (Materia == null)
                {
                    Materia = ObtenerMateria((int)dgvMaterias.SelectedRows[0].Cells[0].Value);
                    txtboxMateriaSelected.Text = Materia.Nombre;
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
                if (Materia != null)
                {
                    Materia = null;
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

                if (!(DocentesDeDictado.Exists(X=> X.Legajo == D.Legajo)))
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
                        DocentesDeDictado.Remove(D);

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

        private void btnCrearDictado_Click(object sender, EventArgs e)
        {
            try
            {
                if (Curso != null && Materia != null && DocentesDeDictado.Count > 0)
                {
                    foreach (Docente docente in DocentesDeDictado)
                    {
                        if (BLL_Curso.Verificar_Docente_es_Alumno_del_Curso(docente, Curso) == false)
                        {
                            throw new Exception("El Docente " + docente.Apellido + ", " + docente.Nombre + " está Inscrito como Alumno en el Curso seleccionado");
                        }
                    }
                    
                    if (MessageBox.Show("¿Desea crear el Dictado?\n\nEl Dictado será:\n\n" + "Del Curso " + Curso.Nombre + " Turno " + Curso.Turno + "\n" + "De la Materia " + Materia.Nombre, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BLL_Dictado.Crear_Dictado(Curso, Materia, DocentesDeDictado);
                        LogManager.Escribir(ID, "Creó un Dictado", 3);

                        LM = BLL_Materia.Ver_Materias_Activas_Sin_Curso();
                        LD = BLL_Docente.Ver_Docentes_Activos();
                        LC = BLL_Curso.Ver_Cursos_Activos();

                        dgvCursos.Rows.Clear();
                        dgvMaterias.Rows.Clear();
                        dgvDocentes.Rows.Clear();

                        MostrarCursosEnGrilla(dgvCursos, LC);
                        MostrarMateriasEnGrilla(dgvMaterias, LM);
                        MostrarDocentesEnGrilla(dgvDocentes, LD);

                        DocentesDeDictado.Clear();
                        lbDocentesSelected.Items.Clear();
                        txtBoxCursoSelected.Text = "";
                        txtboxMateriaSelected.Text = "";

                        btnSeleccionarCurso.Enabled = true;
                        btnSeleccionarMateria.Enabled = true;
                        btnDeseleccionarCurso.Enabled = false;
                        btnDeseleccionarMateria.Enabled = false;

                        Materia = null;
                        Curso = null;

                        Verificar_Listas();
                    }
                }
                else { throw new Exception("Debe rellenar todos los campos"); }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Verificar_Listas()
        {
            if (LM.Count == 0)
            {
                //MessageBox.Show("No hay Materias Activas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnAgregarDocente.Enabled = false;
                btnCrearDictado.Enabled = false;
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
                btnCrearDictado.Enabled = false;
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
                btnCrearDictado.Enabled = false;
                btnSeleccionarCurso.Enabled = false;
                btnDeseleccionarCurso.Enabled = false;
                btnDeseleccionarMateria.Enabled = false;
                btnQuitarDocente.Enabled = false;
                btnSeleccionarMateria.Enabled = false;
            }
        }
    }
}
