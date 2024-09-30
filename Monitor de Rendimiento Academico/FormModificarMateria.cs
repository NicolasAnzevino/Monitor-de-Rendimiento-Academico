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
    public partial class FormModificarMateria : Form
    {
        public FormModificarMateria(int pKey, Materia pMateria)
        {
            InitializeComponent();
            this.CenterToScreen();
            ID = pKey;
            Materia = pMateria;
        }

        public int ID;
        public Materia Materia;
        public BLL_Materia BLL_Materia;

        private void FormModificarMateria_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Materia = new BLL_Materia();

            txtBoxNombre.Text = Materia.Nombre;
            txtBoxCantHoras.Text = Materia.Cant_Horas_Semanales.ToString();

            txtBoxCantHoras.MaxLength = 4;
        }

        private void btnModificarMateria_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNombre.Text != "" && txtBoxCantHoras.Text != "")
                {
                    if (BLL_Materia.Comprobar_Unicidad_Nombre_Materia(txtBoxNombre.Text)==0 || txtBoxNombre.Text == Materia.Nombre)
                    {
                        ModificarMateria(txtBoxNombre.Text, int.Parse(txtBoxCantHoras.Text));
                        MessageBox.Show("La Materia fue modificada con Éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogManager.Escribir(ID, "Modificó la materia con ID:" + Materia.Codigo.ToString(), 3);
                        this.Close();
                    }
                    else { throw new Exception("Ya existe una Materia con ese Nombre"); }
                }
                else { throw new Exception("Debe rellenar todos los campos"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void ModificarMateria(string pNombre, int pCantHoras)
        {
            Materia.Nombre = pNombre;
            Materia.Cant_Horas_Semanales = pCantHoras;

            BLL_Materia.Modificar_Materia(Materia);
        }

        private void txtBoxCantHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
