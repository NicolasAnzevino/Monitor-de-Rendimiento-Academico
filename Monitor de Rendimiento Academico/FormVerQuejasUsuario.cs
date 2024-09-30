using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Servicios;
using BLL;


namespace Monitor_de_Rendimiento_Academico
{
    public partial class FormVerQuejasUsuario : Form
    {
        public FormVerQuejasUsuario(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();
            ID = pKey;
        }

        public int ID;
        BLL_Queja BLL_Queja;
        List<Queja> LQ;
        public FormVerSeguimientoQueja FormInfoQueja;

        private void FormVerQuejasUsuario_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Queja = new BLL_Queja();
            LQ = BLL_Queja.Ver_Quejas_Usuario(ID);
            MostrarDatosEnGrilla(dgvQuejasUsuario, LQ);
        }

        private void btnVerInfoQueja_Click(object sender, EventArgs e)
        {
            try
            {
                Queja Q = ObtenerQueja((int)dgvQuejasUsuario.SelectedRows[0].Cells[0].Value);

                VerEstadoQueja(Q);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Queja> L)
        {
            try
            {
                if (L.Count != 0)
                {
                    foreach (Queja Q in L)
                    {
                        pDGV.Rows.Add(Q.ID, Q.Asunto, Q.Fecha.ToShortDateString(), Q.Retornar_Activo());
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; MessageBox.Show("No hay Quejas Activas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }        

        public void VerEstadoQueja(Queja pQueja)
        {
            try
            {
                if (LQ.Count != 0)
                {
                    if (FormInfoQueja == null)
                    {
                        Queja Q = ObtenerQueja((int)dgvQuejasUsuario.SelectedRows[0].Cells[0].Value);

                        List<Seguimiento_Queja> LQ = BLL_Queja.Ver_Seguimiento_de_Queja(Q.ID);

                        foreach (Seguimiento_Queja SQ in LQ)
                        {
                            if (!Q.Estados.Exists(X => X.Estado == SQ.Estado))
                            {
                                Q.Estados.Add(new Seguimiento_Queja(SQ.Estado, SQ.Fecha));
                            }
                        }

                        FormInfoQueja = new FormVerSeguimientoQueja(ID, Q, this);
                        FormInfoQueja.FormClosed += FormInfoQueja_FormClosed;
                        FormInfoQueja.ShowDialog();
                    }
                }
                else { MessageBox.Show("No hay Quejas activas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void FormInfoQueja_FormClosed(object sender, FormClosedEventArgs e)
        {
             FormInfoQueja = null;   
        }

        public Queja ObtenerQueja(int pID)
        {
            Queja Q = LQ.Find(X => X.ID == pID);
            return Q;
        }
    }
}
