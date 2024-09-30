
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormCrearEncuesta
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
            this.txtBoxPregunta = new System.Windows.Forms.TextBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnEnviarPregunta = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtBoxCurso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxPregunta
            // 
            this.txtBoxPregunta.Location = new System.Drawing.Point(12, 34);
            this.txtBoxPregunta.MaxLength = 50;
            this.txtBoxPregunta.Name = "txtBoxPregunta";
            this.txtBoxPregunta.Size = new System.Drawing.Size(153, 20);
            this.txtBoxPregunta.TabIndex = 0;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(9, 12);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(35, 13);
            this.lblPregunta.TabIndex = 1;
            this.lblPregunta.Text = "label1";
            // 
            // btnEnviarPregunta
            // 
            this.btnEnviarPregunta.Location = new System.Drawing.Point(12, 83);
            this.btnEnviarPregunta.Name = "btnEnviarPregunta";
            this.btnEnviarPregunta.Size = new System.Drawing.Size(78, 42);
            this.btnEnviarPregunta.TabIndex = 2;
            this.btnEnviarPregunta.Text = "button1";
            this.btnEnviarPregunta.UseVisualStyleBackColor = true;
            this.btnEnviarPregunta.Click += new System.EventHandler(this.btnEnviarPregunta_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(234, 12);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(35, 13);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "label1";
            // 
            // txtBoxCurso
            // 
            this.txtBoxCurso.BackColor = System.Drawing.Color.White;
            this.txtBoxCurso.Location = new System.Drawing.Point(237, 34);
            this.txtBoxCurso.MaxLength = 50;
            this.txtBoxCurso.Name = "txtBoxCurso";
            this.txtBoxCurso.ReadOnly = true;
            this.txtBoxCurso.Size = new System.Drawing.Size(119, 20);
            this.txtBoxCurso.TabIndex = 3;
            // 
            // FormCrearEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(368, 137);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.txtBoxCurso);
            this.Controls.Add(this.btnEnviarPregunta);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.txtBoxPregunta);
            this.Name = "FormCrearEncuesta";
            this.Text = "FormCrearEncuesta";
            this.Load += new System.EventHandler(this.FormCrearEncuesta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPregunta;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnEnviarPregunta;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtBoxCurso;
    }
}