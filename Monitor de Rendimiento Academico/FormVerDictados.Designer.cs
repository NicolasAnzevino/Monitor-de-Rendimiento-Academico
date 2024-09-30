
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerDictados
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
            this.dgvDictados = new System.Windows.Forms.DataGridView();
            this.DGV_Dictados_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Dictados_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Dictados_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerMateria = new System.Windows.Forms.Button();
            this.lbDocentes = new System.Windows.Forms.ListBox();
            this.lblDictados = new System.Windows.Forms.Label();
            this.lblDocentesDictado = new System.Windows.Forms.Label();
            this.gpMateriasActivos = new System.Windows.Forms.GroupBox();
            this.rbMateriasInactivos = new System.Windows.Forms.RadioButton();
            this.rbMateriasActivas = new System.Windows.Forms.RadioButton();
            this.btnModificarDictado = new System.Windows.Forms.Button();
            this.gpConsultas = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbCurso = new System.Windows.Forms.RadioButton();
            this.rbMateria = new System.Windows.Forms.RadioButton();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBoxBusqueda = new System.Windows.Forms.TextBox();
            this.rbDocente = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictados)).BeginInit();
            this.gpMateriasActivos.SuspendLayout();
            this.gpConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDictados
            // 
            this.dgvDictados.AllowUserToAddRows = false;
            this.dgvDictados.AllowUserToDeleteRows = false;
            this.dgvDictados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDictados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDictados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Dictados_Codigo,
            this.DGV_Dictados_Materia,
            this.DGV_Dictados_Curso});
            this.dgvDictados.Location = new System.Drawing.Point(12, 28);
            this.dgvDictados.MultiSelect = false;
            this.dgvDictados.Name = "dgvDictados";
            this.dgvDictados.ReadOnly = true;
            this.dgvDictados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDictados.Size = new System.Drawing.Size(705, 264);
            this.dgvDictados.TabIndex = 21;
            this.dgvDictados.TabStop = false;
            this.dgvDictados.Click += new System.EventHandler(this.dgvDictados_Click);
            // 
            // DGV_Dictados_Codigo
            // 
            this.DGV_Dictados_Codigo.HeaderText = "Column1";
            this.DGV_Dictados_Codigo.Name = "DGV_Dictados_Codigo";
            this.DGV_Dictados_Codigo.ReadOnly = true;
            // 
            // DGV_Dictados_Materia
            // 
            this.DGV_Dictados_Materia.HeaderText = "Column1";
            this.DGV_Dictados_Materia.Name = "DGV_Dictados_Materia";
            this.DGV_Dictados_Materia.ReadOnly = true;
            // 
            // DGV_Dictados_Curso
            // 
            this.DGV_Dictados_Curso.HeaderText = "Column1";
            this.DGV_Dictados_Curso.Name = "DGV_Dictados_Curso";
            this.DGV_Dictados_Curso.ReadOnly = true;
            // 
            // btnVerMateria
            // 
            this.btnVerMateria.Location = new System.Drawing.Point(12, 298);
            this.btnVerMateria.Name = "btnVerMateria";
            this.btnVerMateria.Size = new System.Drawing.Size(94, 44);
            this.btnVerMateria.TabIndex = 26;
            this.btnVerMateria.Text = "button3";
            this.btnVerMateria.UseVisualStyleBackColor = true;
            this.btnVerMateria.Click += new System.EventHandler(this.btnVerMateria_Click);
            // 
            // lbDocentes
            // 
            this.lbDocentes.FormattingEnabled = true;
            this.lbDocentes.Location = new System.Drawing.Point(723, 28);
            this.lbDocentes.Name = "lbDocentes";
            this.lbDocentes.Size = new System.Drawing.Size(120, 264);
            this.lbDocentes.TabIndex = 27;
            // 
            // lblDictados
            // 
            this.lblDictados.AutoSize = true;
            this.lblDictados.Location = new System.Drawing.Point(330, 9);
            this.lblDictados.Name = "lblDictados";
            this.lblDictados.Size = new System.Drawing.Size(35, 13);
            this.lblDictados.TabIndex = 28;
            this.lblDictados.Text = "label1";
            // 
            // lblDocentesDictado
            // 
            this.lblDocentesDictado.AutoSize = true;
            this.lblDocentesDictado.Location = new System.Drawing.Point(720, 9);
            this.lblDocentesDictado.Name = "lblDocentesDictado";
            this.lblDocentesDictado.Size = new System.Drawing.Size(35, 13);
            this.lblDocentesDictado.TabIndex = 29;
            this.lblDocentesDictado.Text = "label1";
            // 
            // gpMateriasActivos
            // 
            this.gpMateriasActivos.Controls.Add(this.rbMateriasInactivos);
            this.gpMateriasActivos.Controls.Add(this.rbMateriasActivas);
            this.gpMateriasActivos.Location = new System.Drawing.Point(209, 298);
            this.gpMateriasActivos.Name = "gpMateriasActivos";
            this.gpMateriasActivos.Size = new System.Drawing.Size(106, 67);
            this.gpMateriasActivos.TabIndex = 38;
            this.gpMateriasActivos.TabStop = false;
            this.gpMateriasActivos.Text = "groupBox1";
            // 
            // rbMateriasInactivos
            // 
            this.rbMateriasInactivos.AutoSize = true;
            this.rbMateriasInactivos.Location = new System.Drawing.Point(6, 44);
            this.rbMateriasInactivos.Name = "rbMateriasInactivos";
            this.rbMateriasInactivos.Size = new System.Drawing.Size(85, 17);
            this.rbMateriasInactivos.TabIndex = 25;
            this.rbMateriasInactivos.Text = "radioButton2";
            this.rbMateriasInactivos.UseVisualStyleBackColor = true;
            this.rbMateriasInactivos.CheckedChanged += new System.EventHandler(this.rbMateriasInactivos_CheckedChanged);
            // 
            // rbMateriasActivas
            // 
            this.rbMateriasActivas.AutoSize = true;
            this.rbMateriasActivas.Checked = true;
            this.rbMateriasActivas.Location = new System.Drawing.Point(6, 21);
            this.rbMateriasActivas.Name = "rbMateriasActivas";
            this.rbMateriasActivas.Size = new System.Drawing.Size(85, 17);
            this.rbMateriasActivas.TabIndex = 24;
            this.rbMateriasActivas.TabStop = true;
            this.rbMateriasActivas.Text = "radioButton1";
            this.rbMateriasActivas.UseVisualStyleBackColor = true;
            this.rbMateriasActivas.CheckedChanged += new System.EventHandler(this.rbMateriasActivas_CheckedChanged);
            // 
            // btnModificarDictado
            // 
            this.btnModificarDictado.Location = new System.Drawing.Point(109, 298);
            this.btnModificarDictado.Name = "btnModificarDictado";
            this.btnModificarDictado.Size = new System.Drawing.Size(94, 44);
            this.btnModificarDictado.TabIndex = 39;
            this.btnModificarDictado.Text = "button3";
            this.btnModificarDictado.UseVisualStyleBackColor = true;
            this.btnModificarDictado.Click += new System.EventHandler(this.btnModificarDictado_Click);
            // 
            // gpConsultas
            // 
            this.gpConsultas.Controls.Add(this.rbDocente);
            this.gpConsultas.Controls.Add(this.rbMateria);
            this.gpConsultas.Controls.Add(this.rbCurso);
            this.gpConsultas.Controls.Add(this.rbCodigo);
            this.gpConsultas.Controls.Add(this.rbTodos);
            this.gpConsultas.Location = new System.Drawing.Point(321, 298);
            this.gpConsultas.Name = "gpConsultas";
            this.gpConsultas.Size = new System.Drawing.Size(208, 88);
            this.gpConsultas.TabIndex = 40;
            this.gpConsultas.TabStop = false;
            this.gpConsultas.Text = "groupBox1";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(6, 21);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(85, 17);
            this.rbTodos.TabIndex = 26;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "radioButton1";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(6, 42);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(85, 17);
            this.rbCodigo.TabIndex = 26;
            this.rbCodigo.Text = "radioButton2";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbCodigo_CheckedChanged);
            // 
            // rbCurso
            // 
            this.rbCurso.AutoSize = true;
            this.rbCurso.Location = new System.Drawing.Point(97, 21);
            this.rbCurso.Name = "rbCurso";
            this.rbCurso.Size = new System.Drawing.Size(85, 17);
            this.rbCurso.TabIndex = 27;
            this.rbCurso.Text = "radioButton2";
            this.rbCurso.UseVisualStyleBackColor = true;
            this.rbCurso.CheckedChanged += new System.EventHandler(this.rbCurso_CheckedChanged);
            // 
            // rbMateria
            // 
            this.rbMateria.AutoSize = true;
            this.rbMateria.Location = new System.Drawing.Point(6, 65);
            this.rbMateria.Name = "rbMateria";
            this.rbMateria.Size = new System.Drawing.Size(85, 17);
            this.rbMateria.TabIndex = 28;
            this.rbMateria.Text = "radioButton2";
            this.rbMateria.UseVisualStyleBackColor = true;
            this.rbMateria.CheckedChanged += new System.EventHandler(this.rbMateria_CheckedChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(206, 371);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lblBusqueda.TabIndex = 42;
            this.lblBusqueda.Text = "label1";
            // 
            // txtBoxBusqueda
            // 
            this.txtBoxBusqueda.Location = new System.Drawing.Point(209, 387);
            this.txtBoxBusqueda.Name = "txtBoxBusqueda";
            this.txtBoxBusqueda.Size = new System.Drawing.Size(106, 20);
            this.txtBoxBusqueda.TabIndex = 41;
            this.txtBoxBusqueda.TextChanged += new System.EventHandler(this.txtBoxBusqueda_TextChanged);
            // 
            // rbDocente
            // 
            this.rbDocente.AutoSize = true;
            this.rbDocente.Location = new System.Drawing.Point(97, 44);
            this.rbDocente.Name = "rbDocente";
            this.rbDocente.Size = new System.Drawing.Size(85, 17);
            this.rbDocente.TabIndex = 29;
            this.rbDocente.Text = "radioButton2";
            this.rbDocente.UseVisualStyleBackColor = true;
            this.rbDocente.CheckedChanged += new System.EventHandler(this.rbDocente_CheckedChanged);
            // 
            // FormVerDictados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 419);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtBoxBusqueda);
            this.Controls.Add(this.gpConsultas);
            this.Controls.Add(this.btnModificarDictado);
            this.Controls.Add(this.gpMateriasActivos);
            this.Controls.Add(this.lblDocentesDictado);
            this.Controls.Add(this.lblDictados);
            this.Controls.Add(this.lbDocentes);
            this.Controls.Add(this.btnVerMateria);
            this.Controls.Add(this.dgvDictados);
            this.Name = "FormVerDictados";
            this.Text = "FormVerDictados";
            this.Load += new System.EventHandler(this.FormVerDictados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictados)).EndInit();
            this.gpMateriasActivos.ResumeLayout(false);
            this.gpMateriasActivos.PerformLayout();
            this.gpConsultas.ResumeLayout(false);
            this.gpConsultas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDictados;
        private System.Windows.Forms.Button btnVerMateria;
        private System.Windows.Forms.ListBox lbDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dictados_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dictados_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dictados_Curso;
        private System.Windows.Forms.Label lblDictados;
        private System.Windows.Forms.Label lblDocentesDictado;
        private System.Windows.Forms.GroupBox gpMateriasActivos;
        private System.Windows.Forms.RadioButton rbMateriasInactivos;
        private System.Windows.Forms.RadioButton rbMateriasActivas;
        private System.Windows.Forms.Button btnModificarDictado;
        private System.Windows.Forms.GroupBox gpConsultas;
        private System.Windows.Forms.RadioButton rbMateria;
        private System.Windows.Forms.RadioButton rbCurso;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBoxBusqueda;
        private System.Windows.Forms.RadioButton rbDocente;
    }
}