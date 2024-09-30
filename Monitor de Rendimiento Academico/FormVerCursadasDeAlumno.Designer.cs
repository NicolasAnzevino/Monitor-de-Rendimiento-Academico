
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerCursadasDeAlumno
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
            this.dgvCursadasAlumno = new System.Windows.Forms.DataGridView();
            this.DGV_CursadasAlumno_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursadasAlumno_Cur_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursadasAlumno_Cur_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursadasAlumno_Cur_Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursadasAlumno_Cur_Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursadasAlumno_Cur_Libre = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_CursadasAlumno_Cur_Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnVerEvaluacionesDeCursada = new System.Windows.Forms.Button();
            this.btnVerRendimientoDeCursada = new System.Windows.Forms.Button();
            this.btnCompararRendimiento = new System.Windows.Forms.Button();
            this.btnCancelarComparacion = new System.Windows.Forms.Button();
            this.btnAgregarCursada = new System.Windows.Forms.Button();
            this.lblCursada1 = new System.Windows.Forms.Label();
            this.txtBoxCursada1 = new System.Windows.Forms.TextBox();
            this.txtBoxCursada2 = new System.Windows.Forms.TextBox();
            this.lblCursada2 = new System.Windows.Forms.Label();
            this.btnDeseleccionarCursadas = new System.Windows.Forms.Button();
            this.btnCompararCursadas = new System.Windows.Forms.Button();
            this.btnVerInasistencias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursadasAlumno)).BeginInit();
            this.SuspendLayout();
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
            this.DGV_CursadasAlumno_Cur_Libre,
            this.DGV_CursadasAlumno_Cur_Activo});
            this.dgvCursadasAlumno.Location = new System.Drawing.Point(12, 12);
            this.dgvCursadasAlumno.MultiSelect = false;
            this.dgvCursadasAlumno.Name = "dgvCursadasAlumno";
            this.dgvCursadasAlumno.ReadOnly = true;
            this.dgvCursadasAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursadasAlumno.Size = new System.Drawing.Size(799, 227);
            this.dgvCursadasAlumno.TabIndex = 2;
            this.dgvCursadasAlumno.TabStop = false;
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
            // DGV_CursadasAlumno_Cur_Libre
            // 
            this.DGV_CursadasAlumno_Cur_Libre.HeaderText = "Column1";
            this.DGV_CursadasAlumno_Cur_Libre.Name = "DGV_CursadasAlumno_Cur_Libre";
            this.DGV_CursadasAlumno_Cur_Libre.ReadOnly = true;
            // 
            // DGV_CursadasAlumno_Cur_Activo
            // 
            this.DGV_CursadasAlumno_Cur_Activo.HeaderText = "Column1";
            this.DGV_CursadasAlumno_Cur_Activo.Name = "DGV_CursadasAlumno_Cur_Activo";
            this.DGV_CursadasAlumno_Cur_Activo.ReadOnly = true;
            this.DGV_CursadasAlumno_Cur_Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_CursadasAlumno_Cur_Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnVerEvaluacionesDeCursada
            // 
            this.btnVerEvaluacionesDeCursada.Location = new System.Drawing.Point(12, 245);
            this.btnVerEvaluacionesDeCursada.Name = "btnVerEvaluacionesDeCursada";
            this.btnVerEvaluacionesDeCursada.Size = new System.Drawing.Size(96, 47);
            this.btnVerEvaluacionesDeCursada.TabIndex = 3;
            this.btnVerEvaluacionesDeCursada.Text = "button1";
            this.btnVerEvaluacionesDeCursada.UseVisualStyleBackColor = true;
            this.btnVerEvaluacionesDeCursada.Click += new System.EventHandler(this.btnVerEvaluacionesDeCursada_Click);
            // 
            // btnVerRendimientoDeCursada
            // 
            this.btnVerRendimientoDeCursada.Location = new System.Drawing.Point(114, 245);
            this.btnVerRendimientoDeCursada.Name = "btnVerRendimientoDeCursada";
            this.btnVerRendimientoDeCursada.Size = new System.Drawing.Size(96, 47);
            this.btnVerRendimientoDeCursada.TabIndex = 4;
            this.btnVerRendimientoDeCursada.Text = "button1";
            this.btnVerRendimientoDeCursada.UseVisualStyleBackColor = true;
            this.btnVerRendimientoDeCursada.Click += new System.EventHandler(this.btnVerRendimientoDeCursada_Click);
            // 
            // btnCompararRendimiento
            // 
            this.btnCompararRendimiento.Location = new System.Drawing.Point(318, 245);
            this.btnCompararRendimiento.Name = "btnCompararRendimiento";
            this.btnCompararRendimiento.Size = new System.Drawing.Size(96, 47);
            this.btnCompararRendimiento.TabIndex = 5;
            this.btnCompararRendimiento.Text = "button1";
            this.btnCompararRendimiento.UseVisualStyleBackColor = true;
            this.btnCompararRendimiento.Click += new System.EventHandler(this.btnCompararRendimiento_Click);
            // 
            // btnCancelarComparacion
            // 
            this.btnCancelarComparacion.Location = new System.Drawing.Point(318, 245);
            this.btnCancelarComparacion.Name = "btnCancelarComparacion";
            this.btnCancelarComparacion.Size = new System.Drawing.Size(96, 47);
            this.btnCancelarComparacion.TabIndex = 6;
            this.btnCancelarComparacion.Text = "button1";
            this.btnCancelarComparacion.UseVisualStyleBackColor = true;
            this.btnCancelarComparacion.Click += new System.EventHandler(this.btnCancelarComparacion_Click);
            // 
            // btnAgregarCursada
            // 
            this.btnAgregarCursada.Location = new System.Drawing.Point(490, 245);
            this.btnAgregarCursada.Name = "btnAgregarCursada";
            this.btnAgregarCursada.Size = new System.Drawing.Size(96, 47);
            this.btnAgregarCursada.TabIndex = 7;
            this.btnAgregarCursada.Text = "button1";
            this.btnAgregarCursada.UseVisualStyleBackColor = true;
            this.btnAgregarCursada.Click += new System.EventHandler(this.btnAgregarCursada_Click);
            // 
            // lblCursada1
            // 
            this.lblCursada1.AutoSize = true;
            this.lblCursada1.Location = new System.Drawing.Point(589, 245);
            this.lblCursada1.Name = "lblCursada1";
            this.lblCursada1.Size = new System.Drawing.Size(35, 13);
            this.lblCursada1.TabIndex = 8;
            this.lblCursada1.Text = "label1";
            // 
            // txtBoxCursada1
            // 
            this.txtBoxCursada1.BackColor = System.Drawing.Color.White;
            this.txtBoxCursada1.Location = new System.Drawing.Point(592, 261);
            this.txtBoxCursada1.Name = "txtBoxCursada1";
            this.txtBoxCursada1.ReadOnly = true;
            this.txtBoxCursada1.Size = new System.Drawing.Size(117, 20);
            this.txtBoxCursada1.TabIndex = 9;
            // 
            // txtBoxCursada2
            // 
            this.txtBoxCursada2.BackColor = System.Drawing.Color.White;
            this.txtBoxCursada2.Location = new System.Drawing.Point(592, 304);
            this.txtBoxCursada2.Name = "txtBoxCursada2";
            this.txtBoxCursada2.ReadOnly = true;
            this.txtBoxCursada2.Size = new System.Drawing.Size(117, 20);
            this.txtBoxCursada2.TabIndex = 11;
            // 
            // lblCursada2
            // 
            this.lblCursada2.AutoSize = true;
            this.lblCursada2.Location = new System.Drawing.Point(589, 288);
            this.lblCursada2.Name = "lblCursada2";
            this.lblCursada2.Size = new System.Drawing.Size(35, 13);
            this.lblCursada2.TabIndex = 10;
            this.lblCursada2.Text = "label2";
            // 
            // btnDeseleccionarCursadas
            // 
            this.btnDeseleccionarCursadas.Location = new System.Drawing.Point(715, 245);
            this.btnDeseleccionarCursadas.Name = "btnDeseleccionarCursadas";
            this.btnDeseleccionarCursadas.Size = new System.Drawing.Size(96, 47);
            this.btnDeseleccionarCursadas.TabIndex = 12;
            this.btnDeseleccionarCursadas.Text = "button2";
            this.btnDeseleccionarCursadas.UseVisualStyleBackColor = true;
            this.btnDeseleccionarCursadas.Click += new System.EventHandler(this.btnDeseleccionarCursadas_Click);
            // 
            // btnCompararCursadas
            // 
            this.btnCompararCursadas.Location = new System.Drawing.Point(715, 298);
            this.btnCompararCursadas.Name = "btnCompararCursadas";
            this.btnCompararCursadas.Size = new System.Drawing.Size(96, 47);
            this.btnCompararCursadas.TabIndex = 13;
            this.btnCompararCursadas.Text = "button3";
            this.btnCompararCursadas.UseVisualStyleBackColor = true;
            this.btnCompararCursadas.Click += new System.EventHandler(this.btnCompararCursadas_Click);
            // 
            // btnVerInasistencias
            // 
            this.btnVerInasistencias.Location = new System.Drawing.Point(216, 245);
            this.btnVerInasistencias.Name = "btnVerInasistencias";
            this.btnVerInasistencias.Size = new System.Drawing.Size(96, 47);
            this.btnVerInasistencias.TabIndex = 14;
            this.btnVerInasistencias.Text = "button1";
            this.btnVerInasistencias.UseVisualStyleBackColor = true;
            this.btnVerInasistencias.Click += new System.EventHandler(this.btnVerInasistencias_Click);
            // 
            // FormVerCursadasDeAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 357);
            this.Controls.Add(this.btnVerInasistencias);
            this.Controls.Add(this.btnCompararCursadas);
            this.Controls.Add(this.btnDeseleccionarCursadas);
            this.Controls.Add(this.txtBoxCursada2);
            this.Controls.Add(this.lblCursada2);
            this.Controls.Add(this.txtBoxCursada1);
            this.Controls.Add(this.lblCursada1);
            this.Controls.Add(this.btnAgregarCursada);
            this.Controls.Add(this.btnCancelarComparacion);
            this.Controls.Add(this.btnCompararRendimiento);
            this.Controls.Add(this.btnVerRendimientoDeCursada);
            this.Controls.Add(this.btnVerEvaluacionesDeCursada);
            this.Controls.Add(this.dgvCursadasAlumno);
            this.Name = "FormVerCursadasDeAlumno";
            this.Text = "FormVerCursadasDeAlumno";
            this.Load += new System.EventHandler(this.FormVerCursadasDeAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursadasAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursadasAlumno;
        private System.Windows.Forms.Button btnVerEvaluacionesDeCursada;
        private System.Windows.Forms.Button btnVerRendimientoDeCursada;
        private System.Windows.Forms.Button btnCompararRendimiento;
        private System.Windows.Forms.Button btnCancelarComparacion;
        private System.Windows.Forms.Button btnAgregarCursada;
        private System.Windows.Forms.Label lblCursada1;
        private System.Windows.Forms.TextBox txtBoxCursada1;
        private System.Windows.Forms.TextBox txtBoxCursada2;
        private System.Windows.Forms.Label lblCursada2;
        private System.Windows.Forms.Button btnDeseleccionarCursadas;
        private System.Windows.Forms.Button btnCompararCursadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursadasAlumno_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursadasAlumno_Cur_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursadasAlumno_Cur_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursadasAlumno_Cur_Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursadasAlumno_Cur_Turno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_CursadasAlumno_Cur_Libre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_CursadasAlumno_Cur_Activo;
        private System.Windows.Forms.Button btnVerInasistencias;
    }
}