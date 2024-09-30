
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormAgregarCursada
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
            this.lblBusquedaAlu = new System.Windows.Forms.Label();
            this.txtBoxBusquedaAlu = new System.Windows.Forms.TextBox();
            this.gpVisualizacionAlumnos = new System.Windows.Forms.GroupBox();
            this.rbAlumnosTurno = new System.Windows.Forms.RadioButton();
            this.rbAlumnosNombre = new System.Windows.Forms.RadioButton();
            this.rbAlumnosApellido = new System.Windows.Forms.RadioButton();
            this.rbAlumnosDNI = new System.Windows.Forms.RadioButton();
            this.rbAlumnosLegajo = new System.Windows.Forms.RadioButton();
            this.rbAlumnosTodos = new System.Windows.Forms.RadioButton();
            this.btnAgregarCursada = new System.Windows.Forms.Button();
            this.dgvAlumnosActivos = new System.Windows.Forms.DataGridView();
            this.DGV_AlumnosActivos_Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AlumnosActivos_Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCursosActivos = new System.Windows.Forms.DataGridView();
            this.DGV_CursosActivos_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBusquedaCursos = new System.Windows.Forms.Label();
            this.txtBoxBusquedaCurso = new System.Windows.Forms.TextBox();
            this.gpVisualizacionCursos = new System.Windows.Forms.GroupBox();
            this.rbCursosTurno = new System.Windows.Forms.RadioButton();
            this.rbCursosAño = new System.Windows.Forms.RadioButton();
            this.rbCursosNombre = new System.Windows.Forms.RadioButton();
            this.rbCursosCodigo = new System.Windows.Forms.RadioButton();
            this.rbCursosTodos = new System.Windows.Forms.RadioButton();
            this.gpVisualizacionAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosActivos)).BeginInit();
            this.gpVisualizacionCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBusquedaAlu
            // 
            this.lblBusquedaAlu.AutoSize = true;
            this.lblBusquedaAlu.Location = new System.Drawing.Point(110, 358);
            this.lblBusquedaAlu.Name = "lblBusquedaAlu";
            this.lblBusquedaAlu.Size = new System.Drawing.Size(35, 13);
            this.lblBusquedaAlu.TabIndex = 47;
            this.lblBusquedaAlu.Text = "label1";
            // 
            // txtBoxBusquedaAlu
            // 
            this.txtBoxBusquedaAlu.Location = new System.Drawing.Point(113, 374);
            this.txtBoxBusquedaAlu.Name = "txtBoxBusquedaAlu";
            this.txtBoxBusquedaAlu.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBusquedaAlu.TabIndex = 46;
            this.txtBoxBusquedaAlu.TextChanged += new System.EventHandler(this.txtBoxBusqueda_TextChanged);
            // 
            // gpVisualizacionAlumnos
            // 
            this.gpVisualizacionAlumnos.Controls.Add(this.rbAlumnosTurno);
            this.gpVisualizacionAlumnos.Controls.Add(this.rbAlumnosNombre);
            this.gpVisualizacionAlumnos.Controls.Add(this.rbAlumnosApellido);
            this.gpVisualizacionAlumnos.Controls.Add(this.rbAlumnosDNI);
            this.gpVisualizacionAlumnos.Controls.Add(this.rbAlumnosLegajo);
            this.gpVisualizacionAlumnos.Controls.Add(this.rbAlumnosTodos);
            this.gpVisualizacionAlumnos.Location = new System.Drawing.Point(113, 276);
            this.gpVisualizacionAlumnos.Name = "gpVisualizacionAlumnos";
            this.gpVisualizacionAlumnos.Size = new System.Drawing.Size(386, 67);
            this.gpVisualizacionAlumnos.TabIndex = 45;
            this.gpVisualizacionAlumnos.TabStop = false;
            this.gpVisualizacionAlumnos.Text = "groupBox1";
            // 
            // rbAlumnosTurno
            // 
            this.rbAlumnosTurno.AutoSize = true;
            this.rbAlumnosTurno.Location = new System.Drawing.Point(295, 42);
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
            this.rbAlumnosNombre.Location = new System.Drawing.Point(295, 19);
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
            this.rbAlumnosApellido.Location = new System.Drawing.Point(154, 42);
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
            this.rbAlumnosDNI.Location = new System.Drawing.Point(154, 19);
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
            // btnAgregarCursada
            // 
            this.btnAgregarCursada.Location = new System.Drawing.Point(13, 276);
            this.btnAgregarCursada.Name = "btnAgregarCursada";
            this.btnAgregarCursada.Size = new System.Drawing.Size(94, 44);
            this.btnAgregarCursada.TabIndex = 38;
            this.btnAgregarCursada.Text = "button1";
            this.btnAgregarCursada.UseVisualStyleBackColor = true;
            this.btnAgregarCursada.Click += new System.EventHandler(this.btnAgregarCursada_Click);
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
            this.dgvAlumnosActivos.Location = new System.Drawing.Point(13, 12);
            this.dgvAlumnosActivos.MultiSelect = false;
            this.dgvAlumnosActivos.Name = "dgvAlumnosActivos";
            this.dgvAlumnosActivos.ReadOnly = true;
            this.dgvAlumnosActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnosActivos.Size = new System.Drawing.Size(486, 258);
            this.dgvAlumnosActivos.TabIndex = 37;
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
            // dgvCursosActivos
            // 
            this.dgvCursosActivos.AllowUserToAddRows = false;
            this.dgvCursosActivos.AllowUserToDeleteRows = false;
            this.dgvCursosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursosActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_CursosActivos_ID,
            this.DGV_CursosActivos_Codigo,
            this.DGV_CursosActivos_Ano,
            this.DGV_CursosActivos_Turno});
            this.dgvCursosActivos.Location = new System.Drawing.Point(505, 12);
            this.dgvCursosActivos.MultiSelect = false;
            this.dgvCursosActivos.Name = "dgvCursosActivos";
            this.dgvCursosActivos.ReadOnly = true;
            this.dgvCursosActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursosActivos.Size = new System.Drawing.Size(555, 258);
            this.dgvCursosActivos.TabIndex = 48;
            this.dgvCursosActivos.TabStop = false;
            this.dgvCursosActivos.Click += new System.EventHandler(this.dgvCursosActivos_Click);
            // 
            // DGV_CursosActivos_ID
            // 
            this.DGV_CursosActivos_ID.HeaderText = "Column1";
            this.DGV_CursosActivos_ID.Name = "DGV_CursosActivos_ID";
            this.DGV_CursosActivos_ID.ReadOnly = true;
            // 
            // DGV_CursosActivos_Codigo
            // 
            this.DGV_CursosActivos_Codigo.HeaderText = "Column1";
            this.DGV_CursosActivos_Codigo.Name = "DGV_CursosActivos_Codigo";
            this.DGV_CursosActivos_Codigo.ReadOnly = true;
            // 
            // DGV_CursosActivos_Ano
            // 
            this.DGV_CursosActivos_Ano.HeaderText = "Column1";
            this.DGV_CursosActivos_Ano.Name = "DGV_CursosActivos_Ano";
            this.DGV_CursosActivos_Ano.ReadOnly = true;
            // 
            // DGV_CursosActivos_Turno
            // 
            this.DGV_CursosActivos_Turno.HeaderText = "Column1";
            this.DGV_CursosActivos_Turno.Name = "DGV_CursosActivos_Turno";
            this.DGV_CursosActivos_Turno.ReadOnly = true;
            // 
            // lblBusquedaCursos
            // 
            this.lblBusquedaCursos.AutoSize = true;
            this.lblBusquedaCursos.Location = new System.Drawing.Point(502, 358);
            this.lblBusquedaCursos.Name = "lblBusquedaCursos";
            this.lblBusquedaCursos.Size = new System.Drawing.Size(35, 13);
            this.lblBusquedaCursos.TabIndex = 51;
            this.lblBusquedaCursos.Text = "label1";
            // 
            // txtBoxBusquedaCurso
            // 
            this.txtBoxBusquedaCurso.Location = new System.Drawing.Point(505, 374);
            this.txtBoxBusquedaCurso.Name = "txtBoxBusquedaCurso";
            this.txtBoxBusquedaCurso.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBusquedaCurso.TabIndex = 50;
            this.txtBoxBusquedaCurso.TextChanged += new System.EventHandler(this.txtBoxBusquedaCurso_TextChanged);
            // 
            // gpVisualizacionCursos
            // 
            this.gpVisualizacionCursos.Controls.Add(this.rbCursosTodos);
            this.gpVisualizacionCursos.Controls.Add(this.rbCursosTurno);
            this.gpVisualizacionCursos.Controls.Add(this.rbCursosAño);
            this.gpVisualizacionCursos.Controls.Add(this.rbCursosNombre);
            this.gpVisualizacionCursos.Controls.Add(this.rbCursosCodigo);
            this.gpVisualizacionCursos.Location = new System.Drawing.Point(505, 276);
            this.gpVisualizacionCursos.Name = "gpVisualizacionCursos";
            this.gpVisualizacionCursos.Size = new System.Drawing.Size(301, 67);
            this.gpVisualizacionCursos.TabIndex = 49;
            this.gpVisualizacionCursos.TabStop = false;
            this.gpVisualizacionCursos.Text = "groupBox1";
            // 
            // rbCursosTurno
            // 
            this.rbCursosTurno.AutoSize = true;
            this.rbCursosTurno.Location = new System.Drawing.Point(208, 19);
            this.rbCursosTurno.Name = "rbCursosTurno";
            this.rbCursosTurno.Size = new System.Drawing.Size(85, 17);
            this.rbCursosTurno.TabIndex = 29;
            this.rbCursosTurno.Text = "radioButton2";
            this.rbCursosTurno.UseVisualStyleBackColor = true;
            this.rbCursosTurno.CheckedChanged += new System.EventHandler(this.rbCursosTurno_CheckedChanged);
            // 
            // rbCursosAño
            // 
            this.rbCursosAño.AutoSize = true;
            this.rbCursosAño.Location = new System.Drawing.Point(112, 42);
            this.rbCursosAño.Name = "rbCursosAño";
            this.rbCursosAño.Size = new System.Drawing.Size(85, 17);
            this.rbCursosAño.TabIndex = 28;
            this.rbCursosAño.Text = "radioButton1";
            this.rbCursosAño.UseVisualStyleBackColor = true;
            this.rbCursosAño.CheckedChanged += new System.EventHandler(this.rbCursosAño_CheckedChanged);
            // 
            // rbCursosNombre
            // 
            this.rbCursosNombre.AutoSize = true;
            this.rbCursosNombre.Location = new System.Drawing.Point(112, 19);
            this.rbCursosNombre.Name = "rbCursosNombre";
            this.rbCursosNombre.Size = new System.Drawing.Size(93, 17);
            this.rbCursosNombre.TabIndex = 27;
            this.rbCursosNombre.Text = "rbAlumnosDNI";
            this.rbCursosNombre.UseVisualStyleBackColor = true;
            this.rbCursosNombre.CheckedChanged += new System.EventHandler(this.rbCursosNombre_CheckedChanged);
            // 
            // rbCursosCodigo
            // 
            this.rbCursosCodigo.AutoSize = true;
            this.rbCursosCodigo.Location = new System.Drawing.Point(0, 42);
            this.rbCursosCodigo.Name = "rbCursosCodigo";
            this.rbCursosCodigo.Size = new System.Drawing.Size(106, 17);
            this.rbCursosCodigo.TabIndex = 26;
            this.rbCursosCodigo.Text = "rbAlumnosLegajo";
            this.rbCursosCodigo.UseVisualStyleBackColor = true;
            this.rbCursosCodigo.CheckedChanged += new System.EventHandler(this.rbCursosCodigo_CheckedChanged);
            // 
            // rbCursosTodos
            // 
            this.rbCursosTodos.AutoSize = true;
            this.rbCursosTodos.Checked = true;
            this.rbCursosTodos.Location = new System.Drawing.Point(0, 19);
            this.rbCursosTodos.Name = "rbCursosTodos";
            this.rbCursosTodos.Size = new System.Drawing.Size(106, 17);
            this.rbCursosTodos.TabIndex = 30;
            this.rbCursosTodos.Text = "rbAlumnosLegajo";
            this.rbCursosTodos.UseVisualStyleBackColor = true;
            this.rbCursosTodos.CheckedChanged += new System.EventHandler(this.rbCursosTodos_CheckedChanged);
            // 
            // FormAgregarCursada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 410);
            this.Controls.Add(this.lblBusquedaCursos);
            this.Controls.Add(this.txtBoxBusquedaCurso);
            this.Controls.Add(this.gpVisualizacionCursos);
            this.Controls.Add(this.dgvCursosActivos);
            this.Controls.Add(this.lblBusquedaAlu);
            this.Controls.Add(this.txtBoxBusquedaAlu);
            this.Controls.Add(this.gpVisualizacionAlumnos);
            this.Controls.Add(this.btnAgregarCursada);
            this.Controls.Add(this.dgvAlumnosActivos);
            this.Name = "FormAgregarCursada";
            this.Text = "FormAgregarCursada";
            this.Load += new System.EventHandler(this.FormAgregarCursada_Load);
            this.gpVisualizacionAlumnos.ResumeLayout(false);
            this.gpVisualizacionAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosActivos)).EndInit();
            this.gpVisualizacionCursos.ResumeLayout(false);
            this.gpVisualizacionCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBusquedaAlu;
        private System.Windows.Forms.TextBox txtBoxBusquedaAlu;
        private System.Windows.Forms.GroupBox gpVisualizacionAlumnos;
        private System.Windows.Forms.RadioButton rbAlumnosTurno;
        private System.Windows.Forms.RadioButton rbAlumnosNombre;
        private System.Windows.Forms.RadioButton rbAlumnosApellido;
        private System.Windows.Forms.RadioButton rbAlumnosDNI;
        private System.Windows.Forms.RadioButton rbAlumnosLegajo;
        private System.Windows.Forms.RadioButton rbAlumnosTodos;
        private System.Windows.Forms.Button btnAgregarCursada;
        private System.Windows.Forms.DataGridView dgvAlumnosActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AlumnosActivos_Turno;
        private System.Windows.Forms.DataGridView dgvCursosActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Turno;
        private System.Windows.Forms.Label lblBusquedaCursos;
        private System.Windows.Forms.TextBox txtBoxBusquedaCurso;
        private System.Windows.Forms.GroupBox gpVisualizacionCursos;
        private System.Windows.Forms.RadioButton rbCursosTurno;
        private System.Windows.Forms.RadioButton rbCursosAño;
        private System.Windows.Forms.RadioButton rbCursosNombre;
        private System.Windows.Forms.RadioButton rbCursosCodigo;
        private System.Windows.Forms.RadioButton rbCursosTodos;
    }
}