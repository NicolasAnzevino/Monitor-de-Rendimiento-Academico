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
    public partial class FormModificarDocente : Form
    {
        public FormModificarDocente(int pKey, Docente pDocente)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Docente = pDocente;
        }

        public int ID, IDUserDocente;
        public Docente Docente;
        public BLL_Alumno BLL_Alumno;
        public BLL_Docente BLL_Docente;
        public BLL_Usuario BLL_Usuario;

        private void FormModificarDocente_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Alumno = new BLL_Alumno();
            BLL_Docente = new BLL_Docente();
            BLL_Usuario = new BLL_Usuario();

            txtBoxDNI.Text = Docente.DNI.ToString();
            txtBoxApellido.Text = Docente.Apellido;
            txtBoxNombre.Text = Docente.Nombre;

            IDUserDocente = BLL_Docente.Obtener_ID_Usuario_Docente(Docente);

            txtBoxDNI.MaxLength = 8;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxDNI.Text != "" && txtBoxApellido.Text != "" && txtBoxNombre.Text != "")
                {
                    if (MessageBox.Show("¿Estas seguro que desea modificar al Docente?\n\nNOTA: Se modificarán también los Datos del Usuario y Alumno que estén afiliados a este Docente", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        ModificarDocente(int.Parse(txtBoxDNI.Text), txtBoxApellido.Text, txtBoxNombre.Text, IDUserDocente);
                        MessageBox.Show("Se ha modificado el Docente con Legajo " + Docente.Legajo + " con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogManager.Escribir(ID, "Modificó al Docente con Legajo" + Docente.Legajo, 3);
                        txtBoxDNI.Text = "";
                        txtBoxNombre.Text = "";
                        txtBoxApellido.Text = "";                        
                        this.Close();
                    }
                }
                else { throw new Exception("Debe rellenar todos los campos"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }       

        public void ModificarDocente(int pDNI, string pApellido, string pNombre, int pUserID)
        {
            try
            {
                Docente.DNI = pDNI;
                Docente.Apellido = pApellido;
                Docente.Nombre = pNombre;

                BLL_Docente.Modificar_Docente(Docente, pUserID);
                BLL_Usuario.Modificar_Usuario(Docente, pUserID);
                BLL_Alumno.Modificar_Alumno(Docente, pUserID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
