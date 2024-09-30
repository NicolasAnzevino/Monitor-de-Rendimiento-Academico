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
using System.Configuration;
using System.Data.SqlClient;
using Servicios;
using System.IO;

namespace Monitor_de_Rendimiento_Academico
{
    public partial class FormSelectorServidor : Form
    {
        public FormSelectorServidor()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void FormSelectorServidor_Load(object sender, EventArgs e)
        {
            try
            {
                dgvServidoresDetectados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvServidoresDetectados.DataSource = DatabaseCreatorManager.ObtenerServidores();
                dgvServidoresDetectados.Enabled = false;
                EliminarColumnasAdicionales();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void EliminarColumnasAdicionales()
        {
            int count = dgvServidoresDetectados.Columns.Count - 1;

            for (int i = count; i >= 1; i--)
            {
                dgvServidoresDetectados.Columns[i].Visible = false;
            }
        }

        private void btnSeleccionarServidor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNombreServidor.Text != "")
                {
                    if (MessageBox.Show("¿Está seguro de crear la Base de Datos en el servidor " + txtBoxNombreServidor.Text + "?", "Solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                    {
                        FileStream FS = new FileStream("ServerName.txt", FileMode.Open, FileAccess.Write);
                        StreamWriter SW = new StreamWriter(FS);
                        SW.Write(txtBoxNombreServidor.Text);                        
                        SW.Close();

                        MessageBox.Show("Se ha almacenado el nombre del Servidor correctamente\n\n Vuelva a iniciar la aplicación", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }                    
                }
                else { throw new Exception("Debe rellenar todos los campos"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }  
}
