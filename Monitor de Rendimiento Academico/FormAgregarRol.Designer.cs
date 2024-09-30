
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormAgregarRol
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
            this.txtBoxIngreseNombreRol = new System.Windows.Forms.TextBox();
            this.listBoxPermisos = new System.Windows.Forms.ListBox();
            this.listBoxPermisosKit = new System.Windows.Forms.ListBox();
            this.lblIngreseNombreRol = new System.Windows.Forms.Label();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.lblPermisosDeKit = new System.Windows.Forms.Label();
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.btnAgregarPermiso = new System.Windows.Forms.Button();
            this.lblPermisosSeleccionados = new System.Windows.Forms.Label();
            this.listBoxPermisosSeleccionados = new System.Windows.Forms.ListBox();
            this.btnQuitarPermiso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxIngreseNombreRol
            // 
            this.txtBoxIngreseNombreRol.Location = new System.Drawing.Point(12, 28);
            this.txtBoxIngreseNombreRol.MaxLength = 50;
            this.txtBoxIngreseNombreRol.Name = "txtBoxIngreseNombreRol";
            this.txtBoxIngreseNombreRol.Size = new System.Drawing.Size(120, 20);
            this.txtBoxIngreseNombreRol.TabIndex = 0;
            // 
            // listBoxPermisos
            // 
            this.listBoxPermisos.FormattingEnabled = true;
            this.listBoxPermisos.HorizontalScrollbar = true;
            this.listBoxPermisos.Location = new System.Drawing.Point(222, 28);
            this.listBoxPermisos.Name = "listBoxPermisos";
            this.listBoxPermisos.ScrollAlwaysVisible = true;
            this.listBoxPermisos.Size = new System.Drawing.Size(141, 121);
            this.listBoxPermisos.TabIndex = 1;
            this.listBoxPermisos.SelectedIndexChanged += new System.EventHandler(this.listBoxPermisos_SelectedIndexChanged);
            // 
            // listBoxPermisosKit
            // 
            this.listBoxPermisosKit.FormattingEnabled = true;
            this.listBoxPermisosKit.HorizontalScrollbar = true;
            this.listBoxPermisosKit.Location = new System.Drawing.Point(222, 219);
            this.listBoxPermisosKit.Name = "listBoxPermisosKit";
            this.listBoxPermisosKit.ScrollAlwaysVisible = true;
            this.listBoxPermisosKit.Size = new System.Drawing.Size(141, 95);
            this.listBoxPermisosKit.TabIndex = 2;
            // 
            // lblIngreseNombreRol
            // 
            this.lblIngreseNombreRol.AutoSize = true;
            this.lblIngreseNombreRol.Location = new System.Drawing.Point(9, 12);
            this.lblIngreseNombreRol.Name = "lblIngreseNombreRol";
            this.lblIngreseNombreRol.Size = new System.Drawing.Size(132, 13);
            this.lblIngreseNombreRol.TabIndex = 3;
            this.lblIngreseNombreRol.Text = "Ingrese el Nombre del Rol:";
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Location = new System.Drawing.Point(219, 12);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(52, 13);
            this.lblPermisos.TabIndex = 4;
            this.lblPermisos.Text = "Permisos:";
            // 
            // lblPermisosDeKit
            // 
            this.lblPermisosDeKit.AutoSize = true;
            this.lblPermisosDeKit.Location = new System.Drawing.Point(220, 203);
            this.lblPermisosDeKit.Name = "lblPermisosDeKit";
            this.lblPermisosDeKit.Size = new System.Drawing.Size(143, 13);
            this.lblPermisosDeKit.TabIndex = 5;
            this.lblPermisosDeKit.Text = "Permisos que contiene el Kit:";
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Location = new System.Drawing.Point(12, 269);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(97, 45);
            this.btnAgregarRol.TabIndex = 6;
            this.btnAgregarRol.Text = "Agregar Rol";
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.Location = new System.Drawing.Point(222, 155);
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.Size = new System.Drawing.Size(141, 27);
            this.btnAgregarPermiso.TabIndex = 7;
            this.btnAgregarPermiso.Text = "button1";
            this.btnAgregarPermiso.UseVisualStyleBackColor = true;
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // lblPermisosSeleccionados
            // 
            this.lblPermisosSeleccionados.AutoSize = true;
            this.lblPermisosSeleccionados.Location = new System.Drawing.Point(397, 12);
            this.lblPermisosSeleccionados.Name = "lblPermisosSeleccionados";
            this.lblPermisosSeleccionados.Size = new System.Drawing.Size(52, 13);
            this.lblPermisosSeleccionados.TabIndex = 9;
            this.lblPermisosSeleccionados.Text = "Permisos:";
            // 
            // listBoxPermisosSeleccionados
            // 
            this.listBoxPermisosSeleccionados.FormattingEnabled = true;
            this.listBoxPermisosSeleccionados.HorizontalScrollbar = true;
            this.listBoxPermisosSeleccionados.Location = new System.Drawing.Point(400, 28);
            this.listBoxPermisosSeleccionados.Name = "listBoxPermisosSeleccionados";
            this.listBoxPermisosSeleccionados.ScrollAlwaysVisible = true;
            this.listBoxPermisosSeleccionados.Size = new System.Drawing.Size(141, 121);
            this.listBoxPermisosSeleccionados.TabIndex = 8;
            // 
            // btnQuitarPermiso
            // 
            this.btnQuitarPermiso.Location = new System.Drawing.Point(400, 155);
            this.btnQuitarPermiso.Name = "btnQuitarPermiso";
            this.btnQuitarPermiso.Size = new System.Drawing.Size(141, 27);
            this.btnQuitarPermiso.TabIndex = 10;
            this.btnQuitarPermiso.Text = "button1";
            this.btnQuitarPermiso.UseVisualStyleBackColor = true;
            this.btnQuitarPermiso.Click += new System.EventHandler(this.btnQuitarPermiso_Click);
            // 
            // FormAgregarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 326);
            this.Controls.Add(this.btnQuitarPermiso);
            this.Controls.Add(this.lblPermisosSeleccionados);
            this.Controls.Add(this.listBoxPermisosSeleccionados);
            this.Controls.Add(this.btnAgregarPermiso);
            this.Controls.Add(this.btnAgregarRol);
            this.Controls.Add(this.lblPermisosDeKit);
            this.Controls.Add(this.lblPermisos);
            this.Controls.Add(this.lblIngreseNombreRol);
            this.Controls.Add(this.listBoxPermisosKit);
            this.Controls.Add(this.listBoxPermisos);
            this.Controls.Add(this.txtBoxIngreseNombreRol);
            this.Name = "FormAgregarRol";
            this.Text = "Agregar Rol";
            this.Load += new System.EventHandler(this.FormAgregarRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxIngreseNombreRol;
        private System.Windows.Forms.ListBox listBoxPermisos;
        private System.Windows.Forms.ListBox listBoxPermisosKit;
        private System.Windows.Forms.Label lblIngreseNombreRol;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Label lblPermisosDeKit;
        private System.Windows.Forms.Button btnAgregarRol;
        private System.Windows.Forms.Button btnAgregarPermiso;
        private System.Windows.Forms.Label lblPermisosSeleccionados;
        private System.Windows.Forms.ListBox listBoxPermisosSeleccionados;
        private System.Windows.Forms.Button btnQuitarPermiso;
    }
}