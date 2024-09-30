
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAlumnosActivos = new System.Windows.Forms.DataGridView();
            this.DGV_AlumnosActivos_Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbAlumnosInactivos = new System.Windows.Forms.RadioButton();
            this.rbAlumnosActivos = new System.Windows.Forms.RadioButton();
            this.btnVerCursadas = new System.Windows.Forms.Button();
            this.btnDarDeBajaAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblFechaIng = new System.Windows.Forms.Label();
            this.gpAlumnosActivos = new System.Windows.Forms.GroupBox();
            this.gpVisualizacion = new System.Windows.Forms.GroupBox();
            this.rbAlumnosTurno = new System.Windows.Forms.RadioButton();
            this.rbAlumnosNombre = new System.Windows.Forms.RadioButton();
            this.rbAlumnosApellido = new System.Windows.Forms.RadioButton();
            this.rbAlumnosDNI = new System.Windows.Forms.RadioButton();
            this.rbAlumnosLegajo = new System.Windows.Forms.RadioButton();
            this.rbAlumnosTodos = new System.Windows.Forms.RadioButton();
            this.txtBoxBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxFechaNac = new System.Windows.Forms.TextBox();
            this.txtBoxFechaIng = new System.Windows.Forms.TextBox();
            this.btnDarDeAltaAlumno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosActivos)).BeginInit();
            this.gpAlumnosActivos.SuspendLayout();
            this.gpVisualizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlumnosActivos
            // 
            this.dgvAlumnosActivos.AllowUserToAddRows = false;
            this.dgvAlumnosActivos.AllowUserToDeleteRows = false;
            this.dgvAlumnosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_AlumnosActivos_Legajo,
            this.DGV_AlumnosActivos_DNI,
            this.DGV_AlumnosActivos_Apellido,
            this.DGV_AlumnosActivos_Nombre,
            this.DGV_AlumnosActivos_Turno});
            this.dgvAlumnosActivos.Location = new System.Drawing.Point(12, 12);
            this.dgvAlumnosActivos.MultiSelect = false;
            this.dgvAlumnosActivos.Name = "dgvAlumnosActivos";
            this.dgvAlumnosActivos.ReadOnly = true;
            this.dgvAlumnosActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnosActivos.Size = new System.Drawing.Size(705, 260);
            this.dgvAlumnosActivos.TabIndex = 20;
            this.dgvAlumnosActivos.TabStop = false;
            this.dgvAlumnosActivos.Click += new System.EventHandler(this.dgvAlumnosActivos_Click);
            // 
            // DGV_AlumnosActivos_Legajo
            // 
            this.DGV_AlumnosActivos_Legajo.HeaderText = "Column1";
            this.DGV_AlumnosActivos_Legajo.Name = "DGV_AlumnosActivos_Legajo";
            this.DGV_AlumnosActivos_Legajo.ReadOnly = true;
            // 
            // DGV_AlumnosActivos_DNI
            // 
            this.DGV_AlumnosActivos_DNI.HeaderText = "Column1";
            this.DGV_AlumnosActivos_DNI.Name = "DGV_AlumnosActivos_DNI";
            this.DGV_AlumnosActivos_DNI.ReadOnly = true;
            // 
            // DGV_AlumnosActivos_Apellido
            // 
            this.DGV_AlumnosActivos_Apellido.HeaderText = "Column1";
            this.DGV_AlumnosActivos_Apellido.Name = "DGV_AlumnosActivos_Apellido";
            this.DGV_AlumnosActivos_Apellido.ReadOnly = true;
            // 
            // DGV_AlumnosActivos_Nombre
            // 
            this.DGV_AlumnosActivos_Nombre.HeaderText = "Column1";
            this.DGV_AlumnosActivos_Nombre.Name = "DGV_AlumnosActivos_Nombre";
            this.DGV_AlumnosActivos_Nombre.ReadOnly = true;
            // 
            // DGV_AlumnosActivos_Turno
            // 
            this.DGV_AlumnosActivos_Turno.HeaderText = "Column1";
            this.DGV_AlumnosActivos_Turno.Name = "DGV_AlumnosActivos_Turno";
            this.DGV_AlumnosActivos_Turno.ReadOnly = true;
            // 
            // rbAlumnosInactivos
            // 
            this.rbAlumnosInactivos.AutoSize = true;
            this.rbAlumnosInactivos.Location = new System.Drawing.Point(6, 44);
            this.rbAlumnosInactivos.Name = "rbAlumnosInactivos";
            this.rbAlumnosInactivos.Size = new System.Drawing.Size(85, 17);
            this.rbAlumnosInactivos.TabIndex = 25;
            this.rbAlumnosInactivos.Text = "radioButton2";
            this.rbAlumnosInactivos.UseVisualStyleBackColor = true;
            this.rbAlumnosInactivos.CheckedChanged += new System.EventHandler(this.rbAlumnosInactivos_CheckedChanged);
            // 
            // rbAlumnosActivos
            // 
            this.rbAlumnosActivos.AutoSize = true;
            this.rbAlumnosActivos.Checked = true;
            this.rbAlumnosActivos.Location = new System.Drawing.Point(6, 21);
            this.rbAlumnosActivos.Name = "rbAlumnosActivos";
            this.rbAlumnosActivos.Size = new System.Drawing.Size(85, 17);
            this.rbAlumnosActivos.TabIndex = 24;
            this.rbAlumnosActivos.TabStop = true;
            this.rbAlumnosActivos.Text = "radioButton1";
            this.rbAlumnosActivos.UseVisualStyleBackColor = true;
            this.rbAlumnosActivos.CheckedChanged += new System.EventHandler(this.rbAlumnosActivos_CheckedChanged);
            // 
            // btnVerCursadas
            // 
            this.btnVerCursadas.Location = new System.Drawing.Point(212, 278);
            this.btnVerCursadas.Name = "btnVerCursadas";
            this.btnVerCursadas.Size = new System.Drawing.Size(94, 44);
            this.btnVerCursadas.TabIndex = 23;
            this.btnVerCursadas.Text = "button3";
            this.btnVerCursadas.UseVisualStyleBackColor = true;
            this.btnVerCursadas.Click += new System.EventHandler(this.btnVerCursadas_Click);
            // 
            // btnDarDeBajaAlumno
            // 
            this.btnDarDeBajaAlumno.Location = new System.Drawing.Point(112, 278);
            this.btnDarDeBajaAlumno.Name = "btnDarDeBajaAlumno";
            this.btnDarDeBajaAlumno.Size = new System.Drawing.Size(94, 44);
            this.btnDarDeBajaAlumno.TabIndex = 22;
            this.btnDarDeBajaAlumno.Text = "button2";
            this.btnDarDeBajaAlumno.UseVisualStyleBackColor = true;
            this.btnDarDeBajaAlumno.Click += new System.EventHandler(this.btnDarDeBajaAlumno_Click);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Location = new System.Drawing.Point(12, 278);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(94, 44);
            this.btnModificarAlumno.TabIndex = 21;
            this.btnModificarAlumno.Text = "button1";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 347);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 13);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Correo Electrónico: ";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(9, 395);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNac.TabIndex = 27;
            this.lblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // lblFechaIng
            // 
            this.lblFechaIng.AutoSize = true;
            this.lblFechaIng.Location = new System.Drawing.Point(9, 445);
            this.lblFechaIng.Name = "lblFechaIng";
            this.lblFechaIng.Size = new System.Drawing.Size(93, 13);
            this.lblFechaIng.TabIndex = 28;
            this.lblFechaIng.Text = "Fecha de Ingreso:";
            // 
            // gpAlumnosActivos
            // 
            this.gpAlumnosActivos.Controls.Add(this.rbAlumnosInactivos);
            this.gpAlumnosActivos.Controls.Add(this.rbAlumnosActivos);
            this.gpAlumnosActivos.Location = new System.Drawing.Point(312, 278);
            this.gpAlumnosActivos.Name = "gpAlumnosActivos";
            this.gpAlumnosActivos.Size = new System.Drawing.Size(106, 67);
            this.gpAlumnosActivos.TabIndex = 29;
            this.gpAlumnosActivos.TabStop = false;
            this.gpAlumnosActivos.Text = "groupBox1";
            // 
            // gpVisualizacion
            // 
            this.gpVisualizacion.Controls.Add(this.rbAlumnosTurno);
            this.gpVisualizacion.Controls.Add(this.rbAlumnosNombre);
            this.gpVisualizacion.Controls.Add(this.rbAlumnosApellido);
            this.gpVisualizacion.Controls.Add(this.rbAlumnosDNI);
            this.gpVisualizacion.Controls.Add(this.rbAlumnosLegajo);
            this.gpVisualizacion.Controls.Add(this.rbAlumnosTodos);
            this.gpVisualizacion.Location = new System.Drawing.Point(424, 278);
            this.gpVisualizacion.Name = "gpVisualizacion";
            this.gpVisualizacion.Size = new System.Drawing.Size(293, 67);
            this.gpVisualizacion.TabIndex = 30;
            this.gpVisualizacion.TabStop = false;
            this.gpVisualizacion.Text = "groupBox1";
            // 
            // rbAlumnosTurno
            // 
            this.rbAlumnosTurno.AutoSize = true;
            this.rbAlumnosTurno.Location = new System.Drawing.Point(199, 42);
            this.rbAlumnosTurno.Name = "rbAlumnosTurno";
            this.rbAlumnosTurno.Size = new System.Drawing.Size(85, 17);
            this.rbAlumnosTurno.TabIndex = 31;
            this.rbAlumnosTurno.Text = "radioButton3";
            this.rbAlumnosTurno.UseVisualStyleBackColor = true;
            this.rbAlumnosTurno.CheckedChanged += new System.EventHandler(this.rbAlumnosTurno_CheckedChanged);
            // 
            // rbAlumnosNombre
            // 
            this.rbAlumnosNombre.AutoSize = true;
            this.rbAlumnosNombre.Location = new System.Drawing.Point(199, 19);
            this.rbAlumnosNombre.Name = "rbAlumnosNombre";
            this.rbAlumnosNombre.Size = new System.Drawing.Size(85, 17);
            this.rbAlumnosNombre.TabIndex = 30;
            this.rbAlumnosNombre.Text = "radioButton3";
            this.rbAlumnosNombre.UseVisualStyleBackColor = true;
            this.rbAlumnosNombre.CheckedChanged += new System.EventHandler(this.rbAlumnosNombre_CheckedChanged);
            // 
            // rbAlumnosApellido
            // 
            this.rbAlumnosApellido.AutoSize = true;
            this.rbAlumnosApellido.Location = new System.Drawing.Point(108, 42);
            this.rbAlumnosApellido.Name = "rbAlumnosApellido";
            this.rbAlumnosApellido.Size = new System.Drawing.Size(85, 17);
            this.rbAlumnosApellido.TabIndex = 29;
            this.rbAlumnosApellido.Text = "radioButton2";
            this.rbAlumnosApellido.UseVisualStyleBackColor = true;
            this.rbAlumnosApellido.CheckedChanged += new System.EventHandler(this.rbAlumnosApellido_CheckedChanged);
            // 
            // rbAlumnosDNI
            // 
            this.rbAlumnosDNI.AutoSize = true;
            this.rbAlumnosDNI.Location = new System.Drawing.Point(108, 19);
            this.rbAlumnosDNI.Name = "rbAlumnosDNI";
            this.rbAlumnosDNI.Size = new System.Drawing.Size(85, 17);
            this.rbAlumnosDNI.TabIndex = 28;
            this.rbAlumnosDNI.Text = "radioButton1";
            this.rbAlumnosDNI.UseVisualStyleBackColor = true;
            this.rbAlumnosDNI.CheckedChanged += new System.EventHandler(this.rbAlumnosDNI_CheckedChanged);
            // 
            // rbAlumnosLegajo
            // 
            this.rbAlumnosLegajo.AutoSize = true;
            this.rbAlumnosLegajo.Location = new System.Drawing.Point(6, 42);
            this.rbAlumnosLegajo.Name = "rbAlumnosLegajo";
            this.rbAlumnosLegajo.Size = new System.Drawing.Size(93, 17);
            this.rbAlumnosLegajo.TabIndex = 27;
            this.rbAlumnosLegajo.Text = "rbAlumnosDNI";
            this.rbAlumnosLegajo.UseVisualStyleBackColor = true;
            this.rbAlumnosLegajo.CheckedChanged += new System.EventHandler(this.rbAlumnosLegajo_CheckedChanged);
            // 
            // rbAlumnosTodos
            // 
            this.rbAlumnosTodos.AutoSize = true;
            this.rbAlumnosTodos.Checked = true;
            this.rbAlumnosTodos.Location = new System.Drawing.Point(6, 19);
            this.rbAlumnosTodos.Name = "rbAlumnosTodos";
            this.rbAlumnosTodos.Size = new System.Drawing.Size(106, 17);
            this.rbAlumnosTodos.TabIndex = 26;
            this.rbAlumnosTodos.TabStop = true;
            this.rbAlumnosTodos.Text = "rbAlumnosLegajo";
            this.rbAlumnosTodos.UseVisualStyleBackColor = true;
            this.rbAlumnosTodos.CheckedChanged += new System.EventHandler(this.rbAlumnosTodos_CheckedChanged);
            // 
            // txtBoxBusqueda
            // 
            this.txtBoxBusqueda.Location = new System.Drawing.Point(424, 376);
            this.txtBoxBusqueda.Name = "txtBoxBusqueda";
            this.txtBoxBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBusqueda.TabIndex = 31;
            this.txtBoxBusqueda.TextChanged += new System.EventHandler(this.txtBoxBusqueda_TextChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(421, 360);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lblBusqueda.TabIndex = 32;
            this.lblBusqueda.Text = "label1";
            this.lblBusqueda.Click += new System.EventHandler(this.lblBusqueda_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.Color.White;
            this.txtBoxEmail.Location = new System.Drawing.Point(12, 363);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.ReadOnly = true;
            this.txtBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEmail.TabIndex = 33;
            // 
            // txtBoxFechaNac
            // 
            this.txtBoxFechaNac.BackColor = System.Drawing.Color.White;
            this.txtBoxFechaNac.Location = new System.Drawing.Point(12, 411);
            this.txtBoxFechaNac.Name = "txtBoxFechaNac";
            this.txtBoxFechaNac.ReadOnly = true;
            this.txtBoxFechaNac.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFechaNac.TabIndex = 34;
            // 
            // txtBoxFechaIng
            // 
            this.txtBoxFechaIng.BackColor = System.Drawing.Color.White;
            this.txtBoxFechaIng.Location = new System.Drawing.Point(12, 461);
            this.txtBoxFechaIng.Name = "txtBoxFechaIng";
            this.txtBoxFechaIng.ReadOnly = true;
            this.txtBoxFechaIng.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFechaIng.TabIndex = 35;
            // 
            // btnDarDeAltaAlumno
            // 
            this.btnDarDeAltaAlumno.Location = new System.Drawing.Point(112, 278);
            this.btnDarDeAltaAlumno.Name = "btnDarDeAltaAlumno";
            this.btnDarDeAltaAlumno.Size = new System.Drawing.Size(94, 44);
            this.btnDarDeAltaAlumno.TabIndex = 36;
            this.btnDarDeAltaAlumno.Text = "button2";
            this.btnDarDeAltaAlumno.UseVisualStyleBackColor = true;
            this.btnDarDeAltaAlumno.Visible = false;
            this.btnDarDeAltaAlumno.Click += new System.EventHandler(this.btnDarDeAltaAlumno_Click);
            // 
            // FormVerAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 489);
            this.Controls.Add(this.btnDarDeAltaAlumno);
            this.Controls.Add(this.txtBoxFechaIng);
            this.Controls.Add(this.txtBoxFechaNac);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtBoxBusqueda);
            this.Controls.Add(this.gpVisualizacion);
            this.Controls.Add(this.gpAlumnosActivos);
            this.Controls.Add(this.lblFechaIng);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnVerCursadas);
            this.Controls.Add(this.btnDarDeBajaAlumno);
            this.Controls.Add(this.btnModificarAlumno);
            this.Controls.Add(this.dgvAlumnosActivos);
            this.Name = "FormVerAlumnos";
            this.Text = "FormVerAlumnos";
            this.Load += new System.EventHandler(this.FormVerAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosActivos)).EndInit();
            this.gpAlumnosActivos.ResumeLayout(false);
            this.gpAlumnosActivos.PerformLayout();
            this.gpVisualizacion.ResumeLayout(false);
            this.gpVisualizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnosActivos;
        private System.Windows.Forms.RadioButton rbAlumnosInactivos;
        private System.Windows.Forms.RadioButton rbAlumnosActivos;
        private System.Windows.Forms.Button btnVerCursadas;
        private System.Windows.Forms.Button btnDarDeBajaAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblFechaIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Turno;
        private System.Windows.Forms.GroupBox gpAlumnosActivos;
        private System.Windows.Forms.GroupBox gpVisualizacion;
        private System.Windows.Forms.RadioButton rbAlumnosTurno;
        private System.Windows.Forms.RadioButton rbAlumnosNombre;
        private System.Windows.Forms.RadioButton rbAlumnosApellido;
        private System.Windows.Forms.RadioButton rbAlumnosDNI;
        private System.Windows.Forms.RadioButton rbAlumnosLegajo;
        private System.Windows.Forms.RadioButton rbAlumnosTodos;
        private System.Windows.Forms.TextBox txtBoxBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxFechaNac;
        private System.Windows.Forms.TextBox txtBoxFechaIng;
        private System.Windows.Forms.Button btnDarDeAltaAlumno;
    }
}