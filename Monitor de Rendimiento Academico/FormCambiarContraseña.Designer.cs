
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormCambiarContraseña
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
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtBoxPassword1 = new System.Windows.Forms.TextBox();
            this.txtBoxPassword2 = new System.Windows.Forms.TextBox();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.lblContraseñasIncorrectas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(12, 12);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(35, 13);
            this.lblContraseña.TabIndex = 0;
            this.lblContraseña.Text = "label1";
            // 
            // txtBoxPassword1
            // 
            this.txtBoxPassword1.Location = new System.Drawing.Point(12, 28);
            this.txtBoxPassword1.MaxLength = 50;
            this.txtBoxPassword1.Name = "txtBoxPassword1";
            this.txtBoxPassword1.Size = new System.Drawing.Size(143, 20);
            this.txtBoxPassword1.TabIndex = 1;
            this.txtBoxPassword1.UseSystemPasswordChar = true;
            this.txtBoxPassword1.TextChanged += new System.EventHandler(this.txtBoxPassword1_TextChanged);
            // 
            // txtBoxPassword2
            // 
            this.txtBoxPassword2.Location = new System.Drawing.Point(12, 83);
            this.txtBoxPassword2.MaxLength = 50;
            this.txtBoxPassword2.Name = "txtBoxPassword2";
            this.txtBoxPassword2.Size = new System.Drawing.Size(143, 20);
            this.txtBoxPassword2.TabIndex = 3;
            this.txtBoxPassword2.UseSystemPasswordChar = true;
            this.txtBoxPassword2.TextChanged += new System.EventHandler(this.txtBoxPassword2_TextChanged);
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(12, 67);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(35, 13);
            this.lblConfirmarContraseña.TabIndex = 2;
            this.lblConfirmarContraseña.Text = "label2";
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Enabled = false;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(184, 121);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(90, 48);
            this.btnCambiarContraseña.TabIndex = 4;
            this.btnCambiarContraseña.Text = "button1";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // lblContraseñasIncorrectas
            // 
            this.lblContraseñasIncorrectas.AutoSize = true;
            this.lblContraseñasIncorrectas.Location = new System.Drawing.Point(9, 156);
            this.lblContraseñasIncorrectas.Name = "lblContraseñasIncorrectas";
            this.lblContraseñasIncorrectas.Size = new System.Drawing.Size(35, 13);
            this.lblContraseñasIncorrectas.TabIndex = 5;
            this.lblContraseñasIncorrectas.Text = "label1";
            // 
            // FormCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 181);
            this.Controls.Add(this.lblContraseñasIncorrectas);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.txtBoxPassword2);
            this.Controls.Add(this.lblConfirmarContraseña);
            this.Controls.Add(this.txtBoxPassword1);
            this.Controls.Add(this.lblContraseña);
            this.Name = "FormCambiarContraseña";
            this.Text = "FormCambiarContraseña";
            this.Load += new System.EventHandler(this.FormCambiarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtBoxPassword1;
        private System.Windows.Forms.TextBox txtBoxPassword2;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Label lblContraseñasIncorrectas;
    }
}