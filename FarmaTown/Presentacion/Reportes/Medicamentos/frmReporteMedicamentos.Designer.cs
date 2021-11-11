
namespace FarmaTown.Presentacion.Reportes.Medicamentos
{
    partial class frmReporteMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteMedicamentos));
            this.dSMedicamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMedicamentos = new FarmaTown.Datos.Reportes.DSMedicamentos();
            this.rpvMedicamentos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.txtbCantMax = new System.Windows.Forms.TextBox();
            this.txtbCantMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.btnLimpiar = new CustomControls.RJControls.RJButton();
            this.btnGenerar = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dSMedicamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMedicamentos)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSMedicamentosBindingSource
            // 
            this.dSMedicamentosBindingSource.DataSource = this.dSMedicamentos;
            this.dSMedicamentosBindingSource.Position = 0;
            // 
            // dSMedicamentos
            // 
            this.dSMedicamentos.DataSetName = "DSMedicamentos";
            this.dSMedicamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvMedicamentos
            // 
            reportDataSource1.Name = "DSMedicamentos";
            reportDataSource1.Value = this.dSMedicamentosBindingSource;
            this.rpvMedicamentos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvMedicamentos.LocalReport.ReportEmbeddedResource = "FarmaTown.Presentacion.Reportes.Medicamentos.rptMedicamentos.rdlc";
            this.rpvMedicamentos.Location = new System.Drawing.Point(15, 220);
            this.rpvMedicamentos.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rpvMedicamentos.Name = "rpvMedicamentos";
            this.rpvMedicamentos.ServerReport.BearerToken = null;
            this.rpvMedicamentos.Size = new System.Drawing.Size(807, 424);
            this.rpvMedicamentos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(209)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 33);
            this.label1.TabIndex = 44;
            this.label1.Text = "Reporte Medicamentos";
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltros.Controls.Add(this.txtbCantMax);
            this.gbFiltros.Controls.Add(this.txtbCantMin);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.lblBarrio);
            this.gbFiltros.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.gbFiltros.Location = new System.Drawing.Point(15, 55);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gbFiltros.Size = new System.Drawing.Size(807, 101);
            this.gbFiltros.TabIndex = 48;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // txtbCantMax
            // 
            this.txtbCantMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbCantMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbCantMax.Location = new System.Drawing.Point(606, 42);
            this.txtbCantMax.Margin = new System.Windows.Forms.Padding(12, 5, 6, 5);
            this.txtbCantMax.Name = "txtbCantMax";
            this.txtbCantMax.Size = new System.Drawing.Size(142, 25);
            this.txtbCantMax.TabIndex = 2;
            this.txtbCantMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbStocks_KeyDown);
            // 
            // txtbCantMin
            // 
            this.txtbCantMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbCantMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbCantMin.Location = new System.Drawing.Point(175, 42);
            this.txtbCantMin.Margin = new System.Windows.Forms.Padding(12, 5, 6, 5);
            this.txtbCantMin.Name = "txtbCantMin";
            this.txtbCantMin.Size = new System.Drawing.Size(171, 25);
            this.txtbCantMin.TabIndex = 1;
            this.txtbCantMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbStocks_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Stock Mínimo";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.BackColor = System.Drawing.Color.White;
            this.lblBarrio.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblBarrio.Location = new System.Drawing.Point(434, 42);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(147, 23);
            this.lblBarrio.TabIndex = 48;
            this.lblBarrio.Text = "Stock Máximo:";
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
            this.btnLimpiar.Location = new System.Drawing.Point(267, 164);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 37);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.Black;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnGenerar.Location = new System.Drawing.Point(456, 164);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(114, 37);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextColor = System.Drawing.Color.Black;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmReporteMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.MedicalResearch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(835, 658);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpvMedicamentos);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmReporteMedicamentos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Medicamentos - FarmaTown";
            this.Load += new System.EventHandler(this.frmReporteMedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSMedicamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMedicamentos)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvMedicamentos;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btnLimpiar;
        private CustomControls.RJControls.RJButton btnGenerar;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.TextBox txtbCantMax;
        private System.Windows.Forms.TextBox txtbCantMin;
        private System.Windows.Forms.BindingSource dSMedicamentosBindingSource;
        private Datos.Reportes.DSMedicamentos dSMedicamentos;
    }
}