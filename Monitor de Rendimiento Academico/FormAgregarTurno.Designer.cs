
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormAgregarTurno
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregarTurno = new System.Windows.Forms.Button();
            this.txtBoxTurno = new System.Windows.Forms.TextBox();
            this.lblTurnosCreados = new System.Windows.Forms.Label();
            this.lbTurnos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 6);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "label1";
            // 
            // btnAgregarTurno
            // 
            this.btnAgregarTurno.Location = new System.Drawing.Point(12, 148);
            this.btnAgregarTurno.Name = "btnAgregarTurno";
            this.btnAgregarTurno.Size = new System.Drawing.Size(76, 34);
            this.btnAgregarTurno.TabIndex = 1;
            this.btnAgregarTurno.Text = "button1";
            this.btnAgregarTurno.UseVisualStyleBackColor = true;
            this.btnAgregarTurno.Click += new System.EventHandler(this.btnAgregarTurno_Click);
            // 
            // txtBoxTurno
            // 
            this.txtBoxTurno.Location = new System.Drawing.Point(12, 22);
            this.txtBoxTurno.MaxLength = 50;
            this.txtBoxTurno.Name = "txtBoxTurno";
            this.txtBoxTurno.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTurno.TabIndex = 2;
            // 
            // lblTurnosCreados
            // 
            this.lblTurnosCreados.AutoSize = true;
            this.lblTurnosCreados.Location = new System.Drawing.Point(200, 6);
            this.lblTurnosCreados.Name = "lblTurnosCreados";
            this.lblTurnosCreados.Size = new System.Drawing.Size(35, 13);
            this.lblTurnosCreados.TabIndex = 3;
            this.lblTurnosCreados.Text = "label1";
            // 
            // lbTurnos
            // 
            this.lbTurnos.Enabled = false;
            this.lbTurnos.FormattingEnabled = true;
            this.lbTurnos.Location = new System.Drawing.Point(203, 22);
            this.lbTurnos.Name = "lbTurnos";
            this.lbTurnos.Size = new System.Drawing.Size(120, 160);
            this.lbTurnos.TabIndex = 4;
            // 
            // FormAgregarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 191);
            this.Controls.Add(this.lbTurnos);
            this.Controls.Add(this.lblTurnosCreados);
            this.Controls.Add(this.txtBoxTurno);
            this.Controls.Add(this.btnAgregarTurno);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormAgregarTurno";
            this.Text = "FormAgregarTurno";
            this.Load += new System.EventHandler(this.FormAgregarTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregarTurno;
        private System.Windows.Forms.TextBox txtBoxTurno;
        private System.Windows.Forms.Label lblTurnosCreados;
        private System.Windows.Forms.ListBox lbTurnos;
    }
}