
namespace FarmaTown.Presentacion.Reportes
{
    partial class frmListadoMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoMedicamentos));
            this.medicamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGeneral = new FarmaTown.DataSetGeneral();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.txtbCantMax = new System.Windows.Forms.TextBox();
            this.txtbCantMin = new System.Windows.Forms.TextBox();
            this.lblSMax = new System.Windows.Forms.Label();
            this.lblSMin = new System.Windows.Forms.Label();
            this.rpvMedicamentos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerar = new CustomControls.RJControls.RJButton();
            this.medicamentosTableAdapter = new FarmaTown.DataSetGeneralTableAdapters.MedicamentosTableAdapter();
            this.btnSalir = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // medicamentosBindingSource
            // 
            this.medicamentosBindingSource.DataMember = "Medicamentos";
            this.medicamentosBindingSource.DataSource = this.dataSetGeneral;
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
            this.label1.Location = new System.Drawing.Point(247, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 33);
            this.label1.TabIndex = 41;
            this.label1.Text = "Medicamentos";
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltros.Controls.Add(this.txtbCantMax);
            this.gbFiltros.Controls.Add(this.txtbCantMin);
            this.gbFiltros.Controls.Add(this.lblSMax);
            this.gbFiltros.Controls.Add(this.lblSMin);
            this.gbFiltros.Location = new System.Drawing.Point(12, 67);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(658, 94);
            this.gbFiltros.TabIndex = 42;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // txtbCantMax
            // 
            this.txtbCantMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbCantMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbCantMax.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.txtbCantMax.Location = new System.Drawing.Point(485, 41);
            this.txtbCantMax.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbCantMax.Name = "txtbCantMax";
            this.txtbCantMax.Size = new System.Drawing.Size(158, 25);
            this.txtbCantMax.TabIndex = 45;
            // 
            // txtbCantMin
            // 
            this.txtbCantMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbCantMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbCantMin.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.txtbCantMin.Location = new System.Drawing.Point(155, 41);
            this.txtbCantMin.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbCantMin.Name = "txtbCantMin";
            this.txtbCantMin.Size = new System.Drawing.Size(158, 25);
            this.txtbCantMin.TabIndex = 44;
            // 
            // lblSMax
            // 
            this.lblSMax.AutoSize = true;
            this.lblSMax.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblSMax.Location = new System.Drawing.Point(347, 47);
            this.lblSMax.Name = "lblSMax";
            this.lblSMax.Size = new System.Drawing.Size(122, 19);
            this.lblSMax.TabIndex = 43;
            this.lblSMax.Text = "Stock Máximo:";
            // 
            // lblSMin
            // 
            this.lblSMin.AutoSize = true;
            this.lblSMin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblSMin.Location = new System.Drawing.Point(23, 47);
            this.lblSMin.Name = "lblSMin";
            this.lblSMin.Size = new System.Drawing.Size(116, 19);
            this.lblSMin.TabIndex = 42;
            this.lblSMin.Text = "Stock Mínimo:";
            // 
            // rpvMedicamentos
            // 
            reportDataSource1.Name = "DSMedicamentos";
            reportDataSource1.Value = this.medicamentosBindingSource;
            this.rpvMedicamentos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvMedicamentos.LocalReport.ReportEmbeddedResource = "FarmaTown.Presentacion.Reportes.rptMedicamentos.rdlc";
            this.rpvMedicamentos.Location = new System.Drawing.Point(39, 215);
            this.rpvMedicamentos.Name = "rpvMedicamentos";
            this.rpvMedicamentos.ServerReport.BearerToken = null;
            this.rpvMedicamentos.Size = new System.Drawing.Size(606, 246);
            this.rpvMedicamentos.TabIndex = 43;
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
            this.btnGenerar.Location = new System.Drawing.Point(291, 167);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(123, 42);
            this.btnGenerar.TabIndex = 44;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextColor = System.Drawing.Color.Black;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // medicamentosTableAdapter
            // 
            this.medicamentosTableAdapter.ClearBeforeFill = true;
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
            this.btnSalir.Location = new System.Drawing.Point(664, 412);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 49);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmListadoMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.listado_medicamentos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(742, 474);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.rpvMedicamentos);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmListadoMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Medicamentos - FarmaTown";
            this.Load += new System.EventHandler(this.frmListadoMedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lblSMax;
        private System.Windows.Forms.Label lblSMin;
        private Microsoft.Reporting.WinForms.ReportViewer rpvMedicamentos;
        private CustomControls.RJControls.RJButton btnGenerar;
        private System.Windows.Forms.TextBox txtbCantMax;
        private System.Windows.Forms.TextBox txtbCantMin;
        private DataSetGeneral dataSetGeneral;
        private System.Windows.Forms.BindingSource medicamentosBindingSource;
        private DataSetGeneralTableAdapters.MedicamentosTableAdapter medicamentosTableAdapter;
        private CustomControls.RJControls.RJButton btnSalir;
    }
}