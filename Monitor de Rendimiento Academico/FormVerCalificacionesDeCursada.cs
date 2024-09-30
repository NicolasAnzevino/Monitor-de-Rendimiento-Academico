using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq.SqlClient;
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
    public partial class FormVerCalificacionesDeCursada : Form
    {
        public FormVerCalificacionesDeCursada(int pKey, Cursada_de_Alumno pCursada)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Cursada = pCursada;
        }

        public int ID;
        public Cursada_de_Alumno Cursada;
        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        List<Evaluacion_de_Alumno> LE;

        private void FormVerCalificacionesDeCursada_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            LE = BLL_Cursada_de_Alumno.Ver_Evaluaciones_de_Cursada(Cursada);
            MostrarDatosEnGrilla(dgvEvaluacionesCalificacion, LE);

            if (LE.Count == 0)
            {
                MessageBox.Show("Esta Cursada no posee Calificaciones", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                dgvEvaluacionesCalificacion_Click(null, null);
            }

            lblBusqueda.Visible = false;
            txtBoxBusqueda.Visible = false;            
        }
        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Evaluacion_de_Alumno> LE)
        {
            try
            {
                if (LE.Count != 0)
                {
                    foreach (Evaluacion_de_Alumno EA in LE)
                    {
                        pDGV.Rows.Add(EA.Codigo, EA.Evaluacion.Codigo, EA.Evaluacion.Titulo, EA.Evaluacion.Materia.Nombre, EA.Fecha.ToShortDateString(), EA.Calificacion);
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void dgvEvaluacionesCalificacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEvaluacionesCalificacion.Rows.Count>0)
                {
                    Evaluacion_de_Alumno EA = Obtener_Evaluacion_de_Alumno(int.Parse(dgvEvaluacionesCalificacion.SelectedRows[0].Cells[0].Value.ToString()));

                    listBoxTemasEvaluacion.Items.Clear();

                    if (EA.Evaluacion.VerTemas().Count>0)
                    {
                        foreach (Tema T in EA.Evaluacion.VerTemas())
                        {
                            listBoxTemasEvaluacion.Items.Add("◉ " + T.Codigo + " - " + T.Nombre);
                        }
                    }

                    txtBoxDocenteEvaluacion.Text = "";
                    txtBoxDocenteEvaluacion.Text = EA.Docente.Legajo + " - " + EA.Docente.Apellido + ", " + EA.Docente.Nombre;
                }
            }
            catch (Exception) {}
        }
        public Evaluacion_de_Alumno Obtener_Evaluacion_de_Alumno(int pCodigo)
        {
            Evaluacion_de_Alumno E = LE.Find(X => X.Codigo == pCodigo);
            return E;
        }

        private void rbEvaluacionesTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEvaluacionesTodos.Checked == true)
            {
                lblBusqueda.Visible = false;
                txtBoxBusqueda.Visible = false;

                dgvEvaluacionesCalificacion.Rows.Clear();
                LE = BLL_Cursada_de_Alumno.Ver_Evaluaciones_de_Cursada(Cursada);
                MostrarDatosEnGrilla(dgvEvaluacionesCalificacion, LE);

                if (LE.Count>0)
                {
                    dgvEvaluacionesCalificacion_Click(null, null);
                }
            }
        }

        private void rbEvaluacionesMateria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEvaluacionesMateria.Checked == true)
            {
                if (lblBusqueda.Visible == false)
                {
                    lblBusqueda.Visible = true;
                }

                if (txtBoxBusqueda.Visible == false)
                {
                    txtBoxBusqueda.Visible = true;
                }
            }
        }             
        
        private void txtBoxBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (rbEvaluacionesMateria.Checked == true)
                {
                    dgvEvaluacionesCalificacion.Rows.Clear();
                    MostrarDatosEnGrilla(dgvEvaluacionesCalificacion, BLL_Cursada_de_Alumno.Ver_EvaAlu_Materia(LE, txtBoxBusqueda.Text));
                    
                    if (dgvEvaluacionesCalificacion.Rows.Count>0)
                    {
                        dgvEvaluacionesCalificacion_Click(null, null);
                    }
                }
                else if (rbEvaluacionesFecha.Checked == true)
                {
                    dgvEvaluacionesCalificacion.Rows.Clear();
                    MostrarDatosEnGrilla(dgvEvaluacionesCalificacion, BLL_Cursada_de_Alumno.Ver_EvaAlu_Fecha(LE, DateTime.Parse(txtBoxBusqueda.Text)));

                    if (dgvEvaluacionesCalificacion.Rows.Count > 0)
                    {
                        dgvEvaluacionesCalificacion_Click(null, null);
                    }
                }
                else if (rbEvaluacionesCalificacion.Checked == true)
                {
                    dgvEvaluacionesCalificacion.Rows.Clear();
                    MostrarDatosEnGrilla(dgvEvaluacionesCalificacion, BLL_Cursada_de_Alumno.Ver_EvaAlu_Calificacion(LE, int.Parse(txtBoxBusqueda.Text)));

                    if (dgvEvaluacionesCalificacion.Rows.Count > 0)
                    {
                        dgvEvaluacionesCalificacion_Click(null, null);
                    }
                }


            }
            catch (Exception) { }
        }

        private void rbEvaluacionesFecha_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbEvaluacionesFecha.Checked == true)
            {
                if (lblBusqueda.Visible == false)
                {
                    lblBusqueda.Visible = true;
                }

                if (txtBoxBusqueda.Visible == false)
                {
                    txtBoxBusqueda.Visible = true;
                }
            }
        }

        private void rbEvaluacionesCalificacion_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbEvaluacionesCalificacion.Checked == true)
            {
                if (lblBusqueda.Visible == false)
                {
                    lblBusqueda.Visible = true;
                }

                if (txtBoxBusqueda.Visible == false)
                {
                    txtBoxBusqueda.Visible = true;
                }
            }
        }
    }
}
