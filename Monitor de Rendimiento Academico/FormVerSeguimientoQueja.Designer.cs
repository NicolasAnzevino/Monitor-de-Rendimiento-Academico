
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerSeguimientoQueja
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
            this.lblDescripcionSeguimiento = new System.Windows.Forms.Label();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDescripcionSeguimiento
            // 
            this.lblDescripcionSeguimiento.AutoSize = true;
            this.lblDescripcionSeguimiento.Location = new System.Drawing.Point(12, 22);
            this.lblDescripcionSeguimiento.Name = "lblDescripcionSeguimiento";
            this.lblDescripcionSeguimiento.Size = new System.Drawing.Size(35, 13);
            this.lblDescripcionSeguimiento.TabIndex = 0;
            this.lblDescripcionSeguimiento.Text = "label1";
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.BackColor = System.Drawing.Color.White;
            this.txtBoxDescripcion.Location = new System.Drawing.Point(12, 54);
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.ReadOnly = true;
            this.txtBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDescripcion.Size = new System.Drawing.Size(547, 239);
            this.txtBoxDescripcion.TabIndex = 1;
            this.txtBoxDescripcion.TabStop = false;
            // 
            // FormVerSeguimientoQueja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 301);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.lblDescripcionSeguimiento);
            this.Name = "FormVerSeguimientoQueja";
            this.Text = "FormVerSeguimientoQueja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVerSeguimientoQueja_FormClosed);
            this.Load += new System.EventHandler(this.FormVerSeguimientoQueja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionSeguimiento;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
    }
}