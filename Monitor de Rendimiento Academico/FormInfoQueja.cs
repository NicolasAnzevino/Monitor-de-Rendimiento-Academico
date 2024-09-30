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
    public partial class FormInfoQueja : Form
    {
        public FormInfoQueja(int pKey, Queja pQueja, FormAtenderQueja pFormAtenderQueja)
        {
            InitializeComponent();
            this.CenterToScreen();
            ID = pKey;
            Queja = pQueja;
            FormAnterior = pFormAtenderQueja;
        }

        public bool Activo;
        public int ID;
        public Queja Queja;
        public BLL_Queja BLL_Queja;
        public FormAtenderQueja FormAnterior;

        private void FormInfoQueja_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Queja = new BLL_Queja();

            CargarDatos();

            lblUsername.Text += " " + Queja.Usuario.Nombre;
            lblNombreReal.Text += " " + Queja.Usuario.NombreReal;
            lblApellido.Text += " " + Queja.Usuario.Apellido;

        }
        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Activo = true; //Le ponemos false si terminó, true si sigue activo

                if (txtBoxRespuesta.Text != "")
                {
                    if (MessageBox.Show("¿La Queja finalizó?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Activo = false;
                    }

                    EnviarRespuesta(Queja.ID, txtBoxRespuesta.Text);
                    LogManager.Escribir(ID, "Ha respondido a una Queja", 1);
                    MessageBox.Show("Respuesta enviada correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    
                    if (MessageBox.Show("¿Desea atender más Quejas?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        FormAnterior.Close();
                    }
                    else
                    {
                        
                    }
                }
                else { throw new Exception("Debe ingresar texto primero"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void CargarDatos()
        {
            try
            {
                int IDIdioma = SessionManager.getInstance(ID).Idioma;

                txtBoxDescripcion.Text = Queja.Descripcion;

                if (Queja.Estados.Count !=0)
                {
                    if (IDIdioma==1)
                    {
                        foreach (Seguimiento_Queja SQ in Queja.Estados)
                        {
                            txtBoxDescripcion.Text += "\r\n\r\n" + "[ACTUALIZACIÓN] - " + SQ.Fecha.ToShortDateString() + "\r\n" + SQ.Estado;
                        }
                    }

                    else if (IDIdioma==2)
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

        public void EnviarRespuesta(int pID, string pRespuesta)
        {
            try
            {
                if (Activo == false)
                {
                    BLL_Queja.Actualizar_Estado_Queja(pID);
                }

                BLL_Queja.Agregar_Seguimiento(pID, pRespuesta, DateTime.Today);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void FormInfoQueja_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                txtBoxDescripcion.Text = "";
                txtBoxRespuesta.Text = "";
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
