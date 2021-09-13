
namespace FarmaTown.Presentacion
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.txtbNombre = new JMaterialTextbox.JMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new CustomControls.RJControls.RJButton();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new CustomControls.RJControls.RJButton();
            this.btnEditar = new CustomControls.RJControls.RJButton();
            this.btnEliminar = new CustomControls.RJControls.RJButton();
            this.btnAgregar = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbResultados.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(30, 45);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(425, 150);
            this.dgvUsuarios.TabIndex = 13;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // gbResultados
            // 
            this.gbResultados.BackColor = System.Drawing.Color.Transparent;
            this.gbResultados.Controls.Add(this.dgvUsuarios);
            this.gbResultados.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.gbResultados.Location = new System.Drawing.Point(33, 246);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(478, 212);
            this.gbResultados.TabIndex = 20;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbFiltros.Controls.Add(this.txtbNombre);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.btnConsultar);
            this.gbFiltros.Controls.Add(this.cboRoles);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.gbFiltros.Location = new System.Drawing.Point(33, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(478, 228);
            this.gbFiltros.TabIndex = 21;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtbNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtbNombre.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtbNombre.ForeColors = System.Drawing.Color.Black;
            this.txtbNombre.HintText = null;
            this.txtbNombre.IsPassword = false;
            this.txtbNombre.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.txtbNombre.LineThickness = 2;
            this.txtbNombre.Location = new System.Drawing.Point(150, 55);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbNombre.MaxLength = 32767;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbNombre.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbNombre.ReadOnly = false;
            this.txtbNombre.Size = new System.Drawing.Size(244, 23);
            this.txtbNombre.TabIndex = 1;
            this.txtbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbNombre.TextName = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario:";
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
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnConsultar.Location = new System.Drawing.Point(191, 169);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(104, 37);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.Black;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboRoles
            // 
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Location = new System.Drawing.Point(150, 113);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(244, 31);
            this.cboRoles.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rol:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnSalir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnSalir.BackgroundImage = global::FarmaTown.Properties.Resources.trash1;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.BorderColor = System.Drawing.Color.Green;
            this.btnSalir.BorderRadius = 20;
            this.btnSalir.BorderSize = 1;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(435, 484);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 49);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnEditar.BackgroundImage = global::FarmaTown.Properties.Resources.Editor;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.BorderColor = System.Drawing.Color.Green;
            this.btnEditar.BorderRadius = 20;
            this.btnEditar.BorderSize = 1;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(116, 484);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(58, 49);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnEliminar.BackgroundImage = global::FarmaTown.Properties.Resources.trash;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.BorderColor = System.Drawing.Color.Green;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 1;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(200, 484);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 49);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnAgregar.BackgroundImage = global::FarmaTown.Properties.Resources.addPerson;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.BorderColor = System.Drawing.Color.Green;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.BorderSize = 1;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.Location = new System.Drawing.Point(33, 484);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 49);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.undraw_Hire_re_gn5j;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(547, 559);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbResultados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbResultados.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private CustomControls.RJControls.RJButton btnAgregar;
        private CustomControls.RJControls.RJButton btnEliminar;
        private CustomControls.RJControls.RJButton btnEditar;
        private CustomControls.RJControls.RJButton btnSalir;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.GroupBox gbFiltros;
        private JMaterialTextbox.JMaterialTextbox txtbNombre;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btnConsultar;
        private System.Windows.Forms.ComboBox cboRoles;
        private System.Windows.Forms.Label label2;
    }
}