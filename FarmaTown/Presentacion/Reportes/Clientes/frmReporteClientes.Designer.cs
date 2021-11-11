
namespace FarmaTown.Presentacion.Reportes.Clientes
{
    partial class frmReporteClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteClientes));
            this.dtClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTSClientes = new FarmaTown.Datos.Reportes.DTSClientes();
            this.rpvClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLocalidades = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cboBarrios = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new CustomControls.RJControls.RJButton();
            this.btnGenerar = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTSClientes)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtClientesBindingSource
            // 
            this.dtClientesBindingSource.DataMember = "dtClientes";
            this.dtClientesBindingSource.DataSource = this.DTSClientes;
            // 
            // DTSClientes
            // 
            this.DTSClientes.DataSetName = "DTSClientes";
            this.DTSClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvClientes
            // 
            reportDataSource1.Name = "DSClientes";
            reportDataSource1.Value = this.dtClientesBindingSource;
            this.rpvClientes.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvClientes.LocalReport.ReportEmbeddedResource = "FarmaTown.Presentacion.Reportes.Clientes.rptClientes.rdlc";
            this.rpvClientes.Location = new System.Drawing.Point(24, 263);
            this.rpvClientes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rpvClientes.Name = "rpvClientes";
            this.rpvClientes.ServerReport.BearerToken = null;
            this.rpvClientes.Size = new System.Drawing.Size(776, 371);
            this.rpvClientes.TabIndex = 0;
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.cboLocalidades);
            this.gbFiltros.Controls.Add(this.lblLocalidad);
            this.gbFiltros.Controls.Add(this.cboBarrios);
            this.gbFiltros.Controls.Add(this.lblBarrio);
            this.gbFiltros.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.gbFiltros.Location = new System.Drawing.Point(24, 70);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gbFiltros.Size = new System.Drawing.Size(776, 116);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(568, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Sólo se muestran los barrios y localidades que tienen al menos un cliente";
            // 
            // cboLocalidades
            // 
            this.cboLocalidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.cboLocalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLocalidades.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.cboLocalidades.FormattingEnabled = true;
            this.cboLocalidades.Location = new System.Drawing.Point(509, 66);
            this.cboLocalidades.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboLocalidades.Name = "cboLocalidades";
            this.cboLocalidades.Size = new System.Drawing.Size(211, 27);
            this.cboLocalidades.TabIndex = 51;
            this.cboLocalidades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbosEnter_KeyDown);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblLocalidad.Location = new System.Drawing.Point(403, 69);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(92, 19);
            this.lblLocalidad.TabIndex = 50;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // cboBarrios
            // 
            this.cboBarrios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.cboBarrios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBarrios.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.cboBarrios.FormattingEnabled = true;
            this.cboBarrios.Location = new System.Drawing.Point(123, 66);
            this.cboBarrios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboBarrios.Name = "cboBarrios";
            this.cboBarrios.Size = new System.Drawing.Size(211, 27);
            this.cboBarrios.TabIndex = 49;
            this.cboBarrios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbosEnter_KeyDown);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblBarrio.Location = new System.Drawing.Point(58, 69);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(57, 19);
            this.lblBarrio.TabIndex = 48;
            this.lblBarrio.Text = "Barrio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(209)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 33);
            this.label1.TabIndex = 41;
            this.label1.Text = "Reporte Clientes";
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
            this.btnLimpiar.Location = new System.Drawing.Point(267, 203);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(123, 42);
            this.btnLimpiar.TabIndex = 43;
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
            this.btnGenerar.Location = new System.Drawing.Point(464, 203);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(123, 42);
            this.btnGenerar.TabIndex = 42;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextColor = System.Drawing.Color.Black;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.reporteClientes;
            this.ClientSize = new System.Drawing.Size(839, 648);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.rpvClientes);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmReporteClientes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Clientes - FarmaTown";
            this.Load += new System.EventHandler(this.frmReporteClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTSClientes)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvClientes;
        private System.Windows.Forms.BindingSource dtClientesBindingSource;
        private Datos.Reportes.DTSClientes DTSClientes;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLocalidades;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cboBarrios;
        private System.Windows.Forms.Label lblBarrio;
        private CustomControls.RJControls.RJButton btnLimpiar;
        private CustomControls.RJControls.RJButton btnGenerar;
        private System.Windows.Forms.Label label2;
    }
}