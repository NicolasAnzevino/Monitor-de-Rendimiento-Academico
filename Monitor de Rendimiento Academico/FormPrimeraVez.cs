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
    public partial class FormPrimeraVez : Form
    {
        public FormPrimeraVez()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void FormPrimeraVez_Load(object sender, EventArgs e)
        {
            BLLUsuario = new BLL_Usuario();
            BLLRol = new BLL_Rol();
            BLLDocente = new BLL_Docente();
            this.WindowState = FormWindowState.Normal;

            txtBoxDNI.MaxLength = 8;
        }

        BLL_Usuario BLLUsuario;
        BLL_Rol BLLRol;
        BLL_Docente BLLDocente;

        private void buttonRegistrarse_Click(object sender, EventArgs e)
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
                if (txtBoxUsername.Text != "" && txtBoxPassword.Text != "" && txtBoxNombreReal.Text != "" && txtBoxApellido.Text != "" && txtBoxDNI.Text != "" && txtBoxLegajo.Text != "")
                {
                    bool B = BLLUsuario.Verificar_Nombre(txtBoxUsername.Text); //True -> Existe || False -> No existe    

                    if (BLLUsuario.Verificar_Nombre(txtBoxUsername.Text) == false)
                    {
                        if (BLLUsuario.Verificar_DNI(int.Parse(txtBoxDNI.Text)) == false)
                        {
                            BLLUsuario.Registrar_Usuario(txtBoxUsername.Text, txtBoxPassword.Text, BLLRol.Buscar_Rol(2), txtBoxNombreReal.Text, txtBoxApellido.Text, int.Parse(txtBoxDNI.Text));

                            int MaxID = BLLUsuario.Obtener_Max_ID();

                            BLLDocente.Agregar_Docente(txtBoxLegajo.Text, int.Parse(txtBoxDNI.Text), txtBoxNombreReal.Text, txtBoxApellido.Text, MaxID);

                            LogManager.Escribir(BLLUsuario.Buscar_ID_Usuario(txtBoxUsername.Text), "Se ha registrado el Director de Estudios", 2);

                            MessageBox.Show("Se ha creado el Usuario correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                        else { throw new Exception("Ya existe un Usuario con ese DNI"); }

                        
                    }
                    else  { throw new Exception("Ya existe un Usuario con ese Nombre"); }
                }
                else { throw new Exception("Debe rellenar todos los campos"); }
                
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

