
namespace FarmaTown.Presentacion.ABMC_s.TiposDocumento
{
    partial class frmTiposDoc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposDoc));
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.lblPalabraClave = new System.Windows.Forms.Label();
            this.txtbPalabraClave = new System.Windows.Forms.TextBox();
            this.btnConsultar = new CustomControls.RJControls.RJButton();
            this.btnLimpiar = new CustomControls.RJControls.RJButton();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new CustomControls.RJControls.RJButton();
            this.dgvTiposDoc = new System.Windows.Forms.DataGridView();
            this.btnSalir = new CustomControls.RJControls.RJButton();
            this.btnEditar = new CustomControls.RJControls.RJButton();
            this.btnEliminar = new CustomControls.RJControls.RJButton();
            this.btnAgregar = new CustomControls.RJControls.RJButton();
            this.ttipBtnABM = new System.Windows.Forms.ToolTip(this.components);
            this.lblAviso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTiposDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomTiposDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltros.SuspendLayout();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNombre.Location = new System.Drawing.Point(141, 59);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(200, 25);
            this.txtbNombre.TabIndex = 1;
            this.txtbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbNombre_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltros.Controls.Add(this.lblPalabraClave);
            this.gbFiltros.Controls.Add(this.txtbPalabraClave);
            this.gbFiltros.Controls.Add(this.btnConsultar);
            this.gbFiltros.Controls.Add(this.btnLimpiar);
            this.gbFiltros.Controls.Add(this.txtbNombre);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Location = new System.Drawing.Point(22, 81);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(789, 162);
            this.gbFiltros.TabIndex = 13;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // lblPalabraClave
            // 
            this.lblPalabraClave.AutoSize = true;
            this.lblPalabraClave.BackColor = System.Drawing.Color.Transparent;
            this.lblPalabraClave.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabraClave.Location = new System.Drawing.Point(382, 59);
            this.lblPalabraClave.Name = "lblPalabraClave";
            this.lblPalabraClave.Size = new System.Drawing.Size(132, 23);
            this.lblPalabraClave.TabIndex = 14;
            this.lblPalabraClave.Text = "Descripción:";
            // 
            // txtbPalabraClave
            // 
            this.txtbPalabraClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbPalabraClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPalabraClave.Location = new System.Drawing.Point(523, 59);
            this.txtbPalabraClave.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtbPalabraClave.Name = "txtbPalabraClave";
            this.txtbPalabraClave.Size = new System.Drawing.Size(200, 25);
            this.txtbPalabraClave.TabIndex = 2;
            this.txtbPalabraClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbPalabraClave_KeyDown);
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
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnConsultar.Location = new System.Drawing.Point(451, 102);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(115, 39);
            this.btnConsultar.TabIndex = 3;
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
            this.btnLimpiar.Location = new System.Drawing.Point(249, 102);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 38);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.Black;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gbResultados
            // 
            this.gbResultados.BackColor = System.Drawing.Color.Transparent;
            this.gbResultados.Controls.Add(this.btnActualizar);
            this.gbResultados.Controls.Add(this.dgvTiposDoc);
            this.gbResultados.Location = new System.Drawing.Point(22, 267);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(789, 268);
            this.gbResultados.TabIndex = 31;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
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
            this.btnActualizar.Location = new System.Drawing.Point(666, 130);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 37);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Black;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvTiposDoc
            // 
            this.dgvTiposDoc.AllowUserToAddRows = false;
            this.dgvTiposDoc.AllowUserToDeleteRows = false;
            this.dgvTiposDoc.AllowUserToResizeRows = false;
            this.dgvTiposDoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.dgvTiposDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTiposDoc,
            this.nomTiposDoc,
            this.descripcion});
            this.dgvTiposDoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.dgvTiposDoc.Location = new System.Drawing.Point(22, 33);
            this.dgvTiposDoc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvTiposDoc.MultiSelect = false;
            this.dgvTiposDoc.Name = "dgvTiposDoc";
            this.dgvTiposDoc.ReadOnly = true;
            this.dgvTiposDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiposDoc.Size = new System.Drawing.Size(633, 218);
            this.dgvTiposDoc.TabIndex = 60;
            this.dgvTiposDoc.TabStop = false;
            this.dgvTiposDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiposDocumento_CellClick);
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
            this.btnSalir.Location = new System.Drawing.Point(758, 541);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 49);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.ttipBtnABM.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(114, 541);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(58, 49);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.ttipBtnABM.SetToolTip(this.btnEditar, "Modificar Tipo de Documento selecionado");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(209, 541);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 49);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.ttipBtnABM.SetToolTip(this.btnEliminar, "Deshabilitar Tipo de Documento seleccionado");
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAgregar.BackgroundImage = global::FarmaTown.Properties.Resources.addDocument;
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
            this.btnAgregar.Location = new System.Drawing.Point(22, 541);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(57, 49);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.ttipBtnABM.SetToolTip(this.btnAgregar, "Agregar Tipo de Documento");
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblAviso.ForeColor = System.Drawing.Color.Maroon;
            this.lblAviso.Location = new System.Drawing.Point(301, 541);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(213, 44);
            this.lblAviso.TabIndex = 41;
            this.lblAviso.Text = "Debe elegir un tipo de \r\ndocumento primero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(209)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 33);
            this.label2.TabIndex = 42;
            this.label2.Text = "Consulta Tipos Documento";
            // 
            // idTiposDoc
            // 
            this.idTiposDoc.HeaderText = "ID";
            this.idTiposDoc.Name = "idTiposDoc";
            this.idTiposDoc.ReadOnly = true;
            this.idTiposDoc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idTiposDoc.Visible = false;
            this.idTiposDoc.Width = 30;
            // 
            // nomTiposDoc
            // 
            this.nomTiposDoc.HeaderText = "Nombre";
            this.nomTiposDoc.Name = "nomTiposDoc";
            this.nomTiposDoc.ReadOnly = true;
            this.nomTiposDoc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nomTiposDoc.Width = 200;
            // 
            // descripcion
            // 
            this.descripcion.FillWeight = 250F;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 389;
            // 
            // frmTiposDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.frmTiposDoc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(841, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbFiltros);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmTiposDoc";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Tipos Documento - FarmaTown";
            this.Load += new System.EventHandler(this.frmTipoDoc_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.gbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFiltros;
        private CustomControls.RJControls.RJButton btnLimpiar;
        private CustomControls.RJControls.RJButton btnConsultar;
        private System.Windows.Forms.GroupBox gbResultados;
        private CustomControls.RJControls.RJButton btnActualizar;
        private System.Windows.Forms.DataGridView dgvTiposDoc;
        private CustomControls.RJControls.RJButton btnSalir;
        private CustomControls.RJControls.RJButton btnEditar;
        private CustomControls.RJControls.RJButton btnEliminar;
        private CustomControls.RJControls.RJButton btnAgregar;
        private System.Windows.Forms.ToolTip ttipBtnABM;
        private System.Windows.Forms.Label lblPalabraClave;
        private System.Windows.Forms.TextBox txtbPalabraClave;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTiposDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomTiposDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}