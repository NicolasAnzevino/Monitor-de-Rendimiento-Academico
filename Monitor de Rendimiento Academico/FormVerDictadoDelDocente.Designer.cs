
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerDictadoDelDocente
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
            this.lblEvaluaciones = new System.Windows.Forms.Label();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.btnVerCalificaciones = new System.Windows.Forms.Button();
            this.lbTemas = new System.Windows.Forms.ListBox();
            this.DGV_Evaluaciones_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Evaluaciones_Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Evaluaciones_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEvaluaciones = new System.Windows.Forms.DataGridView();
            this.DGV_AlumnosActivos_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTemasDeEvaluacion = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.lbTemasMateria = new System.Windows.Forms.ListBox();
            this.lblTemasMateria = new System.Windows.Forms.Label();
            this.btnVerClases = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEvaluaciones
            // 
            this.lblEvaluaciones.AutoSize = true;
            this.lblEvaluaciones.Location = new System.Drawing.Point(681, 9);
            this.lblEvaluaciones.Name = "lblEvaluaciones";
            this.lblEvaluaciones.Size = new System.Drawing.Size(35, 13);
            this.lblEvaluaciones.TabIndex = 57;
            this.lblEvaluaciones.Text = "label1";
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Location = new System.Drawing.Point(197, 9);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(35, 13);
            this.lblAlumnos.TabIndex = 56;
            this.lblAlumnos.Text = "label1";
            // 
            // btnVerCalificaciones
            // 
            this.btnVerCalificaciones.Location = new System.Drawing.Point(12, 281);
            this.btnVerCalificaciones.Name = "btnVerCalificaciones";
            this.btnVerCalificaciones.Size = new System.Drawing.Size(117, 51);
            this.btnVerCalificaciones.TabIndex = 53;
            this.btnVerCalificaciones.Text = "button2";
            this.btnVerCalificaciones.UseVisualStyleBackColor = true;
            this.btnVerCalificaciones.Click += new System.EventHandler(this.btnVerCalificaciones_Click);
            // 
            // lbTemas
            // 
            this.lbTemas.FormattingEnabled = true;
            this.lbTemas.Location = new System.Drawing.Point(898, 25);
            this.lbTemas.Name = "lbTemas";
            this.lbTemas.Size = new System.Drawing.Size(151, 251);
            this.lbTemas.TabIndex = 51;
            // 
            // DGV_Evaluaciones_Fecha
            // 
            this.DGV_Evaluaciones_Fecha.HeaderText = "Column1";
            this.DGV_Evaluaciones_Fecha.Name = "DGV_Evaluaciones_Fecha";
            this.DGV_Evaluaciones_Fecha.ReadOnly = true;
            // 
            // DGV_Evaluaciones_Titulo
            // 
            this.DGV_Evaluaciones_Titulo.HeaderText = "Column1";
            this.DGV_Evaluaciones_Titulo.Name = "DGV_Evaluaciones_Titulo";
            this.DGV_Evaluaciones_Titulo.ReadOnly = true;
            // 
            // DGV_Evaluaciones_Codigo
            // 
            this.DGV_Evaluaciones_Codigo.HeaderText = "Column1";
            this.DGV_Evaluaciones_Codigo.Name = "DGV_Evaluaciones_Codigo";
            this.DGV_Evaluaciones_Codigo.ReadOnly = true;
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
            this.dgvEvaluaciones.Location = new System.Drawing.Point(467, 25);
            this.dgvEvaluaciones.MultiSelect = false;
            this.dgvEvaluaciones.Name = "dgvEvaluaciones";
            this.dgvEvaluaciones.ReadOnly = true;
            this.dgvEvaluaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvaluaciones.Size = new System.Drawing.Size(425, 250);
            this.dgvEvaluaciones.TabIndex = 50;
            this.dgvEvaluaciones.TabStop = false;
            this.dgvEvaluaciones.Click += new System.EventHandler(this.dgvEvaluaciones_Click);
            // 
            // DGV_AlumnosActivos_Nombre
            // 
            this.DGV_AlumnosActivos_Nombre.HeaderText = "Column1";
            this.DGV_AlumnosActivos_Nombre.Name = "DGV_AlumnosActivos_Nombre";
            this.DGV_AlumnosActivos_Nombre.ReadOnly = true;
            // 
            // DGV_AlumnosActivos_Apellido
            // 
            this.DGV_AlumnosActivos_Apellido.HeaderText = "Column1";
            this.DGV_AlumnosActivos_Apellido.Name = "DGV_AlumnosActivos_Apellido";
            this.DGV_AlumnosActivos_Apellido.ReadOnly = true;
            // 
            // DGV_AlumnosActivos_DNI
            // 
            this.DGV_AlumnosActivos_DNI.HeaderText = "Column1";
            this.DGV_AlumnosActivos_DNI.Name = "DGV_AlumnosActivos_DNI";
            this.DGV_AlumnosActivos_DNI.ReadOnly = true;
            // 
            // DGV_AlumnosActivos_Legajo
            // 
            this.DGV_AlumnosActivos_Legajo.HeaderText = "Column1";
            this.DGV_AlumnosActivos_Legajo.Name = "DGV_AlumnosActivos_Legajo";
            this.DGV_AlumnosActivos_Legajo.ReadOnly = true;
            // 
            // lblTemasDeEvaluacion
            // 
            this.lblTemasDeEvaluacion.AutoSize = true;
            this.lblTemasDeEvaluacion.Location = new System.Drawing.Point(898, 9);
            this.lblTemasDeEvaluacion.Name = "lblTemasDeEvaluacion";
            this.lblTemasDeEvaluacion.Size = new System.Drawing.Size(35, 13);
            this.lblTemasDeEvaluacion.TabIndex = 58;
            this.lblTemasDeEvaluacion.Text = "label1";
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
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 25);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(425, 250);
            this.dgvAlumnos.TabIndex = 49;
            this.dgvAlumnos.TabStop = false;
            this.dgvAlumnos.Click += new System.EventHandler(this.dgvAlumnos_Click);
            // 
            // lbTemasMateria
            // 
            this.lbTemasMateria.FormattingEnabled = true;
            this.lbTemasMateria.Location = new System.Drawing.Point(1055, 24);
            this.lbTemasMateria.Name = "lbTemasMateria";
            this.lbTemasMateria.Size = new System.Drawing.Size(151, 251);
            this.lbTemasMateria.TabIndex = 59;
            // 
            // lblTemasMateria
            // 
            this.lblTemasMateria.AutoSize = true;
            this.lblTemasMateria.Location = new System.Drawing.Point(1055, 8);
            this.lblTemasMateria.Name = "lblTemasMateria";
            this.lblTemasMateria.Size = new System.Drawing.Size(35, 13);
            this.lblTemasMateria.TabIndex = 60;
            this.lblTemasMateria.Text = "label1";
            // 
            // btnVerClases
            // 
            this.btnVerClases.Location = new System.Drawing.Point(135, 281);
            this.btnVerClases.Name = "btnVerClases";
            this.btnVerClases.Size = new System.Drawing.Size(117, 51);
            this.btnVerClases.TabIndex = 61;
            this.btnVerClases.Text = "button2";
            this.btnVerClases.UseVisualStyleBackColor = true;
            this.btnVerClases.Click += new System.EventHandler(this.btnVerClases_Click);
            // 
            // FormVerDictadoDelDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 344);
            this.Controls.Add(this.btnVerClases);
            this.Controls.Add(this.lbTemasMateria);
            this.Controls.Add(this.lblTemasMateria);
            this.Controls.Add(this.lblEvaluaciones);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.btnVerCalificaciones);
            this.Controls.Add(this.lbTemas);
            this.Controls.Add(this.dgvEvaluaciones);
            this.Controls.Add(this.lblTemasDeEvaluacion);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "FormVerDictadoDelDocente";
            this.Text = "FormVerDictadoDelDocente";
            this.Load += new System.EventHandler(this.FormVerDictadoDelDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEvaluaciones;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Button btnVerCalificaciones;
        private System.Windows.Forms.ListBox lbTemas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Evaluaciones_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Evaluaciones_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Evaluaciones_Codigo;
        private System.Windows.Forms.DataGridView dgvEvaluaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Legajo;
        private System.Windows.Forms.Label lblTemasDeEvaluacion;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.ListBox lbTemasMateria;
        private System.Windows.Forms.Label lblTemasMateria;
        private System.Windows.Forms.Button btnVerClases;
    }
}