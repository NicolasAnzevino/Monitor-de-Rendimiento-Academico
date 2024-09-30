
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormAtenderQueja
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
            this.dgvQuejasActivas = new System.Windows.Forms.DataGridView();
            this.btnAtenderQueja = new System.Windows.Forms.Button();
            this.DGV_QuejasActivas_Col_Codigo_Queja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_QuejasActivas_Col_Queja_Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_QuejasActivas_Col_Usuario_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_QuejasActivas_Col_Fecha_Queja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuejasActivas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuejasActivas
            // 
            this.dgvQuejasActivas.AllowUserToAddRows = false;
            this.dgvQuejasActivas.AllowUserToDeleteRows = false;
            this.dgvQuejasActivas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuejasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuejasActivas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_QuejasActivas_Col_Codigo_Queja,
            this.DGV_QuejasActivas_Col_Queja_Asunto,
            this.DGV_QuejasActivas_Col_Usuario_Nombre,
            this.DGV_QuejasActivas_Col_Fecha_Queja});
            this.dgvQuejasActivas.Location = new System.Drawing.Point(12, 12);
            this.dgvQuejasActivas.MultiSelect = false;
            this.dgvQuejasActivas.Name = "dgvQuejasActivas";
            this.dgvQuejasActivas.ReadOnly = true;
            this.dgvQuejasActivas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuejasActivas.Size = new System.Drawing.Size(648, 227);
            this.dgvQuejasActivas.TabIndex = 0;
            this.dgvQuejasActivas.TabStop = false;
            // 
            // btnAtenderQueja
            // 
            this.btnAtenderQueja.Location = new System.Drawing.Point(12, 245);
            this.btnAtenderQueja.Name = "btnAtenderQueja";
            this.btnAtenderQueja.Size = new System.Drawing.Size(101, 45);
            this.btnAtenderQueja.TabIndex = 1;
            this.btnAtenderQueja.Text = "Atender Queja";
            this.btnAtenderQueja.UseVisualStyleBackColor = true;
            this.btnAtenderQueja.Click += new System.EventHandler(this.btnAtenderQueja_Click);
            // 
            // DGV_QuejasActivas_Col_Codigo_Queja
            // 
            this.DGV_QuejasActivas_Col_Codigo_Queja.HeaderText = "Columna3";
            this.DGV_QuejasActivas_Col_Codigo_Queja.Name = "DGV_QuejasActivas_Col_Codigo_Queja";
            this.DGV_QuejasActivas_Col_Codigo_Queja.ReadOnly = true;
            // 
            // DGV_QuejasActivas_Col_Queja_Asunto
            // 
            this.DGV_QuejasActivas_Col_Queja_Asunto.HeaderText = "Columna1";
            this.DGV_QuejasActivas_Col_Queja_Asunto.Name = "DGV_QuejasActivas_Col_Queja_Asunto";
            this.DGV_QuejasActivas_Col_Queja_Asunto.ReadOnly = true;
            // 
            // DGV_QuejasActivas_Col_Usuario_Nombre
            // 
            this.DGV_QuejasActivas_Col_Usuario_Nombre.HeaderText = "Columna2";
            this.DGV_QuejasActivas_Col_Usuario_Nombre.Name = "DGV_QuejasActivas_Col_Usuario_Nombre";
            this.DGV_QuejasActivas_Col_Usuario_Nombre.ReadOnly = true;
            // 
            // DGV_QuejasActivas_Col_Fecha_Queja
            // 
            this.DGV_QuejasActivas_Col_Fecha_Queja.HeaderText = "Columna4";
            this.DGV_QuejasActivas_Col_Fecha_Queja.Name = "DGV_QuejasActivas_Col_Fecha_Queja";
            this.DGV_QuejasActivas_Col_Fecha_Queja.ReadOnly = true;
            // 
            // FormAtenderQueja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 307);
            this.Controls.Add(this.btnAtenderQueja);
            this.Controls.Add(this.dgvQuejasActivas);
            this.Name = "FormAtenderQueja";
            this.Text = "FormAtenderQueja";
            this.Load += new System.EventHandler(this.FormAtenderQueja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuejasActivas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuejasActivas;
        private System.Windows.Forms.Button btnAtenderQueja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_QuejasActivas_Col_Codigo_Queja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_QuejasActivas_Col_Queja_Asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_QuejasActivas_Col_Usuario_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_QuejasActivas_Col_Fecha_Queja;
    }
}