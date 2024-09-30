
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormCrearCurso
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
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoCurso = new System.Windows.Forms.Label();
            this.lblAnoCurso = new System.Windows.Forms.Label();
            this.txtBoxAno = new System.Windows.Forms.TextBox();
            this.lblTurnoCurso = new System.Windows.Forms.Label();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(12, 30);
            this.txtBoxCodigo.MaxLength = 50;
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodigo.TabIndex = 0;
            // 
            // lblCodigoCurso
            // 
            this.lblCodigoCurso.AutoSize = true;
            this.lblCodigoCurso.Location = new System.Drawing.Point(12, 14);
            this.lblCodigoCurso.Name = "lblCodigoCurso";
            this.lblCodigoCurso.Size = new System.Drawing.Size(90, 13);
            this.lblCodigoCurso.TabIndex = 1;
            this.lblCodigoCurso.Text = "Codigo del Curso:";
            // 
            // lblAnoCurso
            // 
            this.lblAnoCurso.AutoSize = true;
            this.lblAnoCurso.Location = new System.Drawing.Point(12, 63);
            this.lblAnoCurso.Name = "lblAnoCurso";
            this.lblAnoCurso.Size = new System.Drawing.Size(90, 13);
            this.lblAnoCurso.TabIndex = 3;
            this.lblAnoCurso.Text = "Codigo del Curso:";
            // 
            // txtBoxAno
            // 
            this.txtBoxAno.Location = new System.Drawing.Point(12, 79);
            this.txtBoxAno.Name = "txtBoxAno";
            this.txtBoxAno.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAno.TabIndex = 2;
            this.txtBoxAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAno_KeyPress);
            // 
            // lblTurnoCurso
            // 
            this.lblTurnoCurso.AutoSize = true;
            this.lblTurnoCurso.Location = new System.Drawing.Point(12, 120);
            this.lblTurnoCurso.Name = "lblTurnoCurso";
            this.lblTurnoCurso.Size = new System.Drawing.Size(90, 13);
            this.lblTurnoCurso.TabIndex = 5;
            this.lblTurnoCurso.Text = "Codigo del Curso:";
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.Location = new System.Drawing.Point(12, 179);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(100, 42);
            this.btnCrearCurso.TabIndex = 7;
            this.btnCrearCurso.Text = "button1";
            this.btnCrearCurso.UseVisualStyleBackColor = true;
            this.btnCrearCurso.Click += new System.EventHandler(this.btnCrearCurso_Click);
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.IntegralHeight = false;
            this.comboBoxTurno.Location = new System.Drawing.Point(12, 136);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTurno.TabIndex = 8;
            // 
            // FormCrearCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 233);
            this.Controls.Add(this.comboBoxTurno);
            this.Controls.Add(this.btnCrearCurso);
            this.Controls.Add(this.lblTurnoCurso);
            this.Controls.Add(this.lblAnoCurso);
            this.Controls.Add(this.txtBoxAno);
            this.Controls.Add(this.lblCodigoCurso);
            this.Controls.Add(this.txtBoxCodigo);
            this.Name = "FormCrearCurso";
            this.Text = "FormCrearCurso";
            this.Load += new System.EventHandler(this.FormCrearCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.Label lblCodigoCurso;
        private System.Windows.Forms.Label lblAnoCurso;
        private System.Windows.Forms.TextBox txtBoxAno;
        private System.Windows.Forms.Label lblTurnoCurso;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.ComboBox comboBoxTurno;
    }
}