
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormModificarCurso
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
            this.btnModificarCurso = new System.Windows.Forms.Button();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtBoxAno = new System.Windows.Forms.TextBox();
            this.lblTurnoCurso = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnModificarCurso
            // 
            this.btnModificarCurso.Location = new System.Drawing.Point(12, 176);
            this.btnModificarCurso.Name = "btnModificarCurso";
            this.btnModificarCurso.Size = new System.Drawing.Size(88, 45);
            this.btnModificarCurso.TabIndex = 18;
            this.btnModificarCurso.Text = "button3";
            this.btnModificarCurso.UseVisualStyleBackColor = true;
            this.btnModificarCurso.Click += new System.EventHandler(this.btnModificarCurso_Click);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(12, 67);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(35, 13);
            this.lblAno.TabIndex = 17;
            this.lblAno.Text = "label2";
            // 
            // txtBoxAno
            // 
            this.txtBoxAno.Location = new System.Drawing.Point(12, 83);
            this.txtBoxAno.Name = "txtBoxAno";
            this.txtBoxAno.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAno.TabIndex = 16;
            this.txtBoxAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAno_KeyPress);
            // 
            // lblTurnoCurso
            // 
            this.lblTurnoCurso.AutoSize = true;
            this.lblTurnoCurso.Location = new System.Drawing.Point(12, 123);
            this.lblTurnoCurso.Name = "lblTurnoCurso";
            this.lblTurnoCurso.Size = new System.Drawing.Size(90, 13);
            this.lblTurnoCurso.TabIndex = 19;
            this.lblTurnoCurso.Text = "Codigo del Curso:";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(12, 30);
            this.txtBoxNombre.MaxLength = 50;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 14;
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Location = new System.Drawing.Point(12, 14);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(35, 13);
            this.lblNombreCurso.TabIndex = 15;
            this.lblNombreCurso.Text = "label1";
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.IntegralHeight = false;
            this.comboBoxTurno.Location = new System.Drawing.Point(12, 139);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTurno.TabIndex = 20;
            this.comboBoxTurno.Click += new System.EventHandler(this.comboBoxTurno_Click);
            // 
            // FormModificarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 233);
            this.Controls.Add(this.comboBoxTurno);
            this.Controls.Add(this.lblTurnoCurso);
            this.Controls.Add(this.btnModificarCurso);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtBoxAno);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.txtBoxNombre);
            this.Name = "FormModificarCurso";
            this.Text = "FormModificarCurso";
            this.Load += new System.EventHandler(this.FormModificarCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarCurso;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtBoxAno;
        private System.Windows.Forms.Label lblTurnoCurso;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.ComboBox comboBoxTurno;
    }
}