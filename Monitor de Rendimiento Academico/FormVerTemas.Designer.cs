
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerTemas
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
            this.dgvTemas = new System.Windows.Forms.DataGridView();
            this.DGV_Temas_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Temas_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrearTema = new System.Windows.Forms.Button();
            this.btnQuitarTemaDeMateria = new System.Windows.Forms.Button();
            this.btnModificarTema = new System.Windows.Forms.Button();
            this.btnAgregarAMateria = new System.Windows.Forms.Button();
            this.lblTodosTemas = new System.Windows.Forms.Label();
            this.lblTemasDeMateria = new System.Windows.Forms.Label();
            this.dgvTemasMateria = new System.Windows.Forms.DataGridView();
            this.DGV_Temas_Materia_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Temas_Materia_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxDescripcionTema = new System.Windows.Forms.TextBox();
            this.gpConsultas = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBoxBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemasMateria)).BeginInit();
            this.gpConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTemas
            // 
            this.dgvTemas.AllowUserToAddRows = false;
            this.dgvTemas.AllowUserToDeleteRows = false;
            this.dgvTemas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Temas_Codigo,
            this.DGV_Temas_Nombre});
            this.dgvTemas.Location = new System.Drawing.Point(12, 29);
            this.dgvTemas.MultiSelect = false;
            this.dgvTemas.Name = "dgvTemas";
            this.dgvTemas.ReadOnly = true;
            this.dgvTemas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTemas.Size = new System.Drawing.Size(507, 191);
            this.dgvTemas.TabIndex = 20;
            this.dgvTemas.TabStop = false;
            this.dgvTemas.Click += new System.EventHandler(this.dgvTemas_Click);
            // 
            // DGV_Temas_Codigo
            // 
            this.DGV_Temas_Codigo.HeaderText = "Column1";
            this.DGV_Temas_Codigo.Name = "DGV_Temas_Codigo";
            this.DGV_Temas_Codigo.ReadOnly = true;
            // 
            // DGV_Temas_Nombre
            // 
            this.DGV_Temas_Nombre.HeaderText = "Column1";
            this.DGV_Temas_Nombre.Name = "DGV_Temas_Nombre";
            this.DGV_Temas_Nombre.ReadOnly = true;
            // 
            // btnCrearTema
            // 
            this.btnCrearTema.Location = new System.Drawing.Point(12, 226);
            this.btnCrearTema.Name = "btnCrearTema";
            this.btnCrearTema.Size = new System.Drawing.Size(93, 49);
            this.btnCrearTema.TabIndex = 22;
            this.btnCrearTema.Text = "button1";
            this.btnCrearTema.UseVisualStyleBackColor = true;
            this.btnCrearTema.Click += new System.EventHandler(this.btnCrearTema_Click);
            // 
            // btnQuitarTemaDeMateria
            // 
            this.btnQuitarTemaDeMateria.Location = new System.Drawing.Point(593, 226);
            this.btnQuitarTemaDeMateria.Name = "btnQuitarTemaDeMateria";
            this.btnQuitarTemaDeMateria.Size = new System.Drawing.Size(93, 49);
            this.btnQuitarTemaDeMateria.TabIndex = 23;
            this.btnQuitarTemaDeMateria.Text = "button2";
            this.btnQuitarTemaDeMateria.UseVisualStyleBackColor = true;
            this.btnQuitarTemaDeMateria.Click += new System.EventHandler(this.btnQuitarTemaDeMateria_Click);
            // 
            // btnModificarTema
            // 
            this.btnModificarTema.Location = new System.Drawing.Point(111, 226);
            this.btnModificarTema.Name = "btnModificarTema";
            this.btnModificarTema.Size = new System.Drawing.Size(93, 49);
            this.btnModificarTema.TabIndex = 24;
            this.btnModificarTema.Text = "button3";
            this.btnModificarTema.UseVisualStyleBackColor = true;
            this.btnModificarTema.Click += new System.EventHandler(this.btnModificarTema_Click);
            // 
            // btnAgregarAMateria
            // 
            this.btnAgregarAMateria.Location = new System.Drawing.Point(210, 226);
            this.btnAgregarAMateria.Name = "btnAgregarAMateria";
            this.btnAgregarAMateria.Size = new System.Drawing.Size(93, 49);
            this.btnAgregarAMateria.TabIndex = 25;
            this.btnAgregarAMateria.Text = "button3";
            this.btnAgregarAMateria.UseVisualStyleBackColor = true;
            this.btnAgregarAMateria.Click += new System.EventHandler(this.btnAgregarAMateria_Click);
            // 
            // lblTodosTemas
            // 
            this.lblTodosTemas.AutoSize = true;
            this.lblTodosTemas.Location = new System.Drawing.Point(252, 9);
            this.lblTodosTemas.Name = "lblTodosTemas";
            this.lblTodosTemas.Size = new System.Drawing.Size(35, 13);
            this.lblTodosTemas.TabIndex = 26;
            this.lblTodosTemas.Text = "label1";
            // 
            // lblTemasDeMateria
            // 
            this.lblTemasDeMateria.AutoSize = true;
            this.lblTemasDeMateria.Location = new System.Drawing.Point(753, 9);
            this.lblTemasDeMateria.Name = "lblTemasDeMateria";
            this.lblTemasDeMateria.Size = new System.Drawing.Size(35, 13);
            this.lblTemasDeMateria.TabIndex = 27;
            this.lblTemasDeMateria.Text = "label1";
            // 
            // dgvTemasMateria
            // 
            this.dgvTemasMateria.AllowUserToAddRows = false;
            this.dgvTemasMateria.AllowUserToDeleteRows = false;
            this.dgvTemasMateria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTemasMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemasMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Temas_Materia_Codigo,
            this.DGV_Temas_Materia_Nombre});
            this.dgvTemasMateria.Location = new System.Drawing.Point(593, 29);
            this.dgvTemasMateria.MultiSelect = false;
            this.dgvTemasMateria.Name = "dgvTemasMateria";
            this.dgvTemasMateria.ReadOnly = true;
            this.dgvTemasMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTemasMateria.Size = new System.Drawing.Size(341, 191);
            this.dgvTemasMateria.TabIndex = 28;
            this.dgvTemasMateria.TabStop = false;
            // 
            // DGV_Temas_Materia_Codigo
            // 
            this.DGV_Temas_Materia_Codigo.HeaderText = "Column1";
            this.DGV_Temas_Materia_Codigo.Name = "DGV_Temas_Materia_Codigo";
            this.DGV_Temas_Materia_Codigo.ReadOnly = true;
            // 
            // DGV_Temas_Materia_Nombre
            // 
            this.DGV_Temas_Materia_Nombre.HeaderText = "Column1";
            this.DGV_Temas_Materia_Nombre.Name = "DGV_Temas_Materia_Nombre";
            this.DGV_Temas_Materia_Nombre.ReadOnly = true;
            // 
            // txtBoxDescripcionTema
            // 
            this.txtBoxDescripcionTema.BackColor = System.Drawing.Color.White;
            this.txtBoxDescripcionTema.Location = new System.Drawing.Point(12, 295);
            this.txtBoxDescripcionTema.Multiline = true;
            this.txtBoxDescripcionTema.Name = "txtBoxDescripcionTema";
            this.txtBoxDescripcionTema.ReadOnly = true;
            this.txtBoxDescripcionTema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDescripcionTema.Size = new System.Drawing.Size(291, 90);
            this.txtBoxDescripcionTema.TabIndex = 29;
            // 
            // gpConsultas
            // 
            this.gpConsultas.Controls.Add(this.rbNombre);
            this.gpConsultas.Controls.Add(this.rbCodigo);
            this.gpConsultas.Controls.Add(this.rbTodos);
            this.gpConsultas.Location = new System.Drawing.Point(309, 226);
            this.gpConsultas.Name = "gpConsultas";
            this.gpConsultas.Size = new System.Drawing.Size(210, 73);
            this.gpConsultas.TabIndex = 30;
            this.gpConsultas.TabStop = false;
            this.gpConsultas.Text = "groupBox1";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(6, 19);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(85, 17);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "radioButton1";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(6, 42);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(85, 17);
            this.rbCodigo.TabIndex = 1;
            this.rbCodigo.Text = "radioButton2";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbCodigo_CheckedChanged);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(97, 19);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(85, 17);
            this.rbNombre.TabIndex = 2;
            this.rbNombre.Text = "radioButton3";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(312, 304);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lblBusqueda.TabIndex = 38;
            this.lblBusqueda.Text = "label1";
            // 
            // txtBoxBusqueda
            // 
            this.txtBoxBusqueda.Location = new System.Drawing.Point(315, 320);
            this.txtBoxBusqueda.Name = "txtBoxBusqueda";
            this.txtBoxBusqueda.Size = new System.Drawing.Size(112, 20);
            this.txtBoxBusqueda.TabIndex = 37;
            this.txtBoxBusqueda.TextChanged += new System.EventHandler(this.txtBoxBusqueda_TextChanged);
            // 
            // FormVerTemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 404);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtBoxBusqueda);
            this.Controls.Add(this.gpConsultas);
            this.Controls.Add(this.txtBoxDescripcionTema);
            this.Controls.Add(this.dgvTemasMateria);
            this.Controls.Add(this.lblTemasDeMateria);
            this.Controls.Add(this.lblTodosTemas);
            this.Controls.Add(this.btnAgregarAMateria);
            this.Controls.Add(this.btnModificarTema);
            this.Controls.Add(this.btnQuitarTemaDeMateria);
            this.Controls.Add(this.btnCrearTema);
            this.Controls.Add(this.dgvTemas);
            this.Name = "FormVerTemas";
            this.Text = "FormVerTemas";
            this.Load += new System.EventHandler(this.FormVerTemas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemasMateria)).EndInit();
            this.gpConsultas.ResumeLayout(false);
            this.gpConsultas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTemas;
        private System.Windows.Forms.Button btnCrearTema;
        private System.Windows.Forms.Button btnQuitarTemaDeMateria;
        private System.Windows.Forms.Button btnModificarTema;
        private System.Windows.Forms.Button btnAgregarAMateria;
        private System.Windows.Forms.Label lblTodosTemas;
        private System.Windows.Forms.Label lblTemasDeMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Temas_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Temas_Nombre;
        private System.Windows.Forms.DataGridView dgvTemasMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Temas_Materia_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Temas_Materia_Nombre;
        private System.Windows.Forms.TextBox txtBoxDescripcionTema;
        private System.Windows.Forms.GroupBox gpConsultas;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBoxBusqueda;
    }
}