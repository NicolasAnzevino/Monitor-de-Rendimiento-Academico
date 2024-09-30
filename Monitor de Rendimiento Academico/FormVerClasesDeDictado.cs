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
    public partial class FormVerClasesDeDictado : Form
    {
        public FormVerClasesDeDictado(int pKey, Dictado pDictado)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
            Dictado = pDictado;
        }

        public int ID;
        public Curso Curso;
        public Dictado Dictado;
        public BLL_Dictado BLL_Dictado;
        public List<Clase> Clases;        

        private void FormVerClasesDeDictado_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            txtBoxBuscar.Mask = "00/00/0000";

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Dictado = new BLL_Dictado();

            lblBuscar.Visible = false;
            txtBoxBuscar.Visible = false;

            Clases = BLL_Dictado.Ver_Clases_de_Dictado(Dictado);

            if (Clases.Count>0)
            {
                MostrarDatosEnGrilla(dgvClases, Clases);
                dgvClases_Click(null, null);
                txtBoxDescripcionClase.Select(0, 0);
            }
            else { MessageBox.Show("Este Dictado no posee clases", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
        }
        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Clase> pLC)
        {
            try
            {
                if (pLC.Count != 0)
                {
                    foreach (Clase C in pLC)
                    {
                        pDGV.Rows.Add(C.Codigo, C.Fecha.ToShortDateString());
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Clase ObtenerClase(int pID)
        {
            Clase C = Clases.Find(X => X.Codigo == pID);
            return C;
        }

        public Tema ObtenerTema(Clase pClase,int pID)
        {
            Tema T = pClase.Temas.Find(X => X.Codigo == pID);
            return T;
        }

        private void dgvClases_Click(object sender, EventArgs e)
        {
            try
            {
                Clase C = ObtenerClase((int)dgvClases.SelectedRows[0].Cells[0].Value);

                listBoxTemasClase.Items.Clear();
                txtBoxDescripcionClase.Text = "";
                txtBoxDescripcionClase.Text = C.Descripcion;

                foreach (Tema T in C.Temas)
                {
                    listBoxTemasClase.Items.Add(T.Codigo + " - " + T.Nombre);
                }
            }
            catch (Exception) {}
        }

        private void listBoxTemasClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtDescripcionTema.Text = "";

                if (listBoxTemasClase.Items.Count>0)
                {
                    if (listBoxTemasClase.SelectedIndex != -1)
                    {
                        Clase C = ObtenerClase((int)dgvClases.SelectedRows[0].Cells[0].Value);

                        Tema T = ObtenerTema(C, int.Parse((listBoxTemasClase.SelectedItem.ToString().Substring(0, listBoxTemasClase.SelectedItem.ToString().IndexOf("-")))));
                        txtDescripcionTema.Text = T.Descripcion;
                    }                    
                }                
            }
            catch (Exception) {}
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked == true)
            {
                lblBuscar.Visible = false;
                txtBoxBuscar.Text = "";
                txtBoxBuscar.Visible = false;

                dgvClases.Rows.Clear();
                Clases = BLL_Dictado.Ver_Clases_de_Dictado(Dictado);

                if (Clases.Count > 0)
                {
                    MostrarDatosEnGrilla(dgvClases, Clases);
                    dgvClases_Click(null, null);
                    txtBoxDescripcionClase.Select(0, 0);
                }
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
                txtBoxDescripcionClase.Text = "";
                txtDescripcionTema.Text = "";
                listBoxTemasClase.Items.Clear();

                dgvClases.Rows.Clear();
                MostrarDatosEnGrilla(dgvClases, BLL_Dictado.Ver_Clases_Fecha(Clases, DateTime.Parse(txtBoxBuscar.Text)));

                if (dgvClases.Rows.Count > 0)
                {
                    dgvClases_Click(null, null);
                    txtBoxDescripcionClase.Select(0, 0);
                }
            }
            catch (Exception) {}
        }
    }
}
