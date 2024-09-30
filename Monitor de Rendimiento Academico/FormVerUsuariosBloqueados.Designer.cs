
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerUsuariosBloqueados
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
            this.dgvCuentasBloqueadas = new System.Windows.Forms.DataGridView();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.DGVCuentasBloqueadas_Col_Nombre_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVCuentasBloqueadas_Col_Nombre_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasBloqueadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCuentasBloqueadas
            // 
            this.dgvCuentasBloqueadas.AllowUserToAddRows = false;
            this.dgvCuentasBloqueadas.AllowUserToDeleteRows = false;
            this.dgvCuentasBloqueadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuentasBloqueadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentasBloqueadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVCuentasBloqueadas_Col_Nombre_Usuario,
            this.DGVCuentasBloqueadas_Col_Nombre_Rol});
            this.dgvCuentasBloqueadas.Location = new System.Drawing.Point(12, 13);
            this.dgvCuentasBloqueadas.MultiSelect = false;
            this.dgvCuentasBloqueadas.Name = "dgvCuentasBloqueadas";
            this.dgvCuentasBloqueadas.ReadOnly = true;
            this.dgvCuentasBloqueadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentasBloqueadas.Size = new System.Drawing.Size(501, 216);
            this.dgvCuentasBloqueadas.TabIndex = 0;
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Location = new System.Drawing.Point(12, 235);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(75, 39);
            this.btnDesbloquear.TabIndex = 1;
            this.btnDesbloquear.Text = "Desbloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // DGVCuentasBloqueadas_Col_Nombre_Usuario
            // 
            this.DGVCuentasBloqueadas_Col_Nombre_Usuario.HeaderText = "Columna1";
            this.DGVCuentasBloqueadas_Col_Nombre_Usuario.Name = "DGVCuentasBloqueadas_Col_Nombre_Usuario";
            this.DGVCuentasBloqueadas_Col_Nombre_Usuario.ReadOnly = true;
            // 
            // DGVCuentasBloqueadas_Col_Nombre_Rol
            // 
            this.DGVCuentasBloqueadas_Col_Nombre_Rol.HeaderText = "Columna2";
            this.DGVCuentasBloqueadas_Col_Nombre_Rol.Name = "DGVCuentasBloqueadas_Col_Nombre_Rol";
            this.DGVCuentasBloqueadas_Col_Nombre_Rol.ReadOnly = true;
            // 
            // FormVerUsuariosBloqueados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 296);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.dgvCuentasBloqueadas);
            this.Name = "FormVerUsuariosBloqueados";
            this.Text = "Cuentas Bloqueadas";
            this.Load += new System.EventHandler(this.FormVerUsuariosBloqueados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasBloqueadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCuentasBloqueadas;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVCuentasBloqueadas_Col_Nombre_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVCuentasBloqueadas_Col_Nombre_Rol;
    }
}