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
    public partial class FormRealizarQueja : Form
    {
        public FormRealizarQueja(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;

        BLL_Queja BLL_Queja;

        private void FormRealizarQueja_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            txtBoxAsunto.MaxLength = 50;
            txtBoxDescripcion.MaxLength = 150;

            BLL_Queja = new BLL_Queja();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxAsunto.Text == "" || txtBoxDescripcion.Text == "") { throw new Exception("Debe rellenar todos los campos"); }

                if (MessageBox.Show("¿Está seguro de enviar la Queja?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Enviar(txtBoxAsunto.Text, txtBoxDescripcion.Text, ID);
                    MessageBox.Show("La Queja se ha enviado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxAsunto.Clear();
                    txtBoxDescripcion.Clear();
                }              
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Enviar(string pAsunto, string pDescripcion, int pID)
        {
            try
            {
                BLL_Queja.Crear_Queja(pAsunto, pDescripcion, pID);
                LogManager.Escribir(ID, "Ha creado una Queja", 2);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
