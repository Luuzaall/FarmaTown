
namespace FarmaTown.Presentacion.Reportes
{
    partial class frmListadoVentas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoVentas));
            this.dtVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTSVentas = new FarmaTown.Presentacion.Reportes.DTSVentas();
            this.rpvVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cboLocalidades = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cboFarmacias = new System.Windows.Forms.ComboBox();
            this.lblFarmacia = new System.Windows.Forms.Label();
            this.lblFH = new System.Windows.Forms.Label();
            this.lblFD = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar = new CustomControls.RJControls.RJButton();
            this.btnLimpiar = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTSVentas)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtVentasBindingSource
            // 
            this.dtVentasBindingSource.DataMember = "dtVentas";
            this.dtVentasBindingSource.DataSource = this.DTSVentas;
            // 
            // DTSVentas
            // 
            this.DTSVentas.DataSetName = "DTSVentas";
            this.DTSVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvVentas
            // 
            reportDataSource1.Name = "DSVentas";
            reportDataSource1.Value = this.dtVentasBindingSource;
            this.rpvVentas.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvVentas.LocalReport.ReportEmbeddedResource = "FarmaTown.Presentacion.Reportes.rptVentas.rdlc";
            this.rpvVentas.Location = new System.Drawing.Point(15, 312);
            this.rpvVentas.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rpvVentas.Name = "rpvVentas";
            this.rpvVentas.ServerReport.BearerToken = null;
            this.rpvVentas.Size = new System.Drawing.Size(1242, 282);
            this.rpvVentas.TabIndex = 0;
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltros.Controls.Add(this.cboLocalidades);
            this.gbFiltros.Controls.Add(this.lblLocalidad);
            this.gbFiltros.Controls.Add(this.cboFarmacias);
            this.gbFiltros.Controls.Add(this.lblFarmacia);
            this.gbFiltros.Controls.Add(this.lblFH);
            this.gbFiltros.Controls.Add(this.lblFD);
            this.gbFiltros.Controls.Add(this.dtpFechaHasta);
            this.gbFiltros.Controls.Add(this.dtpFechaDesde);
            this.gbFiltros.Location = new System.Drawing.Point(15, 55);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1245, 188);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // cboLocalidades
            // 
            this.cboLocalidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.cboLocalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLocalidades.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.cboLocalidades.FormattingEnabled = true;
            this.cboLocalidades.Location = new System.Drawing.Point(800, 119);
            this.cboLocalidades.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboLocalidades.Name = "cboLocalidades";
            this.cboLocalidades.Size = new System.Drawing.Size(211, 27);
            this.cboLocalidades.TabIndex = 47;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblLocalidad.Location = new System.Drawing.Point(694, 122);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(92, 19);
            this.lblLocalidad.TabIndex = 46;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // cboFarmacias
            // 
            this.cboFarmacias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.cboFarmacias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFarmacias.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.cboFarmacias.FormattingEnabled = true;
            this.cboFarmacias.Location = new System.Drawing.Point(304, 120);
            this.cboFarmacias.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboFarmacias.Name = "cboFarmacias";
            this.cboFarmacias.Size = new System.Drawing.Size(211, 27);
            this.cboFarmacias.TabIndex = 45;
            // 
            // lblFarmacia
            // 
            this.lblFarmacia.AutoSize = true;
            this.lblFarmacia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblFarmacia.Location = new System.Drawing.Point(199, 128);
            this.lblFarmacia.Name = "lblFarmacia";
            this.lblFarmacia.Size = new System.Drawing.Size(89, 19);
            this.lblFarmacia.TabIndex = 44;
            this.lblFarmacia.Text = "Farmacia:";
            // 
            // lblFH
            // 
            this.lblFH.AutoSize = true;
            this.lblFH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblFH.Location = new System.Drawing.Point(674, 65);
            this.lblFH.Name = "lblFH";
            this.lblFH.Size = new System.Drawing.Size(109, 19);
            this.lblFH.TabIndex = 43;
            this.lblFH.Text = "Fecha Hasta:";
            // 
            // lblFD
            // 
            this.lblFD.AutoSize = true;
            this.lblFD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblFD.Location = new System.Drawing.Point(174, 70);
            this.lblFD.Name = "lblFD";
            this.lblFD.Size = new System.Drawing.Size(114, 19);
            this.lblFD.TabIndex = 42;
            this.lblFD.Text = "Fecha Desde:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(209)))));
            this.dtpFechaHasta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFechaHasta.Location = new System.Drawing.Point(800, 58);
            this.dtpFechaHasta.MaxDate = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            this.dtpFechaHasta.MinDate = new System.DateTime(2021, 6, 16, 0, 0, 0, 0);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(211, 27);
            this.dtpFechaHasta.TabIndex = 41;
            this.dtpFechaHasta.Value = new System.DateTime(2021, 10, 26, 17, 20, 9, 0);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(209)))));
            this.dtpFechaDesde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFechaDesde.Location = new System.Drawing.Point(304, 65);
            this.dtpFechaDesde.MaxDate = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            this.dtpFechaDesde.MinDate = new System.DateTime(2021, 6, 16, 0, 0, 0, 0);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(211, 27);
            this.dtpFechaDesde.TabIndex = 40;
            this.dtpFechaDesde.Value = new System.DateTime(2021, 10, 19, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(209)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 33);
            this.label1.TabIndex = 40;
            this.label1.Text = "Reporte Ventas";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnGenerar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerar.BorderColor = System.Drawing.Color.Green;
            this.btnGenerar.BorderRadius = 20;
            this.btnGenerar.BorderSize = 1;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.Black;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGenerar.Location = new System.Drawing.Point(672, 262);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(123, 42);
            this.btnGenerar.TabIndex = 39;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextColor = System.Drawing.Color.Black;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
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
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiar.Location = new System.Drawing.Point(475, 262);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(123, 42);
            this.btnLimpiar.TabIndex = 41;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.Black;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.reporteClientes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1272, 608);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.rpvVentas);
            this.Controls.Add(this.btnGenerar);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmListadoVentas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Ventas - FarmaTown";
            this.Load += new System.EventHandler(this.frmListadoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTSVentas)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvVentas;
        private System.Windows.Forms.BindingSource dtVentasBindingSource;
        private DTSVentas DTSVentas;
        private System.Windows.Forms.GroupBox gbFiltros;
        private CustomControls.RJControls.RJButton btnGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFH;
        private System.Windows.Forms.Label lblFD;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFarmacia;
        private System.Windows.Forms.ComboBox cboFarmacias;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cboLocalidades;
        private CustomControls.RJControls.RJButton btnLimpiar;
    }
}