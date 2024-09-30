
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerCursosCompararRendimiento
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
            this.btnVerAlumnosDelCurso = new System.Windows.Forms.Button();
            this.dgvCursosActivos = new System.Windows.Forms.DataGridView();
            this.DGV_CursosActivos_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_CursosActivos_Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerAlumnosDelCurso
            // 
            this.btnVerAlumnosDelCurso.Location = new System.Drawing.Point(12, 278);
            this.btnVerAlumnosDelCurso.Name = "btnVerAlumnosDelCurso";
            this.btnVerAlumnosDelCurso.Size = new System.Drawing.Size(86, 42);
            this.btnVerAlumnosDelCurso.TabIndex = 27;
            this.btnVerAlumnosDelCurso.Text = "button1";
            this.btnVerAlumnosDelCurso.UseVisualStyleBackColor = true;
            this.btnVerAlumnosDelCurso.Click += new System.EventHandler(this.btnVerAlumnosDelCurso_Click);
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
            this.dgvCursosActivos.TabIndex = 26;
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
            // FormVerCursosCompararRendimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 331);
            this.Controls.Add(this.btnVerAlumnosDelCurso);
            this.Controls.Add(this.dgvCursosActivos);
            this.Name = "FormVerCursosCompararRendimiento";
            this.Text = "FormVerCursosCompararRendimiento";
            this.Load += new System.EventHandler(this.FormVerCursosCompararRendimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosActivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerAlumnosDelCurso;
        private System.Windows.Forms.DataGridView dgvCursosActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_CursosActivos_Turno;
    }
}