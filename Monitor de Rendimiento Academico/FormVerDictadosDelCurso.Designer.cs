
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerDictadosDelCurso
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
            this.lbDocentes = new System.Windows.Forms.ListBox();
            this.dgvDictados = new System.Windows.Forms.DataGridView();
            this.lblDocentesDictado = new System.Windows.Forms.Label();
            this.lblDictados = new System.Windows.Forms.Label();
            this.DGV_Dictados_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Dictados_Materia_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Dictados_Materia_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictados)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDocentes
            // 
            this.lbDocentes.FormattingEnabled = true;
            this.lbDocentes.Location = new System.Drawing.Point(720, 22);
            this.lbDocentes.Name = "lbDocentes";
            this.lbDocentes.Size = new System.Drawing.Size(120, 264);
            this.lbDocentes.TabIndex = 29;
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
            this.dgvDictados.Location = new System.Drawing.Point(9, 22);
            this.dgvDictados.MultiSelect = false;
            this.dgvDictados.Name = "dgvDictados";
            this.dgvDictados.ReadOnly = true;
            this.dgvDictados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDictados.Size = new System.Drawing.Size(705, 264);
            this.dgvDictados.TabIndex = 28;
            this.dgvDictados.TabStop = false;
            this.dgvDictados.Click += new System.EventHandler(this.dgvDictados_Click);
            // 
            // lblDocentesDictado
            // 
            this.lblDocentesDictado.AutoSize = true;
            this.lblDocentesDictado.Location = new System.Drawing.Point(722, 6);
            this.lblDocentesDictado.Name = "lblDocentesDictado";
            this.lblDocentesDictado.Size = new System.Drawing.Size(35, 13);
            this.lblDocentesDictado.TabIndex = 31;
            this.lblDocentesDictado.Text = "label1";
            // 
            // lblDictados
            // 
            this.lblDictados.AutoSize = true;
            this.lblDictados.Location = new System.Drawing.Point(332, 6);
            this.lblDictados.Name = "lblDictados";
            this.lblDictados.Size = new System.Drawing.Size(35, 13);
            this.lblDictados.TabIndex = 30;
            this.lblDictados.Text = "label1";
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
            // FormVerDictadosDelCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 315);
            this.Controls.Add(this.lblDocentesDictado);
            this.Controls.Add(this.lblDictados);
            this.Controls.Add(this.lbDocentes);
            this.Controls.Add(this.dgvDictados);
            this.Name = "FormVerDictadosDelCurso";
            this.Text = "FormVerDictadosDelCurso";
            this.Load += new System.EventHandler(this.FormVerDictadosDelCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDocentes;
        private System.Windows.Forms.DataGridView dgvDictados;
        private System.Windows.Forms.Label lblDocentesDictado;
        private System.Windows.Forms.Label lblDictados;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dictados_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dictados_Materia_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dictados_Materia_Nombre;
    }
}