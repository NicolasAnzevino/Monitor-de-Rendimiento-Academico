﻿
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormVerInasistenciasAlumnoPerfil
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
            this.dgvInasistencias = new System.Windows.Forms.DataGridView();
            this.DGV_Inasistencias_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Inasistencias_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Inasistencias_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpConsultas = new System.Windows.Forms.GroupBox();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.txtBoxJust = new System.Windows.Forms.TextBox();
            this.lblJustificacion = new System.Windows.Forms.Label();
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtBoxBuscar = new System.Windows.Forms.MaskedTextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInasistencias)).BeginInit();
            this.gpConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInasistencias
            // 
            this.dgvInasistencias.AllowUserToAddRows = false;
            this.dgvInasistencias.AllowUserToDeleteRows = false;
            this.dgvInasistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInasistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInasistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Inasistencias_Codigo,
            this.DGV_Inasistencias_Fecha,
            this.DGV_Inasistencias_Valor});
            this.dgvInasistencias.Location = new System.Drawing.Point(12, 12);
            this.dgvInasistencias.MultiSelect = false;
            this.dgvInasistencias.Name = "dgvInasistencias";
            this.dgvInasistencias.ReadOnly = true;
            this.dgvInasistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInasistencias.Size = new System.Drawing.Size(553, 252);
            this.dgvInasistencias.TabIndex = 39;
            this.dgvInasistencias.TabStop = false;
            this.dgvInasistencias.Click += new System.EventHandler(this.dgvInasistencias_Click);
            // 
            // DGV_Inasistencias_Codigo
            // 
            this.DGV_Inasistencias_Codigo.HeaderText = "Column1";
            this.DGV_Inasistencias_Codigo.Name = "DGV_Inasistencias_Codigo";
            this.DGV_Inasistencias_Codigo.ReadOnly = true;
            // 
            // DGV_Inasistencias_Fecha
            // 
            this.DGV_Inasistencias_Fecha.HeaderText = "Column1";
            this.DGV_Inasistencias_Fecha.Name = "DGV_Inasistencias_Fecha";
            this.DGV_Inasistencias_Fecha.ReadOnly = true;
            // 
            // DGV_Inasistencias_Valor
            // 
            this.DGV_Inasistencias_Valor.HeaderText = "Column1";
            this.DGV_Inasistencias_Valor.Name = "DGV_Inasistencias_Valor";
            this.DGV_Inasistencias_Valor.ReadOnly = true;
            // 
            // gpConsultas
            // 
            this.gpConsultas.Controls.Add(this.rbFecha);
            this.gpConsultas.Controls.Add(this.rbTodas);
            this.gpConsultas.Location = new System.Drawing.Point(459, 270);
            this.gpConsultas.Name = "gpConsultas";
            this.gpConsultas.Size = new System.Drawing.Size(106, 67);
            this.gpConsultas.TabIndex = 42;
            this.gpConsultas.TabStop = false;
            this.gpConsultas.Text = "groupBox1";
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Location = new System.Drawing.Point(6, 44);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(85, 17);
            this.rbFecha.TabIndex = 25;
            this.rbFecha.Text = "radioButton2";
            this.rbFecha.UseVisualStyleBackColor = true;
            this.rbFecha.CheckedChanged += new System.EventHandler(this.rbFecha_CheckedChanged);
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Checked = true;
            this.rbTodas.Location = new System.Drawing.Point(6, 21);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(85, 17);
            this.rbTodas.TabIndex = 24;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "radioButton1";
            this.rbTodas.UseVisualStyleBackColor = true;
            this.rbTodas.CheckedChanged += new System.EventHandler(this.rbTodas_CheckedChanged);
            // 
            // txtBoxJust
            // 
            this.txtBoxJust.BackColor = System.Drawing.Color.White;
            this.txtBoxJust.Location = new System.Drawing.Point(699, 28);
            this.txtBoxJust.Multiline = true;
            this.txtBoxJust.Name = "txtBoxJust";
            this.txtBoxJust.ReadOnly = true;
            this.txtBoxJust.Size = new System.Drawing.Size(123, 236);
            this.txtBoxJust.TabIndex = 48;
            // 
            // lblJustificacion
            // 
            this.lblJustificacion.AutoSize = true;
            this.lblJustificacion.Location = new System.Drawing.Point(696, 12);
            this.lblJustificacion.Name = "lblJustificacion";
            this.lblJustificacion.Size = new System.Drawing.Size(35, 13);
            this.lblJustificacion.TabIndex = 47;
            this.lblJustificacion.Text = "label3";
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.BackColor = System.Drawing.Color.White;
            this.txtBoxDesc.Location = new System.Drawing.Point(571, 28);
            this.txtBoxDesc.Multiline = true;
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.ReadOnly = true;
            this.txtBoxDesc.Size = new System.Drawing.Size(123, 236);
            this.txtBoxDesc.TabIndex = 46;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(571, 12);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(35, 13);
            this.lblDescripcion.TabIndex = 45;
            this.lblDescripcion.Text = "label1";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(353, 313);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBuscar.TabIndex = 44;
            this.txtBoxBuscar.TextChanged += new System.EventHandler(this.txtBoxBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(350, 297);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(35, 13);
            this.lblBuscar.TabIndex = 43;
            this.lblBuscar.Text = "label1";
            // 
            // FormVerInasistenciasAlumnoPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 359);
            this.Controls.Add(this.dgvInasistencias);
            this.Controls.Add(this.gpConsultas);
            this.Controls.Add(this.txtBoxJust);
            this.Controls.Add(this.lblJustificacion);
            this.Controls.Add(this.txtBoxDesc);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Name = "FormVerInasistenciasAlumnoPerfil";
            this.Text = "FormVerInasistenciasAlumnoPerfil";
            this.Load += new System.EventHandler(this.FormVerInasistenciasAlumnoPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInasistencias)).EndInit();
            this.gpConsultas.ResumeLayout(false);
            this.gpConsultas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInasistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Inasistencias_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Inasistencias_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Inasistencias_Valor;
        private System.Windows.Forms.GroupBox gpConsultas;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.TextBox txtBoxJust;
        private System.Windows.Forms.Label lblJustificacion;
        private System.Windows.Forms.TextBox txtBoxDesc;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.MaskedTextBox txtBoxBuscar;
        private System.Windows.Forms.Label lblBuscar;
    }
}