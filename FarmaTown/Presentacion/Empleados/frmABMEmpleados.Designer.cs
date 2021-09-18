
namespace FarmaTown.Presentacion.Empleados
{
    partial class frmABMEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMEmpleados));
            this.btnLimpiar = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.txtbNombre = new JMaterialTextbox.JMaterialTextbox();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblRepetirContra = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.lblNroDni = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.txtbNroDoc = new JMaterialTextbox.JMaterialTextbox();
            this.btnCancelar = new CustomControls.RJControls.RJButton();
            this.btnAceptar = new CustomControls.RJControls.RJButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbLocalidad = new JMaterialTextbox.JMaterialTextbox();
            this.transparentLabel2 = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.txtbBarrio = new JMaterialTextbox.JMaterialTextbox();
            this.transparentLabel1 = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.txtbNomCalle = new JMaterialTextbox.JMaterialTextbox();
            this.lblCalle = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.txtbNomFarm = new JMaterialTextbox.JMaterialTextbox();
            this.lblNomFarm = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.dgvFarmacias = new System.Windows.Forms.DataGridView();
            this.btnRegEmpleado = new CustomControls.RJControls.RJButton();
            this.idFarmacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomFarmacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmacias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.White;
            groupBox1.BackgroundImage = global::FarmaTown.Properties.Resources.Empleados;
            groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            groupBox1.Controls.Add(this.btnLimpiar);
            groupBox1.Controls.Add(this.label1);
            groupBox1.Controls.Add(this.lblNombre);
            groupBox1.Controls.Add(this.txtbNombre);
            groupBox1.Controls.Add(this.cboTipoDoc);
            groupBox1.Controls.Add(this.lblRepetirContra);
            groupBox1.Controls.Add(this.lblNroDni);
            groupBox1.Controls.Add(this.txtbNroDoc);
            groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            groupBox1.Location = new System.Drawing.Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1233, 240);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Empleado";
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
            this.btnLimpiar.Location = new System.Drawing.Point(916, 98);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 49);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.Black;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.label1.Location = new System.Drawing.Point(26, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "Los campos con (*) \r\nson obligatorios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(282, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(126, 23);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.TabStop = false;
            this.lblNombre.Text = "  Nombre(*):";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopLeft;
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
            this.txtbNombre.Location = new System.Drawing.Point(477, 54);
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
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(477, 169);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(301, 27);
            this.cboTipoDoc.TabIndex = 18;
            // 
            // lblRepetirContra
            // 
            this.lblRepetirContra.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblRepetirContra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRepetirContra.Location = new System.Drawing.Point(237, 169);
            this.lblRepetirContra.Name = "lblRepetirContra";
            this.lblRepetirContra.Size = new System.Drawing.Size(171, 23);
            this.lblRepetirContra.TabIndex = 21;
            this.lblRepetirContra.TabStop = false;
            this.lblRepetirContra.Text = "Tipo Documento:";
            this.lblRepetirContra.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblNroDni
            // 
            this.lblNroDni.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNroDni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNroDni.Location = new System.Drawing.Point(261, 107);
            this.lblNroDni.Name = "lblNroDni";
            this.lblNroDni.Size = new System.Drawing.Size(147, 23);
            this.lblNroDni.TabIndex = 22;
            this.lblNroDni.TabStop = false;
            this.lblNroDni.Text = "N° Documento:";
            this.lblNroDni.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // txtbNroDoc
            // 
            this.txtbNroDoc.BackColor = System.Drawing.Color.Transparent;
            this.txtbNroDoc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbNroDoc.Font_Size = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbNroDoc.ForeColors = System.Drawing.Color.Black;
            this.txtbNroDoc.HintText = null;
            this.txtbNroDoc.IsPassword = false;
            this.txtbNroDoc.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.txtbNroDoc.LineThickness = 3;
            this.txtbNroDoc.Location = new System.Drawing.Point(477, 107);
            this.txtbNroDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNroDoc.MaxLength = 32767;
            this.txtbNroDoc.Name = "txtbNroDoc";
            this.txtbNroDoc.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbNroDoc.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbNroDoc.ReadOnly = false;
            this.txtbNroDoc.Size = new System.Drawing.Size(301, 23);
            this.txtbNroDoc.TabIndex = 14;
            this.txtbNroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbNroDoc.TextName = "";
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
            this.btnCancelar.Location = new System.Drawing.Point(703, 675);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 49);
            this.btnCancelar.TabIndex = 27;
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
            this.btnAceptar.Location = new System.Drawing.Point(1109, 673);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 49);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.Black;
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.txtbLocalidad);
            this.groupBox2.Controls.Add(this.transparentLabel2);
            this.groupBox2.Controls.Add(this.txtbBarrio);
            this.groupBox2.Controls.Add(this.transparentLabel1);
            this.groupBox2.Controls.Add(this.txtbNomCalle);
            this.groupBox2.Controls.Add(this.lblCalle);
            this.groupBox2.Controls.Add(this.txtbNomFarm);
            this.groupBox2.Controls.Add(this.lblNomFarm);
            this.groupBox2.Controls.Add(this.dgvFarmacias);
            this.groupBox2.Controls.Add(this.btnRegEmpleado);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(23, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1233, 395);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Farmacias";
            // 
            // txtbLocalidad
            // 
            this.txtbLocalidad.BackColor = System.Drawing.Color.Transparent;
            this.txtbLocalidad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbLocalidad.Font_Size = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbLocalidad.ForeColors = System.Drawing.Color.Black;
            this.txtbLocalidad.HintText = null;
            this.txtbLocalidad.IsPassword = false;
            this.txtbLocalidad.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.txtbLocalidad.LineThickness = 3;
            this.txtbLocalidad.Location = new System.Drawing.Point(780, 99);
            this.txtbLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtbLocalidad.MaxLength = 32767;
            this.txtbLocalidad.Name = "txtbLocalidad";
            this.txtbLocalidad.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbLocalidad.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbLocalidad.ReadOnly = false;
            this.txtbLocalidad.Size = new System.Drawing.Size(301, 23);
            this.txtbLocalidad.TabIndex = 34;
            this.txtbLocalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbLocalidad.TextName = "";
            // 
            // transparentLabel2
            // 
            this.transparentLabel2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.transparentLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transparentLabel2.Location = new System.Drawing.Point(631, 99);
            this.transparentLabel2.Name = "transparentLabel2";
            this.transparentLabel2.Size = new System.Drawing.Size(118, 23);
            this.transparentLabel2.TabIndex = 33;
            this.transparentLabel2.TabStop = false;
            this.transparentLabel2.Text = " Localidad:";
            this.transparentLabel2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // txtbBarrio
            // 
            this.txtbBarrio.BackColor = System.Drawing.Color.Transparent;
            this.txtbBarrio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbBarrio.Font_Size = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbBarrio.ForeColors = System.Drawing.Color.Black;
            this.txtbBarrio.HintText = null;
            this.txtbBarrio.IsPassword = false;
            this.txtbBarrio.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.txtbBarrio.LineThickness = 3;
            this.txtbBarrio.Location = new System.Drawing.Point(780, 47);
            this.txtbBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.txtbBarrio.MaxLength = 32767;
            this.txtbBarrio.Name = "txtbBarrio";
            this.txtbBarrio.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbBarrio.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbBarrio.ReadOnly = false;
            this.txtbBarrio.Size = new System.Drawing.Size(301, 23);
            this.txtbBarrio.TabIndex = 32;
            this.txtbBarrio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbBarrio.TextName = "";
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.transparentLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transparentLabel1.Location = new System.Drawing.Point(680, 47);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(69, 23);
            this.transparentLabel1.TabIndex = 31;
            this.transparentLabel1.TabStop = false;
            this.transparentLabel1.Text = "Barrio:";
            this.transparentLabel1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // txtbNomCalle
            // 
            this.txtbNomCalle.BackColor = System.Drawing.Color.Transparent;
            this.txtbNomCalle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbNomCalle.Font_Size = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbNomCalle.ForeColors = System.Drawing.Color.Black;
            this.txtbNomCalle.HintText = null;
            this.txtbNomCalle.IsPassword = false;
            this.txtbNomCalle.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.txtbNomCalle.LineThickness = 3;
            this.txtbNomCalle.Location = new System.Drawing.Point(263, 99);
            this.txtbNomCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNomCalle.MaxLength = 32767;
            this.txtbNomCalle.Name = "txtbNomCalle";
            this.txtbNomCalle.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbNomCalle.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbNomCalle.ReadOnly = false;
            this.txtbNomCalle.Size = new System.Drawing.Size(301, 23);
            this.txtbNomCalle.TabIndex = 29;
            this.txtbNomCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbNomCalle.TextName = "";
            // 
            // lblCalle
            // 
            this.lblCalle.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblCalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCalle.Location = new System.Drawing.Point(92, 99);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(152, 23);
            this.lblCalle.TabIndex = 28;
            this.lblCalle.TabStop = false;
            this.lblCalle.Text = "Nombre Calle:";
            this.lblCalle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // txtbNomFarm
            // 
            this.txtbNomFarm.BackColor = System.Drawing.Color.Transparent;
            this.txtbNomFarm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbNomFarm.Font_Size = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbNomFarm.ForeColors = System.Drawing.Color.Black;
            this.txtbNomFarm.HintText = null;
            this.txtbNomFarm.IsPassword = false;
            this.txtbNomFarm.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.txtbNomFarm.LineThickness = 3;
            this.txtbNomFarm.Location = new System.Drawing.Point(263, 47);
            this.txtbNomFarm.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNomFarm.MaxLength = 32767;
            this.txtbNomFarm.Name = "txtbNomFarm";
            this.txtbNomFarm.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbNomFarm.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbNomFarm.ReadOnly = false;
            this.txtbNomFarm.Size = new System.Drawing.Size(301, 23);
            this.txtbNomFarm.TabIndex = 27;
            this.txtbNomFarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbNomFarm.TextName = "";
            // 
            // lblNomFarm
            // 
            this.lblNomFarm.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNomFarm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomFarm.Location = new System.Drawing.Point(138, 47);
            this.lblNomFarm.Name = "lblNomFarm";
            this.lblNomFarm.Size = new System.Drawing.Size(106, 23);
            this.lblNomFarm.TabIndex = 27;
            this.lblNomFarm.TabStop = false;
            this.lblNomFarm.Text = "  Nombre:";
            this.lblNomFarm.TextAlign = System.Drawing.ContentAlignment.TopLeft;
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
            this.idFarmacia,
            this.nomFarmacia,
            this.calle,
            this.numero,
            this.nomBarrio,
            this.nomLocalidad});
            this.dgvFarmacias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.dgvFarmacias.Location = new System.Drawing.Point(21, 156);
            this.dgvFarmacias.MultiSelect = false;
            this.dgvFarmacias.Name = "dgvFarmacias";
            this.dgvFarmacias.ReadOnly = true;
            this.dgvFarmacias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFarmacias.Size = new System.Drawing.Size(1042, 219);
            this.dgvFarmacias.TabIndex = 27;
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
            this.btnRegEmpleado.Location = new System.Drawing.Point(1110, 229);
            this.btnRegEmpleado.Name = "btnRegEmpleado";
            this.btnRegEmpleado.Size = new System.Drawing.Size(106, 56);
            this.btnRegEmpleado.TabIndex = 26;
            this.btnRegEmpleado.Text = "Registrar Farmacia";
            this.btnRegEmpleado.TextColor = System.Drawing.Color.Black;
            this.btnRegEmpleado.UseVisualStyleBackColor = false;
            // 
            // idFarmacia
            // 
            this.idFarmacia.HeaderText = "ID";
            this.idFarmacia.Name = "idFarmacia";
            this.idFarmacia.ReadOnly = true;
            this.idFarmacia.Width = 50;
            // 
            // nomFarmacia
            // 
            this.nomFarmacia.HeaderText = "Nombre";
            this.nomFarmacia.Name = "nomFarmacia";
            this.nomFarmacia.ReadOnly = true;
            this.nomFarmacia.Width = 250;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            this.calle.Width = 170;
            // 
            // numero
            // 
            this.numero.HeaderText = "N°";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // nomBarrio
            // 
            this.nomBarrio.HeaderText = "Barrio";
            this.nomBarrio.Name = "nomBarrio";
            this.nomBarrio.ReadOnly = true;
            this.nomBarrio.Width = 200;
            // 
            // nomLocalidad
            // 
            this.nomLocalidad.HeaderText = "Localidad";
            this.nomLocalidad.Name = "nomLocalidad";
            this.nomLocalidad.ReadOnly = true;
            this.nomLocalidad.Width = 200;
            // 
            // frmABMEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.Empleados;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1290, 747);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmABMEmpleados";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.frmABMEmpleados_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmacias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.RJControls.RJButton btnLimpiar;
        private DiseñosElemGUI.TransparentLabel lblNombre;
        private JMaterialTextbox.JMaterialTextbox txtbNombre;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private DiseñosElemGUI.TransparentLabel lblRepetirContra;
        private DiseñosElemGUI.TransparentLabel lblNroDni;
        private JMaterialTextbox.JMaterialTextbox txtbNroDoc;
        private CustomControls.RJControls.RJButton btnCancelar;
        private CustomControls.RJControls.RJButton btnAceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvFarmacias;
        private System.Windows.Forms.Label label1;
        private JMaterialTextbox.JMaterialTextbox txtbNomFarm;
        private DiseñosElemGUI.TransparentLabel lblNomFarm;
        private JMaterialTextbox.JMaterialTextbox txtbLocalidad;
        private DiseñosElemGUI.TransparentLabel transparentLabel2;
        private JMaterialTextbox.JMaterialTextbox txtbBarrio;
        private DiseñosElemGUI.TransparentLabel transparentLabel1;
        private JMaterialTextbox.JMaterialTextbox txtbNomCalle;
        private DiseñosElemGUI.TransparentLabel lblCalle;
        private CustomControls.RJControls.RJButton btnRegEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFarmacia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomFarmacia;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomLocalidad;
    }
}