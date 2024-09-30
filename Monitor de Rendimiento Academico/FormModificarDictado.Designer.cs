
namespace Monitor_de_Rendimiento_Academico
{
    partial class FormModificarDictado
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
            this.DGV_Cursos_Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Cursos_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Cursos_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeseleccionarCurso = new System.Windows.Forms.Button();
            this.lblCursoSelected = new System.Windows.Forms.Label();
            this.txtBoxCursoSelected = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCurso = new System.Windows.Forms.Button();
            this.lblCursos = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.DGV_Cursos_Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeseleccionarMateria = new System.Windows.Forms.Button();
            this.lblMateriaSeleccionada = new System.Windows.Forms.Label();
            this.txtboxMateriaSelected = new System.Windows.Forms.TextBox();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            this.lblDocentesSelect = new System.Windows.Forms.Label();
            this.btnQuitarDocente = new System.Windows.Forms.Button();
            this.btnSeleccionarMateria = new System.Windows.Forms.Button();
            this.lblDocentes = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lbDocentesSelected = new System.Windows.Forms.ListBox();
            this.btnModificarDictado = new System.Windows.Forms.Button();
            this.DGV_Docentes_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Docentes_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Docentes_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Docentes_Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.DGV_Materia_Cant_Horas_Semanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Materia_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Materia_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Cursos_Turno
            // 
            this.DGV_Cursos_Turno.HeaderText = "Column1";
            this.DGV_Cursos_Turno.Name = "DGV_Cursos_Turno";
            this.DGV_Cursos_Turno.ReadOnly = true;
            // 
            // DGV_Cursos_Nombre
            // 
            this.DGV_Cursos_Nombre.HeaderText = "Column1";
            this.DGV_Cursos_Nombre.Name = "DGV_Cursos_Nombre";
            this.DGV_Cursos_Nombre.ReadOnly = true;
            // 
            // DGV_Cursos_Codigo
            // 
            this.DGV_Cursos_Codigo.HeaderText = "Column1";
            this.DGV_Cursos_Codigo.Name = "DGV_Cursos_Codigo";
            this.DGV_Cursos_Codigo.ReadOnly = true;
            // 
            // btnDeseleccionarCurso
            // 
            this.btnDeseleccionarCurso.Location = new System.Drawing.Point(217, 262);
            this.btnDeseleccionarCurso.Name = "btnDeseleccionarCurso";
            this.btnDeseleccionarCurso.Size = new System.Drawing.Size(106, 37);
            this.btnDeseleccionarCurso.TabIndex = 60;
            this.btnDeseleccionarCurso.Text = "button5";
            this.btnDeseleccionarCurso.UseVisualStyleBackColor = true;
            this.btnDeseleccionarCurso.Click += new System.EventHandler(this.btnDeseleccionarCurso_Click);
            // 
            // lblCursoSelected
            // 
            this.lblCursoSelected.AutoSize = true;
            this.lblCursoSelected.Location = new System.Drawing.Point(108, 262);
            this.lblCursoSelected.Name = "lblCursoSelected";
            this.lblCursoSelected.Size = new System.Drawing.Size(35, 13);
            this.lblCursoSelected.TabIndex = 59;
            this.lblCursoSelected.Text = "label1";
            // 
            // txtBoxCursoSelected
            // 
            this.txtBoxCursoSelected.Location = new System.Drawing.Point(111, 278);
            this.txtBoxCursoSelected.Name = "txtBoxCursoSelected";
            this.txtBoxCursoSelected.ReadOnly = true;
            this.txtBoxCursoSelected.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCursoSelected.TabIndex = 58;
            // 
            // btnSeleccionarCurso
            // 
            this.btnSeleccionarCurso.Location = new System.Drawing.Point(12, 255);
            this.btnSeleccionarCurso.Name = "btnSeleccionarCurso";
            this.btnSeleccionarCurso.Size = new System.Drawing.Size(87, 43);
            this.btnSeleccionarCurso.TabIndex = 57;
            this.btnSeleccionarCurso.Text = "button2";
            this.btnSeleccionarCurso.UseVisualStyleBackColor = true;
            this.btnSeleccionarCurso.Click += new System.EventHandler(this.btnSeleccionarCurso_Click);
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.Location = new System.Drawing.Point(162, 9);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(35, 13);
            this.lblCursos.TabIndex = 56;
            this.lblCursos.Text = "label1";
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Cursos_Codigo,
            this.DGV_Cursos_Nombre,
            this.DGV_Cursos_Ano,
            this.DGV_Cursos_Turno});
            this.dgvCursos.Location = new System.Drawing.Point(12, 25);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(328, 225);
            this.dgvCursos.TabIndex = 55;
            this.dgvCursos.TabStop = false;
            // 
            // DGV_Cursos_Ano
            // 
            this.DGV_Cursos_Ano.HeaderText = "Column1";
            this.DGV_Cursos_Ano.Name = "DGV_Cursos_Ano";
            this.DGV_Cursos_Ano.ReadOnly = true;
            // 
            // btnDeseleccionarMateria
            // 
            this.btnDeseleccionarMateria.Location = new System.Drawing.Point(560, 262);
            this.btnDeseleccionarMateria.Name = "btnDeseleccionarMateria";
            this.btnDeseleccionarMateria.Size = new System.Drawing.Size(106, 37);
            this.btnDeseleccionarMateria.TabIndex = 54;
            this.btnDeseleccionarMateria.Text = "button5";
            this.btnDeseleccionarMateria.UseVisualStyleBackColor = true;
            this.btnDeseleccionarMateria.Click += new System.EventHandler(this.btnDeseleccionarMateria_Click);
            // 
            // lblMateriaSeleccionada
            // 
            this.lblMateriaSeleccionada.AutoSize = true;
            this.lblMateriaSeleccionada.Location = new System.Drawing.Point(451, 262);
            this.lblMateriaSeleccionada.Name = "lblMateriaSeleccionada";
            this.lblMateriaSeleccionada.Size = new System.Drawing.Size(35, 13);
            this.lblMateriaSeleccionada.TabIndex = 53;
            this.lblMateriaSeleccionada.Text = "label1";
            // 
            // txtboxMateriaSelected
            // 
            this.txtboxMateriaSelected.Location = new System.Drawing.Point(454, 278);
            this.txtboxMateriaSelected.Name = "txtboxMateriaSelected";
            this.txtboxMateriaSelected.ReadOnly = true;
            this.txtboxMateriaSelected.Size = new System.Drawing.Size(100, 20);
            this.txtboxMateriaSelected.TabIndex = 52;
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.Location = new System.Drawing.Point(698, 256);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Size = new System.Drawing.Size(87, 43);
            this.btnAgregarDocente.TabIndex = 51;
            this.btnAgregarDocente.Text = "button4";
            this.btnAgregarDocente.UseVisualStyleBackColor = true;
            this.btnAgregarDocente.Click += new System.EventHandler(this.btnAgregarDocente_Click);
            // 
            // lblDocentesSelect
            // 
            this.lblDocentesSelect.AutoSize = true;
            this.lblDocentesSelect.Location = new System.Drawing.Point(1054, 9);
            this.lblDocentesSelect.Name = "lblDocentesSelect";
            this.lblDocentesSelect.Size = new System.Drawing.Size(35, 13);
            this.lblDocentesSelect.TabIndex = 50;
            this.lblDocentesSelect.Text = "label1";
            // 
            // btnQuitarDocente
            // 
            this.btnQuitarDocente.Location = new System.Drawing.Point(1043, 255);
            this.btnQuitarDocente.Name = "btnQuitarDocente";
            this.btnQuitarDocente.Size = new System.Drawing.Size(87, 43);
            this.btnQuitarDocente.TabIndex = 49;
            this.btnQuitarDocente.Text = "button3";
            this.btnQuitarDocente.UseVisualStyleBackColor = true;
            this.btnQuitarDocente.Click += new System.EventHandler(this.btnQuitarDocente_Click);
            // 
            // btnSeleccionarMateria
            // 
            this.btnSeleccionarMateria.Location = new System.Drawing.Point(355, 255);
            this.btnSeleccionarMateria.Name = "btnSeleccionarMateria";
            this.btnSeleccionarMateria.Size = new System.Drawing.Size(87, 43);
            this.btnSeleccionarMateria.TabIndex = 48;
            this.btnSeleccionarMateria.Text = "button2";
            this.btnSeleccionarMateria.UseVisualStyleBackColor = true;
            this.btnSeleccionarMateria.Click += new System.EventHandler(this.btnSeleccionarMateria_Click);
            // 
            // lblDocentes
            // 
            this.lblDocentes.AutoSize = true;
            this.lblDocentes.Location = new System.Drawing.Point(843, 9);
            this.lblDocentes.Name = "lblDocentes";
            this.lblDocentes.Size = new System.Drawing.Size(35, 13);
            this.lblDocentes.TabIndex = 47;
            this.lblDocentes.Text = "label1";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(505, 9);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(35, 13);
            this.lblMateria.TabIndex = 46;
            this.lblMateria.Text = "label1";
            // 
            // lbDocentesSelected
            // 
            this.lbDocentesSelected.FormattingEnabled = true;
            this.lbDocentesSelected.Location = new System.Drawing.Point(1043, 25);
            this.lbDocentesSelected.Name = "lbDocentesSelected";
            this.lbDocentesSelected.Size = new System.Drawing.Size(163, 225);
            this.lbDocentesSelected.TabIndex = 45;
            // 
            // btnModificarDictado
            // 
            this.btnModificarDictado.Location = new System.Drawing.Point(12, 333);
            this.btnModificarDictado.Name = "btnModificarDictado";
            this.btnModificarDictado.Size = new System.Drawing.Size(103, 60);
            this.btnModificarDictado.TabIndex = 44;
            this.btnModificarDictado.Text = "button1";
            this.btnModificarDictado.UseVisualStyleBackColor = true;
            this.btnModificarDictado.Click += new System.EventHandler(this.btnModificarDictado_Click);
            // 
            // DGV_Docentes_Nombre
            // 
            this.DGV_Docentes_Nombre.HeaderText = "Column1";
            this.DGV_Docentes_Nombre.Name = "DGV_Docentes_Nombre";
            this.DGV_Docentes_Nombre.ReadOnly = true;
            // 
            // DGV_Docentes_Apellido
            // 
            this.DGV_Docentes_Apellido.HeaderText = "Column1";
            this.DGV_Docentes_Apellido.Name = "DGV_Docentes_Apellido";
            this.DGV_Docentes_Apellido.ReadOnly = true;
            // 
            // DGV_Docentes_DNI
            // 
            this.DGV_Docentes_DNI.HeaderText = "Column1";
            this.DGV_Docentes_DNI.Name = "DGV_Docentes_DNI";
            this.DGV_Docentes_DNI.ReadOnly = true;
            // 
            // DGV_Docentes_Legajo
            // 
            this.DGV_Docentes_Legajo.HeaderText = "Column1";
            this.DGV_Docentes_Legajo.Name = "DGV_Docentes_Legajo";
            this.DGV_Docentes_Legajo.ReadOnly = true;
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Docentes_Legajo,
            this.DGV_Docentes_DNI,
            this.DGV_Docentes_Apellido,
            this.DGV_Docentes_Nombre});
            this.dgvDocentes.Location = new System.Drawing.Point(698, 25);
            this.dgvDocentes.MultiSelect = false;
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(328, 225);
            this.dgvDocentes.TabIndex = 43;
            this.dgvDocentes.TabStop = false;
            // 
            // DGV_Materia_Cant_Horas_Semanales
            // 
            this.DGV_Materia_Cant_Horas_Semanales.HeaderText = "Column1";
            this.DGV_Materia_Cant_Horas_Semanales.Name = "DGV_Materia_Cant_Horas_Semanales";
            this.DGV_Materia_Cant_Horas_Semanales.ReadOnly = true;
            // 
            // DGV_Materia_Nombre
            // 
            this.DGV_Materia_Nombre.HeaderText = "Column1";
            this.DGV_Materia_Nombre.Name = "DGV_Materia_Nombre";
            this.DGV_Materia_Nombre.ReadOnly = true;
            // 
            // DGV_Materia_Codigo
            // 
            this.DGV_Materia_Codigo.HeaderText = "Column1";
            this.DGV_Materia_Codigo.Name = "DGV_Materia_Codigo";
            this.DGV_Materia_Codigo.ReadOnly = true;
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Materia_Codigo,
            this.DGV_Materia_Nombre,
            this.DGV_Materia_Cant_Horas_Semanales});
            this.dgvMaterias.Location = new System.Drawing.Point(355, 25);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(328, 225);
            this.dgvMaterias.TabIndex = 42;
            this.dgvMaterias.TabStop = false;
            // 
            // FormModificarDictado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 403);
            this.Controls.Add(this.btnDeseleccionarCurso);
            this.Controls.Add(this.lblCursoSelected);
            this.Controls.Add(this.txtBoxCursoSelected);
            this.Controls.Add(this.btnSeleccionarCurso);
            this.Controls.Add(this.lblCursos);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.btnDeseleccionarMateria);
            this.Controls.Add(this.lblMateriaSeleccionada);
            this.Controls.Add(this.txtboxMateriaSelected);
            this.Controls.Add(this.btnAgregarDocente);
            this.Controls.Add(this.lblDocentesSelect);
            this.Controls.Add(this.btnQuitarDocente);
            this.Controls.Add(this.btnSeleccionarMateria);
            this.Controls.Add(this.lblDocentes);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lbDocentesSelected);
            this.Controls.Add(this.btnModificarDictado);
            this.Controls.Add(this.dgvDocentes);
            this.Controls.Add(this.dgvMaterias);
            this.Name = "FormModificarDictado";
            this.Text = "FormModificarDictado";
            this.Load += new System.EventHandler(this.FormModificarDictado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Cursos_Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Cursos_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Cursos_Codigo;
        private System.Windows.Forms.Button btnDeseleccionarCurso;
        private System.Windows.Forms.Label lblCursoSelected;
        private System.Windows.Forms.TextBox txtBoxCursoSelected;
        private System.Windows.Forms.Button btnSeleccionarCurso;
        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Cursos_Ano;
        private System.Windows.Forms.Button btnDeseleccionarMateria;
        private System.Windows.Forms.Label lblMateriaSeleccionada;
        private System.Windows.Forms.TextBox txtboxMateriaSelected;
        private System.Windows.Forms.Button btnAgregarDocente;
        private System.Windows.Forms.Label lblDocentesSelect;
        private System.Windows.Forms.Button btnQuitarDocente;
        private System.Windows.Forms.Button btnSeleccionarMateria;
        private System.Windows.Forms.Label lblDocentes;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ListBox lbDocentesSelected;
        private System.Windows.Forms.Button btnModificarDictado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Docentes_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Docentes_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Docentes_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Docentes_Legajo;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Materia_Cant_Horas_Semanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Materia_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Materia_Codigo;
        private System.Windows.Forms.DataGridView dgvMaterias;
    }
}