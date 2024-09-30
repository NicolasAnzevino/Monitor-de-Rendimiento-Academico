
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerRendimientoCursada
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerRendimientoCursada));
            this.txtBoxRendimiento = new System.Windows.Forms.TextBox();
            this.txtBoxConclusion = new System.Windows.Forms.RichTextBox();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.lblInfoRendimiento = new System.Windows.Forms.Label();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.lblGraficoRendimiento = new System.Windows.Forms.Label();
            this.chartRendimiento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gpVisualizacion = new System.Windows.Forms.GroupBox();
            this.rbMateria = new System.Windows.Forms.RadioButton();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.txtBoxMateria = new System.Windows.Forms.TextBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtBoxFecha2 = new System.Windows.Forms.MaskedTextBox();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.txtBoxFecha1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartRendimiento)).BeginInit();
            this.gpVisualizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxRendimiento
            // 
            this.txtBoxRendimiento.BackColor = System.Drawing.Color.White;
            this.txtBoxRendimiento.Location = new System.Drawing.Point(709, 25);
            this.txtBoxRendimiento.Multiline = true;
            this.txtBoxRendimiento.Name = "txtBoxRendimiento";
            this.txtBoxRendimiento.ReadOnly = true;
            this.txtBoxRendimiento.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxRendimiento.Size = new System.Drawing.Size(387, 307);
            this.txtBoxRendimiento.TabIndex = 1;
            // 
            // txtBoxConclusion
            // 
            this.txtBoxConclusion.BackColor = System.Drawing.Color.White;
            this.txtBoxConclusion.Location = new System.Drawing.Point(709, 351);
            this.txtBoxConclusion.Name = "txtBoxConclusion";
            this.txtBoxConclusion.ReadOnly = true;
            this.txtBoxConclusion.Size = new System.Drawing.Size(387, 76);
            this.txtBoxConclusion.TabIndex = 2;
            this.txtBoxConclusion.Text = "";
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.Location = new System.Drawing.Point(12, 303);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(101, 51);
            this.btnGenerarInforme.TabIndex = 3;
            this.btnGenerarInforme.Text = "button1";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            this.btnGenerarInforme.Click += new System.EventHandler(this.btnGenerarInforme_Click);
            // 
            // lblInfoRendimiento
            // 
            this.lblInfoRendimiento.AutoSize = true;
            this.lblInfoRendimiento.Location = new System.Drawing.Point(706, 8);
            this.lblInfoRendimiento.Name = "lblInfoRendimiento";
            this.lblInfoRendimiento.Size = new System.Drawing.Size(35, 13);
            this.lblInfoRendimiento.TabIndex = 4;
            this.lblInfoRendimiento.Text = "label1";
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Location = new System.Drawing.Point(706, 335);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(35, 13);
            this.lblConclusion.TabIndex = 5;
            this.lblConclusion.Text = "label1";
            // 
            // lblGraficoRendimiento
            // 
            this.lblGraficoRendimiento.AutoSize = true;
            this.lblGraficoRendimiento.Location = new System.Drawing.Point(12, 9);
            this.lblGraficoRendimiento.Name = "lblGraficoRendimiento";
            this.lblGraficoRendimiento.Size = new System.Drawing.Size(35, 13);
            this.lblGraficoRendimiento.TabIndex = 6;
            this.lblGraficoRendimiento.Text = "label1";
            // 
            // chartRendimiento
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRendimiento.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRendimiento.Legends.Add(legend1);
            this.chartRendimiento.Location = new System.Drawing.Point(12, 25);
            this.chartRendimiento.Name = "chartRendimiento";
            this.chartRendimiento.Size = new System.Drawing.Size(691, 272);
            this.chartRendimiento.TabIndex = 7;
            this.chartRendimiento.Text = "chart2";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // gpVisualizacion
            // 
            this.gpVisualizacion.Controls.Add(this.rbMateria);
            this.gpVisualizacion.Controls.Add(this.rbFecha);
            this.gpVisualizacion.Controls.Add(this.rbTodos);
            this.gpVisualizacion.Location = new System.Drawing.Point(517, 303);
            this.gpVisualizacion.Name = "gpVisualizacion";
            this.gpVisualizacion.Size = new System.Drawing.Size(183, 81);
            this.gpVisualizacion.TabIndex = 8;
            this.gpVisualizacion.TabStop = false;
            this.gpVisualizacion.Text = "groupBox1";
            // 
            // rbMateria
            // 
            this.rbMateria.AutoSize = true;
            this.rbMateria.Location = new System.Drawing.Point(97, 25);
            this.rbMateria.Name = "rbMateria";
            this.rbMateria.Size = new System.Drawing.Size(85, 17);
            this.rbMateria.TabIndex = 2;
            this.rbMateria.Text = "radioButton1";
            this.rbMateria.UseVisualStyleBackColor = true;
            this.rbMateria.CheckedChanged += new System.EventHandler(this.rbMateria_CheckedChanged);
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Location = new System.Drawing.Point(6, 48);
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
            this.rbTodos.Location = new System.Drawing.Point(6, 25);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(85, 17);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "radioButton1";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // txtBoxMateria
            // 
            this.txtBoxMateria.Location = new System.Drawing.Point(367, 319);
            this.txtBoxMateria.Name = "txtBoxMateria";
            this.txtBoxMateria.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMateria.TabIndex = 9;
            this.txtBoxMateria.TextChanged += new System.EventHandler(this.txtBoxMateria_TextChanged);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(364, 303);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(35, 13);
            this.lblMateria.TabIndex = 10;
            this.lblMateria.Text = "label1";
            // 
            // txtBoxFecha2
            // 
            this.txtBoxFecha2.Location = new System.Drawing.Point(367, 364);
            this.txtBoxFecha2.Name = "txtBoxFecha2";
            this.txtBoxFecha2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFecha2.TabIndex = 11;
            this.txtBoxFecha2.TextChanged += new System.EventHandler(this.txtBoxFecha2_TextChanged);
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(364, 348);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(35, 13);
            this.lblFecha2.TabIndex = 12;
            this.lblFecha2.Text = "label1";
            // 
            // lblFecha1
            // 
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Location = new System.Drawing.Point(364, 303);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(35, 13);
            this.lblFecha1.TabIndex = 14;
            this.lblFecha1.Text = "label1";
            // 
            // txtBoxFecha1
            // 
            this.txtBoxFecha1.Location = new System.Drawing.Point(367, 319);
            this.txtBoxFecha1.Name = "txtBoxFecha1";
            this.txtBoxFecha1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFecha1.TabIndex = 13;
            this.txtBoxFecha1.TextChanged += new System.EventHandler(this.txtBoxFecha1_TextChanged);
            // 
            // FormVerRendimientoCursada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 456);
            this.Controls.Add(this.lblFecha1);
            this.Controls.Add(this.txtBoxFecha1);
            this.Controls.Add(this.lblFecha2);
            this.Controls.Add(this.txtBoxFecha2);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.txtBoxMateria);
            this.Controls.Add(this.gpVisualizacion);
            this.Controls.Add(this.chartRendimiento);
            this.Controls.Add(this.lblGraficoRendimiento);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.lblInfoRendimiento);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.txtBoxConclusion);
            this.Controls.Add(this.txtBoxRendimiento);
            this.Name = "FormVerRendimientoCursada";
            this.Text = "FormVerRendimientoCursada";
            this.Load += new System.EventHandler(this.FormVerRendimientoCursada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRendimiento)).EndInit();
            this.gpVisualizacion.ResumeLayout(false);
            this.gpVisualizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxRendimiento;
        private System.Windows.Forms.RichTextBox txtBoxConclusion;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.Label lblInfoRendimiento;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Label lblGraficoRendimiento;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRendimiento;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.GroupBox gpVisualizacion;
        private System.Windows.Forms.RadioButton rbMateria;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.TextBox txtBoxMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.MaskedTextBox txtBoxFecha2;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.MaskedTextBox txtBoxFecha1;
    }
}