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
    public partial class FormAtenderQueja : Form
    {
        public FormAtenderQueja(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();
            ID = pKey;
        }

        public int ID;
        BLL_Queja BLL_Queja;
        List<Queja> LQ;
        public FormInfoQueja FormInfoQueja;

        private void FormAtenderQueja_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Queja = new BLL_Queja();
            LQ = BLL_Queja.Ver_Quejas_Activas();
            MostrarDatosEnGrilla(dgvQuejasActivas, LQ);
        }

        private void btnAtenderQueja_Click(object sender, EventArgs e)
        {
            try
            {
                if (LQ.Count!=0)
                {
                    if (FormInfoQueja == null)
                    {
                        Queja Q = ObtenerQueja((int)dgvQuejasActivas.SelectedRows[0].Cells[0].Value);

                        List<Seguimiento_Queja> LQ = BLL_Queja.Ver_Seguimiento_de_Queja(Q.ID);

                        foreach (Seguimiento_Queja SQ in LQ)
                        {
                            if (!Q.Estados.Exists(X=> X.Estado == SQ.Estado))
                            {
                                Q.Estados.Add(new Seguimiento_Queja(SQ.Estado, SQ.Fecha));
                            }                            
                        }

                        FormInfoQueja = new FormInfoQueja(ID, Q, this);                        
                        FormInfoQueja.FormClosed += FormInfoQueja_FormClosed;
                        FormInfoQueja.ShowDialog();
                    }
                }
                else { MessageBox.Show("No hay Quejas activas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormInfoQueja_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInfoQueja = null;
            LQ = BLL_Queja.Ver_Quejas_Activas();
            dgvQuejasActivas.Rows.Clear();
            MostrarDatosEnGrilla(dgvQuejasActivas, LQ);
        }

        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Queja> L)
        {
            try
            {
                if (L.Count != 0)
                {
                    foreach (Queja Q in L)
                    {
                        pDGV.Rows.Add(Q.ID, Q.Asunto, Q.Usuario.Nombre + " - " + Q.Usuario.Apellido + " " + Q.Usuario.NombreReal, Q.Fecha.ToShortDateString());
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; MessageBox.Show("No hay Quejas activas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            }
            catch (Exception ex) { }
        }

        public Queja ObtenerQueja(int pID)
        {
            Queja Q = LQ.Find(X => X.ID == pID);
            return Q;
        }
    }
}
