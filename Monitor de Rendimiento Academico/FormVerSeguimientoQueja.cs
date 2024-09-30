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
    public partial class FormVerSeguimientoQueja : Form
    {
        public FormVerSeguimientoQueja(int pKey, Queja pQueja, FormVerQuejasUsuario pFormVerQuejasUsuario)
        {
            InitializeComponent();
            this.CenterToScreen();
            ID = pKey;
            Queja = pQueja;
            FormAnterior = pFormVerQuejasUsuario;
        }

        public int ID;
        public Queja Queja;
        public BLL_Queja BLL_Queja;
        public FormVerQuejasUsuario FormAnterior;

        private void FormVerSeguimientoQueja_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Queja = new BLL_Queja();

            CargarDatos();
        }

        public void CargarDatos()
        {
            try
            {
                int IDIdioma = SessionManager.getInstance(ID).Idioma;

                txtBoxDescripcion.Text = Queja.Descripcion;

                if (Queja.Estados.Count != 0)
                {
                    if (IDIdioma == 1)
                    {
                        foreach (Seguimiento_Queja SQ in Queja.Estados)
                        {
                            txtBoxDescripcion.Text += "\r\n\r\n" + "[ACTUALIZACIÓN] - " + SQ.Fecha.ToShortDateString() + "\r\n" + SQ.Estado;
                        }
                    }

                    else if (IDIdioma == 2)
                    {
                        foreach (Seguimiento_Queja SQ in Queja.Estados)
                        {
                            txtBoxDescripcion.Text += "\r\n\r\n" + "[UPDATE] - " + SQ.Fecha.ToShortDateString() + "\r\n" + SQ.Estado;
                        }
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void FormVerSeguimientoQueja_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                txtBoxDescripcion.Text = "";
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
