
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormPrimeraVez
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
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombreReal = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.txtBoxNombreReal = new System.Windows.Forms.TextBox();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtBoxLegajo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.Location = new System.Drawing.Point(107, 408);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(88, 59);
            this.buttonRegistrarse.TabIndex = 0;
            this.buttonRegistrarse.Text = "Registrarse";
            this.buttonRegistrarse.UseVisualStyleBackColor = true;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(67, 111);
            this.txtBoxUsername.MaxLength = 50;
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(192, 20);
            this.txtBoxUsername.TabIndex = 1;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(67, 166);
            this.txtBoxPassword.MaxLength = 50;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(192, 20);
            this.txtBoxPassword.TabIndex = 2;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(64, 150);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(64, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(101, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre de Usuario:";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(114, 18);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(105, 24);
            this.lblBienvenido.TabIndex = 14;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(61, 54);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(131, 13);
            this.lblDescripcion.TabIndex = 15;
            this.lblDescripcion.Text = "Para comenzar, regístrese";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(64, 252);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombreReal
            // 
            this.lblNombreReal.AutoSize = true;
            this.lblNombreReal.Location = new System.Drawing.Point(64, 205);
            this.lblNombreReal.Name = "lblNombreReal";
            this.lblNombreReal.Size = new System.Drawing.Size(47, 13);
            this.lblNombreReal.TabIndex = 18;
            this.lblNombreReal.Text = "Nombre:";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(67, 268);
            this.txtBoxApellido.MaxLength = 50;
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(192, 20);
            this.txtBoxApellido.TabIndex = 17;
            // 
            // txtBoxNombreReal
            // 
            this.txtBoxNombreReal.Location = new System.Drawing.Point(67, 221);
            this.txtBoxNombreReal.MaxLength = 50;
            this.txtBoxNombreReal.Name = "txtBoxNombreReal";
            this.txtBoxNombreReal.Size = new System.Drawing.Size(192, 20);
            this.txtBoxNombreReal.TabIndex = 16;
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Location = new System.Drawing.Point(67, 321);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(192, 20);
            this.txtBoxDNI.TabIndex = 20;
            this.txtBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDNI_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(64, 305);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 21;
            this.lblDNI.Text = "DNI:";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(64, 352);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(42, 13);
            this.lblLegajo.TabIndex = 23;
            this.lblLegajo.Text = "Legajo:";
            // 
            // txtBoxLegajo
            // 
            this.txtBoxLegajo.Location = new System.Drawing.Point(67, 368);
            this.txtBoxLegajo.MaxLength = 50;
            this.txtBoxLegajo.Name = "txtBoxLegajo";
            this.txtBoxLegajo.Size = new System.Drawing.Size(192, 20);
            this.txtBoxLegajo.TabIndex = 22;
            // 
            // FormPrimeraVez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 479);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.txtBoxLegajo);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombreReal);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.txtBoxNombreReal);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.buttonRegistrarse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrimeraVez";
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.FormPrimeraVez_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombreReal;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.TextBox txtBoxNombreReal;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtBoxLegajo;
    }
}