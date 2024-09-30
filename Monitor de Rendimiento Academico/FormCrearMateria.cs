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
    public partial class FormCrearMateria : Form
    {
        public FormCrearMateria(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;
        BLL_Materia BLL_Materia;

        private void FormCrearMateria_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Materia = new BLL_Materia();

            txtBoxCantHoras.MaxLength = 4;
        }

        private void btnCrearMateria_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNombre.Text != "" && txtBoxCantHoras.Text != "")
                {
                    Crear_Materia(txtBoxNombre.Text, int.Parse(txtBoxCantHoras.Text));
                    MessageBox.Show("La Materia " + txtBoxNombre.Text + " fue creada correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogManager.Escribir(ID, "Creó la Materia " + txtBoxNombre.Text, 3);
                    txtBoxNombre.Text = "";
                    txtBoxCantHoras.Text = "";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Crear_Materia(string pNombre, int pCantHoras)
        {
            try
            {
                BLL_Materia.Crear_Materia(pNombre, pCantHoras);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
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
