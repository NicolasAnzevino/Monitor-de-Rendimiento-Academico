
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormModificarAlumno
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
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.lblAluDNI = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.lblAluApellido = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblAluNombre = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblAluEmail = new System.Windows.Forms.Label();
            this.lblAluFechaIng = new System.Windows.Forms.Label();
            this.lblAluFechaNac = new System.Windows.Forms.Label();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.lblAluTurno = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SelectorFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.SelectorFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Location = new System.Drawing.Point(12, 28);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDNI.TabIndex = 3;
            // 
            // lblAluDNI
            // 
            this.lblAluDNI.AutoSize = true;
            this.lblAluDNI.Location = new System.Drawing.Point(12, 12);
            this.lblAluDNI.Name = "lblAluDNI";
            this.lblAluDNI.Size = new System.Drawing.Size(35, 13);
            this.lblAluDNI.TabIndex = 2;
            this.lblAluDNI.Text = "label1";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(12, 82);
            this.txtBoxApellido.MaxLength = 50;
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellido.TabIndex = 5;
            // 
            // lblAluApellido
            // 
            this.lblAluApellido.AutoSize = true;
            this.lblAluApellido.Location = new System.Drawing.Point(12, 66);
            this.lblAluApellido.Name = "lblAluApellido";
            this.lblAluApellido.Size = new System.Drawing.Size(35, 13);
            this.lblAluApellido.TabIndex = 4;
            this.lblAluApellido.Text = "label1";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(12, 133);
            this.txtBoxNombre.MaxLength = 50;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 7;
            // 
            // lblAluNombre
            // 
            this.lblAluNombre.AutoSize = true;
            this.lblAluNombre.Location = new System.Drawing.Point(12, 117);
            this.lblAluNombre.Name = "lblAluNombre";
            this.lblAluNombre.Size = new System.Drawing.Size(35, 13);
            this.lblAluNombre.TabIndex = 6;
            this.lblAluNombre.Text = "label1";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(12, 182);
            this.txtBoxEmail.MaxLength = 50;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEmail.TabIndex = 9;
            // 
            // lblAluEmail
            // 
            this.lblAluEmail.AutoSize = true;
            this.lblAluEmail.Location = new System.Drawing.Point(12, 166);
            this.lblAluEmail.Name = "lblAluEmail";
            this.lblAluEmail.Size = new System.Drawing.Size(35, 13);
            this.lblAluEmail.TabIndex = 8;
            this.lblAluEmail.Text = "label1";
            // 
            // lblAluFechaIng
            // 
            this.lblAluFechaIng.AutoSize = true;
            this.lblAluFechaIng.Location = new System.Drawing.Point(145, 12);
            this.lblAluFechaIng.Name = "lblAluFechaIng";
            this.lblAluFechaIng.Size = new System.Drawing.Size(35, 13);
            this.lblAluFechaIng.TabIndex = 10;
            this.lblAluFechaIng.Text = "label1";
            // 
            // lblAluFechaNac
            // 
            this.lblAluFechaNac.AutoSize = true;
            this.lblAluFechaNac.Location = new System.Drawing.Point(12, 218);
            this.lblAluFechaNac.Name = "lblAluFechaNac";
            this.lblAluFechaNac.Size = new System.Drawing.Size(35, 13);
            this.lblAluFechaNac.TabIndex = 12;
            this.lblAluFechaNac.Text = "label1";
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.IntegralHeight = false;
            this.comboBoxTurno.Location = new System.Drawing.Point(145, 82);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTurno.TabIndex = 14;
            this.comboBoxTurno.Click += new System.EventHandler(this.comboBoxTurno_Click);
            // 
            // lblAluTurno
            // 
            this.lblAluTurno.AutoSize = true;
            this.lblAluTurno.Location = new System.Drawing.Point(145, 66);
            this.lblAluTurno.Name = "lblAluTurno";
            this.lblAluTurno.Size = new System.Drawing.Size(35, 13);
            this.lblAluTurno.TabIndex = 15;
            this.lblAluTurno.Text = "label1";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(166, 199);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 50);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "button1";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // SelectorFechaIngreso
            // 
            this.SelectorFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SelectorFechaIngreso.Location = new System.Drawing.Point(148, 28);
            this.SelectorFechaIngreso.Name = "SelectorFechaIngreso";
            this.SelectorFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.SelectorFechaIngreso.TabIndex = 53;
            // 
            // SelectorFechaNacimiento
            // 
            this.SelectorFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SelectorFechaNacimiento.Location = new System.Drawing.Point(12, 234);
            this.SelectorFechaNacimiento.Name = "SelectorFechaNacimiento";
            this.SelectorFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.SelectorFechaNacimiento.TabIndex = 54;
            // 
            // FormModificarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 262);
            this.Controls.Add(this.SelectorFechaNacimiento);
            this.Controls.Add(this.SelectorFechaIngreso);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblAluTurno);
            this.Controls.Add(this.comboBoxTurno);
            this.Controls.Add(this.lblAluFechaNac);
            this.Controls.Add(this.lblAluFechaIng);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblAluEmail);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblAluNombre);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.lblAluApellido);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.lblAluDNI);
            this.Name = "FormModificarAlumno";
            this.Text = "FormModificarAlumno";
            this.Load += new System.EventHandler(this.FormModificarAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.Label lblAluDNI;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label lblAluApellido;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblAluNombre;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblAluEmail;
        private System.Windows.Forms.Label lblAluFechaIng;
        private System.Windows.Forms.Label lblAluFechaNac;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.Label lblAluTurno;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DateTimePicker SelectorFechaIngreso;
        private System.Windows.Forms.DateTimePicker SelectorFechaNacimiento;
    }
}