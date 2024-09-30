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
    public partial class FormResponderEncuesta : Form
    {
        public FormResponderEncuesta(int pKey, Encuesta pEncuesta, Alumno pAlumno)
        {
            InitializeComponent();
            this.CenterToScreen();
            ID = pKey;
            Encuesta = pEncuesta;
            Alumno = pAlumno;
        }

        public int ID, Posicion;
        public Encuesta Encuesta;
        public Alumno Alumno;
        public BLL_Pregunta_de_Encuesta BLL_Pregunta_de_Encuesta;
        public List<Pregunta_de_Encuesta> LP;
        public Dictionary<int, Respuesta_de_Encuesta> Diccionario;

        private void FormResponderEncuesta_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Pregunta_de_Encuesta = new BLL_Pregunta_de_Encuesta();

            LP = BLL_Pregunta_de_Encuesta.Ver_Preguntas_de_Encuesta(Encuesta);
            Diccionario = new Dictionary<int, Respuesta_de_Encuesta>();

            btnEnviarEncuesta.Visible = false;

            Posicion = 0;

            Mostrar_Datos(Posicion);

            txtBoxRespuesta.Focus();
        }
        public void Mostrar_Datos(int pPosicion)
        {
            try
            {
                if (pPosicion == LP.Count - 1)
                {
                    btnEnviarEncuesta.Visible = true;
                    btnSiguiente.Visible = false;
                }

                txtBoxPregunta.Text = "";
                txtBoxRespuesta.Text = "";

                txtBoxPregunta.Text = LP[pPosicion].Pregunta.ToString();

                foreach (Control C in this.Controls)
                {
                    if (C is RadioButton)
                    {
                        RadioButton RB = C as RadioButton;
                        RB.Checked = false;
                    }                    
                }

                rb1.Checked = true;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                int Valoracion = Asignar_Valoracion_RadioButton();

                Diccionario.Add(LP[Posicion].Codigo, BLL_Pregunta_de_Encuesta.Asignar_Valoracion(Valoracion, txtBoxRespuesta.Text));

                Posicion++;
                Mostrar_Datos(Posicion);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnEnviarEncuesta_Click(object sender, EventArgs e)
        {
            try
            {
                int Valoracion = Asignar_Valoracion_RadioButton();

                Diccionario.Add(LP[Posicion].Codigo, BLL_Pregunta_de_Encuesta.Asignar_Valoracion(Valoracion, txtBoxRespuesta.Text));

                LogManager.Escribir(ID, "Completó la Encuesta " + Encuesta.Codigo.ToString() + " - Creada el: " + Encuesta.Fecha_Creacion.ToShortDateString(), 3);
                MessageBox.Show("Gracias por tu tiempo", "Gracias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BLL_Pregunta_de_Encuesta.Enviar_Respuestas_de_Encuesta(Diccionario, Alumno, Encuesta);
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        public int Asignar_Valoracion_RadioButton()
        {
            int Valoracion = 0;

            if (rb1.Checked == true) { Valoracion = 1; }
            else if (rb2.Checked == true) { Valoracion = 2; }
            else if (rb3.Checked == true) { Valoracion = 3; }
            else if (rb4.Checked == true) { Valoracion = 4; }
            else { Valoracion = 5; }

            return Valoracion;
        }
    }
}
