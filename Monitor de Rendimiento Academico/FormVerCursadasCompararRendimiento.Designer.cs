
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerCursadasCompararRendimiento
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
            this.DGV_CursadasAlumno_Cur_Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSeleccionarCursada = new System.Windows.Forms.Button();
            this.txtBoxCursada1 = new System.Windows.Forms.TextBox();
            this.lblCursada1 = new System.Windows.Forms.Label();
            this.lblCursada2 = new System.Windows.Forms.Label();
            this.txtBoxCursada2 = new System.Windows.Forms.TextBox();
            this.btnDeseleccionarCursadas = new System.Windows.Forms.Button();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.txtBoxAlumno = new System.Windows.Forms.TextBox();
            this.btnCompararCursadas = new System.Windows.Forms.Button();
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
            this.DGV_CursadasAlumno_Cur_Activo});
            this.dgvCursadasAlumno.Location = new System.Drawing.Point(12, 12);
            this.dgvCursadasAlumno.MultiSelect = false;
            this.dgvCursadasAlumno.Name = "dgvCursadasAlumno";
            this.dgvCursadasAlumno.ReadOnly = true;
            this.dgvCursadasAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursadasAlumno.Size = new System.Drawing.Size(648, 227);
            this.dgvCursadasAlumno.TabIndex = 3;
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
            // DGV_CursadasAlumno_Cur_Activo
            // 
            this.DGV_CursadasAlumno_Cur_Activo.HeaderText = "Column1";
            this.DGV_CursadasAlumno_Cur_Activo.Name = "DGV_CursadasAlumno_Cur_Activo";
            this.DGV_CursadasAlumno_Cur_Activo.ReadOnly = true;
            this.DGV_CursadasAlumno_Cur_Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_CursadasAlumno_Cur_Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnSeleccionarCursada
            // 
            this.btnSeleccionarCursada.Location = new System.Drawing.Point(12, 241);
            this.btnSeleccionarCursada.Name = "btnSeleccionarCursada";
            this.btnSeleccionarCursada.Size = new System.Drawing.Size(97, 48);
            this.btnSeleccionarCursada.TabIndex = 4;
            this.btnSeleccionarCursada.Text = "button1";
            this.btnSeleccionarCursada.UseVisualStyleBackColor = true;
            this.btnSeleccionarCursada.Click += new System.EventHandler(this.btnSeleccionarCursada_Click);
            // 
            // txtBoxCursada1
            // 
            this.txtBoxCursada1.BackColor = System.Drawing.Color.White;
            this.txtBoxCursada1.Location = new System.Drawing.Point(115, 262);
            this.txtBoxCursada1.Name = "txtBoxCursada1";
            this.txtBoxCursada1.ReadOnly = true;
            this.txtBoxCursada1.Size = new System.Drawing.Size(145, 20);
            this.txtBoxCursada1.TabIndex = 5;
            // 
            // lblCursada1
            // 
            this.lblCursada1.AutoSize = true;
            this.lblCursada1.Location = new System.Drawing.Point(112, 246);
            this.lblCursada1.Name = "lblCursada1";
            this.lblCursada1.Size = new System.Drawing.Size(35, 13);
            this.lblCursada1.TabIndex = 6;
            this.lblCursada1.Text = "label1";
            // 
            // lblCursada2
            // 
            this.lblCursada2.AutoSize = true;
            this.lblCursada2.Location = new System.Drawing.Point(112, 292);
            this.lblCursada2.Name = "lblCursada2";
            this.lblCursada2.Size = new System.Drawing.Size(35, 13);
            this.lblCursada2.TabIndex = 8;
            this.lblCursada2.Text = "label2";
            // 
            // txtBoxCursada2
            // 
            this.txtBoxCursada2.BackColor = System.Drawing.Color.White;
            this.txtBoxCursada2.Location = new System.Drawing.Point(115, 308);
            this.txtBoxCursada2.Name = "txtBoxCursada2";
            this.txtBoxCursada2.ReadOnly = true;
            this.txtBoxCursada2.Size = new System.Drawing.Size(145, 20);
            this.txtBoxCursada2.TabIndex = 7;
            // 
            // btnDeseleccionarCursadas
            // 
            this.btnDeseleccionarCursadas.Location = new System.Drawing.Point(266, 241);
            this.btnDeseleccionarCursadas.Name = "btnDeseleccionarCursadas";
            this.btnDeseleccionarCursadas.Size = new System.Drawing.Size(97, 48);
            this.btnDeseleccionarCursadas.TabIndex = 9;
            this.btnDeseleccionarCursadas.Text = "button2";
            this.btnDeseleccionarCursadas.UseVisualStyleBackColor = true;
            this.btnDeseleccionarCursadas.Click += new System.EventHandler(this.btnDeseleccionarCursadas_Click);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(520, 246);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(35, 13);
            this.lblAlumno.TabIndex = 11;
            this.lblAlumno.Text = "label3";
            // 
            // txtBoxAlumno
            // 
            this.txtBoxAlumno.BackColor = System.Drawing.Color.White;
            this.txtBoxAlumno.Location = new System.Drawing.Point(523, 262);
            this.txtBoxAlumno.Name = "txtBoxAlumno";
            this.txtBoxAlumno.ReadOnly = true;
            this.txtBoxAlumno.Size = new System.Drawing.Size(137, 20);
            this.txtBoxAlumno.TabIndex = 10;
            // 
            // btnCompararCursadas
            // 
            this.btnCompararCursadas.Location = new System.Drawing.Point(369, 241);
            this.btnCompararCursadas.Name = "btnCompararCursadas";
            this.btnCompararCursadas.Size = new System.Drawing.Size(97, 48);
            this.btnCompararCursadas.TabIndex = 12;
            this.btnCompararCursadas.Text = "button3";
            this.btnCompararCursadas.UseVisualStyleBackColor = true;
            this.btnCompararCursadas.Click += new System.EventHandler(this.btnCompararCursadas_Click);
            // 
            // FormVerCursadasCompararRendimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 337);
            this.Controls.Add(this.btnCompararCursadas);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.txtBoxAlumno);
            this.Controls.Add(this.btnDeseleccionarCursadas);
            this.Controls.Add(this.lblCursada2);
            this.Controls.Add(this.txtBoxCursada2);
            this.Controls.Add(this.lblCursada1);
            this.Controls.Add(this.txtBoxCursada1);
            this.Controls.Add(this.btnSeleccionarCursada);
            this.Controls.Add(this.dgvCursadasAlumno);
            this.Name = "FormVerCursadasCompararRendimiento";
            this.Text = "FormVerCursadasCompararRendimiento";
            this.Load += new System.EventHandler(this.FormVerCursadasCompararRendimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursadasAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursadasAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursadasAlumno_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursadasAlumno_Cur_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursadasAlumno_Cur_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursadasAlumno_Cur_Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursadasAlumno_Cur_Turno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_CursadasAlumno_Cur_Activo;
        private System.Windows.Forms.Button btnSeleccionarCursada;
        private System.Windows.Forms.TextBox txtBoxCursada1;
        private System.Windows.Forms.Label lblCursada1;
        private System.Windows.Forms.Label lblCursada2;
        private System.Windows.Forms.TextBox txtBoxCursada2;
        private System.Windows.Forms.Button btnDeseleccionarCursadas;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.TextBox txtBoxAlumno;
        private System.Windows.Forms.Button btnCompararCursadas;
    }
}