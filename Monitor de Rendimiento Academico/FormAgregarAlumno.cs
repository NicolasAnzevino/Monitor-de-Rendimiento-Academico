using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;
using Entidades;
using BLL;
using System.Globalization;

namespace Monitor_de_Rendimiento_Academico
{
    public partial class FormAgregarAlumno : Form
    {
        public FormAgregarAlumno(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;
        List<Usuario> LU;
        List<Turno> LT;

        BLL_Usuario BLL_Usuario;
        BLL_Alumno BLL_Alumno;
        BLL_Turno BLL_Turno;

        private void FormAgregarAlumno_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Usuario = new BLL_Usuario();
            BLL_Alumno = new BLL_Alumno();
            BLL_Turno = new BLL_Turno();

            txtBoxDNI.MaxLength = 8;

            LU = BLL_Usuario.Ver_Usuarios_Disponible_Alumno();
            MostrarEnGrilla(dgvUsuariosHabilitados, LU);

            if (dgvUsuariosHabilitados.Rows.Count>0)
            {
                dgvUsuariosHabilitados_CellClick(null, null);
            }

            LT = BLL_Turno.Ver_Turnos();

            if (LT.Count>0)
            {
                Mostrar_Turnos(LT);
            }

            lblBuscar.Visible = false;
            txtBoxBuscar.Visible = false;
        }

        private void brnCrearAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuariosHabilitados.Rows.Count>0)
                {
                    if (LT.Count>0)
                    {
                        Usuario U = ObtenerUsuario((int)dgvUsuariosHabilitados.SelectedRows[0].Cells[0].Value);

                        if (!string.IsNullOrEmpty(comboBoxTurnos.Text))
                        {
                            string item = (string)comboBoxTurnos.SelectedItem;

                            Turno T = ObtenerTurno(int.Parse(item.Substring(0, item.ToString().IndexOf("-"))));

                            if (txtBoxLegajo.Text != "" && txtBoxCorreoElectronico.Text != "" && item != null)
                            {
                                if (BLL_Alumno.Verificar_Unicidad_Legajo(txtBoxLegajo.Text) == false) //TRUE EXISTE - FALSE NO
                                {
                                    if (Verificar_Email(txtBoxCorreoElectronico.Text) == true)
                                    {
                                        DateTime FechaIngreso = SelectorFechaIngreso.Value.Date;
                                        DateTime FechaNacimiento = SelectorFechaNacimiento.Value.Date;

                                        if (FechaIngreso > FechaNacimiento)
                                        {
                                            Agregar_Alumno(txtBoxLegajo.Text, int.Parse(txtBoxDNI.Text), txtBoxCorreoElectronico.Text, txtBoxNombre.Text, txtBoxApellido.Text, T.ID, FechaIngreso, FechaNacimiento, U);
                                            dgvUsuariosHabilitados_CellClick(null, null);
                                            txtBoxLegajo.Text = "";
                                            txtBoxCorreoElectronico.Text = "";
                                            comboBoxTurnos.Text = "";
                                        }
                                        else { throw new Exception("La fecha de ingreso no puede ser menor a la fecha de nacimiento"); }
                                    }
                                    else { throw new Exception("Debe ingresar un Correo Electrónico válido"); }
                                }
                                else { throw new Exception("Ese Legajo ya está en uso"); }
                            }
                            else { throw new Exception("Debe rellenar todos los campos"); }
                        }
                    }
                        
                    else { throw new Exception("No hay Turnos cargados"); }
                } else { throw new Exception("No hay Usuarios a los que asociar el Alumno"); }              
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Agregar_Alumno(string pLegajo, int pDNI, string pCorreoElectronico, string pNombre, string pApellido, int pTurno, DateTime pFechaIngreso, DateTime pFechaNacimiento, Usuario pUsuario)
        {
            try
            {
                BLL_Alumno.Agregar_Alumno(pLegajo, pDNI, pCorreoElectronico, pNombre, pApellido, pTurno, pFechaIngreso, pFechaNacimiento, pUsuario);
                MessageBox.Show("Se ha creado el Alumno correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogManager.Escribir(ID, "Ha creado al Alumno con Legajo " + pLegajo, 3);
                LU = BLL_Usuario.Ver_Usuarios_Disponible_Alumno();
                dgvUsuariosHabilitados.Rows.Clear();
                MostrarEnGrilla(dgvUsuariosHabilitados, LU);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void MostrarEnGrilla(DataGridView pDGV, List<Usuario> L)
        {
            try
            {
                if (L.Count != 0)
                {
                    foreach (Usuario U in L)
                    {
                        pDGV.Rows.Add(U.ID, U.Nombre, U.Apellido + " " + U.NombreReal, U.Rol.Nombre);
                    }
                }
                else { dgvUsuariosHabilitados.Rows.Clear(); dgvUsuariosHabilitados.DataSource = null; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public Usuario ObtenerUsuario(int pID)
        {
            Usuario U = LU.Find(X => X.ID == pID);
            return U;
        }

        private void dgvUsuariosHabilitados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvUsuariosHabilitados.Rows.Count>0)
                {
                    Usuario U = ObtenerUsuario((int)dgvUsuariosHabilitados.SelectedRows[0].Cells[0].Value);
                    txtBoxDNI.Text = U.DNI.ToString();
                    txtBoxNombre.Text = U.NombreReal.ToString();
                    txtBoxApellido.Text = U.Apellido.ToString();
                }                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void comboBoxTurnos_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Verificar_Email(string pEmail)
        {
            bool B = false;

            Regex R = new Regex(@"[a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+");
            if (R.IsMatch(pEmail))
            {
                B = true;
            }

            return B;            
        }

        private void rbUsuariosTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblBuscar.Visible = false;
            txtBoxBuscar.Visible = false;
            txtBoxBuscar.Text = "";

            dgvUsuariosHabilitados.Rows.Clear();
            LU = BLL_Usuario.Ver_Usuarios_Disponible_Alumno();
            MostrarEnGrilla(dgvUsuariosHabilitados, LU);
        }

        private void rbUsuariosNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuariosNombre.Checked == true)
            {
                if (lblBuscar.Visible == false)
                {
                    lblBuscar.Visible = true;
                }

                if (txtBoxBuscar.Visible == false)
                {
                    txtBoxBuscar.Visible = true;
                }
            }
        }

        private void rbUsuariosRol_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuariosRol.Checked == true)
            {
                if (lblBuscar.Visible == false)
                {
                    lblBuscar.Visible = true;
                }

                if (txtBoxBuscar.Visible == false)
                {
                    txtBoxBuscar.Visible = true;
                }
            }
        }

        private void rbUsuariosDNI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuariosDNI.Checked == true)
            {
                if (lblBuscar.Visible == false)
                {
                    lblBuscar.Visible = true;
                }

                if (txtBoxBuscar.Visible == false)
                {
                    txtBoxBuscar.Visible = true;
                }
            }
        }

        private void rbUsuariosApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuariosApellido.Checked == true)
            {
                if (lblBuscar.Visible == false)
                {
                    lblBuscar.Visible = true;
                }

                if (txtBoxBuscar.Visible == false)
                {
                    txtBoxBuscar.Visible = true;
                }
            }
        }

        private void rbUsuariosNombreReal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuariosNombreReal.Checked == true)
            {
                if (lblBuscar.Visible == false)
                {
                    lblBuscar.Visible = true;
                }

                if (txtBoxBuscar.Visible == false)
                {
                    txtBoxBuscar.Visible = true;
                }
            }
        }

        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbUsuariosNombre.Checked == true)
                {
                    dgvUsuariosHabilitados.Rows.Clear();
                    MostrarEnGrilla(dgvUsuariosHabilitados, BLL_Usuario.Ver_Usuarios_Nombre(LU, txtBoxBuscar.Text));
                }
                else if (rbUsuariosRol.Checked == true)
                {
                    dgvUsuariosHabilitados.Rows.Clear();
                    MostrarEnGrilla(dgvUsuariosHabilitados, BLL_Usuario.Ver_Usuarios_Rol(LU, txtBoxBuscar.Text));
                }
                else if (rbUsuariosDNI.Checked == true)
                {
                    dgvUsuariosHabilitados.Rows.Clear();
                    MostrarEnGrilla(dgvUsuariosHabilitados, BLL_Usuario.Ver_Usuarios_DNI(LU, int.Parse(txtBoxBuscar.Text)));
                }
                else if (rbUsuariosApellido.Checked == true)
                {
                    dgvUsuariosHabilitados.Rows.Clear();
                    MostrarEnGrilla(dgvUsuariosHabilitados, BLL_Usuario.Ver_Usuarios_Apellido(LU, txtBoxBuscar.Text));
                }
                else if (rbUsuariosNombreReal.Checked == true)
                {
                    dgvUsuariosHabilitados.Rows.Clear();
                    MostrarEnGrilla(dgvUsuariosHabilitados, BLL_Usuario.Ver_Usuarios_Nombre_Real(LU, txtBoxBuscar.Text));
                }
            }
            catch (Exception) { }
        }

        public void Mostrar_Turnos(List<Turno> pLT)
        {
            foreach (Turno T in pLT)
            {
                comboBoxTurnos.Items.Add(T.ID.ToString() + " - " + T.Nombre.ToString());
            }
        }

        public Turno ObtenerTurno(int pCodigo)
        {
            Turno T = LT.Find(X => X.ID == pCodigo);
            return T;
        }
    }
}
