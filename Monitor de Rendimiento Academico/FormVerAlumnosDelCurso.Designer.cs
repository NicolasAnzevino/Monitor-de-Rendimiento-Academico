
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerAlumnosDelCurso
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
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBoxBusqueda = new System.Windows.Forms.TextBox();
            this.gpVisualizacion = new System.Windows.Forms.GroupBox();
            this.rbAlumnosTurno = new System.Windows.Forms.RadioButton();
            this.rbAlumnosNombre = new System.Windows.Forms.RadioButton();
            this.rbAlumnosApellido = new System.Windows.Forms.RadioButton();
            this.rbAlumnosDNI = new System.Windows.Forms.RadioButton();
            this.rbAlumnosLegajo = new System.Windows.Forms.RadioButton();
            this.rbAlumnosTodos = new System.Windows.Forms.RadioButton();
            this.btnVerEvaluaciones = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.txtBoxFechaIng = new System.Windows.Forms.TextBox();
            this.txtBoxFechaNac = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblFechaIng = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.DGV_AlumnosActivos_Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_Libre = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rbRegulares = new System.Windows.Forms.RadioButton();
            this.rbLibres = new System.Windows.Forms.RadioButton();
            this.btnVerInasistencias = new System.Windows.Forms.Button();
            this.gpVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(420, 381);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lblBusqueda.TabIndex = 46;
            this.lblBusqueda.Text = "label1";
            // 
            // txtBoxBusqueda
            // 
            this.txtBoxBusqueda.Location = new System.Drawing.Point(423, 397);
            this.txtBoxBusqueda.Name = "txtBoxBusqueda";
            this.txtBoxBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBusqueda.TabIndex = 45;
            this.txtBoxBusqueda.TextChanged += new System.EventHandler(this.txtBoxBusqueda_TextChanged);
            // 
            // gpVisualizacion
            // 
            this.gpVisualizacion.Controls.Add(this.rbLibres);
            this.gpVisualizacion.Controls.Add(this.rbRegulares);
            this.gpVisualizacion.Controls.Add(this.rbAlumnosTurno);
            this.gpVisualizacion.Controls.Add(this.rbAlumnosNombre);
            this.gpVisualizacion.Controls.Add(this.rbAlumnosApellido);
            this.gpVisualizacion.Controls.Add(this.rbAlumnosDNI);
            this.gpVisualizacion.Controls.Add(this.rbAlumnosLegajo);
            this.gpVisualizacion.Controls.Add(this.rbAlumnosTodos);
            this.gpVisualizacion.Location = new System.Drawing.Point(424, 278);
            this.gpVisualizacion.Name = "gpVisualizacion";
            this.gpVisualizacion.Size = new System.Drawing.Size(293, 91);
            this.gpVisualizacion.TabIndex = 44;
            this.gpVisualizacion.TabStop = false;
            this.gpVisualizacion.Text = "groupBox1";
            // 
            // rbAlumnosTurno
            // 
            this.rbAlumnosTurno.AutoSize = true;
            this.rbAlumnosTurno.Location = new System.Drawing.Point(108, 65);
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
            this.rbAlumnosNombre.Location = new System.Drawing.Point(108, 42);
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
            this.rbAlumnosApellido.Location = new System.Drawing.Point(108, 19);
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
            this.rbAlumnosDNI.Location = new System.Drawing.Point(6, 65);
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
            // btnVerEvaluaciones
            // 
            this.btnVerEvaluaciones.Location = new System.Drawing.Point(12, 278);
            this.btnVerEvaluaciones.Name = "btnVerEvaluaciones";
            this.btnVerEvaluaciones.Size = new System.Drawing.Size(94, 44);
            this.btnVerEvaluaciones.TabIndex = 38;
            this.btnVerEvaluaciones.Text = "button1";
            this.btnVerEvaluaciones.UseVisualStyleBackColor = true;
            this.btnVerEvaluaciones.Click += new System.EventHandler(this.btnVerEvaluaciones_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_AlumnosActivos_Legajo,
            this.DGV_AlumnosActivos_DNI,
            this.DGV_AlumnosActivos_Apellido,
            this.DGV_AlumnosActivos_Nombre,
            this.DGV_AlumnosActivos_Libre});
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 12);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(705, 260);
            this.dgvAlumnos.TabIndex = 37;
            this.dgvAlumnos.TabStop = false;
            this.dgvAlumnos.Click += new System.EventHandler(this.dgvAlumnos_Click);
            // 
            // txtBoxFechaIng
            // 
            this.txtBoxFechaIng.Location = new System.Drawing.Point(12, 447);
            this.txtBoxFechaIng.Name = "txtBoxFechaIng";
            this.txtBoxFechaIng.ReadOnly = true;
            this.txtBoxFechaIng.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFechaIng.TabIndex = 52;
            // 
            // txtBoxFechaNac
            // 
            this.txtBoxFechaNac.Location = new System.Drawing.Point(12, 397);
            this.txtBoxFechaNac.Name = "txtBoxFechaNac";
            this.txtBoxFechaNac.ReadOnly = true;
            this.txtBoxFechaNac.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFechaNac.TabIndex = 51;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(12, 349);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.ReadOnly = true;
            this.txtBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEmail.TabIndex = 50;
            // 
            // lblFechaIng
            // 
            this.lblFechaIng.AutoSize = true;
            this.lblFechaIng.Location = new System.Drawing.Point(9, 431);
            this.lblFechaIng.Name = "lblFechaIng";
            this.lblFechaIng.Size = new System.Drawing.Size(93, 13);
            this.lblFechaIng.TabIndex = 49;
            this.lblFechaIng.Text = "Fecha de Ingreso:";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(9, 381);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNac.TabIndex = 48;
            this.lblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 333);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 13);
            this.lblEmail.TabIndex = 47;
            this.lblEmail.Text = "Correo Electrónico: ";
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
            // DGV_AlumnosActivos_Libre
            // 
            this.DGV_AlumnosActivos_Libre.HeaderText = "Column1";
            this.DGV_AlumnosActivos_Libre.Name = "DGV_AlumnosActivos_Libre";
            this.DGV_AlumnosActivos_Libre.ReadOnly = true;
            this.DGV_AlumnosActivos_Libre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_AlumnosActivos_Libre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rbRegulares
            // 
            this.rbRegulares.AutoSize = true;
            this.rbRegulares.Location = new System.Drawing.Point(199, 19);
            this.rbRegulares.Name = "rbRegulares";
            this.rbRegulares.Size = new System.Drawing.Size(85, 17);
            this.rbRegulares.TabIndex = 32;
            this.rbRegulares.Text = "radioButton3";
            this.rbRegulares.UseVisualStyleBackColor = true;
            this.rbRegulares.CheckedChanged += new System.EventHandler(this.rbRegulares_CheckedChanged);
            // 
            // rbLibres
            // 
            this.rbLibres.AutoSize = true;
            this.rbLibres.Location = new System.Drawing.Point(199, 42);
            this.rbLibres.Name = "rbLibres";
            this.rbLibres.Size = new System.Drawing.Size(85, 17);
            this.rbLibres.TabIndex = 33;
            this.rbLibres.Text = "radioButton3";
            this.rbLibres.UseVisualStyleBackColor = true;
            this.rbLibres.CheckedChanged += new System.EventHandler(this.rbLibres_CheckedChanged);
            // 
            // btnVerInasistencias
            // 
            this.btnVerInasistencias.Location = new System.Drawing.Point(112, 278);
            this.btnVerInasistencias.Name = "btnVerInasistencias";
            this.btnVerInasistencias.Size = new System.Drawing.Size(94, 44);
            this.btnVerInasistencias.TabIndex = 53;
            this.btnVerInasistencias.Text = "button1";
            this.btnVerInasistencias.UseVisualStyleBackColor = true;
            this.btnVerInasistencias.Click += new System.EventHandler(this.btnVerInasistencias_Click);
            // 
            // FormVerAlumnosDelCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 473);
            this.Controls.Add(this.btnVerInasistencias);
            this.Controls.Add(this.txtBoxFechaIng);
            this.Controls.Add(this.txtBoxFechaNac);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblFechaIng);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtBoxBusqueda);
            this.Controls.Add(this.gpVisualizacion);
            this.Controls.Add(this.btnVerEvaluaciones);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "FormVerAlumnosDelCurso";
            this.Text = "FormVerAlumnosDelCurso";
            this.Load += new System.EventHandler(this.FormVerAlumnosDelCurso_Load);
            this.gpVisualizacion.ResumeLayout(false);
            this.gpVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBoxBusqueda;
        private System.Windows.Forms.GroupBox gpVisualizacion;
        private System.Windows.Forms.RadioButton rbAlumnosTurno;
        private System.Windows.Forms.RadioButton rbAlumnosNombre;
        private System.Windows.Forms.RadioButton rbAlumnosApellido;
        private System.Windows.Forms.RadioButton rbAlumnosDNI;
        private System.Windows.Forms.RadioButton rbAlumnosLegajo;
        private System.Windows.Forms.RadioButton rbAlumnosTodos;
        private System.Windows.Forms.Button btnVerEvaluaciones;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.TextBox txtBoxFechaIng;
        private System.Windows.Forms.TextBox txtBoxFechaNac;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblFechaIng;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_AlumnosActivos_Libre;
        private System.Windows.Forms.RadioButton rbLibres;
        private System.Windows.Forms.RadioButton rbRegulares;
        private System.Windows.Forms.Button btnVerInasistencias;
    }
}