
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.DGVUsuarios_Col_Nombre_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVUsuarios_Col_Rol_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVUsuarios_Col_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVUsuarios_Col_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVUsuarios_Col_Nombre_Real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpVisualizacion = new System.Windows.Forms.GroupBox();
            this.rbUsuariosRol = new System.Windows.Forms.RadioButton();
            this.rbUsuariosDNI = new System.Windows.Forms.RadioButton();
            this.rbUsuariosApellido = new System.Windows.Forms.RadioButton();
            this.rbUsuariosNombreReal = new System.Windows.Forms.RadioButton();
            this.rbUsuariosNombre = new System.Windows.Forms.RadioButton();
            this.rbUsuariosTodos = new System.Windows.Forms.RadioButton();
            this.gpUsuariosActivos = new System.Windows.Forms.GroupBox();
            this.rbUsuariosInactivos = new System.Windows.Forms.RadioButton();
            this.rbUsuariosActivos = new System.Windows.Forms.RadioButton();
            this.btnDarDeBajaUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnModificarContraseña = new System.Windows.Forms.Button();
            this.btnDarDeAltaUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gpVisualizacion.SuspendLayout();
            this.gpUsuariosActivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVUsuarios_Col_Nombre_Usuario,
            this.DGVUsuarios_Col_Rol_Nombre,
            this.DGVUsuarios_Col_DNI,
            this.DGVUsuarios_Col_Apellido,
            this.DGVUsuarios_Col_Nombre_Real});
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 12);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(758, 217);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.Click += new System.EventHandler(this.dgvUsuarios_Click);
            // 
            // DGVUsuarios_Col_Nombre_Usuario
            // 
            this.DGVUsuarios_Col_Nombre_Usuario.HeaderText = "Columna1";
            this.DGVUsuarios_Col_Nombre_Usuario.Name = "DGVUsuarios_Col_Nombre_Usuario";
            this.DGVUsuarios_Col_Nombre_Usuario.ReadOnly = true;
            // 
            // DGVUsuarios_Col_Rol_Nombre
            // 
            this.DGVUsuarios_Col_Rol_Nombre.HeaderText = "Columna2";
            this.DGVUsuarios_Col_Rol_Nombre.Name = "DGVUsuarios_Col_Rol_Nombre";
            this.DGVUsuarios_Col_Rol_Nombre.ReadOnly = true;
            // 
            // DGVUsuarios_Col_DNI
            // 
            this.DGVUsuarios_Col_DNI.HeaderText = "Column1";
            this.DGVUsuarios_Col_DNI.Name = "DGVUsuarios_Col_DNI";
            this.DGVUsuarios_Col_DNI.ReadOnly = true;
            // 
            // DGVUsuarios_Col_Apellido
            // 
            this.DGVUsuarios_Col_Apellido.HeaderText = "Column1";
            this.DGVUsuarios_Col_Apellido.Name = "DGVUsuarios_Col_Apellido";
            this.DGVUsuarios_Col_Apellido.ReadOnly = true;
            // 
            // DGVUsuarios_Col_Nombre_Real
            // 
            this.DGVUsuarios_Col_Nombre_Real.HeaderText = "Column1";
            this.DGVUsuarios_Col_Nombre_Real.Name = "DGVUsuarios_Col_Nombre_Real";
            this.DGVUsuarios_Col_Nombre_Real.ReadOnly = true;
            // 
            // gpVisualizacion
            // 
            this.gpVisualizacion.Controls.Add(this.rbUsuariosRol);
            this.gpVisualizacion.Controls.Add(this.rbUsuariosDNI);
            this.gpVisualizacion.Controls.Add(this.rbUsuariosApellido);
            this.gpVisualizacion.Controls.Add(this.rbUsuariosNombreReal);
            this.gpVisualizacion.Controls.Add(this.rbUsuariosNombre);
            this.gpVisualizacion.Controls.Add(this.rbUsuariosTodos);
            this.gpVisualizacion.Location = new System.Drawing.Point(434, 235);
            this.gpVisualizacion.Name = "gpVisualizacion";
            this.gpVisualizacion.Size = new System.Drawing.Size(321, 67);
            this.gpVisualizacion.TabIndex = 32;
            this.gpVisualizacion.TabStop = false;
            this.gpVisualizacion.Text = "groupBox1";
            // 
            // rbUsuariosRol
            // 
            this.rbUsuariosRol.AutoSize = true;
            this.rbUsuariosRol.Location = new System.Drawing.Point(128, 18);
            this.rbUsuariosRol.Name = "rbUsuariosRol";
            this.rbUsuariosRol.Size = new System.Drawing.Size(85, 17);
            this.rbUsuariosRol.TabIndex = 31;
            this.rbUsuariosRol.Text = "radioButton3";
            this.rbUsuariosRol.UseVisualStyleBackColor = true;
            this.rbUsuariosRol.CheckedChanged += new System.EventHandler(this.rbUsuariosRol_CheckedChanged);
            // 
            // rbUsuariosDNI
            // 
            this.rbUsuariosDNI.AutoSize = true;
            this.rbUsuariosDNI.Location = new System.Drawing.Point(128, 41);
            this.rbUsuariosDNI.Name = "rbUsuariosDNI";
            this.rbUsuariosDNI.Size = new System.Drawing.Size(85, 17);
            this.rbUsuariosDNI.TabIndex = 30;
            this.rbUsuariosDNI.Text = "radioButton3";
            this.rbUsuariosDNI.UseVisualStyleBackColor = true;
            this.rbUsuariosDNI.CheckedChanged += new System.EventHandler(this.rbUsuariosDNI_CheckedChanged);
            // 
            // rbUsuariosApellido
            // 
            this.rbUsuariosApellido.AutoSize = true;
            this.rbUsuariosApellido.Location = new System.Drawing.Point(229, 18);
            this.rbUsuariosApellido.Name = "rbUsuariosApellido";
            this.rbUsuariosApellido.Size = new System.Drawing.Size(85, 17);
            this.rbUsuariosApellido.TabIndex = 29;
            this.rbUsuariosApellido.Text = "radioButton2";
            this.rbUsuariosApellido.UseVisualStyleBackColor = true;
            this.rbUsuariosApellido.CheckedChanged += new System.EventHandler(this.rbUsuariosApellido_CheckedChanged);
            // 
            // rbUsuariosNombreReal
            // 
            this.rbUsuariosNombreReal.AutoSize = true;
            this.rbUsuariosNombreReal.Location = new System.Drawing.Point(229, 41);
            this.rbUsuariosNombreReal.Name = "rbUsuariosNombreReal";
            this.rbUsuariosNombreReal.Size = new System.Drawing.Size(85, 17);
            this.rbUsuariosNombreReal.TabIndex = 28;
            this.rbUsuariosNombreReal.Text = "radioButton1";
            this.rbUsuariosNombreReal.UseVisualStyleBackColor = true;
            this.rbUsuariosNombreReal.CheckedChanged += new System.EventHandler(this.rbUsuariosNombreReal_CheckedChanged);
            // 
            // rbUsuariosNombre
            // 
            this.rbUsuariosNombre.AutoSize = true;
            this.rbUsuariosNombre.Location = new System.Drawing.Point(6, 42);
            this.rbUsuariosNombre.Name = "rbUsuariosNombre";
            this.rbUsuariosNombre.Size = new System.Drawing.Size(93, 17);
            this.rbUsuariosNombre.TabIndex = 27;
            this.rbUsuariosNombre.Text = "rbAlumnosDNI";
            this.rbUsuariosNombre.UseVisualStyleBackColor = true;
            this.rbUsuariosNombre.CheckedChanged += new System.EventHandler(this.rbUsuariosNombre_CheckedChanged);
            // 
            // rbUsuariosTodos
            // 
            this.rbUsuariosTodos.AutoSize = true;
            this.rbUsuariosTodos.Checked = true;
            this.rbUsuariosTodos.Location = new System.Drawing.Point(6, 19);
            this.rbUsuariosTodos.Name = "rbUsuariosTodos";
            this.rbUsuariosTodos.Size = new System.Drawing.Size(106, 17);
            this.rbUsuariosTodos.TabIndex = 26;
            this.rbUsuariosTodos.TabStop = true;
            this.rbUsuariosTodos.Text = "rbAlumnosLegajo";
            this.rbUsuariosTodos.UseVisualStyleBackColor = true;
            this.rbUsuariosTodos.CheckedChanged += new System.EventHandler(this.rbUsuariosTodos_CheckedChanged);
            // 
            // gpUsuariosActivos
            // 
            this.gpUsuariosActivos.Controls.Add(this.rbUsuariosInactivos);
            this.gpUsuariosActivos.Controls.Add(this.rbUsuariosActivos);
            this.gpUsuariosActivos.Location = new System.Drawing.Point(322, 235);
            this.gpUsuariosActivos.Name = "gpUsuariosActivos";
            this.gpUsuariosActivos.Size = new System.Drawing.Size(106, 67);
            this.gpUsuariosActivos.TabIndex = 31;
            this.gpUsuariosActivos.TabStop = false;
            this.gpUsuariosActivos.Text = "groupBox1";
            // 
            // rbUsuariosInactivos
            // 
            this.rbUsuariosInactivos.AutoSize = true;
            this.rbUsuariosInactivos.Location = new System.Drawing.Point(6, 44);
            this.rbUsuariosInactivos.Name = "rbUsuariosInactivos";
            this.rbUsuariosInactivos.Size = new System.Drawing.Size(85, 17);
            this.rbUsuariosInactivos.TabIndex = 25;
            this.rbUsuariosInactivos.Text = "radioButton2";
            this.rbUsuariosInactivos.UseVisualStyleBackColor = true;
            this.rbUsuariosInactivos.CheckedChanged += new System.EventHandler(this.rbUsuariosInactivos_CheckedChanged);
            // 
            // rbUsuariosActivos
            // 
            this.rbUsuariosActivos.AutoSize = true;
            this.rbUsuariosActivos.Checked = true;
            this.rbUsuariosActivos.Location = new System.Drawing.Point(6, 21);
            this.rbUsuariosActivos.Name = "rbUsuariosActivos";
            this.rbUsuariosActivos.Size = new System.Drawing.Size(85, 17);
            this.rbUsuariosActivos.TabIndex = 24;
            this.rbUsuariosActivos.TabStop = true;
            this.rbUsuariosActivos.Text = "radioButton1";
            this.rbUsuariosActivos.UseVisualStyleBackColor = true;
            this.rbUsuariosActivos.CheckedChanged += new System.EventHandler(this.rbUsuariosActivos_CheckedChanged);
            // 
            // btnDarDeBajaUsuario
            // 
            this.btnDarDeBajaUsuario.Location = new System.Drawing.Point(12, 235);
            this.btnDarDeBajaUsuario.Name = "btnDarDeBajaUsuario";
            this.btnDarDeBajaUsuario.Size = new System.Drawing.Size(93, 52);
            this.btnDarDeBajaUsuario.TabIndex = 33;
            this.btnDarDeBajaUsuario.Text = "button1";
            this.btnDarDeBajaUsuario.UseVisualStyleBackColor = true;
            this.btnDarDeBajaUsuario.Click += new System.EventHandler(this.btnDarDeBajaUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(111, 235);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(93, 52);
            this.btnModificarUsuario.TabIndex = 34;
            this.btnModificarUsuario.Text = "button2";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(437, 305);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(35, 13);
            this.lblBuscar.TabIndex = 35;
            this.lblBuscar.Text = "label1";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(440, 321);
            this.txtBoxBuscar.MaxLength = 50;
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(99, 20);
            this.txtBoxBuscar.TabIndex = 36;
            this.txtBoxBuscar.TextChanged += new System.EventHandler(this.txtBoxBuscar_TextChanged);
            // 
            // btnModificarContraseña
            // 
            this.btnModificarContraseña.Location = new System.Drawing.Point(210, 235);
            this.btnModificarContraseña.Name = "btnModificarContraseña";
            this.btnModificarContraseña.Size = new System.Drawing.Size(93, 52);
            this.btnModificarContraseña.TabIndex = 37;
            this.btnModificarContraseña.Text = "button2";
            this.btnModificarContraseña.UseVisualStyleBackColor = true;
            this.btnModificarContraseña.Click += new System.EventHandler(this.btnModificarContraseña_Click);
            // 
            // btnDarDeAltaUsuario
            // 
            this.btnDarDeAltaUsuario.Location = new System.Drawing.Point(12, 235);
            this.btnDarDeAltaUsuario.Name = "btnDarDeAltaUsuario";
            this.btnDarDeAltaUsuario.Size = new System.Drawing.Size(93, 52);
            this.btnDarDeAltaUsuario.TabIndex = 38;
            this.btnDarDeAltaUsuario.Text = "button1";
            this.btnDarDeAltaUsuario.UseVisualStyleBackColor = true;
            this.btnDarDeAltaUsuario.Click += new System.EventHandler(this.btnDarDeAltaUsuario_Click);
            // 
            // FormVerUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 350);
            this.Controls.Add(this.btnDarDeAltaUsuario);
            this.Controls.Add(this.btnModificarContraseña);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnDarDeBajaUsuario);
            this.Controls.Add(this.gpVisualizacion);
            this.Controls.Add(this.gpUsuariosActivos);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "FormVerUsuarios";
            this.Text = "FormVerUsuarioscs";
            this.Load += new System.EventHandler(this.FormVerUsuarioscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gpVisualizacion.ResumeLayout(false);
            this.gpVisualizacion.PerformLayout();
            this.gpUsuariosActivos.ResumeLayout(false);
            this.gpUsuariosActivos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVUsuarios_Col_Nombre_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVUsuarios_Col_Rol_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVUsuarios_Col_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVUsuarios_Col_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVUsuarios_Col_Nombre_Real;
        private System.Windows.Forms.GroupBox gpVisualizacion;
        private System.Windows.Forms.RadioButton rbUsuariosRol;
        private System.Windows.Forms.RadioButton rbUsuariosDNI;
        private System.Windows.Forms.RadioButton rbUsuariosApellido;
        private System.Windows.Forms.RadioButton rbUsuariosNombreReal;
        private System.Windows.Forms.RadioButton rbUsuariosNombre;
        private System.Windows.Forms.RadioButton rbUsuariosTodos;
        private System.Windows.Forms.GroupBox gpUsuariosActivos;
        private System.Windows.Forms.RadioButton rbUsuariosInactivos;
        private System.Windows.Forms.RadioButton rbUsuariosActivos;
        private System.Windows.Forms.Button btnDarDeBajaUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Button btnModificarContraseña;
        private System.Windows.Forms.Button btnDarDeAltaUsuario;
    }
}