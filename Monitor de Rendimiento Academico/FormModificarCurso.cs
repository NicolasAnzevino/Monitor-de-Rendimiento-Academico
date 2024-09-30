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
    public partial class FormModificarCurso : Form
    {
        public FormModificarCurso(int pKey, Curso pCurso)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Curso = pCurso;
        }

        public int ID;
        public Curso Curso;
        public BLL_Curso BLL_Curso;
        BLL_Turno BLL_Turno;
        List<Turno> LT;

        private void FormModificarCurso_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Curso = new BLL_Curso();
            BLL_Turno = new BLL_Turno();

            txtBoxNombre.Text = Curso.Nombre;
            txtBoxAno.Text = Curso.Año.ToString();           

            LT = BLL_Turno.Ver_Turnos();

            if (LT.Count > 0)
            {
                Mostrar_Turnos(LT);
            }
            txtBoxAno.MaxLength = 4;
        }

        private void txtBoxAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnModificarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (LT.Count>0)
                {
                    if (!string.IsNullOrEmpty(comboBoxTurno.Text))
                    {
                        string item = (string)comboBoxTurno.SelectedItem;

                        Turno T = ObtenerTurno(int.Parse(item.Substring(0, item.ToString().IndexOf("-"))));

                        if (!(txtBoxNombre.Text == "" || txtBoxAno.Text == "" || item == null))
                        {
                            if (BLL_Curso.Comprobar_Unicidad_Codigo(txtBoxNombre.Text) == 0 || txtBoxNombre.Text == Curso.Nombre)
                            {
                                ModificarCurso(txtBoxNombre.Text, int.Parse(txtBoxAno.Text), T);
                                MessageBox.Show("Se ha modificado el Curso " + txtBoxNombre.Text + " con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LogManager.Escribir(ID, "Modificó el Curso " + Curso.Codigo.ToString(), 3);
                                txtBoxNombre.Text = "";
                                txtBoxAno.Text = "";
                                this.Close();
                            }
                            else { throw new Exception("El nombre ingresado ya está en uso"); }
                        }
                        else { throw new Exception("Debe rellenar todos los campos"); }
                    }                    
                }                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void ModificarCurso(string pNombre, int pAño, Turno pTurno)
        {
            try
            {
                Curso.Nombre = pNombre;
                Curso.Año = pAño;
                Curso.Turno = pTurno;
                BLL_Curso.Modificar_Curso(Curso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }       

        private void comboBoxTurno_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Mostrar_Turnos(List<Turno> pLT)
        {
            foreach (Turno T in pLT)
            {
                comboBoxTurno.Items.Add(T.ID.ToString() + " - " + T.Nombre.ToString());
            }
        }

        public Turno ObtenerTurno(int pCodigo)
        {
            Turno T = LT.Find(X => X.ID == pCodigo);
            return T;
        }

    }
}
