
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerCalificacionesDeCursada
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
            this.rbEvaluacionesFecha = new System.Windows.Forms.RadioButton();
            this.rbEvaluacionesTodos = new System.Windows.Forms.RadioButton();
            this.dgvEvaluacionesCalificacion = new System.Windows.Forms.DataGridView();
            this.lblTemasDeEvaluacion = new System.Windows.Forms.Label();
            this.listBoxTemasEvaluacion = new System.Windows.Forms.ListBox();
            this.rbEvaluacionesCalificacion = new System.Windows.Forms.RadioButton();
            this.lblDocenteEvaluacion = new System.Windows.Forms.Label();
            this.txtBoxDocenteEvaluacion = new System.Windows.Forms.TextBox();
            this.rbEvaluacionesMateria = new System.Windows.Forms.RadioButton();
            this.DGV_Calificaciones_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Calificaciones_Eval_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Calificaciones_Eval_Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Calificaciones_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Calificaciones_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Calificaciones_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluacionesCalificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(227, 281);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lblBusqueda.TabIndex = 36;
            this.lblBusqueda.Text = "label1";
            // 
            // txtBoxBusqueda
            // 
            this.txtBoxBusqueda.Location = new System.Drawing.Point(230, 297);
            this.txtBoxBusqueda.Name = "txtBoxBusqueda";
            this.txtBoxBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBusqueda.TabIndex = 35;
            this.txtBoxBusqueda.TextChanged += new System.EventHandler(this.txtBoxBusqueda_TextChanged_1);
            // 
            // gpVisualizacion
            // 
            this.gpVisualizacion.Controls.Add(this.rbEvaluacionesCalificacion);
            this.gpVisualizacion.Controls.Add(this.rbEvaluacionesFecha);
            this.gpVisualizacion.Controls.Add(this.rbEvaluacionesMateria);
            this.gpVisualizacion.Controls.Add(this.rbEvaluacionesTodos);
            this.gpVisualizacion.Location = new System.Drawing.Point(12, 278);
            this.gpVisualizacion.Name = "gpVisualizacion";
            this.gpVisualizacion.Size = new System.Drawing.Size(201, 67);
            this.gpVisualizacion.TabIndex = 34;
            this.gpVisualizacion.TabStop = false;
            this.gpVisualizacion.Text = "groupBox1";
            // 
            // rbEvaluacionesFecha
            // 
            this.rbEvaluacionesFecha.AutoSize = true;
            this.rbEvaluacionesFecha.Location = new System.Drawing.Point(108, 19);
            this.rbEvaluacionesFecha.Name = "rbEvaluacionesFecha";
            this.rbEvaluacionesFecha.Size = new System.Drawing.Size(85, 17);
            this.rbEvaluacionesFecha.TabIndex = 28;
            this.rbEvaluacionesFecha.Text = "radioButton1";
            this.rbEvaluacionesFecha.UseVisualStyleBackColor = true;
            this.rbEvaluacionesFecha.CheckedChanged += new System.EventHandler(this.rbEvaluacionesFecha_CheckedChanged_1);
            // 
            // rbEvaluacionesTodos
            // 
            this.rbEvaluacionesTodos.AutoSize = true;
            this.rbEvaluacionesTodos.Checked = true;
            this.rbEvaluacionesTodos.Location = new System.Drawing.Point(6, 19);
            this.rbEvaluacionesTodos.Name = "rbEvaluacionesTodos";
            this.rbEvaluacionesTodos.Size = new System.Drawing.Size(106, 17);
            this.rbEvaluacionesTodos.TabIndex = 26;
            this.rbEvaluacionesTodos.TabStop = true;
            this.rbEvaluacionesTodos.Text = "rbAlumnosLegajo";
            this.rbEvaluacionesTodos.UseVisualStyleBackColor = true;
            this.rbEvaluacionesTodos.CheckedChanged += new System.EventHandler(this.rbEvaluacionesTodos_CheckedChanged);
            // 
            // dgvEvaluacionesCalificacion
            // 
            this.dgvEvaluacionesCalificacion.AllowUserToAddRows = false;
            this.dgvEvaluacionesCalificacion.AllowUserToDeleteRows = false;
            this.dgvEvaluacionesCalificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvaluacionesCalificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluacionesCalificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Calificaciones_Codigo,
            this.DGV_Calificaciones_Eval_Codigo,
            this.DGV_Calificaciones_Eval_Titulo,
            this.DGV_Calificaciones_Materia,
            this.DGV_Calificaciones_Fecha,
            this.DGV_Calificaciones_Valor});
            this.dgvEvaluacionesCalificacion.Location = new System.Drawing.Point(12, 12);
            this.dgvEvaluacionesCalificacion.MultiSelect = false;
            this.dgvEvaluacionesCalificacion.Name = "dgvEvaluacionesCalificacion";
            this.dgvEvaluacionesCalificacion.ReadOnly = true;
            this.dgvEvaluacionesCalificacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvaluacionesCalificacion.Size = new System.Drawing.Size(705, 260);
            this.dgvEvaluacionesCalificacion.TabIndex = 33;
            this.dgvEvaluacionesCalificacion.TabStop = false;
            this.dgvEvaluacionesCalificacion.Click += new System.EventHandler(this.dgvEvaluacionesCalificacion_Click);
            // 
            // lblTemasDeEvaluacion
            // 
            this.lblTemasDeEvaluacion.AutoSize = true;
            this.lblTemasDeEvaluacion.Location = new System.Drawing.Point(549, 281);
            this.lblTemasDeEvaluacion.Name = "lblTemasDeEvaluacion";
            this.lblTemasDeEvaluacion.Size = new System.Drawing.Size(35, 13);
            this.lblTemasDeEvaluacion.TabIndex = 38;
            this.lblTemasDeEvaluacion.Text = "label1";
            // 
            // listBoxTemasEvaluacion
            // 
            this.listBoxTemasEvaluacion.FormattingEnabled = true;
            this.listBoxTemasEvaluacion.Location = new System.Drawing.Point(552, 297);
            this.listBoxTemasEvaluacion.Name = "listBoxTemasEvaluacion";
            this.listBoxTemasEvaluacion.Size = new System.Drawing.Size(165, 199);
            this.listBoxTemasEvaluacion.TabIndex = 37;
            // 
            // rbEvaluacionesCalificacion
            // 
            this.rbEvaluacionesCalificacion.AutoSize = true;
            this.rbEvaluacionesCalificacion.Location = new System.Drawing.Point(108, 42);
            this.rbEvaluacionesCalificacion.Name = "rbEvaluacionesCalificacion";
            this.rbEvaluacionesCalificacion.Size = new System.Drawing.Size(85, 17);
            this.rbEvaluacionesCalificacion.TabIndex = 29;
            this.rbEvaluacionesCalificacion.Text = "radioButton1";
            this.rbEvaluacionesCalificacion.UseVisualStyleBackColor = true;
            this.rbEvaluacionesCalificacion.CheckedChanged += new System.EventHandler(this.rbEvaluacionesCalificacion_CheckedChanged_1);
            // 
            // lblDocenteEvaluacion
            // 
            this.lblDocenteEvaluacion.AutoSize = true;
            this.lblDocenteEvaluacion.Location = new System.Drawing.Point(420, 281);
            this.lblDocenteEvaluacion.Name = "lblDocenteEvaluacion";
            this.lblDocenteEvaluacion.Size = new System.Drawing.Size(35, 13);
            this.lblDocenteEvaluacion.TabIndex = 40;
            this.lblDocenteEvaluacion.Text = "label1";
            // 
            // txtBoxDocenteEvaluacion
            // 
            this.txtBoxDocenteEvaluacion.BackColor = System.Drawing.Color.White;
            this.txtBoxDocenteEvaluacion.Location = new System.Drawing.Point(423, 297);
            this.txtBoxDocenteEvaluacion.Name = "txtBoxDocenteEvaluacion";
            this.txtBoxDocenteEvaluacion.ReadOnly = true;
            this.txtBoxDocenteEvaluacion.Size = new System.Drawing.Size(107, 20);
            this.txtBoxDocenteEvaluacion.TabIndex = 39;
            // 
            // rbEvaluacionesMateria
            // 
            this.rbEvaluacionesMateria.AutoSize = true;
            this.rbEvaluacionesMateria.Location = new System.Drawing.Point(6, 42);
            this.rbEvaluacionesMateria.Name = "rbEvaluacionesMateria";
            this.rbEvaluacionesMateria.Size = new System.Drawing.Size(93, 17);
            this.rbEvaluacionesMateria.TabIndex = 27;
            this.rbEvaluacionesMateria.Text = "rbAlumnosDNI";
            this.rbEvaluacionesMateria.UseVisualStyleBackColor = true;
            this.rbEvaluacionesMateria.CheckedChanged += new System.EventHandler(this.rbEvaluacionesMateria_CheckedChanged);
            // 
            // DGV_Calificaciones_Codigo
            // 
            this.DGV_Calificaciones_Codigo.HeaderText = "Column1";
            this.DGV_Calificaciones_Codigo.Name = "DGV_Calificaciones_Codigo";
            this.DGV_Calificaciones_Codigo.ReadOnly = true;
            // 
            // DGV_Calificaciones_Eval_Codigo
            // 
            this.DGV_Calificaciones_Eval_Codigo.HeaderText = "Column1";
            this.DGV_Calificaciones_Eval_Codigo.Name = "DGV_Calificaciones_Eval_Codigo";
            this.DGV_Calificaciones_Eval_Codigo.ReadOnly = true;
            // 
            // DGV_Calificaciones_Eval_Titulo
            // 
            this.DGV_Calificaciones_Eval_Titulo.HeaderText = "Column1";
            this.DGV_Calificaciones_Eval_Titulo.Name = "DGV_Calificaciones_Eval_Titulo";
            this.DGV_Calificaciones_Eval_Titulo.ReadOnly = true;
            // 
            // DGV_Calificaciones_Materia
            // 
            this.DGV_Calificaciones_Materia.HeaderText = "Column1";
            this.DGV_Calificaciones_Materia.Name = "DGV_Calificaciones_Materia";
            this.DGV_Calificaciones_Materia.ReadOnly = true;
            // 
            // DGV_Calificaciones_Fecha
            // 
            this.DGV_Calificaciones_Fecha.HeaderText = "Column1";
            this.DGV_Calificaciones_Fecha.Name = "DGV_Calificaciones_Fecha";
            this.DGV_Calificaciones_Fecha.ReadOnly = true;
            // 
            // DGV_Calificaciones_Valor
            // 
            this.DGV_Calificaciones_Valor.HeaderText = "Column1";
            this.DGV_Calificaciones_Valor.Name = "DGV_Calificaciones_Valor";
            this.DGV_Calificaciones_Valor.ReadOnly = true;
            // 
            // FormVerCalificacionesDeCursada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 501);
            this.Controls.Add(this.lblDocenteEvaluacion);
            this.Controls.Add(this.txtBoxDocenteEvaluacion);
            this.Controls.Add(this.lblTemasDeEvaluacion);
            this.Controls.Add(this.listBoxTemasEvaluacion);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtBoxBusqueda);
            this.Controls.Add(this.gpVisualizacion);
            this.Controls.Add(this.dgvEvaluacionesCalificacion);
            this.Name = "FormVerCalificacionesDeCursada";
            this.Text = "FormVerEvaluacionesDeCursada";
            this.Load += new System.EventHandler(this.FormVerCalificacionesDeCursada_Load);
            this.gpVisualizacion.ResumeLayout(false);
            this.gpVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluacionesCalificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBoxBusqueda;
        private System.Windows.Forms.GroupBox gpVisualizacion;
        private System.Windows.Forms.RadioButton rbEvaluacionesFecha;
        private System.Windows.Forms.RadioButton rbEvaluacionesTodos;
        private System.Windows.Forms.DataGridView dgvEvaluacionesCalificacion;
        private System.Windows.Forms.RadioButton rbEvaluacionesCalificacion;
        private System.Windows.Forms.Label lblTemasDeEvaluacion;
        private System.Windows.Forms.ListBox listBoxTemasEvaluacion;
        private System.Windows.Forms.Label lblDocenteEvaluacion;
        private System.Windows.Forms.TextBox txtBoxDocenteEvaluacion;
        private System.Windows.Forms.RadioButton rbEvaluacionesMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Calificaciones_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Calificaciones_Eval_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Calificaciones_Eval_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Calificaciones_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Calificaciones_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Calificaciones_Valor;
    }
}