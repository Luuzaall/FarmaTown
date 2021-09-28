
namespace FarmaTown.Presentacion.Farmacias
{
    partial class frmABMFarmacias
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
            System.Windows.Forms.GroupBox groupBox1;
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNombre = new JMaterialTextbox.JMaterialTextbox();
            this.txtbNumero = new JMaterialTextbox.JMaterialTextbox();
            this.txtbCalle = new JMaterialTextbox.JMaterialTextbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBarrios = new System.Windows.Forms.DataGridView();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new CustomControls.RJControls.RJButton();
            this.btnAceptar = new CustomControls.RJControls.RJButton();
            this.transparentLabel3 = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.btnRegBarrio = new CustomControls.RJControls.RJButton();
            this.lblSucursal = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.btnLimpiar = new CustomControls.RJControls.RJButton();
            this.lblNumero = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.lblCalle = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.White;
            groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            groupBox1.Controls.Add(this.label1);
            groupBox1.Controls.Add(this.lblSucursal);
            groupBox1.Controls.Add(this.btnLimpiar);
            groupBox1.Controls.Add(this.txtbNombre);
            groupBox1.Controls.Add(this.lblNumero);
            groupBox1.Controls.Add(this.lblCalle);
            groupBox1.Controls.Add(this.txtbNumero);
            groupBox1.Controls.Add(this.txtbCalle);
            groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            groupBox1.Location = new System.Drawing.Point(16, 32);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox1.Size = new System.Drawing.Size(824, 357);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Farmacia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.label1.Location = new System.Drawing.Point(584, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 46);
            this.label1.TabIndex = 23;
            this.label1.Text = "Los campos con (*) \r\nson obligatorios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtbNombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbNombre.Font_Size = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbNombre.ForeColors = System.Drawing.Color.Black;
            this.txtbNombre.HintText = null;
            this.txtbNombre.IsPassword = false;
            this.txtbNombre.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.txtbNombre.LineThickness = 3;
            this.txtbNombre.Location = new System.Drawing.Point(303, 50);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtbNombre.MaxLength = 32767;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbNombre.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbNombre.ReadOnly = false;
            this.txtbNombre.Size = new System.Drawing.Size(401, 28);
            this.txtbNombre.TabIndex = 12;
            this.txtbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbNombre.TextName = "";
            // 
            // txtbNumero
            // 
            this.txtbNumero.BackColor = System.Drawing.Color.Transparent;
            this.txtbNumero.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbNumero.Font_Size = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbNumero.ForeColors = System.Drawing.Color.Black;
            this.txtbNumero.HintText = null;
            this.txtbNumero.IsPassword = false;
            this.txtbNumero.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.txtbNumero.LineThickness = 3;
            this.txtbNumero.Location = new System.Drawing.Point(303, 198);
            this.txtbNumero.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtbNumero.MaxLength = 32767;
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbNumero.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbNumero.ReadOnly = false;
            this.txtbNumero.Size = new System.Drawing.Size(401, 28);
            this.txtbNumero.TabIndex = 15;
            this.txtbNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbNumero.TextName = "";
            // 
            // txtbCalle
            // 
            this.txtbCalle.BackColor = System.Drawing.Color.Transparent;
            this.txtbCalle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbCalle.Font_Size = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbCalle.ForeColors = System.Drawing.Color.Black;
            this.txtbCalle.HintText = null;
            this.txtbCalle.IsPassword = false;
            this.txtbCalle.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.txtbCalle.LineThickness = 3;
            this.txtbCalle.Location = new System.Drawing.Point(303, 123);
            this.txtbCalle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtbCalle.MaxLength = 32767;
            this.txtbCalle.Name = "txtbCalle";
            this.txtbCalle.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbCalle.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbCalle.ReadOnly = false;
            this.txtbCalle.Size = new System.Drawing.Size(401, 28);
            this.txtbCalle.TabIndex = 14;
            this.txtbCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbCalle.TextName = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.transparentLabel3);
            this.groupBox2.Controls.Add(this.dgvBarrios);
            this.groupBox2.Controls.Add(this.btnRegBarrio);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(16, 396);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(824, 357);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Barrio";
            // 
            // dgvBarrios
            // 
            this.dgvBarrios.AllowUserToAddRows = false;
            this.dgvBarrios.AllowUserToDeleteRows = false;
            this.dgvBarrios.AllowUserToResizeColumns = false;
            this.dgvBarrios.AllowUserToResizeRows = false;
            this.dgvBarrios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.dgvBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleado,
            this.Nombre,
            this.Localidad});
            this.dgvBarrios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.dgvBarrios.Location = new System.Drawing.Point(8, 64);
            this.dgvBarrios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBarrios.MultiSelect = false;
            this.dgvBarrios.Name = "dgvBarrios";
            this.dgvBarrios.ReadOnly = true;
            this.dgvBarrios.RowHeadersWidth = 51;
            this.dgvBarrios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarrios.Size = new System.Drawing.Size(619, 279);
            this.dgvBarrios.TabIndex = 27;
            // 
            // idEmpleado
            // 
            this.idEmpleado.HeaderText = "ID";
            this.idEmpleado.MinimumWidth = 6;
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.MinimumWidth = 6;
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            this.Localidad.Width = 170;
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
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancelar.Location = new System.Drawing.Point(157, 774);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(172, 60);
            this.btnCancelar.TabIndex = 29;
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
            this.btnAceptar.Location = new System.Drawing.Point(501, 774);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(187, 60);
            this.btnAceptar.TabIndex = 28;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.Black;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // transparentLabel3
            // 
            this.transparentLabel3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.transparentLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transparentLabel3.Location = new System.Drawing.Point(28, 28);
            this.transparentLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.transparentLabel3.Name = "transparentLabel3";
            this.transparentLabel3.Size = new System.Drawing.Size(40, 28);
            this.transparentLabel3.TabIndex = 36;
            this.transparentLabel3.TabStop = false;
            this.transparentLabel3.Text = "(*)";
            this.transparentLabel3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btnRegBarrio
            // 
            this.btnRegBarrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnRegBarrio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnRegBarrio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegBarrio.BorderColor = System.Drawing.Color.Green;
            this.btnRegBarrio.BorderRadius = 20;
            this.btnRegBarrio.BorderSize = 1;
            this.btnRegBarrio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegBarrio.FlatAppearance.BorderSize = 0;
            this.btnRegBarrio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRegBarrio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRegBarrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegBarrio.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegBarrio.ForeColor = System.Drawing.Color.Black;
            this.btnRegBarrio.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRegBarrio.Location = new System.Drawing.Point(657, 170);
            this.btnRegBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegBarrio.Name = "btnRegBarrio";
            this.btnRegBarrio.Size = new System.Drawing.Size(141, 69);
            this.btnRegBarrio.TabIndex = 26;
            this.btnRegBarrio.Text = "Registrar Barrio";
            this.btnRegBarrio.TextColor = System.Drawing.Color.Black;
            this.btnRegBarrio.UseVisualStyleBackColor = false;
            this.btnRegBarrio.Click += new System.EventHandler(this.btnRegBarrio_Click);
            // 
            // lblSucursal
            // 
            this.lblSucursal.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblSucursal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSucursal.Location = new System.Drawing.Point(55, 50);
            this.lblSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(168, 28);
            this.lblSucursal.TabIndex = 19;
            this.lblSucursal.TabStop = false;
            this.lblSucursal.Text = "  Sucursal(*):";
            this.lblSucursal.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.BorderColor = System.Drawing.Color.Green;
            this.btnLimpiar.BorderRadius = 20;
            this.btnLimpiar.BorderSize = 1;
            this.btnLimpiar.CausesValidation = false;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiar.Location = new System.Drawing.Point(323, 263);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(172, 60);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.Black;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumero.Location = new System.Drawing.Point(72, 198);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(151, 28);
            this.lblNumero.TabIndex = 21;
            this.lblNumero.TabStop = false;
            this.lblNumero.Text = "Número(*):";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblCalle
            // 
            this.lblCalle.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblCalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCalle.Location = new System.Drawing.Point(107, 123);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(116, 28);
            this.lblCalle.TabIndex = 22;
            this.lblCalle.TabStop = false;
            this.lblCalle.Text = "Calle(*):";
            this.lblCalle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // frmABMFarmacias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 862);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmABMFarmacias";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmABMFarmacias_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DiseñosElemGUI.TransparentLabel transparentLabel3;
        private System.Windows.Forms.DataGridView dgvBarrios;
        private CustomControls.RJControls.RJButton btnRegBarrio;
        private CustomControls.RJControls.RJButton btnLimpiar;
        private System.Windows.Forms.Label label1;
        private DiseñosElemGUI.TransparentLabel lblSucursal;
        private JMaterialTextbox.JMaterialTextbox txtbNombre;
        private DiseñosElemGUI.TransparentLabel lblNumero;
        private DiseñosElemGUI.TransparentLabel lblCalle;
        private JMaterialTextbox.JMaterialTextbox txtbNumero;
        private JMaterialTextbox.JMaterialTextbox txtbCalle;
        private CustomControls.RJControls.RJButton btnCancelar;
        private CustomControls.RJControls.RJButton btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
    }
}