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
    public partial class FormModificarTema : Form
    {
        public FormModificarTema(int pKey, Tema pTema)
        {
            InitializeComponent();
            this.CenterToScreen();
            ID = pKey;
            Tema = pTema;
        }

        public int ID;
        public Tema Tema;
        BLL_Materia BLL_Materia;

        private void FormModificarTema_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Materia = new BLL_Materia();

            txtBoxDescripcion.MaxLength = 120;

            txtBoxNombre.Text = Tema.Nombre;
            txtBoxDescripcion.Text = Tema.Descripcion;
        }

        private void lblModificarTema_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNombre.Text != "" && txtBoxDescripcion.Text != "")
                {
                    if (BLL_Materia.Comprobar_Unicidad_Nombre_Tema(txtBoxNombre.Text) == 0 || txtBoxNombre.Text == Tema.Nombre)
                    {
                        Modificar_Tema(txtBoxNombre.Text, txtBoxDescripcion.Text);
                        MessageBox.Show("El Tema fue modificado con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogManager.Escribir(ID, "Creó modificó Tema con ID:" + Tema.Codigo, 3);
                        this.Close();
                    }
                    else { throw new Exception("Ya existe un Tema con ese Nombre"); }
                }
                else { throw new Exception("Debe rellenar todos los Campos"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Modificar_Tema(string pNombre, string pDesc)
        {
            try
            {
                Tema.Nombre = pNombre;
                Tema.Descripcion = pDesc;
                BLL_Materia.Modificar_Tema(Tema);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
    

