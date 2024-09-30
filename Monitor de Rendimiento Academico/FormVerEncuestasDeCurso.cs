using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
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
    public partial class FormVerEncuestasDeCurso : Form
    {
        public FormVerEncuestasDeCurso(int pKey, Curso pCurso)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Curso = pCurso;
        }

        public int ID;
        public Curso Curso;
        public BLL_Encuesta BLL_Encuesta;
        public List<Encuesta> Encuestas;
        public FormVerRespuestaAlumnoEncuesta FormVerRespuestaAlumnoEncuesta;

        private void FormVerEncuestasDeCurso_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Encuesta = new BLL_Encuesta();

            Encuestas = BLL_Encuesta.Ver_Encuestas_de_Curso(Curso);

            if (Encuestas.Count>0)
            {
                MostrarDatosEnGrilla(dgvEncuestasDeCurso, Encuestas);
            }
            else { MessageBox.Show("El Curso no posee Encuestas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
        }
        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Encuesta> pLE)
        {
            try
            {
                if (pLE.Count != 0)
                {
                    foreach (Encuesta E in pLE)
                    {
                        pDGV.Rows.Add(E.Codigo, E.Fecha_Creacion.ToShortDateString());
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public Encuesta ObtenerEncuesta(int pCodigo)
        {
            Encuesta E = Encuestas.Find(X => X.Codigo == pCodigo);
            return E;
        }

        private void btnDarDeBajaEncuesta_Click(object sender, EventArgs e)
        {
            try
            {
                if (Encuestas.Count>0)
                {
                    Encuesta E = ObtenerEncuesta((int)dgvEncuestasDeCurso.SelectedRows[0].Cells[0].Value);
                    Dar_De_Baja_Encuesta(E);
                    LogManager.Escribir(ID, "Dio de baja la Encuesta " + E.Codigo, 3);
                    MessageBox.Show("Se ha dado de baja la Encuesta correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { throw new Exception("No hay Encuestas"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Dar_De_Baja_Encuesta(Encuesta pEncuesta)
        {
            try
            {
                BLL_Encuesta.Dar_de_Baja_Encuesta(pEncuesta);
                Encuestas = BLL_Encuesta.Ver_Encuestas_de_Curso(Curso);
                dgvEncuestasDeCurso.Rows.Clear();
                MostrarDatosEnGrilla(dgvEncuestasDeCurso, Encuestas);               
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void btnVerResultadosDeEncuesta_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormVerRespuestaAlumnoEncuesta == null)
                {
                    if (dgvEncuestasDeCurso.Rows.Count > 0)
                    {
                        Encuesta E = ObtenerEncuesta((int)dgvEncuestasDeCurso.SelectedRows[0].Cells[0].Value);
                        FormVerRespuestaAlumnoEncuesta = new FormVerRespuestaAlumnoEncuesta(ID, Curso, E);
                        FormVerRespuestaAlumnoEncuesta.FormClosed += FormVerRespuestaAlumnoEncuesta_FormClosed;
                        FormVerRespuestaAlumnoEncuesta.ShowDialog();
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void FormVerRespuestaAlumnoEncuesta_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerRespuestaAlumnoEncuesta = null;
        }
    }
}
