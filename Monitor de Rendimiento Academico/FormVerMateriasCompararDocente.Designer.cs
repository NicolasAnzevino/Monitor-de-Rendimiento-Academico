
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerMateriasCompararDocente
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
            this.rbMateriasInactivas = new System.Windows.Forms.RadioButton();
            this.rbMateriasActivas = new System.Windows.Forms.RadioButton();
            this.btnSeleccionarTema = new System.Windows.Forms.Button();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.lblTemasDeMateria = new System.Windows.Forms.Label();
            this.dgvTemas = new System.Windows.Forms.DataGridView();
            this.DGV_Temas_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Temas_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxDescripcionTema = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasActivas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).BeginInit();
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
            this.dgvMateriasActivas.Location = new System.Drawing.Point(12, 27);
            this.dgvMateriasActivas.MultiSelect = false;
            this.dgvMateriasActivas.Name = "dgvMateriasActivas";
            this.dgvMateriasActivas.ReadOnly = true;
            this.dgvMateriasActivas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriasActivas.Size = new System.Drawing.Size(557, 227);
            this.dgvMateriasActivas.TabIndex = 7;
            this.dgvMateriasActivas.TabStop = false;
            this.dgvMateriasActivas.Click += new System.EventHandler(this.dgvMateriasActivas_Click);
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
            // rbMateriasInactivas
            // 
            this.rbMateriasInactivas.AutoSize = true;
            this.rbMateriasInactivas.Location = new System.Drawing.Point(431, 283);
            this.rbMateriasInactivas.Name = "rbMateriasInactivas";
            this.rbMateriasInactivas.Size = new System.Drawing.Size(85, 17);
            this.rbMateriasInactivas.TabIndex = 12;
            this.rbMateriasInactivas.Text = "radioButton2";
            this.rbMateriasInactivas.UseVisualStyleBackColor = true;
            this.rbMateriasInactivas.CheckedChanged += new System.EventHandler(this.rbMateriasInactivas_CheckedChanged);
            // 
            // rbMateriasActivas
            // 
            this.rbMateriasActivas.AutoSize = true;
            this.rbMateriasActivas.Checked = true;
            this.rbMateriasActivas.Location = new System.Drawing.Point(431, 260);
            this.rbMateriasActivas.Name = "rbMateriasActivas";
            this.rbMateriasActivas.Size = new System.Drawing.Size(85, 17);
            this.rbMateriasActivas.TabIndex = 11;
            this.rbMateriasActivas.TabStop = true;
            this.rbMateriasActivas.Text = "radioButton1";
            this.rbMateriasActivas.UseVisualStyleBackColor = true;
            this.rbMateriasActivas.CheckedChanged += new System.EventHandler(this.rbMateriasActivas_CheckedChanged);
            // 
            // btnSeleccionarTema
            // 
            this.btnSeleccionarTema.Location = new System.Drawing.Point(584, 260);
            this.btnSeleccionarTema.Name = "btnSeleccionarTema";
            this.btnSeleccionarTema.Size = new System.Drawing.Size(91, 46);
            this.btnSeleccionarTema.TabIndex = 14;
            this.btnSeleccionarTema.Text = "button1";
            this.btnSeleccionarTema.UseVisualStyleBackColor = true;
            this.btnSeleccionarTema.Click += new System.EventHandler(this.btnSeleccionarTema_Click);
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Location = new System.Drawing.Point(247, 9);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(35, 13);
            this.lblMaterias.TabIndex = 15;
            this.lblMaterias.Text = "label1";
            // 
            // lblTemasDeMateria
            // 
            this.lblTemasDeMateria.AutoSize = true;
            this.lblTemasDeMateria.Location = new System.Drawing.Point(771, 9);
            this.lblTemasDeMateria.Name = "lblTemasDeMateria";
            this.lblTemasDeMateria.Size = new System.Drawing.Size(35, 13);
            this.lblTemasDeMateria.TabIndex = 16;
            this.lblTemasDeMateria.Text = "label1";
            // 
            // dgvTemas
            // 
            this.dgvTemas.AllowUserToAddRows = false;
            this.dgvTemas.AllowUserToDeleteRows = false;
            this.dgvTemas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Temas_Codigo,
            this.DGV_Temas_Nombre});
            this.dgvTemas.Location = new System.Drawing.Point(584, 27);
            this.dgvTemas.MultiSelect = false;
            this.dgvTemas.Name = "dgvTemas";
            this.dgvTemas.ReadOnly = true;
            this.dgvTemas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTemas.Size = new System.Drawing.Size(424, 227);
            this.dgvTemas.TabIndex = 21;
            this.dgvTemas.TabStop = false;
            this.dgvTemas.Click += new System.EventHandler(this.dgvTemas_Click);
            // 
            // DGV_Temas_Codigo
            // 
            this.DGV_Temas_Codigo.HeaderText = "Column1";
            this.DGV_Temas_Codigo.Name = "DGV_Temas_Codigo";
            this.DGV_Temas_Codigo.ReadOnly = true;
            // 
            // DGV_Temas_Nombre
            // 
            this.DGV_Temas_Nombre.HeaderText = "Column1";
            this.DGV_Temas_Nombre.Name = "DGV_Temas_Nombre";
            this.DGV_Temas_Nombre.ReadOnly = true;
            // 
            // txtBoxDescripcionTema
            // 
            this.txtBoxDescripcionTema.BackColor = System.Drawing.Color.White;
            this.txtBoxDescripcionTema.Location = new System.Drawing.Point(693, 260);
            this.txtBoxDescripcionTema.Multiline = true;
            this.txtBoxDescripcionTema.Name = "txtBoxDescripcionTema";
            this.txtBoxDescripcionTema.ReadOnly = true;
            this.txtBoxDescripcionTema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDescripcionTema.Size = new System.Drawing.Size(315, 81);
            this.txtBoxDescripcionTema.TabIndex = 30;
            // 
            // FormVerMateriasCompararDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 371);
            this.Controls.Add(this.txtBoxDescripcionTema);
            this.Controls.Add(this.dgvTemas);
            this.Controls.Add(this.lblTemasDeMateria);
            this.Controls.Add(this.lblMaterias);
            this.Controls.Add(this.btnSeleccionarTema);
            this.Controls.Add(this.dgvMateriasActivas);
            this.Controls.Add(this.rbMateriasInactivas);
            this.Controls.Add(this.rbMateriasActivas);
            this.Name = "FormVerMateriasCompararDocente";
            this.Text = "FormVerMateriasCompararDocente";
            this.Load += new System.EventHandler(this.FormVerMateriasCompararDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasActivas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMateriasActivas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_MateriasActivas_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_MateriasActivas_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_MateriasActivas_Cant_Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_QuejasActivas_Col_Curso;
        private System.Windows.Forms.RadioButton rbMateriasInactivas;
        private System.Windows.Forms.RadioButton rbMateriasActivas;
        private System.Windows.Forms.Button btnSeleccionarTema;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Label lblTemasDeMateria;
        private System.Windows.Forms.DataGridView dgvTemas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Temas_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Temas_Nombre;
        private System.Windows.Forms.TextBox txtBoxDescripcionTema;
    }
}