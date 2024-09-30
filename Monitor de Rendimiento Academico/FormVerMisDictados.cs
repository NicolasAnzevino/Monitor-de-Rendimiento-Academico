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
    public partial class FormVerMisDictados : Form
    {
        public FormVerMisDictados(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();
            ID = pKey;
        }

        public int ID;
        BLL_Dictado BLL_Dictado;
        List<Dictado> LD;
        FormVerMateria FormVerMateria;
        FormVerDictadoDelDocente FormVerDictadoDelDocente;

        private void FormVerMisDictados_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Dictado = new BLL_Dictado();

            LD = BLL_Dictado.Ver_Dictados_del_Docente_Activos(ID);
            MostrarDatosEnGrilla(dgvDictados, LD);

            if (LD.Count > 0)
            {
                dgvDictados_Click(null, null);
            }
            else { MessageBox.Show("No hay Dictados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Dictado> LD)
        {
            try
            {
                if (LD.Count != 0)
                {
                    foreach (Dictado D in LD)
                    {
                        pDGV.Rows.Add(D.Codigo, D.Materia.Nombre, D.Curso.Nombre);
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Dictado ObtenerDictado(int pID)
        {
            Dictado D = LD.Find(X => X.Codigo == pID);
            return D;
        }

        private void rbMateriasActivas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMateriasActivas.Checked == true)
            {
                dgvDictados.Rows.Clear();
                LD = BLL_Dictado.Ver_Dictados_del_Docente_Activos(ID);
                MostrarDatosEnGrilla(dgvDictados, LD);

                lbDocentes.Items.Clear();

                if (LD.Count > 0)
                {
                    dgvDictados_Click(null, null);
                }
            }
        }

        private void rbMateriasInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMateriasInactivos.Checked == true)
            {
                dgvDictados.Rows.Clear();
                LD = BLL_Dictado.Ver_Dictados_del_Docente_Inactivos(ID);
                MostrarDatosEnGrilla(dgvDictados, LD);

                lbDocentes.Items.Clear();

                if (LD.Count > 0)
                {
                    dgvDictados_Click(null, null);
                }
            }
        }

        private void dgvDictados_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDictados.Rows.Count > 0)
                {
                    lbDocentes.Items.Clear();

                    Dictado D = ObtenerDictado((int)dgvDictados.SelectedRows[0].Cells[0].Value);

                    foreach (Docente Docente in D.VerDocentes())
                    {
                        lbDocentes.Items.Add(Docente.Legajo + "-" + Docente.Apellido + ", " + Docente.Nombre);
                    }
                }
            }
            catch (Exception) { }
        }

        private void btnVerMateria_Click(object sender, EventArgs e)
        {
            if (FormVerMateria is null && FormVerDictadoDelDocente is null)
            {
                if (dgvDictados.Rows.Count>0)
                {
                    Dictado D = ObtenerDictado((int)dgvDictados.SelectedRows[0].Cells[0].Value);

                    if (rbMateriasActivas.Checked == true)
                    {
                        FormVerMateria = new FormVerMateria(ID, D.Curso, D.Materia, D);
                        FormVerMateria.FormClosed += FormVerMateria_FormClosed;
                        FormVerMateria.ShowDialog();
                    }
                    else if (rbMateriasInactivos.Checked == true)
                    {
                        FormVerDictadoDelDocente = new FormVerDictadoDelDocente(ID, D.Materia, D);
                        FormVerDictadoDelDocente.FormClosed += FormVerDictadoDelDocente_FormClosed;
                        FormVerDictadoDelDocente.ShowDialog();
                    }

                }                
            }
        }

        private void FormVerDictadoDelDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerDictadoDelDocente = null;
        }

        private void FormVerMateria_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerMateria = null;
        }
    }
}
