
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerBitacoraDeCambios
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
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.DGV_Bitacora_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Bitacora_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Bitacora_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Bitacora_Nivel_Importancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Bitacora_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.gpConsultas = new System.Windows.Forms.GroupBox();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.txtBoxFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVerModificacionesUs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.gpConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Bitacora_ID,
            this.DGV_Bitacora_Descripcion,
            this.DGV_Bitacora_Fecha,
            this.DGV_Bitacora_Nivel_Importancia,
            this.DGV_Bitacora_Usuario});
            this.dgvBitacora.Location = new System.Drawing.Point(12, 12);
            this.dgvBitacora.MultiSelect = false;
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacora.Size = new System.Drawing.Size(819, 260);
            this.dgvBitacora.TabIndex = 20;
            this.dgvBitacora.TabStop = false;
            this.dgvBitacora.Click += new System.EventHandler(this.dgvBitacora_Click);
            // 
            // DGV_Bitacora_ID
            // 
            this.DGV_Bitacora_ID.HeaderText = "Column1";
            this.DGV_Bitacora_ID.Name = "DGV_Bitacora_ID";
            this.DGV_Bitacora_ID.ReadOnly = true;
            // 
            // DGV_Bitacora_Descripcion
            // 
            this.DGV_Bitacora_Descripcion.HeaderText = "Column1";
            this.DGV_Bitacora_Descripcion.Name = "DGV_Bitacora_Descripcion";
            this.DGV_Bitacora_Descripcion.ReadOnly = true;
            // 
            // DGV_Bitacora_Fecha
            // 
            this.DGV_Bitacora_Fecha.HeaderText = "Column1";
            this.DGV_Bitacora_Fecha.Name = "DGV_Bitacora_Fecha";
            this.DGV_Bitacora_Fecha.ReadOnly = true;
            // 
            // DGV_Bitacora_Nivel_Importancia
            // 
            this.DGV_Bitacora_Nivel_Importancia.HeaderText = "Column1";
            this.DGV_Bitacora_Nivel_Importancia.Name = "DGV_Bitacora_Nivel_Importancia";
            this.DGV_Bitacora_Nivel_Importancia.ReadOnly = true;
            // 
            // DGV_Bitacora_Usuario
            // 
            this.DGV_Bitacora_Usuario.HeaderText = "Column1";
            this.DGV_Bitacora_Usuario.Name = "DGV_Bitacora_Usuario";
            this.DGV_Bitacora_Usuario.ReadOnly = true;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(12, 286);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(35, 13);
            this.lblDNI.TabIndex = 21;
            this.lblDNI.Text = "label1";
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.BackColor = System.Drawing.Color.White;
            this.txtBoxDNI.Location = new System.Drawing.Point(12, 302);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.ReadOnly = true;
            this.txtBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDNI.TabIndex = 22;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.BackColor = System.Drawing.Color.White;
            this.txtBoxNombre.Location = new System.Drawing.Point(12, 382);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.ReadOnly = true;
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 24;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 366);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "label1";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.BackColor = System.Drawing.Color.White;
            this.txtBoxApellido.Location = new System.Drawing.Point(12, 343);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.ReadOnly = true;
            this.txtBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellido.TabIndex = 26;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 327);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(35, 13);
            this.lblApellido.TabIndex = 25;
            this.lblApellido.Text = "label1";
            // 
            // gpConsultas
            // 
            this.gpConsultas.Controls.Add(this.rbFecha);
            this.gpConsultas.Controls.Add(this.rbTodos);
            this.gpConsultas.Location = new System.Drawing.Point(735, 286);
            this.gpConsultas.Name = "gpConsultas";
            this.gpConsultas.Size = new System.Drawing.Size(96, 77);
            this.gpConsultas.TabIndex = 27;
            this.gpConsultas.TabStop = false;
            this.gpConsultas.Text = "groupBox1";
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Location = new System.Drawing.Point(6, 41);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(85, 17);
            this.rbFecha.TabIndex = 1;
            this.rbFecha.Text = "radioButton2";
            this.rbFecha.UseVisualStyleBackColor = true;
            this.rbFecha.CheckedChanged += new System.EventHandler(this.rbFecha_CheckedChanged);
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
            // txtBoxFecha
            // 
            this.txtBoxFecha.Location = new System.Drawing.Point(629, 343);
            this.txtBoxFecha.Name = "txtBoxFecha";
            this.txtBoxFecha.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFecha.TabIndex = 28;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(626, 327);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(35, 13);
            this.lblBuscar.TabIndex = 29;
            this.lblBuscar.Text = "label1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(629, 369);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(52, 25);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "button1";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVerModificacionesUs
            // 
            this.btnVerModificacionesUs.Location = new System.Drawing.Point(136, 278);
            this.btnVerModificacionesUs.Name = "btnVerModificacionesUs";
            this.btnVerModificacionesUs.Size = new System.Drawing.Size(120, 44);
            this.btnVerModificacionesUs.TabIndex = 31;
            this.btnVerModificacionesUs.Text = "button1";
            this.btnVerModificacionesUs.UseVisualStyleBackColor = true;
            this.btnVerModificacionesUs.Click += new System.EventHandler(this.btnVerModificacionesUs_Click);
            // 
            // FormVerBitacoraDeCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(843, 414);
            this.Controls.Add(this.btnVerModificacionesUs);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBoxFecha);
            this.Controls.Add(this.gpConsultas);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.dgvBitacora);
            this.Name = "FormVerBitacoraDeCambios";
            this.Text = "FormVerBitacoraDeCambios";
            this.Load += new System.EventHandler(this.FormVerBitacoraDeCambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.gpConsultas.ResumeLayout(false);
            this.gpConsultas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Bitacora_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Bitacora_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Bitacora_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Bitacora_Nivel_Importancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Bitacora_Usuario;
        private System.Windows.Forms.GroupBox gpConsultas;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.MaskedTextBox txtBoxFecha;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVerModificacionesUs;
    }
}