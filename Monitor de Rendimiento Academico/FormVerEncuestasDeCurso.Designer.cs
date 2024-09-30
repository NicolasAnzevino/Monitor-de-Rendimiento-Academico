
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerEncuestasDeCurso
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
            this.btnVerResultadosDeEncuesta = new System.Windows.Forms.Button();
            this.dgvEncuestasDeCurso = new System.Windows.Forms.DataGridView();
            this.btnDarDeBajaEncuesta = new System.Windows.Forms.Button();
            this.DGV_Encuestas_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Encuestas_Fecha_Creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncuestasDeCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerResultadosDeEncuesta
            // 
            this.btnVerResultadosDeEncuesta.Location = new System.Drawing.Point(12, 278);
            this.btnVerResultadosDeEncuesta.Name = "btnVerResultadosDeEncuesta";
            this.btnVerResultadosDeEncuesta.Size = new System.Drawing.Size(86, 56);
            this.btnVerResultadosDeEncuesta.TabIndex = 27;
            this.btnVerResultadosDeEncuesta.Text = "button1";
            this.btnVerResultadosDeEncuesta.UseVisualStyleBackColor = true;
            this.btnVerResultadosDeEncuesta.Click += new System.EventHandler(this.btnVerResultadosDeEncuesta_Click);
            // 
            // dgvEncuestasDeCurso
            // 
            this.dgvEncuestasDeCurso.AllowUserToAddRows = false;
            this.dgvEncuestasDeCurso.AllowUserToDeleteRows = false;
            this.dgvEncuestasDeCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEncuestasDeCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncuestasDeCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Encuestas_Codigo,
            this.DGV_Encuestas_Fecha_Creacion});
            this.dgvEncuestasDeCurso.Location = new System.Drawing.Point(12, 12);
            this.dgvEncuestasDeCurso.MultiSelect = false;
            this.dgvEncuestasDeCurso.Name = "dgvEncuestasDeCurso";
            this.dgvEncuestasDeCurso.ReadOnly = true;
            this.dgvEncuestasDeCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncuestasDeCurso.Size = new System.Drawing.Size(696, 260);
            this.dgvEncuestasDeCurso.TabIndex = 26;
            this.dgvEncuestasDeCurso.TabStop = false;
            // 
            // btnDarDeBajaEncuesta
            // 
            this.btnDarDeBajaEncuesta.Location = new System.Drawing.Point(104, 278);
            this.btnDarDeBajaEncuesta.Name = "btnDarDeBajaEncuesta";
            this.btnDarDeBajaEncuesta.Size = new System.Drawing.Size(86, 56);
            this.btnDarDeBajaEncuesta.TabIndex = 28;
            this.btnDarDeBajaEncuesta.Text = "button1";
            this.btnDarDeBajaEncuesta.UseVisualStyleBackColor = true;
            this.btnDarDeBajaEncuesta.Click += new System.EventHandler(this.btnDarDeBajaEncuesta_Click);
            // 
            // DGV_Encuestas_Codigo
            // 
            this.DGV_Encuestas_Codigo.HeaderText = "Column1";
            this.DGV_Encuestas_Codigo.Name = "DGV_Encuestas_Codigo";
            this.DGV_Encuestas_Codigo.ReadOnly = true;
            // 
            // DGV_Encuestas_Fecha_Creacion
            // 
            this.DGV_Encuestas_Fecha_Creacion.HeaderText = "Column1";
            this.DGV_Encuestas_Fecha_Creacion.Name = "DGV_Encuestas_Fecha_Creacion";
            this.DGV_Encuestas_Fecha_Creacion.ReadOnly = true;
            // 
            // FormVerEncuestasDeCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 346);
            this.Controls.Add(this.btnDarDeBajaEncuesta);
            this.Controls.Add(this.btnVerResultadosDeEncuesta);
            this.Controls.Add(this.dgvEncuestasDeCurso);
            this.Name = "FormVerEncuestasDeCurso";
            this.Text = "FormVerEncuestasDeCurso";
            this.Load += new System.EventHandler(this.FormVerEncuestasDeCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncuestasDeCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerResultadosDeEncuesta;
        private System.Windows.Forms.DataGridView dgvEncuestasDeCurso;
        private System.Windows.Forms.Button btnDarDeBajaEncuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Encuestas_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Encuestas_Fecha_Creacion;
    }
}