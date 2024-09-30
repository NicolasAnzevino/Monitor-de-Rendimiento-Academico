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
    public partial class FormVerCursadasCompararRendimiento : Form
    {
        public FormVerCursadasCompararRendimiento(int pKey, Alumno pAlumno)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Alumno = pAlumno;
        }

        public int ID;
        public Alumno Alumno;
        public BLL_Curso BLL_Curso;
        public BLL_Alumno BLL_Alumno;
        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        public Cursada_de_Alumno Cursada1, Cursada2;
        FormCompararCursadas FormCompararCursadas;

        private void FormVerCursadasCompararRendimiento_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            MostrarDatosEnGrilla(dgvCursadasAlumno, Alumno.VerCursadas());

            if (Alumno.VerCursadas().Count == 0)
            {
                MessageBox.Show("Este Alumno no posee Cursadas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            txtBoxAlumno.Text = Alumno.Legajo + " - " + Alumno.DNI + " - " + Alumno.Apellido + ", " + Alumno.Nombre;

            btnCompararCursadas.Enabled = false;
            btnDeseleccionarCursadas.Enabled = false;
        }

        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Cursada_de_Alumno> LC)
        {
            try
            {
                if (LC.Count != 0)
                {
                    foreach (Cursada_de_Alumno C in LC)
                    {
                        pDGV.Rows.Add(C.Codigo, C.Curso.Codigo, C.Curso.Nombre, C.Curso.Año, C.Curso.Turno, C.Curso.RetornarActivo());
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public Cursada_de_Alumno ObtenerCursada(int pCodigo)
        {
            Cursada_de_Alumno CA = Alumno.VerCursadas().Find(X => X.Codigo == pCodigo);
            return CA;
        }

        private void btnSeleccionarCursada_Click(object sender, EventArgs e)
        {
            try
            {
                SeleccionarCursada();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDeseleccionarCursadas_Click(object sender, EventArgs e)
        {
            try
            {
                DeseleccionarCursadas();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCompararCursadas_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormCompararCursadas == null)
                {
                    if (dgvCursadasAlumno.Rows.Count>0)
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

        public void DeseleccionarCursadas()
        {
            Cursada1 = null;
            Cursada2 = null;

            btnCompararCursadas.Enabled = false;
            btnDeseleccionarCursadas.Enabled = false;

            txtBoxCursada1.Text = "";
            txtBoxCursada2.Text = "";

            dgvCursadasAlumno.Rows.Clear();
            MostrarDatosEnGrilla(dgvCursadasAlumno, Alumno.VerCursadas());
        }
    }
}
