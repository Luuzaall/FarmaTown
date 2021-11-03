
namespace FarmaTown.Presentacion.Reportes
{
    partial class frmReporteVentasxFarmacia
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.farmaciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGeneral = new FarmaTown.DataSetGeneral();
            this.btnConsultar = new CustomControls.RJControls.RJButton();
            this.rpvVentaxFarmacia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.fechaHastaPicker = new System.Windows.Forms.DateTimePicker();
            this.fechaDesdePicker = new System.Windows.Forms.DateTimePicker();
            this.lblFFinal = new System.Windows.Forms.Label();
            this.lblFInicial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.farmaciasTableAdapter = new FarmaTown.DataSetGeneralTableAdapters.FarmaciasTableAdapter();
            this.btnSalir = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // farmaciasBindingSource
            // 
            this.farmaciasBindingSource.DataMember = "Farmacias";
            this.farmaciasBindingSource.DataSource = this.dataSetGeneral;
            // 
            // dataSetGeneral
            // 
            this.dataSetGeneral.DataSetName = "DataSetGeneral";
            this.dataSetGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnConsultar.Location = new System.Drawing.Point(351, 199);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(123, 42);
            this.btnConsultar.TabIndex = 56;
            this.btnConsultar.Text = "Generar";
            this.btnConsultar.TextColor = System.Drawing.Color.Black;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.reportViewer1_Load);
            // 
            // rpvVentaxFarmacia
            // 
            reportDataSource2.Name = "Farmacia";
            reportDataSource2.Value = this.farmaciasBindingSource;
            this.rpvVentaxFarmacia.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvVentaxFarmacia.LocalReport.ReportEmbeddedResource = "FarmaTown.Presentacion.Reportes.Report1.rdlc";
            this.rpvVentaxFarmacia.Location = new System.Drawing.Point(21, 266);
            this.rpvVentaxFarmacia.Name = "rpvVentaxFarmacia";
            this.rpvVentaxFarmacia.ServerReport.BearerToken = null;
            this.rpvVentaxFarmacia.Size = new System.Drawing.Size(802, 321);
            this.rpvVentaxFarmacia.TabIndex = 55;
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltros.Controls.Add(this.fechaHastaPicker);
            this.gbFiltros.Controls.Add(this.fechaDesdePicker);
            this.gbFiltros.Controls.Add(this.lblFFinal);
            this.gbFiltros.Controls.Add(this.lblFInicial);
            this.gbFiltros.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbFiltros.Location = new System.Drawing.Point(21, 83);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(802, 96);
            this.gbFiltros.TabIndex = 54;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // fechaHastaPicker
            // 
            this.fechaHastaPicker.Location = new System.Drawing.Point(559, 36);
            this.fechaHastaPicker.Name = "fechaHastaPicker";
            this.fechaHastaPicker.Size = new System.Drawing.Size(200, 27);
            this.fechaHastaPicker.TabIndex = 45;
            // 
            // fechaDesdePicker
            // 
            this.fechaDesdePicker.Location = new System.Drawing.Point(148, 36);
            this.fechaDesdePicker.Name = "fechaDesdePicker";
            this.fechaDesdePicker.Size = new System.Drawing.Size(200, 27);
            this.fechaDesdePicker.TabIndex = 44;
            // 
            // lblFFinal
            // 
            this.lblFFinal.AutoSize = true;
            this.lblFFinal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblFFinal.Location = new System.Drawing.Point(431, 40);
            this.lblFFinal.Name = "lblFFinal";
            this.lblFFinal.Size = new System.Drawing.Size(113, 19);
            this.lblFFinal.TabIndex = 43;
            this.lblFFinal.Text = "Fecha Hasta: ";
            // 
            // lblFInicial
            // 
            this.lblFInicial.AutoSize = true;
            this.lblFInicial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblFInicial.Location = new System.Drawing.Point(24, 40);
            this.lblFInicial.Name = "lblFInicial";
            this.lblFInicial.Size = new System.Drawing.Size(118, 19);
            this.lblFInicial.TabIndex = 42;
            this.lblFInicial.Text = "Fecha Desde: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(209)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 33);
            this.label1.TabIndex = 53;
            this.label1.Text = "Ventas por Farmacia";
            // 
            // farmaciasTableAdapter
            // 
            this.farmaciasTableAdapter.ClearBeforeFill = true;
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
            this.btnSalir.Location = new System.Drawing.Point(847, 538);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 49);
            this.btnSalir.TabIndex = 57;
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmReporteVentasxFarmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 599);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.rpvVentaxFarmacia);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.label1);
            this.Name = "frmReporteVentasxFarmacia";
            this.Text = "frmReporteVentasxFarmacia";
            this.Load += new System.EventHandler(this.frmReporteVentasxFarmacia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.farmaciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton btnConsultar;
        private Microsoft.Reporting.WinForms.ReportViewer rpvVentaxFarmacia;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.DateTimePicker fechaHastaPicker;
        private System.Windows.Forms.DateTimePicker fechaDesdePicker;
        private System.Windows.Forms.Label lblFFinal;
        private System.Windows.Forms.Label lblFInicial;
        private System.Windows.Forms.Label label1;
        private DataSetGeneral dataSetGeneral;
        private System.Windows.Forms.BindingSource farmaciasBindingSource;
        private DataSetGeneralTableAdapters.FarmaciasTableAdapter farmaciasTableAdapter;
        private CustomControls.RJControls.RJButton btnSalir;
    }
}