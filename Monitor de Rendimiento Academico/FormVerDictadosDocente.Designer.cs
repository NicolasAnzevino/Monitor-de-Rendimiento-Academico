
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerDictadosDocente
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
            this.lblDocentesDictado = new System.Windows.Forms.Label();
            this.lblDictados = new System.Windows.Forms.Label();
            this.lbDocentes = new System.Windows.Forms.ListBox();
            this.dgvDictados = new System.Windows.Forms.DataGridView();
            this.DGV_Dictados_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Dictados_Materia_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Dictados_Materia_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerDictado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDocentesDictado
            // 
            this.lblDocentesDictado.AutoSize = true;
            this.lblDocentesDictado.Location = new System.Drawing.Point(725, 7);
            this.lblDocentesDictado.Name = "lblDocentesDictado";
            this.lblDocentesDictado.Size = new System.Drawing.Size(35, 13);
            this.lblDocentesDictado.TabIndex = 35;
            this.lblDocentesDictado.Text = "label1";
            // 
            // lblDictados
            // 
            this.lblDictados.AutoSize = true;
            this.lblDictados.Location = new System.Drawing.Point(335, 7);
            this.lblDictados.Name = "lblDictados";
            this.lblDictados.Size = new System.Drawing.Size(35, 13);
            this.lblDictados.TabIndex = 34;
            this.lblDictados.Text = "label1";
            // 
            // lbDocentes
            // 
            this.lbDocentes.FormattingEnabled = true;
            this.lbDocentes.Location = new System.Drawing.Point(723, 23);
            this.lbDocentes.Name = "lbDocentes";
            this.lbDocentes.Size = new System.Drawing.Size(120, 264);
            this.lbDocentes.TabIndex = 33;
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
            this.dgvDictados.Location = new System.Drawing.Point(12, 23);
            this.dgvDictados.MultiSelect = false;
            this.dgvDictados.Name = "dgvDictados";
            this.dgvDictados.ReadOnly = true;
            this.dgvDictados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDictados.Size = new System.Drawing.Size(705, 264);
            this.dgvDictados.TabIndex = 32;
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
            // btnVerDictado
            // 
            this.btnVerDictado.Location = new System.Drawing.Point(12, 293);
            this.btnVerDictado.Name = "btnVerDictado";
            this.btnVerDictado.Size = new System.Drawing.Size(92, 46);
            this.btnVerDictado.TabIndex = 36;
            this.btnVerDictado.Text = "button1";
            this.btnVerDictado.UseVisualStyleBackColor = true;
            this.btnVerDictado.Click += new System.EventHandler(this.btnVerDictado_Click);
            // 
            // FormVerDictadosDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 351);
            this.Controls.Add(this.btnVerDictado);
            this.Controls.Add(this.lblDocentesDictado);
            this.Controls.Add(this.lblDictados);
            this.Controls.Add(this.lbDocentes);
            this.Controls.Add(this.dgvDictados);
            this.Name = "FormVerDictadosDocente";
            this.Text = "FormVerDictadosDocente";
            this.Load += new System.EventHandler(this.FormVerDictadosDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDocentesDictado;
        private System.Windows.Forms.Label lblDictados;
        private System.Windows.Forms.ListBox lbDocentes;
        private System.Windows.Forms.DataGridView dgvDictados;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dictados_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dictados_Materia_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dictados_Materia_Nombre;
        private System.Windows.Forms.Button btnVerDictado;
    }
}