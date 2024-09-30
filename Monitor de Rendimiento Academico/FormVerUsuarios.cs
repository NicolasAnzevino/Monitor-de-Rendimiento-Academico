using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Servicios;
using BLL;

namespace Monitor_de_Rendimiento_Academico
{
    public partial class FormVerUsuarios : Form
    {
        public FormVerUsuarios(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();
            ID = pKey;
        }

        public int ID;
        BLL_Usuario BLL_Usuario;
        BLL_Alumno BLL_Alumno;
        BLL_Docente BLL_Docente;
        List<Usuario> LU;
        FormModificarUsuario FormModificarUsuario;
        FormCambiarContraseña FormCambiarContraseña;

        private void FormVerUsuarioscs_Load(object sender, EventArgs e)
        {
            this.Name = "FormVerUsuarios";
            
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Usuario = new BLL_Usuario();
            BLL_Alumno = new BLL_Alumno();
            BLL_Docente = new BLL_Docente();

            LU = BLL_Usuario.Ver_Usuarios_Estado(false); //False -> No dados de Baja ||True -> Dados de Baja
            MostrarEnGrilla(dgvUsuarios, LU);

            lblBuscar.Visible = false;
            txtBoxBuscar.Visible = false;

            btnDarDeAltaUsuario.Visible = false;

            if (LU.Count>0)
            {
                dgvUsuarios_Click(null, null);
            }
        }

        public void MostrarEnGrilla(DataGridView pDGV, List<Usuario> L)
        {
            try
            {
                if (L.Count != 0)
                {
                    foreach (Usuario U in L)
                    {
                        pDGV.Rows.Add(U.Nombre, U.Rol.Nombre, U.DNI.ToString(), U.Apellido, U.NombreReal);
                    }
                }
                else { dgvUsuarios.Rows.Clear(); dgvUsuarios.DataSource = null; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDarDeBajaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.Rows.Count>0)
                {
                    Usuario U = ObtenerUsuario((string)dgvUsuarios.SelectedRows[0].Cells[0].Value);
                    if (MessageBox.Show("¿Está seguro de Dar de Baja a este Usuario?\n\nNota: En el caso de que el Usuario tenga asociado a un Alumno o Docente, estos se darán de baja igual", "Solicitud de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                    {
                        BLL_Usuario.Dar_de_Baja_Usuario(U);
                        BLL_Alumno.Dar_De_Baja_Alumno(U);
                        BLL_Docente.Dar_De_Baja_Docente(U);
                        LogManager.Escribir(ID, "Dio de Baja al Usuario " + U.ID.ToString(), 1);

                        LU = BLL_Usuario.Ver_Usuarios_Estado(false);
                        dgvUsuarios.Rows.Clear();
                        MostrarEnGrilla(dgvUsuarios, LU);
                        MessageBox.Show("Se ha dado de Baja al Usuario correctamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                    
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnDarDeAltaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.Rows.Count > 0)
                {
                    Usuario U = ObtenerUsuario((string)dgvUsuarios.SelectedRows[0].Cells[0].Value);
                    if (MessageBox.Show("¿Está seguro de Dar de Alta a este Usuario?\n\nNota: En el caso de que el Usuario tenga asociado a un Alumno o Docente, estos se darán de Alta igual", "Solicitud de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BLL_Usuario.Dar_de_Alta_Usuario(U);
                        BLL_Alumno.Dar_De_Alta_Alumno(U);
                        BLL_Docente.Dar_De_Baja_Docente(U);
                        LogManager.Escribir(ID, "Dio de Alta al Usuario " + U.ID.ToString(), 1);

                        LU = BLL_Usuario.Ver_Usuarios_Estado(true);
                        dgvUsuarios.Rows.Clear();
                        MostrarEnGrilla(dgvUsuarios, LU);
                        MessageBox.Show("Se ha dado de Alta al Usuario correctamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormModificarUsuario == null)
                {
                    if (dgvUsuarios.Rows.Count>0)
                    {
                        Usuario U = ObtenerUsuario((string)dgvUsuarios.SelectedRows[0].Cells[0].Value);
                        FormModificarUsuario = new FormModificarUsuario(ID, U);
                        FormModificarUsuario.FormClosed += FormModificarUsuario_FormClosed;
                        FormModificarUsuario.ShowDialog();
                    }                    
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormModificarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormModificarUsuario = null;
            dgvUsuarios.Rows.Clear();
            LU = BLL_Usuario.Ver_Usuarios_Estado(false);
            MostrarEnGrilla(dgvUsuarios, LU);
        }

        private void rbUsuariosTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblBuscar.Visible = false;
            txtBoxBuscar.Visible = false;
            txtBoxBuscar.Text = "";

            if (rbUsuariosActivos.Checked== true)
            {
                btnDarDeAltaUsuario.Visible = false;
                btnDarDeBajaUsuario.Visible = true;

                LU = BLL_Usuario.Ver_Usuarios_Estado(false);
                dgvUsuarios.Rows.Clear();
                MostrarEnGrilla(dgvUsuarios, LU);                
            }
            else if (rbUsuariosInactivos.Checked == true)
            {
                btnDarDeAltaUsuario.Visible = true;
                btnDarDeBajaUsuario.Visible = false;

                LU = BLL_Usuario.Ver_Usuarios_Estado(true);
                dgvUsuarios.Rows.Clear();
                MostrarEnGrilla(dgvUsuarios, LU);                
            }

        }

        private void rbUsuariosNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuariosNombre.Checked == true)
            {
                if (lblBuscar.Visible == false)
                {
                    lblBuscar.Visible = true;
                }

                if (txtBoxBuscar.Visible == false)
                {
                    txtBoxBuscar.Visible = true;
                }
            }
        }

        private void rbUsuariosRol_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuariosRol.Checked == true)
            {
                if (lblBuscar.Visible == false)
                {
                    lblBuscar.Visible = true;
                }

                if (txtBoxBuscar.Visible == false)
                {
                    txtBoxBuscar.Visible = true;
                }
            }
        }

        private void rbUsuariosDNI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuariosDNI.Checked == true)
            {
                if (lblBuscar.Visible == false)
                {
                    lblBuscar.Visible = true;
                }

                if (txtBoxBuscar.Visible == false)
                {
                    txtBoxBuscar.Visible = true;
                }
            }
        }

        private void rbUsuariosApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuariosApellido.Checked == true)
            {
                if (lblBuscar.Visible == false)
                {
                    lblBuscar.Visible = true;
                }

                if (txtBoxBuscar.Visible == false)
                {
                    txtBoxBuscar.Visible = true;
                }
            }
        }

        private void rbUsuariosNombreReal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuariosNombreReal.Checked == true)
            {
                if (lblBuscar.Visible == false)
                {
                    lblBuscar.Visible = true;
                }

                if (txtBoxBuscar.Visible == false)
                {
                    txtBoxBuscar.Visible = true;
                }
            }
        }

        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbUsuariosNombre.Checked == true)
                {
                    dgvUsuarios.Rows.Clear();
                    MostrarEnGrilla(dgvUsuarios, BLL_Usuario.Ver_Usuarios_Nombre(LU, txtBoxBuscar.Text));
                }
                else if (rbUsuariosRol.Checked == true)
                {
                    dgvUsuarios.Rows.Clear();
                    MostrarEnGrilla(dgvUsuarios, BLL_Usuario.Ver_Usuarios_Rol(LU, txtBoxBuscar.Text));
                }
                else if (rbUsuariosDNI.Checked == true)
                {
                    dgvUsuarios.Rows.Clear();
                    MostrarEnGrilla(dgvUsuarios, BLL_Usuario.Ver_Usuarios_DNI(LU, int.Parse(txtBoxBuscar.Text)));
                }
                else if (rbUsuariosApellido.Checked == true)
                {
                    dgvUsuarios.Rows.Clear();
                    MostrarEnGrilla(dgvUsuarios, BLL_Usuario.Ver_Usuarios_Apellido(LU, txtBoxBuscar.Text));
                }
                else if (rbUsuariosNombreReal.Checked == true)
                {
                    dgvUsuarios.Rows.Clear();
                    MostrarEnGrilla(dgvUsuarios, BLL_Usuario.Ver_Usuarios_Nombre_Real(LU, txtBoxBuscar.Text));
                }
            }
            catch (Exception) { }
        }

        public Usuario ObtenerUsuario(string pNombre)
        {
            Usuario U = LU.Find(X => X.Nombre == pNombre);
            return U;
        }

        private void btnModificarContraseña_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count>0)
            {
                if (FormCambiarContraseña == null)
                {
                    Usuario U = ObtenerUsuario((string)dgvUsuarios.SelectedRows[0].Cells[0].Value);
                    FormCambiarContraseña = new FormCambiarContraseña(ID, U);
                    FormCambiarContraseña.FormClosed += FormCambiarContraseña_FormClosed;
                    FormCambiarContraseña.ShowDialog();
                }
            }
        }

        private void FormCambiarContraseña_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCambiarContraseña = null;
        }

        private void rbUsuariosActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuariosActivos.Checked==true)
            {
                foreach (RadioButton RB in gpVisualizacion.Controls)
                {
                    RB.Checked = false;
                }

                btnDarDeBajaUsuario.Visible = true;
                btnDarDeAltaUsuario.Visible = false;

                rbUsuariosTodos.Checked = true;

                LU = BLL_Usuario.Ver_Usuarios_Estado(false);
                dgvUsuarios.Rows.Clear();
                MostrarEnGrilla(dgvUsuarios, LU);
            }            
        }

        private void rbUsuariosInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuariosInactivos.Checked == true)
            {
                foreach (RadioButton RB in gpVisualizacion.Controls)
                {
                    RB.Checked = false;
                }

                btnDarDeBajaUsuario.Visible = false;
                btnDarDeAltaUsuario.Visible = true;

                rbUsuariosTodos.Checked = true;

                LU = BLL_Usuario.Ver_Usuarios_Estado(true);
                dgvUsuarios.Rows.Clear();
                MostrarEnGrilla(dgvUsuarios, LU);
            }
        }      
        private void dgvUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.Rows.Count > 0)
                {
                    Usuario U = ObtenerUsuario((string)dgvUsuarios.SelectedRows[0].Cells[0].Value);

                    if (U.Rol.Codigo == 2 || U.Rol.Codigo == 1)
                    {
                        btnDarDeBajaUsuario.Enabled = false;
                    }
                    else
                    {
                        if (btnDarDeBajaUsuario.Enabled == false)
                        {
                            btnDarDeBajaUsuario.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception) { }
        }
    }
}
