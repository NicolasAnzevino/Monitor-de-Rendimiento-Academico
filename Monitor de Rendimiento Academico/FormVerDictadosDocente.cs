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
    public partial class FormVerDictadosDocente : Form
    {
        public FormVerDictadosDocente(int pKey, Docente pDocente)
        {
            InitializeComponent();
            this.CenterToParent();
            ID = pKey;
            Docente = pDocente;
        }

        public int ID, IDDocente;
        public Docente Docente;
        public BLL_Dictado BLL_Dictado;
        public BLL_Docente BLL_Docente;
        public BLL_Materia BLL_Materia;
        public List<Dictado> LD;
        FormVerDictadoDelDocente FormVerDictadoDelDocente;

        private void FormVerDictadosDocente_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Dictado = new BLL_Dictado();
            BLL_Docente = new BLL_Docente();
            BLL_Materia = new BLL_Materia();

            IDDocente = BLL_Docente.Obtener_ID_Usuario_Docente(Docente);

            LD = BLL_Dictado.Ver_Dictados_del_Docente_Activos(IDDocente);
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
                        pDGV.Rows.Add(D.Codigo, D.Materia.Codigo, D.Materia.Nombre);
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
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

        private void btnVerDictado_Click(object sender, EventArgs e)
        {
            if (FormVerDictadoDelDocente is null)
            {
                if (dgvDictados.Rows.Count > 0)
                {
                    Dictado D = ObtenerDictado((int)dgvDictados.SelectedRows[0].Cells[0].Value);

                    Materia M = BLL_Materia.Obtener_Materia_de_Dictado(D);

                    FormVerDictadoDelDocente = new FormVerDictadoDelDocente(ID, M, D);
                    FormVerDictadoDelDocente.FormClosed += FormVerDictadoDelDocente_FormClosed;
                    FormVerDictadoDelDocente.ShowDialog();
                }
            }
        }

        private void FormVerDictadoDelDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerDictadoDelDocente = null;
        }

        public Dictado ObtenerDictado(int pID)
        {
            Dictado D = LD.Find(X => X.Codigo == pID);
            return D;
        }
    }
}
