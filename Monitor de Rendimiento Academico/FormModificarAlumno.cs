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

namespace Monitor_de_Rendimiento_Academico
{
    public partial class FormModificarAlumno : Form
    {
        public FormModificarAlumno(int pKey, Alumno pAlumno)
        {
            InitializeComponent();
            this.CenterToScreen();

            ID = pKey;
            Alumno = pAlumno;
        }

        public int ID, IDUserAlumno;
        public Alumno Alumno;
        public BLL_Alumno BLL_Alumno;
        public BLL_Docente BLL_Docente;
        public BLL_Usuario BLL_Usuario;
        public BLL_Turno BLL_Turno;
        public List<Turno> LT;

        private void FormModificarAlumno_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Alumno = new BLL_Alumno();
            BLL_Docente = new BLL_Docente();
            BLL_Usuario = new BLL_Usuario();
            BLL_Turno = new BLL_Turno();

            txtBoxDNI.Text = Alumno.DNI.ToString();
            txtBoxApellido.Text = Alumno.Apellido;
            txtBoxNombre.Text = Alumno.Nombre;
            txtBoxEmail.Text = Alumno.Correo_Electronico;
            SelectorFechaIngreso.Value = Alumno.Fecha_Ingreso;
            SelectorFechaNacimiento.Value = Alumno.Fecha_Nacimiento;

            txtBoxDNI.MaxLength = 8;

            LT = BLL_Turno.Ver_Turnos();

            if (LT.Count > 0)
            {
                Mostrar_Turnos(LT);
            }

            IDUserAlumno = BLL_Alumno.Obtener_ID_Usuario_Alumno(Alumno);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (LT.Count>0)
                {
                    if (!string.IsNullOrEmpty(comboBoxTurno.Text))
                    {

                        string item = (string)comboBoxTurno.SelectedItem;

                        Turno T = ObtenerTurno(int.Parse(item.Substring(0, item.ToString().IndexOf("-"))));

                        if (txtBoxDNI.Text != "" && txtBoxApellido.Text != "" && txtBoxNombre.Text != "" && txtBoxEmail.Text != "" && item != null)
                        {
                            if (BLL_Usuario.Verificar_DNI(int.Parse(txtBoxDNI.Text)) == false || int.Parse(txtBoxDNI.Text) == Alumno.DNI)
                            {
                                if (Verificar_Email(txtBoxEmail.Text) == true)
                                {
                                    DateTime FechaIngreso = SelectorFechaIngreso.Value;
                                    DateTime FechaNacimiento = SelectorFechaNacimiento.Value;

                                    if (FechaIngreso > FechaNacimiento)
                                    {
                                        if (MessageBox.Show("¿Estas seguro que desea modificar al Alumno?\n\nNOTA: Se modificarán también los Datos del Usuario y Docente que estén afiliados a este Alumno", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                        {
                                            ModificarAlumno(int.Parse(txtBoxDNI.Text), txtBoxApellido.Text, txtBoxNombre.Text, txtBoxEmail.Text, FechaIngreso, FechaNacimiento, T);
                                            MessageBox.Show("Se ha modificado el Alumno con Legajo " + Alumno.Legajo + " con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            LogManager.Escribir(ID, "Modificó al Alumno con Legajo" + Alumno.Legajo, 3);
                                            txtBoxDNI.Text = "";
                                            txtBoxNombre.Text = "";
                                            txtBoxApellido.Text = "";
                                            txtBoxEmail.Text = "";
                                            this.Close();
                                        }
                                    }
                                    else { throw new Exception("La fecha de ingreso no puede ser menor a la fecha de nacimiento"); }
                                }
                                else { throw new Exception("Debe ingresar un Correo Electrónico válido"); }
                            }
                            else { throw new Exception("El DNI ingresado ya está en uso"); }
                        }
                        else { throw new Exception("Debe rellenar todos los campos"); }
                    }

                }                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }         

        public void ModificarAlumno(int pDNI, string pApellido, string pNombre, string pEmail, DateTime pFechaIng, DateTime pFechaNac, Turno pTurno)
        {
            try
            {
                Alumno.DNI = pDNI;
                Alumno.Apellido = pApellido;
                Alumno.Nombre = pNombre;
                Alumno.Correo_Electronico = pEmail;
                Alumno.Fecha_Ingreso = pFechaIng;
                Alumno.Fecha_Nacimiento = pFechaNac;
                Alumno.Turno = pTurno;

                BLL_Alumno.Modificar_Alumno(Alumno);
                BLL_Usuario.Modificar_Usuario(Alumno, IDUserAlumno);
                BLL_Docente.Modificar_Docente(Alumno, IDUserAlumno);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void comboBoxTurno_Click(object sender, EventArgs e)
        {
            
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
