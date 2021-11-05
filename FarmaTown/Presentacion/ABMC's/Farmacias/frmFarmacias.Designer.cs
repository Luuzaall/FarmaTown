
namespace FarmaTown.Presentacion.Farmacias
{
    partial class frmFarmacias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFarmacias));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbSucursal = new System.Windows.Forms.TextBox();
            this.TextbCalle = new System.Windows.Forms.TextBox();
            this.textbNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new CustomControls.RJControls.RJButton();
            this.btnConsultar = new CustomControls.RJControls.RJButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new CustomControls.RJControls.RJButton();
            this.dgvFarmacias = new System.Windows.Forms.DataGridView();
            this.btnEditar = new CustomControls.RJControls.RJButton();
            this.btnEliminar = new CustomControls.RJControls.RJButton();
            this.btnAgregar = new CustomControls.RJControls.RJButton();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnSalir = new CustomControls.RJControls.RJButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmacias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textbSucursal);
            this.groupBox1.Controls.Add(this.TextbCalle);
            this.groupBox1.Controls.Add(this.textbNumero);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(430, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Debe ingresar al menos uno de los datos";
            // 
            // textbSucursal
            // 
            this.textbSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.textbSucursal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbSucursal.Location = new System.Drawing.Point(141, 31);
            this.textbSucursal.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textbSucursal.Name = "textbSucursal";
            this.textbSucursal.Size = new System.Drawing.Size(244, 25);
            this.textbSucursal.TabIndex = 32;
            this.textbSucursal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbSucursal_KeyDown);
            // 
            // TextbCalle
            // 
            this.TextbCalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.TextbCalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextbCalle.Location = new System.Drawing.Point(141, 76);
            this.TextbCalle.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.TextbCalle.Name = "TextbCalle";
            this.TextbCalle.Size = new System.Drawing.Size(244, 25);
            this.TextbCalle.TabIndex = 31;
            this.TextbCalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextbCalle_KeyDown);
            // 
            // textbNumero
            // 
            this.textbNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.textbNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbNumero.Location = new System.Drawing.Point(534, 31);
            this.textbNumero.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textbNumero.Name = "textbNumero";
            this.textbNumero.Size = new System.Drawing.Size(244, 25);
            this.textbNumero.TabIndex = 30;
            this.textbNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbNumero_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Calle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sucursal:";
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
            this.btnLimpiar.Location = new System.Drawing.Point(255, 114);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 37);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.Black;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnConsultar.Location = new System.Drawing.Point(447, 114);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(104, 37);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.Black;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.dgvFarmacias);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(23, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(906, 282);
            this.groupBox2.TabIndex = 1;
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
            this.btnActualizar.Location = new System.Drawing.Point(796, 127);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 37);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Black;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvFarmacias
            // 
            this.dgvFarmacias.AllowUserToAddRows = false;
            this.dgvFarmacias.AllowUserToDeleteRows = false;
            this.dgvFarmacias.AllowUserToResizeColumns = false;
            this.dgvFarmacias.AllowUserToResizeRows = false;
            this.dgvFarmacias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.dgvFarmacias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFarmacias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Sucursal,
            this.Calle,
            this.Número,
            this.Barrio});
            this.dgvFarmacias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFarmacias.Location = new System.Drawing.Point(6, 39);
            this.dgvFarmacias.Name = "dgvFarmacias";
            this.dgvFarmacias.ReadOnly = true;
            this.dgvFarmacias.RowHeadersWidth = 51;
            this.dgvFarmacias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFarmacias.Size = new System.Drawing.Size(784, 237);
            this.dgvFarmacias.TabIndex = 13;
            this.dgvFarmacias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFarmacias_CellClick);
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
            this.btnEditar.Location = new System.Drawing.Point(131, 501);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(58, 49);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.TextColor = System.Drawing.Color.White;
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
            this.btnEliminar.Location = new System.Drawing.Point(240, 501);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 49);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAgregar.BackgroundImage = global::FarmaTown.Properties.Resources.pharmacy;
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
            this.btnAgregar.Location = new System.Drawing.Point(30, 501);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 49);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblAviso.ForeColor = System.Drawing.Color.Maroon;
            this.lblAviso.Location = new System.Drawing.Point(349, 523);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(312, 22);
            this.lblAviso.TabIndex = 23;
            this.lblAviso.Text = "Debe elegir una farmacia primero";
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
            this.btnSalir.Location = new System.Drawing.Point(876, 501);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 49);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.MinimumWidth = 6;
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            this.Sucursal.Width = 200;
            // 
            // Calle
            // 
            this.Calle.HeaderText = "Calle";
            this.Calle.MinimumWidth = 6;
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            this.Calle.Width = 200;
            // 
            // Número
            // 
            this.Número.HeaderText = "Número";
            this.Número.MinimumWidth = 6;
            this.Número.Name = "Número";
            this.Número.ReadOnly = true;
            this.Número.Width = 125;
            // 
            // Barrio
            // 
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.MinimumWidth = 6;
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            this.Barrio.Width = 200;
            // 
            // frmFarmacias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(953, 562);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFarmacias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Farmacias - FarmaTown";
            this.Load += new System.EventHandler(this.frmFarmacias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmacias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvFarmacias;
        private CustomControls.RJControls.RJButton btnEditar;
        private CustomControls.RJControls.RJButton btnEliminar;
        private CustomControls.RJControls.RJButton btnAgregar;
        private System.Windows.Forms.Label lblAviso;
        private CustomControls.RJControls.RJButton btnSalir;
        private CustomControls.RJControls.RJButton btnLimpiar;
        private CustomControls.RJControls.RJButton btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton btnActualizar;
        private System.Windows.Forms.TextBox textbSucursal;
        private System.Windows.Forms.TextBox TextbCalle;
        private System.Windows.Forms.TextBox textbNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
    }
}