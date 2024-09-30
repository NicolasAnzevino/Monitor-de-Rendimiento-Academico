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
    public partial class FormVerMateriasCompararDocente : Form
    {
        public FormVerMateriasCompararDocente(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;
        BLL_Materia BLL_Materia;
        List<Materia> LM;
        FormVerDocentesCompararDocentes FormVerDocentesCompararDocentes;

        private void FormVerMateriasCompararDocente_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Materia = new BLL_Materia();
            LM = BLL_Materia.Ver_Materias_Activas_Con_Curso();

            if (LM.Count>0)
            {
                MostrarDatosEnGrilla(dgvMateriasActivas, LM);
                dgvMateriasActivas_Click(null, null);
            }
            else { MessageBox.Show("No hay Materias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }           
        }

        public Materia ObtenerMateria(int pCodigo)
        {
            Materia M = LM.Find(X => X.Codigo == pCodigo);
            return M;
        }

        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Materia> LM)
        {
            try
            {
                if (LM.Count != 0)
                {
                    foreach (Materia M in LM)
                    {
                        if (M.RetornarCurso().Codigo == 0)
                        {
                            pDGV.Rows.Add(M.Codigo, M.Nombre, M.Cant_Horas_Semanales, "-");
                        }
                        else
                        {
                            pDGV.Rows.Add(M.Codigo, M.Nombre, M.Cant_Horas_Semanales, M.RetornarCurso().Nombre);
                        }
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; MessageBox.Show("No hay Materias", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void rbMateriasActivas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbMateriasActivas.Checked == true)
                {
                    LM = BLL_Materia.Ver_Materias_Activas_Con_Curso();
                    dgvMateriasActivas.Rows.Clear();
                    MostrarDatosEnGrilla(dgvMateriasActivas, LM);

                    if (LM.Count > 0)
                    {
                        dgvMateriasActivas_Click(null, null);
                    }
                    else
                    {
                        dgvTemas.Rows.Clear();
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void rbMateriasInactivas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbMateriasInactivas.Checked == true)
                {
                    LM = BLL_Materia.Ver_Materias_Inactivas_Con_Curso();
                    dgvMateriasActivas.Rows.Clear();
                    MostrarDatosEnGrilla(dgvMateriasActivas, LM);

                    if (LM.Count > 0)
                    {
                        dgvMateriasActivas_Click(null, null);
                    }
                    else
                    {
                        dgvTemas.Rows.Clear();
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }     

        private void dgvMateriasActivas_Click(object sender, EventArgs e)
        {
            try
            {
                if (LM.Count>0)
                {
                    Materia M = ObtenerMateria((int)dgvMateriasActivas.SelectedRows[0].Cells[0].Value);
                    MostrarDatosEnGrillaMateriaTema(dgvTemas, M.VerTemas());
                    dgvTemas_Click(null, null);
                }
                else { throw new Exception("No hay Materias"); }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void btnSeleccionarTema_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTemas.Rows.Count > 0)
                {
                    Materia M = ObtenerMateria((int)dgvMateriasActivas.SelectedRows[0].Cells[0].Value);
                    Tema T = ObtenerTema((int)dgvTemas.SelectedRows[0].Cells[0].Value, M);        
                    
                    if (FormVerDocentesCompararDocentes is null)
                    {
                        FormVerDocentesCompararDocentes = new FormVerDocentesCompararDocentes(ID, T);
                        FormVerDocentesCompararDocentes.FormClosed += FormVerDocentesCompararDocentes_FormClosed;
                        FormVerDocentesCompararDocentes.ShowDialog();
                    }
                }
                else { }
            }
            catch (Exception ex) { }
        }

        private void FormVerDocentesCompararDocentes_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerDocentesCompararDocentes = null;
        }

        private void dgvTemas_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTemas.Rows.Count > 0)
                {
                    Materia M = ObtenerMateria((int)dgvMateriasActivas.SelectedRows[0].Cells[0].Value);
                    Tema T = ObtenerTema((int)dgvTemas.SelectedRows[0].Cells[0].Value, M);
                    txtBoxDescripcionTema.Text = "";

                    if (T.Descripcion!=null)
                    {
                        txtBoxDescripcionTema.Text = T.Descripcion;
                    }
                    else { txtBoxDescripcionTema.Text = ""; }
                }
                else { txtBoxDescripcionTema.Text = ""; }

            }
            catch (Exception ex) { }
        }
        public void MostrarDatosEnGrillaMateriaTema(DataGridView pDGV, List<Tema> L)
        {
            try
            {
                if (L.Count != 0)
                {
                    pDGV.Rows.Clear();

                    foreach (Tema T in L)
                    {
                        pDGV.Rows.Add(T.Codigo, T.Nombre);
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public Tema ObtenerTema(int pID, Materia pMateria)
        {
            Tema T = pMateria.VerTemas().Find(X => X.Codigo == pID);
            return T;
        }
    }
}
