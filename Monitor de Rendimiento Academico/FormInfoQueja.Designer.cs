
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormInfoQueja
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
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcionQueja = new System.Windows.Forms.Label();
            this.txtBoxRespuesta = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblNombreReal = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.BackColor = System.Drawing.Color.White;
            this.txtBoxDescripcion.Location = new System.Drawing.Point(12, 25);
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.ReadOnly = true;
            this.txtBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDescripcion.Size = new System.Drawing.Size(476, 129);
            this.txtBoxDescripcion.TabIndex = 0;
            this.txtBoxDescripcion.TabStop = false;
            // 
            // lblDescripcionQueja
            // 
            this.lblDescripcionQueja.AutoSize = true;
            this.lblDescripcionQueja.Location = new System.Drawing.Point(12, 9);
            this.lblDescripcionQueja.Name = "lblDescripcionQueja";
            this.lblDescripcionQueja.Size = new System.Drawing.Size(35, 13);
            this.lblDescripcionQueja.TabIndex = 1;
            this.lblDescripcionQueja.Text = "label1";
            // 
            // txtBoxRespuesta
            // 
            this.txtBoxRespuesta.Location = new System.Drawing.Point(12, 199);
            this.txtBoxRespuesta.MaxLength = 150;
            this.txtBoxRespuesta.Multiline = true;
            this.txtBoxRespuesta.Name = "txtBoxRespuesta";
            this.txtBoxRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxRespuesta.Size = new System.Drawing.Size(476, 129);
            this.txtBoxRespuesta.TabIndex = 3;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(494, 268);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(139, 56);
            this.buttonEnviar.TabIndex = 4;
            this.buttonEnviar.Text = "button1";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(12, 183);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(35, 13);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "label2";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(494, 26);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 13);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "label3";
            // 
            // lblNombreReal
            // 
            this.lblNombreReal.AutoSize = true;
            this.lblNombreReal.Location = new System.Drawing.Point(494, 49);
            this.lblNombreReal.Name = "lblNombreReal";
            this.lblNombreReal.Size = new System.Drawing.Size(35, 13);
            this.lblNombreReal.TabIndex = 7;
            this.lblNombreReal.Text = "label4";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(494, 71);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(35, 13);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "label5";
            // 
            // FormInfoQueja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 336);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombreReal);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.txtBoxRespuesta);
            this.Controls.Add(this.lblDescripcionQueja);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Name = "FormInfoQueja";
            this.Text = "FormInfoQueja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInfoQueja_FormClosed);
            this.Load += new System.EventHandler(this.FormInfoQueja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Label lblDescripcionQueja;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombreReal;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtBoxRespuesta;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Label lblRespuesta;
    }
}