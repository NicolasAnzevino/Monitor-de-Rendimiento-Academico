
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormModificarUsuario
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
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBoxNombreReal = new System.Windows.Forms.TextBox();
            this.lblNombreReal = new System.Windows.Forms.Label();
            this.listBoxRoles = new System.Windows.Forms.ListBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.lblPermisosDeRol = new System.Windows.Forms.Label();
            this.listBoxPermisosDeRol = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(12, 9);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(35, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "label1";
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Location = new System.Drawing.Point(12, 25);
            this.txtBoxDNI.MaxLength = 8;
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDNI.TabIndex = 1;
            this.txtBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDNI_KeyPress);
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(12, 77);
            this.txtBoxApellido.MaxLength = 50;
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 61);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(35, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "label2";
            // 
            // txtBoxNombreReal
            // 
            this.txtBoxNombreReal.Location = new System.Drawing.Point(12, 127);
            this.txtBoxNombreReal.MaxLength = 50;
            this.txtBoxNombreReal.Name = "txtBoxNombreReal";
            this.txtBoxNombreReal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombreReal.TabIndex = 5;
            // 
            // lblNombreReal
            // 
            this.lblNombreReal.AutoSize = true;
            this.lblNombreReal.Location = new System.Drawing.Point(12, 111);
            this.lblNombreReal.Name = "lblNombreReal";
            this.lblNombreReal.Size = new System.Drawing.Size(35, 13);
            this.lblNombreReal.TabIndex = 4;
            this.lblNombreReal.Text = "label3";
            // 
            // listBoxRoles
            // 
            this.listBoxRoles.FormattingEnabled = true;
            this.listBoxRoles.Location = new System.Drawing.Point(244, 25);
            this.listBoxRoles.Name = "listBoxRoles";
            this.listBoxRoles.Size = new System.Drawing.Size(120, 95);
            this.listBoxRoles.TabIndex = 6;
            this.listBoxRoles.SelectedIndexChanged += new System.EventHandler(this.listBoxRoles_SelectedIndexChanged);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(241, 9);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(35, 13);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "label4";
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(12, 197);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(100, 40);
            this.btnModificarUsuario.TabIndex = 8;
            this.btnModificarUsuario.Text = "button1";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // lblPermisosDeRol
            // 
            this.lblPermisosDeRol.AutoSize = true;
            this.lblPermisosDeRol.Location = new System.Drawing.Point(241, 131);
            this.lblPermisosDeRol.Name = "lblPermisosDeRol";
            this.lblPermisosDeRol.Size = new System.Drawing.Size(35, 13);
            this.lblPermisosDeRol.TabIndex = 10;
            this.lblPermisosDeRol.Text = "label5";
            // 
            // listBoxPermisosDeRol
            // 
            this.listBoxPermisosDeRol.FormattingEnabled = true;
            this.listBoxPermisosDeRol.Location = new System.Drawing.Point(244, 147);
            this.listBoxPermisosDeRol.Name = "listBoxPermisosDeRol";
            this.listBoxPermisosDeRol.Size = new System.Drawing.Size(120, 95);
            this.listBoxPermisosDeRol.TabIndex = 9;
            // 
            // FormModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 249);
            this.Controls.Add(this.lblPermisosDeRol);
            this.Controls.Add(this.listBoxPermisosDeRol);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.listBoxRoles);
            this.Controls.Add(this.txtBoxNombreReal);
            this.Controls.Add(this.lblNombreReal);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.lblDNI);
            this.Name = "FormModificarUsuario";
            this.Text = "FormModificarUsuario";
            this.Load += new System.EventHandler(this.FormModificarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBoxNombreReal;
        private System.Windows.Forms.Label lblNombreReal;
        private System.Windows.Forms.ListBox listBoxRoles;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Label lblPermisosDeRol;
        private System.Windows.Forms.ListBox listBoxPermisosDeRol;
    }
}