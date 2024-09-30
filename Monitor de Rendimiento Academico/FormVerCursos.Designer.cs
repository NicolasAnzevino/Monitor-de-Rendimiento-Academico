
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerCursos
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
            this.dgvCursosActivos = new System.Windows.Forms.DataGridView();
            this.DGV_CursosActivos_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Inscripciones_Abierta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnModificarCurso = new System.Windows.Forms.Button();
            this.btnDarDeBajaCurso = new System.Windows.Forms.Button();
            this.btnVerMateriasDeCurso = new System.Windows.Forms.Button();
            this.btnVerAlumnosDeCurso = new System.Windows.Forms.Button();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.btnCerrarInscripcionCurso = new System.Windows.Forms.Button();
            this.gpActivo = new System.Windows.Forms.GroupBox();
            this.gpConsultas = new System.Windows.Forms.GroupBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbInscCer = new System.Windows.Forms.RadioButton();
            this.rbInscAb = new System.Windows.Forms.RadioButton();
            this.rbTurno = new System.Windows.Forms.RadioButton();
            this.rbAño = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBoxBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosActivos)).BeginInit();
            this.gpActivo.SuspendLayout();
            this.gpConsultas.SuspendLayout();
            this.SuspendLayout();
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
            this.DGV_CursosActivos_Turno,
            this.DGV_CursosActivos_Inscripciones_Abierta});
            this.dgvCursosActivos.Location = new System.Drawing.Point(12, 12);
            this.dgvCursosActivos.MultiSelect = false;
            this.dgvCursosActivos.Name = "dgvCursosActivos";
            this.dgvCursosActivos.ReadOnly = true;
            this.dgvCursosActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursosActivos.Size = new System.Drawing.Size(797, 260);
            this.dgvCursosActivos.TabIndex = 19;
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
            // DGV_CursosActivos_Inscripciones_Abierta
            // 
            this.DGV_CursosActivos_Inscripciones_Abierta.HeaderText = "Column1";
            this.DGV_CursosActivos_Inscripciones_Abierta.Name = "DGV_CursosActivos_Inscripciones_Abierta";
            this.DGV_CursosActivos_Inscripciones_Abierta.ReadOnly = true;
            this.DGV_CursosActivos_Inscripciones_Abierta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_CursosActivos_Inscripciones_Abierta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnModificarCurso
            // 
            this.btnModificarCurso.Location = new System.Drawing.Point(12, 278);
            this.btnModificarCurso.Name = "btnModificarCurso";
            this.btnModificarCurso.Size = new System.Drawing.Size(86, 42);
            this.btnModificarCurso.TabIndex = 20;
            this.btnModificarCurso.Text = "button1";
            this.btnModificarCurso.UseVisualStyleBackColor = true;
            this.btnModificarCurso.Click += new System.EventHandler(this.btnModificarCurso_Click);
            // 
            // btnDarDeBajaCurso
            // 
            this.btnDarDeBajaCurso.Location = new System.Drawing.Point(104, 278);
            this.btnDarDeBajaCurso.Name = "btnDarDeBajaCurso";
            this.btnDarDeBajaCurso.Size = new System.Drawing.Size(86, 42);
            this.btnDarDeBajaCurso.TabIndex = 21;
            this.btnDarDeBajaCurso.Text = "button2";
            this.btnDarDeBajaCurso.UseVisualStyleBackColor = true;
            this.btnDarDeBajaCurso.Click += new System.EventHandler(this.btnDarDeBajaCurso_Click);
            // 
            // btnVerMateriasDeCurso
            // 
            this.btnVerMateriasDeCurso.Location = new System.Drawing.Point(288, 278);
            this.btnVerMateriasDeCurso.Name = "btnVerMateriasDeCurso";
            this.btnVerMateriasDeCurso.Size = new System.Drawing.Size(86, 42);
            this.btnVerMateriasDeCurso.TabIndex = 22;
            this.btnVerMateriasDeCurso.Text = "button3";
            this.btnVerMateriasDeCurso.UseVisualStyleBackColor = true;
            this.btnVerMateriasDeCurso.Click += new System.EventHandler(this.btnVerMateriasDeCurso_Click);
            // 
            // btnVerAlumnosDeCurso
            // 
            this.btnVerAlumnosDeCurso.Location = new System.Drawing.Point(380, 278);
            this.btnVerAlumnosDeCurso.Name = "btnVerAlumnosDeCurso";
            this.btnVerAlumnosDeCurso.Size = new System.Drawing.Size(86, 42);
            this.btnVerAlumnosDeCurso.TabIndex = 23;
            this.btnVerAlumnosDeCurso.Text = "button4";
            this.btnVerAlumnosDeCurso.UseVisualStyleBackColor = true;
            this.btnVerAlumnosDeCurso.Click += new System.EventHandler(this.btnVerAlumnosDeCurso_Click);
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Checked = true;
            this.rbActivo.Location = new System.Drawing.Point(6, 19);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(85, 17);
            this.rbActivo.TabIndex = 24;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "radioButton1";
            this.rbActivo.UseVisualStyleBackColor = true;
            this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(6, 42);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(85, 17);
            this.rbInactivo.TabIndex = 25;
            this.rbInactivo.Text = "radioButton2";
            this.rbInactivo.UseVisualStyleBackColor = true;
            this.rbInactivo.CheckedChanged += new System.EventHandler(this.rbInactivo_CheckedChanged);
            // 
            // btnCerrarInscripcionCurso
            // 
            this.btnCerrarInscripcionCurso.Location = new System.Drawing.Point(196, 278);
            this.btnCerrarInscripcionCurso.Name = "btnCerrarInscripcionCurso";
            this.btnCerrarInscripcionCurso.Size = new System.Drawing.Size(86, 42);
            this.btnCerrarInscripcionCurso.TabIndex = 26;
            this.btnCerrarInscripcionCurso.Text = "button3";
            this.btnCerrarInscripcionCurso.UseVisualStyleBackColor = true;
            this.btnCerrarInscripcionCurso.Click += new System.EventHandler(this.btnCerrarInscripcionCurso_Click);
            // 
            // gpActivo
            // 
            this.gpActivo.Controls.Add(this.rbActivo);
            this.gpActivo.Controls.Add(this.rbInactivo);
            this.gpActivo.Location = new System.Drawing.Point(472, 278);
            this.gpActivo.Name = "gpActivo";
            this.gpActivo.Size = new System.Drawing.Size(118, 68);
            this.gpActivo.TabIndex = 27;
            this.gpActivo.TabStop = false;
            this.gpActivo.Text = "groupBox1";
            // 
            // gpConsultas
            // 
            this.gpConsultas.Controls.Add(this.rbNombre);
            this.gpConsultas.Controls.Add(this.rbInscCer);
            this.gpConsultas.Controls.Add(this.rbInscAb);
            this.gpConsultas.Controls.Add(this.rbTurno);
            this.gpConsultas.Controls.Add(this.rbAño);
            this.gpConsultas.Controls.Add(this.rbCodigo);
            this.gpConsultas.Controls.Add(this.rbTodos);
            this.gpConsultas.Location = new System.Drawing.Point(596, 278);
            this.gpConsultas.Name = "gpConsultas";
            this.gpConsultas.Size = new System.Drawing.Size(213, 114);
            this.gpConsultas.TabIndex = 28;
            this.gpConsultas.TabStop = false;
            this.gpConsultas.Text = "groupBox1";
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(6, 65);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(85, 17);
            this.rbNombre.TabIndex = 6;
            this.rbNombre.Text = "radioButton1";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // rbInscCer
            // 
            this.rbInscCer.AutoSize = true;
            this.rbInscCer.Location = new System.Drawing.Point(97, 65);
            this.rbInscCer.Name = "rbInscCer";
            this.rbInscCer.Size = new System.Drawing.Size(85, 17);
            this.rbInscCer.TabIndex = 5;
            this.rbInscCer.Text = "radioButton1";
            this.rbInscCer.UseVisualStyleBackColor = true;
            this.rbInscCer.CheckedChanged += new System.EventHandler(this.rbInscCer_CheckedChanged);
            // 
            // rbInscAb
            // 
            this.rbInscAb.AutoSize = true;
            this.rbInscAb.Location = new System.Drawing.Point(97, 42);
            this.rbInscAb.Name = "rbInscAb";
            this.rbInscAb.Size = new System.Drawing.Size(85, 17);
            this.rbInscAb.TabIndex = 4;
            this.rbInscAb.Text = "radioButton1";
            this.rbInscAb.UseVisualStyleBackColor = true;
            this.rbInscAb.CheckedChanged += new System.EventHandler(this.rbInscAb_CheckedChanged);
            // 
            // rbTurno
            // 
            this.rbTurno.AutoSize = true;
            this.rbTurno.Location = new System.Drawing.Point(97, 19);
            this.rbTurno.Name = "rbTurno";
            this.rbTurno.Size = new System.Drawing.Size(85, 17);
            this.rbTurno.TabIndex = 3;
            this.rbTurno.Text = "radioButton1";
            this.rbTurno.UseVisualStyleBackColor = true;
            this.rbTurno.CheckedChanged += new System.EventHandler(this.rbTurno_CheckedChanged);
            // 
            // rbAño
            // 
            this.rbAño.AutoSize = true;
            this.rbAño.Location = new System.Drawing.Point(6, 89);
            this.rbAño.Name = "rbAño";
            this.rbAño.Size = new System.Drawing.Size(85, 17);
            this.rbAño.TabIndex = 2;
            this.rbAño.Text = "radioButton1";
            this.rbAño.UseVisualStyleBackColor = true;
            this.rbAño.CheckedChanged += new System.EventHandler(this.rbAño_CheckedChanged);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(6, 42);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(85, 17);
            this.rbCodigo.TabIndex = 1;
            this.rbCodigo.Text = "radioButton1";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbCodigo_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(6, 19);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(85, 17);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "radioButton1";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(469, 352);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lblBusqueda.TabIndex = 34;
            this.lblBusqueda.Text = "label1";
            // 
            // txtBoxBusqueda
            // 
            this.txtBoxBusqueda.Location = new System.Drawing.Point(472, 368);
            this.txtBoxBusqueda.Name = "txtBoxBusqueda";
            this.txtBoxBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBusqueda.TabIndex = 33;
            this.txtBoxBusqueda.TextChanged += new System.EventHandler(this.txtBoxBusqueda_TextChanged);
            // 
            // FormVerCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 396);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.gpConsultas);
            this.Controls.Add(this.txtBoxBusqueda);
            this.Controls.Add(this.gpActivo);
            this.Controls.Add(this.btnCerrarInscripcionCurso);
            this.Controls.Add(this.btnVerAlumnosDeCurso);
            this.Controls.Add(this.btnVerMateriasDeCurso);
            this.Controls.Add(this.btnDarDeBajaCurso);
            this.Controls.Add(this.btnModificarCurso);
            this.Controls.Add(this.dgvCursosActivos);
            this.Name = "FormVerCursos";
            this.Text = "FormVerCursos";
            this.Load += new System.EventHandler(this.FormVerCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosActivos)).EndInit();
            this.gpActivo.ResumeLayout(false);
            this.gpActivo.PerformLayout();
            this.gpConsultas.ResumeLayout(false);
            this.gpConsultas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursosActivos;
        private System.Windows.Forms.Button btnModificarCurso;
        private System.Windows.Forms.Button btnDarDeBajaCurso;
        private System.Windows.Forms.Button btnVerMateriasDeCurso;
        private System.Windows.Forms.Button btnVerAlumnosDeCurso;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.Button btnCerrarInscripcionCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Turno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_CursosActivos_Inscripciones_Abierta;
        private System.Windows.Forms.GroupBox gpActivo;
        private System.Windows.Forms.GroupBox gpConsultas;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbInscCer;
        private System.Windows.Forms.RadioButton rbInscAb;
        private System.Windows.Forms.RadioButton rbTurno;
        private System.Windows.Forms.RadioButton rbAño;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBoxBusqueda;
    }
}