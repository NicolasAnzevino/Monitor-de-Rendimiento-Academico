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
    public partial class FormVerEncuestasAlumno : Form
    {
        public FormVerEncuestasAlumno(int pKey)
        {
            InitializeComponent();
            this.CenterToScreen();
            ID = pKey;
        }

        public int ID;
        public Alumno Alumno;
        public BLL_Alumno BLL_Alumno;
        public BLL_Encuesta_de_Alumno BLL_Encuesta_de_Alumno;
        public List<Encuesta> LE;
        FormResponderEncuesta FormResponderEncuesta;

        private void FormVerEncuestasAlumno_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Alumno = new BLL_Alumno();
            BLL_Encuesta_de_Alumno = new BLL_Encuesta_de_Alumno();

            Alumno = BLL_Alumno.Obtener_Alumno_Por_ID_Usuario(ID);

            if (Alumno != null)
            {
                LE = BLL_Encuesta_de_Alumno.Ver_Encuestas_Alummo(Alumno.Legajo);

                if (LE.Count > 0)
                {
                    MostrarDatosEnGrilla(dgvEncuestasActivas, LE);
                }
            }
            else
            {
                MessageBox.Show("Debe tener un Alumno asociado a este Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public Encuesta ObtenerEncuesta(int pID)
        {
            Encuesta E = LE.Find(X => X.Codigo == pID);
            return E;
        }

        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Encuesta> L)
        {
            try
            {
                if (L.Count != 0)
                {
                    foreach (Encuesta E in L)
                    {
                        pDGV.Rows.Add(E.Codigo, E.Fecha_Creacion.ToShortDateString());
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void btnRealizarEncuesta_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormResponderEncuesta == null)
                {
                    if (dgvEncuestasActivas.Rows.Count > 0)
                    {
                        Encuesta E = ObtenerEncuesta((int)dgvEncuestasActivas.SelectedRows[0].Cells[0].Value);
                        FormResponderEncuesta = new FormResponderEncuesta(ID, E, Alumno);
                        FormResponderEncuesta.FormClosed += FormResponderEncuesta_FormClosed;
                        FormResponderEncuesta.ShowDialog();
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void FormResponderEncuesta_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormResponderEncuesta = null;
            dgvEncuestasActivas.Rows.Clear();

            LE = BLL_Encuesta_de_Alumno.Ver_Encuestas_Alummo(Alumno.Legajo);
            if (LE.Count > 0)
            {
                MostrarDatosEnGrilla(dgvEncuestasActivas, LE);
            }

        }
    }
}
