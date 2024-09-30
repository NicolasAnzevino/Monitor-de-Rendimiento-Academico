using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq.SqlClient;
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
    public partial class FormVerDocentesProblemas : Form
    {
        public FormVerDocentesProblemas(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;
        List<Docente> LD;
        BLL_Docente BLL_Docente;
        FormInformeProblemaDocente FormInformeProblemaDocente;

        private void FormVerDocentesProblemas_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Docente = new BLL_Docente();

            LD = BLL_Docente.Ver_Docentes_Activos();
            MostrarDatosEnGrilla(dgvDocentesActivos, LD);

            lblBusqueda.Visible = false;
            txtBoxBusqueda.Visible = false;

            if (dgvDocentesActivos.Rows.Count > 0)
            {

            }
            else { MessageBox.Show("No hay Docentes", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Docente> LD)
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

        private void rbDocentesActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDocentesActivos.Checked == true)
            {
                LD = BLL_Docente.Ver_Docentes_Activos();
                dgvDocentesActivos.Rows.Clear();
                MostrarDatosEnGrilla(dgvDocentesActivos, LD);
            }
        }

        private void rbDocentesInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDocentesInactivos.Checked == true)
            {
                LD = BLL_Docente.Ver_Docentes_Inactivos();
                dgvDocentesActivos.Rows.Clear();
                MostrarDatosEnGrilla(dgvDocentesActivos, LD);
            }
        }

        private void rbDocentesTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDocentesTodos.Checked == true)
            {
                if (rbDocentesActivos.Checked == true)
                {
                    LD = BLL_Docente.Ver_Docentes_Activos();
                    dgvDocentesActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvDocentesActivos, LD);
                }
                else if (rbDocentesInactivos.Checked == true)
                {
                    LD = BLL_Docente.Ver_Docentes_Inactivos();
                    dgvDocentesActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvDocentesActivos, LD);
                }

                lblBusqueda.Visible = false;
                txtBoxBusqueda.Visible = false;
            }
        }

        private void rbDocentesLegajo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDocentesLegajo.Checked == true)
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

        private void rbDocentesDNI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDocentesDNI.Checked == true)
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

        private void rbDocentesApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDocentesApellido.Checked == true)
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

        private void rbDocentesNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDocentesNombre.Checked == true)
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
                if (rbDocentesLegajo.Checked == true)
                {
                    dgvDocentesActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvDocentesActivos, BLL_Docente.Ver_Docentes_Legajo(LD, txtBoxBusqueda.Text));
                }
                else if (rbDocentesDNI.Checked == true)
                {
                    dgvDocentesActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvDocentesActivos, BLL_Docente.Ver_Docentes_DNI(LD, txtBoxBusqueda.Text));
                }
                else if (rbDocentesApellido.Checked == true)
                {
                    dgvDocentesActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvDocentesActivos, BLL_Docente.Ver_Docentes_Apellido(LD, txtBoxBusqueda.Text));
                }
                else if (rbDocentesNombre.Checked == true)
                {
                    dgvDocentesActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvDocentesActivos, BLL_Docente.Ver_Docentes_Nombre(LD, txtBoxBusqueda.Text));
                }

            }
            catch (Exception) { }
        }

        private void btnSeleccionarDocente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDocentesActivos.Rows.Count > 0)
                {
                    Docente D = ObtenerDocente((string)dgvDocentesActivos.SelectedRows[0].Cells[0].Value);

                    if (BLL_Docente.Obtener_Cant_Evaluaciones_Corregidas(D) > 0)
                    {
                        if (FormInformeProblemaDocente == null)
                        {
                            FormInformeProblemaDocente = new FormInformeProblemaDocente(ID, D);
                            FormInformeProblemaDocente.FormClosed += FormInformeProblemaDocente_FormClosed;
                            FormInformeProblemaDocente.ShowDialog();
                        }
                    }
                    else { throw new Exception("El Docente seleccionado no corrigió ninguna evaluación"); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormInformeProblemaDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInformeProblemaDocente = null;
        }
    }
}
