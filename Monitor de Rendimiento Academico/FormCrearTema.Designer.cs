
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormCrearTema
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
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.btnCrearTema = new System.Windows.Forms.Button();
            this.lblNombreTema = new System.Windows.Forms.Label();
            this.lblDescripcionTema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(12, 33);
            this.txtBoxNombre.MaxLength = 50;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 0;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(12, 100);
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDescripcion.Size = new System.Drawing.Size(199, 72);
            this.txtBoxDescripcion.TabIndex = 1;
            // 
            // btnCrearTema
            // 
            this.btnCrearTema.Location = new System.Drawing.Point(196, 22);
            this.btnCrearTema.Name = "btnCrearTema";
            this.btnCrearTema.Size = new System.Drawing.Size(86, 41);
            this.btnCrearTema.TabIndex = 2;
            this.btnCrearTema.Text = "button1";
            this.btnCrearTema.UseVisualStyleBackColor = true;
            this.btnCrearTema.Click += new System.EventHandler(this.btnCrearTema_Click);
            // 
            // lblNombreTema
            // 
            this.lblNombreTema.AutoSize = true;
            this.lblNombreTema.Location = new System.Drawing.Point(12, 17);
            this.lblNombreTema.Name = "lblNombreTema";
            this.lblNombreTema.Size = new System.Drawing.Size(35, 13);
            this.lblNombreTema.TabIndex = 3;
            this.lblNombreTema.Text = "label1";
            // 
            // lblDescripcionTema
            // 
            this.lblDescripcionTema.AutoSize = true;
            this.lblDescripcionTema.Location = new System.Drawing.Point(12, 84);
            this.lblDescripcionTema.Name = "lblDescripcionTema";
            this.lblDescripcionTema.Size = new System.Drawing.Size(35, 13);
            this.lblDescripcionTema.TabIndex = 4;
            this.lblDescripcionTema.Text = "label1";
            // 
            // FormCrearTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 183);
            this.Controls.Add(this.lblDescripcionTema);
            this.Controls.Add(this.lblNombreTema);
            this.Controls.Add(this.btnCrearTema);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.txtBoxNombre);
            this.Name = "FormCrearTema";
            this.Text = "FormCrearTema";
            this.Load += new System.EventHandler(this.FormCrearTema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Button btnCrearTema;
        private System.Windows.Forms.Label lblNombreTema;
        private System.Windows.Forms.Label lblDescripcionTema;
    }
}