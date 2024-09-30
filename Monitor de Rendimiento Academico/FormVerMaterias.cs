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
    public partial class FormVerMaterias : Form
    {
        public FormVerMaterias(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;
        BLL_Materia BLL_Materia;
        List<Materia> LM;
        FormVerTemas FormVerTemas;
        FormModificarMateria FormModificarMateria;

        private void FormVerMaterias_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Materia = new BLL_Materia();
            LM = BLL_Materia.Ver_Materias_Activas();

            lblBusqueda.Visible = false;
            txtBoxBusqueda.Visible = false;

            MostrarDatosEnGrilla(dgvMateriasActivas, LM);

            if (dgvMateriasActivas.Rows.Count > 0)
            {

            }
            else { MessageBox.Show("No hay Materias", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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
                        if (M.RetornarCurso().Codigo==0) 
                        { 
                            pDGV.Rows.Add(M.Codigo, M.Nombre, M.Cant_Horas_Semanales, "-"); 
                        }
                        else
                        {
                            pDGV.Rows.Add(M.Codigo, M.Nombre, M.Cant_Horas_Semanales, M.RetornarCurso().Codigo + " - " + M.RetornarCurso().Nombre + " - " + M.RetornarCurso().Turno);
                        }                        
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void rbMateriasActivas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbMateriasActivas.Checked==true)
                {
                    LM = BLL_Materia.Ver_Materias_Activas();
                    dgvMateriasActivas.Rows.Clear();
                    MostrarDatosEnGrilla(dgvMateriasActivas, LM);
                    if (btnDarDeBajaMateria.Enabled == false)
                    {
                        btnDarDeBajaMateria.Enabled = true;
                    }
                    if (btnModificarMateria.Enabled == false)
                    {
                        btnModificarMateria.Enabled = true;
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void rbMateriasInactivas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMateriasInactivas.Checked == true)
            {
                LM = BLL_Materia.Ver_Materias_Inactivas();
                dgvMateriasActivas.Rows.Clear();
                MostrarDatosEnGrilla(dgvMateriasActivas, LM);
                btnDarDeBajaMateria.Enabled = false;
                btnModificarMateria.Enabled = false;
            }
        }

        private void btnVerTemasDeMateria_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormVerTemas is null)
                {
                    if (dgvMateriasActivas.Rows.Count>0)
                    {
                        Materia M = ObtenerMateria((int)dgvMateriasActivas.SelectedRows[0].Cells[0].Value);
                        FormVerTemas = new FormVerTemas(ID, M);
                        FormVerTemas.FormClosed += FormVerTemas_FormClosed;
                        FormVerTemas.ShowDialog();
                    }                    
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerTemas_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerTemas = null;
        }

        private void btnDarDeBajaMateria_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMateriasActivas.Rows.Count>0)
                {
                    Materia M = ObtenerMateria((int)dgvMateriasActivas.SelectedRows[0].Cells[0].Value);
                    
                    if (M.RetornarCurso().Codigo == 0)
                    {
                        BLL_Materia.Dar_De_Baja_Materia(M);
                        MessageBox.Show("Se ha dado de baja la Materia" + M.Nombre, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogManager.Escribir(ID, "Dio de baja la Materia " + M.Nombre, 3);
                        dgvMateriasActivas.Rows.Clear();
                        LM = BLL_Materia.Ver_Materias_Activas();
                        MostrarDatosEnGrilla(dgvMateriasActivas, LM);
                    }
                    else { throw new Exception("Esta Materia ya está asignada a un Curso\n\nPara dar de baja las Materias del Curso, debe dar de baja el Curso"); }                    
                }               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnModificarMateria_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormModificarMateria is null)
                {
                    if (dgvMateriasActivas.Rows.Count > 0)
                    {
                        Materia M = ObtenerMateria((int)dgvMateriasActivas.SelectedRows[0].Cells[0].Value);
                        FormModificarMateria = new FormModificarMateria(ID, M);
                        FormModificarMateria.FormClosed += FormModificarMateria_FormClosed;
                        FormModificarMateria.ShowDialog();
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void FormModificarMateria_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                FormModificarMateria = null;
                dgvMateriasActivas.Rows.Clear();
                LM = BLL_Materia.Ver_Materias_Activas();
                MostrarDatosEnGrilla(dgvMateriasActivas, LM);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked == true)
            {
                if (rbMateriasActivas.Checked == true)
                {
                    LM = BLL_Materia.Ver_Materias_Activas();
                    dgvMateriasActivas.Rows.Clear();
                    MostrarDatosEnGrilla(dgvMateriasActivas, LM);
                }
                else if (rbMateriasInactivas.Checked == true)
                {
                    LM = BLL_Materia.Ver_Materias_Inactivas();
                    dgvMateriasActivas.Rows.Clear();
                    MostrarDatosEnGrilla(dgvMateriasActivas, LM);
                }

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

        private void rbCantHoras_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCantHoras.Checked == true)
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

        private void rbCurso_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCurso.Checked == true)
            {
                if (lblBusqueda.Visible == false)
                {
                    lblBusqueda.Visible = true;
                }

                if (txtBoxBusqueda.Visible == false)
                {
                    txtBoxBusqueda.Visible = true;
                }

                txtBoxBusqueda_TextChanged(null, null);
            }
        }

        private void rbSinCurso_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSinCurso.Checked == true)
            {
                lblBusqueda.Visible = false;
                txtBoxBusqueda.Visible = false;

                dgvMateriasActivas.Rows.Clear();
                MostrarDatosEnGrilla(dgvMateriasActivas, BLL_Materia.Ver_Materias_Sin_Curso(LM));
            }
        }

        private void txtBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbCodigo.Checked == true)
                {
                    dgvMateriasActivas.Rows.Clear();
                    MostrarDatosEnGrilla(dgvMateriasActivas, BLL_Materia.Ver_Materias_Codigo(LM, txtBoxBusqueda.Text));
                }
                else if (rbNombre.Checked == true)
                {
                    dgvMateriasActivas.Rows.Clear();
                    MostrarDatosEnGrilla(dgvMateriasActivas, BLL_Materia.Ver_Materias_Nombre(LM, txtBoxBusqueda.Text));
                }
                else if (rbCantHoras.Checked == true)
                {
                    dgvMateriasActivas.Rows.Clear();
                    MostrarDatosEnGrilla(dgvMateriasActivas, BLL_Materia.Ver_Materias_Horas(LM, int.Parse(txtBoxBusqueda.Text)));
                }
                else if (rbCurso.Checked == true)
                {
                    dgvMateriasActivas.Rows.Clear();
                    MostrarDatosEnGrilla(dgvMateriasActivas, BLL_Materia.Ver_Materias_Curso(LM, txtBoxBusqueda.Text));
                }

            }
            catch (Exception) { }
        }
    }
}
