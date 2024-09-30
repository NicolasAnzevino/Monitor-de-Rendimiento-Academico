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
using System.Globalization;

namespace Monitor_de_Rendimiento_Academico
{
    public partial class FormAgregarDocente : Form
    {
        public FormAgregarDocente(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID; 
        
        List<Usuario> LU;

        BLL_Usuario BLL_Usuario;
        BLL_Docente BLL_Docente;

        private void FormAgregarDocente_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Usuario = new BLL_Usuario();
            BLL_Docente = new BLL_Docente();

            txtBoxDNI.MaxLength = 8;

            LU = BLL_Usuario.Ver_Usuarios_Disponible_Docente();
            MostrarEnGrilla(dgvUsuariosHabilitados, LU);

            if (dgvUsuariosHabilitados.Rows.Count > 0)
            {
                dgvUsuariosHabilitados_CellClick(null, null);
            }

            lblBuscar.Visible = false;
            txtBoxBuscar.Visible = false;
        }

        public void MostrarEnGrilla(DataGridView pDGV, List<Usuario> L)
        {
            try
            {
                if (L.Count != 0)
                {
                    foreach (Usuario U in L)
                    {
                        pDGV.Rows.Add(U.ID, U.Nombre, U.Apellido + " " + U.NombreReal, U.Rol.Nombre);
                    }
                }
                else { dgvUsuariosHabilitados.Rows.Clear(); dgvUsuariosHabilitados.DataSource = null; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public Usuario ObtenerUsuario(int pID)
        {
            Usuario U = LU.Find(X => X.ID == pID);
            return U;
        }

        private void dgvUsuariosHabilitados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuariosHabilitados.Rows.Count > 0)
            {
                Usuario U = ObtenerUsuario((int)dgvUsuariosHabilitados.SelectedRows[0].Cells[0].Value);
                txtBoxDNI.Text = U.DNI.ToString();
                txtBoxNombre.Text = U.NombreReal.ToString();
                txtBoxApellido.Text = U.Apellido.ToString();
            }
        }

        private void btnCrearDocente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuariosHabilitados.Rows.Count > 0)
                {
                    Usuario U = ObtenerUsuario((int)dgvUsuariosHabilitados.SelectedRows[0].Cells[0].Value);

                    if (txtBoxLegajo.Text != "")
                    {
                        if (BLL_Docente.Verificar_Unicidad_Legajo(txtBoxLegajo.Text) == false) //TRUE EXISTE - FALSE NO
                        {
                            Agregar_Docente(txtBoxLegajo.Text, int.Parse(txtBoxDNI.Text), txtBoxNombre.Text, txtBoxApellido.Text, U);
                            dgvUsuariosHabilitados_CellClick(null, null);
                            txtBoxLegajo.Text = "";
                        }
                        else { throw new Exception("Ese Legajo ya está en uso"); }
                    }
                    else { throw new Exception("Debe rellenar todos los campos"); }
                }
                else { throw new Exception("No hay Usuarios a los que asociar al Docente"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Agregar_Docente(string pLegajo, int pDNI, string pNombre, string pApellido, Usuario pUsuario)
        {
            try
            {
                BLL_Docente.Agregar_Docente(pLegajo, pDNI, pNombre, pApellido, pUsuario.ID);
                MessageBox.Show("Se ha creado el Docente correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogManager.Escribir(ID, "Ha creado el Docente con Legajo " + pLegajo, 3);
                LU = BLL_Usuario.Ver_Usuarios_Disponible_Docente();
                dgvUsuariosHabilitados.Rows.Clear();
                MostrarEnGrilla(dgvUsuariosHabilitados, LU);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void rbUsuariosTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblBuscar.Visible = false;
            txtBoxBuscar.Visible = false;
            txtBoxBuscar.Text = "";

            dgvUsuariosHabilitados.Rows.Clear();
            LU = BLL_Usuario.Ver_Usuarios_Disponible_Docente();
            MostrarEnGrilla(dgvUsuariosHabilitados, LU);
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
                    dgvUsuariosHabilitados.Rows.Clear();
                    MostrarEnGrilla(dgvUsuariosHabilitados, BLL_Usuario.Ver_Usuarios_Nombre(LU, txtBoxBuscar.Text));
                }
                else if (rbUsuariosRol.Checked == true)
                {
                    dgvUsuariosHabilitados.Rows.Clear();
                    MostrarEnGrilla(dgvUsuariosHabilitados, BLL_Usuario.Ver_Usuarios_Rol(LU, txtBoxBuscar.Text));
                }
                else if (rbUsuariosDNI.Checked == true)
                {
                    dgvUsuariosHabilitados.Rows.Clear();
                    MostrarEnGrilla(dgvUsuariosHabilitados, BLL_Usuario.Ver_Usuarios_DNI(LU, int.Parse(txtBoxBuscar.Text)));
                }
                else if (rbUsuariosApellido.Checked == true)
                {
                    dgvUsuariosHabilitados.Rows.Clear();
                    MostrarEnGrilla(dgvUsuariosHabilitados, BLL_Usuario.Ver_Usuarios_Apellido(LU, txtBoxBuscar.Text));
                }
                else if (rbUsuariosNombreReal.Checked == true)
                {
                    dgvUsuariosHabilitados.Rows.Clear();
                    MostrarEnGrilla(dgvUsuariosHabilitados, BLL_Usuario.Ver_Usuarios_Nombre_Real(LU, txtBoxBuscar.Text));
                }
            }
            catch (Exception) { }
        }
    }
}
