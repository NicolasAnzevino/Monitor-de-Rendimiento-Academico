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
using BLL;

namespace Monitor_de_Rendimiento_Academico
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.CenterToScreen();  
        }

        BLL_Usuario BLL_Usuario;
        static bool ExistenInconsistencias;
        FormPrimeraVez formPrimeraVez;

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (DatabaseCreatorManager.VerificarExistenciaBD() == false)
                {
                    DatabaseCreatorManager.CrearBD();
                }

                BLL_Usuario = new BLL_Usuario();
                ExistenInconsistencias = SecurityManager.Verificar_Digitos_Verificadores();

                panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
                buttonLogin.BackColor = Color.FromArgb(100, 255, 255, 255);
                this.MaximizeBox = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;

                if (ExistenInconsistencias == true)
                {
                    throw new Exception("Existen inconsistencias, no se permite el acceso al sistema");
                }

                if (BLL_Usuario.Comprobar_Primera_Vez()==true) //TRUE -> NO HAY DIRECTOR DE ESTUDIOS || FALSE -> SÍ HAY
                {
                    this.Hide();
                    this.ShowInTaskbar = false;
                    formPrimeraVez = new FormPrimeraVez();
                    formPrimeraVez.Show();
                    formPrimeraVez.FormClosing += FormPrimeraVez_FormClosing;
                }

                this.ShowInTaskbar = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormPrimeraVez_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;

                txtBoxUsername.Text = "";
                txtBoxPassword.Text = "";
                txtBoxUsername.Focus();                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonLogin_Click(object sender, EventArgs e)  
        {
            try
            {
                int pKey = BLL_Usuario.Login(txtBoxUsername.Text, txtBoxPassword.Text, ExistenInconsistencias);
                FormMenuPrincipal MainMenu = new FormMenuPrincipal(pKey);
                this.Hide();
                MainMenu.Show();
                MainMenu.FormClosing += MainMenu_FormClosing;
                MainMenu.FormClosed += MainMenu_FormClosed;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                txtBoxUsername.Text = "";
                txtBoxPassword.Text = "";
                txtBoxUsername.Focus();
                this.Show();

                Dictionary<int, int> IntentosEnBll = BLL_Usuario.ObtenerIntententosIncorrectos();

                Dictionary<int, int> IntentosActualizado = BLL_Usuario.Obtener_Cant_Intentos();

                IntentosEnBll.Clear();

                foreach (KeyValuePair<int, int> Valor in IntentosActualizado)
                {
                    IntentosEnBll.Add(Valor.Key, Valor.Value);
                }

                txtBoxUsername.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(null, null);
            }
        }

        private void txtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(null, null);
            }
        }
    }
}
