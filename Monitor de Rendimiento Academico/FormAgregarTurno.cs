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
    public partial class FormAgregarTurno : Form
    {
        public FormAgregarTurno(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;            
        }

        public int ID;
        public BLL_Turno BLL_Turno;
        public List<Turno> LT;

        private void FormAgregarTurno_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Turno = new BLL_Turno();

            LT = BLL_Turno.Ver_Turnos();

            Mostrar_Turnos(LT, lbTurnos);
        }

        public void Mostrar_Turnos(List<Turno> pLT, ListBox pListBox)
        {
            try
            {
                pListBox.Items.Clear();

                if (pLT.Count>0)
                {
                    foreach (Turno T in pLT)
                    {
                        pListBox.Items.Add(T.Nombre);
                    }
                }                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxTurno.Text != "")
                {
                    if (BLL_Turno.Comprobar_Unicidad_Turno(txtBoxTurno.Text) == 0)
                    {
                        Agregar_Turno(txtBoxTurno.Text);
                        LogManager.Escribir(ID, "Agregó el Turno " + txtBoxTurno.Text, 3);
                        MessageBox.Show("Turno agregado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LT = BLL_Turno.Ver_Turnos();
                        Mostrar_Turnos(LT, lbTurnos);
                    }
                    else { throw new Exception("Ya existe un Turno con este Nombre"); }
                }
                else { throw new Exception("Debe ingresar un Nombre"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Agregar_Turno(string pNombre)
        {
            try
            {
                BLL_Turno.Agregar_Turno(pNombre);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
