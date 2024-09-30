
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerUsuariosModificados
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
            this.txtBoxInforme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxInforme
            // 
            this.txtBoxInforme.BackColor = System.Drawing.Color.White;
            this.txtBoxInforme.Location = new System.Drawing.Point(12, 12);
            this.txtBoxInforme.Multiline = true;
            this.txtBoxInforme.Name = "txtBoxInforme";
            this.txtBoxInforme.ReadOnly = true;
            this.txtBoxInforme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxInforme.Size = new System.Drawing.Size(474, 278);
            this.txtBoxInforme.TabIndex = 0;
            // 
            // FormVerUsuariosModificados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 302);
            this.Controls.Add(this.txtBoxInforme);
            this.Name = "FormVerUsuariosModificados";
            this.Text = "FormVerUsuariosModificados";
            this.Load += new System.EventHandler(this.FormVerUsuariosModificados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxInforme;
    }
}