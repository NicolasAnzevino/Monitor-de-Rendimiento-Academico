
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerMateria
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
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.DGV_AlumnosActivos_Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEvaluaciones = new System.Windows.Forms.DataGridView();
            this.DGV_Evaluaciones_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Evaluaciones_Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Evaluaciones_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTemas = new System.Windows.Forms.ListBox();
            this.btnAgregarEvaluacion = new System.Windows.Forms.Button();
            this.btnVerCalificaciones = new System.Windows.Forms.Button();
            this.btnEliminarEvaluacion = new System.Windows.Forms.Button();
            this.btnModificarEvaluacion = new System.Windows.Forms.Button();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lblEvaluaciones = new System.Windows.Forms.Label();
            this.lblTemasDeEvaluacion = new System.Windows.Forms.Label();
            this.btnAgregarCalificacion = new System.Windows.Forms.Button();
            this.btnVerClases = new System.Windows.Forms.Button();
            this.btnAgregarClase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).BeginInit();
            this.SuspendLayout();
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
            this.DGV_AlumnosActivos_Nombre});
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 26);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(425, 250);
            this.dgvAlumnos.TabIndex = 38;
            this.dgvAlumnos.TabStop = false;
            this.dgvAlumnos.Click += new System.EventHandler(this.dgvAlumnos_Click);
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
            // dgvEvaluaciones
            // 
            this.dgvEvaluaciones.AllowUserToAddRows = false;
            this.dgvEvaluaciones.AllowUserToDeleteRows = false;
            this.dgvEvaluaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Evaluaciones_Codigo,
            this.DGV_Evaluaciones_Titulo,
            this.DGV_Evaluaciones_Fecha});
            this.dgvEvaluaciones.Location = new System.Drawing.Point(467, 26);
            this.dgvEvaluaciones.MultiSelect = false;
            this.dgvEvaluaciones.Name = "dgvEvaluaciones";
            this.dgvEvaluaciones.ReadOnly = true;
            this.dgvEvaluaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvaluaciones.Size = new System.Drawing.Size(425, 250);
            this.dgvEvaluaciones.TabIndex = 39;
            this.dgvEvaluaciones.TabStop = false;
            this.dgvEvaluaciones.Click += new System.EventHandler(this.dgvEvaluaciones_Click);
            // 
            // DGV_Evaluaciones_Codigo
            // 
            this.DGV_Evaluaciones_Codigo.HeaderText = "Column1";
            this.DGV_Evaluaciones_Codigo.Name = "DGV_Evaluaciones_Codigo";
            this.DGV_Evaluaciones_Codigo.ReadOnly = true;
            // 
            // DGV_Evaluaciones_Titulo
            // 
            this.DGV_Evaluaciones_Titulo.HeaderText = "Column1";
            this.DGV_Evaluaciones_Titulo.Name = "DGV_Evaluaciones_Titulo";
            this.DGV_Evaluaciones_Titulo.ReadOnly = true;
            // 
            // DGV_Evaluaciones_Fecha
            // 
            this.DGV_Evaluaciones_Fecha.HeaderText = "Column1";
            this.DGV_Evaluaciones_Fecha.Name = "DGV_Evaluaciones_Fecha";
            this.DGV_Evaluaciones_Fecha.ReadOnly = true;
            // 
            // lbTemas
            // 
            this.lbTemas.FormattingEnabled = true;
            this.lbTemas.Location = new System.Drawing.Point(898, 26);
            this.lbTemas.Name = "lbTemas";
            this.lbTemas.Size = new System.Drawing.Size(151, 251);
            this.lbTemas.TabIndex = 40;
            // 
            // btnAgregarEvaluacion
            // 
            this.btnAgregarEvaluacion.Location = new System.Drawing.Point(467, 282);
            this.btnAgregarEvaluacion.Name = "btnAgregarEvaluacion";
            this.btnAgregarEvaluacion.Size = new System.Drawing.Size(97, 46);
            this.btnAgregarEvaluacion.TabIndex = 41;
            this.btnAgregarEvaluacion.Text = "button1";
            this.btnAgregarEvaluacion.UseVisualStyleBackColor = true;
            this.btnAgregarEvaluacion.Click += new System.EventHandler(this.btnAgregarEvaluacion_Click);
            // 
            // btnVerCalificaciones
            // 
            this.btnVerCalificaciones.Location = new System.Drawing.Point(12, 282);
            this.btnVerCalificaciones.Name = "btnVerCalificaciones";
            this.btnVerCalificaciones.Size = new System.Drawing.Size(97, 46);
            this.btnVerCalificaciones.TabIndex = 42;
            this.btnVerCalificaciones.Text = "button2";
            this.btnVerCalificaciones.UseVisualStyleBackColor = true;
            this.btnVerCalificaciones.Click += new System.EventHandler(this.btnVerCalificaciones_Click);
            // 
            // btnEliminarEvaluacion
            // 
            this.btnEliminarEvaluacion.Location = new System.Drawing.Point(570, 282);
            this.btnEliminarEvaluacion.Name = "btnEliminarEvaluacion";
            this.btnEliminarEvaluacion.Size = new System.Drawing.Size(97, 46);
            this.btnEliminarEvaluacion.TabIndex = 43;
            this.btnEliminarEvaluacion.Text = "button1";
            this.btnEliminarEvaluacion.UseVisualStyleBackColor = true;
            this.btnEliminarEvaluacion.Click += new System.EventHandler(this.btnEliminarEvaluacion_Click);
            // 
            // btnModificarEvaluacion
            // 
            this.btnModificarEvaluacion.Location = new System.Drawing.Point(673, 282);
            this.btnModificarEvaluacion.Name = "btnModificarEvaluacion";
            this.btnModificarEvaluacion.Size = new System.Drawing.Size(97, 46);
            this.btnModificarEvaluacion.TabIndex = 44;
            this.btnModificarEvaluacion.Text = "button1";
            this.btnModificarEvaluacion.UseVisualStyleBackColor = true;
            this.btnModificarEvaluacion.Click += new System.EventHandler(this.btnModificarEvaluacion_Click);
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Location = new System.Drawing.Point(197, 10);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(35, 13);
            this.lblAlumnos.TabIndex = 45;
            this.lblAlumnos.Text = "label1";
            // 
            // lblEvaluaciones
            // 
            this.lblEvaluaciones.AutoSize = true;
            this.lblEvaluaciones.Location = new System.Drawing.Point(681, 10);
            this.lblEvaluaciones.Name = "lblEvaluaciones";
            this.lblEvaluaciones.Size = new System.Drawing.Size(35, 13);
            this.lblEvaluaciones.TabIndex = 46;
            this.lblEvaluaciones.Text = "label1";
            // 
            // lblTemasDeEvaluacion
            // 
            this.lblTemasDeEvaluacion.AutoSize = true;
            this.lblTemasDeEvaluacion.Location = new System.Drawing.Point(898, 10);
            this.lblTemasDeEvaluacion.Name = "lblTemasDeEvaluacion";
            this.lblTemasDeEvaluacion.Size = new System.Drawing.Size(35, 13);
            this.lblTemasDeEvaluacion.TabIndex = 47;
            this.lblTemasDeEvaluacion.Text = "label1";
            // 
            // btnAgregarCalificacion
            // 
            this.btnAgregarCalificacion.Location = new System.Drawing.Point(115, 282);
            this.btnAgregarCalificacion.Name = "btnAgregarCalificacion";
            this.btnAgregarCalificacion.Size = new System.Drawing.Size(97, 46);
            this.btnAgregarCalificacion.TabIndex = 48;
            this.btnAgregarCalificacion.Text = "button2";
            this.btnAgregarCalificacion.UseVisualStyleBackColor = true;
            this.btnAgregarCalificacion.Click += new System.EventHandler(this.btnAgregarCalificacion_Click);
            // 
            // btnVerClases
            // 
            this.btnVerClases.Location = new System.Drawing.Point(237, 282);
            this.btnVerClases.Name = "btnVerClases";
            this.btnVerClases.Size = new System.Drawing.Size(97, 46);
            this.btnVerClases.TabIndex = 49;
            this.btnVerClases.Text = "button2";
            this.btnVerClases.UseVisualStyleBackColor = true;
            this.btnVerClases.Click += new System.EventHandler(this.btnVerClases_Click);
            // 
            // btnAgregarClase
            // 
            this.btnAgregarClase.Location = new System.Drawing.Point(340, 282);
            this.btnAgregarClase.Name = "btnAgregarClase";
            this.btnAgregarClase.Size = new System.Drawing.Size(97, 46);
            this.btnAgregarClase.TabIndex = 50;
            this.btnAgregarClase.Text = "button2";
            this.btnAgregarClase.UseVisualStyleBackColor = true;
            this.btnAgregarClase.Click += new System.EventHandler(this.btnAgregarClase_Click);
            // 
            // FormVerMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 350);
            this.Controls.Add(this.btnAgregarClase);
            this.Controls.Add(this.btnVerClases);
            this.Controls.Add(this.btnAgregarCalificacion);
            this.Controls.Add(this.lblTemasDeEvaluacion);
            this.Controls.Add(this.lblEvaluaciones);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.btnModificarEvaluacion);
            this.Controls.Add(this.btnEliminarEvaluacion);
            this.Controls.Add(this.btnVerCalificaciones);
            this.Controls.Add(this.btnAgregarEvaluacion);
            this.Controls.Add(this.lbTemas);
            this.Controls.Add(this.dgvEvaluaciones);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "FormVerMateria";
            this.Text = "FormVerMateria";
            this.Load += new System.EventHandler(this.FormVerMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Nombre;
        private System.Windows.Forms.DataGridView dgvEvaluaciones;
        private System.Windows.Forms.ListBox lbTemas;
        private System.Windows.Forms.Button btnAgregarEvaluacion;
        private System.Windows.Forms.Button btnVerCalificaciones;
        private System.Windows.Forms.Button btnEliminarEvaluacion;
        private System.Windows.Forms.Button btnModificarEvaluacion;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Label lblEvaluaciones;
        private System.Windows.Forms.Label lblTemasDeEvaluacion;
        private System.Windows.Forms.Button btnAgregarCalificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Evaluaciones_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Evaluaciones_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Evaluaciones_Fecha;
        private System.Windows.Forms.Button btnVerClases;
        private System.Windows.Forms.Button btnAgregarClase;
    }
}