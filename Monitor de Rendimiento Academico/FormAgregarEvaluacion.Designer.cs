
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormAgregarEvaluacion
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
            this.listBoxTemasMateria = new System.Windows.Forms.ListBox();
            this.listBoxTemasEvaluacion = new System.Windows.Forms.ListBox();
            this.btnAgregarEvaluacion = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTemasDeMateria = new System.Windows.Forms.Label();
            this.lblTemasDeEvaluacion = new System.Windows.Forms.Label();
            this.btnAgregarTema = new System.Windows.Forms.Button();
            this.btnEliminarTema = new System.Windows.Forms.Button();
            this.lblTituloEval = new System.Windows.Forms.Label();
            this.txtBoxTituloEval = new System.Windows.Forms.TextBox();
            this.SelectorFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listBoxTemasMateria
            // 
            this.listBoxTemasMateria.FormattingEnabled = true;
            this.listBoxTemasMateria.Location = new System.Drawing.Point(164, 25);
            this.listBoxTemasMateria.Name = "listBoxTemasMateria";
            this.listBoxTemasMateria.Size = new System.Drawing.Size(165, 199);
            this.listBoxTemasMateria.TabIndex = 0;
            // 
            // listBoxTemasEvaluacion
            // 
            this.listBoxTemasEvaluacion.FormattingEnabled = true;
            this.listBoxTemasEvaluacion.Location = new System.Drawing.Point(344, 25);
            this.listBoxTemasEvaluacion.Name = "listBoxTemasEvaluacion";
            this.listBoxTemasEvaluacion.Size = new System.Drawing.Size(165, 199);
            this.listBoxTemasEvaluacion.TabIndex = 1;
            // 
            // btnAgregarEvaluacion
            // 
            this.btnAgregarEvaluacion.Location = new System.Drawing.Point(11, 246);
            this.btnAgregarEvaluacion.Name = "btnAgregarEvaluacion";
            this.btnAgregarEvaluacion.Size = new System.Drawing.Size(85, 57);
            this.btnAgregarEvaluacion.TabIndex = 3;
            this.btnAgregarEvaluacion.Text = "button1";
            this.btnAgregarEvaluacion.UseVisualStyleBackColor = true;
            this.btnAgregarEvaluacion.Click += new System.EventHandler(this.btnAgregarEvaluacion_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(9, 54);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "label1";
            // 
            // lblTemasDeMateria
            // 
            this.lblTemasDeMateria.AutoSize = true;
            this.lblTemasDeMateria.Location = new System.Drawing.Point(161, 9);
            this.lblTemasDeMateria.Name = "lblTemasDeMateria";
            this.lblTemasDeMateria.Size = new System.Drawing.Size(35, 13);
            this.lblTemasDeMateria.TabIndex = 5;
            this.lblTemasDeMateria.Text = "label1";
            // 
            // lblTemasDeEvaluacion
            // 
            this.lblTemasDeEvaluacion.AutoSize = true;
            this.lblTemasDeEvaluacion.Location = new System.Drawing.Point(341, 9);
            this.lblTemasDeEvaluacion.Name = "lblTemasDeEvaluacion";
            this.lblTemasDeEvaluacion.Size = new System.Drawing.Size(35, 13);
            this.lblTemasDeEvaluacion.TabIndex = 6;
            this.lblTemasDeEvaluacion.Text = "label1";
            // 
            // btnAgregarTema
            // 
            this.btnAgregarTema.Location = new System.Drawing.Point(164, 230);
            this.btnAgregarTema.Name = "btnAgregarTema";
            this.btnAgregarTema.Size = new System.Drawing.Size(87, 37);
            this.btnAgregarTema.TabIndex = 7;
            this.btnAgregarTema.Text = "button2";
            this.btnAgregarTema.UseVisualStyleBackColor = true;
            this.btnAgregarTema.Click += new System.EventHandler(this.btnAgregarTema_Click);
            // 
            // btnEliminarTema
            // 
            this.btnEliminarTema.Location = new System.Drawing.Point(344, 230);
            this.btnEliminarTema.Name = "btnEliminarTema";
            this.btnEliminarTema.Size = new System.Drawing.Size(87, 37);
            this.btnEliminarTema.TabIndex = 8;
            this.btnEliminarTema.Text = "button3";
            this.btnEliminarTema.UseVisualStyleBackColor = true;
            this.btnEliminarTema.Click += new System.EventHandler(this.btnEliminarTema_Click);
            // 
            // lblTituloEval
            // 
            this.lblTituloEval.AutoSize = true;
            this.lblTituloEval.Location = new System.Drawing.Point(9, 9);
            this.lblTituloEval.Name = "lblTituloEval";
            this.lblTituloEval.Size = new System.Drawing.Size(35, 13);
            this.lblTituloEval.TabIndex = 10;
            this.lblTituloEval.Text = "label1";
            // 
            // txtBoxTituloEval
            // 
            this.txtBoxTituloEval.Location = new System.Drawing.Point(12, 25);
            this.txtBoxTituloEval.Name = "txtBoxTituloEval";
            this.txtBoxTituloEval.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTituloEval.TabIndex = 11;
            // 
            // SelectorFechaIngreso
            // 
            this.SelectorFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SelectorFechaIngreso.Location = new System.Drawing.Point(12, 70);
            this.SelectorFechaIngreso.Name = "SelectorFechaIngreso";
            this.SelectorFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.SelectorFechaIngreso.TabIndex = 53;
            // 
            // FormAgregarEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 315);
            this.Controls.Add(this.SelectorFechaIngreso);
            this.Controls.Add(this.txtBoxTituloEval);
            this.Controls.Add(this.lblTituloEval);
            this.Controls.Add(this.btnEliminarTema);
            this.Controls.Add(this.btnAgregarTema);
            this.Controls.Add(this.lblTemasDeEvaluacion);
            this.Controls.Add(this.lblTemasDeMateria);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnAgregarEvaluacion);
            this.Controls.Add(this.listBoxTemasEvaluacion);
            this.Controls.Add(this.listBoxTemasMateria);
            this.Name = "FormAgregarEvaluacion";
            this.Text = "FormAgregarEvaluacion";
            this.Load += new System.EventHandler(this.FormAgregarEvaluacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTemasMateria;
        private System.Windows.Forms.ListBox listBoxTemasEvaluacion;
        private System.Windows.Forms.Button btnAgregarEvaluacion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTemasDeMateria;
        private System.Windows.Forms.Label lblTemasDeEvaluacion;
        private System.Windows.Forms.Button btnAgregarTema;
        private System.Windows.Forms.Button btnEliminarTema;
        private System.Windows.Forms.Label lblTituloEval;
        private System.Windows.Forms.TextBox txtBoxTituloEval;
        private System.Windows.Forms.DateTimePicker SelectorFechaIngreso;
    }
}