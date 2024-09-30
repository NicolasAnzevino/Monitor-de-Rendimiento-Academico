
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerClasesDeDictado
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
            this.dgvClases = new System.Windows.Forms.DataGridView();
            this.DGV_Clases_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Clases_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDescripcionClase = new System.Windows.Forms.Label();
            this.txtBoxDescripcionClase = new System.Windows.Forms.TextBox();
            this.lblTemasDeClase = new System.Windows.Forms.Label();
            this.listBoxTemasClase = new System.Windows.Forms.ListBox();
            this.gbVisualizacion = new System.Windows.Forms.GroupBox();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblDescripcionTema = new System.Windows.Forms.Label();
            this.txtDescripcionTema = new System.Windows.Forms.TextBox();
            this.txtBoxBuscar = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).BeginInit();
            this.gbVisualizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClases
            // 
            this.dgvClases.AllowUserToAddRows = false;
            this.dgvClases.AllowUserToDeleteRows = false;
            this.dgvClases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Clases_Codigo,
            this.DGV_Clases_Fecha});
            this.dgvClases.Location = new System.Drawing.Point(12, 12);
            this.dgvClases.MultiSelect = false;
            this.dgvClases.Name = "dgvClases";
            this.dgvClases.ReadOnly = true;
            this.dgvClases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClases.Size = new System.Drawing.Size(536, 260);
            this.dgvClases.TabIndex = 39;
            this.dgvClases.TabStop = false;
            this.dgvClases.Click += new System.EventHandler(this.dgvClases_Click);
            // 
            // DGV_Clases_Codigo
            // 
            this.DGV_Clases_Codigo.HeaderText = "Column1";
            this.DGV_Clases_Codigo.Name = "DGV_Clases_Codigo";
            this.DGV_Clases_Codigo.ReadOnly = true;
            // 
            // DGV_Clases_Fecha
            // 
            this.DGV_Clases_Fecha.HeaderText = "Column1";
            this.DGV_Clases_Fecha.Name = "DGV_Clases_Fecha";
            this.DGV_Clases_Fecha.ReadOnly = true;
            // 
            // lblDescripcionClase
            // 
            this.lblDescripcionClase.AutoSize = true;
            this.lblDescripcionClase.Location = new System.Drawing.Point(12, 278);
            this.lblDescripcionClase.Name = "lblDescripcionClase";
            this.lblDescripcionClase.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionClase.TabIndex = 41;
            this.lblDescripcionClase.Text = "Descripcion";
            // 
            // txtBoxDescripcionClase
            // 
            this.txtBoxDescripcionClase.BackColor = System.Drawing.Color.White;
            this.txtBoxDescripcionClase.Location = new System.Drawing.Point(12, 294);
            this.txtBoxDescripcionClase.MaxLength = 77;
            this.txtBoxDescripcionClase.Multiline = true;
            this.txtBoxDescripcionClase.Name = "txtBoxDescripcionClase";
            this.txtBoxDescripcionClase.ReadOnly = true;
            this.txtBoxDescripcionClase.Size = new System.Drawing.Size(181, 102);
            this.txtBoxDescripcionClase.TabIndex = 40;
            // 
            // lblTemasDeClase
            // 
            this.lblTemasDeClase.AutoSize = true;
            this.lblTemasDeClase.Location = new System.Drawing.Point(554, 9);
            this.lblTemasDeClase.Name = "lblTemasDeClase";
            this.lblTemasDeClase.Size = new System.Drawing.Size(35, 13);
            this.lblTemasDeClase.TabIndex = 43;
            this.lblTemasDeClase.Text = "label1";
            // 
            // listBoxTemasClase
            // 
            this.listBoxTemasClase.FormattingEnabled = true;
            this.listBoxTemasClase.Location = new System.Drawing.Point(554, 25);
            this.listBoxTemasClase.Name = "listBoxTemasClase";
            this.listBoxTemasClase.Size = new System.Drawing.Size(180, 238);
            this.listBoxTemasClase.TabIndex = 42;
            this.listBoxTemasClase.SelectedIndexChanged += new System.EventHandler(this.listBoxTemasClase_SelectedIndexChanged);
            // 
            // gbVisualizacion
            // 
            this.gbVisualizacion.Controls.Add(this.rbFecha);
            this.gbVisualizacion.Controls.Add(this.rbTodos);
            this.gbVisualizacion.Location = new System.Drawing.Point(397, 278);
            this.gbVisualizacion.Name = "gbVisualizacion";
            this.gbVisualizacion.Size = new System.Drawing.Size(122, 72);
            this.gbVisualizacion.TabIndex = 44;
            this.gbVisualizacion.TabStop = false;
            this.gbVisualizacion.Text = "groupBox1";
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Location = new System.Drawing.Point(6, 42);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(85, 17);
            this.rbFecha.TabIndex = 1;
            this.rbFecha.TabStop = true;
            this.rbFecha.Text = "radioButton2";
            this.rbFecha.UseVisualStyleBackColor = true;
            this.rbFecha.CheckedChanged += new System.EventHandler(this.rbFecha_CheckedChanged);
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
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(394, 358);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(35, 13);
            this.lblBuscar.TabIndex = 46;
            this.lblBuscar.Text = "label1";
            // 
            // lblDescripcionTema
            // 
            this.lblDescripcionTema.AutoSize = true;
            this.lblDescripcionTema.Location = new System.Drawing.Point(554, 266);
            this.lblDescripcionTema.Name = "lblDescripcionTema";
            this.lblDescripcionTema.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionTema.TabIndex = 48;
            this.lblDescripcionTema.Text = "Descripcion";
            // 
            // txtDescripcionTema
            // 
            this.txtDescripcionTema.BackColor = System.Drawing.Color.White;
            this.txtDescripcionTema.Location = new System.Drawing.Point(554, 282);
            this.txtDescripcionTema.MaxLength = 77;
            this.txtDescripcionTema.Multiline = true;
            this.txtDescripcionTema.Name = "txtDescripcionTema";
            this.txtDescripcionTema.ReadOnly = true;
            this.txtDescripcionTema.Size = new System.Drawing.Size(180, 81);
            this.txtDescripcionTema.TabIndex = 47;
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(397, 376);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBuscar.TabIndex = 49;
            this.txtBoxBuscar.TextChanged += new System.EventHandler(this.txtBoxBuscar_TextChanged);
            // 
            // FormVerClasesDeDictado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 406);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.lblDescripcionTema);
            this.Controls.Add(this.txtDescripcionTema);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.gbVisualizacion);
            this.Controls.Add(this.lblTemasDeClase);
            this.Controls.Add(this.listBoxTemasClase);
            this.Controls.Add(this.lblDescripcionClase);
            this.Controls.Add(this.txtBoxDescripcionClase);
            this.Controls.Add(this.dgvClases);
            this.Name = "FormVerClasesDeDictado";
            this.Text = "FormVerClasesDeDictado";
            this.Load += new System.EventHandler(this.FormVerClasesDeDictado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).EndInit();
            this.gbVisualizacion.ResumeLayout(false);
            this.gbVisualizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClases;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Clases_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Clases_Fecha;
        private System.Windows.Forms.Label lblDescripcionClase;
        private System.Windows.Forms.TextBox txtBoxDescripcionClase;
        private System.Windows.Forms.Label lblTemasDeClase;
        private System.Windows.Forms.ListBox listBoxTemasClase;
        private System.Windows.Forms.GroupBox gbVisualizacion;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblDescripcionTema;
        private System.Windows.Forms.TextBox txtDescripcionTema;
        private System.Windows.Forms.MaskedTextBox txtBoxBuscar;
    }
}