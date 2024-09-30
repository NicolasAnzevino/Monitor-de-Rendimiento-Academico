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
    public partial class FormVerAlumnos : Form
    {
        public FormVerAlumnos(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;
        List<Alumno> LA;
        BLL_Alumno BLL_Alumno;
        BLL_Usuario BLL_Usuario;
        BLL_Docente BLL_Docente;
        FormModificarAlumno FormModificarAlumno;
        FormVerCursadasDeAlumno FormVerCursadasDeAlumno;

        private void FormVerAlumnos_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Alumno = new BLL_Alumno();
            BLL_Usuario = new BLL_Usuario();
            BLL_Docente = new BLL_Docente();

            LA = BLL_Alumno.Ver_Alumnos_Activos();
            MostrarDatosEnGrilla(dgvAlumnosActivos, LA);

            lblBusqueda.Visible = false;
            txtBoxBusqueda.Visible = false;

            if (dgvAlumnosActivos.Rows.Count > 0)
            {
                dgvAlumnosActivos_Click(null, null);
            }
            else { MessageBox.Show("No hay Alumnos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public Alumno ObtenerAlumno(string pLegajo)
        {
            Alumno A = LA.Find(X => X.Legajo == pLegajo);
            return A;
        }

        private void rbAlumnosActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosActivos.Checked == true)
            {
                LA = BLL_Alumno.Ver_Alumnos_Activos();
                dgvAlumnosActivos.Rows.Clear();
                MostrarDatosEnGrilla(dgvAlumnosActivos, LA);
                btnDarDeAltaAlumno.Visible = false;

                if (btnDarDeBajaAlumno.Visible == false)
                {
                    btnDarDeBajaAlumno.Visible = true;
                }
                if (btnModificarAlumno.Enabled == false)
                {
                    btnModificarAlumno.Enabled = true;
                }

                if (LA.Count != 0)
                {
                    dgvAlumnosActivos_Click(null, null);
                }
                else
                {
                    txtBoxEmail.Text = "";
                    txtBoxFechaIng.Text = "";
                    txtBoxFechaNac.Text = "";
                }
            }
        }

        private void rbAlumnosInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosInactivos.Checked == true)
            {
                LA = BLL_Alumno.Ver_Alumnos_Inactivos();
                dgvAlumnosActivos.Rows.Clear();
                MostrarDatosEnGrilla(dgvAlumnosActivos, LA);
                btnDarDeBajaAlumno.Visible = false;
                btnModificarAlumno.Enabled = false;
                btnDarDeAltaAlumno.Visible = true;

                if (LA.Count != 0)
                {
                    dgvAlumnosActivos_Click(null, null);
                }
                else
                {
                    txtBoxEmail.Text = "";
                    txtBoxFechaIng.Text = "";
                    txtBoxFechaNac.Text = "";
                }
            }
        }

        private void rbAlumnosTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosTodos.Checked == true)
            {
                if (rbAlumnosActivos.Checked == true)
                {
                    LA = BLL_Alumno.Ver_Alumnos_Activos();
                    dgvAlumnosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnosActivos, LA);
                }
                else if (rbAlumnosInactivos.Checked == true)
                {
                    LA = BLL_Alumno.Ver_Alumnos_Inactivos();
                    dgvAlumnosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnosActivos, LA);
                }

                lblBusqueda.Visible = false;
                txtBoxBusqueda.Visible = false;

                if (LA.Count != 0)
                {
                    dgvAlumnosActivos_Click(null, null);
                }
                else
                {
                    txtBoxEmail.Text = "";
                    txtBoxFechaIng.Text = "";
                    txtBoxFechaNac.Text = "";
                }
            }
        }

        private void rbAlumnosLegajo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosLegajo.Checked == true)
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

        private void rbAlumnosDNI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosDNI.Checked == true)
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

        private void rbAlumnosApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosApellido.Checked == true)
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

        private void rbAlumnosNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosNombre.Checked == true)
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

        private void rbAlumnosTurno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosTurno.Checked == true)
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

        private void dgvAlumnosActivos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnosActivos.Rows.Count > 0)
                {
                    Alumno A = ObtenerAlumno((string)dgvAlumnosActivos.SelectedRows[0].Cells[0].Value);

                    txtBoxEmail.Text = "";
                    txtBoxEmail.Text = A.Correo_Electronico;

                    txtBoxFechaNac.Text = "";
                    txtBoxFechaNac.Text = A.Fecha_Nacimiento.ToShortDateString();

                    txtBoxFechaIng.Text = "";
                    txtBoxFechaIng.Text = A.Fecha_Ingreso.ToShortDateString();
                }
            }
            catch (Exception ex) { }
        }

        private void btnDarDeBajaAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnosActivos.Rows.Count > 0)
                {
                    Alumno A = ObtenerAlumno((string)dgvAlumnosActivos.SelectedRows[0].Cells[0].Value);

                    if (MessageBox.Show("¿Está seguro de Dar de Baja a este Alumno?\n\nNota: No se dará de baja al Usuario\nPara dar de baja al Usuario asociado de este Alumno, hágalo desde el módulo *Ver Usuarios*", "Solicitud de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BLL_Alumno.Dar_De_Baja_Alumno(A);
                        MessageBox.Show("Se ha dado de baja el Alumno" + A.Legajo, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogManager.Escribir(ID, "Dio de baja al Alumno " + A.Legajo, 3);
                        dgvAlumnosActivos.Rows.Clear();
                        LA = BLL_Alumno.Ver_Alumnos_Activos();
                        MostrarDatosEnGrilla(dgvAlumnosActivos, LA);
                    }                     
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbAlumnosLegajo.Checked == true)
                {
                    dgvAlumnosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnosActivos, BLL_Alumno.Ver_Alumnos_Legajo(LA, txtBoxBusqueda.Text));
                    Actualizar_TextBox();
                }
                else if (rbAlumnosDNI.Checked == true)
                {
                    dgvAlumnosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnosActivos, BLL_Alumno.Ver_Alumnos_DNI(LA, int.Parse(txtBoxBusqueda.Text)));
                    Actualizar_TextBox();
                }
                else if (rbAlumnosApellido.Checked == true)
                {
                    dgvAlumnosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnosActivos, BLL_Alumno.Ver_Alumnos_Apellido(LA, txtBoxBusqueda.Text));
                    Actualizar_TextBox();
                }
                else if (rbAlumnosNombre.Checked == true)
                {
                    dgvAlumnosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnosActivos, BLL_Alumno.Ver_Alumnos_Nombre(LA, txtBoxBusqueda.Text));
                    Actualizar_TextBox();
                }
                else if (rbAlumnosTurno.Checked == true)
                {
                    dgvAlumnosActivos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnosActivos, BLL_Alumno.Ver_Alumnos_Turno(LA, txtBoxBusqueda.Text));
                    Actualizar_TextBox();
                }

            }
            catch (Exception) { }
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            if (FormModificarAlumno == null)
            {
                if (dgvAlumnosActivos.Rows.Count > 0)
                {
                    Alumno A = ObtenerAlumno((string)dgvAlumnosActivos.SelectedRows[0].Cells[0].Value);
                    FormModificarAlumno = new FormModificarAlumno(ID, A);
                    FormModificarAlumno.FormClosed += FormModificarAlumno_FormClosed;
                    FormModificarAlumno.ShowDialog();
                }
            }
        }

        private void FormModificarAlumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormModificarAlumno = null;
            dgvAlumnosActivos.Rows.Clear();
            LA = BLL_Alumno.Ver_Alumnos_Activos();
            MostrarDatosEnGrilla(dgvAlumnosActivos, LA);

            foreach (Control C in gpAlumnosActivos.Controls)
            {
                if (C is RadioButton)
                {
                    RadioButton RB = C as RadioButton;

                    RB.Checked = false;
                }
            }

            rbAlumnosTodos.Checked = true;
            rbAlumnosActivos.Checked = true;
        }

        public void Actualizar_TextBox()
        {
            if (dgvAlumnosActivos.Rows.Count != 0)
            {
                dgvAlumnosActivos_Click(null, null);
            }
            else
            {
                txtBoxEmail.Text = "";
                txtBoxFechaIng.Text = "";
                txtBoxFechaNac.Text = "";
            }
        }

        private void btnDarDeAltaAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnosActivos.Rows.Count > 0)
                {
                    Alumno A = ObtenerAlumno((string)dgvAlumnosActivos.SelectedRows[0].Cells[0].Value);
                    if (MessageBox.Show("¿Está seguro de Dar de Alta a este Alumno?\n\nNota: No se dará de Alta al Usuario\nPara dar de Alta al Usuario asociado de este Alumno, hágalo desde el módulo *Ver Usuarios*", "Solicitud de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BLL_Alumno.Dar_De_Alta_Alumno(A);
                        MessageBox.Show("Se ha dado de Alta nuevamente el Alumno" + A.Legajo, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogManager.Escribir(ID, "Dio de Alta nuevamente al Alumno " + A.Legajo, 3);
                        dgvAlumnosActivos.Rows.Clear();
                        LA = BLL_Alumno.Ver_Alumnos_Inactivos();
                        MostrarDatosEnGrilla(dgvAlumnosActivos, LA);
                    }                    
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnVerCursadas_Click(object sender, EventArgs e)
        {
            if (FormVerCursadasDeAlumno == null)
            {
                if (dgvAlumnosActivos.Rows.Count > 0)
                {
                    Alumno A = ObtenerAlumno((string)dgvAlumnosActivos.SelectedRows[0].Cells[0].Value);
                    FormVerCursadasDeAlumno = new FormVerCursadasDeAlumno(ID, A);
                    FormVerCursadasDeAlumno.FormClosed += FormVerCursadasDeAlumno_FormClosed;
                    FormVerCursadasDeAlumno.ShowDialog();
                }
            }
        }

        private void FormVerCursadasDeAlumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerCursadasDeAlumno = null;
        }

        private void lblBusqueda_Click(object sender, EventArgs e)
        {

        }
    }
}
