
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormModificarEvaluacion
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
            this.btnEliminarTema = new System.Windows.Forms.Button();
            this.btnAgregarTema = new System.Windows.Forms.Button();
            this.lblTemasDeEvaluacion = new System.Windows.Forms.Label();
            this.lblTemasDeMateria = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnModificarEvaluacion = new System.Windows.Forms.Button();
            this.listBoxTemasEvaluacion = new System.Windows.Forms.ListBox();
            this.listBoxTemasMateria = new System.Windows.Forms.ListBox();
            this.txtBoxTitulo = new System.Windows.Forms.TextBox();
            this.lblTituloEval = new System.Windows.Forms.Label();
            this.SelectorFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnEliminarTema
            // 
            this.btnEliminarTema.Location = new System.Drawing.Point(346, 230);
            this.btnEliminarTema.Name = "btnEliminarTema";
            this.btnEliminarTema.Size = new System.Drawing.Size(87, 37);
            this.btnEliminarTema.TabIndex = 17;
            this.btnEliminarTema.Text = "button3";
            this.btnEliminarTema.UseVisualStyleBackColor = true;
            this.btnEliminarTema.Click += new System.EventHandler(this.btnEliminarTema_Click);
            // 
            // btnAgregarTema
            // 
            this.btnAgregarTema.Location = new System.Drawing.Point(166, 230);
            this.btnAgregarTema.Name = "btnAgregarTema";
            this.btnAgregarTema.Size = new System.Drawing.Size(87, 37);
            this.btnAgregarTema.TabIndex = 16;
            this.btnAgregarTema.Text = "button2";
            this.btnAgregarTema.UseVisualStyleBackColor = true;
            this.btnAgregarTema.Click += new System.EventHandler(this.btnAgregarTema_Click);
            // 
            // lblTemasDeEvaluacion
            // 
            this.lblTemasDeEvaluacion.AutoSize = true;
            this.lblTemasDeEvaluacion.Location = new System.Drawing.Point(343, 9);
            this.lblTemasDeEvaluacion.Name = "lblTemasDeEvaluacion";
            this.lblTemasDeEvaluacion.Size = new System.Drawing.Size(35, 13);
            this.lblTemasDeEvaluacion.TabIndex = 15;
            this.lblTemasDeEvaluacion.Text = "label1";
            // 
            // lblTemasDeMateria
            // 
            this.lblTemasDeMateria.AutoSize = true;
            this.lblTemasDeMateria.Location = new System.Drawing.Point(163, 9);
            this.lblTemasDeMateria.Name = "lblTemasDeMateria";
            this.lblTemasDeMateria.Size = new System.Drawing.Size(35, 13);
            this.lblTemasDeMateria.TabIndex = 14;
            this.lblTemasDeMateria.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 65);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "label1";
            // 
            // btnModificarEvaluacion
            // 
            this.btnModificarEvaluacion.Location = new System.Drawing.Point(12, 246);
            this.btnModificarEvaluacion.Name = "btnModificarEvaluacion";
            this.btnModificarEvaluacion.Size = new System.Drawing.Size(85, 57);
            this.btnModificarEvaluacion.TabIndex = 12;
            this.btnModificarEvaluacion.Text = "button1";
            this.btnModificarEvaluacion.UseVisualStyleBackColor = true;
            this.btnModificarEvaluacion.Click += new System.EventHandler(this.btnModificarEvaluacion_Click);
            // 
            // listBoxTemasEvaluacion
            // 
            this.listBoxTemasEvaluacion.FormattingEnabled = true;
            this.listBoxTemasEvaluacion.Location = new System.Drawing.Point(346, 25);
            this.listBoxTemasEvaluacion.Name = "listBoxTemasEvaluacion";
            this.listBoxTemasEvaluacion.Size = new System.Drawing.Size(165, 199);
            this.listBoxTemasEvaluacion.TabIndex = 11;
            // 
            // listBoxTemasMateria
            // 
            this.listBoxTemasMateria.FormattingEnabled = true;
            this.listBoxTemasMateria.Location = new System.Drawing.Point(166, 25);
            this.listBoxTemasMateria.Name = "listBoxTemasMateria";
            this.listBoxTemasMateria.Size = new System.Drawing.Size(165, 199);
            this.listBoxTemasMateria.TabIndex = 10;
            // 
            // txtBoxTitulo
            // 
            this.txtBoxTitulo.Location = new System.Drawing.Point(12, 34);
            this.txtBoxTitulo.Name = "txtBoxTitulo";
            this.txtBoxTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTitulo.TabIndex = 19;
            // 
            // lblTituloEval
            // 
            this.lblTituloEval.AutoSize = true;
            this.lblTituloEval.Location = new System.Drawing.Point(12, 18);
            this.lblTituloEval.Name = "lblTituloEval";
            this.lblTituloEval.Size = new System.Drawing.Size(35, 13);
            this.lblTituloEval.TabIndex = 20;
            this.lblTituloEval.Text = "label1";
            // 
            // SelectorFechaIngreso
            // 
            this.SelectorFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SelectorFechaIngreso.Location = new System.Drawing.Point(12, 81);
            this.SelectorFechaIngreso.Name = "SelectorFechaIngreso";
            this.SelectorFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.SelectorFechaIngreso.TabIndex = 54;
            // 
            // FormModificarEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 315);
            this.Controls.Add(this.SelectorFechaIngreso);
            this.Controls.Add(this.lblTituloEval);
            this.Controls.Add(this.txtBoxTitulo);
            this.Controls.Add(this.btnEliminarTema);
            this.Controls.Add(this.btnAgregarTema);
            this.Controls.Add(this.lblTemasDeEvaluacion);
            this.Controls.Add(this.lblTemasDeMateria);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnModificarEvaluacion);
            this.Controls.Add(this.listBoxTemasEvaluacion);
            this.Controls.Add(this.listBoxTemasMateria);
            this.Name = "FormModificarEvaluacion";
            this.Text = "FormModificarEvaluacion";
            this.Load += new System.EventHandler(this.FormModificarEvaluacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarTema;
        private System.Windows.Forms.Button btnAgregarTema;
        private System.Windows.Forms.Label lblTemasDeEvaluacion;
        private System.Windows.Forms.Label lblTemasDeMateria;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnModificarEvaluacion;
        private System.Windows.Forms.ListBox listBoxTemasEvaluacion;
        private System.Windows.Forms.ListBox listBoxTemasMateria;
        private System.Windows.Forms.TextBox txtBoxTitulo;
        private System.Windows.Forms.Label lblTituloEval;
        private System.Windows.Forms.DateTimePicker SelectorFechaIngreso;
    }
}