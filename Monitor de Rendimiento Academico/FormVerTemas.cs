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
    public partial class FormVerTemas : Form
    {
        public FormVerTemas(int pKey, Materia pMateria)
        {
            InitializeComponent();
            this.CenterToScreen();
            ID = pKey;
            Materia = pMateria;
        }

        public int ID;
        Materia Materia;
        BLL_Materia BLL_Materia;
        List<Tema> Temas, TemasDeMateria;
        FormCrearTema FormCrearTema;
        FormModificarTema FormModificarTema;

        private void FormVerTemas_Load(object sender, EventArgs e)
        {
            if (Materia.RetornarActivo()==false)
            {
                btnAgregarAMateria.Enabled = false;
                btnModificarTema.Enabled = false;
                btnQuitarTemaDeMateria.Enabled = false;
            }

            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Materia = new BLL_Materia();

            Temas = BLL_Materia.Ver_Temas();
            TemasDeMateria = BLL_Materia.Ver_Temas_De_Materia(Materia);

            MostrarDatosEnGrilla(dgvTemas, Temas);
            MostrarDatosEnGrillaMateriaTema(dgvTemasMateria, TemasDeMateria);

            lblBusqueda.Visible = false;
            txtBoxBusqueda.Visible = false;

            if (Temas.Count==0)
            {
                MessageBox.Show("No hay Temas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvTemas_Click(null, null);
            }
        }

        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Tema> L)
        {
            try
            {
                if (L.Count != 0)
                {
                    foreach (Tema T in L)
                    {
                        pDGV.Rows.Add(T.Codigo, T.Nombre);
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void MostrarDatosEnGrillaMateriaTema(DataGridView pDGV, List<Tema> L)
        {
            try
            {
                if (L.Count != 0)
                {
                    foreach (Tema T in L)
                    {
                        pDGV.Rows.Add(T.Codigo, T.Nombre);
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null;}
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void dgvTemas_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTemas.Rows.Count>0)
                {
                    Tema T = ObtenerTema((int)dgvTemas.SelectedRows[0].Cells[0].Value);
                    txtBoxDescripcionTema.Text = "";
                    txtBoxDescripcionTema.Text = T.Descripcion;
                }
                
            }
            catch (Exception ex) {}
        }

        private void btnCrearTema_Click(object sender, EventArgs e)
        {
            if (FormCrearTema is null)
            {
                FormCrearTema = new FormCrearTema(ID, Materia);
                FormCrearTema.FormClosed += FormCrearTema_FormClosed;
                FormCrearTema.ShowDialog();
            }
        }

        private void FormCrearTema_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCrearTema = null;

            dgvTemas.Rows.Clear();
            dgvTemasMateria.Rows.Clear();
            Temas = BLL_Materia.Ver_Temas();
            TemasDeMateria = BLL_Materia.Ver_Temas_De_Materia(Materia);
            MostrarDatosEnGrilla(dgvTemas, Temas);
            MostrarDatosEnGrillaMateriaTema(dgvTemasMateria, TemasDeMateria);
        }
        private void btnAgregarAMateria_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTemas.Rows.Count>0)
                {
                    Tema T = ObtenerTema((int)dgvTemas.SelectedRows[0].Cells[0].Value);
                    AgregarTemaAMateria(T);
                    MessageBox.Show("Se ha agregado el Tema " + T.Nombre + " a la Materia " + Materia.Nombre, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogManager.Escribir(ID, "Agregó el Tema " + T.Nombre + " a la Materia " + Materia.Nombre, 3);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public Tema ObtenerTema(int pID)
        {
            Tema T = Temas.Find(X => X.Codigo == pID);
            return T;
        }

        private void btnQuitarTemaDeMateria_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTemasMateria.Rows.Count > 0)
                {
                    Tema T = ObtenerTema((int)dgvTemasMateria.SelectedRows[0].Cells[0].Value);

                    if (BLL_Materia.Comprobar_Existencia_Clases(T) == 0)
                    {
                        if (BLL_Materia.Comprobar_Existencia_Evaluaciones(T)==0)
                        {
                            QuitarTemaDeMateria(T);
                            MessageBox.Show("Se ha quitado el Tema " + T.Nombre + " de la Materia " + Materia.Nombre, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LogManager.Escribir(ID, "Quitó el Tema " + T.Nombre + " de la Materia " + Materia.Nombre, 3);
                        }
                        else { MessageBox.Show("El Tema ya existe en una Evaluacion, por lo que no se puede quitar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else { MessageBox.Show("El Tema ya existe en una Clase, por lo que no se puede quitar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void AgregarTemaAMateria(Tema T)
        {
            try
            {
                if (!(TemasDeMateria.Exists(X=> X.Codigo == T.Codigo)))
                {
                    BLL_Materia.Agregar_Tema_A_Materia(Materia, T);
                    dgvTemasMateria.Rows.Clear();
                    TemasDeMateria = BLL_Materia.Ver_Temas_De_Materia(Materia);
                    MostrarDatosEnGrillaMateriaTema(dgvTemasMateria, TemasDeMateria);
                }
                else { throw new Exception("La Materia ya posee ese Tema"); }                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void btnModificarTema_Click(object sender, EventArgs e)
        {
            if (FormModificarTema is null)
            {
                if (dgvTemas.Rows.Count>0)
                {
                    Tema T = ObtenerTema((int)dgvTemas.SelectedRows[0].Cells[0].Value);
                    FormModificarTema = new FormModificarTema(ID, T);
                    FormModificarTema.FormClosed += FormModificarTema_FormClosed;
                    FormModificarTema.ShowDialog();
                }               
            }
        }

        private void FormModificarTema_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormModificarTema = null;
            dgvTemas.Rows.Clear();
            dgvTemasMateria.Rows.Clear();
            Temas = BLL_Materia.Ver_Temas();
            TemasDeMateria = BLL_Materia.Ver_Temas_De_Materia(Materia);
            MostrarDatosEnGrilla(dgvTemas, Temas);
            MostrarDatosEnGrilla(dgvTemasMateria, TemasDeMateria);
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked == true)
            {
                Temas = BLL_Materia.Ver_Temas();
                dgvTemas.Rows.Clear();
                MostrarDatosEnGrilla(dgvTemas, Temas);

                lblBusqueda.Visible = false;
                txtBoxBusqueda.Visible = false;
            }
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCodigo.Checked==true)
            {
                lblBusqueda.Visible = true;
                txtBoxBusqueda.Visible = true;
            }     
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNombre.Checked == true)
            {
                lblBusqueda.Visible = true;
                txtBoxBusqueda.Visible = true;
            }
        }

        private void txtBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbCodigo.Checked == true)
                {
                    dgvTemas.Rows.Clear();
                    MostrarDatosEnGrilla(dgvTemas, BLL_Materia.Ver_Temas_Codigo(Temas, txtBoxBusqueda.Text));
                }
                else if (rbNombre.Checked == true)
                {
                    dgvTemas.Rows.Clear();
                    MostrarDatosEnGrilla(dgvTemas, BLL_Materia.Ver_Temas_Nombre(Temas, txtBoxBusqueda.Text));
                }             

            }
            catch (Exception) { }
        }

        public void QuitarTemaDeMateria(Tema T)
        {
            try
            {
                if (TemasDeMateria.Exists(X => X.Codigo == T.Codigo))
                {
                    BLL_Materia.Quitar_Tema_De_Materia(Materia, T);
                    dgvTemasMateria.Rows.Clear();
                    TemasDeMateria = BLL_Materia.Ver_Temas_De_Materia(Materia);
                    MostrarDatosEnGrillaMateriaTema(dgvTemasMateria, TemasDeMateria);
                }
                else { throw new Exception("La Materia no posee ese Tema"); }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
