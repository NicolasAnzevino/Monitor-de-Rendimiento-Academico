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
    public partial class FormVerUsuariosModificados : Form
    {
        public FormVerUsuariosModificados(int pKey)
        {
            InitializeComponent();
            this.CenterToScreen();
            ID = pKey;
        }

        public int ID;

        private void FormVerUsuariosModificados_Load(object sender, EventArgs e)
        {
            TranslatorManager.TraducirTodo(SessionManager.getInstance(ID).Idioma, this);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            txtBoxInforme.Text = SerializerManager.Ver_Usuarios_Serializados();
            txtBoxInforme.Select(0, 0);
        }
    }
}
