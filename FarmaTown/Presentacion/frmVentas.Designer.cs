
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
            this.lblAvisoStock = new System.Windows.Forms.Label();
            this.txtbDescuentoOS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbImporteTotal = new System.Windows.Forms.TextBox();
            this.txtbSubtotal = new System.Windows.Forms.TextBox();
            this.txtbDescuento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRehacerDetalle = new CustomControls.RJControls.RJButton();
            this.btnQuitar = new CustomControls.RJControls.RJButton();
            this.btnAgregar = new CustomControls.RJControls.RJButton();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.txtbImporte = new System.Windows.Forms.TextBox();
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
            this.label11 = new System.Windows.Forms.Label();
            this.cboObrasSociales = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbTipoDoc = new System.Windows.Forms.TextBox();
            this.btnBuscCliente = new CustomControls.RJControls.RJButton();
            this.txtbNroDoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.ttDescripcionBtn = new System.Windows.Forms.ToolTip(this.components);
            this.btnGuardar = new CustomControls.RJControls.RJButton();
            this.btnNuevaFactura = new CustomControls.RJControls.RJButton();
            this.btnSalir = new CustomControls.RJControls.RJButton();
            this.idArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reintegro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(49, 26);
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
            this.label1.Location = new System.Drawing.Point(569, 22);
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
            this.label2.Location = new System.Drawing.Point(326, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "N° Factura:";
            // 
            // txtbNroFactura
            // 
            this.txtbNroFactura.BackColor = System.Drawing.Color.Silver;
            this.txtbNroFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNroFactura.Enabled = false;
            this.txtbNroFactura.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbNroFactura.Location = new System.Drawing.Point(457, 27);
            this.txtbNroFactura.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbNroFactura.Name = "txtbNroFactura";
            this.txtbNroFactura.Size = new System.Drawing.Size(74, 22);
            this.txtbNroFactura.TabIndex = 5;
            this.txtbNroFactura.TabStop = false;
            // 
            // dtpFechaActual
            // 
            this.dtpFechaActual.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.dtpFechaActual.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.dtpFechaActual.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.dtpFechaActual.Enabled = false;
            this.dtpFechaActual.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.dtpFechaActual.Location = new System.Drawing.Point(653, 19);
            this.dtpFechaActual.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpFechaActual.MaxDate = new System.DateTime(9988, 12, 31, 0, 0, 0, 0);
            this.dtpFechaActual.MinDate = new System.DateTime(2021, 10, 9, 0, 0, 0, 0);
            this.dtpFechaActual.Name = "dtpFechaActual";
            this.dtpFechaActual.Size = new System.Drawing.Size(229, 32);
            this.dtpFechaActual.TabIndex = 6;
            // 
            // gbDetalle
            // 
            this.gbDetalle.BackColor = System.Drawing.Color.Transparent;
            this.gbDetalle.Controls.Add(this.lblAvisoStock);
            this.gbDetalle.Controls.Add(this.txtbDescuentoOS);
            this.gbDetalle.Controls.Add(this.label12);
            this.gbDetalle.Controls.Add(this.txtbImporteTotal);
            this.gbDetalle.Controls.Add(this.txtbSubtotal);
            this.gbDetalle.Controls.Add(this.txtbDescuento);
            this.gbDetalle.Controls.Add(this.label8);
            this.gbDetalle.Controls.Add(this.label7);
            this.gbDetalle.Controls.Add(this.label6);
            this.gbDetalle.Controls.Add(this.btnRehacerDetalle);
            this.gbDetalle.Controls.Add(this.btnQuitar);
            this.gbDetalle.Controls.Add(this.btnAgregar);
            this.gbDetalle.Controls.Add(this.dgvDetalle);
            this.gbDetalle.Controls.Add(this.txtbImporte);
            this.gbDetalle.Controls.Add(this.txtbPrecio);
            this.gbDetalle.Controls.Add(this.label5);
            this.gbDetalle.Controls.Add(this.label4);
            this.gbDetalle.Controls.Add(this.txtbCantMedicamento);
            this.gbDetalle.Controls.Add(this.label3);
            this.gbDetalle.Controls.Add(this.txtbNomMedicamento);
            this.gbDetalle.Controls.Add(this.btnBuscMedicamento);
            this.gbDetalle.Controls.Add(this.lblMedicamento);
            this.gbDetalle.Location = new System.Drawing.Point(29, 206);
            this.gbDetalle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbDetalle.Size = new System.Drawing.Size(909, 413);
            this.gbDetalle.TabIndex = 7;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle";
            this.gbDetalle.Enter += new System.EventHandler(this.gbDetalle_Enter);
            // 
            // lblAvisoStock
            // 
            this.lblAvisoStock.AutoSize = true;
            this.lblAvisoStock.BackColor = System.Drawing.Color.IndianRed;
            this.lblAvisoStock.Location = new System.Drawing.Point(545, 74);
            this.lblAvisoStock.Name = "lblAvisoStock";
            this.lblAvisoStock.Size = new System.Drawing.Size(156, 22);
            this.lblAvisoStock.TabIndex = 28;
            this.lblAvisoStock.Text = "¡Supera el Stock!";
            this.lblAvisoStock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAvisoStock.Visible = false;
            // 
            // txtbDescuentoOS
            // 
            this.txtbDescuentoOS.BackColor = System.Drawing.Color.Silver;
            this.txtbDescuentoOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbDescuentoOS.Enabled = false;
            this.txtbDescuentoOS.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbDescuentoOS.Location = new System.Drawing.Point(471, 142);
            this.txtbDescuentoOS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbDescuentoOS.Name = "txtbDescuentoOS";
            this.txtbDescuentoOS.Size = new System.Drawing.Size(151, 22);
            this.txtbDescuentoOS.TabIndex = 27;
            this.txtbDescuentoOS.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(177, 142);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(273, 23);
            this.label12.TabIndex = 26;
            this.label12.Text = "Descuento de Obra Social:";
            // 
            // txtbImporteTotal
            // 
            this.txtbImporteTotal.BackColor = System.Drawing.Color.Silver;
            this.txtbImporteTotal.Enabled = false;
            this.txtbImporteTotal.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbImporteTotal.Location = new System.Drawing.Point(710, 365);
            this.txtbImporteTotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbImporteTotal.Name = "txtbImporteTotal";
            this.txtbImporteTotal.Size = new System.Drawing.Size(169, 29);
            this.txtbImporteTotal.TabIndex = 25;
            this.txtbImporteTotal.TabStop = false;
            // 
            // txtbSubtotal
            // 
            this.txtbSubtotal.BackColor = System.Drawing.Color.Silver;
            this.txtbSubtotal.Enabled = false;
            this.txtbSubtotal.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbSubtotal.Location = new System.Drawing.Point(110, 365);
            this.txtbSubtotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbSubtotal.Name = "txtbSubtotal";
            this.txtbSubtotal.Size = new System.Drawing.Size(169, 29);
            this.txtbSubtotal.TabIndex = 23;
            this.txtbSubtotal.TabStop = false;
            // 
            // txtbDescuento
            // 
            this.txtbDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbDescuento.Enabled = false;
            this.txtbDescuento.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbDescuento.Location = new System.Drawing.Point(436, 365);
            this.txtbDescuento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbDescuento.Name = "txtbDescuento";
            this.txtbDescuento.Size = new System.Drawing.Size(106, 29);
            this.txtbDescuento.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(316, 371);
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
            this.label7.Location = new System.Drawing.Point(567, 371);
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
            this.label6.Location = new System.Drawing.Point(17, 371);
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
            this.btnRehacerDetalle.TabIndex = 8;
            this.btnRehacerDetalle.TextColor = System.Drawing.Color.Black;
            this.ttDescripcionBtn.SetToolTip(this.btnRehacerDetalle, "Quitar todos los medicamentos del detalle");
            this.btnRehacerDetalle.UseVisualStyleBackColor = false;
            this.btnRehacerDetalle.Click += new System.EventHandler(this.btnRehacerDetalle_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Gray;
            this.btnQuitar.BackgroundColor = System.Drawing.Color.Gray;
            this.btnQuitar.BackgroundImage = global::FarmaTown.Properties.Resources.delete_1_;
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuitar.BorderColor = System.Drawing.Color.Green;
            this.btnQuitar.BorderRadius = 23;
            this.btnQuitar.BorderSize = 1;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.Enabled = false;
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
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.TextColor = System.Drawing.Color.Black;
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ttDescripcionBtn.SetToolTip(this.btnQuitar, "Quitar medicamento al detalle");
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Gray;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.Gray;
            this.btnAgregar.BackgroundImage = global::FarmaTown.Properties.Resources.add;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.BorderColor = System.Drawing.Color.Green;
            this.btnAgregar.BorderRadius = 23;
            this.btnAgregar.BorderSize = 1;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Enabled = false;
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
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.TextColor = System.Drawing.Color.Black;
            this.ttDescripcionBtn.SetToolTip(this.btnAgregar, "Agregar medicamento al detalle");
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AllowUserToResizeColumns = false;
            this.dgvDetalle.AllowUserToResizeRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticulo,
            this.descripcion,
            this.cantidad,
            this.precio,
            this.Reintegro,
            this.importe});
            this.dgvDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.dgvDetalle.Location = new System.Drawing.Point(18, 179);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(870, 174);
            this.dgvDetalle.TabIndex = 17;
            this.dgvDetalle.TabStop = false;
            this.dgvDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellClick);
            this.dgvDetalle.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellLeave);
            // 
            // txtbImporte
            // 
            this.txtbImporte.BackColor = System.Drawing.Color.Silver;
            this.txtbImporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbImporte.Enabled = false;
            this.txtbImporte.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbImporte.Location = new System.Drawing.Point(580, 99);
            this.txtbImporte.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbImporte.Name = "txtbImporte";
            this.txtbImporte.Size = new System.Drawing.Size(135, 22);
            this.txtbImporte.TabIndex = 16;
            this.txtbImporte.TabStop = false;
            // 
            // txtbPrecio
            // 
            this.txtbPrecio.BackColor = System.Drawing.Color.Silver;
            this.txtbPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPrecio.Enabled = false;
            this.txtbPrecio.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbPrecio.Location = new System.Drawing.Point(260, 93);
            this.txtbPrecio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbPrecio.Name = "txtbPrecio";
            this.txtbPrecio.Size = new System.Drawing.Size(151, 22);
            this.txtbPrecio.TabIndex = 15;
            this.txtbPrecio.TabStop = false;
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
            this.txtbCantMedicamento.TabIndex = 5;
            this.txtbCantMedicamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbCantMedicamento_KeyDown);
            this.txtbCantMedicamento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbCantMedicamento_KeyUp);
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
            this.txtbNomMedicamento.BackColor = System.Drawing.Color.Silver;
            this.txtbNomMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNomMedicamento.Enabled = false;
            this.txtbNomMedicamento.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbNomMedicamento.Location = new System.Drawing.Point(260, 50);
            this.txtbNomMedicamento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbNomMedicamento.Name = "txtbNomMedicamento";
            this.txtbNomMedicamento.Size = new System.Drawing.Size(181, 22);
            this.txtbNomMedicamento.TabIndex = 11;
            this.txtbNomMedicamento.TabStop = false;
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
            this.btnBuscMedicamento.TabIndex = 4;
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
            this.cboTipoFactura.Location = new System.Drawing.Point(193, 23);
            this.cboTipoFactura.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(100, 27);
            this.cboTipoFactura.TabIndex = 1;
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbCliente.Controls.Add(this.label11);
            this.gbCliente.Controls.Add(this.cboObrasSociales);
            this.gbCliente.Controls.Add(this.label10);
            this.gbCliente.Controls.Add(this.txtbTipoDoc);
            this.gbCliente.Controls.Add(this.btnBuscCliente);
            this.gbCliente.Controls.Add(this.txtbNroDoc);
            this.gbCliente.Controls.Add(this.label9);
            this.gbCliente.Controls.Add(this.txtNomCliente);
            this.gbCliente.Controls.Add(this.lblNomCliente);
            this.gbCliente.Location = new System.Drawing.Point(29, 69);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(2);
            this.gbCliente.Size = new System.Drawing.Size(909, 131);
            this.gbCliente.TabIndex = 8;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(256, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 23);
            this.label11.TabIndex = 24;
            this.label11.Text = "Obra Social:";
            // 
            // cboObrasSociales
            // 
            this.cboObrasSociales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.cboObrasSociales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboObrasSociales.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.cboObrasSociales.FormattingEnabled = true;
            this.cboObrasSociales.Location = new System.Drawing.Point(405, 86);
            this.cboObrasSociales.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboObrasSociales.Name = "cboObrasSociales";
            this.cboObrasSociales.Size = new System.Drawing.Size(217, 27);
            this.cboObrasSociales.TabIndex = 3;
            this.cboObrasSociales.SelectionChangeCommitted += new System.EventHandler(this.cboObrasSociales_SelectionChangeCommitted);
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
            // txtbTipoDoc
            // 
            this.txtbTipoDoc.BackColor = System.Drawing.Color.Silver;
            this.txtbTipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbTipoDoc.Enabled = false;
            this.txtbTipoDoc.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbTipoDoc.Location = new System.Drawing.Point(730, 41);
            this.txtbTipoDoc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbTipoDoc.Name = "txtbTipoDoc";
            this.txtbTipoDoc.Size = new System.Drawing.Size(172, 22);
            this.txtbTipoDoc.TabIndex = 27;
            this.txtbTipoDoc.TabStop = false;
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
            this.btnBuscCliente.TabIndex = 2;
            this.btnBuscCliente.TextColor = System.Drawing.Color.Black;
            this.ttDescripcionBtn.SetToolTip(this.btnBuscCliente, "Buscar y seleccionar Cliente");
            this.btnBuscCliente.UseVisualStyleBackColor = false;
            this.btnBuscCliente.Click += new System.EventHandler(this.btnBuscCliente_Click);
            // 
            // txtbNroDoc
            // 
            this.txtbNroDoc.BackColor = System.Drawing.Color.Silver;
            this.txtbNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNroDoc.Enabled = false;
            this.txtbNroDoc.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbNroDoc.Location = new System.Drawing.Point(447, 41);
            this.txtbNroDoc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbNroDoc.Name = "txtbNroDoc";
            this.txtbNroDoc.Size = new System.Drawing.Size(172, 22);
            this.txtbNroDoc.TabIndex = 11;
            this.txtbNroDoc.TabStop = false;
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
            this.txtNomCliente.BackColor = System.Drawing.Color.Silver;
            this.txtNomCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomCliente.Enabled = false;
            this.txtNomCliente.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtNomCliente.Location = new System.Drawing.Point(183, 43);
            this.txtNomCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(148, 22);
            this.txtNomCliente.TabIndex = 9;
            this.txtNomCliente.TabStop = false;
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
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gray;
            this.btnGuardar.BackgroundColor = System.Drawing.Color.Gray;
            this.btnGuardar.BackgroundImage = global::FarmaTown.Properties.Resources.ready;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.BorderColor = System.Drawing.Color.Green;
            this.btnGuardar.BorderRadius = 20;
            this.btnGuardar.BorderSize = 1;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(128, 626);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(53, 49);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.ttDescripcionBtn.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnNuevaFactura.Location = new System.Drawing.Point(29, 626);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(53, 49);
            this.btnNuevaFactura.TabIndex = 22;
            this.btnNuevaFactura.TextColor = System.Drawing.Color.White;
            this.ttDescripcionBtn.SetToolTip(this.btnNuevaFactura, "Nueva factura");
            this.btnNuevaFactura.UseVisualStyleBackColor = false;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(885, 626);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 49);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.ttDescripcionBtn.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // idArticulo
            // 
            this.idArticulo.DataPropertyName = "IdMedicamento";
            this.idArticulo.HeaderText = "Id Art.";
            this.idArticulo.Name = "idArticulo";
            this.idArticulo.ReadOnly = true;
            this.idArticulo.Width = 60;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "Nombre";
            this.descripcion.HeaderText = "Nombre";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "Cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "PrecioUnitario";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 150;
            // 
            // Reintegro
            // 
            this.Reintegro.DataPropertyName = "Reintegro";
            this.Reintegro.HeaderText = "Descuento";
            this.Reintegro.Name = "Reintegro";
            this.Reintegro.ReadOnly = true;
            this.Reintegro.Width = 150;
            // 
            // importe
            // 
            this.importe.DataPropertyName = "Importe";
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            this.importe.ToolTipText = "Precio Unitario x Cantidad";
            this.importe.Width = 150;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.carroVacioVenta;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(966, 686);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmVentas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas - FarmaTown";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
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
        private System.Windows.Forms.TextBox txtbImporte;
        private System.Windows.Forms.DataGridView dgvDetalle;
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
        private System.Windows.Forms.TextBox txtbTipoDoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboObrasSociales;
        private System.Windows.Forms.TextBox txtbDescuentoOS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAvisoStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reintegro;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
    }
}