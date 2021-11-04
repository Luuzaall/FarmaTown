
namespace FarmaTown.Presentacion.Reportes
{
    partial class frmReporteTMedicamentosxVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteTMedicamentosxVenta));
            this.TiposDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGeneral = new FarmaTown.DataSetGeneral();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cboLocalidades = new System.Windows.Forms.ComboBox();
            this.fechaHastaPicker = new System.Windows.Forms.DateTimePicker();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.fechaDesdePicker = new System.Windows.Forms.DateTimePicker();
            this.cboFarmacias = new System.Windows.Forms.ComboBox();
            this.lblFarmacia = new System.Windows.Forms.Label();
            this.lblFFinal = new System.Windows.Forms.Label();
            this.lblFInicial = new System.Windows.Forms.Label();
            this.rpvMedicamentosxVenta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MedicamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposMedicamentoTableAdapter = new FarmaTown.DataSetGeneralTableAdapters.TiposMedicamentoTableAdapter();
            this.TiposMedicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTSVentas = new FarmaTown.Datos.Reportes.DSVentas();
            this.btnConsultar = new CustomControls.RJControls.RJButton();
            this.btnSalir = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.TiposDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).BeginInit();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiposMedicamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTSVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // TiposDocumentoBindingSource
            // 
            this.TiposDocumentoBindingSource.DataMember = "TiposDocumento";
            this.TiposDocumentoBindingSource.DataSource = this.dataSetGeneral;
            // 
            // dataSetGeneral
            // 
            this.dataSetGeneral.DataSetName = "DataSetGeneral";
            this.dataSetGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(209)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 33);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tipos de Medicamentos";
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltros.Controls.Add(this.cboLocalidades);
            this.gbFiltros.Controls.Add(this.fechaHastaPicker);
            this.gbFiltros.Controls.Add(this.lblLocalidad);
            this.gbFiltros.Controls.Add(this.fechaDesdePicker);
            this.gbFiltros.Controls.Add(this.cboFarmacias);
            this.gbFiltros.Controls.Add(this.lblFarmacia);
            this.gbFiltros.Controls.Add(this.lblFFinal);
            this.gbFiltros.Controls.Add(this.lblFInicial);
            this.gbFiltros.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbFiltros.Location = new System.Drawing.Point(29, 88);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(774, 127);
            this.gbFiltros.TabIndex = 43;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // cboLocalidades
            // 
            this.cboLocalidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.cboLocalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLocalidades.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.cboLocalidades.FormattingEnabled = true;
            this.cboLocalidades.Location = new System.Drawing.Point(519, 82);
            this.cboLocalidades.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboLocalidades.Name = "cboLocalidades";
            this.cboLocalidades.Size = new System.Drawing.Size(200, 27);
            this.cboLocalidades.TabIndex = 51;
            // 
            // fechaHastaPicker
            // 
            this.fechaHastaPicker.Location = new System.Drawing.Point(519, 32);
            this.fechaHastaPicker.Name = "fechaHastaPicker";
            this.fechaHastaPicker.Size = new System.Drawing.Size(200, 27);
            this.fechaHastaPicker.TabIndex = 45;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblLocalidad.Location = new System.Drawing.Point(419, 85);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(92, 19);
            this.lblLocalidad.TabIndex = 50;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // fechaDesdePicker
            // 
            this.fechaDesdePicker.Location = new System.Drawing.Point(147, 28);
            this.fechaDesdePicker.Name = "fechaDesdePicker";
            this.fechaDesdePicker.Size = new System.Drawing.Size(200, 27);
            this.fechaDesdePicker.TabIndex = 44;
            // 
            // cboFarmacias
            // 
            this.cboFarmacias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.cboFarmacias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFarmacias.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.cboFarmacias.FormattingEnabled = true;
            this.cboFarmacias.Location = new System.Drawing.Point(147, 79);
            this.cboFarmacias.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboFarmacias.Name = "cboFarmacias";
            this.cboFarmacias.Size = new System.Drawing.Size(200, 27);
            this.cboFarmacias.TabIndex = 49;
            // 
            // lblFarmacia
            // 
            this.lblFarmacia.AutoSize = true;
            this.lblFarmacia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblFarmacia.Location = new System.Drawing.Point(50, 84);
            this.lblFarmacia.Name = "lblFarmacia";
            this.lblFarmacia.Size = new System.Drawing.Size(89, 19);
            this.lblFarmacia.TabIndex = 48;
            this.lblFarmacia.Text = "Farmacia:";
            // 
            // lblFFinal
            // 
            this.lblFFinal.AutoSize = true;
            this.lblFFinal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblFFinal.Location = new System.Drawing.Point(404, 34);
            this.lblFFinal.Name = "lblFFinal";
            this.lblFFinal.Size = new System.Drawing.Size(113, 19);
            this.lblFFinal.TabIndex = 43;
            this.lblFFinal.Text = "Fecha Hasta: ";
            // 
            // lblFInicial
            // 
            this.lblFInicial.AutoSize = true;
            this.lblFInicial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblFInicial.Location = new System.Drawing.Point(24, 34);
            this.lblFInicial.Name = "lblFInicial";
            this.lblFInicial.Size = new System.Drawing.Size(118, 19);
            this.lblFInicial.TabIndex = 42;
            this.lblFInicial.Text = "Fecha Desde: ";
            // 
            // rpvMedicamentosxVenta
            // 
            this.rpvMedicamentosxVenta.LocalReport.ReportEmbeddedResource = "FarmaTown.Presentacion.Reportes.rptTMedicamentos.rdlc";
            this.rpvMedicamentosxVenta.Location = new System.Drawing.Point(29, 290);
            this.rpvMedicamentosxVenta.Name = "rpvMedicamentosxVenta";
            this.rpvMedicamentosxVenta.ServerReport.BearerToken = null;
            this.rpvMedicamentosxVenta.Size = new System.Drawing.Size(774, 294);
            this.rpvMedicamentosxVenta.TabIndex = 44;
            // 
            // MedicamentosBindingSource
            // 
            this.MedicamentosBindingSource.DataMember = "TiposMedicamento";
            this.MedicamentosBindingSource.DataSource = this.dataSetGeneral;
            // 
            // dtVentasBindingSource
            // 
            this.dtVentasBindingSource.DataSource = this.dataSetGeneral;
            this.dtVentasBindingSource.Position = 0;
            // 
            // tiposMedicamentoTableAdapter
            // 
            this.tiposMedicamentoTableAdapter.ClearBeforeFill = true;
            // 
            // TiposMedicamentoBindingSource
            // 
            this.TiposMedicamentoBindingSource.DataMember = "TiposMedicamento";
            this.TiposMedicamentoBindingSource.DataSource = this.dataSetGeneral;
            // 
            // DTSVentas
            // 
            this.DTSVentas.DataSetName = "DTSVentas";
            this.DTSVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnConsultar.Location = new System.Drawing.Point(344, 231);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(123, 42);
            this.btnConsultar.TabIndex = 52;
            this.btnConsultar.Text = "Generar";
            this.btnConsultar.TextColor = System.Drawing.Color.Black;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.reportViewer1_Load);
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
            this.btnSalir.Location = new System.Drawing.Point(820, 535);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 49);
            this.btnSalir.TabIndex = 53;
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmReporteTMedicamentosxVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 596);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.rpvMedicamentosxVenta);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteTMedicamentosxVenta";
            this.Text = "Farmatown - Reporte de Tipos Medicamentos";
            this.Load += new System.EventHandler(this.frmReporteTMedicamentosxVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TiposDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiposMedicamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTSVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lblFFinal;
        private System.Windows.Forms.Label lblFInicial;
        private System.Windows.Forms.DateTimePicker fechaHastaPicker;
        private System.Windows.Forms.DateTimePicker fechaDesdePicker;
        private System.Windows.Forms.ComboBox cboLocalidades;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cboFarmacias;
        private System.Windows.Forms.Label lblFarmacia;
        private CustomControls.RJControls.RJButton btnConsultar;
        private Microsoft.Reporting.WinForms.ReportViewer rpvMedicamentosxVenta;
        private System.Windows.Forms.BindingSource MedicamentosBindingSource;
        private DataSetGeneral dataSetGeneral;
        private System.Windows.Forms.BindingSource dtVentasBindingSource;
        private DataSetGeneralTableAdapters.TiposMedicamentoTableAdapter tiposMedicamentoTableAdapter;
        private System.Windows.Forms.BindingSource TiposMedicamentoBindingSource;
        private Datos.Reportes.DSVentas DTSVentas;
        private System.Windows.Forms.BindingSource TiposDocumentoBindingSource;
        private CustomControls.RJControls.RJButton btnSalir;
    }
}