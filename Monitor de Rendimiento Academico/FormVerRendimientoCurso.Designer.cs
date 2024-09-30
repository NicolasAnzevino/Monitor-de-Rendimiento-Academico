
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerRendimientoCurso
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtBoxMateria = new System.Windows.Forms.TextBox();
            this.rbMateria = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.gpVisualizacion = new System.Windows.Forms.GroupBox();
            this.chartRendimiento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGraficoRendimiento = new System.Windows.Forms.Label();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.lblInfoRendimiento = new System.Windows.Forms.Label();
            this.txtBoxConclusion = new System.Windows.Forms.RichTextBox();
            this.txtBoxRendimiento = new System.Windows.Forms.TextBox();
            this.gpVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRendimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(478, 314);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(35, 13);
            this.lblMateria.TabIndex = 24;
            this.lblMateria.Text = "label1";
            // 
            // txtBoxMateria
            // 
            this.txtBoxMateria.Location = new System.Drawing.Point(481, 330);
            this.txtBoxMateria.Name = "txtBoxMateria";
            this.txtBoxMateria.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMateria.TabIndex = 23;
            this.txtBoxMateria.TextChanged += new System.EventHandler(this.txtBoxMateria_TextChanged);
            // 
            // rbMateria
            // 
            this.rbMateria.AutoSize = true;
            this.rbMateria.Location = new System.Drawing.Point(6, 49);
            this.rbMateria.Name = "rbMateria";
            this.rbMateria.Size = new System.Drawing.Size(85, 17);
            this.rbMateria.TabIndex = 2;
            this.rbMateria.Text = "radioButton1";
            this.rbMateria.UseVisualStyleBackColor = true;
            this.rbMateria.CheckedChanged += new System.EventHandler(this.rbMateria_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(6, 25);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(85, 17);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "radioButton1";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // gpVisualizacion
            // 
            this.gpVisualizacion.Controls.Add(this.rbMateria);
            this.gpVisualizacion.Controls.Add(this.rbTodos);
            this.gpVisualizacion.Location = new System.Drawing.Point(587, 305);
            this.gpVisualizacion.Name = "gpVisualizacion";
            this.gpVisualizacion.Size = new System.Drawing.Size(113, 81);
            this.gpVisualizacion.TabIndex = 22;
            this.gpVisualizacion.TabStop = false;
            this.gpVisualizacion.Text = "groupBox1";
            // 
            // chartRendimiento
            // 
            chartArea6.Name = "ChartArea1";
            this.chartRendimiento.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartRendimiento.Legends.Add(legend6);
            this.chartRendimiento.Location = new System.Drawing.Point(12, 27);
            this.chartRendimiento.Name = "chartRendimiento";
            this.chartRendimiento.Size = new System.Drawing.Size(691, 272);
            this.chartRendimiento.TabIndex = 21;
            this.chartRendimiento.Text = "chart2";
            // 
            // lblGraficoRendimiento
            // 
            this.lblGraficoRendimiento.AutoSize = true;
            this.lblGraficoRendimiento.Location = new System.Drawing.Point(12, 11);
            this.lblGraficoRendimiento.Name = "lblGraficoRendimiento";
            this.lblGraficoRendimiento.Size = new System.Drawing.Size(35, 13);
            this.lblGraficoRendimiento.TabIndex = 20;
            this.lblGraficoRendimiento.Text = "label1";
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Location = new System.Drawing.Point(706, 337);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(35, 13);
            this.lblConclusion.TabIndex = 19;
            this.lblConclusion.Text = "label1";
            // 
            // lblInfoRendimiento
            // 
            this.lblInfoRendimiento.AutoSize = true;
            this.lblInfoRendimiento.Location = new System.Drawing.Point(706, 10);
            this.lblInfoRendimiento.Name = "lblInfoRendimiento";
            this.lblInfoRendimiento.Size = new System.Drawing.Size(35, 13);
            this.lblInfoRendimiento.TabIndex = 18;
            this.lblInfoRendimiento.Text = "label1";
            // 
            // txtBoxConclusion
            // 
            this.txtBoxConclusion.BackColor = System.Drawing.Color.White;
            this.txtBoxConclusion.Location = new System.Drawing.Point(709, 353);
            this.txtBoxConclusion.Name = "txtBoxConclusion";
            this.txtBoxConclusion.ReadOnly = true;
            this.txtBoxConclusion.Size = new System.Drawing.Size(387, 91);
            this.txtBoxConclusion.TabIndex = 16;
            this.txtBoxConclusion.Text = "";
            // 
            // txtBoxRendimiento
            // 
            this.txtBoxRendimiento.BackColor = System.Drawing.Color.White;
            this.txtBoxRendimiento.Location = new System.Drawing.Point(709, 27);
            this.txtBoxRendimiento.Multiline = true;
            this.txtBoxRendimiento.Name = "txtBoxRendimiento";
            this.txtBoxRendimiento.ReadOnly = true;
            this.txtBoxRendimiento.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxRendimiento.Size = new System.Drawing.Size(387, 307);
            this.txtBoxRendimiento.TabIndex = 15;
            // 
            // FormVerRendimientoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 456);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.txtBoxMateria);
            this.Controls.Add(this.gpVisualizacion);
            this.Controls.Add(this.chartRendimiento);
            this.Controls.Add(this.lblGraficoRendimiento);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.lblInfoRendimiento);
            this.Controls.Add(this.txtBoxConclusion);
            this.Controls.Add(this.txtBoxRendimiento);
            this.Name = "FormVerRendimientoCurso";
            this.Text = "FormVerRendimientoCurso";
            this.Load += new System.EventHandler(this.FormVerRendimientoCurso_Load);
            this.gpVisualizacion.ResumeLayout(false);
            this.gpVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRendimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtBoxMateria;
        private System.Windows.Forms.RadioButton rbMateria;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.GroupBox gpVisualizacion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRendimiento;
        private System.Windows.Forms.Label lblGraficoRendimiento;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Label lblInfoRendimiento;
        private System.Windows.Forms.RichTextBox txtBoxConclusion;
        private System.Windows.Forms.TextBox txtBoxRendimiento;
    }
}