
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMUsuario));
            this.txtbNombre = new JMaterialTextbox.JMaterialTextbox();
            this.txtbClave = new JMaterialTextbox.JMaterialTextbox();
            this.txtbClaveRep = new JMaterialTextbox.JMaterialTextbox();
            this.txtbFantasma = new JMaterialTextbox.JMaterialTextbox();
            this.jMaterialTextbox2 = new JMaterialTextbox.JMaterialTextbox();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombre = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.lblRol = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.lblRepetirContra = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.lblContraseña = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomFarmacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new CustomControls.RJControls.RJButton();
            this.btnAceptar = new CustomControls.RJControls.RJButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtbNombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbNombre.Font_Size = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbNombre.ForeColors = System.Drawing.Color.Black;
            this.txtbNombre.HintText = null;
            this.txtbNombre.IsPassword = false;
            this.txtbNombre.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.txtbNombre.LineThickness = 3;
            this.txtbNombre.Location = new System.Drawing.Point(420, 29);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNombre.MaxLength = 32767;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbNombre.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbNombre.ReadOnly = false;
            this.txtbNombre.Size = new System.Drawing.Size(301, 23);
            this.txtbNombre.TabIndex = 12;
            this.txtbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbNombre.TextName = "";
            // 
            // txtbClave
            // 
            this.txtbClave.BackColor = System.Drawing.Color.Transparent;
            this.txtbClave.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbClave.Font_Size = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbClave.ForeColors = System.Drawing.Color.Black;
            this.txtbClave.HintText = null;
            this.txtbClave.IsPassword = true;
            this.txtbClave.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.txtbClave.LineThickness = 3;
            this.txtbClave.Location = new System.Drawing.Point(420, 73);
            this.txtbClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtbClave.MaxLength = 32767;
            this.txtbClave.Name = "txtbClave";
            this.txtbClave.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbClave.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbClave.ReadOnly = false;
            this.txtbClave.Size = new System.Drawing.Size(301, 23);
            this.txtbClave.TabIndex = 14;
            this.txtbClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbClave.TextName = "";
            // 
            // txtbClaveRep
            // 
            this.txtbClaveRep.BackColor = System.Drawing.Color.Transparent;
            this.txtbClaveRep.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbClaveRep.Font_Size = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbClaveRep.ForeColors = System.Drawing.Color.Black;
            this.txtbClaveRep.HintText = null;
            this.txtbClaveRep.IsPassword = true;
            this.txtbClaveRep.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.txtbClaveRep.LineThickness = 3;
            this.txtbClaveRep.Location = new System.Drawing.Point(420, 114);
            this.txtbClaveRep.Margin = new System.Windows.Forms.Padding(4);
            this.txtbClaveRep.MaxLength = 32767;
            this.txtbClaveRep.Name = "txtbClaveRep";
            this.txtbClaveRep.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbClaveRep.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbClaveRep.ReadOnly = false;
            this.txtbClaveRep.Size = new System.Drawing.Size(301, 23);
            this.txtbClaveRep.TabIndex = 15;
            this.txtbClaveRep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbClaveRep.TextName = "";
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
            // cboRol
            // 
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(420, 154);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(301, 27);
            this.cboRol.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtbNombre);
            this.groupBox1.Controls.Add(this.cboRol);
            this.groupBox1.Controls.Add(this.lblRol);
            this.groupBox1.Controls.Add(this.lblRepetirContra);
            this.groupBox1.Controls.Add(this.lblContraseña);
            this.groupBox1.Controls.Add(this.txtbClaveRep);
            this.groupBox1.Controls.Add(this.txtbClave);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(28, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 191);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(259, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(101, 23);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.TabStop = false;
            this.lblNombre.Text = "  Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblRol
            // 
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRol.Location = new System.Drawing.Point(319, 154);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(41, 23);
            this.lblRol.TabIndex = 20;
            this.lblRol.TabStop = false;
            this.lblRol.Text = "Rol:";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblRepetirContra
            // 
            this.lblRepetirContra.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblRepetirContra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRepetirContra.Location = new System.Drawing.Point(166, 114);
            this.lblRepetirContra.Name = "lblRepetirContra";
            this.lblRepetirContra.Size = new System.Drawing.Size(194, 23);
            this.lblRepetirContra.TabIndex = 21;
            this.lblRepetirContra.TabStop = false;
            this.lblRepetirContra.Text = "Repetir Contraseña:";
            this.lblRepetirContra.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContraseña.Location = new System.Drawing.Point(241, 73);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(119, 23);
            this.lblContraseña.TabIndex = 22;
            this.lblContraseña.TabStop = false;
            this.lblContraseña.Text = "Contraseña:";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rjButton2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.dgvEmpleados);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(28, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 230);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Empleado";
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.rjButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rjButton2.BorderColor = System.Drawing.Color.Green;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 1;
            this.rjButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rjButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.rjButton2.Location = new System.Drawing.Point(878, 93);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(106, 56);
            this.rjButton2.TabIndex = 26;
            this.rjButton2.Text = "Registrar Empleado";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToResizeColumns = false;
            this.dgvEmpleados.AllowUserToResizeRows = false;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleado,
            this.nomEmpleado,
            this.nroDoc,
            this.nomTipoDoc,
            this.nomFarmacia});
            this.dgvEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.dgvEmpleados.Location = new System.Drawing.Point(78, 26);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(763, 185);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // idEmpleado
            // 
            this.idEmpleado.HeaderText = "ID";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            // 
            // nomEmpleado
            // 
            this.nomEmpleado.HeaderText = "Empleado";
            this.nomEmpleado.Name = "nomEmpleado";
            this.nomEmpleado.ReadOnly = true;
            // 
            // nroDoc
            // 
            this.nroDoc.HeaderText = "N° Doc";
            this.nroDoc.Name = "nroDoc";
            this.nroDoc.ReadOnly = true;
            this.nroDoc.Width = 120;
            // 
            // nomTipoDoc
            // 
            this.nomTipoDoc.HeaderText = "Tipo Doc";
            this.nomTipoDoc.Name = "nomTipoDoc";
            this.nomTipoDoc.ReadOnly = true;
            this.nomTipoDoc.Width = 120;
            // 
            // nomFarmacia
            // 
            this.nomFarmacia.HeaderText = "Farmacia";
            this.nomFarmacia.Name = "nomFarmacia";
            this.nomFarmacia.ReadOnly = true;
            this.nomFarmacia.Width = 250;
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
            this.btnCancelar.Location = new System.Drawing.Point(620, 486);
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
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAceptar.Location = new System.Drawing.Point(878, 486);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 49);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.Black;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.dataGridView1.Location = new System.Drawing.Point(78, 26);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(763, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Empleado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "N° Doc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo Doc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Farmacia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // frmABMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.undraw_High_five_re_jy711;
            this.ClientSize = new System.Drawing.Size(1047, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmABMUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmABMUsuario";
            this.Load += new System.EventHandler(this.frmABMUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.RJControls.RJButton btnAceptar;
        private CustomControls.RJControls.RJButton btnCancelar;
        private JMaterialTextbox.JMaterialTextbox txtbNombre;
        private JMaterialTextbox.JMaterialTextbox txtbClave;
        private JMaterialTextbox.JMaterialTextbox txtbClaveRep;
        private JMaterialTextbox.JMaterialTextbox txtbFantasma;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox2;
        private System.Windows.Forms.ComboBox cboRol;
        private DiseñosElemGUI.TransparentLabel lblNombre;
        private DiseñosElemGUI.TransparentLabel lblRol;
        private DiseñosElemGUI.TransparentLabel lblRepetirContra;
        private DiseñosElemGUI.TransparentLabel lblContraseña;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private CustomControls.RJControls.RJButton rjButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomFarmacia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}