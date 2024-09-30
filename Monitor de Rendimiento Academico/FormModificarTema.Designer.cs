
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormModificarTema
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
            this.lblDescripcionTema = new System.Windows.Forms.Label();
            this.lblNombreTema = new System.Windows.Forms.Label();
            this.lblModificarTema = new System.Windows.Forms.Button();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDescripcionTema
            // 
            this.lblDescripcionTema.AutoSize = true;
            this.lblDescripcionTema.Location = new System.Drawing.Point(12, 81);
            this.lblDescripcionTema.Name = "lblDescripcionTema";
            this.lblDescripcionTema.Size = new System.Drawing.Size(35, 13);
            this.lblDescripcionTema.TabIndex = 9;
            this.lblDescripcionTema.Text = "label1";
            // 
            // lblNombreTema
            // 
            this.lblNombreTema.AutoSize = true;
            this.lblNombreTema.Location = new System.Drawing.Point(12, 14);
            this.lblNombreTema.Name = "lblNombreTema";
            this.lblNombreTema.Size = new System.Drawing.Size(35, 13);
            this.lblNombreTema.TabIndex = 8;
            this.lblNombreTema.Text = "label1";
            // 
            // lblModificarTema
            // 
            this.lblModificarTema.Location = new System.Drawing.Point(196, 19);
            this.lblModificarTema.Name = "lblModificarTema";
            this.lblModificarTema.Size = new System.Drawing.Size(86, 41);
            this.lblModificarTema.TabIndex = 7;
            this.lblModificarTema.Text = "button1";
            this.lblModificarTema.UseVisualStyleBackColor = true;
            this.lblModificarTema.Click += new System.EventHandler(this.lblModificarTema_Click);
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(12, 97);
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDescripcion.Size = new System.Drawing.Size(199, 72);
            this.txtBoxDescripcion.TabIndex = 6;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(12, 30);
            this.txtBoxNombre.MaxLength = 50;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 5;
            // 
            // FormModificarTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 183);
            this.Controls.Add(this.lblDescripcionTema);
            this.Controls.Add(this.lblNombreTema);
            this.Controls.Add(this.lblModificarTema);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.txtBoxNombre);
            this.Name = "FormModificarTema";
            this.Text = "FormModificarTema";
            this.Load += new System.EventHandler(this.FormModificarTema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionTema;
        private System.Windows.Forms.Label lblNombreTema;
        private System.Windows.Forms.Button lblModificarTema;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.TextBox txtBoxNombre;
    }
}