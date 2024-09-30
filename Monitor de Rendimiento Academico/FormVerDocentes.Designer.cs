
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerDocentes
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
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBoxBusqueda = new System.Windows.Forms.TextBox();
            this.gpVisualizacion = new System.Windows.Forms.GroupBox();
            this.rbDocentesNombre = new System.Windows.Forms.RadioButton();
            this.rbDocentesApellido = new System.Windows.Forms.RadioButton();
            this.rbDocentesDNI = new System.Windows.Forms.RadioButton();
            this.rbDocentesLegajo = new System.Windows.Forms.RadioButton();
            this.rbDocentesTodos = new System.Windows.Forms.RadioButton();
            this.gpDocentesActivos = new System.Windows.Forms.GroupBox();
            this.rbDocentesInactivos = new System.Windows.Forms.RadioButton();
            this.rbDocentesActivos = new System.Windows.Forms.RadioButton();
            this.btnVerDictados = new System.Windows.Forms.Button();
            this.btnDarDeBajaDocente = new System.Windows.Forms.Button();
            this.btnModificarDocente = new System.Windows.Forms.Button();
            this.dgvDocentesActivos = new System.Windows.Forms.DataGridView();
            this.DGV_DocentesActivos_Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_DocentesActivos_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_DocentesActivos_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_DocentesActivos_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDarDeAltaDocente = new System.Windows.Forms.Button();
            this.gpVisualizacion.SuspendLayout();
            this.gpDocentesActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentesActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(421, 360);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lblBusqueda.TabIndex = 40;
            this.lblBusqueda.Text = "label1";
            // 
            // txtBoxBusqueda
            // 
            this.txtBoxBusqueda.Location = new System.Drawing.Point(424, 376);
            this.txtBoxBusqueda.Name = "txtBoxBusqueda";
            this.txtBoxBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBusqueda.TabIndex = 39;
            this.txtBoxBusqueda.TextChanged += new System.EventHandler(this.txtBoxBusqueda_TextChanged);
            // 
            // gpVisualizacion
            // 
            this.gpVisualizacion.Controls.Add(this.rbDocentesNombre);
            this.gpVisualizacion.Controls.Add(this.rbDocentesApellido);
            this.gpVisualizacion.Controls.Add(this.rbDocentesDNI);
            this.gpVisualizacion.Controls.Add(this.rbDocentesLegajo);
            this.gpVisualizacion.Controls.Add(this.rbDocentesTodos);
            this.gpVisualizacion.Location = new System.Drawing.Point(424, 278);
            this.gpVisualizacion.Name = "gpVisualizacion";
            this.gpVisualizacion.Size = new System.Drawing.Size(293, 67);
            this.gpVisualizacion.TabIndex = 38;
            this.gpVisualizacion.TabStop = false;
            this.gpVisualizacion.Text = "groupBox1";
            // 
            // rbDocentesNombre
            // 
            this.rbDocentesNombre.AutoSize = true;
            this.rbDocentesNombre.Location = new System.Drawing.Point(199, 19);
            this.rbDocentesNombre.Name = "rbDocentesNombre";
            this.rbDocentesNombre.Size = new System.Drawing.Size(85, 17);
            this.rbDocentesNombre.TabIndex = 30;
            this.rbDocentesNombre.Text = "radioButton3";
            this.rbDocentesNombre.UseVisualStyleBackColor = true;
            this.rbDocentesNombre.CheckedChanged += new System.EventHandler(this.rbDocentesNombre_CheckedChanged);
            // 
            // rbDocentesApellido
            // 
            this.rbDocentesApellido.AutoSize = true;
            this.rbDocentesApellido.Location = new System.Drawing.Point(108, 42);
            this.rbDocentesApellido.Name = "rbDocentesApellido";
            this.rbDocentesApellido.Size = new System.Drawing.Size(85, 17);
            this.rbDocentesApellido.TabIndex = 29;
            this.rbDocentesApellido.Text = "radioButton2";
            this.rbDocentesApellido.UseVisualStyleBackColor = true;
            this.rbDocentesApellido.CheckedChanged += new System.EventHandler(this.rbDocentesApellido_CheckedChanged);
            // 
            // rbDocentesDNI
            // 
            this.rbDocentesDNI.AutoSize = true;
            this.rbDocentesDNI.Location = new System.Drawing.Point(108, 19);
            this.rbDocentesDNI.Name = "rbDocentesDNI";
            this.rbDocentesDNI.Size = new System.Drawing.Size(85, 17);
            this.rbDocentesDNI.TabIndex = 28;
            this.rbDocentesDNI.Text = "radioButton1";
            this.rbDocentesDNI.UseVisualStyleBackColor = true;
            this.rbDocentesDNI.CheckedChanged += new System.EventHandler(this.rbDocentesDNI_CheckedChanged);
            // 
            // rbDocentesLegajo
            // 
            this.rbDocentesLegajo.AutoSize = true;
            this.rbDocentesLegajo.Location = new System.Drawing.Point(6, 42);
            this.rbDocentesLegajo.Name = "rbDocentesLegajo";
            this.rbDocentesLegajo.Size = new System.Drawing.Size(93, 17);
            this.rbDocentesLegajo.TabIndex = 27;
            this.rbDocentesLegajo.Text = "rbAlumnosDNI";
            this.rbDocentesLegajo.UseVisualStyleBackColor = true;
            this.rbDocentesLegajo.CheckedChanged += new System.EventHandler(this.rbDocentesLegajo_CheckedChanged);
            // 
            // rbDocentesTodos
            // 
            this.rbDocentesTodos.AutoSize = true;
            this.rbDocentesTodos.Checked = true;
            this.rbDocentesTodos.Location = new System.Drawing.Point(6, 19);
            this.rbDocentesTodos.Name = "rbDocentesTodos";
            this.rbDocentesTodos.Size = new System.Drawing.Size(106, 17);
            this.rbDocentesTodos.TabIndex = 26;
            this.rbDocentesTodos.TabStop = true;
            this.rbDocentesTodos.Text = "rbAlumnosLegajo";
            this.rbDocentesTodos.UseVisualStyleBackColor = true;
            this.rbDocentesTodos.CheckedChanged += new System.EventHandler(this.rbDocentesTodos_CheckedChanged);
            // 
            // gpDocentesActivos
            // 
            this.gpDocentesActivos.Controls.Add(this.rbDocentesInactivos);
            this.gpDocentesActivos.Controls.Add(this.rbDocentesActivos);
            this.gpDocentesActivos.Location = new System.Drawing.Point(312, 278);
            this.gpDocentesActivos.Name = "gpDocentesActivos";
            this.gpDocentesActivos.Size = new System.Drawing.Size(106, 67);
            this.gpDocentesActivos.TabIndex = 37;
            this.gpDocentesActivos.TabStop = false;
            this.gpDocentesActivos.Text = "groupBox1";
            // 
            // rbDocentesInactivos
            // 
            this.rbDocentesInactivos.AutoSize = true;
            this.rbDocentesInactivos.Location = new System.Drawing.Point(6, 44);
            this.rbDocentesInactivos.Name = "rbDocentesInactivos";
            this.rbDocentesInactivos.Size = new System.Drawing.Size(85, 17);
            this.rbDocentesInactivos.TabIndex = 25;
            this.rbDocentesInactivos.Text = "radioButton2";
            this.rbDocentesInactivos.UseVisualStyleBackColor = true;
            this.rbDocentesInactivos.CheckedChanged += new System.EventHandler(this.rbDocentesInactivos_CheckedChanged);
            // 
            // rbDocentesActivos
            // 
            this.rbDocentesActivos.AutoSize = true;
            this.rbDocentesActivos.Checked = true;
            this.rbDocentesActivos.Location = new System.Drawing.Point(6, 21);
            this.rbDocentesActivos.Name = "rbDocentesActivos";
            this.rbDocentesActivos.Size = new System.Drawing.Size(85, 17);
            this.rbDocentesActivos.TabIndex = 24;
            this.rbDocentesActivos.TabStop = true;
            this.rbDocentesActivos.Text = "radioButton1";
            this.rbDocentesActivos.UseVisualStyleBackColor = true;
            this.rbDocentesActivos.CheckedChanged += new System.EventHandler(this.rbDocentesActivos_CheckedChanged);
            // 
            // btnVerDictados
            // 
            this.btnVerDictados.Location = new System.Drawing.Point(212, 278);
            this.btnVerDictados.Name = "btnVerDictados";
            this.btnVerDictados.Size = new System.Drawing.Size(94, 44);
            this.btnVerDictados.TabIndex = 36;
            this.btnVerDictados.Text = "button3";
            this.btnVerDictados.UseVisualStyleBackColor = true;
            this.btnVerDictados.Click += new System.EventHandler(this.btnVerDictados_Click);
            // 
            // btnDarDeBajaDocente
            // 
            this.btnDarDeBajaDocente.Location = new System.Drawing.Point(112, 278);
            this.btnDarDeBajaDocente.Name = "btnDarDeBajaDocente";
            this.btnDarDeBajaDocente.Size = new System.Drawing.Size(94, 44);
            this.btnDarDeBajaDocente.TabIndex = 35;
            this.btnDarDeBajaDocente.Text = "button2";
            this.btnDarDeBajaDocente.UseVisualStyleBackColor = true;
            this.btnDarDeBajaDocente.Click += new System.EventHandler(this.btnDarDeBajaDocente_Click);
            // 
            // btnModificarDocente
            // 
            this.btnModificarDocente.Location = new System.Drawing.Point(12, 278);
            this.btnModificarDocente.Name = "btnModificarDocente";
            this.btnModificarDocente.Size = new System.Drawing.Size(94, 44);
            this.btnModificarDocente.TabIndex = 34;
            this.btnModificarDocente.Text = "button1";
            this.btnModificarDocente.UseVisualStyleBackColor = true;
            this.btnModificarDocente.Click += new System.EventHandler(this.btnModificarDocente_Click);
            // 
            // dgvDocentesActivos
            // 
            this.dgvDocentesActivos.AllowUserToAddRows = false;
            this.dgvDocentesActivos.AllowUserToDeleteRows = false;
            this.dgvDocentesActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocentesActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentesActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_DocentesActivos_Legajo,
            this.DGV_DocentesActivos_DNI,
            this.DGV_DocentesActivos_Apellido,
            this.DGV_DocentesActivos_Nombre});
            this.dgvDocentesActivos.Location = new System.Drawing.Point(12, 12);
            this.dgvDocentesActivos.MultiSelect = false;
            this.dgvDocentesActivos.Name = "dgvDocentesActivos";
            this.dgvDocentesActivos.ReadOnly = true;
            this.dgvDocentesActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentesActivos.Size = new System.Drawing.Size(705, 260);
            this.dgvDocentesActivos.TabIndex = 33;
            this.dgvDocentesActivos.TabStop = false;
            // 
            // DGV_DocentesActivos_Legajo
            // 
            this.DGV_DocentesActivos_Legajo.HeaderText = "Column1";
            this.DGV_DocentesActivos_Legajo.Name = "DGV_DocentesActivos_Legajo";
            this.DGV_DocentesActivos_Legajo.ReadOnly = true;
            // 
            // DGV_DocentesActivos_DNI
            // 
            this.DGV_DocentesActivos_DNI.HeaderText = "Column1";
            this.DGV_DocentesActivos_DNI.Name = "DGV_DocentesActivos_DNI";
            this.DGV_DocentesActivos_DNI.ReadOnly = true;
            // 
            // DGV_DocentesActivos_Apellido
            // 
            this.DGV_DocentesActivos_Apellido.HeaderText = "Column1";
            this.DGV_DocentesActivos_Apellido.Name = "DGV_DocentesActivos_Apellido";
            this.DGV_DocentesActivos_Apellido.ReadOnly = true;
            // 
            // DGV_DocentesActivos_Nombre
            // 
            this.DGV_DocentesActivos_Nombre.HeaderText = "Column1";
            this.DGV_DocentesActivos_Nombre.Name = "DGV_DocentesActivos_Nombre";
            this.DGV_DocentesActivos_Nombre.ReadOnly = true;
            // 
            // btnDarDeAltaDocente
            // 
            this.btnDarDeAltaDocente.Location = new System.Drawing.Point(112, 278);
            this.btnDarDeAltaDocente.Name = "btnDarDeAltaDocente";
            this.btnDarDeAltaDocente.Size = new System.Drawing.Size(94, 44);
            this.btnDarDeAltaDocente.TabIndex = 41;
            this.btnDarDeAltaDocente.Text = "button2";
            this.btnDarDeAltaDocente.UseVisualStyleBackColor = true;
            this.btnDarDeAltaDocente.Click += new System.EventHandler(this.btnDarDeAltaDocente_Click);
            // 
            // FormVerDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 406);
            this.Controls.Add(this.btnDarDeAltaDocente);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtBoxBusqueda);
            this.Controls.Add(this.gpVisualizacion);
            this.Controls.Add(this.gpDocentesActivos);
            this.Controls.Add(this.btnVerDictados);
            this.Controls.Add(this.btnDarDeBajaDocente);
            this.Controls.Add(this.btnModificarDocente);
            this.Controls.Add(this.dgvDocentesActivos);
            this.Name = "FormVerDocentes";
            this.Text = "FormVerDocentes";
            this.Load += new System.EventHandler(this.FormVerDocentes_Load);
            this.gpVisualizacion.ResumeLayout(false);
            this.gpVisualizacion.PerformLayout();
            this.gpDocentesActivos.ResumeLayout(false);
            this.gpDocentesActivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentesActivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBoxBusqueda;
        private System.Windows.Forms.GroupBox gpVisualizacion;
        private System.Windows.Forms.RadioButton rbDocentesNombre;
        private System.Windows.Forms.RadioButton rbDocentesApellido;
        private System.Windows.Forms.RadioButton rbDocentesDNI;
        private System.Windows.Forms.RadioButton rbDocentesLegajo;
        private System.Windows.Forms.RadioButton rbDocentesTodos;
        private System.Windows.Forms.GroupBox gpDocentesActivos;
        private System.Windows.Forms.RadioButton rbDocentesInactivos;
        private System.Windows.Forms.RadioButton rbDocentesActivos;
        private System.Windows.Forms.Button btnVerDictados;
        private System.Windows.Forms.Button btnDarDeBajaDocente;
        private System.Windows.Forms.Button btnModificarDocente;
        private System.Windows.Forms.DataGridView dgvDocentesActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_DocentesActivos_Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_DocentesActivos_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_DocentesActivos_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_DocentesActivos_Nombre;
        private System.Windows.Forms.Button btnDarDeAltaDocente;
    }
}