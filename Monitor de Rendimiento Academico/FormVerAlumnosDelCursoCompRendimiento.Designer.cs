
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerAlumnosDelCursoCompRendimiento
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
            this.btnSeleccionarAlumno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
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
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 12);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(702, 241);
            this.dgvAlumnos.TabIndex = 39;
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
            // btnSeleccionarAlumno
            // 
            this.btnSeleccionarAlumno.Location = new System.Drawing.Point(12, 259);
            this.btnSeleccionarAlumno.Name = "btnSeleccionarAlumno";
            this.btnSeleccionarAlumno.Size = new System.Drawing.Size(112, 57);
            this.btnSeleccionarAlumno.TabIndex = 48;
            this.btnSeleccionarAlumno.Text = "button1";
            this.btnSeleccionarAlumno.UseVisualStyleBackColor = true;
            this.btnSeleccionarAlumno.Click += new System.EventHandler(this.btnSeleccionarAlumno_Click);
            // 
            // FormVerAlumnosDelCursoCompRendimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 327);
            this.Controls.Add(this.btnSeleccionarAlumno);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "FormVerAlumnosDelCursoCompRendimiento";
            this.Text = "FormVerAlumnosDelCursoCompararRendimiento";
            this.Load += new System.EventHandler(this.FormVerAlumnosDelCursoCompararRendimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Nombre;
        private System.Windows.Forms.Button btnSeleccionarAlumno;
    }
}