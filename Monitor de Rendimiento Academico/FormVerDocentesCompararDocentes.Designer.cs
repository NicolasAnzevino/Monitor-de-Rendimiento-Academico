
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerDocentesCompararDocentes
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
            this.dgvDocentesActivos = new System.Windows.Forms.DataGridView();
            this.DGV_DocentesActivos_Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_DocentesActivos_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_DocentesActivos_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_DocentesActivos_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCompararDocentes = new System.Windows.Forms.Button();
            this.btnDeseleccionarDocentes = new System.Windows.Forms.Button();
            this.lblDocente2 = new System.Windows.Forms.Label();
            this.txtBoxDocente2 = new System.Windows.Forms.TextBox();
            this.txtBoxDocente1 = new System.Windows.Forms.TextBox();
            this.btnSeleccionarDocente = new System.Windows.Forms.Button();
            this.lblDocente1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentesActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocentesActivos
            // 
            this.dgvDocentesActivos.AllowUserToAddRows = false;
            this.dgvDocentesActivos.AllowUserToDeleteRows = false;
            this.dgvDocentesActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocentesActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentesActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_DocentesActivos_Legajo,
            this.DGV_DocentesActivos_DNI,
            this.DGV_DocentesActivos_Apellido,
            this.DGV_DocentesActivos_Nombre});
            this.dgvDocentesActivos.Location = new System.Drawing.Point(12, 12);
            this.dgvDocentesActivos.MultiSelect = false;
            this.dgvDocentesActivos.Name = "dgvDocentesActivos";
            this.dgvDocentesActivos.ReadOnly = true;
            this.dgvDocentesActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentesActivos.Size = new System.Drawing.Size(705, 260);
            this.dgvDocentesActivos.TabIndex = 34;
            this.dgvDocentesActivos.TabStop = false;
            // 
            // DGV_DocentesActivos_Legajo
            // 
            this.DGV_DocentesActivos_Legajo.HeaderText = "Column1";
            this.DGV_DocentesActivos_Legajo.Name = "DGV_DocentesActivos_Legajo";
            this.DGV_DocentesActivos_Legajo.ReadOnly = true;
            // 
            // DGV_DocentesActivos_DNI
            // 
            this.DGV_DocentesActivos_DNI.HeaderText = "Column1";
            this.DGV_DocentesActivos_DNI.Name = "DGV_DocentesActivos_DNI";
            this.DGV_DocentesActivos_DNI.ReadOnly = true;
            // 
            // DGV_DocentesActivos_Apellido
            // 
            this.DGV_DocentesActivos_Apellido.HeaderText = "Column1";
            this.DGV_DocentesActivos_Apellido.Name = "DGV_DocentesActivos_Apellido";
            this.DGV_DocentesActivos_Apellido.ReadOnly = true;
            // 
            // DGV_DocentesActivos_Nombre
            // 
            this.DGV_DocentesActivos_Nombre.HeaderText = "Column1";
            this.DGV_DocentesActivos_Nombre.Name = "DGV_DocentesActivos_Nombre";
            this.DGV_DocentesActivos_Nombre.ReadOnly = true;
            // 
            // btnCompararDocentes
            // 
            this.btnCompararDocentes.Location = new System.Drawing.Point(369, 278);
            this.btnCompararDocentes.Name = "btnCompararDocentes";
            this.btnCompararDocentes.Size = new System.Drawing.Size(97, 48);
            this.btnCompararDocentes.TabIndex = 40;
            this.btnCompararDocentes.Text = "button3";
            this.btnCompararDocentes.UseVisualStyleBackColor = true;
            this.btnCompararDocentes.Click += new System.EventHandler(this.btnCompararDocentes_Click);
            // 
            // btnDeseleccionarDocentes
            // 
            this.btnDeseleccionarDocentes.Location = new System.Drawing.Point(266, 278);
            this.btnDeseleccionarDocentes.Name = "btnDeseleccionarDocentes";
            this.btnDeseleccionarDocentes.Size = new System.Drawing.Size(97, 48);
            this.btnDeseleccionarDocentes.TabIndex = 39;
            this.btnDeseleccionarDocentes.Text = "button2";
            this.btnDeseleccionarDocentes.UseVisualStyleBackColor = true;
            this.btnDeseleccionarDocentes.Click += new System.EventHandler(this.btnDeseleccionarDocentes_Click);
            // 
            // lblDocente2
            // 
            this.lblDocente2.AutoSize = true;
            this.lblDocente2.Location = new System.Drawing.Point(112, 329);
            this.lblDocente2.Name = "lblDocente2";
            this.lblDocente2.Size = new System.Drawing.Size(35, 13);
            this.lblDocente2.TabIndex = 38;
            this.lblDocente2.Text = "label2";
            // 
            // txtBoxDocente2
            // 
            this.txtBoxDocente2.BackColor = System.Drawing.Color.White;
            this.txtBoxDocente2.Location = new System.Drawing.Point(115, 345);
            this.txtBoxDocente2.Name = "txtBoxDocente2";
            this.txtBoxDocente2.ReadOnly = true;
            this.txtBoxDocente2.Size = new System.Drawing.Size(145, 20);
            this.txtBoxDocente2.TabIndex = 37;
            // 
            // txtBoxDocente1
            // 
            this.txtBoxDocente1.BackColor = System.Drawing.Color.White;
            this.txtBoxDocente1.Location = new System.Drawing.Point(115, 299);
            this.txtBoxDocente1.Name = "txtBoxDocente1";
            this.txtBoxDocente1.ReadOnly = true;
            this.txtBoxDocente1.Size = new System.Drawing.Size(145, 20);
            this.txtBoxDocente1.TabIndex = 36;
            // 
            // btnSeleccionarDocente
            // 
            this.btnSeleccionarDocente.Location = new System.Drawing.Point(12, 278);
            this.btnSeleccionarDocente.Name = "btnSeleccionarDocente";
            this.btnSeleccionarDocente.Size = new System.Drawing.Size(97, 48);
            this.btnSeleccionarDocente.TabIndex = 35;
            this.btnSeleccionarDocente.Text = "button1";
            this.btnSeleccionarDocente.UseVisualStyleBackColor = true;
            this.btnSeleccionarDocente.Click += new System.EventHandler(this.btnSeleccionarDocente_Click);
            // 
            // lblDocente1
            // 
            this.lblDocente1.AutoSize = true;
            this.lblDocente1.Location = new System.Drawing.Point(115, 283);
            this.lblDocente1.Name = "lblDocente1";
            this.lblDocente1.Size = new System.Drawing.Size(35, 13);
            this.lblDocente1.TabIndex = 41;
            this.lblDocente1.Text = "label2";
            // 
            // FormVerDocentesCompararDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 383);
            this.Controls.Add(this.lblDocente1);
            this.Controls.Add(this.btnCompararDocentes);
            this.Controls.Add(this.btnDeseleccionarDocentes);
            this.Controls.Add(this.lblDocente2);
            this.Controls.Add(this.txtBoxDocente2);
            this.Controls.Add(this.txtBoxDocente1);
            this.Controls.Add(this.btnSeleccionarDocente);
            this.Controls.Add(this.dgvDocentesActivos);
            this.Name = "FormVerDocentesCompararDocentes";
            this.Text = "FormVerDocentesCompararDocentes";
            this.Load += new System.EventHandler(this.FormVerDocentesCompararDocentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentesActivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocentesActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_DocentesActivos_Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_DocentesActivos_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_DocentesActivos_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_DocentesActivos_Nombre;
        private System.Windows.Forms.Button btnCompararDocentes;
        private System.Windows.Forms.Button btnDeseleccionarDocentes;
        private System.Windows.Forms.Label lblDocente2;
        private System.Windows.Forms.TextBox txtBoxDocente2;
        private System.Windows.Forms.TextBox txtBoxDocente1;
        private System.Windows.Forms.Button btnSeleccionarDocente;
        private System.Windows.Forms.Label lblDocente1;
    }
}