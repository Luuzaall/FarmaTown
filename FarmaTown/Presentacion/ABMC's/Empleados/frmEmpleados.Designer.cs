
namespace FarmaTown.Presentacion.Empleados
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.txtbFarmacia = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbPasaporteLetras = new System.Windows.Forms.TextBox();
            this.txtbPasaporteNro = new System.Windows.Forms.TextBox();
            this.lblAvisoNroDoc = new System.Windows.Forms.Label();
            this.txtbNroDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new CustomControls.RJControls.RJButton();
            this.lblNomEmp = new System.Windows.Forms.Label();
            this.btnConsultar = new CustomControls.RJControls.RJButton();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new CustomControls.RJControls.RJButton();
            this.btnEditar = new CustomControls.RJControls.RJButton();
            this.btnEliminar = new CustomControls.RJControls.RJButton();
            this.btnAgregar = new CustomControls.RJControls.RJButton();
            this.lblAviso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new CustomControls.RJControls.RJButton();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomFarmacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.gbResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbFiltros.Controls.Add(this.txtbFarmacia);
            this.gbFiltros.Controls.Add(this.txtbNombre);
            this.gbFiltros.Controls.Add(this.txtbPasaporteLetras);
            this.gbFiltros.Controls.Add(this.txtbPasaporteNro);
            this.gbFiltros.Controls.Add(this.lblAvisoNroDoc);
            this.gbFiltros.Controls.Add(this.txtbNroDoc);
            this.gbFiltros.Controls.Add(this.label5);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.btnLimpiar);
            this.gbFiltros.Controls.Add(this.lblNomEmp);
            this.gbFiltros.Controls.Add(this.btnConsultar);
            this.gbFiltros.Controls.Add(this.cboTipoDoc);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.gbFiltros.Location = new System.Drawing.Point(32, 64);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1094, 197);
            this.gbFiltros.TabIndex = 22;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // txtbFarmacia
            // 
            this.txtbFarmacia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbFarmacia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbFarmacia.Location = new System.Drawing.Point(673, 45);
            this.txtbFarmacia.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbFarmacia.Name = "txtbFarmacia";
            this.txtbFarmacia.Size = new System.Drawing.Size(243, 25);
            this.txtbFarmacia.TabIndex = 2;
            this.txtbFarmacia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbFiltros_KeyDown);
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNombre.Location = new System.Drawing.Point(221, 43);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(243, 25);
            this.txtbNombre.TabIndex = 1;
            this.txtbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbFiltros_KeyDown);
            // 
            // txtbPasaporteLetras
            // 
            this.txtbPasaporteLetras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbPasaporteLetras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPasaporteLetras.Enabled = false;
            this.txtbPasaporteLetras.Location = new System.Drawing.Point(678, 88);
            this.txtbPasaporteLetras.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbPasaporteLetras.Name = "txtbPasaporteLetras";
            this.txtbPasaporteLetras.Size = new System.Drawing.Size(85, 25);
            this.txtbPasaporteLetras.TabIndex = 4;
            this.txtbPasaporteLetras.Visible = false;
            this.txtbPasaporteLetras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbPasaporteLetras_KeyDown);
            // 
            // txtbPasaporteNro
            // 
            this.txtbPasaporteNro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbPasaporteNro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPasaporteNro.Enabled = false;
            this.txtbPasaporteNro.Location = new System.Drawing.Point(785, 88);
            this.txtbPasaporteNro.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbPasaporteNro.Name = "txtbPasaporteNro";
            this.txtbPasaporteNro.Size = new System.Drawing.Size(131, 25);
            this.txtbPasaporteNro.TabIndex = 5;
            this.txtbPasaporteNro.Visible = false;
            this.txtbPasaporteNro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbPasaporteNro_KeyDown);
            // 
            // lblAvisoNroDoc
            // 
            this.lblAvisoNroDoc.AutoSize = true;
            this.lblAvisoNroDoc.BackColor = System.Drawing.Color.IndianRed;
            this.lblAvisoNroDoc.Location = new System.Drawing.Point(674, 119);
            this.lblAvisoNroDoc.Name = "lblAvisoNroDoc";
            this.lblAvisoNroDoc.Size = new System.Drawing.Size(0, 23);
            this.lblAvisoNroDoc.TabIndex = 30;
            this.lblAvisoNroDoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbNroDoc
            // 
            this.txtbNroDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNroDoc.Enabled = false;
            this.txtbNroDoc.Location = new System.Drawing.Point(678, 88);
            this.txtbNroDoc.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbNroDoc.Name = "txtbNroDoc";
            this.txtbNroDoc.Size = new System.Drawing.Size(238, 25);
            this.txtbNroDoc.TabIndex = 4;
            this.txtbNroDoc.Visible = false;
            this.txtbNroDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbNroDoc_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(491, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "N° Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(538, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Farmacia:";
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
            this.btnLimpiar.Location = new System.Drawing.Point(299, 140);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 37);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.Black;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblNomEmp
            // 
            this.lblNomEmp.AutoSize = true;
            this.lblNomEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblNomEmp.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEmp.Location = new System.Drawing.Point(89, 45);
            this.lblNomEmp.Name = "lblNomEmp";
            this.lblNomEmp.Size = new System.Drawing.Size(95, 23);
            this.lblNomEmp.TabIndex = 11;
            this.lblNomEmp.Text = "Nombre:";
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
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnConsultar.Location = new System.Drawing.Point(533, 140);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(113, 37);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.Black;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(221, 88);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(243, 31);
            this.cboTipoDoc.TabIndex = 3;
            this.cboTipoDoc.SelectionChangeCommitted += new System.EventHandler(this.cboTipoDoc_SelectionChangeCommited);
            this.cboTipoDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbFiltros_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Documento:";
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
            this.btnSalir.Location = new System.Drawing.Point(1042, 615);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 49);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.TextColor = System.Drawing.Color.White;
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
            this.btnEditar.Location = new System.Drawing.Point(141, 615);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(58, 49);
            this.btnEditar.TabIndex = 10;
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
            this.btnEliminar.Location = new System.Drawing.Point(253, 615);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 49);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAgregar.BackgroundImage = global::FarmaTown.Properties.Resources.addPerson;
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
            this.btnAgregar.Location = new System.Drawing.Point(33, 615);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(57, 49);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblAviso.ForeColor = System.Drawing.Color.Maroon;
            this.lblAviso.Location = new System.Drawing.Point(327, 631);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(313, 22);
            this.lblAviso.TabIndex = 37;
            this.lblAviso.Text = "Debe elegir un empleado primero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(209)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 33);
            this.label1.TabIndex = 38;
            this.label1.Text = "Consulta Empleados";
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
            this.btnActualizar.Location = new System.Drawing.Point(972, 142);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 37);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Black;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToResizeColumns = false;
            this.dgvEmpleados.AllowUserToResizeRows = false;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleado,
            this.nomEmpleado,
            this.nroDoc,
            this.nomTipoDoc,
            this.nomFarmacia});
            this.dgvEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.dgvEmpleados.Location = new System.Drawing.Point(16, 31);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(938, 267);
            this.dgvEmpleados.TabIndex = 8;
            this.dgvEmpleados.TabStop = false;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            // 
            // gbResultados
            // 
            this.gbResultados.BackColor = System.Drawing.Color.Transparent;
            this.gbResultados.Controls.Add(this.dgvEmpleados);
            this.gbResultados.Controls.Add(this.btnActualizar);
            this.gbResultados.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.gbResultados.Location = new System.Drawing.Point(32, 283);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(1094, 310);
            this.gbResultados.TabIndex = 23;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // idEmpleado
            // 
            this.idEmpleado.HeaderText = "ID";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Visible = false;
            this.idEmpleado.Width = 50;
            // 
            // nomEmpleado
            // 
            this.nomEmpleado.HeaderText = "Nombre";
            this.nomEmpleado.Name = "nomEmpleado";
            this.nomEmpleado.ReadOnly = true;
            this.nomEmpleado.Width = 200;
            // 
            // nroDoc
            // 
            this.nroDoc.HeaderText = "N° Documento";
            this.nroDoc.Name = "nroDoc";
            this.nroDoc.ReadOnly = true;
            this.nroDoc.Width = 170;
            // 
            // nomTipoDoc
            // 
            this.nomTipoDoc.HeaderText = "Tipo Documento";
            this.nomTipoDoc.Name = "nomTipoDoc";
            this.nomTipoDoc.ReadOnly = true;
            this.nomTipoDoc.Width = 150;
            // 
            // nomFarmacia
            // 
            this.nomFarmacia.HeaderText = "Farmacia";
            this.nomFarmacia.Name = "nomFarmacia";
            this.nomFarmacia.ReadOnly = true;
            this.nomFarmacia.Width = 300;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.coworkers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(1146, 678);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbFiltros);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmEmpleados";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Empleados - Farmatown";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.gbResultados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton btnLimpiar;
        private System.Windows.Forms.Label lblNomEmp;
        private CustomControls.RJControls.RJButton btnConsultar;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJButton btnEditar;
        private CustomControls.RJControls.RJButton btnEliminar;
        private CustomControls.RJControls.RJButton btnAgregar;
        private CustomControls.RJControls.RJButton btnSalir;
        private System.Windows.Forms.TextBox txtbNroDoc;
        private System.Windows.Forms.Label lblAvisoNroDoc;
        private System.Windows.Forms.TextBox txtbPasaporteLetras;
        private System.Windows.Forms.TextBox txtbPasaporteNro;
        private System.Windows.Forms.TextBox txtbFarmacia;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btnActualizar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomFarmacia;
    }
}