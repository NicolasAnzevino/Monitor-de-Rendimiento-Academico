
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerDictadosDocenteVerRendimiento
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
            this.btnVerRendimientoDictado = new System.Windows.Forms.Button();
            this.lblDocentesDictado = new System.Windows.Forms.Label();
            this.lblDictados = new System.Windows.Forms.Label();
            this.lbDocentes = new System.Windows.Forms.ListBox();
            this.dgvDictados = new System.Windows.Forms.DataGridView();
            this.DGV_Dictados_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Dictados_Materia_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Dictados_Materia_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpMateriasActivos = new System.Windows.Forms.GroupBox();
            this.rbMateriasInactivos = new System.Windows.Forms.RadioButton();
            this.rbMateriasActivas = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictados)).BeginInit();
            this.gpMateriasActivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerRendimientoDictado
            // 
            this.btnVerRendimientoDictado.Location = new System.Drawing.Point(11, 294);
            this.btnVerRendimientoDictado.Name = "btnVerRendimientoDictado";
            this.btnVerRendimientoDictado.Size = new System.Drawing.Size(92, 46);
            this.btnVerRendimientoDictado.TabIndex = 41;
            this.btnVerRendimientoDictado.Text = "button1";
            this.btnVerRendimientoDictado.UseVisualStyleBackColor = true;
            this.btnVerRendimientoDictado.Click += new System.EventHandler(this.btnVerRendimientoDictado_Click);
            // 
            // lblDocentesDictado
            // 
            this.lblDocentesDictado.AutoSize = true;
            this.lblDocentesDictado.Location = new System.Drawing.Point(724, 8);
            this.lblDocentesDictado.Name = "lblDocentesDictado";
            this.lblDocentesDictado.Size = new System.Drawing.Size(35, 13);
            this.lblDocentesDictado.TabIndex = 40;
            this.lblDocentesDictado.Text = "label1";
            // 
            // lblDictados
            // 
            this.lblDictados.AutoSize = true;
            this.lblDictados.Location = new System.Drawing.Point(334, 8);
            this.lblDictados.Name = "lblDictados";
            this.lblDictados.Size = new System.Drawing.Size(35, 13);
            this.lblDictados.TabIndex = 39;
            this.lblDictados.Text = "label1";
            // 
            // lbDocentes
            // 
            this.lbDocentes.FormattingEnabled = true;
            this.lbDocentes.Location = new System.Drawing.Point(722, 24);
            this.lbDocentes.Name = "lbDocentes";
            this.lbDocentes.Size = new System.Drawing.Size(120, 264);
            this.lbDocentes.TabIndex = 38;
            // 
            // dgvDictados
            // 
            this.dgvDictados.AllowUserToAddRows = false;
            this.dgvDictados.AllowUserToDeleteRows = false;
            this.dgvDictados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDictados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDictados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Dictados_Codigo,
            this.DGV_Dictados_Materia_Codigo,
            this.DGV_Dictados_Materia_Nombre});
            this.dgvDictados.Location = new System.Drawing.Point(11, 24);
            this.dgvDictados.MultiSelect = false;
            this.dgvDictados.Name = "dgvDictados";
            this.dgvDictados.ReadOnly = true;
            this.dgvDictados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDictados.Size = new System.Drawing.Size(705, 264);
            this.dgvDictados.TabIndex = 37;
            this.dgvDictados.TabStop = false;
            this.dgvDictados.Click += new System.EventHandler(this.dgvDictados_Click);
            // 
            // DGV_Dictados_Codigo
            // 
            this.DGV_Dictados_Codigo.HeaderText = "Column1";
            this.DGV_Dictados_Codigo.Name = "DGV_Dictados_Codigo";
            this.DGV_Dictados_Codigo.ReadOnly = true;
            // 
            // DGV_Dictados_Materia_Codigo
            // 
            this.DGV_Dictados_Materia_Codigo.HeaderText = "Column1";
            this.DGV_Dictados_Materia_Codigo.Name = "DGV_Dictados_Materia_Codigo";
            this.DGV_Dictados_Materia_Codigo.ReadOnly = true;
            // 
            // DGV_Dictados_Materia_Nombre
            // 
            this.DGV_Dictados_Materia_Nombre.HeaderText = "Column1";
            this.DGV_Dictados_Materia_Nombre.Name = "DGV_Dictados_Materia_Nombre";
            this.DGV_Dictados_Materia_Nombre.ReadOnly = true;
            // 
            // gpMateriasActivos
            // 
            this.gpMateriasActivos.Controls.Add(this.rbMateriasInactivos);
            this.gpMateriasActivos.Controls.Add(this.rbMateriasActivas);
            this.gpMateriasActivos.Location = new System.Drawing.Point(109, 294);
            this.gpMateriasActivos.Name = "gpMateriasActivos";
            this.gpMateriasActivos.Size = new System.Drawing.Size(106, 67);
            this.gpMateriasActivos.TabIndex = 42;
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
            // FormVerDictadosDocenteVerRendimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 365);
            this.Controls.Add(this.gpMateriasActivos);
            this.Controls.Add(this.btnVerRendimientoDictado);
            this.Controls.Add(this.lblDocentesDictado);
            this.Controls.Add(this.lblDictados);
            this.Controls.Add(this.lbDocentes);
            this.Controls.Add(this.dgvDictados);
            this.Name = "FormVerDictadosDocenteVerRendimiento";
            this.Text = "FormVerDictadosDocenteVerRendimiento";
            this.Load += new System.EventHandler(this.FormVerDictadosDocenteVerRendimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictados)).EndInit();
            this.gpMateriasActivos.ResumeLayout(false);
            this.gpMateriasActivos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerRendimientoDictado;
        private System.Windows.Forms.Label lblDocentesDictado;
        private System.Windows.Forms.Label lblDictados;
        private System.Windows.Forms.ListBox lbDocentes;
        private System.Windows.Forms.DataGridView dgvDictados;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dictados_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dictados_Materia_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dictados_Materia_Nombre;
        private System.Windows.Forms.GroupBox gpMateriasActivos;
        private System.Windows.Forms.RadioButton rbMateriasInactivos;
        private System.Windows.Forms.RadioButton rbMateriasActivas;
    }
}