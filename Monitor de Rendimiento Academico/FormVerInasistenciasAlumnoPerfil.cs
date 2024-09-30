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
    public partial class FormVerInasistenciasAlumnoPerfil : Form
    {
        public FormVerInasistenciasAlumnoPerfil(int pKey, Cursada_de_Alumno pCursada, Alumno pAlumno)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
            Cursada = pCursada;
            Alumno = pAlumno;
        }

        public int ID;
        public decimal TotalFaltas;
        public List<Inasistencia> LI;
        public Cursada_de_Alumno Cursada;
        public Alumno Alumno;

        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;

        private void FormVerInasistenciasAlumnoPerfil_Load(object sender, EventArgs e)
        {
            txtBoxBuscar.Mask = "00/00/0000";

            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            lblBuscar.Visible = false;
            txtBoxBuscar.Visible = false;

            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            LI = BLL_Cursada_de_Alumno.Ver_Inasistencia_Alumno(Cursada);

            if (LI.Count > 0)
            {
                MostrarDatosEnGrilla(dgvInasistencias, LI);
                ObtenerTotalFaltas();
            }
            else { MessageBox.Show("Este Alumno no posee Inasistencias la Cursada seleccionada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Inasistencia> LI)
        {
            try
            {
                if (LI.Count != 0)
                {
                    foreach (Inasistencia I in LI)
                    {
                        pDGV.Rows.Add(I.Codigo, I.Fecha.ToShortDateString(), I.Valor.ToString());
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void ObtenerTotalFaltas()
        {
            try
            {
                if (LI.Count != 0)
                {
                    foreach (Inasistencia I in LI)
                    {
                        TotalFaltas += I.Valor;
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void dgvInasistencias_Click(object sender, EventArgs e)
        {
            try
            {
                if (LI.Count > 0)
                {
                    Inasistencia I = ObtenerInasistencia((int)dgvInasistencias.SelectedRows[0].Cells[0].Value);

                    txtBoxDesc.Text = "";
                    txtBoxJust.Text = "";

                    txtBoxDesc.Text = I.Descripcion;
                    txtBoxJust.Text = I.Justificacion;
                }
            }
            catch (Exception) { }
        }
        public Inasistencia ObtenerInasistencia(int pCodigo)
        {
            Inasistencia I = LI.Find(X => X.Codigo == pCodigo);
            return I;
        }

        private void rbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodas.Checked == true)
            {
                LI = BLL_Cursada_de_Alumno.Ver_Inasistencia_Alumno(Cursada);
                dgvInasistencias.Rows.Clear();
                MostrarDatosEnGrilla(dgvInasistencias, LI);

                lblBuscar.Visible = false;
                txtBoxBuscar.Visible = false;
                txtBoxBuscar.Text = "";
            }
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFecha.Checked == true)
            {
                lblBuscar.Visible = true;
                txtBoxBuscar.Visible = true;
            }
        }

        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime Fecha = DateTime.Parse(txtBoxBuscar.Text);
                dgvInasistencias.Rows.Clear();
                MostrarDatosEnGrilla(dgvInasistencias, BLL_Cursada_de_Alumno.Ver_Inasistencias_Fecha(LI, Fecha));
            }
            catch (Exception) { }
        }
    }
}
