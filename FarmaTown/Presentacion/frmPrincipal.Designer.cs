namespace FarmaTown.Presentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.obrasSocialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farmaciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNomRol = new System.Windows.Forms.Label();
            this.lblReloj = new System.Windows.Forms.Label();
            this.reportePorTipoDeMedicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFarmaciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F);
            this.msPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 5, 0, 2);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.gestiónToolStripMenuItem,
            this.ventasToolStripMenuItem1,
            this.reportesToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msPrincipal.Size = new System.Drawing.Size(1095, 28);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalToolStripMenuItem,
            this.obrasSocialesToolStripMenuItem,
            this.farmaciasToolStripMenuItem,
            this.ubicaciónToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.gestiónToolStripMenuItem.Text = "Gestión";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem1,
            this.tiposDocumentoToolStripMenuItem,
            this.usuariosToolStripMenuItem1});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(197, 24);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // tiposDocumentoToolStripMenuItem
            // 
            this.tiposDocumentoToolStripMenuItem.Name = "tiposDocumentoToolStripMenuItem";
            this.tiposDocumentoToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.tiposDocumentoToolStripMenuItem.Text = "Tipos Documento";
            this.tiposDocumentoToolStripMenuItem.Click += new System.EventHandler(this.tiposDocumentoToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(197, 24);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            this.usuariosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // obrasSocialesToolStripMenuItem
            // 
            this.obrasSocialesToolStripMenuItem.Name = "obrasSocialesToolStripMenuItem";
            this.obrasSocialesToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.obrasSocialesToolStripMenuItem.Text = "Obras Sociales";
            this.obrasSocialesToolStripMenuItem.Click += new System.EventHandler(this.obrasSocialesToolStripMenuItem_Click);
            // 
            // farmaciasToolStripMenuItem
            // 
            this.farmaciasToolStripMenuItem.Name = "farmaciasToolStripMenuItem";
            this.farmaciasToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.farmaciasToolStripMenuItem.Text = "Farmacias";
            this.farmaciasToolStripMenuItem.Click += new System.EventHandler(this.farmaciasToolStripMenuItem_Click);
            // 
            // ubicaciónToolStripMenuItem
            // 
            this.ubicaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localidadesToolStripMenuItem,
            this.barriosToolStripMenuItem});
            this.ubicaciónToolStripMenuItem.Name = "ubicaciónToolStripMenuItem";
            this.ubicaciónToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.ubicaciónToolStripMenuItem.Text = "Ubicación";
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            this.localidadesToolStripMenuItem.Click += new System.EventHandler(this.localidadesToolStripMenuItem_Click);
            // 
            // barriosToolStripMenuItem
            // 
            this.barriosToolStripMenuItem.Name = "barriosToolStripMenuItem";
            this.barriosToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.barriosToolStripMenuItem.Text = "Barrios";
            this.barriosToolStripMenuItem.Click += new System.EventHandler(this.barriosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(67, 24);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            this.ventasToolStripMenuItem1.Click += new System.EventHandler(this.ventasToolStripMenuItem1_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem2,
            this.medicamentosToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem2
            // 
            this.ventasToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem,
            this.reportePorTipoDeMedicamentoToolStripMenuItem,
            this.porFarmaciaToolStripMenuItem});
            this.ventasToolStripMenuItem2.Name = "ventasToolStripMenuItem2";
            this.ventasToolStripMenuItem2.Size = new System.Drawing.Size(180, 24);
            this.ventasToolStripMenuItem2.Text = "Ventas";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.listadoToolStripMenuItem.Text = "Listado";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // medicamentosToolStripMenuItem
            // 
            this.medicamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem1});
            this.medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            this.medicamentosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.medicamentosToolStripMenuItem.Text = "Medicamentos";
            // 
            // listadoToolStripMenuItem1
            // 
            this.listadoToolStripMenuItem1.Name = "listadoToolStripMenuItem1";
            this.listadoToolStripMenuItem1.Size = new System.Drawing.Size(125, 24);
            this.listadoToolStripMenuItem1.Text = "Listado";
            this.listadoToolStripMenuItem1.Click += new System.EventHandler(this.listadoToolStripMenuItem1_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem2});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem2
            // 
            this.listadoToolStripMenuItem2.Name = "listadoToolStripMenuItem2";
            this.listadoToolStripMenuItem2.Size = new System.Drawing.Size(125, 24);
            this.listadoToolStripMenuItem2.Text = "Listado";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblUsuario.Location = new System.Drawing.Point(96, 124);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(171, 47);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblRol.Location = new System.Drawing.Point(189, 224);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(90, 47);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(279, 107);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 64);
            this.lblNombre.TabIndex = 3;
            // 
            // lblNomRol
            // 
            this.lblNomRol.AutoSize = true;
            this.lblNomRol.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNomRol.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lblNomRol.Location = new System.Drawing.Point(279, 224);
            this.lblNomRol.Name = "lblNomRol";
            this.lblNomRol.Size = new System.Drawing.Size(0, 47);
            this.lblNomRol.TabIndex = 4;
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.lblReloj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReloj.Font = new System.Drawing.Font("Century Gothic", 50F, System.Drawing.FontStyle.Bold);
            this.lblReloj.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblReloj.Location = new System.Drawing.Point(684, 157);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(2, 82);
            this.lblReloj.TabIndex = 5;
            this.lblReloj.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reportePorTipoDeMedicamentoToolStripMenuItem
            // 
            this.reportePorTipoDeMedicamentoToolStripMenuItem.Name = "reportePorTipoDeMedicamentoToolStripMenuItem";
            this.reportePorTipoDeMedicamentoToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.reportePorTipoDeMedicamentoToolStripMenuItem.Text = "Por Tipo de Medicamento";
            this.reportePorTipoDeMedicamentoToolStripMenuItem.Click += new System.EventHandler(this.reportePorTipoDeMedicamentoToolStripMenuItem_Click);
            // 
            // porFarmaciaToolStripMenuItem
            // 
            this.porFarmaciaToolStripMenuItem.Name = "porFarmaciaToolStripMenuItem";
            this.porFarmaciaToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.porFarmaciaToolStripMenuItem.Text = "Por Farmacia";
            this.porFarmaciaToolStripMenuItem.Click += new System.EventHandler(this.porFarmaciaToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1095, 600);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.lblNomRol);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.msPrincipal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msPrincipal;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal - FarmaTown";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNomRol;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrasSocialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farmaciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tiposDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ubicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reportePorTipoDeMedicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFarmaciaToolStripMenuItem;
    }
}