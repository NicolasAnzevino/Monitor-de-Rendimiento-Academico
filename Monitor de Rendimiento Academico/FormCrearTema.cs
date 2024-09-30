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
    public partial class FormCrearTema : Form
    {
        public FormCrearTema(int pKey, Materia pMateria)
        {
            InitializeComponent();
            this.CenterToScreen();
            ID = pKey;
            Materia = pMateria;
        }

        public int ID;
        public Materia Materia;
        BLL_Materia BLL_Materia;

        private void FormCrearTema_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Materia = new BLL_Materia();

            txtBoxDescripcion.MaxLength = 120;
        }

        private void btnCrearTema_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNombre.Text != "" && txtBoxDescripcion.Text != "")
                {
                    if (BLL_Materia.Comprobar_Unicidad_Nombre_Tema(txtBoxNombre.Text) == 0)
                    {
                        Tema T = Agregar_Tema(txtBoxNombre.Text, txtBoxDescripcion.Text);
                        MessageBox.Show("El Tema '"+ txtBoxNombre.Text + "' fue creado con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogManager.Escribir(ID, "Creó el Tema" + txtBoxNombre.Text, 3);

                        if (MessageBox.Show("¿Desea agregar este tema a la Materia seleccionada anteriormente?\n\nAunque rechace esto, podrá agregar el tema a la materia más adelante", "Solicitud de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            BLL_Materia.Agregar_Tema_A_Materia(Materia, T);
                            MessageBox.Show("El Tema fue agregado a la Materia con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        txtBoxNombre.Text = "";
                        txtBoxDescripcion.Text = "";
                    }
                    else { throw new Exception("Ya existe un Tema con ese Nombre"); }
                }
                else { throw new Exception("Debe rellenar todos los Campos"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public Tema Agregar_Tema(string pNombre, string pDescripcion)
        {
            try
            {
                Tema T = BLL_Materia.Agregar_Tema(pNombre, pDescripcion);
                return T;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
