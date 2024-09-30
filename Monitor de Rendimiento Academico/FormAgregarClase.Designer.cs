
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormAgregarClase
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
            this.btnAgregarClase = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.btnEliminarTema = new System.Windows.Forms.Button();
            this.btnAgregarTema = new System.Windows.Forms.Button();
            this.lblTemasDeClase = new System.Windows.Forms.Label();
            this.lblTemasDeMateria = new System.Windows.Forms.Label();
            this.listBoxTemasClase = new System.Windows.Forms.ListBox();
            this.listBoxTemasMateria = new System.Windows.Forms.ListBox();
            this.SelectorFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAgregarClase
            // 
            this.btnAgregarClase.Location = new System.Drawing.Point(12, 236);
            this.btnAgregarClase.Name = "btnAgregarClase";
            this.btnAgregarClase.Size = new System.Drawing.Size(110, 48);
            this.btnAgregarClase.TabIndex = 14;
            this.btnAgregarClase.Text = "button1";
            this.btnAgregarClase.UseVisualStyleBackColor = true;
            this.btnAgregarClase.Click += new System.EventHandler(this.btnAgregarClase_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(90, 13);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "Codigo del Curso:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 64);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(90, 13);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Codigo del Curso:";
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(12, 80);
            this.txtBoxDescripcion.MaxLength = 77;
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(133, 150);
            this.txtBoxDescripcion.TabIndex = 9;
            // 
            // btnEliminarTema
            // 
            this.btnEliminarTema.Location = new System.Drawing.Point(402, 236);
            this.btnEliminarTema.Name = "btnEliminarTema";
            this.btnEliminarTema.Size = new System.Drawing.Size(87, 37);
            this.btnEliminarTema.TabIndex = 26;
            this.btnEliminarTema.Text = "button3";
            this.btnEliminarTema.UseVisualStyleBackColor = true;
            this.btnEliminarTema.Click += new System.EventHandler(this.btnEliminarTema_Click);
            // 
            // btnAgregarTema
            // 
            this.btnAgregarTema.Location = new System.Drawing.Point(222, 236);
            this.btnAgregarTema.Name = "btnAgregarTema";
            this.btnAgregarTema.Size = new System.Drawing.Size(87, 37);
            this.btnAgregarTema.TabIndex = 25;
            this.btnAgregarTema.Text = "button2";
            this.btnAgregarTema.UseVisualStyleBackColor = true;
            this.btnAgregarTema.Click += new System.EventHandler(this.btnAgregarTema_Click);
            // 
            // lblTemasDeClase
            // 
            this.lblTemasDeClase.AutoSize = true;
            this.lblTemasDeClase.Location = new System.Drawing.Point(399, 15);
            this.lblTemasDeClase.Name = "lblTemasDeClase";
            this.lblTemasDeClase.Size = new System.Drawing.Size(35, 13);
            this.lblTemasDeClase.TabIndex = 24;
            this.lblTemasDeClase.Text = "label1";
            // 
            // lblTemasDeMateria
            // 
            this.lblTemasDeMateria.AutoSize = true;
            this.lblTemasDeMateria.Location = new System.Drawing.Point(219, 15);
            this.lblTemasDeMateria.Name = "lblTemasDeMateria";
            this.lblTemasDeMateria.Size = new System.Drawing.Size(35, 13);
            this.lblTemasDeMateria.TabIndex = 23;
            this.lblTemasDeMateria.Text = "label1";
            // 
            // listBoxTemasClase
            // 
            this.listBoxTemasClase.FormattingEnabled = true;
            this.listBoxTemasClase.Location = new System.Drawing.Point(402, 31);
            this.listBoxTemasClase.Name = "listBoxTemasClase";
            this.listBoxTemasClase.Size = new System.Drawing.Size(165, 199);
            this.listBoxTemasClase.TabIndex = 22;
            // 
            // listBoxTemasMateria
            // 
            this.listBoxTemasMateria.FormattingEnabled = true;
            this.listBoxTemasMateria.Location = new System.Drawing.Point(222, 31);
            this.listBoxTemasMateria.Name = "listBoxTemasMateria";
            this.listBoxTemasMateria.Size = new System.Drawing.Size(165, 199);
            this.listBoxTemasMateria.TabIndex = 21;
            // 
            // SelectorFechaIngreso
            // 
            this.SelectorFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SelectorFechaIngreso.Location = new System.Drawing.Point(12, 31);
            this.SelectorFechaIngreso.Name = "SelectorFechaIngreso";
            this.SelectorFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.SelectorFechaIngreso.TabIndex = 54;
            // 
            // FormAgregarClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 296);
            this.Controls.Add(this.SelectorFechaIngreso);
            this.Controls.Add(this.btnEliminarTema);
            this.Controls.Add(this.btnAgregarTema);
            this.Controls.Add(this.lblTemasDeClase);
            this.Controls.Add(this.lblTemasDeMateria);
            this.Controls.Add(this.listBoxTemasClase);
            this.Controls.Add(this.listBoxTemasMateria);
            this.Controls.Add(this.btnAgregarClase);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Name = "FormAgregarClase";
            this.Text = "FormAgregarClase";
            this.Load += new System.EventHandler(this.FormAgregarClase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarClase;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Button btnEliminarTema;
        private System.Windows.Forms.Button btnAgregarTema;
        private System.Windows.Forms.Label lblTemasDeClase;
        private System.Windows.Forms.Label lblTemasDeMateria;
        private System.Windows.Forms.ListBox listBoxTemasClase;
        private System.Windows.Forms.ListBox listBoxTemasMateria;
        private System.Windows.Forms.DateTimePicker SelectorFechaIngreso;
    }
}