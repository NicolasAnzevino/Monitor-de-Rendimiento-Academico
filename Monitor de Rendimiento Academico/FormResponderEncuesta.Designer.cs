
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormResponderEncuesta
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
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtBoxRespuesta = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnEnviarEncuesta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxPregunta
            // 
            this.txtBoxPregunta.BackColor = System.Drawing.Color.White;
            this.txtBoxPregunta.Location = new System.Drawing.Point(9, 47);
            this.txtBoxPregunta.Multiline = true;
            this.txtBoxPregunta.Name = "txtBoxPregunta";
            this.txtBoxPregunta.ReadOnly = true;
            this.txtBoxPregunta.Size = new System.Drawing.Size(349, 90);
            this.txtBoxPregunta.TabIndex = 0;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(12, 31);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(35, 13);
            this.lblPregunta.TabIndex = 1;
            this.lblPregunta.Text = "label1";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(12, 165);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(31, 17);
            this.rb1.TabIndex = 2;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(90, 165);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(31, 17);
            this.rb2.TabIndex = 3;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(168, 165);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(31, 17);
            this.rb3.TabIndex = 4;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(246, 165);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(31, 17);
            this.rb4.TabIndex = 5;
            this.rb4.Text = "4";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(324, 165);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(31, 17);
            this.rb5.TabIndex = 6;
            this.rb5.Text = "5";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(9, 203);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(35, 13);
            this.lblRespuesta.TabIndex = 8;
            this.lblRespuesta.Text = "label2";
            // 
            // txtBoxRespuesta
            // 
            this.txtBoxRespuesta.Location = new System.Drawing.Point(9, 219);
            this.txtBoxRespuesta.MaxLength = 77;
            this.txtBoxRespuesta.Multiline = true;
            this.txtBoxRespuesta.Name = "txtBoxRespuesta";
            this.txtBoxRespuesta.Size = new System.Drawing.Size(349, 90);
            this.txtBoxRespuesta.TabIndex = 7;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(281, 315);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 48);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.Text = "button1";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnEnviarEncuesta
            // 
            this.btnEnviarEncuesta.Location = new System.Drawing.Point(280, 315);
            this.btnEnviarEncuesta.Name = "btnEnviarEncuesta";
            this.btnEnviarEncuesta.Size = new System.Drawing.Size(75, 48);
            this.btnEnviarEncuesta.TabIndex = 10;
            this.btnEnviarEncuesta.Text = "button1";
            this.btnEnviarEncuesta.UseVisualStyleBackColor = true;
            this.btnEnviarEncuesta.Click += new System.EventHandler(this.btnEnviarEncuesta_Click);
            // 
            // FormResponderEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 375);
            this.Controls.Add(this.btnEnviarEncuesta);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.txtBoxRespuesta);
            this.Controls.Add(this.rb5);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.txtBoxPregunta);
            this.Name = "FormResponderEncuesta";
            this.Text = "FormResponderEncuesta";
            this.Load += new System.EventHandler(this.FormResponderEncuesta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPregunta;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtBoxRespuesta;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnEnviarEncuesta;
    }
}