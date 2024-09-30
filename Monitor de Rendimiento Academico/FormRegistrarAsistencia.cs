using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
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
    public partial class FormRegistrarAsistencia : Form
    {
        public FormRegistrarAsistencia(int pKey, Curso pCurso)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
            Curso = pCurso;
        }

        public int ID;
        public Curso Curso;
        BLL_Alumno BLL_Alumno;
        BLL_Curso BLL_Curso;
        BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        public List<Alumno> LA;
        public List<Cursada_de_Alumno> CursadasLibres, CursadasALiberar;
        public Dictionary<int, decimal> Cursada_Cant_Inasistencias;
        public Dictionary<int, bool> Cursada_Estado;

        private void FormRegistrarAsistencia_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            lblFechaHoy.Text = DateTime.Today.ToShortDateString();

            CultureInfo Culture = Thread.CurrentThread.CurrentUICulture;

            string DiaDeHoy = Culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);

            lblDiaHoy.Text = DiaDeHoy;

            BLL_Alumno = new BLL_Alumno();
            BLL_Curso = new BLL_Curso();
            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            CursadasLibres = new List<Cursada_de_Alumno>();
            CursadasALiberar = new List<Cursada_de_Alumno>();

            LA = BLL_Curso.Ver_Alumnos_del_Curso(Curso);

            if (LA.Count>0)
            {
                foreach (Alumno Alumno in LA)
                {
                    Asignar_Cursadas_a_Alumno(Alumno);
                }

                Cursada_Cant_Inasistencias = BLL_Cursada_de_Alumno.Obtener_Cant_Inasistencias(LA);
                BLL_Cursada_de_Alumno.Obtener_Inasistencias_Alumnos(LA);
                //MostrarDatosEnGrilla(dgvAlumnosAsistencia, LA);
                MostrarDatosEnGrilla2(dgvAlumnosAsistencia, LA);
                Quitar_Filas_Libres();
                txtBoxFecha.Text = DateTime.Today.ToShortDateString();

                dgvAlumnosAsistencia_Click(null, null);
            }
            else { MessageBox.Show("Este Curso no posee Alumnos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
        }
        public void MostrarDatosEnGrilla(DataGridView pDGV, List<Alumno> LA)
        {
            try
            {
                if (LA.Count != 0)
                {
                    foreach (Alumno A in LA)
                    {
                        pDGV.Rows.Add(A.Legajo, A.Apellido, A.Nombre, A.DNI);
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void MostrarDatosEnGrilla2(DataGridView pDGV, List<Alumno> LA)
        {
            try
            {
                if (LA.Count != 0)
                {
                    for (int i = 0; i < LA.Count; i++)
                    {
                        pDGV.Rows.Add(LA[i].Legajo, LA[i].Apellido, LA[i].Nombre, LA[i].DNI, "");

                        if (ObtenerFalta(LA[i]) == "No")
                        {
                            dgvAlumnosAsistencia.Rows[i].Cells[4].Style.BackColor = Color.Green;
                        }
                        else if (ObtenerFalta(LA[i]) == "Si")
                        {
                            dgvAlumnosAsistencia.Rows[i].Cells[4].Style.BackColor = Color.Red;
                        }
                        else if (ObtenerFalta(LA[i]) == "Media")
                        {
                            dgvAlumnosAsistencia.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                        }                     
                    }
                }
                else { pDGV.Rows.Clear(); pDGV.DataSource = null; }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }


        public Alumno ObtenerAlumno(string pLegajo)
        {
            Alumno A = LA.Find(X => X.Legajo == pLegajo);
            return A;
        }

        public void Asignar_Cursadas_a_Alumno(Alumno pAlumno)
        {
            Cursada_de_Alumno CA = BLL_Cursada_de_Alumno.Buscar_Cursada_de_Alumno(pAlumno, Curso);
            pAlumno.VerCursadas().Add(CA);
        }

        private void dgvAlumnosAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnosAsistencia.Rows.Count > 0)
                {
                    Alumno A = ObtenerAlumno((string)dgvAlumnosAsistencia.SelectedRows[0].Cells[0].Value);

                    txtBoxDescripcion.Text = "";
                    txtBoxJustificacion.Text = "";
                    txtBoxValor.Text = "0,00";

                    if (A.VerCursadas()[0].VerInasistencias().Count > 0)
                    {
                        txtBoxDescripcion.Text = A.VerCursadas()[0].VerInasistencias()[0].Descripcion;
                        txtBoxJustificacion.Text = A.VerCursadas()[0].VerInasistencias()[0].Justificacion;
                        txtBoxValor.Text = (A.VerCursadas()[0].VerInasistencias()[0].Valor).ToString();
                        btnSumar.Enabled = false;
                        btnRestar.Enabled = false;
                        txtBoxDescripcion.Enabled = false;
                        txtBoxJustificacion.Enabled = false;
                    }
                    else
                    {
                        btnSumar.Enabled = true;
                        btnRestar.Enabled = true;
                        txtBoxDescripcion.Enabled = true;
                        txtBoxJustificacion.Enabled = true;
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void btnAgregarFalta_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnosAsistencia.Rows.Count > 0)
                {
                    Alumno A = ObtenerAlumno((string)dgvAlumnosAsistencia.SelectedRows[0].Cells[0].Value);

                    if (txtBoxValor.Text != "0,00")
                    {
                        if (A.VerCursadas()[0].Libre == false)
                        {
                            if (A.VerCursadas()[0].VerInasistencias().Count == 0) //Si no tiene inasistencias en el día de la fecha
                            {
                                if (txtBoxValor.Text == "0,50")
                                {
                                    dgvAlumnosAsistencia.Rows[dgvAlumnosAsistencia.SelectedRows[0].Index].Cells[4].Style.BackColor = Color.Yellow;
                                }
                                else if (txtBoxValor.Text == "1,00")
                                {
                                    dgvAlumnosAsistencia.Rows[dgvAlumnosAsistencia.SelectedRows[0].Index].Cells[4].Style.BackColor = Color.Red;
                                }

                                Agregar_Inasistencia(A.VerCursadas()[0], DateTime.Parse(txtBoxFecha.Text), decimal.Parse(txtBoxValor.Text), txtBoxDescripcion.Text, txtBoxJustificacion.Text);
                                Cursada_Cant_Inasistencias[A.VerCursadas()[0].Codigo] += decimal.Parse(txtBoxValor.Text);
                                btnSumar.Enabled = false;
                                btnRestar.Enabled = false;
                                txtBoxDescripcion.Enabled = false;
                                txtBoxJustificacion.Enabled = false;
                                MessageBox.Show("Inasistencia agregada correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (Cursada_Cant_Inasistencias[A.VerCursadas()[0].Codigo] >= 25) //Si es igual o mayor o 25 le pregunto si quiere que su estado cambie
                                {
                                    if (MessageBox.Show("El Alumno " + A.Apellido + ", " + A.Nombre + " " + '(' + A.Legajo + ')' + " superó el límite de inasistencias permitidas (25)\n\n¿Desea poner el estado del Alumno en Libre?\n\nFaltas del Alumno: " + Cursada_Cant_Inasistencias[A.VerCursadas()[0].Codigo].ToString() + "\n\nNota: Aunque rechace esto, la inasistencia se contabilizará igualmente\n\nEl estado del Alumno cambiará luego de haber enviado las Inasistencias", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        A.VerCursadas()[0].Libre = true;
                                        CursadasLibres.Add(A.VerCursadas()[0]);                                        

                                        if (CursadasALiberar.Exists(X => X.Codigo == A.VerCursadas()[0].Codigo))
                                        {
                                            CursadasALiberar.Remove(CursadasALiberar.Find(X => X.Codigo == A.VerCursadas()[0].Codigo));
                                        }
                                    }
                                }
                            }
                            else { throw new Exception("Ya se agregó una Inasistencia en la fecha de hoy"); }
                        }
                        else { throw new Exception("Este Alumno se encuentra libre, por lo que no puede concurrir a la Escuela"); }
                    }
                    else { MessageBox.Show("Debe ingresar un valor mayor a 0", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnQuitarInasistencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnosAsistencia.Rows.Count > 0)
                {
                    Alumno A = ObtenerAlumno((string)dgvAlumnosAsistencia.SelectedRows[0].Cells[0].Value);

                    if (A.VerCursadas()[0].VerInasistencias().Count > 0)
                    {
                        if (Cursada_Cant_Inasistencias[A.VerCursadas()[0].Codigo] - decimal.Parse(txtBoxValor.Text) < 25 && A.VerCursadas()[0].Libre == true || CursadasLibres.Exists(X => X.Codigo == A.VerCursadas()[0].Codigo))
                        {
                            if (MessageBox.Show("Si usted elimina esta Inasistencia, el estado del Alumno " + A.Apellido + ", " + A.Nombre + " pasará a ser Alumno Regular\n\n¿Está de acuerdo con esto?\n\nNota: El Estado del Alumno cambiará cuando envíe las Inasistencias", "Solicitud de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                dgvAlumnosAsistencia.Rows[dgvAlumnosAsistencia.SelectedRows[0].Index].Cells[4].Style.BackColor = Color.Green;
                                Cursada_Cant_Inasistencias[A.VerCursadas()[0].Codigo] -= decimal.Parse(txtBoxValor.Text);
                                A.VerCursadas()[0].Libre = false;
                                Quitar_Inasistencia(A);

                                if (CursadasLibres.Exists(X=> X.Codigo == A.VerCursadas()[0].Codigo))
                                {
                                    CursadasLibres.Remove(CursadasLibres.Find(X => X.Codigo == A.VerCursadas()[0].Codigo));
                                }                                

                                MessageBox.Show("Inasistencia eliminada correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CursadasALiberar.Add(A.VerCursadas()[0]);
                                dgvAlumnosAsistencia_Click(null, null);
                            }
                        }
                        else
                        {
                            dgvAlumnosAsistencia.Rows[dgvAlumnosAsistencia.SelectedRows[0].Index].Cells[4].Style.BackColor = Color.Green;
                            Cursada_Cant_Inasistencias[A.VerCursadas()[0].Codigo] -= decimal.Parse(txtBoxValor.Text);
                            Quitar_Inasistencia(A);
                            MessageBox.Show("Inasistencia eliminada correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvAlumnosAsistencia_Click(null, null);
                        }
                    }
                    else { throw new Exception("Este Alumno no posee una inasistencia en el día de la fecha"); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //Parte Inasistencia

        public void Agregar_Inasistencia(Cursada_de_Alumno pCA, DateTime pFecha, decimal pValor, string pDescripcion, string pJustificacion)
        {
            try
            {
                BLL_Cursada_de_Alumno.Agregar_Inasistencia(pCA, pFecha, pValor, pDescripcion, pJustificacion);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }            
        }

        public void Quitar_Inasistencia(Alumno pAlumno)
        {
            try
            {
                BLL_Cursada_de_Alumno.Quitar_Inasistencia(pAlumno.VerCursadas()[0]);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Enviar_Inasistencias(List<Alumno> pLA, Curso pCurso)
        {
            try
            {
                BLL_Cursada_de_Alumno.Enviar_Inasistencias(pLA, pCurso);

                if (CursadasLibres.Count>0)
                {
                    foreach (Cursada_de_Alumno CA in CursadasLibres)
                    {
                        BLL_Cursada_de_Alumno.Modificar_Estado_de_Cursada(CA, true);
                    }                    
                }

                if (CursadasALiberar.Count>0)
                {
                    foreach (Cursada_de_Alumno CA in CursadasALiberar)
                    {
                        BLL_Cursada_de_Alumno.Modificar_Estado_de_Cursada(CA, false);
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }       

        public bool SeRegistraronFaltas()
        {
            bool HayFaltas = false; //False -> No ||True -> Sí

            foreach (Alumno A in LA)
            {
                if (A.VerCursadas()[0].VerInasistencias().Count>0)
                {
                    HayFaltas = true;
                    break;
                }
            }

            return HayFaltas;
        }

        private void btnEnviarAsistencias_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de enviar las Inasistencias?", "Solicitud de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Enviar_Inasistencias(LA, Curso);
                    LogManager.Escribir(ID, "Envió las Inasistencias del Curso " + Curso.Nombre, 3);
                    MessageBox.Show("Las inasistencias fueron enviadas correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }


                //if (SeRegistraronFaltas()==true)
                //{
                                     
                //}
                //else { throw new Exception("Debe haber al menos una inasistencia"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (txtBoxValor.Text == "0,00")
            {
                txtBoxValor.Text = "0,50";
            }
            else if (txtBoxValor.Text == "0,50")
            {
                txtBoxValor.Text = "1,00";
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (txtBoxValor.Text == "1,00")
            {
                txtBoxValor.Text = "0,50";
            }
            else if (txtBoxValor.Text == "0,50")
            {
                txtBoxValor.Text = "0,00";
            }
        }

        public string ObtenerFalta(Alumno pAlumno)
        {
            string Falta = "No";

            if (pAlumno.VerCursadas()[0].VerInasistencias().Count == 0)
            {
                Falta = "No";
            }
            else
            {
                if (pAlumno.VerCursadas()[0].VerInasistencias()[0].Valor == 1)
                {
                    Falta = "Si";
                }
                else
                {
                    Falta = "Media";
                }
            }

            return Falta;
        }

        public void Quitar_Filas_Libres()
        {
            for (int i = 0; i < dgvAlumnosAsistencia.Rows.Count; i++)
            {
                if (LA[i].VerCursadas()[0].Libre==true && LA[i].VerCursadas()[0].VerInasistencias().Count==0)
                {
                    dgvAlumnosAsistencia.Rows.RemoveAt(i);
                }
            }
        }
    }
}
