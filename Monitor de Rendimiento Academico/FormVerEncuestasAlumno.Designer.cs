
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerEncuestasAlumno
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
            this.btnRealizarEncuesta = new System.Windows.Forms.Button();
            this.dgvEncuestasActivas = new System.Windows.Forms.DataGridView();
            this.DGV_EncuestasActivas_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_EncuestasActivas_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncuestasActivas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRealizarEncuesta
            // 
            this.btnRealizarEncuesta.Location = new System.Drawing.Point(12, 278);
            this.btnRealizarEncuesta.Name = "btnRealizarEncuesta";
            this.btnRealizarEncuesta.Size = new System.Drawing.Size(94, 44);
            this.btnRealizarEncuesta.TabIndex = 36;
            this.btnRealizarEncuesta.Text = "button1";
            this.btnRealizarEncuesta.UseVisualStyleBackColor = true;
            this.btnRealizarEncuesta.Click += new System.EventHandler(this.btnRealizarEncuesta_Click);
            // 
            // dgvEncuestasActivas
            // 
            this.dgvEncuestasActivas.AllowUserToAddRows = false;
            this.dgvEncuestasActivas.AllowUserToDeleteRows = false;
            this.dgvEncuestasActivas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEncuestasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncuestasActivas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_EncuestasActivas_Codigo,
            this.DGV_EncuestasActivas_Fecha});
            this.dgvEncuestasActivas.Location = new System.Drawing.Point(12, 12);
            this.dgvEncuestasActivas.MultiSelect = false;
            this.dgvEncuestasActivas.Name = "dgvEncuestasActivas";
            this.dgvEncuestasActivas.ReadOnly = true;
            this.dgvEncuestasActivas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncuestasActivas.Size = new System.Drawing.Size(705, 260);
            this.dgvEncuestasActivas.TabIndex = 35;
            this.dgvEncuestasActivas.TabStop = false;
            // 
            // DGV_EncuestasActivas_Codigo
            // 
            this.DGV_EncuestasActivas_Codigo.HeaderText = "Column1";
            this.DGV_EncuestasActivas_Codigo.Name = "DGV_EncuestasActivas_Codigo";
            this.DGV_EncuestasActivas_Codigo.ReadOnly = true;
            // 
            // DGV_EncuestasActivas_Fecha
            // 
            this.DGV_EncuestasActivas_Fecha.HeaderText = "Column1";
            this.DGV_EncuestasActivas_Fecha.Name = "DGV_EncuestasActivas_Fecha";
            this.DGV_EncuestasActivas_Fecha.ReadOnly = true;
            // 
            // FormVerEncuestasAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 334);
            this.Controls.Add(this.btnRealizarEncuesta);
            this.Controls.Add(this.dgvEncuestasActivas);
            this.Name = "FormVerEncuestasAlumno";
            this.Text = "FormVerEncuestasAlumno";
            this.Load += new System.EventHandler(this.FormVerEncuestasAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncuestasActivas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRealizarEncuesta;
        private System.Windows.Forms.DataGridView dgvEncuestasActivas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_EncuestasActivas_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_EncuestasActivas_Fecha;
    }
}