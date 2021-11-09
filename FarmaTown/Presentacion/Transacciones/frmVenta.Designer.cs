
namespace FarmaTown.Presentacion.Transacciones
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblNombreOS = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.lblImporteTotalSDesc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblImporteTotalCliente = new System.Windows.Forms.Label();
            this.lblAvisoCant = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.idArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reintegro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.btnCancelar = new CustomControls.RJControls.RJButton();
            this.btnAceptar = new CustomControls.RJControls.RJButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFarmacia = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMedioPago = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbClientes.SuspendLayout();
            this.gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(209)))));
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(383, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(23, 33);
            this.lblTitulo.TabIndex = 48;
            this.lblTitulo.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "N° Factura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(631, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Fecha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(42, 65);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(134, 23);
            this.lblUsuario.TabIndex = 50;
            this.lblUsuario.Text = "Tipo Factura:";
            // 
            // gbClientes
            // 
            this.gbClientes.BackColor = System.Drawing.Color.Transparent;
            this.gbClientes.Controls.Add(this.label13);
            this.gbClientes.Controls.Add(this.lblNroDoc);
            this.gbClientes.Controls.Add(this.lblNombreOS);
            this.gbClientes.Controls.Add(this.lblTipoDoc);
            this.gbClientes.Controls.Add(this.lblNombreCliente);
            this.gbClientes.Controls.Add(this.label14);
            this.gbClientes.Controls.Add(this.label15);
            this.gbClientes.Controls.Add(this.label16);
            this.gbClientes.Location = new System.Drawing.Point(21, 187);
            this.gbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Padding = new System.Windows.Forms.Padding(2);
            this.gbClientes.Size = new System.Drawing.Size(909, 121);
            this.gbClientes.TabIndex = 54;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Datos Cliente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(279, 79);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 23);
            this.label13.TabIndex = 24;
            this.label13.Text = "Obra Social:";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.BackColor = System.Drawing.Color.Silver;
            this.lblNroDoc.Location = new System.Drawing.Point(714, 41);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(15, 22);
            this.lblNroDoc.TabIndex = 60;
            this.lblNroDoc.Text = ".";
            // 
            // lblNombreOS
            // 
            this.lblNombreOS.AutoSize = true;
            this.lblNombreOS.BackColor = System.Drawing.Color.Silver;
            this.lblNombreOS.Location = new System.Drawing.Point(417, 79);
            this.lblNombreOS.Name = "lblNombreOS";
            this.lblNombreOS.Size = new System.Drawing.Size(15, 22);
            this.lblNombreOS.TabIndex = 57;
            this.lblNombreOS.Text = ".";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.BackColor = System.Drawing.Color.Silver;
            this.lblTipoDoc.Location = new System.Drawing.Point(415, 40);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(15, 22);
            this.lblTipoDoc.TabIndex = 58;
            this.lblTipoDoc.Text = ".";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.Silver;
            this.lblNombreCliente.Location = new System.Drawing.Point(124, 39);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(15, 22);
            this.lblNombreCliente.TabIndex = 61;
            this.lblNombreCliente.Text = ".";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(306, 39);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 23);
            this.label14.TabIndex = 28;
            this.label14.Text = "Tipo Doc:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(610, 40);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 23);
            this.label15.TabIndex = 12;
            this.label15.Text = "Nro Doc:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 38);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 23);
            this.label16.TabIndex = 9;
            this.label16.Text = "Nombre:";
            // 
            // gbDetalle
            // 
            this.gbDetalle.BackColor = System.Drawing.Color.Transparent;
            this.gbDetalle.Controls.Add(this.lblImporteTotalSDesc);
            this.gbDetalle.Controls.Add(this.label3);
            this.gbDetalle.Controls.Add(this.lblImporteTotalCliente);
            this.gbDetalle.Controls.Add(this.lblAvisoCant);
            this.gbDetalle.Controls.Add(this.label7);
            this.gbDetalle.Controls.Add(this.dgvDetalle);
            this.gbDetalle.Location = new System.Drawing.Point(21, 329);
            this.gbDetalle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbDetalle.Size = new System.Drawing.Size(909, 224);
            this.gbDetalle.TabIndex = 55;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle";
            // 
            // lblImporteTotalSDesc
            // 
            this.lblImporteTotalSDesc.AutoSize = true;
            this.lblImporteTotalSDesc.BackColor = System.Drawing.Color.Silver;
            this.lblImporteTotalSDesc.Location = new System.Drawing.Point(400, 170);
            this.lblImporteTotalSDesc.Name = "lblImporteTotalSDesc";
            this.lblImporteTotalSDesc.Size = new System.Drawing.Size(15, 22);
            this.lblImporteTotalSDesc.TabIndex = 65;
            this.lblImporteTotalSDesc.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 23);
            this.label3.TabIndex = 64;
            this.label3.Text = "Importe total pagado sin descuento:";
            // 
            // lblImporteTotalCliente
            // 
            this.lblImporteTotalCliente.AutoSize = true;
            this.lblImporteTotalCliente.BackColor = System.Drawing.Color.Silver;
            this.lblImporteTotalCliente.Location = new System.Drawing.Point(804, 169);
            this.lblImporteTotalCliente.Name = "lblImporteTotalCliente";
            this.lblImporteTotalCliente.Size = new System.Drawing.Size(15, 22);
            this.lblImporteTotalCliente.TabIndex = 62;
            this.lblImporteTotalCliente.Text = ".";
            // 
            // lblAvisoCant
            // 
            this.lblAvisoCant.AutoSize = true;
            this.lblAvisoCant.BackColor = System.Drawing.Color.IndianRed;
            this.lblAvisoCant.Location = new System.Drawing.Point(647, 76);
            this.lblAvisoCant.Name = "lblAvisoCant";
            this.lblAvisoCant.Size = new System.Drawing.Size(0, 22);
            this.lblAvisoCant.TabIndex = 30;
            this.lblAvisoCant.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAvisoCant.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(460, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Importe total pagado por cliente:";
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
            this.dgvDetalle.Location = new System.Drawing.Point(25, 37);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(870, 108);
            this.dgvDetalle.TabIndex = 17;
            this.dgvDetalle.TabStop = false;
            // 
            // idArticulo
            // 
            this.idArticulo.DataPropertyName = "IdMedicamento";
            this.idArticulo.HeaderText = "Id Art.";
            this.idArticulo.Name = "idArticulo";
            this.idArticulo.ReadOnly = true;
            this.idArticulo.Visible = false;
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
            this.precio.DataPropertyName = "PrecioUnitarioShort";
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
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.BackColor = System.Drawing.Color.Silver;
            this.lblTipoFactura.Location = new System.Drawing.Point(185, 65);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(15, 22);
            this.lblTipoFactura.TabIndex = 56;
            this.lblTipoFactura.Text = ".";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Silver;
            this.lblFecha.Location = new System.Drawing.Point(716, 65);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(15, 22);
            this.lblFecha.TabIndex = 59;
            this.lblFecha.Text = ".";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.BackColor = System.Drawing.Color.Silver;
            this.lblNroFactura.Location = new System.Drawing.Point(495, 65);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(15, 22);
            this.lblNroFactura.TabIndex = 62;
            this.lblNroFactura.Text = ".";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderColor = System.Drawing.Color.Green;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 1;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancelar.Location = new System.Drawing.Point(537, 578);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 49);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.Black;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.BorderColor = System.Drawing.Color.Green;
            this.btnAceptar.BorderRadius = 20;
            this.btnAceptar.BorderSize = 1;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAceptar.Location = new System.Drawing.Point(790, 576);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 49);
            this.btnAceptar.TabIndex = 67;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.Black;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Silver;
            this.lblEstado.Location = new System.Drawing.Point(286, 108);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(15, 22);
            this.lblEstado.TabIndex = 70;
            this.lblEstado.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 69;
            this.label5.Text = "Estado:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Silver;
            this.lblEmpleado.Location = new System.Drawing.Point(172, 151);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(15, 22);
            this.lblEmpleado.TabIndex = 72;
            this.lblEmpleado.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 151);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 23);
            this.label9.TabIndex = 71;
            this.label9.Text = "Empleado:";
            // 
            // lblFarmacia
            // 
            this.lblFarmacia.AutoSize = true;
            this.lblFarmacia.BackColor = System.Drawing.Color.Silver;
            this.lblFarmacia.Location = new System.Drawing.Point(454, 151);
            this.lblFarmacia.Name = "lblFarmacia";
            this.lblFarmacia.Size = new System.Drawing.Size(15, 22);
            this.lblFarmacia.TabIndex = 74;
            this.lblFarmacia.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(328, 151);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 23);
            this.label10.TabIndex = 73;
            this.label10.Text = "Farmacia:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.BackColor = System.Drawing.Color.Silver;
            this.lblLocalidad.Location = new System.Drawing.Point(771, 148);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(15, 22);
            this.lblLocalidad.TabIndex = 76;
            this.lblLocalidad.Text = ".";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(655, 148);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 23);
            this.label11.TabIndex = 75;
            this.label11.Text = "Localidad:";
            // 
            // lblMedioPago
            // 
            this.lblMedioPago.AutoSize = true;
            this.lblMedioPago.BackColor = System.Drawing.Color.Silver;
            this.lblMedioPago.Location = new System.Drawing.Point(655, 107);
            this.lblMedioPago.Name = "lblMedioPago";
            this.lblMedioPago.Size = new System.Drawing.Size(15, 22);
            this.lblMedioPago.TabIndex = 78;
            this.lblMedioPago.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 23);
            this.label6.TabIndex = 77;
            this.label6.Text = "Medio de Pago:";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.Baja_Venta;
            this.ClientSize = new System.Drawing.Size(948, 647);
            this.Controls.Add(this.lblMedioPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblFarmacia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNroFactura);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTipoFactura);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmVenta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja de Venta - FarmaTown";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label lblAvisoCant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblNombreOS;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblImporteTotalCliente;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.Label lblImporteTotalSDesc;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton btnAceptar;
        private CustomControls.RJControls.RJButton btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reintegro;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFarmacia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMedioPago;
        private System.Windows.Forms.Label label6;
    }
}