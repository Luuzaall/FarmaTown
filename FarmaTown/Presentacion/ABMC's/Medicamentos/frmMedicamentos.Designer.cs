
namespace FarmaTown.Presentacion.ABMC_s.Medicamentos
{
    partial class frmMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicamentos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new CustomControls.RJControls.RJButton();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.lblAviso = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbMedicamento = new System.Windows.Forms.TextBox();
            this.btnConsultar = new CustomControls.RJControls.RJButton();
            this.btnLimpiar = new CustomControls.RJControls.RJButton();
            this.cboTipos = new System.Windows.Forms.ComboBox();
            this.lblTipoMedicamento = new System.Windows.Forms.Label();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.btnSeleccionar = new CustomControls.RJControls.RJButton();
            this.btnSalir = new CustomControls.RJControls.RJButton();
            this.btnEliminar = new CustomControls.RJControls.RJButton();
            this.btnEditar = new CustomControls.RJControls.RJButton();
            this.btnAgregar = new CustomControls.RJControls.RJButton();
            this.idMedicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.dgvMedicamentos);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(21, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1049, 312);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnActualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.BorderColor = System.Drawing.Color.Green;
            this.btnActualizar.BorderRadius = 20;
            this.btnActualizar.BorderSize = 1;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnActualizar.Location = new System.Drawing.Point(939, 101);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 48);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Black;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.AllowUserToAddRows = false;
            this.dgvMedicamentos.AllowUserToDeleteRows = false;
            this.dgvMedicamentos.AllowUserToResizeColumns = false;
            this.dgvMedicamentos.AllowUserToResizeRows = false;
            this.dgvMedicamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicamentos,
            this.nombre,
            this.Tipo,
            this.precio,
            this.cantidad,
            this.Descripcion});
            this.dgvMedicamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.dgvMedicamentos.Location = new System.Drawing.Point(19, 31);
            this.dgvMedicamentos.MultiSelect = false;
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.ReadOnly = true;
            this.dgvMedicamentos.RowHeadersWidth = 50;
            this.dgvMedicamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamentos.ShowEditingIcon = false;
            this.dgvMedicamentos.Size = new System.Drawing.Size(914, 275);
            this.dgvMedicamentos.TabIndex = 14;
            this.dgvMedicamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamentos_CellClick);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblAviso.ForeColor = System.Drawing.Color.Maroon;
            this.lblAviso.Location = new System.Drawing.Point(301, 528);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(284, 22);
            this.lblAviso.TabIndex = 23;
            this.lblAviso.Text = "Debe elegir un usuario primero";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtbMedicamento);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.cboTipos);
            this.groupBox1.Controls.Add(this.lblTipoMedicamento);
            this.groupBox1.Controls.Add(this.lblMedicamento);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(21, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 156);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txtbMedicamento
            // 
            this.txtbMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbMedicamento.Location = new System.Drawing.Point(210, 52);
            this.txtbMedicamento.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbMedicamento.Name = "txtbMedicamento";
            this.txtbMedicamento.Size = new System.Drawing.Size(244, 25);
            this.txtbMedicamento.TabIndex = 27;
            this.txtbMedicamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbEnter_KeyDown);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnConsultar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.BorderColor = System.Drawing.Color.Green;
            this.btnConsultar.BorderRadius = 20;
            this.btnConsultar.BorderSize = 1;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnConsultar.Location = new System.Drawing.Point(511, 97);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(104, 37);
            this.btnConsultar.TabIndex = 26;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.Black;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.BorderColor = System.Drawing.Color.Green;
            this.btnLimpiar.BorderRadius = 20;
            this.btnLimpiar.BorderSize = 1;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiar.Location = new System.Drawing.Point(371, 97);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 37);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.Black;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cboTipos
            // 
            this.cboTipos.FormattingEnabled = true;
            this.cboTipos.Location = new System.Drawing.Point(607, 44);
            this.cboTipos.Name = "cboTipos";
            this.cboTipos.Size = new System.Drawing.Size(244, 31);
            this.cboTipos.TabIndex = 23;
            this.cboTipos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbEnter_KeyDown);
            // 
            // lblTipoMedicamento
            // 
            this.lblTipoMedicamento.AutoSize = true;
            this.lblTipoMedicamento.BackColor = System.Drawing.Color.White;
            this.lblTipoMedicamento.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMedicamento.Location = new System.Drawing.Point(530, 52);
            this.lblTipoMedicamento.Name = "lblTipoMedicamento";
            this.lblTipoMedicamento.Size = new System.Drawing.Size(55, 23);
            this.lblTipoMedicamento.TabIndex = 22;
            this.lblTipoMedicamento.Text = "Tipo:";
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicamento.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamento.Location = new System.Drawing.Point(25, 52);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(154, 23);
            this.lblMedicamento.TabIndex = 21;
            this.lblMedicamento.Text = "Medicamento:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Gray;
            this.btnSeleccionar.BackgroundColor = System.Drawing.Color.Gray;
            this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccionar.BorderColor = System.Drawing.Color.Green;
            this.btnSeleccionar.BorderRadius = 20;
            this.btnSeleccionar.BorderSize = 1;
            this.btnSeleccionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.Black;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSeleccionar.Location = new System.Drawing.Point(727, 515);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(178, 49);
            this.btnSeleccionar.TabIndex = 45;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextColor = System.Drawing.Color.Black;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnSalir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnSalir.BackgroundImage = global::FarmaTown.Properties.Resources.logout;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.BorderColor = System.Drawing.Color.Green;
            this.btnSalir.BorderRadius = 20;
            this.btnSalir.BorderSize = 1;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1011, 515);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 49);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gray;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.Gray;
            this.btnEliminar.BackgroundImage = global::FarmaTown.Properties.Resources.trash;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.BorderColor = System.Drawing.Color.Green;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 1;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(211, 515);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 49);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gray;
            this.btnEditar.BackgroundColor = System.Drawing.Color.Gray;
            this.btnEditar.BackgroundImage = global::FarmaTown.Properties.Resources.Editor;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.BorderColor = System.Drawing.Color.Green;
            this.btnEditar.BorderRadius = 20;
            this.btnEditar.BorderSize = 1;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEditar.Location = new System.Drawing.Point(120, 515);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(58, 49);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAgregar.BackgroundImage = global::FarmaTown.Properties.Resources.add;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.BorderColor = System.Drawing.Color.Green;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.BorderSize = 1;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.Location = new System.Drawing.Point(22, 515);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 49);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // idMedicamentos
            // 
            this.idMedicamentos.HeaderText = "ID";
            this.idMedicamentos.Name = "idMedicamentos";
            this.idMedicamentos.ReadOnly = true;
            this.idMedicamentos.Visible = false;
            this.idMedicamentos.Width = 50;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo Medicamento";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 200;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio Lista";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 130;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // frmMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.ABMOOSS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1094, 570);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Medicamentos - Farmatown";
            this.Load += new System.EventHandler(this.frmMedicamentos_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private CustomControls.RJControls.RJButton btnActualizar;
        private CustomControls.RJControls.RJButton btnAgregar;
        private CustomControls.RJControls.RJButton btnEditar;
        private CustomControls.RJControls.RJButton btnEliminar;
        private System.Windows.Forms.Label lblAviso;
        private CustomControls.RJControls.RJButton btnSalir;
        private CustomControls.RJControls.RJButton btnSeleccionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbMedicamento;
        private CustomControls.RJControls.RJButton btnConsultar;
        private CustomControls.RJControls.RJButton btnLimpiar;
        private System.Windows.Forms.ComboBox cboTipos;
        private System.Windows.Forms.Label lblTipoMedicamento;
        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}