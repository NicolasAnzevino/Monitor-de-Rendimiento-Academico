
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerCursosEncuestasResultado
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
            this.btnVerEncuestasDeCurso = new System.Windows.Forms.Button();
            this.dgvCursosActivos = new System.Windows.Forms.DataGridView();
            this.DGV_CursosActivos_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.gpConsultas = new System.Windows.Forms.GroupBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbTurno = new System.Windows.Forms.RadioButton();
            this.rbAño = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.txtBoxBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosActivos)).BeginInit();
            this.gpConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerEncuestasDeCurso
            // 
            this.btnVerEncuestasDeCurso.Location = new System.Drawing.Point(12, 278);
            this.btnVerEncuestasDeCurso.Name = "btnVerEncuestasDeCurso";
            this.btnVerEncuestasDeCurso.Size = new System.Drawing.Size(108, 47);
            this.btnVerEncuestasDeCurso.TabIndex = 25;
            this.btnVerEncuestasDeCurso.Text = "button1";
            this.btnVerEncuestasDeCurso.UseVisualStyleBackColor = true;
            this.btnVerEncuestasDeCurso.Click += new System.EventHandler(this.btnVerEncuestasDeCurso_Click);
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
            this.dgvCursosActivos.Location = new System.Drawing.Point(12, 12);
            this.dgvCursosActivos.MultiSelect = false;
            this.dgvCursosActivos.Name = "dgvCursosActivos";
            this.dgvCursosActivos.ReadOnly = true;
            this.dgvCursosActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursosActivos.Size = new System.Drawing.Size(696, 260);
            this.dgvCursosActivos.TabIndex = 24;
            this.dgvCursosActivos.TabStop = false;
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
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(386, 324);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lblBusqueda.TabIndex = 41;
            this.lblBusqueda.Text = "label1";
            // 
            // gpConsultas
            // 
            this.gpConsultas.Controls.Add(this.rbNombre);
            this.gpConsultas.Controls.Add(this.rbTurno);
            this.gpConsultas.Controls.Add(this.rbAño);
            this.gpConsultas.Controls.Add(this.rbCodigo);
            this.gpConsultas.Controls.Add(this.rbTodos);
            this.gpConsultas.Location = new System.Drawing.Point(495, 278);
            this.gpConsultas.Name = "gpConsultas";
            this.gpConsultas.Size = new System.Drawing.Size(213, 87);
            this.gpConsultas.TabIndex = 39;
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
            // rbTurno
            // 
            this.rbTurno.AutoSize = true;
            this.rbTurno.Location = new System.Drawing.Point(97, 42);
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
            this.rbAño.Location = new System.Drawing.Point(97, 19);
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
            this.rbTodos.Text = "radioButton1";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // txtBoxBusqueda
            // 
            this.txtBoxBusqueda.Location = new System.Drawing.Point(389, 340);
            this.txtBoxBusqueda.Name = "txtBoxBusqueda";
            this.txtBoxBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBusqueda.TabIndex = 40;
            this.txtBoxBusqueda.TextChanged += new System.EventHandler(this.txtBoxBusqueda_TextChanged);
            // 
            // FormVerCursosEncuestasResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 387);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.gpConsultas);
            this.Controls.Add(this.txtBoxBusqueda);
            this.Controls.Add(this.btnVerEncuestasDeCurso);
            this.Controls.Add(this.dgvCursosActivos);
            this.Name = "FormVerCursosEncuestasResultado";
            this.Text = "FormVerCursosEncuestasResultado";
            this.Load += new System.EventHandler(this.FormVerCursosEncuestasResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosActivos)).EndInit();
            this.gpConsultas.ResumeLayout(false);
            this.gpConsultas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerEncuestasDeCurso;
        private System.Windows.Forms.DataGridView dgvCursosActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Turno;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.GroupBox gpConsultas;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbTurno;
        private System.Windows.Forms.RadioButton rbAño;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.TextBox txtBoxBusqueda;
    }
}