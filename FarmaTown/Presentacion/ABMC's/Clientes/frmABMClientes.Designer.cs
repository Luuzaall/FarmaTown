
namespace FarmaTown.Presentacion.ABMC_s.Clientes
{
    partial class frmABMClientes
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
            System.Windows.Forms.GroupBox gbClientes;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMClientes));
            this.lblApeCli = new System.Windows.Forms.Label();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblNomCli = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbPasaporteLetras = new System.Windows.Forms.TextBox();
            this.txtbPasaporteNro = new System.Windows.Forms.TextBox();
            this.lblAvisoNroDoc = new System.Windows.Forms.Label();
            this.txtbNroDoc = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtbNumero = new System.Windows.Forms.TextBox();
            this.txtbCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnAgregarBarrio = new CustomControls.RJControls.RJButton();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.btnAceptar = new CustomControls.RJControls.RJButton();
            this.btnCancelar = new CustomControls.RJControls.RJButton();
            this.gbUbicacion = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new CustomControls.RJControls.RJButton();
            this.gbFiltrosFarm = new System.Windows.Forms.GroupBox();
            this.txtbNombreBarrio = new System.Windows.Forms.TextBox();
            this.btnConsultarUbicacion = new CustomControls.RJControls.RJButton();
            this.btnLimpiarUbicacion = new CustomControls.RJControls.RJButton();
            this.dgvBarrios = new System.Windows.Forms.DataGridView();
            this.btnLimpiarCliente = new CustomControls.RJControls.RJButton();
            this.txtbLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblBarriosDGV = new System.Windows.Forms.Label();
            this.idBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gbClientes = new System.Windows.Forms.GroupBox();
            gbClientes.SuspendLayout();
            this.gbUbicacion.SuspendLayout();
            this.gbFiltrosFarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbClientes
            // 
            gbClientes.BackColor = System.Drawing.Color.Transparent;
            gbClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            gbClientes.Controls.Add(this.btnLimpiarCliente);
            gbClientes.Controls.Add(this.lblApeCli);
            gbClientes.Controls.Add(this.txtbApellido);
            gbClientes.Controls.Add(this.lblTipoDoc);
            gbClientes.Controls.Add(this.lblNroDoc);
            gbClientes.Controls.Add(this.lblNomCli);
            gbClientes.Controls.Add(this.txtbNombre);
            gbClientes.Controls.Add(this.txtbPasaporteLetras);
            gbClientes.Controls.Add(this.txtbPasaporteNro);
            gbClientes.Controls.Add(this.lblAvisoNroDoc);
            gbClientes.Controls.Add(this.txtbNroDoc);
            gbClientes.Controls.Add(this.lblAviso);
            gbClientes.Controls.Add(this.cboTipoDoc);
            gbClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            gbClientes.Location = new System.Drawing.Point(12, 26);
            gbClientes.Name = "gbClientes";
            gbClientes.Size = new System.Drawing.Size(871, 180);
            gbClientes.TabIndex = 31;
            gbClientes.TabStop = false;
            gbClientes.Text = "Datos del Cliente";
            // 
            // lblApeCli
            // 
            this.lblApeCli.AutoSize = true;
            this.lblApeCli.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblApeCli.Location = new System.Drawing.Point(16, 70);
            this.lblApeCli.Name = "lblApeCli";
            this.lblApeCli.Size = new System.Drawing.Size(123, 23);
            this.lblApeCli.TabIndex = 33;
            this.lblApeCli.Text = "Apellido(*):";
            // 
            // txtbApellido
            // 
            this.txtbApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbApellido.Location = new System.Drawing.Point(148, 73);
            this.txtbApellido.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(223, 20);
            this.txtbApellido.TabIndex = 32;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblTipoDoc.Location = new System.Drawing.Point(399, 37);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(201, 23);
            this.lblTipoDoc.TabIndex = 31;
            this.lblTipoDoc.Text = "Tipo Documento(*):";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNroDoc.Location = new System.Drawing.Point(415, 70);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(185, 23);
            this.lblNroDoc.TabIndex = 30;
            this.lblNroDoc.Text = "N° Documento(*):";
            // 
            // lblNomCli
            // 
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNomCli.Location = new System.Drawing.Point(19, 37);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(120, 23);
            this.lblNomCli.TabIndex = 25;
            this.lblNomCli.Text = "Nombre(*):";
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNombre.Location = new System.Drawing.Point(148, 40);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(223, 20);
            this.txtbNombre.TabIndex = 1;
            // 
            // txtbPasaporteLetras
            // 
            this.txtbPasaporteLetras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbPasaporteLetras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPasaporteLetras.Enabled = false;
            this.txtbPasaporteLetras.Location = new System.Drawing.Point(609, 73);
            this.txtbPasaporteLetras.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbPasaporteLetras.Name = "txtbPasaporteLetras";
            this.txtbPasaporteLetras.Size = new System.Drawing.Size(86, 20);
            this.txtbPasaporteLetras.TabIndex = 3;
            this.txtbPasaporteLetras.Visible = false;
            // 
            // txtbPasaporteNro
            // 
            this.txtbPasaporteNro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbPasaporteNro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPasaporteNro.Enabled = false;
            this.txtbPasaporteNro.Location = new System.Drawing.Point(725, 73);
            this.txtbPasaporteNro.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbPasaporteNro.Name = "txtbPasaporteNro";
            this.txtbPasaporteNro.Size = new System.Drawing.Size(95, 20);
            this.txtbPasaporteNro.TabIndex = 3;
            this.txtbPasaporteNro.Visible = false;
            // 
            // lblAvisoNroDoc
            // 
            this.lblAvisoNroDoc.AutoSize = true;
            this.lblAvisoNroDoc.BackColor = System.Drawing.Color.IndianRed;
            this.lblAvisoNroDoc.Location = new System.Drawing.Point(630, 96);
            this.lblAvisoNroDoc.Name = "lblAvisoNroDoc";
            this.lblAvisoNroDoc.Size = new System.Drawing.Size(0, 19);
            this.lblAvisoNroDoc.TabIndex = 24;
            this.lblAvisoNroDoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbNroDoc
            // 
            this.txtbNroDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNroDoc.Enabled = false;
            this.txtbNroDoc.Location = new System.Drawing.Point(609, 73);
            this.txtbNroDoc.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbNroDoc.Name = "txtbNroDoc";
            this.txtbNroDoc.Size = new System.Drawing.Size(211, 20);
            this.txtbNroDoc.TabIndex = 3;
            this.txtbNroDoc.Visible = false;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.lblAviso.Location = new System.Drawing.Point(176, 112);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(161, 38);
            this.lblAviso.TabIndex = 23;
            this.lblAviso.Text = "Los campos con (*) \r\nson obligatorios";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(609, 37);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(211, 27);
            this.cboTipoDoc.TabIndex = 2;
            // 
            // txtbNumero
            // 
            this.txtbNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNumero.Location = new System.Drawing.Point(609, 40);
            this.txtbNumero.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Size = new System.Drawing.Size(211, 20);
            this.txtbNumero.TabIndex = 40;
            // 
            // txtbCalle
            // 
            this.txtbCalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbCalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbCalle.Location = new System.Drawing.Point(148, 37);
            this.txtbCalle.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbCalle.Name = "txtbCalle";
            this.txtbCalle.Size = new System.Drawing.Size(211, 20);
            this.txtbCalle.TabIndex = 39;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblCalle.Location = new System.Drawing.Point(46, 34);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(93, 23);
            this.lblCalle.TabIndex = 38;
            this.lblCalle.Text = "Calle(*):";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNumero.Location = new System.Drawing.Point(481, 37);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(119, 23);
            this.lblNumero.TabIndex = 37;
            this.lblNumero.Text = "Número(*):";
            // 
            // btnAgregarBarrio
            // 
            this.btnAgregarBarrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAgregarBarrio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAgregarBarrio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarBarrio.BorderColor = System.Drawing.Color.Green;
            this.btnAgregarBarrio.BorderRadius = 20;
            this.btnAgregarBarrio.BorderSize = 1;
            this.btnAgregarBarrio.CausesValidation = false;
            this.btnAgregarBarrio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarBarrio.FlatAppearance.BorderSize = 0;
            this.btnAgregarBarrio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAgregarBarrio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAgregarBarrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarBarrio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarBarrio.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarBarrio.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAgregarBarrio.Location = new System.Drawing.Point(598, 284);
            this.btnAgregarBarrio.Name = "btnAgregarBarrio";
            this.btnAgregarBarrio.Size = new System.Drawing.Size(145, 38);
            this.btnAgregarBarrio.TabIndex = 36;
            this.btnAgregarBarrio.Text = "Agregar Barrio";
            this.btnAgregarBarrio.TextColor = System.Drawing.Color.Black;
            this.btnAgregarBarrio.UseVisualStyleBackColor = false;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblBarrio.Location = new System.Drawing.Point(25, 26);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(96, 23);
            this.lblBarrio.TabIndex = 34;
            this.lblBarrio.Text = "Barrio(*):";
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
            this.btnAceptar.Location = new System.Drawing.Point(474, 641);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(127, 46);
            this.btnAceptar.TabIndex = 38;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.Black;
            this.btnAceptar.UseVisualStyleBackColor = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(304, 641);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 46);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.Black;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // gbUbicacion
            // 
            this.gbUbicacion.BackColor = System.Drawing.Color.Transparent;
            this.gbUbicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbUbicacion.Controls.Add(this.lblBarriosDGV);
            this.gbUbicacion.Controls.Add(this.btnAgregarBarrio);
            this.gbUbicacion.Controls.Add(this.btnActualizar);
            this.gbUbicacion.Controls.Add(this.gbFiltrosFarm);
            this.gbUbicacion.Controls.Add(this.txtbNumero);
            this.gbUbicacion.Controls.Add(this.dgvBarrios);
            this.gbUbicacion.Controls.Add(this.txtbCalle);
            this.gbUbicacion.Controls.Add(this.lblNumero);
            this.gbUbicacion.Controls.Add(this.lblCalle);
            this.gbUbicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gbUbicacion.Location = new System.Drawing.Point(12, 225);
            this.gbUbicacion.Name = "gbUbicacion";
            this.gbUbicacion.Size = new System.Drawing.Size(871, 410);
            this.gbUbicacion.TabIndex = 40;
            this.gbUbicacion.TabStop = false;
            this.gbUbicacion.Text = "Datos de Ubicación";
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
            this.btnActualizar.Location = new System.Drawing.Point(622, 337);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 37);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Black;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // gbFiltrosFarm
            // 
            this.gbFiltrosFarm.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltrosFarm.Controls.Add(this.txtbLocalidad);
            this.gbFiltrosFarm.Controls.Add(this.lblLocalidad);
            this.gbFiltrosFarm.Controls.Add(this.txtbNombreBarrio);
            this.gbFiltrosFarm.Controls.Add(this.btnLimpiarUbicacion);
            this.gbFiltrosFarm.Controls.Add(this.btnConsultarUbicacion);
            this.gbFiltrosFarm.Controls.Add(this.lblBarrio);
            this.gbFiltrosFarm.Location = new System.Drawing.Point(18, 78);
            this.gbFiltrosFarm.Name = "gbFiltrosFarm";
            this.gbFiltrosFarm.Size = new System.Drawing.Size(832, 130);
            this.gbFiltrosFarm.TabIndex = 35;
            this.gbFiltrosFarm.TabStop = false;
            this.gbFiltrosFarm.Text = "FILTROS";
            // 
            // txtbNombreBarrio
            // 
            this.txtbNombreBarrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNombreBarrio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNombreBarrio.Location = new System.Drawing.Point(130, 26);
            this.txtbNombreBarrio.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbNombreBarrio.Name = "txtbNombreBarrio";
            this.txtbNombreBarrio.Size = new System.Drawing.Size(211, 20);
            this.txtbNombreBarrio.TabIndex = 41;
            // 
            // btnConsultarUbicacion
            // 
            this.btnConsultarUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnConsultarUbicacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnConsultarUbicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultarUbicacion.BorderColor = System.Drawing.Color.Green;
            this.btnConsultarUbicacion.BorderRadius = 20;
            this.btnConsultarUbicacion.BorderSize = 1;
            this.btnConsultarUbicacion.CausesValidation = false;
            this.btnConsultarUbicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarUbicacion.FlatAppearance.BorderSize = 0;
            this.btnConsultarUbicacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConsultarUbicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnConsultarUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarUbicacion.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarUbicacion.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarUbicacion.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnConsultarUbicacion.Location = new System.Drawing.Point(444, 69);
            this.btnConsultarUbicacion.Name = "btnConsultarUbicacion";
            this.btnConsultarUbicacion.Size = new System.Drawing.Size(115, 37);
            this.btnConsultarUbicacion.TabIndex = 10;
            this.btnConsultarUbicacion.Text = "Consultar";
            this.btnConsultarUbicacion.TextColor = System.Drawing.Color.Black;
            this.btnConsultarUbicacion.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarUbicacion
            // 
            this.btnLimpiarUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnLimpiarUbicacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnLimpiarUbicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarUbicacion.BorderColor = System.Drawing.Color.Green;
            this.btnLimpiarUbicacion.BorderRadius = 20;
            this.btnLimpiarUbicacion.BorderSize = 1;
            this.btnLimpiarUbicacion.CausesValidation = false;
            this.btnLimpiarUbicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarUbicacion.FlatAppearance.BorderSize = 0;
            this.btnLimpiarUbicacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpiarUbicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnLimpiarUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarUbicacion.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarUbicacion.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarUbicacion.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiarUbicacion.Location = new System.Drawing.Point(300, 69);
            this.btnLimpiarUbicacion.Name = "btnLimpiarUbicacion";
            this.btnLimpiarUbicacion.Size = new System.Drawing.Size(115, 37);
            this.btnLimpiarUbicacion.TabIndex = 9;
            this.btnLimpiarUbicacion.Text = "Limpiar";
            this.btnLimpiarUbicacion.TextColor = System.Drawing.Color.Black;
            this.btnLimpiarUbicacion.UseVisualStyleBackColor = false;
            // 
            // dgvBarrios
            // 
            this.dgvBarrios.AllowUserToAddRows = false;
            this.dgvBarrios.AllowUserToDeleteRows = false;
            this.dgvBarrios.AllowUserToResizeColumns = false;
            this.dgvBarrios.AllowUserToResizeRows = false;
            this.dgvBarrios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.dgvBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBarrio,
            this.nomBarrio,
            this.nomLocalidad});
            this.dgvBarrios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.dgvBarrios.Location = new System.Drawing.Point(18, 243);
            this.dgvBarrios.MultiSelect = false;
            this.dgvBarrios.Name = "dgvBarrios";
            this.dgvBarrios.ReadOnly = true;
            this.dgvBarrios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarrios.Size = new System.Drawing.Size(545, 161);
            this.dgvBarrios.TabIndex = 11;
            this.dgvBarrios.TabStop = false;
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnLimpiarCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnLimpiarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarCliente.BorderColor = System.Drawing.Color.Green;
            this.btnLimpiarCliente.BorderRadius = 20;
            this.btnLimpiarCliente.BorderSize = 1;
            this.btnLimpiarCliente.CausesValidation = false;
            this.btnLimpiarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCliente.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpiarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnLimpiarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCliente.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarCliente.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiarCliente.Location = new System.Drawing.Point(371, 112);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(115, 37);
            this.btnLimpiarCliente.TabIndex = 34;
            this.btnLimpiarCliente.Text = "Limpiar";
            this.btnLimpiarCliente.TextColor = System.Drawing.Color.Black;
            this.btnLimpiarCliente.UseVisualStyleBackColor = false;
            // 
            // txtbLocalidad
            // 
            this.txtbLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbLocalidad.Location = new System.Drawing.Point(591, 26);
            this.txtbLocalidad.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbLocalidad.Name = "txtbLocalidad";
            this.txtbLocalidad.Size = new System.Drawing.Size(211, 20);
            this.txtbLocalidad.TabIndex = 43;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblLocalidad.Location = new System.Drawing.Point(469, 23);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(113, 23);
            this.lblLocalidad.TabIndex = 42;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblBarriosDGV
            // 
            this.lblBarriosDGV.AutoSize = true;
            this.lblBarriosDGV.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblBarriosDGV.Location = new System.Drawing.Point(19, 217);
            this.lblBarriosDGV.Name = "lblBarriosDGV";
            this.lblBarriosDGV.Size = new System.Drawing.Size(74, 23);
            this.lblBarriosDGV.TabIndex = 41;
            this.lblBarriosDGV.Text = "Barrios";
            // 
            // idBarrio
            // 
            this.idBarrio.HeaderText = "ID";
            this.idBarrio.Name = "idBarrio";
            this.idBarrio.ReadOnly = true;
            this.idBarrio.Width = 50;
            // 
            // nomBarrio
            // 
            this.nomBarrio.HeaderText = "Nombre";
            this.nomBarrio.Name = "nomBarrio";
            this.nomBarrio.ReadOnly = true;
            this.nomBarrio.Width = 250;
            // 
            // nomLocalidad
            // 
            this.nomLocalidad.HeaderText = "Localidad";
            this.nomLocalidad.Name = "nomLocalidad";
            this.nomLocalidad.ReadOnly = true;
            this.nomLocalidad.Width = 200;
            // 
            // frmABMClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.ABMClients;
            this.ClientSize = new System.Drawing.Size(901, 690);
            this.Controls.Add(this.gbUbicacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(gbClientes);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmABMClientes";
            gbClientes.ResumeLayout(false);
            gbClientes.PerformLayout();
            this.gbUbicacion.ResumeLayout(false);
            this.gbUbicacion.PerformLayout();
            this.gbFiltrosFarm.ResumeLayout(false);
            this.gbFiltrosFarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblNomCli;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lblAvisoNroDoc;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.TextBox txtbPasaporteLetras;
        private System.Windows.Forms.TextBox txtbPasaporteNro;
        private System.Windows.Forms.TextBox txtbNroDoc;
        private System.Windows.Forms.Label lblApeCli;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.Label lblBarrio;
        private CustomControls.RJControls.RJButton btnAgregarBarrio;
        private System.Windows.Forms.TextBox txtbNumero;
        private System.Windows.Forms.TextBox txtbCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNumero;
        private CustomControls.RJControls.RJButton btnAceptar;
        private CustomControls.RJControls.RJButton btnCancelar;
        private System.Windows.Forms.GroupBox gbUbicacion;
        private CustomControls.RJControls.RJButton btnActualizar;
        private System.Windows.Forms.GroupBox gbFiltrosFarm;
        private CustomControls.RJControls.RJButton btnConsultarUbicacion;
        private CustomControls.RJControls.RJButton btnLimpiarUbicacion;
        private System.Windows.Forms.DataGridView dgvBarrios;
        private System.Windows.Forms.TextBox txtbNombreBarrio;
        private CustomControls.RJControls.RJButton btnLimpiarCliente;
        private System.Windows.Forms.TextBox txtbLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblBarriosDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomLocalidad;
    }
}