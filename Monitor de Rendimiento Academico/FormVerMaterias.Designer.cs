
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerMaterias
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
            this.dgvMateriasActivas = new System.Windows.Forms.DataGridView();
            this.DGV_MateriasActivas_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_MateriasActivas_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_MateriasActivas_Cant_Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_QuejasActivas_Col_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnDarDeBajaMateria = new System.Windows.Forms.Button();
            this.btnVerTemasDeMateria = new System.Windows.Forms.Button();
            this.rbMateriasActivas = new System.Windows.Forms.RadioButton();
            this.rbMateriasInactivas = new System.Windows.Forms.RadioButton();
            this.gpActivo = new System.Windows.Forms.GroupBox();
            this.gpConsultas = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbCantHoras = new System.Windows.Forms.RadioButton();
            this.rbCurso = new System.Windows.Forms.RadioButton();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBoxBusqueda = new System.Windows.Forms.TextBox();
            this.rbSinCurso = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasActivas)).BeginInit();
            this.gpActivo.SuspendLayout();
            this.gpConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMateriasActivas
            // 
            this.dgvMateriasActivas.AllowUserToAddRows = false;
            this.dgvMateriasActivas.AllowUserToDeleteRows = false;
            this.dgvMateriasActivas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasActivas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_MateriasActivas_Codigo,
            this.DGV_MateriasActivas_Nombre,
            this.DGV_MateriasActivas_Cant_Horas,
            this.DGV_QuejasActivas_Col_Curso});
            this.dgvMateriasActivas.Location = new System.Drawing.Point(12, 12);
            this.dgvMateriasActivas.MultiSelect = false;
            this.dgvMateriasActivas.Name = "dgvMateriasActivas";
            this.dgvMateriasActivas.ReadOnly = true;
            this.dgvMateriasActivas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriasActivas.Size = new System.Drawing.Size(705, 227);
            this.dgvMateriasActivas.TabIndex = 1;
            this.dgvMateriasActivas.TabStop = false;
            // 
            // DGV_MateriasActivas_Codigo
            // 
            this.DGV_MateriasActivas_Codigo.HeaderText = "Columna3";
            this.DGV_MateriasActivas_Codigo.Name = "DGV_MateriasActivas_Codigo";
            this.DGV_MateriasActivas_Codigo.ReadOnly = true;
            // 
            // DGV_MateriasActivas_Nombre
            // 
            this.DGV_MateriasActivas_Nombre.HeaderText = "Columna1";
            this.DGV_MateriasActivas_Nombre.Name = "DGV_MateriasActivas_Nombre";
            this.DGV_MateriasActivas_Nombre.ReadOnly = true;
            // 
            // DGV_MateriasActivas_Cant_Horas
            // 
            this.DGV_MateriasActivas_Cant_Horas.HeaderText = "Columna2";
            this.DGV_MateriasActivas_Cant_Horas.Name = "DGV_MateriasActivas_Cant_Horas";
            this.DGV_MateriasActivas_Cant_Horas.ReadOnly = true;
            // 
            // DGV_QuejasActivas_Col_Curso
            // 
            this.DGV_QuejasActivas_Col_Curso.HeaderText = "Columna4";
            this.DGV_QuejasActivas_Col_Curso.Name = "DGV_QuejasActivas_Col_Curso";
            this.DGV_QuejasActivas_Col_Curso.ReadOnly = true;
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Location = new System.Drawing.Point(12, 245);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(94, 44);
            this.btnModificarMateria.TabIndex = 2;
            this.btnModificarMateria.Text = "button1";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click);
            // 
            // btnDarDeBajaMateria
            // 
            this.btnDarDeBajaMateria.Location = new System.Drawing.Point(112, 245);
            this.btnDarDeBajaMateria.Name = "btnDarDeBajaMateria";
            this.btnDarDeBajaMateria.Size = new System.Drawing.Size(94, 44);
            this.btnDarDeBajaMateria.TabIndex = 3;
            this.btnDarDeBajaMateria.Text = "button2";
            this.btnDarDeBajaMateria.UseVisualStyleBackColor = true;
            this.btnDarDeBajaMateria.Click += new System.EventHandler(this.btnDarDeBajaMateria_Click);
            // 
            // btnVerTemasDeMateria
            // 
            this.btnVerTemasDeMateria.Location = new System.Drawing.Point(212, 245);
            this.btnVerTemasDeMateria.Name = "btnVerTemasDeMateria";
            this.btnVerTemasDeMateria.Size = new System.Drawing.Size(94, 44);
            this.btnVerTemasDeMateria.TabIndex = 4;
            this.btnVerTemasDeMateria.Text = "button3";
            this.btnVerTemasDeMateria.UseVisualStyleBackColor = true;
            this.btnVerTemasDeMateria.Click += new System.EventHandler(this.btnVerTemasDeMateria_Click);
            // 
            // rbMateriasActivas
            // 
            this.rbMateriasActivas.AutoSize = true;
            this.rbMateriasActivas.Checked = true;
            this.rbMateriasActivas.Location = new System.Drawing.Point(6, 19);
            this.rbMateriasActivas.Name = "rbMateriasActivas";
            this.rbMateriasActivas.Size = new System.Drawing.Size(85, 17);
            this.rbMateriasActivas.TabIndex = 5;
            this.rbMateriasActivas.TabStop = true;
            this.rbMateriasActivas.Text = "radioButton1";
            this.rbMateriasActivas.UseVisualStyleBackColor = true;
            this.rbMateriasActivas.CheckedChanged += new System.EventHandler(this.rbMateriasActivas_CheckedChanged);
            // 
            // rbMateriasInactivas
            // 
            this.rbMateriasInactivas.AutoSize = true;
            this.rbMateriasInactivas.Location = new System.Drawing.Point(6, 42);
            this.rbMateriasInactivas.Name = "rbMateriasInactivas";
            this.rbMateriasInactivas.Size = new System.Drawing.Size(85, 17);
            this.rbMateriasInactivas.TabIndex = 6;
            this.rbMateriasInactivas.Text = "radioButton2";
            this.rbMateriasInactivas.UseVisualStyleBackColor = true;
            this.rbMateriasInactivas.CheckedChanged += new System.EventHandler(this.rbMateriasInactivas_CheckedChanged);
            // 
            // gpActivo
            // 
            this.gpActivo.Controls.Add(this.rbMateriasActivas);
            this.gpActivo.Controls.Add(this.rbMateriasInactivas);
            this.gpActivo.Location = new System.Drawing.Point(366, 245);
            this.gpActivo.Name = "gpActivo";
            this.gpActivo.Size = new System.Drawing.Size(112, 67);
            this.gpActivo.TabIndex = 7;
            this.gpActivo.TabStop = false;
            this.gpActivo.Text = "groupBox1";
            // 
            // gpConsultas
            // 
            this.gpConsultas.Controls.Add(this.rbSinCurso);
            this.gpConsultas.Controls.Add(this.rbCurso);
            this.gpConsultas.Controls.Add(this.rbCantHoras);
            this.gpConsultas.Controls.Add(this.rbNombre);
            this.gpConsultas.Controls.Add(this.rbCodigo);
            this.gpConsultas.Controls.Add(this.rbTodos);
            this.gpConsultas.Location = new System.Drawing.Point(484, 245);
            this.gpConsultas.Name = "gpConsultas";
            this.gpConsultas.Size = new System.Drawing.Size(233, 86);
            this.gpConsultas.TabIndex = 8;
            this.gpConsultas.TabStop = false;
            this.gpConsultas.Text = "groupBox1";
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
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(6, 42);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(85, 17);
            this.rbCodigo.TabIndex = 1;
            this.rbCodigo.Text = "radioButton2";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbCodigo_CheckedChanged);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(6, 64);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(85, 17);
            this.rbNombre.TabIndex = 2;
            this.rbNombre.Text = "radioButton3";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // rbCantHoras
            // 
            this.rbCantHoras.AutoSize = true;
            this.rbCantHoras.Location = new System.Drawing.Point(106, 19);
            this.rbCantHoras.Name = "rbCantHoras";
            this.rbCantHoras.Size = new System.Drawing.Size(85, 17);
            this.rbCantHoras.TabIndex = 3;
            this.rbCantHoras.Text = "radioButton4";
            this.rbCantHoras.UseVisualStyleBackColor = true;
            this.rbCantHoras.CheckedChanged += new System.EventHandler(this.rbCantHoras_CheckedChanged);
            // 
            // rbCurso
            // 
            this.rbCurso.AutoSize = true;
            this.rbCurso.Location = new System.Drawing.Point(106, 42);
            this.rbCurso.Name = "rbCurso";
            this.rbCurso.Size = new System.Drawing.Size(85, 17);
            this.rbCurso.TabIndex = 4;
            this.rbCurso.Text = "radioButton5";
            this.rbCurso.UseVisualStyleBackColor = true;
            this.rbCurso.CheckedChanged += new System.EventHandler(this.rbCurso_CheckedChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(363, 318);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lblBusqueda.TabIndex = 36;
            this.lblBusqueda.Text = "label1";
            // 
            // txtBoxBusqueda
            // 
            this.txtBoxBusqueda.Location = new System.Drawing.Point(366, 334);
            this.txtBoxBusqueda.Name = "txtBoxBusqueda";
            this.txtBoxBusqueda.Size = new System.Drawing.Size(112, 20);
            this.txtBoxBusqueda.TabIndex = 35;
            this.txtBoxBusqueda.TextChanged += new System.EventHandler(this.txtBoxBusqueda_TextChanged);
            // 
            // rbSinCurso
            // 
            this.rbSinCurso.AutoSize = true;
            this.rbSinCurso.Location = new System.Drawing.Point(106, 63);
            this.rbSinCurso.Name = "rbSinCurso";
            this.rbSinCurso.Size = new System.Drawing.Size(85, 17);
            this.rbSinCurso.TabIndex = 5;
            this.rbSinCurso.Text = "radioButton5";
            this.rbSinCurso.UseVisualStyleBackColor = true;
            this.rbSinCurso.CheckedChanged += new System.EventHandler(this.rbSinCurso_CheckedChanged);
            // 
            // FormVerMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 366);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtBoxBusqueda);
            this.Controls.Add(this.gpConsultas);
            this.Controls.Add(this.gpActivo);
            this.Controls.Add(this.btnVerTemasDeMateria);
            this.Controls.Add(this.btnDarDeBajaMateria);
            this.Controls.Add(this.btnModificarMateria);
            this.Controls.Add(this.dgvMateriasActivas);
            this.Name = "FormVerMaterias";
            this.Text = "FormVerMaterias";
            this.Load += new System.EventHandler(this.FormVerMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasActivas)).EndInit();
            this.gpActivo.ResumeLayout(false);
            this.gpActivo.PerformLayout();
            this.gpConsultas.ResumeLayout(false);
            this.gpConsultas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMateriasActivas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_MateriasActivas_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_MateriasActivas_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_MateriasActivas_Cant_Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_QuejasActivas_Col_Curso;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnDarDeBajaMateria;
        private System.Windows.Forms.Button btnVerTemasDeMateria;
        private System.Windows.Forms.RadioButton rbMateriasActivas;
        private System.Windows.Forms.RadioButton rbMateriasInactivas;
        private System.Windows.Forms.GroupBox gpActivo;
        private System.Windows.Forms.GroupBox gpConsultas;
        private System.Windows.Forms.RadioButton rbCurso;
        private System.Windows.Forms.RadioButton rbCantHoras;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBoxBusqueda;
        private System.Windows.Forms.RadioButton rbSinCurso;
    }
}