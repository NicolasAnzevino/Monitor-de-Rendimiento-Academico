using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;
using Servicios;
using BLL;

namespace Monitor_de_Rendimiento_Academico
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal(int pKey)
        {
            InitializeComponent();
            this.CenterToScreen();
            ID = pKey;
        }

        public int ID;
        public bool SalirNormal;
        public Usuario U;

        //Formularios
        FormRegistrarUsuario FormRegistrar;
        FormAgregarRol FormAgregarRol;
        FormVerUsuarios FormVerUsuarios;
        FormVerUsuariosBloqueados FormUsuariosBloqueados;
        FormRealizarQueja FormRealizarQueja;
        FormAtenderQueja FormAtenderQueja;
        FormVerQuejasUsuario FormVerQuejasUsuario;
        BLL_Usuario BLL_Usuario;
        FormCrearCurso FormCrearCurso;
        FormVerCursos FormVerCursos;
        FormCrearMateria FormCrearMateria;
        FormVerMaterias FormVerMaterias;
        FormAgregarAlumno FormAgregarAlumno;
        FormVerAlumnos FormVerAlumnos;
        FormAgregarDocente FormAgregarDocente;
        FormVerDocentes FormVerDocentes;
        FormCrearDictado FormCrearDictado;
        FormVerDictados FormVerDictados;
        FormAgregarCursada FormAgregarCursada;
        FormVerMisDictados FormVerMisDictados;
        FormVerCursosEncuesta FormVerCursosEncuesta;
        FormVerEncuestasAlumno FormVerEncuestasAlumno;
        FormVerCursosEncuestasResultado FormVerCursosEncuestasResultado;
        FormVerCursosVerRendimientoAlumno FormVerCursosVerRendimientoAlumno;
        FormVerCursosCompararRendimiento FormVerCursosCompararRendimiento;
        FormVerDocentesVerRendimiento FormVerDocentesVerRendimiento;
        FormVerMateriasCompararDocente FormVerMateriasCompararDocente;
        FormVerBitacoraDeCambios FormVerBitacoraDeCambios;
        FormVerPerfilAlumno FormVerPerfilAlumno;
        FormAgregarTurno FormAgregarTurno;
        FormVerCursosAsistencia FormVerCursosAsistencia;
        FormDetectarProblemas FormDetectarProblemas;
        FormVerCursosVerRendCurso FormVerCursosVerRendCurso;

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            BLL_Usuario = new BLL_Usuario();

            foreach (ToolStripMenuItem i in menuStrip1.Items)
            {
                i.Visible = false;
                foreach (ToolStripMenuItem _i in i.DropDownItems)
                {
                    _i.Visible = false;
                }
            }

            U = SessionManager.getInstance(ID).User;

            foreach (ToolStripMenuItem i in menuStrip1.Items)
            {
                if (i.DropDownItems.Count > 0)
                {
                    bool show = false;

                    foreach (ToolStripMenuItem _i in i.DropDownItems)
                    {
                        if (U.Rol.Validar((string)_i.Tag))
                        {
                            _i.Visible = true;
                            show = true;
                        }
                    }
                    i.Visible = show;
                }
                else { i.Visible = U.Rol.Validar((string)i.Tag); }
            }

            foreach (ToolStripMenuItem item in idiomaToolStripMenuItem.DropDownItems)
            {
                item.Visible = true;
            }

            if (SessionManager.getInstance(ID).Idioma == 1)
            {
                ((ToolStripMenuItem)idiomaToolStripMenuItem.DropDownItems[0]).Checked = true;
            }
            else if (SessionManager.getInstance(ID).Idioma == 2)
            {
                ((ToolStripMenuItem)idiomaToolStripMenuItem.DropDownItems[1]).Checked = true;
            }

            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            toolStripStatusLabelNombreUsuarioReal.Text += " " + SessionManager.getInstance(ID).User.Nombre.ToString();
            toolStripStatusLabelRolReal.Text += " " + SessionManager.getInstance(ID).User.Rol.Nombre.ToString();

            idiomaToolStripMenuItem.Visible = true;

            SalirNormal = true; //Si esta en false, quiere decir que chau, te kickea al max

            //docentesToolStripMenuItem.Visible = true;
            //verDocentesToolStripMenuItem.Visible = true;
        }

        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (SalirNormal==true)
                {
                    string Titulo, Texto;

                    if (SessionManager.getInstance(ID).Idioma == 1)
                    {
                        Titulo = "Confirmar Cerrar Sesión";
                        Texto = "¿Desea salir del sistema?";
                    }
                    else
                    {
                        Titulo = "Confirm Logout";
                        Texto = "Do you want to Log Out?";
                    }

                    if (MessageBox.Show(Texto, Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LogManager.Escribir(ID, "Ha cerrado sesión", 3);
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {

                }                            
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //Funciones

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)registrarUsuarioToolStripMenuItem.Tag) == true)
                {
                    if (FormRegistrar is null)
                    {
                        FormRegistrar = new FormRegistrarUsuario(ID);
                        FormRegistrar.MdiParent = this;
                        FormRegistrar.FormClosed += FormRegistrar_FormClosed;
                        FormRegistrar.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormRegistrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                FormRegistrar = null;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void agregarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)agregarRolToolStripMenuItem.Tag)==true)
                {
                    if (FormAgregarRol is null)
                    {
                        FormAgregarRol = new FormAgregarRol(ID);
                        FormAgregarRol.MdiParent = this;
                        FormAgregarRol.FormClosed += FormAgregarRol_FormClosed;
                        FormAgregarRol.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormAgregarRol_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAgregarRol = null;
        }

        private void verCuentasBloqueadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verCuentasBloqueadasToolStripMenuItem.Tag)==true)
                {
                    if (FormUsuariosBloqueados is null)
                    {
                        FormUsuariosBloqueados = new FormVerUsuariosBloqueados(ID);
                        FormUsuariosBloqueados.MdiParent = this;
                        FormUsuariosBloqueados.FormClosed += FormUsuariosBloqueados_FormClosed;
                        FormUsuariosBloqueados.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormUsuariosBloqueados_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                FormUsuariosBloqueados = null;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cambiarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SessionManager.getInstance(ID).Idioma = TranslatorManager.CambiarIdioma(ID, SessionManager.getInstance(ID).Idioma);
                TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

                BLL_Usuario.Actualizar_Digitos_Verificadores(ID);

                LogManager.Escribir(ID, "Ha cambiado el idioma", 3);

                if (SessionManager.getInstance(ID).Idioma == 1)
                {
                    MessageBox.Show("El idioma ha sido cambiado a Español");
                }
                else if (SessionManager.getInstance(ID).Idioma == 2)
                {
                    MessageBox.Show("The language has been changed to English");
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void realizarBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)realizarBackUpToolStripMenuItem.Tag)==true)
                {
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        LogManager.Escribir(ID, "Realizó un BackUp en el día " + DateTime.Now.ToShortDateString(), 1);
                        BackupRestoreManager.RealizarBackup(folderBrowserDialog.SelectedPath);

                        string S = "";
                        string T = "";

                        if (SessionManager.getInstance(ID).Idioma == 1)
                        {
                            S = "Se ha realizado el BackUp correctamente";
                            T = "BackUp realizado";
                        }
                        else if (SessionManager.getInstance(ID).Idioma == 2)
                        {
                            S = "The BackUp has been carried out correctly";
                            T = "BackUp done";
                        }

                        MessageBox.Show(S, T, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //BackupRestoreManager.RealizarBackup();

                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void realizarRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)realizarRestoreToolStripMenuItem.Tag)==true)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (Path.GetExtension(openFileDialog.FileName) == ".bak")
                        {
                            string S = "";
                            string T = "";

                            if (SessionManager.getInstance(ID).Idioma == 1)
                            {
                                S = "La aplicación se cerrará\n\nVuelva a ingresar para ver los cambios";
                                T = "Atención";
                            }
                            else if (SessionManager.getInstance(ID).Idioma == 2)
                            {
                                S = "The application will close\n\nRe-login to see the changes";
                                T = "Atention";
                            }

                            SalirNormal = false;
                            BackupRestoreManager.RealizarRestore(openFileDialog.FileName);
                            MessageBox.Show(S,T, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        else { throw new Exception("Debe seleccionar un archivo de backup válido"); }
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void realizarQuejaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)realizarQuejaToolStripMenuItem.Tag)==true)
                {
                    if (FormRealizarQueja is null)
                    {
                        FormRealizarQueja = new FormRealizarQueja(ID);
                        FormRealizarQueja.MdiParent = this;
                        FormRealizarQueja.FormClosed += FormRealizarQueja_FormClosed;
                        FormRealizarQueja.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormRealizarQueja_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormRealizarQueja = null;
        }

        private void verEstadoDeQuejaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verEstadoDeQuejaToolStripMenuItem.Tag)==true)
                {
                    if (FormVerQuejasUsuario is null)
                    {
                        FormVerQuejasUsuario = new FormVerQuejasUsuario(ID);
                        FormVerQuejasUsuario.MdiParent = this;
                        FormVerQuejasUsuario.FormClosed += FormVerQuejasUsuario_FormClosed;
                        FormVerQuejasUsuario.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerQuejasUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerQuejasUsuario = null;
        }

        private void atenderQuejaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)atenderQuejaToolStripMenuItem.Tag) == true)
                {
                    if (FormAtenderQueja is null)
                    {
                        FormAtenderQueja = new FormAtenderQueja(ID);
                        FormAtenderQueja.MdiParent = this;
                        FormAtenderQueja.FormClosed += FormAtenderQueja_FormClosed;
                        FormAtenderQueja.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormAtenderQueja_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAtenderQueja = null;
        }

        private void crearCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)crearCursoToolStripMenuItem.Tag)==true)
                {
                    if (FormCrearCurso is null)
                    {
                        FormCrearCurso = new FormCrearCurso(ID);
                        FormCrearCurso.MdiParent = this;
                        FormCrearCurso.FormClosed += FormCrearCurso_FormClosed;
                        FormCrearCurso.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormCrearCurso_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCrearCurso = null;
        }

        private void crearAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)crearAlumnoToolStripMenuItem.Tag)==true)
                {
                    if (FormAgregarAlumno is null)
                    {
                        FormAgregarAlumno = new FormAgregarAlumno(ID);
                        FormAgregarAlumno.MdiParent = this;
                        FormAgregarAlumno.FormClosed += FormAgregarAlumno_FormClosed;
                        FormAgregarAlumno.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormAgregarAlumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAgregarAlumno = null;
        }

        private void verCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verCursosToolStripMenuItem.Tag)==true)
                {
                    if (FormVerCursos is null)
                    {
                        FormVerCursos = new FormVerCursos(ID);
                        FormVerCursos.MdiParent = this;
                        FormVerCursos.FormClosed += FormVerCursos_FormClosed;
                        FormVerCursos.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerCursos_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerCursos = null;
        }

        private void crearMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)crearMateriaToolStripMenuItem.Tag) == true)
                {
                    if (FormCrearMateria is null)
                    {
                        FormCrearMateria = new FormCrearMateria(ID);
                        FormCrearMateria.MdiParent = this;
                        FormCrearMateria.FormClosed += FormCrearMateria_FormClosed;
                        FormCrearMateria.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }   
        }

        private void FormCrearMateria_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCrearMateria = null;
        }

        private void verMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verMateriasToolStripMenuItem.Tag) == true)
                {
                    if (FormVerMaterias is null)
                    {
                        FormVerMaterias = new FormVerMaterias(ID);
                        FormVerMaterias.MdiParent = this;
                        FormVerMaterias.FormClosed += FormVerMaterias_FormClosed;
                        FormVerMaterias.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerMaterias_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerMaterias = null;
        }

        private void verAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verAlumnosToolStripMenuItem.Tag) == true)
                {
                    if (FormVerAlumnos is null)
                    {
                        FormVerAlumnos = new FormVerAlumnos(ID);
                        FormVerAlumnos.MdiParent = this;
                        FormVerAlumnos.FormClosed += FormVerAlumnos_FormClosed;
                        FormVerAlumnos.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); } 
        }

        private void FormVerAlumnos_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerAlumnos = null;
        }

        private void crearDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)crearDocenteToolStripMenuItem.Tag) == true)
                {
                    if (FormAgregarDocente is null)
                    {
                        FormAgregarDocente = new FormAgregarDocente(ID);
                        FormAgregarDocente.MdiParent = this;
                        FormAgregarDocente.FormClosed += FormAgregarDocente_FormClosed;
                        FormAgregarDocente.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormAgregarDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAgregarDocente = null;
        }

        private void verDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verDocentesToolStripMenuItem.Tag) == true)
                {
                    if (FormVerDocentes is null)
                    {
                        FormVerDocentes = new FormVerDocentes(ID);
                        FormVerDocentes.MdiParent = this;
                        FormVerDocentes.FormClosed += FormVerDocentes_FormClosed;
                        FormVerDocentes.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }       
        }

        private void FormVerDocentes_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerDocentes = null;
        }

        private void crearDictadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)crearDictadoToolStripMenuItem.Tag) == true)
                {
                    if (FormCrearDictado is null)
                    {
                        FormCrearDictado = new FormCrearDictado(ID);
                        FormCrearDictado.MdiParent = this;
                        FormCrearDictado.FormClosed += FormCrearDictado_FormClosed;
                        FormCrearDictado.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormCrearDictado_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCrearDictado = null;
        }

        private void verDictadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verDictadosToolStripMenuItem.Tag) == true)
                {
                    if (FormVerDictados is null)
                    {
                        FormVerDictados = new FormVerDictados(ID);
                        FormVerDictados.MdiParent = this;
                        FormVerDictados.FormClosed += FormVerDictados_FormClosed;
                        FormVerDictados.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerDictados_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerDictados = null;
        }

        private void crearCursadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)crearCursadaToolStripMenuItem.Tag) == true)
                {
                    if (FormAgregarCursada is null)
                    {
                        FormAgregarCursada = new FormAgregarCursada(ID);
                        FormAgregarCursada.MdiParent = this;
                        FormAgregarCursada.FormClosed += FormAgregarCursada_FormClosed;
                        FormAgregarCursada.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormAgregarCursada_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAgregarCursada = null;
        }

        private void verMisDictadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verMisDictadosToolStripMenuItem.Tag) == true)
                {
                    if (FormVerMisDictados is null)
                    {
                        FormVerMisDictados = new FormVerMisDictados(ID);
                        FormVerMisDictados.MdiParent = this;
                        FormVerMisDictados.FormClosed += FormVerMisDictados_FormClosed;
                        FormVerMisDictados.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerMisDictados_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerMisDictados = null;
        }

        private void agregarEncuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)agregarEncuestaToolStripMenuItem.Tag) == true)
                {
                    if (FormVerCursosEncuesta is null)
                    {
                        FormVerCursosEncuesta = new FormVerCursosEncuesta(ID);
                        FormVerCursosEncuesta.MdiParent = this;
                        FormVerCursosEncuesta.FormClosed += FormVerCursosEncuesta_FormClosed;
                        FormVerCursosEncuesta.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerCursosEncuesta_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerCursosEncuesta = null;
        }

        private void verEncuestasACompletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verEncuestasACompletarToolStripMenuItem.Tag) == true)
                {
                    if (FormVerEncuestasAlumno is null)
                    {
                        FormVerEncuestasAlumno = new FormVerEncuestasAlumno(ID);
                        FormVerEncuestasAlumno.MdiParent = this;
                        FormVerEncuestasAlumno.FormClosed += FormVerEncuestasAlumno_FormClosed;
                        FormVerEncuestasAlumno.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerEncuestasAlumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerEncuestasAlumno = null;
        }

        private void verEstadoDeEncuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verEstadoDeEncuestaToolStripMenuItem.Tag) == true)
                {
                    if (FormVerCursosEncuestasResultado is null)
                    {
                        FormVerCursosEncuestasResultado = new FormVerCursosEncuestasResultado(ID);
                        FormVerCursosEncuestasResultado.MdiParent = this;
                        FormVerCursosEncuestasResultado.FormClosed += FormVerCursosEncuestasResultado_FormClosed;
                        FormVerCursosEncuestasResultado.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerCursosEncuestasResultado_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerCursosEncuestasResultado = null;
        }

        private void verificarRendimientoDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verificarRendimientoDeAlumnoToolStripMenuItem.Tag) == true)
                {
                    if (FormVerCursosVerRendimientoAlumno is null)
                    {
                        FormVerCursosVerRendimientoAlumno = new FormVerCursosVerRendimientoAlumno(ID);
                        FormVerCursosVerRendimientoAlumno.MdiParent = this;
                        FormVerCursosVerRendimientoAlumno.FormClosed += FormVerCursosVerRendimientoAlumno_FormClosed;
                        FormVerCursosVerRendimientoAlumno.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }      
        }

        private void FormVerCursosVerRendimientoAlumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerCursosVerRendimientoAlumno = null;
        }

        private void compararRendimientoDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)compararRendimientoDeAlumnoToolStripMenuItem.Tag) == true)
                {
                    if (FormVerCursosCompararRendimiento is null)
                    {
                        FormVerCursosCompararRendimiento = new FormVerCursosCompararRendimiento(ID);
                        FormVerCursosCompararRendimiento.MdiParent = this;
                        FormVerCursosCompararRendimiento.FormClosed += FormVerCursosCompararRendimiento_FormClosed;
                        FormVerCursosCompararRendimiento.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }     
        }

        private void FormVerCursosCompararRendimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerCursosCompararRendimiento = null;
        }

        private void verificarRendimientoDeDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verificarRendimientoDeDocenteToolStripMenuItem.Tag) == true)
                {
                    if (FormVerDocentesVerRendimiento is null)
                    {
                        FormVerDocentesVerRendimiento = new FormVerDocentesVerRendimiento(ID);
                        FormVerDocentesVerRendimiento.MdiParent = this;
                        FormVerDocentesVerRendimiento.FormClosed += FormVerDocentesVerRendimiento_FormClosed;
                        FormVerDocentesVerRendimiento.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerDocentesVerRendimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerDocentesVerRendimiento = null;
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verUsuariosToolStripMenuItem.Tag) == true)
                {
                    if (FormVerUsuarios is null)
                    {
                        FormVerUsuarios = new FormVerUsuarios(ID);
                        FormVerUsuarios.MdiParent = this;
                        FormVerUsuarios.FormClosed += FormVerUsuarios_FormClosed;
                        FormVerUsuarios.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }  
        }

        private void FormVerUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerUsuarios = null;
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (SessionManager.getInstance(ID).Idioma != 1)
                {
                    SessionManager.getInstance(ID).Idioma = TranslatorManager.CambiarIdioma(ID, SessionManager.getInstance(ID).Idioma);
                    TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

                    BLL_Usuario.Actualizar_Digitos_Verificadores(ID);

                    LogManager.Escribir(ID, "Ha cambiado el idioma", 3);

                    if (SessionManager.getInstance(ID).Idioma == 1)
                    {
                        MessageBox.Show("El idioma ha sido cambiado a Español", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ((ToolStripMenuItem)idiomaToolStripMenuItem.DropDownItems[0]).Checked = true;
                    ((ToolStripMenuItem)idiomaToolStripMenuItem.DropDownItems[1]).Checked = false;
                }               

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (SessionManager.getInstance(ID).Idioma != 2)
                {
                    SessionManager.getInstance(ID).Idioma = TranslatorManager.CambiarIdioma(ID, SessionManager.getInstance(ID).Idioma);
                    TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

                    BLL_Usuario.Actualizar_Digitos_Verificadores(ID);

                    LogManager.Escribir(ID, "Ha cambiado el idioma", 3);
                    
                    if (SessionManager.getInstance(ID).Idioma == 2)
                    {
                        MessageBox.Show("The language has been changed to English", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ((ToolStripMenuItem)idiomaToolStripMenuItem.DropDownItems[1]).Checked = true;
                    ((ToolStripMenuItem)idiomaToolStripMenuItem.DropDownItems[0]).Checked = false;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void compararRendimientoDeDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)compararRendimientoDeDocenteToolStripMenuItem.Tag)==true)
                {
                    if (FormVerMateriasCompararDocente is null)
                    {
                        FormVerMateriasCompararDocente = new FormVerMateriasCompararDocente(ID);
                        FormVerMateriasCompararDocente.MdiParent = this;
                        FormVerMateriasCompararDocente.FormClosed += FormVerMateriasCompararDocente_FormClosed;
                        FormVerMateriasCompararDocente.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerMateriasCompararDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerMateriasCompararDocente = null;
        }

        private void verBitácoraDeCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verBitácoraDeCambiosToolStripMenuItem.Tag) == true)
                {
                    if (FormVerBitacoraDeCambios is null)
                    {
                        FormVerBitacoraDeCambios = new FormVerBitacoraDeCambios(ID);
                        FormVerBitacoraDeCambios.MdiParent = this;
                        FormVerBitacoraDeCambios.FormClosed += FormVerBitacoraDeCambios_FormClosed;
                        FormVerBitacoraDeCambios.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerBitacoraDeCambios_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerBitacoraDeCambios = null;
        }

        private void verMiPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verMiPerfilToolStripMenuItem.Tag) == true)
                {
                    if (FormVerPerfilAlumno is null)
                    {
                        FormVerPerfilAlumno = new FormVerPerfilAlumno(ID);
                        FormVerPerfilAlumno.MdiParent = this;
                        FormVerPerfilAlumno.FormClosed += FormVerPerfilAlumno_FormClosed;
                        FormVerPerfilAlumno.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerPerfilAlumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerPerfilAlumno = null;
        }

        private void agregarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)agregarTurnoToolStripMenuItem.Tag) == true)
                {
                    if (FormAgregarTurno is null)
                    {
                        FormAgregarTurno = new FormAgregarTurno(ID);
                        FormAgregarTurno.MdiParent = this;
                        FormAgregarTurno.FormClosed += FormAgregarTurno_FormClosed;
                        FormAgregarTurno.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormAgregarTurno_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAgregarTurno = null;
        }

        private void registrarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)registrarAsistenciaToolStripMenuItem.Tag) == true)
                {
                    if (FormVerCursosAsistencia is null)
                    {
                        FormVerCursosAsistencia = new FormVerCursosAsistencia(ID);
                        FormVerCursosAsistencia.MdiParent = this;
                        FormVerCursosAsistencia.FormClosed += FormVerCursosAsistencia_FormClosed;
                        FormVerCursosAsistencia.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerCursosAsistencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerCursosAsistencia = null;
        }

        private void detectarProblemasDeAprendizajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)detectarProblemasDeAprendizajeToolStripMenuItem.Tag) == true)
                {
                    if (FormDetectarProblemas is null)
                    {
                        FormDetectarProblemas = new FormDetectarProblemas(ID);
                        FormDetectarProblemas.MdiParent = this;
                        FormDetectarProblemas.FormClosed += FormDetectarProblemas_FormClosed;
                        FormDetectarProblemas.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormDetectarProblemas_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormDetectarProblemas = null;
        }

        private void verificarRendimientoDeCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Usuario.Verificar_Permiso(U, (string)verificarRendimientoDeCursoToolStripMenuItem.Tag) == true)
                {
                    if (FormVerCursosVerRendCurso is null)
                    {
                        FormVerCursosVerRendCurso = new FormVerCursosVerRendCurso(ID);
                        FormVerCursosVerRendCurso.MdiParent = this;
                        FormVerCursosVerRendCurso.FormClosed += FormVerCursosVerRendCurso_FormClosed; ;
                        FormVerCursosVerRendCurso.Show();
                    }
                }
                else { throw new Exception("Este Usuario no tiene permisos para realizar esta acción"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormVerCursosVerRendCurso_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerCursosVerRendCurso = null;
        }
    }    
}