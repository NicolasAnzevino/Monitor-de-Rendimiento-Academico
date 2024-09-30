
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormCrearMateria
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantHorasSem = new System.Windows.Forms.Label();
            this.txtBoxCantHoras = new System.Windows.Forms.TextBox();
            this.btnCrearMateria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(12, 32);
            this.txtBoxNombre.MaxLength = 50;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "label1";
            // 
            // lblCantHorasSem
            // 
            this.lblCantHorasSem.AutoSize = true;
            this.lblCantHorasSem.Location = new System.Drawing.Point(12, 69);
            this.lblCantHorasSem.Name = "lblCantHorasSem";
            this.lblCantHorasSem.Size = new System.Drawing.Size(35, 13);
            this.lblCantHorasSem.TabIndex = 3;
            this.lblCantHorasSem.Text = "label2";
            // 
            // txtBoxCantHoras
            // 
            this.txtBoxCantHoras.Location = new System.Drawing.Point(12, 85);
            this.txtBoxCantHoras.Name = "txtBoxCantHoras";
            this.txtBoxCantHoras.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCantHoras.TabIndex = 2;
            this.txtBoxCantHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCantHoras_KeyPress);
            // 
            // btnCrearMateria
            // 
            this.btnCrearMateria.Location = new System.Drawing.Point(12, 129);
            this.btnCrearMateria.Name = "btnCrearMateria";
            this.btnCrearMateria.Size = new System.Drawing.Size(88, 45);
            this.btnCrearMateria.TabIndex = 13;
            this.btnCrearMateria.Text = "button3";
            this.btnCrearMateria.UseVisualStyleBackColor = true;
            this.btnCrearMateria.Click += new System.EventHandler(this.btnCrearMateria_Click);
            // 
            // FormCrearMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 184);
            this.Controls.Add(this.btnCrearMateria);
            this.Controls.Add(this.lblCantHorasSem);
            this.Controls.Add(this.txtBoxCantHoras);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBoxNombre);
            this.Name = "FormCrearMateria";
            this.Text = "FormCrearMateria";
            this.Load += new System.EventHandler(this.FormCrearMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantHorasSem;
        private System.Windows.Forms.TextBox txtBoxCantHoras;
        private System.Windows.Forms.Button btnCrearMateria;
    }
}