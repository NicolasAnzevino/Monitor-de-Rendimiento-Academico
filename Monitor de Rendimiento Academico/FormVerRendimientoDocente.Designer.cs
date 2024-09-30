
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerRendimientoDocente
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerRendimientoDocente));
            this.chartRendimiento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGraficoRendimiento = new System.Windows.Forms.Label();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.lblInfoRendimiento = new System.Windows.Forms.Label();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.txtBoxConclusion = new System.Windows.Forms.RichTextBox();
            this.txtBoxRendimiento = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gpVisualizacion = new System.Windows.Forms.GroupBox();
            this.rbRendimientoDictado = new System.Windows.Forms.RadioButton();
            this.rbRendimientoDocente = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartRendimiento)).BeginInit();
            this.gpVisualizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartRendimiento
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRendimiento.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRendimiento.Legends.Add(legend2);
            this.chartRendimiento.Location = new System.Drawing.Point(12, 26);
            this.chartRendimiento.Name = "chartRendimiento";
            this.chartRendimiento.Size = new System.Drawing.Size(691, 272);
            this.chartRendimiento.TabIndex = 14;
            this.chartRendimiento.Text = "chart2";
            // 
            // lblGraficoRendimiento
            // 
            this.lblGraficoRendimiento.AutoSize = true;
            this.lblGraficoRendimiento.Location = new System.Drawing.Point(12, 10);
            this.lblGraficoRendimiento.Name = "lblGraficoRendimiento";
            this.lblGraficoRendimiento.Size = new System.Drawing.Size(35, 13);
            this.lblGraficoRendimiento.TabIndex = 13;
            this.lblGraficoRendimiento.Text = "label1";
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Location = new System.Drawing.Point(706, 336);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(35, 13);
            this.lblConclusion.TabIndex = 12;
            this.lblConclusion.Text = "label1";
            // 
            // lblInfoRendimiento
            // 
            this.lblInfoRendimiento.AutoSize = true;
            this.lblInfoRendimiento.Location = new System.Drawing.Point(706, 9);
            this.lblInfoRendimiento.Name = "lblInfoRendimiento";
            this.lblInfoRendimiento.Size = new System.Drawing.Size(35, 13);
            this.lblInfoRendimiento.TabIndex = 11;
            this.lblInfoRendimiento.Text = "label1";
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.Location = new System.Drawing.Point(12, 304);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(101, 51);
            this.btnGenerarInforme.TabIndex = 10;
            this.btnGenerarInforme.Text = "button1";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            this.btnGenerarInforme.Click += new System.EventHandler(this.btnGenerarInforme_Click);
            // 
            // txtBoxConclusion
            // 
            this.txtBoxConclusion.BackColor = System.Drawing.Color.White;
            this.txtBoxConclusion.Location = new System.Drawing.Point(709, 352);
            this.txtBoxConclusion.Name = "txtBoxConclusion";
            this.txtBoxConclusion.ReadOnly = true;
            this.txtBoxConclusion.Size = new System.Drawing.Size(387, 76);
            this.txtBoxConclusion.TabIndex = 9;
            this.txtBoxConclusion.Text = "";
            // 
            // txtBoxRendimiento
            // 
            this.txtBoxRendimiento.BackColor = System.Drawing.Color.White;
            this.txtBoxRendimiento.Location = new System.Drawing.Point(709, 26);
            this.txtBoxRendimiento.Multiline = true;
            this.txtBoxRendimiento.Name = "txtBoxRendimiento";
            this.txtBoxRendimiento.ReadOnly = true;
            this.txtBoxRendimiento.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxRendimiento.Size = new System.Drawing.Size(387, 307);
            this.txtBoxRendimiento.TabIndex = 8;
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
            this.gpVisualizacion.Controls.Add(this.rbRendimientoDictado);
            this.gpVisualizacion.Controls.Add(this.rbRendimientoDocente);
            this.gpVisualizacion.Location = new System.Drawing.Point(531, 304);
            this.gpVisualizacion.Name = "gpVisualizacion";
            this.gpVisualizacion.Size = new System.Drawing.Size(172, 72);
            this.gpVisualizacion.TabIndex = 15;
            this.gpVisualizacion.TabStop = false;
            this.gpVisualizacion.Text = "groupBox1";
            // 
            // rbRendimientoDictado
            // 
            this.rbRendimientoDictado.AutoSize = true;
            this.rbRendimientoDictado.Location = new System.Drawing.Point(6, 42);
            this.rbRendimientoDictado.Name = "rbRendimientoDictado";
            this.rbRendimientoDictado.Size = new System.Drawing.Size(85, 17);
            this.rbRendimientoDictado.TabIndex = 1;
            this.rbRendimientoDictado.TabStop = true;
            this.rbRendimientoDictado.Text = "radioButton2";
            this.rbRendimientoDictado.UseVisualStyleBackColor = true;
            this.rbRendimientoDictado.CheckedChanged += new System.EventHandler(this.rbRendimientoDictado_CheckedChanged);
            // 
            // rbRendimientoDocente
            // 
            this.rbRendimientoDocente.AutoSize = true;
            this.rbRendimientoDocente.Checked = true;
            this.rbRendimientoDocente.Location = new System.Drawing.Point(6, 19);
            this.rbRendimientoDocente.Name = "rbRendimientoDocente";
            this.rbRendimientoDocente.Size = new System.Drawing.Size(85, 17);
            this.rbRendimientoDocente.TabIndex = 0;
            this.rbRendimientoDocente.TabStop = true;
            this.rbRendimientoDocente.Text = "radioButton1";
            this.rbRendimientoDocente.UseVisualStyleBackColor = true;
            this.rbRendimientoDocente.CheckedChanged += new System.EventHandler(this.rbRendimientoDocente_CheckedChanged);
            // 
            // FormVerRendimientoDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 456);
            this.Controls.Add(this.gpVisualizacion);
            this.Controls.Add(this.chartRendimiento);
            this.Controls.Add(this.lblGraficoRendimiento);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.lblInfoRendimiento);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.txtBoxConclusion);
            this.Controls.Add(this.txtBoxRendimiento);
            this.Name = "FormVerRendimientoDocente";
            this.Text = "FormVerRendimientoDocente";
            this.Load += new System.EventHandler(this.FormVerRendimientoDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRendimiento)).EndInit();
            this.gpVisualizacion.ResumeLayout(false);
            this.gpVisualizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRendimiento;
        private System.Windows.Forms.Label lblGraficoRendimiento;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Label lblInfoRendimiento;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.RichTextBox txtBoxConclusion;
        private System.Windows.Forms.TextBox txtBoxRendimiento;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.GroupBox gpVisualizacion;
        private System.Windows.Forms.RadioButton rbRendimientoDictado;
        private System.Windows.Forms.RadioButton rbRendimientoDocente;
    }
}