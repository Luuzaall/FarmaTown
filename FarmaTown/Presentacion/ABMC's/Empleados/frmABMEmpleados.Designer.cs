
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
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblNomEmp = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbPasaporteLetras = new System.Windows.Forms.TextBox();
            this.txtbPasaporteNro = new System.Windows.Forms.TextBox();
            this.lblAvisoNroDoc = new System.Windows.Forms.Label();
            this.txtbNroDoc = new System.Windows.Forms.TextBox();
            this.btnLimpiarEmpleado = new CustomControls.RJControls.RJButton();
            this.lblAviso = new System.Windows.Forms.Label();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.gbFarmacias = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnActualizar = new CustomControls.RJControls.RJButton();
            this.gbFiltrosFarm = new System.Windows.Forms.GroupBox();
            this.txtbLocalidad = new System.Windows.Forms.TextBox();
            this.txtbNomFarm = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtbNomCalle = new System.Windows.Forms.TextBox();
            this.lblNomCalle = new System.Windows.Forms.Label();
            this.txtbBarrio = new System.Windows.Forms.TextBox();
            this.btnConsultarFarm = new CustomControls.RJControls.RJButton();
            this.lnlNomFarm = new System.Windows.Forms.Label();
            this.btnLimpiarFarmacias = new CustomControls.RJControls.RJButton();
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
            gbEmpleados.Controls.Add(this.lblTipoDoc);
            gbEmpleados.Controls.Add(this.lblNroDoc);
            gbEmpleados.Controls.Add(this.lblNomEmp);
            gbEmpleados.Controls.Add(this.txtbNombre);
            gbEmpleados.Controls.Add(this.txtbPasaporteLetras);
            gbEmpleados.Controls.Add(this.txtbPasaporteNro);
            gbEmpleados.Controls.Add(this.lblAvisoNroDoc);
            gbEmpleados.Controls.Add(this.txtbNroDoc);
            gbEmpleados.Controls.Add(this.btnLimpiarEmpleado);
            gbEmpleados.Controls.Add(this.lblAviso);
            gbEmpleados.Controls.Add(this.cboTipoDoc);
            gbEmpleados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            gbEmpleados.Location = new System.Drawing.Point(23, 12);
            gbEmpleados.Name = "gbEmpleados";
            gbEmpleados.Size = new System.Drawing.Size(1233, 152);
            gbEmpleados.TabIndex = 1;
            gbEmpleados.TabStop = false;
            gbEmpleados.Text = "Datos del Empleado";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.BackColor = System.Drawing.Color.White;
            this.lblTipoDoc.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblTipoDoc.Location = new System.Drawing.Point(239, 70);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(201, 23);
            this.lblTipoDoc.TabIndex = 31;
            this.lblTipoDoc.Text = "Tipo Documento(*):";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNroDoc.Location = new System.Drawing.Point(255, 115);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(185, 23);
            this.lblNroDoc.TabIndex = 30;
            this.lblNroDoc.Text = "N° Documento(*):";
            // 
            // lblNomEmp
            // 
            this.lblNomEmp.AutoSize = true;
            this.lblNomEmp.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNomEmp.Location = new System.Drawing.Point(308, 26);
            this.lblNomEmp.Name = "lblNomEmp";
            this.lblNomEmp.Size = new System.Drawing.Size(132, 23);
            this.lblNomEmp.TabIndex = 25;
            this.lblNomEmp.Text = "  Nombre(*):";
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNombre.Location = new System.Drawing.Point(477, 26);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(301, 20);
            this.txtbNombre.TabIndex = 1;
            this.txtbNombre.TextChanged += new System.EventHandler(this.txtbNombre_TextChanged);
            this.txtbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbNombre_KeyDown);
            // 
            // txtbPasaporteLetras
            // 
            this.txtbPasaporteLetras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbPasaporteLetras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPasaporteLetras.Enabled = false;
            this.txtbPasaporteLetras.Location = new System.Drawing.Point(477, 118);
            this.txtbPasaporteLetras.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbPasaporteLetras.Name = "txtbPasaporteLetras";
            this.txtbPasaporteLetras.Size = new System.Drawing.Size(86, 20);
            this.txtbPasaporteLetras.TabIndex = 3;
            this.txtbPasaporteLetras.Visible = false;
            this.txtbPasaporteLetras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbPasaporteLetras_KeyDown);
            // 
            // txtbPasaporteNro
            // 
            this.txtbPasaporteNro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbPasaporteNro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPasaporteNro.Enabled = false;
            this.txtbPasaporteNro.Location = new System.Drawing.Point(593, 118);
            this.txtbPasaporteNro.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbPasaporteNro.Name = "txtbPasaporteNro";
            this.txtbPasaporteNro.Size = new System.Drawing.Size(185, 20);
            this.txtbPasaporteNro.TabIndex = 3;
            this.txtbPasaporteNro.Visible = false;
            this.txtbPasaporteNro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbPasaporteNro_KeyDown);
            // 
            // lblAvisoNroDoc
            // 
            this.lblAvisoNroDoc.AutoSize = true;
            this.lblAvisoNroDoc.BackColor = System.Drawing.Color.IndianRed;
            this.lblAvisoNroDoc.Location = new System.Drawing.Point(498, 159);
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
            this.txtbNroDoc.Location = new System.Drawing.Point(477, 118);
            this.txtbNroDoc.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbNroDoc.Name = "txtbNroDoc";
            this.txtbNroDoc.Size = new System.Drawing.Size(301, 20);
            this.txtbNroDoc.TabIndex = 3;
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
            this.btnLimpiarEmpleado.Location = new System.Drawing.Point(876, 58);
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
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(477, 70);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(301, 27);
            this.cboTipoDoc.TabIndex = 2;
            this.cboTipoDoc.SelectionChangeCommitted += new System.EventHandler(this.cboTipoDoc_SelectionChangeCommited);
            // 
            // gbFarmacias
            // 
            this.gbFarmacias.BackColor = System.Drawing.Color.Transparent;
            this.gbFarmacias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbFarmacias.Controls.Add(this.label8);
            this.gbFarmacias.Controls.Add(this.btnActualizar);
            this.gbFarmacias.Controls.Add(this.gbFiltrosFarm);
            this.gbFarmacias.Controls.Add(this.dgvFarmacias);
            this.gbFarmacias.Controls.Add(this.btnRegFarmacia);
            this.gbFarmacias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gbFarmacias.Location = new System.Drawing.Point(23, 170);
            this.gbFarmacias.Name = "gbFarmacias";
            this.gbFarmacias.Size = new System.Drawing.Size(1233, 429);
            this.gbFarmacias.TabIndex = 3;
            this.gbFarmacias.TabStop = false;
            this.gbFarmacias.Text = "Datos de Farmacias";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(14, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "(*)";
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
            this.btnActualizar.Location = new System.Drawing.Point(1085, 316);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 37);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Black;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gbFiltrosFarm
            // 
            this.gbFiltrosFarm.BackColor = System.Drawing.Color.Snow;
            this.gbFiltrosFarm.Controls.Add(this.txtbLocalidad);
            this.gbFiltrosFarm.Controls.Add(this.txtbNomFarm);
            this.gbFiltrosFarm.Controls.Add(this.lblLocalidad);
            this.gbFiltrosFarm.Controls.Add(this.lblBarrio);
            this.gbFiltrosFarm.Controls.Add(this.txtbNomCalle);
            this.gbFiltrosFarm.Controls.Add(this.lblNomCalle);
            this.gbFiltrosFarm.Controls.Add(this.txtbBarrio);
            this.gbFiltrosFarm.Controls.Add(this.btnConsultarFarm);
            this.gbFiltrosFarm.Controls.Add(this.lnlNomFarm);
            this.gbFiltrosFarm.Controls.Add(this.btnLimpiarFarmacias);
            this.gbFiltrosFarm.Location = new System.Drawing.Point(18, 32);
            this.gbFiltrosFarm.Name = "gbFiltrosFarm";
            this.gbFiltrosFarm.Size = new System.Drawing.Size(1198, 136);
            this.gbFiltrosFarm.TabIndex = 2;
            this.gbFiltrosFarm.TabStop = false;
            this.gbFiltrosFarm.Text = "FILTROS";
            // 
            // txtbLocalidad
            // 
            this.txtbLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbLocalidad.Location = new System.Drawing.Point(711, 84);
            this.txtbLocalidad.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbLocalidad.Name = "txtbLocalidad";
            this.txtbLocalidad.Size = new System.Drawing.Size(301, 20);
            this.txtbLocalidad.TabIndex = 8;
            this.txtbLocalidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbLocalidad_KeyDown);
            // 
            // txtbNomFarm
            // 
            this.txtbNomFarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNomFarm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNomFarm.Location = new System.Drawing.Point(209, 29);
            this.txtbNomFarm.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbNomFarm.Name = "txtbNomFarm";
            this.txtbNomFarm.Size = new System.Drawing.Size(301, 20);
            this.txtbNomFarm.TabIndex = 5;
            this.txtbNomFarm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbNomFarm_KeyDown);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblLocalidad.Location = new System.Drawing.Point(571, 84);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(119, 23);
            this.lblLocalidad.TabIndex = 27;
            this.lblLocalidad.Text = " Localidad:";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblBarrio.Location = new System.Drawing.Point(619, 29);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(71, 23);
            this.lblBarrio.TabIndex = 29;
            this.lblBarrio.Text = "Barrio:";
            // 
            // txtbNomCalle
            // 
            this.txtbNomCalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNomCalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNomCalle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbNomCalle.Location = new System.Drawing.Point(209, 84);
            this.txtbNomCalle.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbNomCalle.Name = "txtbNomCalle";
            this.txtbNomCalle.Size = new System.Drawing.Size(301, 20);
            this.txtbNomCalle.TabIndex = 7;
            this.txtbNomCalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbNomCalle_KeyDown);
            // 
            // lblNomCalle
            // 
            this.lblNomCalle.AutoSize = true;
            this.lblNomCalle.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNomCalle.Location = new System.Drawing.Point(37, 81);
            this.lblNomCalle.Name = "lblNomCalle";
            this.lblNomCalle.Size = new System.Drawing.Size(153, 23);
            this.lblNomCalle.TabIndex = 28;
            this.lblNomCalle.Text = "Nombre Calle:";
            // 
            // txtbBarrio
            // 
            this.txtbBarrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbBarrio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbBarrio.Location = new System.Drawing.Point(711, 29);
            this.txtbBarrio.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbBarrio.Name = "txtbBarrio";
            this.txtbBarrio.Size = new System.Drawing.Size(301, 20);
            this.txtbBarrio.TabIndex = 6;
            this.txtbBarrio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbBarrio_KeyDown);
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
            this.btnConsultarFarm.TabIndex = 10;
            this.btnConsultarFarm.Text = "Consultar";
            this.btnConsultarFarm.TextColor = System.Drawing.Color.Black;
            this.btnConsultarFarm.UseVisualStyleBackColor = false;
            this.btnConsultarFarm.Click += new System.EventHandler(this.btnConsultarFarm_Click);
            // 
            // lnlNomFarm
            // 
            this.lnlNomFarm.AutoSize = true;
            this.lnlNomFarm.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lnlNomFarm.Location = new System.Drawing.Point(83, 26);
            this.lnlNomFarm.Name = "lnlNomFarm";
            this.lnlNomFarm.Size = new System.Drawing.Size(107, 23);
            this.lnlNomFarm.TabIndex = 26;
            this.lnlNomFarm.Text = "  Nombre:";
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
            this.btnLimpiarFarmacias.TabIndex = 9;
            this.btnLimpiarFarmacias.Text = "Limpiar";
            this.btnLimpiarFarmacias.TextColor = System.Drawing.Color.Black;
            this.btnLimpiarFarmacias.UseVisualStyleBackColor = false;
            this.btnLimpiarFarmacias.Click += new System.EventHandler(this.btnLimpiarFarmacias_Click);
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
            this.dgvFarmacias.Size = new System.Drawing.Size(1012, 211);
            this.dgvFarmacias.TabIndex = 11;
            this.dgvFarmacias.TabStop = false;
            this.dgvFarmacias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvFarmacias_KeyDown);
            // 
            // idFarmacia
            // 
            this.idFarmacia.HeaderText = "ID";
            this.idFarmacia.Name = "idFarmacia";
            this.idFarmacia.ReadOnly = true;
            this.idFarmacia.Visible = false;
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
            this.btnRegFarmacia.Location = new System.Drawing.Point(1085, 237);
            this.btnRegFarmacia.Name = "btnRegFarmacia";
            this.btnRegFarmacia.Size = new System.Drawing.Size(106, 56);
            this.btnRegFarmacia.TabIndex = 11;
            this.btnRegFarmacia.Text = "Registrar Farmacia";
            this.btnRegFarmacia.TextColor = System.Drawing.Color.Black;
            this.btnRegFarmacia.UseVisualStyleBackColor = false;
            this.btnRegFarmacia.Click += new System.EventHandler(this.btnRegFarmacia_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(729, 605);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 49);
            this.btnCancelar.TabIndex = 14;
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
            this.btnAceptar.Location = new System.Drawing.Point(1116, 603);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 49);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.Black;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmABMEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.Empleados;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1281, 664);
            this.Controls.Add(gbEmpleados);
            this.Controls.Add(this.gbFarmacias);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmABMEmpleados";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmABMEmpleados_Load);
            gbEmpleados.ResumeLayout(false);
            gbEmpleados.PerformLayout();
            this.gbFarmacias.ResumeLayout(false);
            this.gbFarmacias.PerformLayout();
            this.gbFiltrosFarm.ResumeLayout(false);
            this.gbFiltrosFarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmacias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.RJControls.RJButton btnCancelar;
        private CustomControls.RJControls.RJButton btnAceptar;
        private System.Windows.Forms.GroupBox gbFarmacias;
        private System.Windows.Forms.DataGridView dgvFarmacias;
        private CustomControls.RJControls.RJButton btnRegFarmacia;
        private System.Windows.Forms.GroupBox gbFiltrosFarm;
        private CustomControls.RJControls.RJButton btnLimpiarFarmacias;
        private System.Windows.Forms.TextBox txtbNroDoc;
        private CustomControls.RJControls.RJButton btnLimpiarEmpleado;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private CustomControls.RJControls.RJButton btnConsultarFarm;
        private CustomControls.RJControls.RJButton btnActualizar;
        private System.Windows.Forms.Label lblAvisoNroDoc;
        private System.Windows.Forms.TextBox txtbPasaporteNro;
        private System.Windows.Forms.TextBox txtbPasaporteLetras;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbLocalidad;
        private System.Windows.Forms.TextBox txtbNomFarm;
        private System.Windows.Forms.TextBox txtbNomCalle;
        private System.Windows.Forms.TextBox txtbBarrio;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblNomEmp;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblNomCalle;
        private System.Windows.Forms.Label lnlNomFarm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFarmacia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomFarmacia;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomLocalidad;
    }
}