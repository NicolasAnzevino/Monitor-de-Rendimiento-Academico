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
    public partial class FormVerDictados : Form
    {
        public FormVerDictados(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();
            ID = pKey;
        }

        public int ID;
        BLL_Dictado BLL_Dictado;
        BLL_Materia BLL_Materia;
        List<Dictado> LD;
        FormVerDictadoDelDocente FormVerDictadoDelDocente;
        FormModificarDictado FormModificarDictado;

        private void FormVerDictados_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Dictado = new BLL_Dictado();
            BLL_Materia = new BLL_Materia();

            LD = BLL_Dictado.Ver_Dictados_Activos();
            MostrarDatosEnGrilla(dgvDictados, LD);
            lblBusqueda.Visible = false;
            txtBoxBusqueda.Visible = false;


            if (LD.Count>0)
            {
                dgvDictados_Click(null, null);
            }
            else { MessageBox.Show("No hay Dictados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);}            
        }
        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Dictado> LD)
        {
            try
            {
                if (LD.Count != 0)
                {
                    foreach (Dictado D in LD)
                    {
                        pDGV.Rows.Add(D.Codigo, D.Materia.Nombre, D.Curso.Nombre);
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Dictado ObtenerDictado(int pID)
        {
            Dictado D = LD.Find(X => X.Codigo == pID);
            return D;
        }

        private void dgvDictados_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDictados.Rows.Count>0)
                {
                    lbDocentes.Items.Clear();

                    Dictado D = ObtenerDictado((int)dgvDictados.SelectedRows[0].Cells[0].Value);

                    foreach (Docente Docente in D.VerDocentes())
                    {
                        lbDocentes.Items.Add(Docente.Legajo + "-" + Docente.Apellido + ", " + Docente.Nombre);
                    }
                }
            }
            catch (Exception) { }
        }

        private void rbMateriasActivas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMateriasActivas.Checked==true)
            {
                dgvDictados.Rows.Clear();
                LD = BLL_Dictado.Ver_Dictados_Activos();
                MostrarDatosEnGrilla(dgvDictados, LD);

                lbDocentes.Items.Clear();

                if (LD.Count > 0)
                {
                    dgvDictados_Click(null, null);
                }
            }
        }

        private void rbMateriasInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMateriasInactivos.Checked == true)
            {
                dgvDictados.Rows.Clear();
                LD = BLL_Dictado.Ver_Dictados_Inactivos();
                MostrarDatosEnGrilla(dgvDictados, LD);

                lbDocentes.Items.Clear();

                if (LD.Count > 0)
                {
                    dgvDictados_Click(null, null);
                }
            }
        }

        private void btnVerMateria_Click(object sender, EventArgs e)
        {
            if (FormVerDictadoDelDocente is null)
            {
                if (dgvDictados.Rows.Count>0)
                {
                    Dictado D = ObtenerDictado((int)dgvDictados.SelectedRows[0].Cells[0].Value);

                    Materia M = BLL_Materia.Obtener_Materia_de_Dictado(D);

                    FormVerDictadoDelDocente = new FormVerDictadoDelDocente(ID, M, D);
                    FormVerDictadoDelDocente.FormClosed += FormVerDictadoDelDocente_FormClosed;
                    FormVerDictadoDelDocente.ShowDialog();
                }                
            }
        }

        private void FormVerDictadoDelDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerDictadoDelDocente = null;
        }

        private void btnModificarDictado_Click(object sender, EventArgs e)
        {
            if (FormModificarDictado is null)
            {
                if (dgvDictados.Rows.Count > 0)
                {
                    Dictado D = ObtenerDictado((int)dgvDictados.SelectedRows[0].Cells[0].Value);

                    Materia M = BLL_Materia.Obtener_Materia_de_Dictado(D);

                    bool B = BLL_Materia.Verificar_Evaluaciones_Materia(M);

                    FormModificarDictado = new FormModificarDictado(ID, M, D, D.VerDocentes(), B);
                    FormModificarDictado.FormClosed += FormModificarDictado_FormClosed;
                    FormModificarDictado.ShowDialog();
                }
            }
        }

        private void FormModificarDictado_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormModificarDictado = null;
            rbMateriasInactivos.Checked = false;
            rbMateriasActivas.Checked = true;

            dgvDictados.Rows.Clear();
            LD = BLL_Dictado.Ver_Dictados_Activos();
            MostrarDatosEnGrilla(dgvDictados, LD);

            if (LD.Count > 0)
            {
                dgvDictados_Click(null, null);
            }
            else { MessageBox.Show("No hay Dictados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked == true)
            {
                if (rbMateriasActivas.Checked == true)
                {
                    LD = BLL_Dictado.Ver_Dictados_Activos();
                    dgvDictados.Rows.Clear();
                    MostrarDatosEnGrilla(dgvDictados, LD);
                }
                else if (rbMateriasInactivos.Checked == true)
                {
                    LD = BLL_Dictado.Ver_Dictados_Inactivos();
                    dgvDictados.Rows.Clear();
                    MostrarDatosEnGrilla(dgvDictados, LD);
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

        private void rbMateria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMateria.Checked == true)
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
            }
        }

        private void rbDocente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDocente.Checked == true)
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
                    dgvDictados.Rows.Clear();
                    MostrarDatosEnGrilla(dgvDictados, BLL_Dictado.Ver_Dictados_Codigo(LD, txtBoxBusqueda.Text));

                    if (dgvDictados.Rows.Count > 0)
                    {
                        dgvDictados_Click(null, null);
                    }
                }
                else if (rbMateria.Checked == true)
                {
                    dgvDictados.Rows.Clear();
                    MostrarDatosEnGrilla(dgvDictados, BLL_Dictado.Ver_Dictados_Materia(LD, txtBoxBusqueda.Text));

                    if (dgvDictados.Rows.Count > 0)
                    {
                        dgvDictados_Click(null, null);
                    }
                }
                else if (rbCurso.Checked == true)
                {
                    dgvDictados.Rows.Clear();
                    MostrarDatosEnGrilla(dgvDictados, BLL_Dictado.Ver_Dictados_Curso(LD, txtBoxBusqueda.Text));

                    if (dgvDictados.Rows.Count > 0)
                    {
                        dgvDictados_Click(null, null);
                    }

                }
                else if (rbDocente.Checked == true)
                {
                    dgvDictados.Rows.Clear();
                    MostrarDatosEnGrilla(dgvDictados, BLL_Dictado.Ver_Dictados_Docente(LD, txtBoxBusqueda.Text));

                    if (dgvDictados.Rows.Count>0)
                    {
                        dgvDictados_Click(null, null);
                    }
                }
            }
            catch (Exception) { }
        }
    }
}
