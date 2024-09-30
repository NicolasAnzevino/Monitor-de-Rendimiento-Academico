
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerCursosProblemas
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
            this.txtBoxBusqueda = new System.Windows.Forms.TextBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbTurno = new System.Windows.Forms.RadioButton();
            this.rbAño = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.gpConsultas = new System.Windows.Forms.GroupBox();
            this.gpActivo = new System.Windows.Forms.GroupBox();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.btnSeleccionarCurso = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.dgvCursosActivos = new System.Windows.Forms.DataGridView();
            this.DGV_CursosActivos_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpConsultas.SuspendLayout();
            this.gpActivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxBusqueda
            // 
            this.txtBoxBusqueda.Location = new System.Drawing.Point(472, 364);
            this.txtBoxBusqueda.Name = "txtBoxBusqueda";
            this.txtBoxBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBusqueda.TabIndex = 43;
            this.txtBoxBusqueda.TextChanged += new System.EventHandler(this.txtBoxBusqueda_TextChanged);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(107, 19);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(85, 17);
            this.rbNombre.TabIndex = 6;
            this.rbNombre.Text = "radioButton1";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // rbTurno
            // 
            this.rbTurno.AutoSize = true;
            this.rbTurno.Location = new System.Drawing.Point(107, 42);
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
            this.rbAño.Location = new System.Drawing.Point(6, 65);
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
            // gpConsultas
            // 
            this.gpConsultas.Controls.Add(this.rbNombre);
            this.gpConsultas.Controls.Add(this.rbTurno);
            this.gpConsultas.Controls.Add(this.rbAño);
            this.gpConsultas.Controls.Add(this.rbCodigo);
            this.gpConsultas.Controls.Add(this.rbTodos);
            this.gpConsultas.Location = new System.Drawing.Point(596, 274);
            this.gpConsultas.Name = "gpConsultas";
            this.gpConsultas.Size = new System.Drawing.Size(213, 87);
            this.gpConsultas.TabIndex = 42;
            this.gpConsultas.TabStop = false;
            this.gpConsultas.Text = "groupBox1";
            // 
            // gpActivo
            // 
            this.gpActivo.Controls.Add(this.rbActivo);
            this.gpActivo.Controls.Add(this.rbInactivo);
            this.gpActivo.Location = new System.Drawing.Point(472, 274);
            this.gpActivo.Name = "gpActivo";
            this.gpActivo.Size = new System.Drawing.Size(118, 68);
            this.gpActivo.TabIndex = 41;
            this.gpActivo.TabStop = false;
            this.gpActivo.Text = "groupBox1";
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
            // btnSeleccionarCurso
            // 
            this.btnSeleccionarCurso.Location = new System.Drawing.Point(12, 274);
            this.btnSeleccionarCurso.Name = "btnSeleccionarCurso";
            this.btnSeleccionarCurso.Size = new System.Drawing.Size(103, 48);
            this.btnSeleccionarCurso.TabIndex = 36;
            this.btnSeleccionarCurso.Text = "button1";
            this.btnSeleccionarCurso.UseVisualStyleBackColor = true;
            this.btnSeleccionarCurso.Click += new System.EventHandler(this.btnSeleccionarCurso_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(469, 348);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lblBusqueda.TabIndex = 44;
            this.lblBusqueda.Text = "label1";
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
            this.dgvCursosActivos.Location = new System.Drawing.Point(12, 8);
            this.dgvCursosActivos.MultiSelect = false;
            this.dgvCursosActivos.Name = "dgvCursosActivos";
            this.dgvCursosActivos.ReadOnly = true;
            this.dgvCursosActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursosActivos.Size = new System.Drawing.Size(797, 260);
            this.dgvCursosActivos.TabIndex = 35;
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
            // FormVerCursosProblemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 396);
            this.Controls.Add(this.txtBoxBusqueda);
            this.Controls.Add(this.gpConsultas);
            this.Controls.Add(this.gpActivo);
            this.Controls.Add(this.btnSeleccionarCurso);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.dgvCursosActivos);
            this.Name = "FormVerCursosProblemas";
            this.Text = "FormVerCursosProblemas";
            this.Load += new System.EventHandler(this.FormVerCursosProblemas_Load);
            this.gpConsultas.ResumeLayout(false);
            this.gpConsultas.PerformLayout();
            this.gpActivo.ResumeLayout(false);
            this.gpActivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosActivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxBusqueda;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbTurno;
        private System.Windows.Forms.RadioButton rbAño;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.GroupBox gpConsultas;
        private System.Windows.Forms.GroupBox gpActivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.Button btnSeleccionarCurso;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.DataGridView dgvCursosActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Turno;
    }
}