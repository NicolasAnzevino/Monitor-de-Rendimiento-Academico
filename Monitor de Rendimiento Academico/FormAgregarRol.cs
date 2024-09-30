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
    public partial class FormAgregarRol : Form
    {
        public FormAgregarRol(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;

        BLL_Usuario BLL_Usuario;
        BLL_Rol BLL_Rol;
        List<Permiso> LP, PermisosSeleccionados;

        private void FormAgregarRol_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Usuario = new BLL_Usuario();
            BLL_Rol = new BLL_Rol();

            LP = BLL_Rol.Ver_Permisos();
            PermisosSeleccionados = new List<Permiso>();

            Mostrar_Permisos(LP, listBoxPermisos);

            listBoxPermisos.Sorted = true;

            if (listBoxPermisos.Items.Count>0)
            {
                listBoxPermisos.SetSelected(0, true);
            }
        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                Permiso P = ObtenerPermiso((int.Parse(listBoxPermisos.SelectedItem.ToString().Substring(0, listBoxPermisos.SelectedItem.ToString().IndexOf("-")))));

                if (!(PermisosSeleccionados.Exists(X=> X.ID == P.ID)))
                {
                    PermisosSeleccionados.Add(P);
                    Mostrar_Permisos(PermisosSeleccionados, listBoxPermisosSeleccionados);
                    listBoxPermisosSeleccionados.SetSelected(0, true);
                }
                else { throw new Exception("Este permiso ya fue agregado anteriormente"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnQuitarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                Permiso P = ObtenerPermiso((int.Parse(listBoxPermisosSeleccionados.SelectedItem.ToString().Substring(0, listBoxPermisosSeleccionados.SelectedItem.ToString().IndexOf("-")))));

                if (PermisosSeleccionados.Exists(X => X.ID == P.ID))
                {
                    PermisosSeleccionados.Remove(P);
                    Mostrar_Permisos(PermisosSeleccionados, listBoxPermisosSeleccionados);

                    if (listBoxPermisosSeleccionados.Items.Count>0)
                    {
                        listBoxPermisosSeleccionados.SetSelected(0, true);
                    }
                }
                else { }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Mostrar_Permisos(List<Permiso> pLP, ListBox pListBox)
        {
            try
            {
                pListBox.Items.Clear();

                foreach (Permiso P in pLP)
                {
                    pListBox.Items.Add(P.ID + " - " + P.Codigo);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listBoxPermisos_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPermisosKit.Items.Clear();

            Permiso P = ObtenerPermiso((int.Parse(listBoxPermisos.SelectedItem.ToString().Substring(0, listBoxPermisos.SelectedItem.ToString().IndexOf("-")))));

            if (P is PermisoCompuesto)
            {
                List<Permiso> LPRepe = P.RetornaPermisos();
                List<Permiso> LPSinRepe = new List<Permiso>();

                foreach (Permiso Permiso in LPRepe)
                {
                    if (!(LPSinRepe.Exists(X=> X.ID == Permiso.ID)))
                    {
                        LPSinRepe.Add(Permiso);
                    }
                }

                Mostrar_Permisos(LPSinRepe, listBoxPermisosKit);
            }
            else
            {
                listBoxPermisosKit.Items.Clear();
            }
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxIngreseNombreRol.Text != "")
                {
                    if (BLL_Rol.Verificar_Nombre(txtBoxIngreseNombreRol.Text) == false)
                    {
                        if (PermisosSeleccionados.Count > 0)
                        {
                            Agregar_Rol(txtBoxIngreseNombreRol.Text);
                            LogManager.Escribir(ID, "Creó el Rol " + txtBoxIngreseNombreRol.Text, 2);
                            MessageBox.Show("Se ha creado el Rol " + txtBoxIngreseNombreRol.Text + " con éxito", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtBoxIngreseNombreRol.Text = "";
                            PermisosSeleccionados.Clear();
                            Mostrar_Permisos(LP, listBoxPermisos);
                            listBoxPermisosKit.Items.Clear();
                            Mostrar_Permisos(PermisosSeleccionados, listBoxPermisosSeleccionados);

                            if (listBoxPermisos.Items.Count > 0)
                            {
                                listBoxPermisos.SetSelected(0, true);
                            }
                        }
                        else { throw new Exception("Debe seleccionarse mínimamente un Permiso"); }
                    }
                    else { throw new Exception("Ya existe un Rol con ese nombre"); }
                }
                else { throw new Exception("Debe rellenar todos los Campos"); }                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Agregar_Rol(string pNombre)
        {
            try
            {
                BLL_Rol.Agregar_Rol(pNombre, PermisosSeleccionados);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public Permiso ObtenerPermiso(int pID)
        {
            Permiso P = LP.Find(X => X.ID == pID);
            return P;
        }


    }
}
