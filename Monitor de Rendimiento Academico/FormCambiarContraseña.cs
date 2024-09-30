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
    public partial class FormCambiarContraseña : Form
    {
        public FormCambiarContraseña(int pKey, Usuario pUsuario)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Usuario = pUsuario;
        }

        public int ID;
        public Usuario Usuario;
        public BLL_Usuario BLL_Usuario;

        private void FormCambiarContraseña_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Usuario = new BLL_Usuario();
        }

        private void txtBoxPassword1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                VerificarIgualdadContraseñas(txtBoxPassword1.Text, txtBoxPassword2.Text);
            }
            catch (Exception) {}
        }

        private void txtBoxPassword2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                VerificarIgualdadContraseñas(txtBoxPassword1.Text, txtBoxPassword2.Text);
            }
            catch (Exception) { }
        }

        public void VerificarIgualdadContraseñas(string pPass1, string pPass2)
        {
            if (pPass1 == "" || pPass2 == "")
            {
                btnCambiarContraseña.Enabled = false;
                lblContraseñasIncorrectas.Visible = true;
            }
            else
            {
                if (pPass1 == pPass2)
                {
                    btnCambiarContraseña.Enabled = true;
                    lblContraseñasIncorrectas.Visible = false;
                }
                else
                {
                    btnCambiarContraseña.Enabled = false;
                    lblContraseñasIncorrectas.Visible = true;
                }
            }            
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxPassword1.Text == txtBoxPassword2.Text)
                {
                    if (MessageBox.Show("¿Está seguro de cambiar la contraseña?", "Solicitud de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                    {
                        Cambiar_Contraseña(txtBoxPassword1.Text);
                        LogManager.Escribir(ID, "Modificó la Contraseña del Usuario " + Usuario.ID + " - " + Usuario.Nombre, 1);
                        MessageBox.Show("La contraseña fue modificada correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }                    
                }
                else { throw new Exception("Las contraseñas no son iguales"); }                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Cambiar_Contraseña(string pPassword)
        {
            try
            {
                BLL_Usuario.Cambiar_Contraseña(pPassword, Usuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
