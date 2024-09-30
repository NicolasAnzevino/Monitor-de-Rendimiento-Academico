
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerRespuestaAlumnoEncuesta
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
            this.DGV_AlumnosActivos_Apellido_Y_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_Completo_Encuesta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lblEstadoEncuesta = new System.Windows.Forms.Label();
            this.txtBoxEstadoEncuesta = new System.Windows.Forms.RichTextBox();
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
            this.DGV_AlumnosActivos_Apellido_Y_Nombre,
            this.DGV_AlumnosActivos_Completo_Encuesta});
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 31);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(385, 305);
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
            // DGV_AlumnosActivos_Apellido_Y_Nombre
            // 
            this.DGV_AlumnosActivos_Apellido_Y_Nombre.HeaderText = "Column1";
            this.DGV_AlumnosActivos_Apellido_Y_Nombre.Name = "DGV_AlumnosActivos_Apellido_Y_Nombre";
            this.DGV_AlumnosActivos_Apellido_Y_Nombre.ReadOnly = true;
            // 
            // DGV_AlumnosActivos_Completo_Encuesta
            // 
            this.DGV_AlumnosActivos_Completo_Encuesta.HeaderText = "Column1";
            this.DGV_AlumnosActivos_Completo_Encuesta.Name = "DGV_AlumnosActivos_Completo_Encuesta";
            this.DGV_AlumnosActivos_Completo_Encuesta.ReadOnly = true;
            this.DGV_AlumnosActivos_Completo_Encuesta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_AlumnosActivos_Completo_Encuesta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Location = new System.Drawing.Point(12, 15);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(35, 13);
            this.lblAlumnos.TabIndex = 40;
            this.lblAlumnos.Text = "label1";
            // 
            // lblEstadoEncuesta
            // 
            this.lblEstadoEncuesta.AutoSize = true;
            this.lblEstadoEncuesta.Location = new System.Drawing.Point(403, 15);
            this.lblEstadoEncuesta.Name = "lblEstadoEncuesta";
            this.lblEstadoEncuesta.Size = new System.Drawing.Size(35, 13);
            this.lblEstadoEncuesta.TabIndex = 41;
            this.lblEstadoEncuesta.Text = "label1";
            // 
            // txtBoxEstadoEncuesta
            // 
            this.txtBoxEstadoEncuesta.BackColor = System.Drawing.Color.White;
            this.txtBoxEstadoEncuesta.Location = new System.Drawing.Point(403, 31);
            this.txtBoxEstadoEncuesta.Name = "txtBoxEstadoEncuesta";
            this.txtBoxEstadoEncuesta.ReadOnly = true;
            this.txtBoxEstadoEncuesta.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtBoxEstadoEncuesta.Size = new System.Drawing.Size(385, 305);
            this.txtBoxEstadoEncuesta.TabIndex = 42;
            this.txtBoxEstadoEncuesta.Text = "";
            // 
            // FormVerRespuestaAlumnoEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.txtBoxEstadoEncuesta);
            this.Controls.Add(this.lblEstadoEncuesta);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "FormVerRespuestaAlumnoEncuesta";
            this.Text = "VerRespuestaAlumnoEncuesta";
            this.Load += new System.EventHandler(this.VerRespuestaAlumnoEncuesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Apellido_Y_Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_AlumnosActivos_Completo_Encuesta;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Label lblEstadoEncuesta;
        private System.Windows.Forms.RichTextBox txtBoxEstadoEncuesta;
    }
}