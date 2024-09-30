
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormAgregarDocente
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
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtBoxLegajo = new System.Windows.Forms.TextBox();
            this.lblAluLegajo = new System.Windows.Forms.Label();
            this.dgvUsuariosHabilitados = new System.Windows.Forms.DataGridView();
            this.DGV_UsuariosActivos_Col_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_UsuariosActivos_Col_NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_UsuariosActivos_Col_Nombre_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_UsuariosActivos_Col_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrearDocente = new System.Windows.Forms.Button();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.gpVisualizacion = new System.Windows.Forms.GroupBox();
            this.rbUsuariosRol = new System.Windows.Forms.RadioButton();
            this.rbUsuariosDNI = new System.Windows.Forms.RadioButton();
            this.rbUsuariosApellido = new System.Windows.Forms.RadioButton();
            this.rbUsuariosNombreReal = new System.Windows.Forms.RadioButton();
            this.rbUsuariosNombre = new System.Windows.Forms.RadioButton();
            this.rbUsuariosTodos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosHabilitados)).BeginInit();
            this.gpVisualizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(12, 186);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.ReadOnly = true;
            this.txtBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellido.TabIndex = 19;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 170);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(35, 13);
            this.lblApellido.TabIndex = 18;
            this.lblApellido.Text = "label4";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(12, 137);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.ReadOnly = true;
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 17;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 121);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "label3";
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Location = new System.Drawing.Point(12, 84);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.ReadOnly = true;
            this.txtBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDNI.TabIndex = 15;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(12, 68);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(35, 13);
            this.lblDNI.TabIndex = 14;
            this.lblDNI.Text = "label2";
            // 
            // txtBoxLegajo
            // 
            this.txtBoxLegajo.Location = new System.Drawing.Point(12, 33);
            this.txtBoxLegajo.Name = "txtBoxLegajo";
            this.txtBoxLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLegajo.TabIndex = 13;
            // 
            // lblAluLegajo
            // 
            this.lblAluLegajo.AutoSize = true;
            this.lblAluLegajo.Location = new System.Drawing.Point(12, 17);
            this.lblAluLegajo.Name = "lblAluLegajo";
            this.lblAluLegajo.Size = new System.Drawing.Size(35, 13);
            this.lblAluLegajo.TabIndex = 12;
            this.lblAluLegajo.Text = "label1";
            // 
            // dgvUsuariosHabilitados
            // 
            this.dgvUsuariosHabilitados.AllowUserToAddRows = false;
            this.dgvUsuariosHabilitados.AllowUserToDeleteRows = false;
            this.dgvUsuariosHabilitados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuariosHabilitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosHabilitados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_UsuariosActivos_Col_Codigo,
            this.DGV_UsuariosActivos_Col_NombreUsuario,
            this.DGV_UsuariosActivos_Col_Nombre_Apellido,
            this.DGV_UsuariosActivos_Col_Rol});
            this.dgvUsuariosHabilitados.Location = new System.Drawing.Point(200, 17);
            this.dgvUsuariosHabilitados.MultiSelect = false;
            this.dgvUsuariosHabilitados.Name = "dgvUsuariosHabilitados";
            this.dgvUsuariosHabilitados.ReadOnly = true;
            this.dgvUsuariosHabilitados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuariosHabilitados.Size = new System.Drawing.Size(415, 237);
            this.dgvUsuariosHabilitados.TabIndex = 20;
            this.dgvUsuariosHabilitados.TabStop = false;
            this.dgvUsuariosHabilitados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosHabilitados_CellClick);
            // 
            // DGV_UsuariosActivos_Col_Codigo
            // 
            this.DGV_UsuariosActivos_Col_Codigo.HeaderText = "Column1";
            this.DGV_UsuariosActivos_Col_Codigo.Name = "DGV_UsuariosActivos_Col_Codigo";
            this.DGV_UsuariosActivos_Col_Codigo.ReadOnly = true;
            // 
            // DGV_UsuariosActivos_Col_NombreUsuario
            // 
            this.DGV_UsuariosActivos_Col_NombreUsuario.HeaderText = "Column1";
            this.DGV_UsuariosActivos_Col_NombreUsuario.Name = "DGV_UsuariosActivos_Col_NombreUsuario";
            this.DGV_UsuariosActivos_Col_NombreUsuario.ReadOnly = true;
            // 
            // DGV_UsuariosActivos_Col_Nombre_Apellido
            // 
            this.DGV_UsuariosActivos_Col_Nombre_Apellido.HeaderText = "Column1";
            this.DGV_UsuariosActivos_Col_Nombre_Apellido.Name = "DGV_UsuariosActivos_Col_Nombre_Apellido";
            this.DGV_UsuariosActivos_Col_Nombre_Apellido.ReadOnly = true;
            // 
            // DGV_UsuariosActivos_Col_Rol
            // 
            this.DGV_UsuariosActivos_Col_Rol.HeaderText = "Column1";
            this.DGV_UsuariosActivos_Col_Rol.Name = "DGV_UsuariosActivos_Col_Rol";
            this.DGV_UsuariosActivos_Col_Rol.ReadOnly = true;
            // 
            // btnCrearDocente
            // 
            this.btnCrearDocente.Location = new System.Drawing.Point(12, 242);
            this.btnCrearDocente.Name = "btnCrearDocente";
            this.btnCrearDocente.Size = new System.Drawing.Size(98, 47);
            this.btnCrearDocente.TabIndex = 21;
            this.btnCrearDocente.Text = "button2";
            this.btnCrearDocente.UseVisualStyleBackColor = true;
            this.btnCrearDocente.Click += new System.EventHandler(this.btnCrearDocente_Click);
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(206, 346);
            this.txtBoxBuscar.MaxLength = 50;
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(99, 20);
            this.txtBoxBuscar.TabIndex = 42;
            this.txtBoxBuscar.TextChanged += new System.EventHandler(this.txtBoxBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(203, 330);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(35, 13);
            this.lblBuscar.TabIndex = 41;
            this.lblBuscar.Text = "label1";
            // 
            // gpVisualizacion
            // 
            this.gpVisualizacion.Controls.Add(this.rbUsuariosRol);
            this.gpVisualizacion.Controls.Add(this.rbUsuariosDNI);
            this.gpVisualizacion.Controls.Add(this.rbUsuariosApellido);
            this.gpVisualizacion.Controls.Add(this.rbUsuariosNombreReal);
            this.gpVisualizacion.Controls.Add(this.rbUsuariosNombre);
            this.gpVisualizacion.Controls.Add(this.rbUsuariosTodos);
            this.gpVisualizacion.Location = new System.Drawing.Point(200, 260);
            this.gpVisualizacion.Name = "gpVisualizacion";
            this.gpVisualizacion.Size = new System.Drawing.Size(321, 67);
            this.gpVisualizacion.TabIndex = 40;
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
            // FormAgregarDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 369);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.gpVisualizacion);
            this.Controls.Add(this.btnCrearDocente);
            this.Controls.Add(this.dgvUsuariosHabilitados);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtBoxLegajo);
            this.Controls.Add(this.lblAluLegajo);
            this.Name = "FormAgregarDocente";
            this.Text = "FormAgregarDocente";
            this.Load += new System.EventHandler(this.FormAgregarDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosHabilitados)).EndInit();
            this.gpVisualizacion.ResumeLayout(false);
            this.gpVisualizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtBoxLegajo;
        private System.Windows.Forms.Label lblAluLegajo;
        private System.Windows.Forms.DataGridView dgvUsuariosHabilitados;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_UsuariosActivos_Col_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_UsuariosActivos_Col_NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_UsuariosActivos_Col_Nombre_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_UsuariosActivos_Col_Rol;
        private System.Windows.Forms.Button btnCrearDocente;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.GroupBox gpVisualizacion;
        private System.Windows.Forms.RadioButton rbUsuariosRol;
        private System.Windows.Forms.RadioButton rbUsuariosDNI;
        private System.Windows.Forms.RadioButton rbUsuariosApellido;
        private System.Windows.Forms.RadioButton rbUsuariosNombreReal;
        private System.Windows.Forms.RadioButton rbUsuariosNombre;
        private System.Windows.Forms.RadioButton rbUsuariosTodos;
    }
}