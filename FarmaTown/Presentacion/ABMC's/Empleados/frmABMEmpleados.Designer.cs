
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
            System.Windows.Forms.GroupBox gbEmpleados;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMEmpleados));
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbPasaporteLetras = new System.Windows.Forms.TextBox();
            this.txtbPasaporteNro = new System.Windows.Forms.TextBox();
            this.lblAvisoNroDoc = new System.Windows.Forms.Label();
            this.txtbNroDoc = new System.Windows.Forms.TextBox();
            this.btnLimpiarEmpleado = new CustomControls.RJControls.RJButton();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblNombre = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblTipoDoc = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.lblNroDni = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.gbFarmacias = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new CustomControls.RJControls.RJButton();
            this.transparentLabel3 = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.gbFiltrosFarm = new System.Windows.Forms.GroupBox();
            this.btnConsultarFarm = new CustomControls.RJControls.RJButton();
            this.btnLimpiarFarmacias = new CustomControls.RJControls.RJButton();
            this.transparentLabel1 = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.txtbLocalidad = new JMaterialTextbox.JMaterialTextbox();
            this.lblNomFarm = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.transparentLabel2 = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.txtbNomFarm = new JMaterialTextbox.JMaterialTextbox();
            this.txtbBarrio = new JMaterialTextbox.JMaterialTextbox();
            this.lblCalle = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.txtbNomCalle = new JMaterialTextbox.JMaterialTextbox();
            this.dgvFarmacias = new System.Windows.Forms.DataGridView();
            this.idFarmacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomFarmacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegFarmacia = new CustomControls.RJControls.RJButton();
            this.btnCancelar = new CustomControls.RJControls.RJButton();
            this.btnAceptar = new CustomControls.RJControls.RJButton();
            gbEmpleados = new System.Windows.Forms.GroupBox();
            gbEmpleados.SuspendLayout();
            this.gbFarmacias.SuspendLayout();
            this.gbFiltrosFarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmacias)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEmpleados
            // 
            gbEmpleados.BackColor = System.Drawing.Color.Transparent;
            gbEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            gbEmpleados.Controls.Add(this.txtbNombre);
            gbEmpleados.Controls.Add(this.txtbPasaporteLetras);
            gbEmpleados.Controls.Add(this.txtbPasaporteNro);
            gbEmpleados.Controls.Add(this.lblAvisoNroDoc);
            gbEmpleados.Controls.Add(this.txtbNroDoc);
            gbEmpleados.Controls.Add(this.btnLimpiarEmpleado);
            gbEmpleados.Controls.Add(this.lblAviso);
            gbEmpleados.Controls.Add(this.lblNombre);
            gbEmpleados.Controls.Add(this.cboTipoDoc);
            gbEmpleados.Controls.Add(this.lblTipoDoc);
            gbEmpleados.Controls.Add(this.lblNroDni);
            gbEmpleados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            gbEmpleados.Location = new System.Drawing.Point(23, 12);
            gbEmpleados.Name = "gbEmpleados";
            gbEmpleados.Size = new System.Drawing.Size(1233, 200);
            gbEmpleados.TabIndex = 30;
            gbEmpleados.TabStop = false;
            gbEmpleados.Text = "Datos del Empleado";
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNombre.Location = new System.Drawing.Point(477, 26);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(301, 20);
            this.txtbNombre.TabIndex = 28;
            this.txtbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNombre_KeyPress);
            // 
            // txtbPasaporteLetras
            // 
            this.txtbPasaporteLetras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbPasaporteLetras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPasaporteLetras.Enabled = false;
            this.txtbPasaporteLetras.Location = new System.Drawing.Point(477, 136);
            this.txtbPasaporteLetras.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbPasaporteLetras.Name = "txtbPasaporteLetras";
            this.txtbPasaporteLetras.Size = new System.Drawing.Size(86, 20);
            this.txtbPasaporteLetras.TabIndex = 27;
            this.txtbPasaporteLetras.Visible = false;
            this.txtbPasaporteLetras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbPasaporteLetras_KeyDown);
            // 
            // txtbPasaporteNro
            // 
            this.txtbPasaporteNro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbPasaporteNro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPasaporteNro.Enabled = false;
            this.txtbPasaporteNro.Location = new System.Drawing.Point(593, 136);
            this.txtbPasaporteNro.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbPasaporteNro.Name = "txtbPasaporteNro";
            this.txtbPasaporteNro.Size = new System.Drawing.Size(185, 20);
            this.txtbPasaporteNro.TabIndex = 26;
            this.txtbPasaporteNro.Visible = false;
            this.txtbPasaporteNro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbPasaporteNro_KeyDown);
            // 
            // lblAvisoNroDoc
            // 
            this.lblAvisoNroDoc.AutoSize = true;
            this.lblAvisoNroDoc.BackColor = System.Drawing.Color.IndianRed;
            this.lblAvisoNroDoc.Location = new System.Drawing.Point(493, 199);
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
            this.txtbNroDoc.Location = new System.Drawing.Point(477, 136);
            this.txtbNroDoc.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbNroDoc.Name = "txtbNroDoc";
            this.txtbNroDoc.Size = new System.Drawing.Size(301, 20);
            this.txtbNroDoc.TabIndex = 2;
            this.txtbNroDoc.Visible = false;
            this.txtbNroDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbNroDoc_KeyDown);
            // 
            // btnLimpiarEmpleado
            // 
            this.btnLimpiarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnLimpiarEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnLimpiarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarEmpleado.BorderColor = System.Drawing.Color.Green;
            this.btnLimpiarEmpleado.BorderRadius = 20;
            this.btnLimpiarEmpleado.BorderSize = 1;
            this.btnLimpiarEmpleado.CausesValidation = false;
            this.btnLimpiarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnLimpiarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpiarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnLimpiarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarEmpleado.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarEmpleado.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiarEmpleado.Location = new System.Drawing.Point(916, 58);
            this.btnLimpiarEmpleado.Name = "btnLimpiarEmpleado";
            this.btnLimpiarEmpleado.Size = new System.Drawing.Size(129, 49);
            this.btnLimpiarEmpleado.TabIndex = 4;
            this.btnLimpiarEmpleado.Text = "Limpiar";
            this.btnLimpiarEmpleado.TextColor = System.Drawing.Color.Black;
            this.btnLimpiarEmpleado.UseVisualStyleBackColor = false;
            this.btnLimpiarEmpleado.Click += new System.EventHandler(this.btnLimpiarEmpleado_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.lblAviso.Location = new System.Drawing.Point(32, 65);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(161, 38);
            this.lblAviso.TabIndex = 23;
            this.lblAviso.Text = "Los campos con (*) \r\nson obligatorios";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(282, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(126, 23);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.TabStop = false;
            this.lblNombre.Text = "  Nombre(*):";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(477, 80);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(301, 27);
            this.cboTipoDoc.TabIndex = 3;
            this.cboTipoDoc.DropDownClosed += new System.EventHandler(this.cboTipoDoc_DropDownClosed);
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblTipoDoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipoDoc.Location = new System.Drawing.Point(215, 80);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(193, 23);
            this.lblTipoDoc.TabIndex = 21;
            this.lblTipoDoc.TabStop = false;
            this.lblTipoDoc.Text = "Tipo Documento(*):";
            this.lblTipoDoc.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblNroDni
            // 
            this.lblNroDni.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNroDni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNroDni.Location = new System.Drawing.Point(228, 133);
            this.lblNroDni.Name = "lblNroDni";
            this.lblNroDni.Size = new System.Drawing.Size(180, 23);
            this.lblNroDni.TabIndex = 22;
            this.lblNroDni.TabStop = false;
            this.lblNroDni.Text = "N° Documento(*):";
            this.lblNroDni.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // gbFarmacias
            // 
            this.gbFarmacias.BackColor = System.Drawing.Color.White;
            this.gbFarmacias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbFarmacias.Controls.Add(this.btnActualizar);
            this.gbFarmacias.Controls.Add(this.transparentLabel3);
            this.gbFarmacias.Controls.Add(this.gbFiltrosFarm);
            this.gbFarmacias.Controls.Add(this.dgvFarmacias);
            this.gbFarmacias.Controls.Add(this.btnRegFarmacia);
            this.gbFarmacias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gbFarmacias.Location = new System.Drawing.Point(23, 233);
            this.gbFarmacias.Name = "gbFarmacias";
            this.gbFarmacias.Size = new System.Drawing.Size(1233, 429);
            this.gbFarmacias.TabIndex = 29;
            this.gbFarmacias.TabStop = false;
            this.gbFarmacias.Text = "Datos de Farmacias";
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
            this.btnActualizar.Location = new System.Drawing.Point(1111, 318);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 37);
            this.btnActualizar.TabIndex = 36;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Black;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // transparentLabel3
            // 
            this.transparentLabel3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.transparentLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transparentLabel3.Location = new System.Drawing.Point(18, 174);
            this.transparentLabel3.Name = "transparentLabel3";
            this.transparentLabel3.Size = new System.Drawing.Size(30, 23);
            this.transparentLabel3.TabIndex = 35;
            this.transparentLabel3.TabStop = false;
            this.transparentLabel3.Text = "(*)";
            this.transparentLabel3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // gbFiltrosFarm
            // 
            this.gbFiltrosFarm.Controls.Add(this.btnConsultarFarm);
            this.gbFiltrosFarm.Controls.Add(this.btnLimpiarFarmacias);
            this.gbFiltrosFarm.Controls.Add(this.transparentLabel1);
            this.gbFiltrosFarm.Controls.Add(this.txtbLocalidad);
            this.gbFiltrosFarm.Controls.Add(this.lblNomFarm);
            this.gbFiltrosFarm.Controls.Add(this.transparentLabel2);
            this.gbFiltrosFarm.Controls.Add(this.txtbNomFarm);
            this.gbFiltrosFarm.Controls.Add(this.txtbBarrio);
            this.gbFiltrosFarm.Controls.Add(this.lblCalle);
            this.gbFiltrosFarm.Controls.Add(this.txtbNomCalle);
            this.gbFiltrosFarm.Location = new System.Drawing.Point(18, 32);
            this.gbFiltrosFarm.Name = "gbFiltrosFarm";
            this.gbFiltrosFarm.Size = new System.Drawing.Size(1198, 136);
            this.gbFiltrosFarm.TabIndex = 35;
            this.gbFiltrosFarm.TabStop = false;
            this.gbFiltrosFarm.Text = "FILTROS";
            // 
            // btnConsultarFarm
            // 
            this.btnConsultarFarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnConsultarFarm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnConsultarFarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultarFarm.BorderColor = System.Drawing.Color.Green;
            this.btnConsultarFarm.BorderRadius = 20;
            this.btnConsultarFarm.BorderSize = 1;
            this.btnConsultarFarm.CausesValidation = false;
            this.btnConsultarFarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarFarm.FlatAppearance.BorderSize = 0;
            this.btnConsultarFarm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConsultarFarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnConsultarFarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFarm.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFarm.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarFarm.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnConsultarFarm.Location = new System.Drawing.Point(1058, 78);
            this.btnConsultarFarm.Name = "btnConsultarFarm";
            this.btnConsultarFarm.Size = new System.Drawing.Size(115, 37);
            this.btnConsultarFarm.TabIndex = 35;
            this.btnConsultarFarm.Text = "Consultar";
            this.btnConsultarFarm.TextColor = System.Drawing.Color.Black;
            this.btnConsultarFarm.UseVisualStyleBackColor = false;
            this.btnConsultarFarm.Click += new System.EventHandler(this.btnConsultarFarm_Click);
            // 
            // btnLimpiarFarmacias
            // 
            this.btnLimpiarFarmacias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnLimpiarFarmacias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnLimpiarFarmacias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarFarmacias.BorderColor = System.Drawing.Color.Green;
            this.btnLimpiarFarmacias.BorderRadius = 20;
            this.btnLimpiarFarmacias.BorderSize = 1;
            this.btnLimpiarFarmacias.CausesValidation = false;
            this.btnLimpiarFarmacias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarFarmacias.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFarmacias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpiarFarmacias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnLimpiarFarmacias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFarmacias.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFarmacias.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarFarmacias.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiarFarmacias.Location = new System.Drawing.Point(1058, 26);
            this.btnLimpiarFarmacias.Name = "btnLimpiarFarmacias";
            this.btnLimpiarFarmacias.Size = new System.Drawing.Size(115, 37);
            this.btnLimpiarFarmacias.TabIndex = 34;
            this.btnLimpiarFarmacias.Text = "Limpiar";
            this.btnLimpiarFarmacias.TextColor = System.Drawing.Color.Black;
            this.btnLimpiarFarmacias.UseVisualStyleBackColor = false;
            this.btnLimpiarFarmacias.Click += new System.EventHandler(this.btnLimpiarFarmacias_Click);
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.transparentLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transparentLabel1.Location = new System.Drawing.Point(611, 26);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(69, 23);
            this.transparentLabel1.TabIndex = 31;
            this.transparentLabel1.TabStop = false;
            this.transparentLabel1.Text = "Barrio:";
            this.transparentLabel1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
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
            this.txtbLocalidad.Location = new System.Drawing.Point(711, 78);
            this.txtbLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtbLocalidad.MaxLength = 32767;
            this.txtbLocalidad.Name = "txtbLocalidad";
            this.txtbLocalidad.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbLocalidad.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbLocalidad.ReadOnly = false;
            this.txtbLocalidad.Size = new System.Drawing.Size(301, 23);
            this.txtbLocalidad.TabIndex = 8;
            this.txtbLocalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbLocalidad.TextName = "";
            // 
            // lblNomFarm
            // 
            this.lblNomFarm.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNomFarm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomFarm.Location = new System.Drawing.Point(69, 26);
            this.lblNomFarm.Name = "lblNomFarm";
            this.lblNomFarm.Size = new System.Drawing.Size(106, 23);
            this.lblNomFarm.TabIndex = 27;
            this.lblNomFarm.TabStop = false;
            this.lblNomFarm.Text = "  Nombre:";
            this.lblNomFarm.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // transparentLabel2
            // 
            this.transparentLabel2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.transparentLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transparentLabel2.Location = new System.Drawing.Point(562, 78);
            this.transparentLabel2.Name = "transparentLabel2";
            this.transparentLabel2.Size = new System.Drawing.Size(118, 23);
            this.transparentLabel2.TabIndex = 33;
            this.transparentLabel2.TabStop = false;
            this.transparentLabel2.Text = " Localidad:";
            this.transparentLabel2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
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
            this.txtbNomFarm.Location = new System.Drawing.Point(194, 26);
            this.txtbNomFarm.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNomFarm.MaxLength = 32767;
            this.txtbNomFarm.Name = "txtbNomFarm";
            this.txtbNomFarm.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbNomFarm.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbNomFarm.ReadOnly = false;
            this.txtbNomFarm.Size = new System.Drawing.Size(301, 23);
            this.txtbNomFarm.TabIndex = 5;
            this.txtbNomFarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbNomFarm.TextName = "";
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
            this.txtbBarrio.Location = new System.Drawing.Point(711, 26);
            this.txtbBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.txtbBarrio.MaxLength = 32767;
            this.txtbBarrio.Name = "txtbBarrio";
            this.txtbBarrio.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbBarrio.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbBarrio.ReadOnly = false;
            this.txtbBarrio.Size = new System.Drawing.Size(301, 23);
            this.txtbBarrio.TabIndex = 7;
            this.txtbBarrio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbBarrio.TextName = "";
            // 
            // lblCalle
            // 
            this.lblCalle.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblCalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCalle.Location = new System.Drawing.Point(23, 78);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(152, 23);
            this.lblCalle.TabIndex = 28;
            this.lblCalle.TabStop = false;
            this.lblCalle.Text = "Nombre Calle:";
            this.lblCalle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
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
            this.txtbNomCalle.Location = new System.Drawing.Point(194, 78);
            this.txtbNomCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNomCalle.MaxLength = 32767;
            this.txtbNomCalle.Name = "txtbNomCalle";
            this.txtbNomCalle.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbNomCalle.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbNomCalle.ReadOnly = false;
            this.txtbNomCalle.Size = new System.Drawing.Size(301, 23);
            this.txtbNomCalle.TabIndex = 6;
            this.txtbNomCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbNomCalle.TextName = "";
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
            this.dgvFarmacias.Location = new System.Drawing.Point(18, 203);
            this.dgvFarmacias.MultiSelect = false;
            this.dgvFarmacias.Name = "dgvFarmacias";
            this.dgvFarmacias.ReadOnly = true;
            this.dgvFarmacias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFarmacias.Size = new System.Drawing.Size(1078, 211);
            this.dgvFarmacias.TabIndex = 27;
            this.dgvFarmacias.TabStop = false;
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
            // btnRegFarmacia
            // 
            this.btnRegFarmacia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnRegFarmacia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnRegFarmacia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegFarmacia.BorderColor = System.Drawing.Color.Green;
            this.btnRegFarmacia.BorderRadius = 20;
            this.btnRegFarmacia.BorderSize = 1;
            this.btnRegFarmacia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegFarmacia.FlatAppearance.BorderSize = 0;
            this.btnRegFarmacia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRegFarmacia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRegFarmacia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegFarmacia.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegFarmacia.ForeColor = System.Drawing.Color.Black;
            this.btnRegFarmacia.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRegFarmacia.Location = new System.Drawing.Point(1110, 240);
            this.btnRegFarmacia.Name = "btnRegFarmacia";
            this.btnRegFarmacia.Size = new System.Drawing.Size(106, 56);
            this.btnRegFarmacia.TabIndex = 9;
            this.btnRegFarmacia.Text = "Registrar Farmacia";
            this.btnRegFarmacia.TextColor = System.Drawing.Color.Black;
            this.btnRegFarmacia.UseVisualStyleBackColor = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(712, 670);
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
            this.btnAceptar.Location = new System.Drawing.Point(1116, 668);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 49);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.Black;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmABMEmpleados
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.Empleados;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1281, 731);
            this.Controls.Add(gbEmpleados);
            this.Controls.Add(this.gbFarmacias);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmABMEmpleados";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmABMEmpleados_Load);
            gbEmpleados.ResumeLayout(false);
            gbEmpleados.PerformLayout();
            this.gbFarmacias.ResumeLayout(false);
            this.gbFiltrosFarm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmacias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.RJControls.RJButton btnCancelar;
        private CustomControls.RJControls.RJButton btnAceptar;
        private System.Windows.Forms.GroupBox gbFarmacias;
        private System.Windows.Forms.DataGridView dgvFarmacias;
        private JMaterialTextbox.JMaterialTextbox txtbNomFarm;
        private DiseñosElemGUI.TransparentLabel lblNomFarm;
        private JMaterialTextbox.JMaterialTextbox txtbLocalidad;
        private DiseñosElemGUI.TransparentLabel transparentLabel2;
        private JMaterialTextbox.JMaterialTextbox txtbBarrio;
        private DiseñosElemGUI.TransparentLabel transparentLabel1;
        private JMaterialTextbox.JMaterialTextbox txtbNomCalle;
        private DiseñosElemGUI.TransparentLabel lblCalle;
        private CustomControls.RJControls.RJButton btnRegFarmacia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFarmacia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomFarmacia;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomLocalidad;
        private System.Windows.Forms.GroupBox gbFiltrosFarm;
        private DiseñosElemGUI.TransparentLabel transparentLabel3;
        private CustomControls.RJControls.RJButton btnLimpiarFarmacias;
        private System.Windows.Forms.TextBox txtbNroDoc;
        private CustomControls.RJControls.RJButton btnLimpiarEmpleado;
        private System.Windows.Forms.Label lblAviso;
        private DiseñosElemGUI.TransparentLabel lblNombre;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private DiseñosElemGUI.TransparentLabel lblTipoDoc;
        private DiseñosElemGUI.TransparentLabel lblNroDni;
        private CustomControls.RJControls.RJButton btnConsultarFarm;
        private CustomControls.RJControls.RJButton btnActualizar;
        private System.Windows.Forms.Label lblAvisoNroDoc;
        private System.Windows.Forms.TextBox txtbPasaporteNro;
        private System.Windows.Forms.TextBox txtbPasaporteLetras;
        private System.Windows.Forms.TextBox txtbNombre;
    }
}