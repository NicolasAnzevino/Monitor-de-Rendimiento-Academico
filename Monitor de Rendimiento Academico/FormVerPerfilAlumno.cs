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
    public partial class FormVerPerfilAlumno : Form
    {
        public FormVerPerfilAlumno(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();
            ID = pKey;
        }

        public int ID;
        public Alumno Alumno;
        List<Cursada_de_Alumno> LC;

        BLL_Alumno BLL_Alumno;
        BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;

        FormVerCalificacionesDeCursada FormVerCalificacionesDeCursada;
        FormVerInasistenciasAlumnoPerfil FormVerInasistenciasAlumnoPerfil;

        private void FormVerPerfilAlumno_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Alumno = new BLL_Alumno();
            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            Alumno = BLL_Alumno.Obtener_Alumno_Por_ID_Usuario(ID);

            if (Alumno == null)
            {
                MessageBox.Show("Este Usuario no posee un Alumno asociado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LC = new List<Cursada_de_Alumno>();
            }
            else
            {
                txtBoxLegajo.Text = Alumno.Legajo.ToString();
                txtBoxDNI.Text = Alumno.DNI.ToString();
                txtBoxApellidoyNombre.Text = Alumno.Apellido + ", " + Alumno.Nombre;
                txtBoxCorreoElectronico.Text = Alumno.Correo_Electronico;
                txtBoxFechaIngreso.Text = Alumno.Fecha_Ingreso.ToShortDateString();
                txtBoxFechaNacimiento.Text = Alumno.Fecha_Nacimiento.ToShortDateString();
                txtBoxTurno.Text = Alumno.Turno.ToString();

                txtBoxLegajo.Select(0, 0);

                LC = BLL_Cursada_de_Alumno.Ver_Cursadas_de_Alumno(Alumno);

                if (LC.Count == 0)
                {
                    MessageBox.Show("Este Alumno no posee Cursadas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MostrarDatosEnGrilla(dgvCursadasAlumno, LC);
                }
            }            
        }

        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Cursada_de_Alumno> LC)
        {
            try
            {
                if (LC.Count != 0)
                {
                    foreach (Cursada_de_Alumno C in LC)
                    {
                        pDGV.Rows.Add(C.Codigo, C.Curso.Nombre, C.Curso.Año, C.Curso.Turno, C.Libre, C.Curso.RetornarActivo());
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
            try
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
                    else { throw new Exception("Debe haber mínimamente una Cursada para que pueda tener una calificación"); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            
        }

        private void FormVerCalificacionesDeCursada_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerCalificacionesDeCursada = null;
        }

        private void btnVerInasistencias_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormVerInasistenciasAlumnoPerfil == null)
                {
                    if (dgvCursadasAlumno.Rows.Count > 0)
                    {
                        Cursada_de_Alumno C = ObtenerCursada((int)dgvCursadasAlumno.SelectedRows[0].Cells[0].Value);

                        FormVerInasistenciasAlumnoPerfil = new FormVerInasistenciasAlumnoPerfil(ID, C, Alumno);
                        FormVerInasistenciasAlumnoPerfil.FormClosed += FormVerInasistenciasAlumnoPerfil_FormClosed;
                        FormVerInasistenciasAlumnoPerfil.ShowDialog();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerInasistenciasAlumnoPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerInasistenciasAlumnoPerfil = null;
        }
    }
}
