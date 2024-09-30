using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq.SqlClient;
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
    public partial class FormAgregarInasistencia : Form
    {
        public FormAgregarInasistencia(int pKey, Cursada_de_Alumno pCursada, Alumno pAlumno, decimal pTotalInasistencias)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
            Cursada = pCursada;
            Alumno = pAlumno;
            CantidadInasistenciasTotal = pTotalInasistencias;
        }

        public int ID;
        public Cursada_de_Alumno Cursada;
        public Alumno Alumno;

        public decimal CantidadInasistenciasTotal;

        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;
        private void FormAgregarInasistencia_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();

            txtBoxValor.Text = "0,00";            
        }

        private void btnEnviarInasistencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectorFecha.Value.Date != DateTime.Today)
                {
                    if (SelectorFecha.Value.Date < DateTime.Today)
                    {
                        if (txtBoxValor.Text != "0,00")
                        {
                            if (Cursada.Libre == false)
                            {
                                if (BLL_Cursada_de_Alumno.Verificar_Inasistencia(Cursada, SelectorFecha.Value.Date)==0)
                                {
                                    decimal Valor = decimal.Parse(txtBoxValor.Text);

                                    if (CantidadInasistenciasTotal + Valor >= 25 && Cursada.Libre == false)
                                    {
                                        if (MessageBox.Show("Nota: El Alumno ha superado el límite de faltas (25)\n\n¿Desea modificar el Estado de Alumno a Libre?\n\nAunque rechace esto, la modificación se efectuará, pero no se modificará el Estado del Alumno", "Solicitud de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            Cursada.Libre = true;
                                            BLL_Cursada_de_Alumno.Modificar_Estado_de_Cursada(Cursada, true);
                                        }

                                        CantidadInasistenciasTotal += Valor;
                                        AgregarInasistencia(Valor, SelectorFecha.Value.Date, txtBoxDescripcion.Text, txtBoxJustificacion.Text, Cursada);
                                        LogManager.Escribir(ID, "Agregó una Inasistencia al Alumno" + Alumno.Legajo + " en el día " + SelectorFecha.Value.Date, 2);

                                        MessageBox.Show("La Inasistencia fue agregada correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                    {
                                        CantidadInasistenciasTotal += Valor;
                                        AgregarInasistencia(Valor, SelectorFecha.Value.Date, txtBoxDescripcion.Text, txtBoxJustificacion.Text, Cursada);
                                        LogManager.Escribir(ID, "Agregó una Inasistencia al Alumno" + Alumno.Legajo + " en el día " + SelectorFecha.Value.Date, 2);

                                        MessageBox.Show("La Inasistencia fue agregada correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                }
                                else { MessageBox.Show("Ya existe una Inasistencia en la fecha ingresada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            }
                           
                        }
                        else { MessageBox.Show("Debe ingresar un valor mayor a 0", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else { MessageBox.Show("No puede ingresar una Inasistencia en un día posterior al día de la fecha", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Para agregar una Inasistencia en el día de la fecha, hágalo desde *Registrar Asistencias*", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void AgregarInasistencia(decimal pValor, DateTime pFecha, string pDescripcion, string pJustificacion, Cursada_de_Alumno pCursada)
        {
            BLL_Cursada_de_Alumno.Agregar_Inasistencia(pCursada, pFecha, pValor, pDescripcion, pJustificacion);
            BLL_Cursada_de_Alumno.Agregar_Inasistencia(Cursada, Cursada.VerInasistencias()[0]);
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
    }
}
