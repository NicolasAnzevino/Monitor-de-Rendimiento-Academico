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
    public partial class FormVerInasistenciasAlumno : Form
    {
        public FormVerInasistenciasAlumno(int pKey, Cursada_de_Alumno pCursada, Alumno pAlumno)
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

        FormAgregarInasistencia FormAgregarInasistencia;
        FormModificarInasistencia FormModificarInasistencia;

        private void FormVerInasistenciasAlumno_Load(object sender, EventArgs e)
        {
            txtBoxBuscar.Mask = "00/00/0000";
            
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            lblBuscar.Visible = false;
            txtBoxBuscar.Visible = false;

            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            LI = BLL_Cursada_de_Alumno.Ver_Inasistencia_Alumno(Cursada);

            if (Cursada.Curso.RetornarActivo() == false)
            {
                btnAgregarInasistencia.Enabled = false;
                btnEliminarInasistencia.Enabled = false;
                btnModificarInasistencia.Enabled = false;
            }

            if (LI.Count>0)
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
            catch (Exception) {}          
        }

        public Inasistencia ObtenerInasistencia(int pCodigo)
        {
            Inasistencia I = LI.Find(X => X.Codigo == pCodigo);
            return I;
        }

        private void rbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodas.Checked==true)
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
            catch (Exception) {}
        }

        private void btnEliminarInasistencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInasistencias.Rows.Count>0)
                {
                    Inasistencia I = ObtenerInasistencia((int)dgvInasistencias.SelectedRows[0].Cells[0].Value);

                    if (MessageBox.Show("¿Está seguro de eliminar la Inasistencia?", "Solicitud de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (TotalFaltas -I.Valor < 25 && Cursada.Libre == true)
                        {
                            if (MessageBox.Show("Nota: Si usted elimina esta Inasistencia, el estado del Alumno " + Alumno.Apellido + ", " + Alumno.Nombre + " pasará a ser Alumno Regular\n\n¿Está de acuerdo con esto?", "Solicitud de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Eliminar_Inasistencia(I);
                                LogManager.Escribir(ID, "Eliminó una Inasistencia de la Cursada " + Cursada.Codigo + " del Alumno " + Alumno.Legajo, 2);
                                BLL_Cursada_de_Alumno.Modificar_Estado_de_Cursada(Cursada, false);
                                Cursada.Libre = false;
                                TotalFaltas -= I.Valor;
                                LogManager.Escribir(ID, "Estableció la Cursada " + Cursada.Codigo + " del Alumno " + Alumno.Legajo + " en Alumno Regular ", 2);
                                MessageBox.Show("Inasistencia eliminada correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            TotalFaltas -= I.Valor;
                            Eliminar_Inasistencia(I);
                            LogManager.Escribir(ID, "Eliminó una Inasistencia de la Cursada " + Cursada.Codigo + " del Alumno " + Alumno.Legajo, 2);
                            MessageBox.Show("Inasistencia eliminada correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }                        
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Eliminar_Inasistencia(Inasistencia pInasistencia)
        {
            BLL_Cursada_de_Alumno.Eliminar_Inasistencia(pInasistencia);
            dgvInasistencias.Rows.Clear();

            LI = BLL_Cursada_de_Alumno.Ver_Inasistencia_Alumno(Cursada);

            if (LI.Count > 0)
            {
                MostrarDatosEnGrilla(dgvInasistencias, LI);
            }
            else { MessageBox.Show("Este Alumno no posee Inasistencias la Cursada seleccionada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close(); }
        }

        private void btnModificarInasistencia_Click(object sender, EventArgs e)
        {
            if (FormModificarInasistencia == null)
            {
                if (dgvInasistencias.Rows.Count > 0)
                {
                    Inasistencia I = ObtenerInasistencia((int)dgvInasistencias.SelectedRows[0].Cells[0].Value);
                    FormModificarInasistencia = new FormModificarInasistencia(ID, Cursada, I, Alumno, TotalFaltas);
                    FormModificarInasistencia.FormClosed += FormModificarInasistencia_FormClosed;
                    FormModificarInasistencia.ShowDialog();
                }
            }
        }

        private void FormModificarInasistencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormModificarInasistencia = null;

            dgvInasistencias.Rows.Clear();

            LI = BLL_Cursada_de_Alumno.Ver_Inasistencia_Alumno(Cursada);

            if (LI.Count > 0)
            {
                MostrarDatosEnGrilla(dgvInasistencias, LI);
                TotalFaltas = BLL_Cursada_de_Alumno.Obtener_Total_Inasistencias_de_Cursada(Cursada);
            }
            else { MessageBox.Show("Este Alumno no posee Inasistencias la Cursada seleccionada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnAgregarInasistencia_Click(object sender, EventArgs e)
        {
            if (Cursada.Libre==false)
            {
                if (FormAgregarInasistencia == null)
                {
                    FormAgregarInasistencia = new FormAgregarInasistencia(ID, Cursada, Alumno, TotalFaltas);
                    FormAgregarInasistencia.FormClosed += FormAgregarInasistencia_FormClosed;
                    FormAgregarInasistencia.ShowDialog();
                }
            }
            else { MessageBox.Show("Un Alumno cuyo estado sea Libre no puede concurrir a clases", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void FormAgregarInasistencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAgregarInasistencia = null;
            dgvInasistencias.Rows.Clear();

            LI = BLL_Cursada_de_Alumno.Ver_Inasistencia_Alumno(Cursada);

            if (LI.Count > 0)
            {
                MostrarDatosEnGrilla(dgvInasistencias, LI);
                TotalFaltas = BLL_Cursada_de_Alumno.Obtener_Total_Inasistencias_de_Cursada(Cursada);
            }
            else { MessageBox.Show("Este Alumno no posee Inasistencias la Cursada seleccionada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);}

        }
    }

}
