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
    public partial class FormAgregarEvaluacion : Form
    {
        public FormAgregarEvaluacion(int pKey, Materia pMateria)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Materia = pMateria;
        }

        public int ID;
        public Curso Curso;
        public Materia Materia;
        public BLL_Materia BLL_Materia;
        public List<Tema> TemasDeMateria, TemasDeEvaluacion;

        private void FormAgregarEvaluacion_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Materia = new BLL_Materia();

            TemasDeMateria = BLL_Materia.Ver_Temas_De_Materia(Materia);

            TemasDeEvaluacion = new List<Tema>();

            MostrarTemasEnListBox();

            btnEliminarTema.Enabled = false;

            if (listBoxTemasMateria.Items.Count > 0)
            {
                listBoxTemasMateria.SetSelected(0, true);
            }
        }

        private void btnAgregarTema_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTemasMateria.Items.Count>0)
                {
                    Tema T = ObtenerTema(int.Parse(listBoxTemasMateria.SelectedItem.ToString().Substring(0, listBoxTemasMateria.SelectedItem.ToString().IndexOf("-"))));

                    if (!(TemasDeEvaluacion.Exists(X => X.Codigo == T.Codigo)))
                    {
                        TemasDeEvaluacion.Add(T);
                        listBoxTemasEvaluacion.Items.Add(T.Codigo + "-" + T.Nombre);
                        btnEliminarTema.Enabled = true;

                        if (listBoxTemasEvaluacion.SelectedIndex == -1)
                        {
                            listBoxTemasEvaluacion.SetSelected(0, true);
                        }
                    }
                    else { throw new Exception("Este Tema ya fue agregado anteriormente"); }
                }
                else { throw new Exception("La Materia no posee Temas"); }
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
                        TemasDeEvaluacion.Remove(T);

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

        public void MostrarTemasEnListBox()
        {
            try
            {
                if (TemasDeMateria.Count>0)
                {
                    foreach (Tema T in TemasDeMateria)
                    {
                        listBoxTemasMateria.Items.Add(T.Codigo + "-" + T.Nombre);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAgregarEvaluacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (TemasDeEvaluacion.Count> 0 && txtBoxTituloEval.Text != "")
                {
                    DateTime FechaEvaluacion = SelectorFechaIngreso.Value.Date;
                    Agregar_Evaluacion(txtBoxTituloEval.Text, FechaEvaluacion, TemasDeEvaluacion, Materia);
                    LogManager.Escribir(ID, "Agregó una Evaluación en la Materia" + Materia.Codigo.ToString() + "-" + Materia.Nombre, 3);
                    this.Close();
                }
                else { throw new Exception("Debe rellenar todos los campos"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public Tema ObtenerTema(int pCodigo)
        {
            Tema T = TemasDeMateria.Find(X => X.Codigo == pCodigo);
            return T;
        }

        public void Agregar_Evaluacion(string pTitulo, DateTime pFecha, List<Tema> pTemas, Materia pMateria)
        {
            BLL_Materia.Crear_Evaluacion_de_Materia(pTitulo, pFecha, pTemas, pMateria);
        }
    }
}
