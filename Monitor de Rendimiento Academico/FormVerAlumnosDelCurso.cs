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
    public partial class FormVerAlumnosDelCurso : Form
    {
        public FormVerAlumnosDelCurso(int pKey, Curso pCurso)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
            Curso = pCurso;
        }

        public int ID;
        public Curso Curso;
        public BLL_Curso BLL_Curso;
        public BLL_Alumno BLL_Alumno;
        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        public List<Alumno> LA;
        public Dictionary<string, bool> Alumnos_Estado;
        FormVerCalificacionesDeCursada FormVerCalificacionesDeCursada;
        FormVerInasistenciasAlumno FormVerInasistenciasAlumno;

        private void FormVerAlumnosDelCurso_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Curso = new BLL_Curso();
            BLL_Alumno = new BLL_Alumno();
            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            LA = BLL_Curso.Ver_Alumnos_del_Curso(Curso);
            Alumnos_Estado = BLL_Curso.Ver_Estado_de_Alumnos_de_Curso(Curso);
            MostrarDatosEnGrilla(dgvAlumnos, LA);

            lblBusqueda.Visible = false;
            txtBoxBusqueda.Visible = false;

            if (dgvAlumnos.Rows.Count > 0)
            {
                dgvAlumnos_Click(null, null);
            }
            else { MessageBox.Show("No hay Alumnos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close(); }
        }
        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Alumno> LA)
        {
            try
            {
                if (LA.Count != 0)
                {
                    foreach (Alumno A in LA)
                    {
                        pDGV.Rows.Add(A.Legajo, A.DNI, A.Apellido, A.Nombre, Alumnos_Estado[A.Legajo]);
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Alumno ObtenerAlumno(string pLegajo)
        {
            Alumno A = LA.Find(X => X.Legajo == pLegajo);
            return A;
        }

        private void rbAlumnosTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosTodos.Checked == true)
            {
                LA = BLL_Curso.Ver_Alumnos_del_Curso(Curso);
                dgvAlumnos.Rows.Clear();               
                MostrarDatosEnGrilla(dgvAlumnos, LA);

                lblBusqueda.Visible = false;
                txtBoxBusqueda.Visible = false;

                if (LA.Count != 0)
                {
                    dgvAlumnos_Click(null, null);
                }
                else
                {
                    txtBoxEmail.Text = "";
                    txtBoxFechaIng.Text = "";
                    txtBoxFechaNac.Text = "";
                }
            }
        }

        private void rbAlumnosLegajo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosLegajo.Checked == true)
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

        private void rbAlumnosDNI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosDNI.Checked == true)
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

        private void rbAlumnosApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosApellido.Checked == true)
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

        private void rbAlumnosNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosNombre.Checked == true)
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

        private void rbAlumnosTurno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumnosTurno.Checked == true)
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

        private void txtBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbAlumnosLegajo.Checked == true)
                {
                    dgvAlumnos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnos, BLL_Alumno.Ver_Alumnos_Legajo(LA, txtBoxBusqueda.Text));
                    Actualizar_TextBox();
                }
                else if (rbAlumnosDNI.Checked == true)
                {
                    dgvAlumnos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnos, BLL_Alumno.Ver_Alumnos_DNI(LA, int.Parse(txtBoxBusqueda.Text)));
                    Actualizar_TextBox();
                }
                else if (rbAlumnosApellido.Checked == true)
                {
                    dgvAlumnos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnos, BLL_Alumno.Ver_Alumnos_Apellido(LA, txtBoxBusqueda.Text));
                    Actualizar_TextBox();
                }
                else if (rbAlumnosNombre.Checked == true)
                {
                    dgvAlumnos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnos, BLL_Alumno.Ver_Alumnos_Nombre(LA, txtBoxBusqueda.Text));
                    Actualizar_TextBox();
                }
                else if (rbAlumnosTurno.Checked == true)
                {
                    dgvAlumnos.Rows.Clear();
                    MostrarDatosEnGrilla(dgvAlumnos, BLL_Alumno.Ver_Alumnos_Turno(LA, txtBoxBusqueda.Text));
                    Actualizar_TextBox();
                }
            }
            catch (Exception) { }
        }

        private void dgvAlumnos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnos.Rows.Count > 0)
                {
                    Alumno A = ObtenerAlumno((string)dgvAlumnos.SelectedRows[0].Cells[0].Value);

                    txtBoxEmail.Text = "";
                    txtBoxEmail.Text = A.Correo_Electronico;

                    txtBoxFechaNac.Text = "";
                    txtBoxFechaNac.Text = A.Fecha_Nacimiento.ToShortDateString();

                    txtBoxFechaIng.Text = "";
                    txtBoxFechaIng.Text = A.Fecha_Ingreso.ToShortDateString();
                }
            }
            catch (Exception ex) { }
        }
        public void Actualizar_TextBox()
        {
            if (dgvAlumnos.Rows.Count != 0)
            {
                dgvAlumnos_Click(null, null);
            }
            else
            {
                txtBoxEmail.Text = "";
                txtBoxFechaIng.Text = "";
                txtBoxFechaNac.Text = "";
            }
        }

        private void btnVerEvaluaciones_Click(object sender, EventArgs e)
        {
            if (FormVerCalificacionesDeCursada is null)
            {
                if (LA.Count > 0)
                {
                    Alumno A = ObtenerAlumno((string)dgvAlumnos.SelectedRows[0].Cells[0].Value);

                    Cursada_de_Alumno CA = BLL_Cursada_de_Alumno.Buscar_Cursada_de_Alumno(A, Curso);

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

        private void rbRegulares_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRegulares.Checked == true)
            {
                lblBusqueda.Visible = false;
                txtBoxBusqueda.Visible = false;
                txtBoxBusqueda.Text = "";

                dgvAlumnos.Rows.Clear();
                MostrarDatosEnGrilla(dgvAlumnos, BLL_Alumno.Ver_Alumnos_Regulares(LA, Alumnos_Estado));
                Actualizar_TextBox();
            }
        }

        private void rbLibres_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLibres.Checked == true)
            {
                lblBusqueda.Visible = false;
                txtBoxBusqueda.Visible = false;
                txtBoxBusqueda.Text = "";

                dgvAlumnos.Rows.Clear();
                MostrarDatosEnGrilla(dgvAlumnos, BLL_Alumno.Ver_Alumnos_Libres(LA, Alumnos_Estado));
                Actualizar_TextBox();
            }
        }

        private void btnVerInasistencias_Click(object sender, EventArgs e)
        {
            if (FormVerInasistenciasAlumno is null)
            {
                if (LA.Count > 0)
                {
                    Alumno A = ObtenerAlumno((string)dgvAlumnos.SelectedRows[0].Cells[0].Value);

                    Cursada_de_Alumno CA = BLL_Cursada_de_Alumno.Buscar_Cursada_de_Alumno(A, Curso);

                    FormVerInasistenciasAlumno = new FormVerInasistenciasAlumno(ID, CA, A);
                    FormVerInasistenciasAlumno.FormClosed += FormVerInasistenciasAlumno_FormClosed; ;
                    FormVerInasistenciasAlumno.ShowDialog();
                }               
            }
        }

        private void FormVerInasistenciasAlumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerInasistenciasAlumno = null;

            foreach (RadioButton RB in gpVisualizacion.Controls)
            {
                RB.Checked = false;
            }

            rbAlumnosTodos.Checked = true;
            rbAlumnosTodos_CheckedChanged(null, null);
        }
    }
}
