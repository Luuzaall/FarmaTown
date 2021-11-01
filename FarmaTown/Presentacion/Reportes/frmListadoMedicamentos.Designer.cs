
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoMedicamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.lblPMin = new System.Windows.Forms.Label();
            this.lblPMax = new System.Windows.Forms.Label();
            this.rpvMedicamentos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
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
            this.gbFiltros.Controls.Add(this.lblPMax);
            this.gbFiltros.Controls.Add(this.lblPMin);
            this.gbFiltros.Location = new System.Drawing.Point(12, 67);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(798, 188);
            this.gbFiltros.TabIndex = 42;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // lblPMin
            // 
            this.lblPMin.AutoSize = true;
            this.lblPMin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblPMin.Location = new System.Drawing.Point(25, 64);
            this.lblPMin.Name = "lblPMin";
            this.lblPMin.Size = new System.Drawing.Size(123, 19);
            this.lblPMin.TabIndex = 42;
            this.lblPMin.Text = "Precio Mínimo:";
            // 
            // lblPMax
            // 
            this.lblPMax.AutoSize = true;
            this.lblPMax.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblPMax.Location = new System.Drawing.Point(378, 64);
            this.lblPMax.Name = "lblPMax";
            this.lblPMax.Size = new System.Drawing.Size(129, 19);
            this.lblPMax.TabIndex = 43;
            this.lblPMax.Text = "Precio Máximo:";
            // 
            // rpvMedicamentos
            // 
            this.rpvMedicamentos.Location = new System.Drawing.Point(12, 278);
            this.rpvMedicamentos.Name = "rpvMedicamentos";
            this.rpvMedicamentos.ServerReport.BearerToken = null;
            this.rpvMedicamentos.Size = new System.Drawing.Size(690, 246);
            this.rpvMedicamentos.TabIndex = 43;
            // 
            // frmListadoMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.listado_medicamentos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(849, 549);
            this.Controls.Add(this.rpvMedicamentos);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmListadoMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Medicamentos - FarmaTown";
            this.Load += new System.EventHandler(this.frmListadoMedicamentos_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lblPMax;
        private System.Windows.Forms.Label lblPMin;
        private Microsoft.Reporting.WinForms.ReportViewer rpvMedicamentos;
    }
}