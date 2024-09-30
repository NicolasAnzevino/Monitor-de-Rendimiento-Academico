
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormSelectorServidor
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.txtBoxNombreServidor = new System.Windows.Forms.TextBox();
            this.dgvServidoresDetectados = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarServidor = new System.Windows.Forms.Button();
            this.lblServidoresDetectados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServidoresDetectados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(8, 33);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(237, 13);
            this.lblDescripcion.TabIndex = 17;
            this.lblDescripcion.Text = "Por favor, ingrese el nombre del Servidor de SQL";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(7, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(105, 24);
            this.lblBienvenido.TabIndex = 16;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // txtBoxNombreServidor
            // 
            this.txtBoxNombreServidor.Location = new System.Drawing.Point(12, 304);
            this.txtBoxNombreServidor.MaxLength = 175;
            this.txtBoxNombreServidor.Name = "txtBoxNombreServidor";
            this.txtBoxNombreServidor.Size = new System.Drawing.Size(131, 20);
            this.txtBoxNombreServidor.TabIndex = 18;
            // 
            // dgvServidoresDetectados
            // 
            this.dgvServidoresDetectados.AllowUserToAddRows = false;
            this.dgvServidoresDetectados.AllowUserToDeleteRows = false;
            this.dgvServidoresDetectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServidoresDetectados.Location = new System.Drawing.Point(12, 79);
            this.dgvServidoresDetectados.Name = "dgvServidoresDetectados";
            this.dgvServidoresDetectados.ReadOnly = true;
            this.dgvServidoresDetectados.Size = new System.Drawing.Size(315, 210);
            this.dgvServidoresDetectados.TabIndex = 19;
            // 
            // btnSeleccionarServidor
            // 
            this.btnSeleccionarServidor.Location = new System.Drawing.Point(149, 304);
            this.btnSeleccionarServidor.Name = "btnSeleccionarServidor";
            this.btnSeleccionarServidor.Size = new System.Drawing.Size(85, 20);
            this.btnSeleccionarServidor.TabIndex = 20;
            this.btnSeleccionarServidor.Text = "Seleccionar";
            this.btnSeleccionarServidor.UseVisualStyleBackColor = true;
            this.btnSeleccionarServidor.Click += new System.EventHandler(this.btnSeleccionarServidor_Click);
            // 
            // lblServidoresDetectados
            // 
            this.lblServidoresDetectados.AutoSize = true;
            this.lblServidoresDetectados.Location = new System.Drawing.Point(115, 63);
            this.lblServidoresDetectados.Name = "lblServidoresDetectados";
            this.lblServidoresDetectados.Size = new System.Drawing.Size(115, 13);
            this.lblServidoresDetectados.TabIndex = 21;
            this.lblServidoresDetectados.Text = "Servidores Detectados";
            // 
            // FormSelectorServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 340);
            this.Controls.Add(this.lblServidoresDetectados);
            this.Controls.Add(this.btnSeleccionarServidor);
            this.Controls.Add(this.dgvServidoresDetectados);
            this.Controls.Add(this.txtBoxNombreServidor);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblBienvenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSelectorServidor";
            this.Text = "Monitor de Rendimiento Academico - Seleccionar Servidor";
            this.Load += new System.EventHandler(this.FormSelectorServidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServidoresDetectados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.TextBox txtBoxNombreServidor;
        private System.Windows.Forms.DataGridView dgvServidoresDetectados;
        private System.Windows.Forms.Button btnSeleccionarServidor;
        private System.Windows.Forms.Label lblServidoresDetectados;
    }
}