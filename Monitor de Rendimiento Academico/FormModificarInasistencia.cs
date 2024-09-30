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
    public partial class FormModificarInasistencia : Form
    {
        public FormModificarInasistencia(int pKey, Cursada_de_Alumno pCursada, Inasistencia pInasistencia, Alumno pAlumno, decimal pTotalInasistencias)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
            Cursada = pCursada;
            Inasistencia = pInasistencia;
            Alumno = pAlumno;
            CantidadInasistenciasTotal = pTotalInasistencias;
        }

        public int ID;
        public Cursada_de_Alumno Cursada;
        public Inasistencia Inasistencia;
        public Alumno Alumno;

        public decimal CantidadInasistenciasTotal, ValorInicial;

        public BLL_Cursada_de_Alumno BLL_Cursada_de_Alumno;

        private void FormModificarInasistencia_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            txtBoxFecha.Text = Inasistencia.Fecha.ToShortDateString();
            txtBoxDescripcion.Text = Inasistencia.Descripcion;
            txtBoxJustificacion.Text = Inasistencia.Justificacion;
            txtBoxValor.Text = Inasistencia.Valor.ToString();
            ValorInicial = Inasistencia.Valor;

            txtBoxFecha.Select(0, 0);

            BLL_Cursada_de_Alumno = new BLL_Cursada_de_Alumno();
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

        private void btnEnviarInasistencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxValor.Text != "0,00")
                {
                    if (MessageBox.Show("¿Está seguro de modificar la Inasistencia?", "Solicitud de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                    {
                        decimal NewValor = decimal.Parse(txtBoxValor.Text);
                        Inasistencia.Descripcion = txtBoxDescripcion.Text;
                        Inasistencia.Justificacion = txtBoxJustificacion.Text;

                        CantidadInasistenciasTotal -= ValorInicial;

                        Inasistencia.Valor = NewValor;

                        if (CantidadInasistenciasTotal + NewValor >=25 && Cursada.Libre == false)
                        {
                            if (MessageBox.Show("Nota: El Alumno ha superado el límite de faltas (25)\n\n¿Desea modificar el Estado de Alumno a Libre?\n\nAunque rechace esto, la modificación se efectuará, pero no se modificará el Estado del Alumno", "Solicitud de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                BLL_Cursada_de_Alumno.Modificar_Estado_de_Cursada(Cursada, true);
                                Cursada.Libre = true;
                            }

                            ModificarInasistencia(Inasistencia);
                            LogManager.Escribir(ID, "Modificó la Inasistencia " + Inasistencia.Codigo + " - Alumno: " + Alumno.Legajo, 2);

                            MessageBox.Show("La Inasistencia fue modificada correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }
                        else if (CantidadInasistenciasTotal + NewValor < 25 && Cursada.Libre == true)
                        {
                            if (MessageBox.Show("Nota: Modificando el valor de esta falta haría que el Alumno pase su Estado a Alumno Regular\n\n¿Está de acuerdo con esto?", "Solicitud de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                BLL_Cursada_de_Alumno.Modificar_Estado_de_Cursada(Cursada, false);
                                Cursada.Libre = false;
                                ModificarInasistencia(Inasistencia);
                                LogManager.Escribir(ID, "Modificó la Inasistencia " + Inasistencia.Codigo + " - Alumno: " + Alumno.Legajo, 2);

                                MessageBox.Show("La Inasistencia fue modificada correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }                            
                        }
                        else
                        {
                            ModificarInasistencia(Inasistencia);
                            LogManager.Escribir(ID, "Modificó la Inasistencia " + Inasistencia.Codigo + " - Alumno: " + Alumno.Legajo, 2);

                            MessageBox.Show("La Inasistencia fue modificada correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                else { MessageBox.Show("Debe ingresar un valor mayor a 0\n\nSi desea eliminar la Inasistencia, cierre esta ventana y seleccione *Eliminar Inasistencia*", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void ModificarInasistencia(Inasistencia pInasistencia)
        {
            BLL_Cursada_de_Alumno.Modificar_Inasistencia(Cursada, pInasistencia);
        }
    }
}
