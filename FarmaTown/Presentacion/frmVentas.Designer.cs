﻿
namespace FarmaTown.Presentacion
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNroFactura = new System.Windows.Forms.TextBox();
            this.dtpFechaActual = new System.Windows.Forms.DateTimePicker();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.txtbImporteTotal = new System.Windows.Forms.TextBox();
            this.txtbSubtotal = new System.Windows.Forms.TextBox();
            this.txtbDescuento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRehacerDetalle = new CustomControls.RJControls.RJButton();
            this.btnQuitar = new CustomControls.RJControls.RJButton();
            this.btnAgregar = new CustomControls.RJControls.RJButton();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.idArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtbPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbCantMedicamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbNomMedicamento = new System.Windows.Forms.TextBox();
            this.btnBuscMedicamento = new CustomControls.RJControls.RJButton();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBuscCliente = new CustomControls.RJControls.RJButton();
            this.txtbNroDoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.btnSalir = new CustomControls.RJControls.RJButton();
            this.btnNuevaFactura = new CustomControls.RJControls.RJButton();
            this.btnGuardar = new CustomControls.RJControls.RJButton();
            this.ttDescripcionBtn = new System.Windows.Forms.ToolTip(this.components);
            this.gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(46, 33);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(134, 23);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Tipo Factura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(566, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "N° Factura:";
            // 
            // txtbNroFactura
            // 
            this.txtbNroFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNroFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNroFactura.Enabled = false;
            this.txtbNroFactura.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbNroFactura.Location = new System.Drawing.Point(190, 88);
            this.txtbNroFactura.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbNroFactura.Name = "txtbNroFactura";
            this.txtbNroFactura.Size = new System.Drawing.Size(74, 22);
            this.txtbNroFactura.TabIndex = 5;
            // 
            // dtpFechaActual
            // 
            this.dtpFechaActual.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.dtpFechaActual.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.dtpFechaActual.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.dtpFechaActual.Enabled = false;
            this.dtpFechaActual.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.dtpFechaActual.Location = new System.Drawing.Point(650, 26);
            this.dtpFechaActual.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpFechaActual.MaxDate = new System.DateTime(9988, 12, 31, 0, 0, 0, 0);
            this.dtpFechaActual.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpFechaActual.Name = "dtpFechaActual";
            this.dtpFechaActual.Size = new System.Drawing.Size(229, 32);
            this.dtpFechaActual.TabIndex = 6;
            // 
            // gbDetalle
            // 
            this.gbDetalle.BackColor = System.Drawing.Color.Transparent;
            this.gbDetalle.Controls.Add(this.txtbImporteTotal);
            this.gbDetalle.Controls.Add(this.txtbSubtotal);
            this.gbDetalle.Controls.Add(this.txtbDescuento);
            this.gbDetalle.Controls.Add(this.label8);
            this.gbDetalle.Controls.Add(this.label7);
            this.gbDetalle.Controls.Add(this.label6);
            this.gbDetalle.Controls.Add(this.btnRehacerDetalle);
            this.gbDetalle.Controls.Add(this.btnQuitar);
            this.gbDetalle.Controls.Add(this.btnAgregar);
            this.gbDetalle.Controls.Add(this.dgvMedicamentos);
            this.gbDetalle.Controls.Add(this.textBox1);
            this.gbDetalle.Controls.Add(this.txtbPrecio);
            this.gbDetalle.Controls.Add(this.label5);
            this.gbDetalle.Controls.Add(this.label4);
            this.gbDetalle.Controls.Add(this.txtbCantMedicamento);
            this.gbDetalle.Controls.Add(this.label3);
            this.gbDetalle.Controls.Add(this.txtbNomMedicamento);
            this.gbDetalle.Controls.Add(this.btnBuscMedicamento);
            this.gbDetalle.Controls.Add(this.lblMedicamento);
            this.gbDetalle.Location = new System.Drawing.Point(28, 220);
            this.gbDetalle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbDetalle.Size = new System.Drawing.Size(909, 446);
            this.gbDetalle.TabIndex = 7;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle";
            // 
            // txtbImporteTotal
            // 
            this.txtbImporteTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbImporteTotal.Enabled = false;
            this.txtbImporteTotal.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbImporteTotal.Location = new System.Drawing.Point(682, 395);
            this.txtbImporteTotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbImporteTotal.Name = "txtbImporteTotal";
            this.txtbImporteTotal.Size = new System.Drawing.Size(151, 29);
            this.txtbImporteTotal.TabIndex = 25;
            // 
            // txtbSubtotal
            // 
            this.txtbSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbSubtotal.Enabled = false;
            this.txtbSubtotal.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbSubtotal.Location = new System.Drawing.Point(682, 327);
            this.txtbSubtotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbSubtotal.Name = "txtbSubtotal";
            this.txtbSubtotal.Size = new System.Drawing.Size(151, 29);
            this.txtbSubtotal.TabIndex = 23;
            // 
            // txtbDescuento
            // 
            this.txtbDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbDescuento.Enabled = false;
            this.txtbDescuento.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbDescuento.Location = new System.Drawing.Point(682, 359);
            this.txtbDescuento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbDescuento.Name = "txtbDescuento";
            this.txtbDescuento.Size = new System.Drawing.Size(151, 29);
            this.txtbDescuento.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(525, 365);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Descuento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(525, 401);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Importe Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 333);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Subtotal:";
            // 
            // btnRehacerDetalle
            // 
            this.btnRehacerDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnRehacerDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnRehacerDetalle.BackgroundImage = global::FarmaTown.Properties.Resources.rehacer;
            this.btnRehacerDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRehacerDetalle.BorderColor = System.Drawing.Color.Green;
            this.btnRehacerDetalle.BorderRadius = 23;
            this.btnRehacerDetalle.BorderSize = 1;
            this.btnRehacerDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRehacerDetalle.FlatAppearance.BorderSize = 0;
            this.btnRehacerDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRehacerDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRehacerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRehacerDetalle.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRehacerDetalle.ForeColor = System.Drawing.Color.Black;
            this.btnRehacerDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRehacerDetalle.Location = new System.Drawing.Point(836, 48);
            this.btnRehacerDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.btnRehacerDetalle.Name = "btnRehacerDetalle";
            this.btnRehacerDetalle.Size = new System.Drawing.Size(43, 43);
            this.btnRehacerDetalle.TabIndex = 19;
            this.btnRehacerDetalle.TextColor = System.Drawing.Color.Black;
            this.ttDescripcionBtn.SetToolTip(this.btnRehacerDetalle, "Quitar todos los medicamentos del detalle");
            this.btnRehacerDetalle.UseVisualStyleBackColor = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnQuitar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnQuitar.BackgroundImage = global::FarmaTown.Properties.Resources.delete_1_;
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuitar.BorderColor = System.Drawing.Color.Green;
            this.btnQuitar.BorderRadius = 23;
            this.btnQuitar.BorderSize = 1;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.Black;
            this.btnQuitar.Location = new System.Drawing.Point(775, 48);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(43, 43);
            this.btnQuitar.TabIndex = 18;
            this.btnQuitar.TextColor = System.Drawing.Color.Black;
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ttDescripcionBtn.SetToolTip(this.btnQuitar, "Quitar medicamento al detalle");
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAgregar.BackgroundImage = global::FarmaTown.Properties.Resources.add;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.BorderColor = System.Drawing.Color.Green;
            this.btnAgregar.BorderRadius = 23;
            this.btnAgregar.BorderSize = 1;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(713, 48);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(43, 43);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.TextColor = System.Drawing.Color.Black;
            this.ttDescripcionBtn.SetToolTip(this.btnAgregar, "Agregar medicamento al detalle");
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.AllowUserToAddRows = false;
            this.dgvMedicamentos.AllowUserToDeleteRows = false;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticulo,
            this.descripcion,
            this.cantidad,
            this.precio,
            this.importe});
            this.dgvMedicamentos.Location = new System.Drawing.Point(21, 147);
            this.dgvMedicamentos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.ReadOnly = true;
            this.dgvMedicamentos.Size = new System.Drawing.Size(870, 164);
            this.dgvMedicamentos.TabIndex = 17;
            // 
            // idArticulo
            // 
            this.idArticulo.HeaderText = "Id Art.";
            this.idArticulo.Name = "idArticulo";
            this.idArticulo.ReadOnly = true;
            this.idArticulo.Width = 60;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 350;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cant";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 150;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            this.importe.Width = 150;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(580, 99);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 22);
            this.textBox1.TabIndex = 16;
            // 
            // txtbPrecio
            // 
            this.txtbPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPrecio.Enabled = false;
            this.txtbPrecio.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbPrecio.Location = new System.Drawing.Point(260, 93);
            this.txtbPrecio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbPrecio.Name = "txtbPrecio";
            this.txtbPrecio.Size = new System.Drawing.Size(151, 22);
            this.txtbPrecio.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(463, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Importe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Precio:";
            // 
            // txtbCantMedicamento
            // 
            this.txtbCantMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbCantMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbCantMedicamento.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbCantMedicamento.Location = new System.Drawing.Point(580, 50);
            this.txtbCantMedicamento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbCantMedicamento.Name = "txtbCantMedicamento";
            this.txtbCantMedicamento.Size = new System.Drawing.Size(76, 22);
            this.txtbCantMedicamento.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cantidad:";
            // 
            // txtbNomMedicamento
            // 
            this.txtbNomMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNomMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNomMedicamento.Enabled = false;
            this.txtbNomMedicamento.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbNomMedicamento.Location = new System.Drawing.Point(260, 50);
            this.txtbNomMedicamento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbNomMedicamento.Name = "txtbNomMedicamento";
            this.txtbNomMedicamento.Size = new System.Drawing.Size(151, 22);
            this.txtbNomMedicamento.TabIndex = 11;
            // 
            // btnBuscMedicamento
            // 
            this.btnBuscMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnBuscMedicamento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnBuscMedicamento.BackgroundImage = global::FarmaTown.Properties.Resources.search;
            this.btnBuscMedicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscMedicamento.BorderColor = System.Drawing.Color.Green;
            this.btnBuscMedicamento.BorderRadius = 20;
            this.btnBuscMedicamento.BorderSize = 1;
            this.btnBuscMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscMedicamento.FlatAppearance.BorderSize = 0;
            this.btnBuscMedicamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBuscMedicamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnBuscMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscMedicamento.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscMedicamento.ForeColor = System.Drawing.Color.Black;
            this.btnBuscMedicamento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscMedicamento.Location = new System.Drawing.Point(21, 50);
            this.btnBuscMedicamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscMedicamento.Name = "btnBuscMedicamento";
            this.btnBuscMedicamento.Size = new System.Drawing.Size(50, 39);
            this.btnBuscMedicamento.TabIndex = 11;
            this.btnBuscMedicamento.TextColor = System.Drawing.Color.Black;
            this.ttDescripcionBtn.SetToolTip(this.btnBuscMedicamento, "Buscar y seleccionar Medicamento");
            this.btnBuscMedicamento.UseVisualStyleBackColor = false;
            this.btnBuscMedicamento.Click += new System.EventHandler(this.btnBuscMedicamento_Click);
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicamento.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamento.Location = new System.Drawing.Point(82, 48);
            this.lblMedicamento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(154, 23);
            this.lblMedicamento.TabIndex = 8;
            this.lblMedicamento.Text = "Medicamento:";
            // 
            // cboTipoFactura
            // 
            this.cboTipoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.cboTipoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoFactura.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Location = new System.Drawing.Point(190, 30);
            this.cboTipoFactura.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(217, 27);
            this.cboTipoFactura.TabIndex = 3;
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbCliente.Controls.Add(this.label10);
            this.gbCliente.Controls.Add(this.textBox2);
            this.gbCliente.Controls.Add(this.btnBuscCliente);
            this.gbCliente.Controls.Add(this.txtbNroDoc);
            this.gbCliente.Controls.Add(this.label9);
            this.gbCliente.Controls.Add(this.txtNomCliente);
            this.gbCliente.Controls.Add(this.lblNomCliente);
            this.gbCliente.Location = new System.Drawing.Point(28, 116);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(2);
            this.gbCliente.Size = new System.Drawing.Size(909, 85);
            this.gbCliente.TabIndex = 8;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(629, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 23);
            this.label10.TabIndex = 28;
            this.label10.Text = "Tipo Doc:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(730, 41);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 22);
            this.textBox2.TabIndex = 27;
            // 
            // btnBuscCliente
            // 
            this.btnBuscCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnBuscCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnBuscCliente.BackgroundImage = global::FarmaTown.Properties.Resources.search;
            this.btnBuscCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscCliente.BorderColor = System.Drawing.Color.Green;
            this.btnBuscCliente.BorderRadius = 20;
            this.btnBuscCliente.BorderSize = 1;
            this.btnBuscCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBuscCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnBuscCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscCliente.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscCliente.ForeColor = System.Drawing.Color.Black;
            this.btnBuscCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscCliente.Location = new System.Drawing.Point(18, 30);
            this.btnBuscCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscCliente.Name = "btnBuscCliente";
            this.btnBuscCliente.Size = new System.Drawing.Size(50, 39);
            this.btnBuscCliente.TabIndex = 26;
            this.btnBuscCliente.TextColor = System.Drawing.Color.Black;
            this.ttDescripcionBtn.SetToolTip(this.btnBuscCliente, "Buscar y seleccionar Cliente");
            this.btnBuscCliente.UseVisualStyleBackColor = false;
            this.btnBuscCliente.Click += new System.EventHandler(this.btnBuscCliente_Click);
            // 
            // txtbNroDoc
            // 
            this.txtbNroDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNroDoc.Enabled = false;
            this.txtbNroDoc.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbNroDoc.Location = new System.Drawing.Point(447, 41);
            this.txtbNroDoc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbNroDoc.Name = "txtbNroDoc";
            this.txtbNroDoc.Size = new System.Drawing.Size(172, 22);
            this.txtbNroDoc.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(341, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nro Doc:";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtNomCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomCliente.Enabled = false;
            this.txtNomCliente.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtNomCliente.Location = new System.Drawing.Point(183, 43);
            this.txtNomCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(148, 22);
            this.txtNomCliente.TabIndex = 9;
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNomCliente.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCliente.Location = new System.Drawing.Point(77, 40);
            this.lblNomCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(95, 23);
            this.lblNomCliente.TabIndex = 9;
            this.lblNomCliente.Text = "Nombre:";
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
            this.btnSalir.Location = new System.Drawing.Point(884, 673);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 49);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.ttDescripcionBtn.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnNuevaFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnNuevaFactura.BackgroundImage = global::FarmaTown.Properties.Resources.addDocument;
            this.btnNuevaFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevaFactura.BorderColor = System.Drawing.Color.Green;
            this.btnNuevaFactura.BorderRadius = 20;
            this.btnNuevaFactura.BorderSize = 1;
            this.btnNuevaFactura.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNuevaFactura.FlatAppearance.BorderSize = 0;
            this.btnNuevaFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnNuevaFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNuevaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaFactura.ForeColor = System.Drawing.Color.White;
            this.btnNuevaFactura.Location = new System.Drawing.Point(28, 673);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(53, 49);
            this.btnNuevaFactura.TabIndex = 22;
            this.btnNuevaFactura.TextColor = System.Drawing.Color.White;
            this.ttDescripcionBtn.SetToolTip(this.btnNuevaFactura, "Nueva factura");
            this.btnNuevaFactura.UseVisualStyleBackColor = false;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnGuardar.BackgroundImage = global::FarmaTown.Properties.Resources.ready;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.BorderColor = System.Drawing.Color.Green;
            this.btnGuardar.BorderRadius = 20;
            this.btnGuardar.BorderSize = 1;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(127, 673);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(53, 49);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.ttDescripcionBtn.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.carroVacioVenta;
            this.ClientSize = new System.Drawing.Size(962, 734);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevaFactura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.dtpFechaActual);
            this.Controls.Add(this.txtbNroFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipoFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuario);
            this.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmVentas";
            this.Text = "Ventas - FarmaTown";
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNroFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaActual;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.ComboBox cboTipoFactura;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.TextBox txtbNomMedicamento;
        private CustomControls.RJControls.RJButton btnBuscMedicamento;
        private System.Windows.Forms.TextBox txtbPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbCantMedicamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private CustomControls.RJControls.RJButton btnAgregar;
        private CustomControls.RJControls.RJButton btnRehacerDetalle;
        private CustomControls.RJControls.RJButton btnQuitar;
        private System.Windows.Forms.TextBox txtbNroDoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbImporteTotal;
        private System.Windows.Forms.TextBox txtbSubtotal;
        private System.Windows.Forms.TextBox txtbDescuento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJButton btnSalir;
        private CustomControls.RJControls.RJButton btnNuevaFactura;
        private CustomControls.RJControls.RJButton btnGuardar;
        private CustomControls.RJControls.RJButton btnBuscCliente;
        private System.Windows.Forms.ToolTip ttDescripcionBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
    }
}