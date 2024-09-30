
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormDetectarProblemas
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
            this.btnProblemasCurso = new System.Windows.Forms.Button();
            this.btnProblemasDocente = new System.Windows.Forms.Button();
            this.lblTipoProblema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProblemasCurso
            // 
            this.btnProblemasCurso.Location = new System.Drawing.Point(137, 115);
            this.btnProblemasCurso.Name = "btnProblemasCurso";
            this.btnProblemasCurso.Size = new System.Drawing.Size(99, 44);
            this.btnProblemasCurso.TabIndex = 0;
            this.btnProblemasCurso.Text = "button1";
            this.btnProblemasCurso.UseVisualStyleBackColor = true;
            this.btnProblemasCurso.Click += new System.EventHandler(this.btnProblemasCurso_Click);
            // 
            // btnProblemasDocente
            // 
            this.btnProblemasDocente.Location = new System.Drawing.Point(353, 115);
            this.btnProblemasDocente.Name = "btnProblemasDocente";
            this.btnProblemasDocente.Size = new System.Drawing.Size(99, 44);
            this.btnProblemasDocente.TabIndex = 1;
            this.btnProblemasDocente.Text = "button2";
            this.btnProblemasDocente.UseVisualStyleBackColor = true;
            this.btnProblemasDocente.Click += new System.EventHandler(this.btnProblemasDocente_Click);
            // 
            // lblTipoProblema
            // 
            this.lblTipoProblema.AutoSize = true;
            this.lblTipoProblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProblema.Location = new System.Drawing.Point(94, 30);
            this.lblTipoProblema.Name = "lblTipoProblema";
            this.lblTipoProblema.Size = new System.Drawing.Size(380, 24);
            this.lblTipoProblema.TabIndex = 2;
            this.lblTipoProblema.Text = "¿Qué tipo de problema desea detectar?";
            // 
            // FormDetectarProblemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 253);
            this.Controls.Add(this.lblTipoProblema);
            this.Controls.Add(this.btnProblemasDocente);
            this.Controls.Add(this.btnProblemasCurso);
            this.Name = "FormDetectarProblemas";
            this.Text = "FormDetectarProblemas";
            this.Load += new System.EventHandler(this.FormDetectarProblemas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProblemasCurso;
        private System.Windows.Forms.Button btnProblemasDocente;
        private System.Windows.Forms.Label lblTipoProblema;
    }
}