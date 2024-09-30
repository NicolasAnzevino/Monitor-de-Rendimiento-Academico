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
    public partial class FormCrearCurso : Form
    {
        public FormCrearCurso(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;
        BLL_Curso BLL_Curso;
        BLL_Turno BLL_Turno;
        List<Turno> LT;

        private void FormCrearCurso_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            txtBoxAno.MaxLength = 4;                

            BLL_Curso = new BLL_Curso();
            BLL_Turno = new BLL_Turno();

            LT = BLL_Turno.Ver_Turnos();

            if (LT.Count > 0)
            {
                Mostrar_Turnos(LT);
            }
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (LT.Count>0)
                {
                    if (!string.IsNullOrEmpty(comboBoxTurno.Text))
                    {
                        string item = (string)comboBoxTurno.SelectedItem;

                        Turno T = ObtenerTurno(int.Parse(item.Substring(0, item.ToString().IndexOf("-"))));

                        if (!(txtBoxCodigo.Text == "" || txtBoxAno.Text == "" || item == null))
                        {
                            if (BLL_Curso.Comprobar_Unicidad_Codigo(txtBoxCodigo.Text) == 0)
                            {
                                CrearCurso(txtBoxCodigo.Text, int.Parse(txtBoxAno.Text), T);
                                MessageBox.Show("Se ha creado el Curso " + txtBoxCodigo.Text + " con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LogManager.Escribir(ID, "Creó el Curso " + txtBoxCodigo.Text, 3);
                                txtBoxCodigo.Text = "";
                                txtBoxAno.Text = "";
                            }
                            else { throw new Exception("El código ingresado ya está en uso"); }
                        }
                        else { throw new Exception("Debe rellenar todos los campos"); }
                    }
                }                   
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void CrearCurso(string pCodigo, int pAño, Turno pTurno)
        {
            try
            {
                BLL_Curso.Crear_Curso(pCodigo,pAño,pTurno); 
            }
            catch (Exception ex) { throw new Exception(ex.Message); }            
        }

        private void txtBoxAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void comboBoxTurno_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void comboBoxTurno_SelectedIndexChanged(object sender, EventArgs e)
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
