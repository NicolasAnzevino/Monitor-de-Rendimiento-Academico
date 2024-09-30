
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormInformeProblemaCurso
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
            this.lblConclusion = new System.Windows.Forms.Label();
            this.txtBoxInforme = new System.Windows.Forms.TextBox();
            this.lblInforme = new System.Windows.Forms.Label();
            this.txtBoxConclusion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Location = new System.Drawing.Point(478, 5);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(35, 13);
            this.lblConclusion.TabIndex = 8;
            this.lblConclusion.Text = "label1";
            // 
            // txtBoxInforme
            // 
            this.txtBoxInforme.BackColor = System.Drawing.Color.White;
            this.txtBoxInforme.Location = new System.Drawing.Point(12, 21);
            this.txtBoxInforme.Multiline = true;
            this.txtBoxInforme.Name = "txtBoxInforme";
            this.txtBoxInforme.ReadOnly = true;
            this.txtBoxInforme.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxInforme.Size = new System.Drawing.Size(449, 307);
            this.txtBoxInforme.TabIndex = 6;
            // 
            // lblInforme
            // 
            this.lblInforme.AutoSize = true;
            this.lblInforme.Location = new System.Drawing.Point(12, 5);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(35, 13);
            this.lblInforme.TabIndex = 9;
            this.lblInforme.Text = "label1";
            // 
            // txtBoxConclusion
            // 
            this.txtBoxConclusion.BackColor = System.Drawing.Color.White;
            this.txtBoxConclusion.Location = new System.Drawing.Point(481, 21);
            this.txtBoxConclusion.Multiline = true;
            this.txtBoxConclusion.Name = "txtBoxConclusion";
            this.txtBoxConclusion.ReadOnly = true;
            this.txtBoxConclusion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxConclusion.Size = new System.Drawing.Size(340, 307);
            this.txtBoxConclusion.TabIndex = 10;
            // 
            // FormInformeProblemaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 368);
            this.Controls.Add(this.txtBoxConclusion);
            this.Controls.Add(this.lblInforme);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.txtBoxInforme);
            this.Name = "FormInformeProblemaCurso";
            this.Text = "FormInformeProblemaCurso";
            this.Load += new System.EventHandler(this.FormInformeProblemaCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.TextBox txtBoxInforme;
        private System.Windows.Forms.Label lblInforme;
        private System.Windows.Forms.TextBox txtBoxConclusion;
    }
}