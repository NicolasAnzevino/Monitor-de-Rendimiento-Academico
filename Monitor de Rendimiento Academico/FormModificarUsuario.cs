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
    public partial class FormModificarUsuario : Form
    {
        public FormModificarUsuario(int pKey, Usuario pUsuario)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Usuario = pUsuario;
        }

        public int ID;
        public Usuario Usuario, UsuarioPrevio;
        public BLL_Usuario BLL_Usuario;
        public BLL_Rol BLL_Rol;
        public BLL_Alumno BLL_Alumno;
        public BLL_Docente BLL_Docente;
        List<Rol> Roles;

        private void FormModificarUsuario_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            UsuarioPrevio = new Usuario(Usuario.ID,Usuario.Nombre, Usuario.DNI, Usuario.Apellido, Usuario.NombreReal);

            BLL_Usuario = new BLL_Usuario();
            BLL_Rol = new BLL_Rol();
            BLL_Alumno = new BLL_Alumno();
            BLL_Docente = new BLL_Docente();

            Roles = BLL_Rol.Ver_Roles_Con_Permisos();

            if (Usuario.Rol.Codigo == 1 ||Usuario.Rol.Codigo == 2) //El Admin y el Dir de estudios no pueden cambiarse de Rol
            {
                listBoxRoles.Visible = false;
                listBoxPermisosDeRol.Visible = false;
                lblRol.Visible = false;
                lblPermisosDeRol.Visible = false;
            }
            else
            {
                listBoxRoles.DataSource = Roles;
            }            

            txtBoxDNI.Text = Usuario.DNI.ToString();
            txtBoxApellido.Text = Usuario.Apellido;
            txtBoxNombreReal.Text = Usuario.NombreReal;
        }

        private void listBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rol R = listBoxRoles.SelectedItem as Rol;

            Mostrar_Permisos(R.VerPermisos(), listBoxPermisosDeRol);            
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

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxDNI.Text != "" && txtBoxApellido.Text != "" && txtBoxNombreReal.Text != "")
                {
                    int DNI = int.Parse(txtBoxDNI.Text);

                    if (BLL_Usuario.Verificar_DNI(DNI)==false || int.Parse(txtBoxDNI.Text) == Usuario.DNI)
                    {
                        if (MessageBox.Show("¿Desea modificar al Usuario?\nTambién se modificará al Alumno y Docente afiliado a este Usuario, en el caso de que así sea", "Solicitud de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                        {
                            Rol R = listBoxRoles.SelectedItem as Rol;

                            if (SessionManager.getInstance(ID).User.Rol.Codigo == 1 || SessionManager.getInstance(ID).User.Rol.Codigo == 2)
                            {
                                Modificar_Usuario(DNI, txtBoxApellido.Text, txtBoxNombreReal.Text, SessionManager.getInstance(ID).User.Rol);
                            }
                            else
                            {
                                Modificar_Usuario(DNI, txtBoxApellido.Text, txtBoxNombreReal.Text, R);
                            }

                            LogManager.Escribir(ID, "Modificó al Usuario " + Usuario.Nombre, 2);
                            SerializerManager.GuardarModificacionUsuario(UsuarioPrevio, txtBoxNombreReal.Text, txtBoxApellido.Text, DNI, R, SessionManager.getInstance(ID).User);
                            MessageBox.Show("Se modificó al Usuario " + Usuario.Nombre + " con éxito", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }                        
                    }
                    else { throw new Exception("No pueden existir dos personas con el mismo DNI"); }
                }
                else { throw new Exception("Debe rellenar todos los campos"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Modificar_Usuario(int pDNI, string pApellido, string pNombreReal, Rol pRol)
        {
            try
            {
                Usuario.DNI = pDNI;
                Usuario.Apellido = pApellido;
                Usuario.NombreReal = pNombreReal;
                Usuario.Rol = pRol;
                BLL_Usuario.Modificar_Usuario(Usuario);
                BLL_Alumno.Modificar_Alumno(Usuario);
                BLL_Docente.Modificar_Docente(Usuario);
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
    }
}
