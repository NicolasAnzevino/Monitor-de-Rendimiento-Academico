
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormRegistrarAsistencia
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
            this.lblFechaHoy = new System.Windows.Forms.Label();
            this.btnEnviarAsistencias = new System.Windows.Forms.Button();
            this.lblDiaHoy = new System.Windows.Forms.Label();
            this.dgvAlumnosAsistencia = new System.Windows.Forms.DataGridView();
            this.panelInasistencia = new System.Windows.Forms.Panel();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.txtBoxValor = new System.Windows.Forms.TextBox();
            this.btnQuitarInasistencia = new System.Windows.Forms.Button();
            this.btnAgregarFalta = new System.Windows.Forms.Button();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.lblJustificacion = new System.Windows.Forms.Label();
            this.txtBoxJustificacion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtBoxFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.DGV_CursosActivos_Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosAsistencia_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosAsistencia_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosAsistencia_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosAsistencia_Asistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosAsistencia)).BeginInit();
            this.panelInasistencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaHoy
            // 
            this.lblFechaHoy.AutoSize = true;
            this.lblFechaHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoy.Location = new System.Drawing.Point(239, 9);
            this.lblFechaHoy.Name = "lblFechaHoy";
            this.lblFechaHoy.Size = new System.Drawing.Size(72, 16);
            this.lblFechaHoy.TabIndex = 1;
            this.lblFechaHoy.Text = "25/10/2021";
            // 
            // btnEnviarAsistencias
            // 
            this.btnEnviarAsistencias.Location = new System.Drawing.Point(756, 357);
            this.btnEnviarAsistencias.Name = "btnEnviarAsistencias";
            this.btnEnviarAsistencias.Size = new System.Drawing.Size(117, 50);
            this.btnEnviarAsistencias.TabIndex = 2;
            this.btnEnviarAsistencias.Text = "button1";
            this.btnEnviarAsistencias.UseVisualStyleBackColor = true;
            this.btnEnviarAsistencias.Click += new System.EventHandler(this.btnEnviarAsistencias_Click);
            // 
            // lblDiaHoy
            // 
            this.lblDiaHoy.AutoSize = true;
            this.lblDiaHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaHoy.Location = new System.Drawing.Point(239, 25);
            this.lblDiaHoy.Name = "lblDiaHoy";
            this.lblDiaHoy.Size = new System.Drawing.Size(53, 18);
            this.lblDiaHoy.TabIndex = 3;
            this.lblDiaHoy.Text = "Lunes";
            // 
            // dgvAlumnosAsistencia
            // 
            this.dgvAlumnosAsistencia.AllowUserToAddRows = false;
            this.dgvAlumnosAsistencia.AllowUserToDeleteRows = false;
            this.dgvAlumnosAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnosAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_CursosActivos_Legajo,
            this.DGV_AlumnosAsistencia_Apellido,
            this.DGV_AlumnosAsistencia_Nombre,
            this.DGV_AlumnosAsistencia_DNI,
            this.DGV_AlumnosAsistencia_Asistencia});
            this.dgvAlumnosAsistencia.Location = new System.Drawing.Point(12, 9);
            this.dgvAlumnosAsistencia.MultiSelect = false;
            this.dgvAlumnosAsistencia.Name = "dgvAlumnosAsistencia";
            this.dgvAlumnosAsistencia.ReadOnly = true;
            this.dgvAlumnosAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnosAsistencia.Size = new System.Drawing.Size(392, 400);
            this.dgvAlumnosAsistencia.TabIndex = 21;
            this.dgvAlumnosAsistencia.TabStop = false;
            this.dgvAlumnosAsistencia.Click += new System.EventHandler(this.dgvAlumnosAsistencia_Click);
            // 
            // panelInasistencia
            // 
            this.panelInasistencia.BackColor = System.Drawing.SystemColors.Info;
            this.panelInasistencia.Controls.Add(this.btnRestar);
            this.panelInasistencia.Controls.Add(this.btnSumar);
            this.panelInasistencia.Controls.Add(this.txtBoxValor);
            this.panelInasistencia.Controls.Add(this.btnQuitarInasistencia);
            this.panelInasistencia.Controls.Add(this.btnAgregarFalta);
            this.panelInasistencia.Controls.Add(this.txtBoxDescripcion);
            this.panelInasistencia.Controls.Add(this.lblDiaHoy);
            this.panelInasistencia.Controls.Add(this.lblJustificacion);
            this.panelInasistencia.Controls.Add(this.txtBoxJustificacion);
            this.panelInasistencia.Controls.Add(this.lblFechaHoy);
            this.panelInasistencia.Controls.Add(this.lblDescripcion);
            this.panelInasistencia.Controls.Add(this.lblValor);
            this.panelInasistencia.Controls.Add(this.txtBoxFecha);
            this.panelInasistencia.Controls.Add(this.lblFecha);
            this.panelInasistencia.Location = new System.Drawing.Point(410, 9);
            this.panelInasistencia.Name = "panelInasistencia";
            this.panelInasistencia.Size = new System.Drawing.Size(319, 400);
            this.panelInasistencia.TabIndex = 22;
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(135, 88);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(20, 23);
            this.btnRestar.TabIndex = 27;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(109, 88);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(20, 23);
            this.btnSumar.TabIndex = 26;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // txtBoxValor
            // 
            this.txtBoxValor.BackColor = System.Drawing.Color.White;
            this.txtBoxValor.Location = new System.Drawing.Point(3, 90);
            this.txtBoxValor.MaxLength = 77;
            this.txtBoxValor.Name = "txtBoxValor";
            this.txtBoxValor.ReadOnly = true;
            this.txtBoxValor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValor.TabIndex = 25;
            // 
            // btnQuitarInasistencia
            // 
            this.btnQuitarInasistencia.Location = new System.Drawing.Point(73, 348);
            this.btnQuitarInasistencia.Name = "btnQuitarInasistencia";
            this.btnQuitarInasistencia.Size = new System.Drawing.Size(116, 50);
            this.btnQuitarInasistencia.TabIndex = 24;
            this.btnQuitarInasistencia.Text = "button1";
            this.btnQuitarInasistencia.UseVisualStyleBackColor = true;
            this.btnQuitarInasistencia.Click += new System.EventHandler(this.btnQuitarInasistencia_Click);
            // 
            // btnAgregarFalta
            // 
            this.btnAgregarFalta.Location = new System.Drawing.Point(195, 348);
            this.btnAgregarFalta.Name = "btnAgregarFalta";
            this.btnAgregarFalta.Size = new System.Drawing.Size(116, 49);
            this.btnAgregarFalta.TabIndex = 23;
            this.btnAgregarFalta.Text = "button1";
            this.btnAgregarFalta.UseVisualStyleBackColor = true;
            this.btnAgregarFalta.Click += new System.EventHandler(this.btnAgregarFalta_Click);
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(3, 154);
            this.txtBoxDescripcion.MaxLength = 77;
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(201, 61);
            this.txtBoxDescripcion.TabIndex = 7;
            // 
            // lblJustificacion
            // 
            this.lblJustificacion.AutoSize = true;
            this.lblJustificacion.Location = new System.Drawing.Point(3, 231);
            this.lblJustificacion.Name = "lblJustificacion";
            this.lblJustificacion.Size = new System.Drawing.Size(35, 13);
            this.lblJustificacion.TabIndex = 6;
            this.lblJustificacion.Text = "label3";
            // 
            // txtBoxJustificacion
            // 
            this.txtBoxJustificacion.Location = new System.Drawing.Point(3, 247);
            this.txtBoxJustificacion.MaxLength = 77;
            this.txtBoxJustificacion.Multiline = true;
            this.txtBoxJustificacion.Name = "txtBoxJustificacion";
            this.txtBoxJustificacion.Size = new System.Drawing.Size(201, 71);
            this.txtBoxJustificacion.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 138);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(35, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "label3";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(3, 74);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(35, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "label3";
            // 
            // txtBoxFecha
            // 
            this.txtBoxFecha.BackColor = System.Drawing.Color.White;
            this.txtBoxFecha.Location = new System.Drawing.Point(3, 41);
            this.txtBoxFecha.MaxLength = 77;
            this.txtBoxFecha.Name = "txtBoxFecha";
            this.txtBoxFecha.ReadOnly = true;
            this.txtBoxFecha.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFecha.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(3, 25);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "label3";
            // 
            // DGV_CursosActivos_Legajo
            // 
            this.DGV_CursosActivos_Legajo.HeaderText = "Column1";
            this.DGV_CursosActivos_Legajo.Name = "DGV_CursosActivos_Legajo";
            this.DGV_CursosActivos_Legajo.ReadOnly = true;
            // 
            // DGV_AlumnosAsistencia_Apellido
            // 
            this.DGV_AlumnosAsistencia_Apellido.HeaderText = "Column1";
            this.DGV_AlumnosAsistencia_Apellido.Name = "DGV_AlumnosAsistencia_Apellido";
            this.DGV_AlumnosAsistencia_Apellido.ReadOnly = true;
            // 
            // DGV_AlumnosAsistencia_Nombre
            // 
            this.DGV_AlumnosAsistencia_Nombre.HeaderText = "Column1";
            this.DGV_AlumnosAsistencia_Nombre.Name = "DGV_AlumnosAsistencia_Nombre";
            this.DGV_AlumnosAsistencia_Nombre.ReadOnly = true;
            // 
            // DGV_AlumnosAsistencia_DNI
            // 
            this.DGV_AlumnosAsistencia_DNI.HeaderText = "Column1";
            this.DGV_AlumnosAsistencia_DNI.Name = "DGV_AlumnosAsistencia_DNI";
            this.DGV_AlumnosAsistencia_DNI.ReadOnly = true;
            // 
            // DGV_AlumnosAsistencia_Asistencia
            // 
            this.DGV_AlumnosAsistencia_Asistencia.HeaderText = "Column1";
            this.DGV_AlumnosAsistencia_Asistencia.Name = "DGV_AlumnosAsistencia_Asistencia";
            this.DGV_AlumnosAsistencia_Asistencia.ReadOnly = true;
            // 
            // FormRegistrarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 412);
            this.Controls.Add(this.panelInasistencia);
            this.Controls.Add(this.dgvAlumnosAsistencia);
            this.Controls.Add(this.btnEnviarAsistencias);
            this.Name = "FormRegistrarAsistencia";
            this.Text = "FormRegistrarAsistencia";
            this.Load += new System.EventHandler(this.FormRegistrarAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosAsistencia)).EndInit();
            this.panelInasistencia.ResumeLayout(false);
            this.panelInasistencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFechaHoy;
        private System.Windows.Forms.Button btnEnviarAsistencias;
        private System.Windows.Forms.Label lblDiaHoy;
        private System.Windows.Forms.DataGridView dgvAlumnosAsistencia;
        private System.Windows.Forms.Panel panelInasistencia;
        private System.Windows.Forms.Button btnQuitarInasistencia;
        private System.Windows.Forms.Button btnAgregarFalta;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Label lblJustificacion;
        private System.Windows.Forms.TextBox txtBoxJustificacion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtBoxFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.TextBox txtBoxValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosAsistencia_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosAsistencia_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosAsistencia_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosAsistencia_Asistencia;
    }
}