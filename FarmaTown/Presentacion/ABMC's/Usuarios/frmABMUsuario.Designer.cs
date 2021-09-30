
namespace FarmaTown.Presentacion
{
    partial class frmABMUsuario
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
            System.Windows.Forms.GroupBox groupBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMUsuario));
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbClave = new System.Windows.Forms.TextBox();
            this.txtbClaveRep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.txtbFantasma = new JMaterialTextbox.JMaterialTextbox();
            this.jMaterialTextbox2 = new JMaterialTextbox.JMaterialTextbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomFarmacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new CustomControls.RJControls.RJButton();
            this.transparentLabel3 = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.btnRegEmpleado = new CustomControls.RJControls.RJButton();
            this.btnVerClaveRep = new CustomControls.RJControls.RJButton();
            this.btnVerClave = new CustomControls.RJControls.RJButton();
            this.btnLimpiar = new CustomControls.RJControls.RJButton();
            this.lblNombre = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.lblRol = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.lblRepetirContra = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.lblContraseña = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.btnCancelar = new CustomControls.RJControls.RJButton();
            this.btnAceptar = new CustomControls.RJControls.RJButton();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.White;
            groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            groupBox1.Controls.Add(this.txtbNombre);
            groupBox1.Controls.Add(this.txtbClave);
            groupBox1.Controls.Add(this.txtbClaveRep);
            groupBox1.Controls.Add(this.btnVerClaveRep);
            groupBox1.Controls.Add(this.btnVerClave);
            groupBox1.Controls.Add(this.btnLimpiar);
            groupBox1.Controls.Add(this.label1);
            groupBox1.Controls.Add(this.lblNombre);
            groupBox1.Controls.Add(this.cboRol);
            groupBox1.Controls.Add(this.lblRol);
            groupBox1.Controls.Add(this.lblRepetirContra);
            groupBox1.Controls.Add(this.lblContraseña);
            groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            groupBox1.Location = new System.Drawing.Point(23, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1137, 203);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Usuario";
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNombre.Location = new System.Drawing.Point(469, 28);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(12, 5, 6, 5);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(301, 20);
            this.txtbNombre.TabIndex = 1;
            this.txtbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbEnter_KeyDown);
            // 
            // txtbClave
            // 
            this.txtbClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbClave.Location = new System.Drawing.Point(469, 73);
            this.txtbClave.Margin = new System.Windows.Forms.Padding(12, 5, 6, 5);
            this.txtbClave.Name = "txtbClave";
            this.txtbClave.PasswordChar = '*';
            this.txtbClave.Size = new System.Drawing.Size(301, 20);
            this.txtbClave.TabIndex = 2;
            this.txtbClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbEnter_KeyDown);
            // 
            // txtbClaveRep
            // 
            this.txtbClaveRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbClaveRep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbClaveRep.Location = new System.Drawing.Point(469, 114);
            this.txtbClaveRep.Margin = new System.Windows.Forms.Padding(12, 5, 6, 5);
            this.txtbClaveRep.Name = "txtbClaveRep";
            this.txtbClaveRep.PasswordChar = '*';
            this.txtbClaveRep.Size = new System.Drawing.Size(301, 20);
            this.txtbClaveRep.TabIndex = 4;
            this.txtbClaveRep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbEnter_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "Los campos con (*) \r\nson obligatorios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboRol
            // 
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(469, 151);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(301, 27);
            this.cboRol.TabIndex = 6;
            this.cboRol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbEnter_KeyDown);
            // 
            // txtbFantasma
            // 
            this.txtbFantasma.BackColor = System.Drawing.Color.Transparent;
            this.txtbFantasma.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtbFantasma.Font_Size = new System.Drawing.Font("Century Gothic", 15F);
            this.txtbFantasma.ForeColors = System.Drawing.Color.Black;
            this.txtbFantasma.HintText = null;
            this.txtbFantasma.IsPassword = false;
            this.txtbFantasma.LineBackColor = System.Drawing.Color.Red;
            this.txtbFantasma.LineThickness = 3;
            this.txtbFantasma.Location = new System.Drawing.Point(368, 110);
            this.txtbFantasma.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtbFantasma.MaxLength = 32767;
            this.txtbFantasma.Name = "txtbFantasma";
            this.txtbFantasma.OnFocusedColor = System.Drawing.Color.Black;
            this.txtbFantasma.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbFantasma.ReadOnly = false;
            this.txtbFantasma.Size = new System.Drawing.Size(452, 31);
            this.txtbFantasma.TabIndex = 12;
            this.txtbFantasma.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbFantasma.TextName = "";
            // 
            // jMaterialTextbox2
            // 
            this.jMaterialTextbox2.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox2.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox2.ForeColors = System.Drawing.Color.Black;
            this.jMaterialTextbox2.HintText = null;
            this.jMaterialTextbox2.IsPassword = false;
            this.jMaterialTextbox2.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jMaterialTextbox2.LineThickness = 2;
            this.jMaterialTextbox2.Location = new System.Drawing.Point(245, 149);
            this.jMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMaterialTextbox2.MaxLength = 32767;
            this.jMaterialTextbox2.Name = "jMaterialTextbox2";
            this.jMaterialTextbox2.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox2.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox2.ReadOnly = false;
            this.jMaterialTextbox2.Size = new System.Drawing.Size(301, 23);
            this.jMaterialTextbox2.TabIndex = 14;
            this.jMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox2.TextName = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.transparentLabel3);
            this.groupBox2.Controls.Add(this.dgvEmpleados);
            this.groupBox2.Controls.Add(this.btnRegEmpleado);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(23, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1137, 335);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Empleado";
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
            this.dgvEmpleados.Location = new System.Drawing.Point(15, 52);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(976, 267);
            this.dgvEmpleados.TabIndex = 27;
            this.dgvEmpleados.TabStop = false;
            // 
            // idEmpleado
            // 
            this.idEmpleado.HeaderText = "ID";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
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
            this.btnActualizar.Location = new System.Drawing.Point(1015, 206);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 37);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Black;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // transparentLabel3
            // 
            this.transparentLabel3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.transparentLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transparentLabel3.Location = new System.Drawing.Point(21, 23);
            this.transparentLabel3.Name = "transparentLabel3";
            this.transparentLabel3.Size = new System.Drawing.Size(30, 23);
            this.transparentLabel3.TabIndex = 36;
            this.transparentLabel3.TabStop = false;
            this.transparentLabel3.Text = "(*)";
            this.transparentLabel3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btnRegEmpleado
            // 
            this.btnRegEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnRegEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnRegEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegEmpleado.BorderColor = System.Drawing.Color.Green;
            this.btnRegEmpleado.BorderRadius = 20;
            this.btnRegEmpleado.BorderSize = 1;
            this.btnRegEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegEmpleado.FlatAppearance.BorderSize = 0;
            this.btnRegEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRegEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRegEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegEmpleado.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnRegEmpleado.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRegEmpleado.Location = new System.Drawing.Point(1013, 115);
            this.btnRegEmpleado.Name = "btnRegEmpleado";
            this.btnRegEmpleado.Size = new System.Drawing.Size(106, 56);
            this.btnRegEmpleado.TabIndex = 8;
            this.btnRegEmpleado.Text = "Registrar Empleado";
            this.btnRegEmpleado.TextColor = System.Drawing.Color.Black;
            this.btnRegEmpleado.UseVisualStyleBackColor = false;
            this.btnRegEmpleado.Click += new System.EventHandler(this.btnRegEmpleado_Click);
            // 
            // btnVerClaveRep
            // 
            this.btnVerClaveRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnVerClaveRep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnVerClaveRep.BackgroundImage = global::FarmaTown.Properties.Resources.eyeParaClave;
            this.btnVerClaveRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerClaveRep.BorderColor = System.Drawing.Color.Green;
            this.btnVerClaveRep.BorderRadius = 15;
            this.btnVerClaveRep.BorderSize = 1;
            this.btnVerClaveRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerClaveRep.FlatAppearance.BorderSize = 0;
            this.btnVerClaveRep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVerClaveRep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnVerClaveRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerClaveRep.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClaveRep.ForeColor = System.Drawing.Color.Black;
            this.btnVerClaveRep.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnVerClaveRep.Location = new System.Drawing.Point(789, 105);
            this.btnVerClaveRep.Name = "btnVerClaveRep";
            this.btnVerClaveRep.Size = new System.Drawing.Size(33, 29);
            this.btnVerClaveRep.TabIndex = 5;
            this.btnVerClaveRep.TextColor = System.Drawing.Color.Black;
            this.btnVerClaveRep.UseVisualStyleBackColor = false;
            this.btnVerClaveRep.Click += new System.EventHandler(this.btnVerClaveRep_Click);
            // 
            // btnVerClave
            // 
            this.btnVerClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnVerClave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnVerClave.BackgroundImage = global::FarmaTown.Properties.Resources.eyeParaClave;
            this.btnVerClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerClave.BorderColor = System.Drawing.Color.Green;
            this.btnVerClave.BorderRadius = 15;
            this.btnVerClave.BorderSize = 1;
            this.btnVerClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerClave.FlatAppearance.BorderSize = 0;
            this.btnVerClave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVerClave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnVerClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerClave.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClave.ForeColor = System.Drawing.Color.Black;
            this.btnVerClave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnVerClave.Location = new System.Drawing.Point(789, 70);
            this.btnVerClave.Name = "btnVerClave";
            this.btnVerClave.Size = new System.Drawing.Size(33, 29);
            this.btnVerClave.TabIndex = 3;
            this.btnVerClave.TextColor = System.Drawing.Color.Black;
            this.btnVerClave.UseVisualStyleBackColor = false;
            this.btnVerClave.Click += new System.EventHandler(this.btnVerClave_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.BorderColor = System.Drawing.Color.Green;
            this.btnLimpiar.BorderRadius = 20;
            this.btnLimpiar.BorderSize = 1;
            this.btnLimpiar.CausesValidation = false;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiar.Location = new System.Drawing.Point(936, 70);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 49);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.Black;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(283, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(126, 23);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.TabStop = false;
            this.lblNombre.Text = "  Nombre(*):";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblRol
            // 
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRol.Location = new System.Drawing.Point(343, 151);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(66, 23);
            this.lblRol.TabIndex = 20;
            this.lblRol.TabStop = false;
            this.lblRol.Text = "Rol(*):";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblRepetirContra
            // 
            this.lblRepetirContra.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblRepetirContra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRepetirContra.Location = new System.Drawing.Point(187, 111);
            this.lblRepetirContra.Name = "lblRepetirContra";
            this.lblRepetirContra.Size = new System.Drawing.Size(222, 23);
            this.lblRepetirContra.TabIndex = 21;
            this.lblRepetirContra.TabStop = false;
            this.lblRepetirContra.Text = "Repetir Contraseña(*):";
            this.lblRepetirContra.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContraseña.Location = new System.Drawing.Point(262, 70);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(147, 23);
            this.lblContraseña.TabIndex = 22;
            this.lblContraseña.TabStop = false;
            this.lblContraseña.Text = "Contraseña(*):";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.TopLeft;
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
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancelar.Location = new System.Drawing.Point(733, 594);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 49);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.Black;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(991, 594);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 49);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.Black;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmABMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.undraw_High_five_re_jy711;
            this.ClientSize = new System.Drawing.Size(1185, 674);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmABMUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmABMUsuario_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.RJControls.RJButton btnAceptar;
        private CustomControls.RJControls.RJButton btnCancelar;
        private JMaterialTextbox.JMaterialTextbox txtbFantasma;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox2;
        private System.Windows.Forms.ComboBox cboRol;
        private DiseñosElemGUI.TransparentLabel lblNombre;
        private DiseñosElemGUI.TransparentLabel lblRol;
        private DiseñosElemGUI.TransparentLabel lblRepetirContra;
        private DiseñosElemGUI.TransparentLabel lblContraseña;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomControls.RJControls.RJButton btnRegEmpleado;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomFarmacia;
        private CustomControls.RJControls.RJButton btnLimpiar;
        private CustomControls.RJControls.RJButton btnVerClave;
        private CustomControls.RJControls.RJButton btnVerClaveRep;
        private DiseñosElemGUI.TransparentLabel transparentLabel3;
        private CustomControls.RJControls.RJButton btnActualizar;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbClave;
        private System.Windows.Forms.TextBox txtbClaveRep;
    }
}