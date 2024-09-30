
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormRealizarQueja
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
            this.txtBoxAsunto = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblAsuntoQueja = new System.Windows.Forms.Label();
            this.lblDescripcionQueja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxAsunto
            // 
            this.txtBoxAsunto.Location = new System.Drawing.Point(12, 27);
            this.txtBoxAsunto.MaxLength = 50;
            this.txtBoxAsunto.Name = "txtBoxAsunto";
            this.txtBoxAsunto.Size = new System.Drawing.Size(384, 20);
            this.txtBoxAsunto.TabIndex = 0;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(12, 83);
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(384, 156);
            this.txtBoxDescripcion.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(403, 206);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 33);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblAsuntoQueja
            // 
            this.lblAsuntoQueja.AutoSize = true;
            this.lblAsuntoQueja.Location = new System.Drawing.Point(12, 8);
            this.lblAsuntoQueja.Name = "lblAsuntoQueja";
            this.lblAsuntoQueja.Size = new System.Drawing.Size(43, 13);
            this.lblAsuntoQueja.TabIndex = 3;
            this.lblAsuntoQueja.Text = "Asunto:";
            // 
            // lblDescripcionQueja
            // 
            this.lblDescripcionQueja.AutoSize = true;
            this.lblDescripcionQueja.Location = new System.Drawing.Point(12, 67);
            this.lblDescripcionQueja.Name = "lblDescripcionQueja";
            this.lblDescripcionQueja.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionQueja.TabIndex = 4;
            this.lblDescripcionQueja.Text = "Descripción:";
            // 
            // FormRealizarQueja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 249);
            this.Controls.Add(this.lblDescripcionQueja);
            this.Controls.Add(this.lblAsuntoQueja);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.txtBoxAsunto);
            this.Name = "FormRealizarQueja";
            this.Text = "FormRealizarQueja";
            this.Load += new System.EventHandler(this.FormRealizarQueja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxAsunto;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblAsuntoQueja;
        private System.Windows.Forms.Label lblDescripcionQueja;
    }
}