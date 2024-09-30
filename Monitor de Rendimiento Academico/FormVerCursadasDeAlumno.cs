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
    public partial class FormVerCursadasDeAlumno : Form
    {
        public FormVerCursadasDeAlumno(int pKey, Alumno pAlumno)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Alumno = pAlumno;
        }

        public int ID;
        public Alumno Alumno;
        public Cursada_de_Alumno Cursada1, Cursada2;
        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        List<Cursada_de_Alumno> LC;
        FormVerCalificacionesDeCursada FormVerCalificacionesDeCursada;
        FormVerRendimientoCursada FormVerRendimientoCursada;
        FormCompararCursadas FormCompararCursadas;
        FormVerInasistenciasAlumno FormVerInasistenciasAlumno;

        private void FormVerCursadasDeAlumno_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            LC = BLL_Cursada_de_Alumno.Ver_Cursadas_de_Alumno(Alumno);
            MostrarDatosEnGrilla(dgvCursadasAlumno, LC);

            if (LC.Count==0)
            {
                MessageBox.Show("Este Alumno no posee Cursadas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            this.Size = new Size(839, 342);

            btnCancelarComparacion.Visible = false;
            btnAgregarCursada.Visible = false;
            lblCursada1.Visible = false;
            lblCursada2.Visible = false;
            txtBoxCursada1.Visible = false;
            txtBoxCursada2.Visible = false;
            btnDeseleccionarCursadas.Visible = false;
            btnCompararCursadas.Visible = false;
        }
        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Cursada_de_Alumno> LC)
        {
            try
            {
                if (LC.Count != 0)
                {
                    foreach (Cursada_de_Alumno C in LC)
                    {
                        pDGV.Rows.Add(C.Codigo, C.Curso.Codigo, C.Curso.Nombre, C.Curso.Año, C.Curso.Turno, C.Libre, C.Curso.RetornarActivo());
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public Cursada_de_Alumno ObtenerCursada(int pCodigo)
        {
            Cursada_de_Alumno CA = LC.Find(X => X.Codigo == pCodigo);
            return CA;
        }

        private void btnVerEvaluacionesDeCursada_Click(object sender, EventArgs e)
        {
            if (FormVerCalificacionesDeCursada is null)
            {
                if (LC.Count > 0)
                {
                    Cursada_de_Alumno CA = ObtenerCursada((int)dgvCursadasAlumno.SelectedRows[0].Cells[0].Value);

                    FormVerCalificacionesDeCursada = new FormVerCalificacionesDeCursada(ID, CA);
                    FormVerCalificacionesDeCursada.FormClosed += FormVerCalificacionesDeCursada_FormClosed;
                    FormVerCalificacionesDeCursada.ShowDialog();
                }
                else
                {
                    throw new Exception("Debe haber mínimamente una Cursada para que pueda tener una calificación");
                }
            }
        }

        private void FormVerCalificacionesDeCursada_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerCalificacionesDeCursada = null;
        }

        private void btnCompararRendimiento_Click(object sender, EventArgs e)
        {
            try
            {
                this.Size = new Size(839, 396);

                btnCancelarComparacion.Visible = true;
                btnAgregarCursada.Visible = true;
                lblCursada1.Visible = true;
                lblCursada2.Visible = true;
                txtBoxCursada1.Visible = true;
                txtBoxCursada2.Visible = true;
                btnDeseleccionarCursadas.Visible = true;
                btnCompararCursadas.Visible = true;

                btnVerEvaluacionesDeCursada.Visible = false;
                btnVerRendimientoDeCursada.Visible = false;
                btnCompararRendimiento.Visible = false;
                btnVerInasistencias.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelarComparacion_Click(object sender, EventArgs e)
        {
            try
            {
                DeseleccionarCursadas();
                
                btnVerEvaluacionesDeCursada.Visible = true;
                btnVerRendimientoDeCursada.Visible = true;
                btnCompararRendimiento.Visible = true;
                btnVerInasistencias.Visible = true;

                this.Size = new Size(839, 342);

                btnCancelarComparacion.Visible = false;
                btnAgregarCursada.Visible = false;
                lblCursada1.Visible = false;
                lblCursada2.Visible = false;
                txtBoxCursada1.Visible = false;
                txtBoxCursada2.Visible = false;
                btnDeseleccionarCursadas.Visible = false;
                btnCompararCursadas.Visible = false;

                dgvCursadasAlumno.Rows.Clear();
                MostrarDatosEnGrilla(dgvCursadasAlumno, LC);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnVerRendimientoDeCursada_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormVerRendimientoCursada == null)
                {
                    if (dgvCursadasAlumno.Rows.Count > 0)
                    {
                        Cursada_de_Alumno C = ObtenerCursada((int)dgvCursadasAlumno.SelectedRows[0].Cells[0].Value);

                        FormVerRendimientoCursada = new FormVerRendimientoCursada(ID, Alumno, C);
                        FormVerRendimientoCursada.FormClosed += FormVerRendimientoCursada_FormClosed;
                        FormVerRendimientoCursada.ShowDialog();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerRendimientoCursada_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerRendimientoCursada = null;
        }

        private void btnAgregarCursada_Click(object sender, EventArgs e)
        {
            try
            {
                SeleccionarCursada();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public void SeleccionarCursada()
        {
            try
            {
                if (Cursada1 == null)
                {
                    Cursada1 = ObtenerCursada((int)dgvCursadasAlumno.SelectedRows[0].Cells[0].Value);

                    btnCompararCursadas.Enabled = true;
                    btnDeseleccionarCursadas.Enabled = true;

                    txtBoxCursada1.Text = Cursada1.Curso.Codigo + " - " + Cursada1.Curso.Nombre + " - " + Cursada1.Curso.Turno;

                    foreach (DataGridViewRow r in dgvCursadasAlumno.SelectedRows)
                    {
                        if ((int)r.Cells[0].Value == Cursada1.Codigo)
                        {
                            dgvCursadasAlumno.Rows.RemoveAt(r.Index);
                        }
                    }
                }
                else if (Cursada2 == null)
                {
                    if (Cursada2 != Cursada1)
                    {
                        Cursada2 = ObtenerCursada((int)dgvCursadasAlumno.SelectedRows[0].Cells[0].Value);

                        txtBoxCursada2.Text = Cursada2.Curso.Codigo + " - " + Cursada2.Curso.Nombre + " - " + Cursada2.Curso.Turno;
                    }
                    else { DeseleccionarCursadas(); throw new Exception("No se puede realizar una comparación con la misma Cursada"); }
                }
                else
                {
                    throw new Exception("Ya se seleccionaron dos Cursadas");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void btnCompararCursadas_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormCompararCursadas == null)
                {
                    if (dgvCursadasAlumno.Rows.Count > 0)
                    {
                        if (Cursada1 != null && Cursada2 != null)
                        {
                            FormCompararCursadas = new FormCompararCursadas(ID, Alumno, Cursada1, Cursada2);
                            FormCompararCursadas.FormClosed += FormCompararCursadas_FormClosed;
                            FormCompararCursadas.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormCompararCursadas_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCompararCursadas = null;
            DeseleccionarCursadas();
            btnCancelarComparacion_Click(null, null);
        }

        private void btnDeseleccionarCursadas_Click(object sender, EventArgs e)
        {
            DeseleccionarCursadas();
        }

        private void btnVerInasistencias_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormVerInasistenciasAlumno == null)
                {
                    if (dgvCursadasAlumno.Rows.Count > 0)
                    {
                        Cursada_de_Alumno C = ObtenerCursada((int)dgvCursadasAlumno.SelectedRows[0].Cells[0].Value);

                        FormVerInasistenciasAlumno = new FormVerInasistenciasAlumno(ID, C, Alumno);
                        FormVerInasistenciasAlumno.FormClosed += FormVerInasistenciasAlumno_FormClosed;
                        FormVerInasistenciasAlumno.ShowDialog();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerInasistenciasAlumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerInasistenciasAlumno = null;

            LC = BLL_Cursada_de_Alumno.Ver_Cursadas_de_Alumno(Alumno);
            dgvCursadasAlumno.Rows.Clear();
            MostrarDatosEnGrilla(dgvCursadasAlumno, LC);
        }

        public void DeseleccionarCursadas()
        {
            Cursada1 = null;
            Cursada2 = null;

            btnCompararCursadas.Enabled = false;
            btnDeseleccionarCursadas.Enabled = false;

            txtBoxCursada1.Text = "";
            txtBoxCursada2.Text = "";

            dgvCursadasAlumno.Rows.Clear();
            MostrarDatosEnGrilla(dgvCursadasAlumno, LC);
        }
    }
}
