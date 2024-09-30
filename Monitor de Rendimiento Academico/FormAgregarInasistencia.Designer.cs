
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormAgregarInasistencia
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
            this.btnEnviarInasistencia = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.txtBoxValor = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.lblJustificacion = new System.Windows.Forms.Label();
            this.txtBoxJustificacion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SelectorFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnEnviarInasistencia
            // 
            this.btnEnviarInasistencia.Location = new System.Drawing.Point(271, 256);
            this.btnEnviarInasistencia.Name = "btnEnviarInasistencia";
            this.btnEnviarInasistencia.Size = new System.Drawing.Size(119, 47);
            this.btnEnviarInasistencia.TabIndex = 49;
            this.btnEnviarInasistencia.Text = "button1";
            this.btnEnviarInasistencia.UseVisualStyleBackColor = true;
            this.btnEnviarInasistencia.Click += new System.EventHandler(this.btnEnviarInasistencia_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(144, 73);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(20, 23);
            this.btnRestar.TabIndex = 48;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(118, 73);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(20, 23);
            this.btnSumar.TabIndex = 47;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // txtBoxValor
            // 
            this.txtBoxValor.BackColor = System.Drawing.Color.White;
            this.txtBoxValor.Location = new System.Drawing.Point(12, 75);
            this.txtBoxValor.MaxLength = 77;
            this.txtBoxValor.Name = "txtBoxValor";
            this.txtBoxValor.ReadOnly = true;
            this.txtBoxValor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValor.TabIndex = 46;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(12, 139);
            this.txtBoxDescripcion.MaxLength = 77;
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(201, 61);
            this.txtBoxDescripcion.TabIndex = 45;
            // 
            // lblJustificacion
            // 
            this.lblJustificacion.AutoSize = true;
            this.lblJustificacion.Location = new System.Drawing.Point(12, 216);
            this.lblJustificacion.Name = "lblJustificacion";
            this.lblJustificacion.Size = new System.Drawing.Size(35, 13);
            this.lblJustificacion.TabIndex = 44;
            this.lblJustificacion.Text = "label3";
            // 
            // txtBoxJustificacion
            // 
            this.txtBoxJustificacion.Location = new System.Drawing.Point(12, 232);
            this.txtBoxJustificacion.MaxLength = 77;
            this.txtBoxJustificacion.Multiline = true;
            this.txtBoxJustificacion.Name = "txtBoxJustificacion";
            this.txtBoxJustificacion.Size = new System.Drawing.Size(201, 71);
            this.txtBoxJustificacion.TabIndex = 43;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 123);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(35, 13);
            this.lblDescripcion.TabIndex = 42;
            this.lblDescripcion.Text = "label3";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 59);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(35, 13);
            this.lblValor.TabIndex = 41;
            this.lblValor.Text = "label3";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 10);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 39;
            this.lblFecha.Text = "label3";
            // 
            // SelectorFecha
            // 
            this.SelectorFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SelectorFecha.Location = new System.Drawing.Point(12, 26);
            this.SelectorFecha.Name = "SelectorFecha";
            this.SelectorFecha.Size = new System.Drawing.Size(100, 20);
            this.SelectorFecha.TabIndex = 50;
            // 
            // FormAgregarInasistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 314);
            this.Controls.Add(this.SelectorFecha);
            this.Controls.Add(this.btnEnviarInasistencia);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtBoxValor);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.lblJustificacion);
            this.Controls.Add(this.txtBoxJustificacion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblFecha);
            this.Name = "FormAgregarInasistencia";
            this.Text = "FormAgregarInasistencia";
            this.Load += new System.EventHandler(this.FormAgregarInasistencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarInasistencia;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.TextBox txtBoxValor;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Label lblJustificacion;
        private System.Windows.Forms.TextBox txtBoxJustificacion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker SelectorFecha;
    }
}