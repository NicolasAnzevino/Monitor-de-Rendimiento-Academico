
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerQuejasUsuario
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
            this.btnVerInfoQueja = new System.Windows.Forms.Button();
            this.dgvQuejasUsuario = new System.Windows.Forms.DataGridView();
            this.DGV_QuejasUsuario_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_QuejasUsuario_Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_QuejasUsuario_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_QuejasUsuario_Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuejasUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerInfoQueja
            // 
            this.btnVerInfoQueja.Location = new System.Drawing.Point(12, 247);
            this.btnVerInfoQueja.Name = "btnVerInfoQueja";
            this.btnVerInfoQueja.Size = new System.Drawing.Size(101, 45);
            this.btnVerInfoQueja.TabIndex = 3;
            this.btnVerInfoQueja.Text = "Ver Queja";
            this.btnVerInfoQueja.UseVisualStyleBackColor = true;
            this.btnVerInfoQueja.Click += new System.EventHandler(this.btnVerInfoQueja_Click);
            // 
            // dgvQuejasUsuario
            // 
            this.dgvQuejasUsuario.AllowUserToAddRows = false;
            this.dgvQuejasUsuario.AllowUserToDeleteRows = false;
            this.dgvQuejasUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuejasUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuejasUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_QuejasUsuario_Codigo,
            this.DGV_QuejasUsuario_Asunto,
            this.DGV_QuejasUsuario_Fecha,
            this.DGV_QuejasUsuario_Activo});
            this.dgvQuejasUsuario.Location = new System.Drawing.Point(12, 14);
            this.dgvQuejasUsuario.MultiSelect = false;
            this.dgvQuejasUsuario.Name = "dgvQuejasUsuario";
            this.dgvQuejasUsuario.ReadOnly = true;
            this.dgvQuejasUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuejasUsuario.Size = new System.Drawing.Size(648, 227);
            this.dgvQuejasUsuario.TabIndex = 2;
            this.dgvQuejasUsuario.TabStop = false;
            // 
            // DGV_QuejasUsuario_Codigo
            // 
            this.DGV_QuejasUsuario_Codigo.HeaderText = "Columna0";
            this.DGV_QuejasUsuario_Codigo.Name = "DGV_QuejasUsuario_Codigo";
            this.DGV_QuejasUsuario_Codigo.ReadOnly = true;
            // 
            // DGV_QuejasUsuario_Asunto
            // 
            this.DGV_QuejasUsuario_Asunto.HeaderText = "Columna1";
            this.DGV_QuejasUsuario_Asunto.Name = "DGV_QuejasUsuario_Asunto";
            this.DGV_QuejasUsuario_Asunto.ReadOnly = true;
            // 
            // DGV_QuejasUsuario_Fecha
            // 
            this.DGV_QuejasUsuario_Fecha.HeaderText = "Columna3";
            this.DGV_QuejasUsuario_Fecha.Name = "DGV_QuejasUsuario_Fecha";
            this.DGV_QuejasUsuario_Fecha.ReadOnly = true;
            // 
            // DGV_QuejasUsuario_Activo
            // 
            this.DGV_QuejasUsuario_Activo.HeaderText = "Activo";
            this.DGV_QuejasUsuario_Activo.Name = "DGV_QuejasUsuario_Activo";
            this.DGV_QuejasUsuario_Activo.ReadOnly = true;
            // 
            // FormVerQuejasUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 307);
            this.Controls.Add(this.btnVerInfoQueja);
            this.Controls.Add(this.dgvQuejasUsuario);
            this.Name = "FormVerQuejasUsuario";
            this.Text = "FormVerQuejasUsuario";
            this.Load += new System.EventHandler(this.FormVerQuejasUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuejasUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerInfoQueja;
        private System.Windows.Forms.DataGridView dgvQuejasUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_QuejasUsuario_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_QuejasUsuario_Asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_QuejasUsuario_Fecha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_QuejasUsuario_Activo;
    }
}