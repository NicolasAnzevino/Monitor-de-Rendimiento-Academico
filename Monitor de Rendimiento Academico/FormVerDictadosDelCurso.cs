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
    public partial class FormVerDictadosDelCurso : Form
    {
        public FormVerDictadosDelCurso(int pKey, Curso pCurso)
        {
            InitializeComponent();
            this.CenterToScreen();
            ID = pKey;
            Curso = pCurso;
        }

        public int ID;
        public Curso Curso;
        BLL_Curso BLL_Curso;
        public List<Dictado> LD;

        private void FormVerDictadosDelCurso_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Curso = new BLL_Curso();

            LD = BLL_Curso.Ver_Dictados_del_Curso(Curso);
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
        public Dictado ObtenerDictado(int pID)
        {
            Dictado D = LD.Find(X => X.Codigo == pID);
            return D;
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
    }
}
