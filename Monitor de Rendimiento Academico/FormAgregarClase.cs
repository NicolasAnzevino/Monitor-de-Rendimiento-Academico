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
    public partial class FormAgregarClase : Form
    {
        public FormAgregarClase(int pKey, Dictado pDictado, Materia pMateria)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
            Dictado = pDictado;
            Materia = pMateria;
        }

        public int ID;
        public Curso Curso;
        public Materia Materia;
        public Dictado Dictado;
        public BLL_Materia BLL_Materia;
        public BLL_Dictado BLL_Dictado;
        public List<Tema> TemasDeMateria, TemasDeEvaluacion;

        private void FormAgregarClase_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Materia = new BLL_Materia();
            BLL_Dictado = new BLL_Dictado();

            TemasDeMateria = BLL_Materia.Ver_Temas_De_Materia(Materia);

            TemasDeEvaluacion = new List<Tema>();

            SelectorFechaIngreso.Value = DateTime.Now;

            MostrarTemasEnListBox();

            btnEliminarTema.Enabled = false;

            if (listBoxTemasMateria.Items.Count > 0)
            {
                listBoxTemasMateria.SetSelected(0, true);
            }
        }
        public void MostrarTemasEnListBox()
        {
            try
            {
                if (TemasDeMateria.Count > 0)
                {
                    foreach (Tema T in TemasDeMateria)
                    {
                        listBoxTemasMateria.Items.Add(T.Codigo + "-" + T.Nombre);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAgregarTema_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTemasMateria.Items.Count > 0)
                {
                    Tema T = ObtenerTema(int.Parse(listBoxTemasMateria.SelectedItem.ToString().Substring(0, listBoxTemasMateria.SelectedItem.ToString().IndexOf("-"))));

                    if (!(TemasDeEvaluacion.Exists(X => X.Codigo == T.Codigo)))
                    {
                        TemasDeEvaluacion.Add(T);
                        listBoxTemasClase.Items.Add(T.Codigo + "-" + T.Nombre);
                        btnEliminarTema.Enabled = true;

                        if (listBoxTemasClase.SelectedIndex == -1)
                        {
                            listBoxTemasClase.SetSelected(0, true);
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
                if (listBoxTemasClase.Items.Count != 0)
                {
                    Tema T = ObtenerTema(int.Parse(listBoxTemasClase.SelectedItem.ToString().Substring(0, listBoxTemasClase.SelectedItem.ToString().IndexOf("-"))));

                    if (TemasDeEvaluacion.Exists(X => X.Codigo == T.Codigo))
                    {
                        TemasDeEvaluacion.Remove(T);

                        listBoxTemasClase.Items.Clear();

                        if (TemasDeEvaluacion.Count != 0)
                        {
                            foreach (Tema tema in TemasDeEvaluacion)
                            {
                                listBoxTemasClase.Items.Add(tema.Codigo + "-" + tema.Nombre);
                            }
                        }

                        if (listBoxTemasClase.SelectedIndex == -1)
                        {
                            listBoxTemasClase.SelectedIndex = 0;
                        }
                    }
                    //else { throw new Exception("El Dictado no posee al Docente seleccionado"); }
                }
                else { btnEliminarTema.Enabled = false; }
            }
            catch (Exception) { }
        }

        private void btnAgregarClase_Click(object sender, EventArgs e)
        {
            try
            {
                if (TemasDeEvaluacion.Count > 0 && txtBoxDescripcion.Text != "")
                {
                    DateTime FechaClase = SelectorFechaIngreso.Value.Date;

                    if (BLL_Dictado.Verificar_Existencia_de_Clase(FechaClase,Dictado)==0)
                    {
                        Agregar_Clase(txtBoxDescripcion.Text, FechaClase, TemasDeEvaluacion, Dictado);
                        LogManager.Escribir(ID, "Agregó una Clase en el Dictado" + Dictado.Codigo.ToString() + "-" + Materia.Nombre, 3);
                        this.Close();
                    }
                    else { throw new Exception("Ya se ingresó una clase en la fecha ingresada"); }                    
                }
                else { throw new Exception("Debe rellenar todos los campos"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Agregar_Clase(string pDescripcion, DateTime pFecha, List<Tema> pTemas, Dictado pDictado)
        {
            BLL_Dictado.Agregar_Clase(pDescripcion, pFecha, pTemas, pDictado);
        }

        public Tema ObtenerTema(int pCodigo)
        {
            Tema T = TemasDeMateria.Find(X => X.Codigo == pCodigo);
            return T;
        }
    }
}
