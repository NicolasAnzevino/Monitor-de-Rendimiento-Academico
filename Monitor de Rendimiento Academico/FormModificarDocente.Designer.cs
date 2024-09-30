
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormModificarDocente
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
            this.lblDocNombre = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.lblDocApellido = new System.Windows.Forms.Label();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.lblDocDNI = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(12, 132);
            this.txtBoxNombre.MaxLength = 50;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 13;
            // 
            // lblDocNombre
            // 
            this.lblDocNombre.AutoSize = true;
            this.lblDocNombre.Location = new System.Drawing.Point(12, 116);
            this.lblDocNombre.Name = "lblDocNombre";
            this.lblDocNombre.Size = new System.Drawing.Size(35, 13);
            this.lblDocNombre.TabIndex = 12;
            this.lblDocNombre.Text = "label1";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(12, 81);
            this.txtBoxApellido.MaxLength = 50;
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellido.TabIndex = 11;
            // 
            // lblDocApellido
            // 
            this.lblDocApellido.AutoSize = true;
            this.lblDocApellido.Location = new System.Drawing.Point(12, 65);
            this.lblDocApellido.Name = "lblDocApellido";
            this.lblDocApellido.Size = new System.Drawing.Size(35, 13);
            this.lblDocApellido.TabIndex = 10;
            this.lblDocApellido.Text = "label1";
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Location = new System.Drawing.Point(12, 27);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDNI.TabIndex = 9;
            // 
            // lblDocDNI
            // 
            this.lblDocDNI.AutoSize = true;
            this.lblDocDNI.Location = new System.Drawing.Point(12, 11);
            this.lblDocDNI.Name = "lblDocDNI";
            this.lblDocDNI.Size = new System.Drawing.Size(35, 13);
            this.lblDocDNI.TabIndex = 8;
            this.lblDocDNI.Text = "label1";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 177);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 50);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "button1";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FormModificarDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 240);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblDocNombre);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.lblDocApellido);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.lblDocDNI);
            this.Name = "FormModificarDocente";
            this.Text = "FormModificarDocente";
            this.Load += new System.EventHandler(this.FormModificarDocente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblDocNombre;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label lblDocApellido;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.Label lblDocDNI;
        private System.Windows.Forms.Button btnModificar;
    }
}