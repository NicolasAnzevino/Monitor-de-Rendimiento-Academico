using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FormVerBitacoraDeCambios : Form
    {
        public FormVerBitacoraDeCambios(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;
        public DataTable DT;
        FormVerUsuariosModificados FormVerUsuariosModificados;

        private void FormVerBitacoraDeCambios_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            txtBoxFecha.Mask = "00/00/0000";

            lblBuscar.Visible = false;
            txtBoxFecha.Visible = false;
            btnBuscar.Visible = false;

            DT = LogManager.Ver_Logs();
            DT.PrimaryKey = new DataColumn[] { DT.Columns[0] };

            if (DT.Rows.Count==0)
            {
                MessageBox.Show("No hay acciones realizadas en el sistema", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MostrarDatosEnGrilla(dgvBitacora, DT);
                dgvBitacora_Click(null, null);
            }

            txtBoxDNI.Select(0, 0);
        }

        private void dgvBitacora_Click(object sender, EventArgs e)
        {
            if (dgvBitacora.Rows.Count>0)
            {
                DataRow DR = ObtenerDR((int)dgvBitacora.SelectedRows[0].Cells[0].Value);

                txtBoxApellido.Text = DR.Field<string>(6);
                txtBoxDNI.Text = DR.Field<int>(5).ToString();
                txtBoxNombre.Text = DR.Field<string>(7);
            }            
        }

        public void MostrarDatosEnGrilla(DataGridView pDGV, DataTable pDT)
        {
            try
            {
                int Pos = 0;

                if (pDT.Rows.Count != 0)
                {
                    foreach (DataRow DR in pDT.Rows)
                    {
                        pDGV.Rows.Add(DR.Field<int>(0), DR.Field<string>(1), DR.Field<DateTime>(2).ToShortDateString() + " - " + DR.Field<DateTime>(2).ToLongTimeString(), DR.Field<int>(3), DR.Field<string>(4));

                        if (DR.Field<int>(3) == 1)
                        {
                            dgvBitacora.Rows[Pos].Cells[3].Style.BackColor = Color.Red;
                        }
                        else if (DR.Field<int>(3) == 2)
                        {
                            dgvBitacora.Rows[Pos].Cells[3].Style.BackColor = Color.Yellow;
                        }
                        else if (DR.Field<int>(3) == 3)
                        {
                            dgvBitacora.Rows[Pos].Cells[3].Style.BackColor = Color.Green;
                        }

                        Pos++;
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        } 

        public DataRow ObtenerDR(int pID)
        {
            DataRow DR = DT.Rows.Find(pID);
            return DR;
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbTodos.Checked==true)
                {
                    dgvBitacora.Rows.Clear();

                    txtBoxFecha.Text = "";
                    txtBoxFecha.Visible = false;
                    lblBuscar.Visible = false;
                    btnBuscar.Visible = false;

                    DT = LogManager.Ver_Logs();
                    DT.PrimaryKey = new DataColumn[] { DT.Columns[0] };

                    if (DT.Rows.Count == 0)
                    {
                        MessageBox.Show("No hay acciones realizadas en el sistema", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MostrarDatosEnGrilla(dgvBitacora, DT);
                        dgvBitacora_Click(null, null);
                    }

                    txtBoxDNI.Select(0, 0);
                }

                
            }
            catch (Exception) {}
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbFecha.Checked == true)
                {
                    dgvBitacora.Rows.Clear();

                    txtBoxFecha.Text = "";
                    txtBoxFecha.Visible = true;
                    lblBuscar.Visible = true;
                    btnBuscar.Visible = true;
                }
            }
            catch (Exception) { }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable DT = LogManager.Ver_Logs_Fecha(DateTime.Parse(txtBoxFecha.Text));
                MostrarDatosEnGrilla(dgvBitacora, DT);
            }
            catch (Exception) { }
        }

        private void btnVerModificacionesUs_Click(object sender, EventArgs e)
        {
            if (FormVerUsuariosModificados is null)
            {
                FormVerUsuariosModificados = new FormVerUsuariosModificados(ID);
                FormVerUsuariosModificados.FormClosed += FormVerUsuariosModificados_FormClosed;
                FormVerUsuariosModificados.ShowDialog();
            }
        }

        private void FormVerUsuariosModificados_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerUsuariosModificados = null;
        }
    }
}
