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
    public partial class FormVerUsuariosBloqueados : Form
    {
        public FormVerUsuariosBloqueados(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();
            ID = pKey;
        }

        public int ID;

        BLL_Usuario BLL_Usuario;

        private void FormVerUsuariosBloqueados_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            BLL_Usuario = new BLL_Usuario();

            MostrarEnGrilla(dgvCuentasBloqueadas, BLL_Usuario.Ver_Usuarios_Bloqueados());       
            
            if (ComprobarCuentasBloqueadas()==false)
            {
                MessageBox.Show("No hay Usuarios Bloqueados");
            }
        }

        public void MostrarEnGrilla(DataGridView pDGV, List<Usuario> L)
        {
            try
            {
                if (L.Count != 0)
                {
                    foreach (Usuario U in L)
                    {
                        pDGV.Rows.Add(U.Nombre, U.Rol.Nombre);
                    }
                }
                else { dgvCuentasBloqueadas.Rows.Clear(); dgvCuentasBloqueadas.DataSource = null; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }            
        }

        public void Desbloquear_Cuenta(string pUsername)
        {
            try
            {
                BLL_Usuario.Desbloquear_Cuenta(pUsername);
                MostrarEnGrilla(dgvCuentasBloqueadas, BLL_Usuario.Ver_Usuarios_Bloqueados());
                LogManager.Escribir(ID, "Desbloqueó al Usuario " + pUsername, 2);
                MessageBox.Show("El Usuario " + pUsername + " fue desbloqueado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }     
        
        public bool ComprobarCuentasBloqueadas()
        {
            bool B = false; //FALSE -> NO HAY || TRUE -> SÍ HAY

            if (dgvCuentasBloqueadas.Rows.Count>0)
            {
                B = true;
            }

            return B;
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCuentasBloqueadas.Rows.Count != 0)
                {
                    Desbloquear_Cuenta((string)dgvCuentasBloqueadas.Rows[0].Cells[0].Value);
                } 
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        
    }
}
