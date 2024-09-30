
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormModificarMateria
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
            this.txtBoxCantHoras = new System.Windows.Forms.TextBox();
            this.lblCantHorasMateria = new System.Windows.Forms.Label();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxCantHoras
            // 
            this.txtBoxCantHoras.Location = new System.Drawing.Point(12, 98);
            this.txtBoxCantHoras.Name = "txtBoxCantHoras";
            this.txtBoxCantHoras.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCantHoras.TabIndex = 3;
            this.txtBoxCantHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCantHoras_KeyPress);
            // 
            // lblCantHorasMateria
            // 
            this.lblCantHorasMateria.AutoSize = true;
            this.lblCantHorasMateria.Location = new System.Drawing.Point(12, 82);
            this.lblCantHorasMateria.Name = "lblCantHorasMateria";
            this.lblCantHorasMateria.Size = new System.Drawing.Size(35, 13);
            this.lblCantHorasMateria.TabIndex = 2;
            this.lblCantHorasMateria.Text = "label2";
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Location = new System.Drawing.Point(12, 137);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(100, 42);
            this.btnModificarMateria.TabIndex = 4;
            this.btnModificarMateria.Text = "button1";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click);
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Location = new System.Drawing.Point(12, 14);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(35, 13);
            this.lblNombreMateria.TabIndex = 0;
            this.lblNombreMateria.Text = "label1";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(12, 30);
            this.txtBoxNombre.MaxLength = 50;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 1;
            // 
            // FormModificarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 191);
            this.Controls.Add(this.btnModificarMateria);
            this.Controls.Add(this.txtBoxCantHoras);
            this.Controls.Add(this.lblCantHorasMateria);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblNombreMateria);
            this.Name = "FormModificarMateria";
            this.Text = "FormModificarMateria";
            this.Load += new System.EventHandler(this.FormModificarMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxCantHoras;
        private System.Windows.Forms.Label lblCantHorasMateria;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.TextBox txtBoxNombre;
    }
}