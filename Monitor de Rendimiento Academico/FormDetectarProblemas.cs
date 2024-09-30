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
    public partial class FormDetectarProblemas : Form
    {
        public FormDetectarProblemas(int pKey)
        {
            InitializeComponent();
            this.CenterToParent();

            ID = pKey;
        }

        public int ID;
        FormVerCursosProblemas FormVerCursosProblemas;
        FormVerDocentesProblemas FormVerDocentesProblemas;

        private void FormDetectarProblemas_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnProblemasCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormVerCursosProblemas == null)
                {
                    FormVerCursosProblemas = new FormVerCursosProblemas(ID);
                    FormVerCursosProblemas.FormClosed += FormVerCursosProblemas_FormClosed;
                    FormVerCursosProblemas.ShowDialog();
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void FormVerCursosProblemas_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerCursosProblemas = null;
        }

        private void btnProblemasDocente_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormVerDocentesProblemas == null)
                {
                    FormVerDocentesProblemas = new FormVerDocentesProblemas(ID);
                    FormVerDocentesProblemas.FormClosed += FormVerDocentesProblemas_FormClosed;
                    FormVerDocentesProblemas.ShowDialog();
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void FormVerDocentesProblemas_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormVerDocentesProblemas = null;
        }
    }
}
