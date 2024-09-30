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
    public partial class FormVerDocentesCompararDocentes : Form
    {
        public FormVerDocentesCompararDocentes(int pKey, Tema pTema)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Tema = pTema;
        }

        public int ID;
        public Tema Tema;
        List<Docente> LD;
        BLL_Docente BLL_Docente;
        Docente Docente1, Docente2;
        FormCompararDocente FormCompararDocente;

        private void FormVerDocentesCompararDocentes_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Docente = new BLL_Docente();

            LD = BLL_Docente.Ver_Docentes_Evaluaron_Tema(Tema);
            MostrarDatosEnGrilla(dgvDocentesActivos, LD);

            btnDeseleccionarDocentes.Enabled = false;
            btnCompararDocentes.Enabled = false;

            if (dgvDocentesActivos.Rows.Count > 1)
            {
                btnSeleccionarDocente.Enabled = true;
            }
            else { MessageBox.Show("Debe haber al menos 2 Docentes que hayan Evaluado este tema para poder compararlos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); btnSeleccionarDocente.Enabled = true; this.Close(); }
        }
        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Docente> LD)
        {
            try
            {
                if (LD.Count != 0)
                {
                    foreach (Docente D in LD)
                    {
                        pDGV.Rows.Add(D.Legajo, D.DNI, D.Apellido, D.Nombre);
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public Docente ObtenerDocente(string pLegajo)
        {
            Docente D = LD.Find(X => X.Legajo == pLegajo);
            return D;
        }

        private void btnSeleccionarDocente_Click(object sender, EventArgs e)
        {
            try
            {
                SeleccionarCursada();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDeseleccionarDocentes_Click(object sender, EventArgs e)
        {
            try
            {
                DeseleccionarCursadas();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCompararDocentes_Click(object sender, EventArgs e)
        {
            if (FormCompararDocente is null)
            {
                FormCompararDocente = new FormCompararDocente(ID, Docente1, Docente2, Tema);
                FormCompararDocente.FormClosed += FormCompararDocente_FormClosed;
                FormCompararDocente.ShowDialog();
            }
        }

        private void FormCompararDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCompararDocente = null;
        }

        public void SeleccionarCursada()
        {
            try
            {
                if (Docente1 == null)
                {
                    Docente1 = ObtenerDocente((string)dgvDocentesActivos.SelectedRows[0].Cells[0].Value);

                    btnDeseleccionarDocentes.Enabled = true;

                    txtBoxDocente1.Text = Docente1.Legajo + " - " + Docente1.Apellido + " - " + Docente1.Nombre;

                    foreach (DataGridViewRow r in dgvDocentesActivos.SelectedRows)
                    {
                        if ((string)r.Cells[0].Value == Docente1.Legajo)
                        {
                            dgvDocentesActivos.Rows.RemoveAt(r.Index);
                        }
                    }
                }
                else if (Docente2 == null)
                {
                    if (Docente2 != Docente1)
                    {
                        Docente2 = ObtenerDocente((string)dgvDocentesActivos.SelectedRows[0].Cells[0].Value);

                        txtBoxDocente2.Text = Docente2.Legajo + " - " + Docente2.Apellido + " - " + Docente2.Nombre;

                        btnCompararDocentes.Enabled = true;
                    }
                    else { DeseleccionarCursadas(); throw new Exception("No se puede realizar una comparación con el mismo Docente"); }
                }
                else
                {
                    throw new Exception("Ya se seleccionaron dos Docentes");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void DeseleccionarCursadas()
        {
            Docente1 = null;
            Docente2 = null;

            btnCompararDocentes.Enabled = false;
            btnDeseleccionarDocentes.Enabled = false;

            txtBoxDocente1.Text = "";
            txtBoxDocente2.Text = "";

            dgvDocentesActivos.Rows.Clear();
            MostrarDatosEnGrilla(dgvDocentesActivos, LD);
        }
    }
}
