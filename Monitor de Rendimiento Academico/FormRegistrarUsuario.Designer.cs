
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormRegistrarUsuario
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
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.listBoxRoles = new System.Windows.Forms.ListBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombreReal = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.txtBoxNombreReal = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.lblPermisosDeRol = new System.Windows.Forms.Label();
            this.listBoxPermisosDeRol = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(12, 207);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(93, 40);
            this.buttonRegistrar.TabIndex = 13;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(280, 13);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(26, 13);
            this.lblRol.TabIndex = 12;
            this.lblRol.Text = "Rol:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(10, 56);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // listBoxRoles
            // 
            this.listBoxRoles.FormattingEnabled = true;
            this.listBoxRoles.Location = new System.Drawing.Point(283, 29);
            this.listBoxRoles.Name = "listBoxRoles";
            this.listBoxRoles.Size = new System.Drawing.Size(120, 95);
            this.listBoxRoles.TabIndex = 9;
            this.listBoxRoles.SelectedIndexChanged += new System.EventHandler(this.listBoxRoles_SelectedIndexChanged);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(10, 76);
            this.txtBoxPassword.MaxLength = 50;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPassword.TabIndex = 8;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(10, 29);
            this.txtBoxUsername.MaxLength = 50;
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUsername.TabIndex = 7;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(148, 56);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombreReal
            // 
            this.lblNombreReal.AutoSize = true;
            this.lblNombreReal.Location = new System.Drawing.Point(148, 9);
            this.lblNombreReal.Name = "lblNombreReal";
            this.lblNombreReal.Size = new System.Drawing.Size(47, 13);
            this.lblNombreReal.TabIndex = 16;
            this.lblNombreReal.Text = "Nombre:";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(148, 76);
            this.txtBoxApellido.MaxLength = 50;
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellido.TabIndex = 15;
            // 
            // txtBoxNombreReal
            // 
            this.txtBoxNombreReal.Location = new System.Drawing.Point(148, 29);
            this.txtBoxNombreReal.MaxLength = 50;
            this.txtBoxNombreReal.Name = "txtBoxNombreReal";
            this.txtBoxNombreReal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombreReal.TabIndex = 14;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(148, 111);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 19;
            this.lblDNI.Text = "DNI:";
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Location = new System.Drawing.Point(148, 125);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDNI.TabIndex = 18;
            this.txtBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDNI_KeyPress);
            // 
            // lblPermisosDeRol
            // 
            this.lblPermisosDeRol.AutoSize = true;
            this.lblPermisosDeRol.Location = new System.Drawing.Point(279, 136);
            this.lblPermisosDeRol.Name = "lblPermisosDeRol";
            this.lblPermisosDeRol.Size = new System.Drawing.Size(35, 13);
            this.lblPermisosDeRol.TabIndex = 21;
            this.lblPermisosDeRol.Text = "label5";
            // 
            // listBoxPermisosDeRol
            // 
            this.listBoxPermisosDeRol.FormattingEnabled = true;
            this.listBoxPermisosDeRol.Location = new System.Drawing.Point(282, 152);
            this.listBoxPermisosDeRol.Name = "listBoxPermisosDeRol";
            this.listBoxPermisosDeRol.Size = new System.Drawing.Size(120, 95);
            this.listBoxPermisosDeRol.TabIndex = 20;
            this.listBoxPermisosDeRol.SelectedIndexChanged += new System.EventHandler(this.listBoxPermisosDeRol_SelectedIndexChanged);
            // 
            // FormRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 259);
            this.Controls.Add(this.lblPermisosDeRol);
            this.Controls.Add(this.listBoxPermisosDeRol);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombreReal);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.txtBoxNombreReal);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.listBoxRoles);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Name = "FormRegistrarUsuario";
            this.Text = "Registrar Usuario";
            this.Load += new System.EventHandler(this.FormRegistrarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListBox listBoxRoles;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombreReal;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.TextBox txtBoxNombreReal;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.Label lblPermisosDeRol;
        private System.Windows.Forms.ListBox listBoxPermisosDeRol;
    }
}