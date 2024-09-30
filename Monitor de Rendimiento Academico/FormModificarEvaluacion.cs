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
    public partial class FormModificarEvaluacion : Form
    {
        public FormModificarEvaluacion(int pKey, Materia pMateria, Evaluacion pEvaluacion)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Materia = pMateria;
            Evaluacion = pEvaluacion;
        }

        public int ID;
        public Materia Materia;
        public Evaluacion Evaluacion;
        public BLL_Materia BLL_Materia;
        public List<Tema> TemasDeMateria, TemasDeEvaluacion;

        private void FormModificarEvaluacion_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Materia = new BLL_Materia();

            TemasDeMateria = BLL_Materia.Ver_Temas_De_Materia(Materia);

            TemasDeEvaluacion = BLL_Materia.Ver_Temas_de_Evaluacion(Evaluacion);

            MostrarTemasEnListBox(listBoxTemasMateria, TemasDeMateria);
            MostrarTemasEnListBox(listBoxTemasEvaluacion, TemasDeEvaluacion);

            txtBoxTitulo.Text = Evaluacion.Titulo;
            SelectorFechaIngreso.Value = Evaluacion.Fecha;

            if (listBoxTemasMateria.Items.Count > 0)
            {
                listBoxTemasMateria.SetSelected(0, true);
            }

            if (listBoxTemasEvaluacion.Items.Count > 0)
            {
                listBoxTemasEvaluacion.SetSelected(0, true);
            }
        }
        public void MostrarTemasEnListBox(ListBox pListBox, List<Tema> pLT)
        {
            try
            {
                if (pLT.Count > 0)
                {
                    foreach (Tema T in pLT)
                    {
                        pListBox.Items.Add(T.Codigo + "-" + T.Nombre);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAgregarTema_Click(object sender, EventArgs e)
        {
            try
            {
                Tema T = ObtenerTema(int.Parse(listBoxTemasMateria.SelectedItem.ToString().Substring(0, listBoxTemasMateria.SelectedItem.ToString().IndexOf("-"))));

                if (!(TemasDeEvaluacion.Exists(X => X.Codigo == T.Codigo)))
                {
                    TemasDeEvaluacion.Add(T);
                    listBoxTemasEvaluacion.Items.Add(T.Codigo + "-" + T.Nombre);
                    btnEliminarTema.Enabled = true;

                    if (listBoxTemasEvaluacion.SelectedIndex == -1)
                    {
                        listBoxTemasEvaluacion.SelectedIndex = 0;
                    }
                }
                else { throw new Exception("Este Tema ya fue agregado anteriormente"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnEliminarTema_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTemasEvaluacion.Items.Count != 0)
                {
                    Tema T = ObtenerTema(int.Parse(listBoxTemasEvaluacion.SelectedItem.ToString().Substring(0, listBoxTemasEvaluacion.SelectedItem.ToString().IndexOf("-"))));

                    if (TemasDeEvaluacion.Exists(X => X.Codigo == T.Codigo))
                    {
                        TemasDeEvaluacion.RemoveAll(X => X.Codigo == T.Codigo);

                        listBoxTemasEvaluacion.Items.Clear();

                        if (TemasDeEvaluacion.Count != 0)
                        {
                            foreach (Tema tema in TemasDeEvaluacion)
                            {
                                listBoxTemasEvaluacion.Items.Add(tema.Codigo + "-" + tema.Nombre);
                            }
                        }

                        if (listBoxTemasEvaluacion.SelectedIndex == -1)
                        {
                            listBoxTemasEvaluacion.SelectedIndex = 0;
                        }
                    }
                    //else { throw new Exception("El Dictado no posee al Docente seleccionado"); }
                }
                else { btnEliminarTema.Enabled = false; }
            }
            catch (Exception) { }
        }

        private void btnModificarEvaluacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxTitulo.Text != "" && TemasDeEvaluacion.Count > 0)
                {
                    DateTime FechaEvaluacion = SelectorFechaIngreso.Value;
                    Evaluacion.Titulo = txtBoxTitulo.Text;
                    Evaluacion.Fecha = FechaEvaluacion;
                    Modificar_Evaluacion(Evaluacion, TemasDeEvaluacion);
                    LogManager.Escribir(ID, "Modificó la Evaluación" + Evaluacion.Codigo.ToString(), 3);
                    MessageBox.Show("La Evaluación fue modificada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else { throw new Exception("Debe rellenar todos los campos"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public void Modificar_Evaluacion(Evaluacion pEvaluacion, List<Tema> pTemas)
        {
            BLL_Materia.Modificar_Evaluacion(pEvaluacion, pTemas);
        }

        public Tema ObtenerTema(int pCodigo)
        {
            Tema T = TemasDeMateria.Find(X => X.Codigo == pCodigo);
            return T;
        }
    }
}
