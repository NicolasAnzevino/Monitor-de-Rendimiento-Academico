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
    public partial class FormVerDocentes : Form
    {
        public FormVerDocentes(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;
        List<Docente> LD;
        BLL_Docente BLL_Docente;
        FormModificarDocente FormModificarDocente;
        FormVerDictadosDocente FormVerDictadosDocente;

        private void FormVerDocentes_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Docente = new BLL_Docente();

            LD = BLL_Docente.Ver_Docentes_Activos();
            MostrarDatosEnGrilla(dgvDocentesActivos, LD);

            lblBusqueda.Visible = false;
            txtBoxBusqueda.Visible = false;

            btnDarDeAltaDocente.Visible = false;

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

                btnDarDeAltaDocente.Visible = false;

                if (dgvDocentesActivos.Rows.Count>0)
                {
                    btnVerDictados.Enabled = true;
                }
                else
                {
                    btnVerDictados.Enabled = false;
                }               

                if (btnDarDeBajaDocente.Enabled == false)
                {
                    btnDarDeBajaDocente.Enabled = true;
                }
                if (btnModificarDocente.Enabled == false)
                {
                    btnModificarDocente.Enabled = true;
                }
            }
        }

        private void rbDocentesInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDocentesInactivos.Checked == true)
            {
                LD = BLL_Docente.Ver_Docentes_Inactivos();
                dgvDocentesActivos.Rows.Clear();
                MostrarDatosEnGrilla(dgvDocentesActivos, LD);
                btnDarDeBajaDocente.Enabled = false;
                btnModificarDocente.Enabled = false;
                btnDarDeAltaDocente.Visible = true;

                if (dgvDocentesActivos.Rows.Count > 0)
                {
                    btnDarDeAltaDocente.Enabled = true;
                    btnVerDictados.Enabled = true;
                }
                else
                {
                    btnDarDeAltaDocente.Enabled = false;
                    btnVerDictados.Enabled = false;
                }
            }
        }

        private void rbDocentesTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDocentesTodos.Checked == true)
            {
                if (rbDocentesActivos.Checked == true)
                {
                    btnDarDeAltaDocente.Visible = false;
                    btnDarDeBajaDocente.Visible = true;

                    LD = BLL_Docente.Ver_Docentes_Activos();
                    dgvDocentesActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvDocentesActivos, LD);
                }
                else if (rbDocentesInactivos.Checked == true)
                {
                    btnDarDeAltaDocente.Visible = true;
                    btnDarDeBajaDocente.Visible = false;

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

        private void btnDarDeBajaDocente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDocentesActivos.Rows.Count > 0)
                {
                    Docente D = ObtenerDocente((string)dgvDocentesActivos.SelectedRows[0].Cells[0].Value);
                    if (MessageBox.Show("¿Está seguro de Dar de Baja a este Docente?\n\nNota: No se dará de baja al Usuario\nPara dar de baja al Usuario asociado de este Docente, hágalo desde el módulo *Ver Usuarios*", "Solicitud de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BLL_Docente.Dar_De_Baja_Docente(D);
                        MessageBox.Show("Se ha dado de baja el Docente " + D.Legajo, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogManager.Escribir(ID, "Dio de baja al Docente " + D.Legajo, 3);
                        dgvDocentesActivos.Rows.Clear();
                        LD = BLL_Docente.Ver_Docentes_Activos();
                        MostrarDatosEnGrilla(dgvDocentesActivos, LD);
                        rbDocentesActivos_CheckedChanged(null, null);
                    }                   
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnDarDeAltaDocente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDocentesActivos.Rows.Count > 0)
                {
                    Docente D = ObtenerDocente((string)dgvDocentesActivos.SelectedRows[0].Cells[0].Value);
                    if (MessageBox.Show("¿Está seguro de Dar de Alta a este Docente?\n\nNota: No se dará de alta al Usuario\nPara dar de alta al Usuario asociado de este Docente, hágalo desde el módulo *Ver Usuarios*", "Solicitud de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BLL_Docente.Dar_De_Alta_Docente(D);
                        MessageBox.Show("Se ha dado de Alta nuevamente el Docente " + D.Legajo, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogManager.Escribir(ID, "Dio de Alta nuevamente al Docente " + D.Legajo, 3);
                        dgvDocentesActivos.Rows.Clear();
                        LD = BLL_Docente.Ver_Docentes_Inactivos();
                        MostrarDatosEnGrilla(dgvDocentesActivos, LD);
                        rbDocentesInactivos_CheckedChanged(null, null);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnModificarDocente_Click(object sender, EventArgs e)
        {
            if (FormModificarDocente == null)
            {
                if (dgvDocentesActivos.Rows.Count > 0)
                {
                    Docente D = ObtenerDocente((string)dgvDocentesActivos.SelectedRows[0].Cells[0].Value);
                    FormModificarDocente = new FormModificarDocente(ID, D);
                    FormModificarDocente.FormClosed += FormModificarDocente_FormClosed;
                    FormModificarDocente.ShowDialog();
                }
            }
        }

        private void FormModificarDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormModificarDocente = null;
            dgvDocentesActivos.Rows.Clear();
            LD = BLL_Docente.Ver_Docentes_Activos();
            MostrarDatosEnGrilla(dgvDocentesActivos, LD);

            foreach (Control C in gpVisualizacion.Controls)
            {
                if (C is RadioButton)
                {
                    RadioButton RB = C as RadioButton;

                    RB.Checked = false;
                }
            }

            rbDocentesTodos.Checked = true;

        }

        private void btnVerDictados_Click(object sender, EventArgs e)
        {
            if (FormVerDictadosDocente == null)
            {
                if (dgvDocentesActivos.Rows.Count > 0)
                {
                    Docente D = ObtenerDocente((string)dgvDocentesActivos.SelectedRows[0].Cells[0].Value);
                    FormVerDictadosDocente = new FormVerDictadosDocente(ID, D);
                    FormVerDictadosDocente.FormClosed += FormVerDictadosDocente_FormClosed;
                    FormVerDictadosDocente.ShowDialog();
                }
            }
        }

        private void FormVerDictadosDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerDictadosDocente = null;
        }

       
    }
}

