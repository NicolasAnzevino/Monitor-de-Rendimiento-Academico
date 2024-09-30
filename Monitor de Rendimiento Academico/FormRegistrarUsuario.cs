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
    public partial class FormRegistrarUsuario : Form
    {
        public FormRegistrarUsuario(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;

        BLL_Usuario BLL_Usuario;
        BLL_Rol BLL_Rol;
        List<Rol> Roles;

        private void FormRegistrarUsuario_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            BLL_Usuario = new BLL_Usuario();
            BLL_Rol = new BLL_Rol();

            Roles = BLL_Rol.Ver_Roles_Con_Permisos();

            listBoxRoles.DataSource = Roles;

            txtBoxDNI.MaxLength = 8;
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Registrarse();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Registrarse()
        {
            try
            {
                if (txtBoxUsername.Text == "" || txtBoxPassword.Text == "" || txtBoxNombreReal.Text == "" || txtBoxApellido.Text == "" || txtBoxDNI.Text == "")
                {
                    throw new Exception("Debe rellenar todos los campos");
                }                              

                if (BLL_Usuario.Verificar_Nombre(txtBoxUsername.Text)==false)
                {
                    if (BLL_Usuario.Verificar_DNI(int.Parse(txtBoxDNI.Text)) == false)
                    {
                        BLL_Usuario.Registrar_Usuario(txtBoxUsername.Text, txtBoxPassword.Text, listBoxRoles.SelectedItem as Rol, txtBoxNombreReal.Text, txtBoxApellido.Text, int.Parse(txtBoxDNI.Text));

                        LogManager.Escribir(ID, "Ha creado un Usuario", 2);

                        MessageBox.Show("Se ha creado el Usuario correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBoxUsername.Text = "";
                        txtBoxPassword.Text = "";
                        txtBoxNombreReal.Text = "";
                        txtBoxApellido.Text = "";
                        txtBoxDNI.Text = "";
                    }
                    else
                    {
                        throw new Exception("Ya existe un Usuario con ese DNI");
                    }
                }
                else
                {
                    throw new Exception("Ya existe un Usuario con ese Nombre de Usuario");
                }                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void txtBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void listBoxPermisosDeRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Mostrar_Permisos(List<Permiso> pLP, ListBox pListBox)
        {
            try
            {
                pListBox.Items.Clear();

                foreach (Permiso P in pLP)
                {
                    pListBox.Items.Add(P.Codigo);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rol R = listBoxRoles.SelectedItem as Rol;

            Mostrar_Permisos(R.VerPermisos(), listBoxPermisosDeRol);
        }
    }
}
