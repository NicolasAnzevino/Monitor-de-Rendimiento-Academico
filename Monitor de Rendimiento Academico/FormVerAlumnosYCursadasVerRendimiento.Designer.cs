
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerAlumnosYCursadasVerRendimiento
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
            this.dgvCursadasAlumno = new System.Windows.Forms.DataGridView();
            this.DGV_CursadasAlumno_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursadasAlumno_Cur_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursadasAlumno_Cur_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursadasAlumno_Cur_Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursadasAlumno_Cur_Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursadasAlumno_Cur_Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnVerRendimientoDeCursada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursadasAlumno)).BeginInit();
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
            this.dgvAlumnos.Size = new System.Drawing.Size(374, 215);
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
            // dgvCursadasAlumno
            // 
            this.dgvCursadasAlumno.AllowUserToAddRows = false;
            this.dgvCursadasAlumno.AllowUserToDeleteRows = false;
            this.dgvCursadasAlumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursadasAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursadasAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_CursadasAlumno_Codigo,
            this.DGV_CursadasAlumno_Cur_Codigo,
            this.DGV_CursadasAlumno_Cur_Nombre,
            this.DGV_CursadasAlumno_Cur_Ano,
            this.DGV_CursadasAlumno_Cur_Turno,
            this.DGV_CursadasAlumno_Cur_Activo});
            this.dgvCursadasAlumno.Location = new System.Drawing.Point(392, 12);
            this.dgvCursadasAlumno.MultiSelect = false;
            this.dgvCursadasAlumno.Name = "dgvCursadasAlumno";
            this.dgvCursadasAlumno.ReadOnly = true;
            this.dgvCursadasAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursadasAlumno.Size = new System.Drawing.Size(410, 215);
            this.dgvCursadasAlumno.TabIndex = 39;
            this.dgvCursadasAlumno.TabStop = false;
            this.dgvCursadasAlumno.Click += new System.EventHandler(this.dgvCursadasAlumno_Click);
            // 
            // DGV_CursadasAlumno_Codigo
            // 
            this.DGV_CursadasAlumno_Codigo.HeaderText = "Columna3";
            this.DGV_CursadasAlumno_Codigo.Name = "DGV_CursadasAlumno_Codigo";
            this.DGV_CursadasAlumno_Codigo.ReadOnly = true;
            // 
            // DGV_CursadasAlumno_Cur_Codigo
            // 
            this.DGV_CursadasAlumno_Cur_Codigo.HeaderText = "Columna1";
            this.DGV_CursadasAlumno_Cur_Codigo.Name = "DGV_CursadasAlumno_Cur_Codigo";
            this.DGV_CursadasAlumno_Cur_Codigo.ReadOnly = true;
            // 
            // DGV_CursadasAlumno_Cur_Nombre
            // 
            this.DGV_CursadasAlumno_Cur_Nombre.HeaderText = "Columna2";
            this.DGV_CursadasAlumno_Cur_Nombre.Name = "DGV_CursadasAlumno_Cur_Nombre";
            this.DGV_CursadasAlumno_Cur_Nombre.ReadOnly = true;
            // 
            // DGV_CursadasAlumno_Cur_Ano
            // 
            this.DGV_CursadasAlumno_Cur_Ano.HeaderText = "Column1";
            this.DGV_CursadasAlumno_Cur_Ano.Name = "DGV_CursadasAlumno_Cur_Ano";
            this.DGV_CursadasAlumno_Cur_Ano.ReadOnly = true;
            // 
            // DGV_CursadasAlumno_Cur_Turno
            // 
            this.DGV_CursadasAlumno_Cur_Turno.HeaderText = "Column1";
            this.DGV_CursadasAlumno_Cur_Turno.Name = "DGV_CursadasAlumno_Cur_Turno";
            this.DGV_CursadasAlumno_Cur_Turno.ReadOnly = true;
            // 
            // DGV_CursadasAlumno_Cur_Activo
            // 
            this.DGV_CursadasAlumno_Cur_Activo.HeaderText = "Column1";
            this.DGV_CursadasAlumno_Cur_Activo.Name = "DGV_CursadasAlumno_Cur_Activo";
            this.DGV_CursadasAlumno_Cur_Activo.ReadOnly = true;
            this.DGV_CursadasAlumno_Cur_Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_CursadasAlumno_Cur_Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnVerRendimientoDeCursada
            // 
            this.btnVerRendimientoDeCursada.Location = new System.Drawing.Point(392, 233);
            this.btnVerRendimientoDeCursada.Name = "btnVerRendimientoDeCursada";
            this.btnVerRendimientoDeCursada.Size = new System.Drawing.Size(99, 50);
            this.btnVerRendimientoDeCursada.TabIndex = 40;
            this.btnVerRendimientoDeCursada.Text = "button1";
            this.btnVerRendimientoDeCursada.UseVisualStyleBackColor = true;
            this.btnVerRendimientoDeCursada.Click += new System.EventHandler(this.btnVerRendimientoDeCursada_Click);
            // 
            // FormVerAlumnosYCursadasVerRendimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 298);
            this.Controls.Add(this.btnVerRendimientoDeCursada);
            this.Controls.Add(this.dgvCursadasAlumno);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "FormVerAlumnosYCursadasVerRendimiento";
            this.Text = "FormVerAlumnosYCursadasVerRendimiento";
            this.Load += new System.EventHandler(this.FormVerAlumnosYCursadasVerRendimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursadasAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Nombre;
        private System.Windows.Forms.DataGridView dgvCursadasAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursadasAlumno_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursadasAlumno_Cur_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursadasAlumno_Cur_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursadasAlumno_Cur_Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursadasAlumno_Cur_Turno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_CursadasAlumno_Cur_Activo;
        private System.Windows.Forms.Button btnVerRendimientoDeCursada;
    }
}