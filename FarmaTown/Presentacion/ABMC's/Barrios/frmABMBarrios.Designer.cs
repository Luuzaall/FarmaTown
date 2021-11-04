
namespace FarmaTown.Presentacion.Localidades
{
    partial class frmABMBarrios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMBarrios));
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.dgvLocalidades = new System.Windows.Forms.DataGridView();
            this.lblNomLocalidad = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.btnCancelar = new CustomControls.RJControls.RJButton();
            this.btnAceptar = new CustomControls.RJControls.RJButton();
            this.btnLimpiar = new CustomControls.RJControls.RJButton();
            this.lblNomBarrio = new FarmaTown.Presentacion.DiseñosElemGUI.TransparentLabel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.idLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.txtbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNombre.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.Location = new System.Drawing.Point(159, 49);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(316, 25);
            this.txtbNombre.TabIndex = 34;
            // 
            // dgvLocalidades
            // 
            this.dgvLocalidades.AllowUserToAddRows = false;
            this.dgvLocalidades.AllowUserToDeleteRows = false;
            this.dgvLocalidades.AllowUserToResizeColumns = false;
            this.dgvLocalidades.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLocalidades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocalidades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLocalidad,
            this.nomLocalidad});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocalidades.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLocalidades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(79)))));
            this.dgvLocalidades.Location = new System.Drawing.Point(159, 118);
            this.dgvLocalidades.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvLocalidades.MultiSelect = false;
            this.dgvLocalidades.Name = "dgvLocalidades";
            this.dgvLocalidades.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLocalidades.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLocalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalidades.Size = new System.Drawing.Size(316, 138);
            this.dgvLocalidades.TabIndex = 41;
            this.dgvLocalidades.TabStop = false;
            // 
            // lblNomLocalidad
            // 
            this.lblNomLocalidad.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNomLocalidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomLocalidad.Location = new System.Drawing.Point(18, 158);
            this.lblNomLocalidad.Name = "lblNomLocalidad";
            this.lblNomLocalidad.Size = new System.Drawing.Size(132, 23);
            this.lblNomLocalidad.TabIndex = 40;
            this.lblNomLocalidad.TabStop = false;
            this.lblNomLocalidad.Text = "Localidad(*):";
            this.lblNomLocalidad.TextAlign = System.Drawing.ContentAlignment.TopLeft;
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
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancelar.Location = new System.Drawing.Point(159, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 46);
            this.btnCancelar.TabIndex = 38;
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
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAceptar.Location = new System.Drawing.Point(355, 278);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 46);
            this.btnAceptar.TabIndex = 37;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.Black;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(504, 158);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 44);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.Black;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblNomBarrio
            // 
            this.lblNomBarrio.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblNomBarrio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomBarrio.Location = new System.Drawing.Point(28, 51);
            this.lblNomBarrio.Name = "lblNomBarrio";
            this.lblNomBarrio.Size = new System.Drawing.Size(106, 23);
            this.lblNomBarrio.TabIndex = 35;
            this.lblNomBarrio.TabStop = false;
            this.lblNomBarrio.Text = "Nombre(*):";
            this.lblNomBarrio.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblAviso.Location = new System.Drawing.Point(24, 9);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(218, 22);
            this.lblAviso.TabIndex = 43;
            this.lblAviso.Text = "El campo es obligatorio";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // idLocalidad
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLocalidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.idLocalidad.HeaderText = "ID";
            this.idLocalidad.Name = "idLocalidad";
            this.idLocalidad.ReadOnly = true;
            this.idLocalidad.Visible = false;
            this.idLocalidad.Width = 50;
            // 
            // nomLocalidad
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomLocalidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.nomLocalidad.HeaderText = "Nombre";
            this.nomLocalidad.Name = "nomLocalidad";
            this.nomLocalidad.ReadOnly = true;
            this.nomLocalidad.Width = 250;
            // 
            // frmABMBarrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.undraw_small_town_rxs3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(619, 336);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.dgvLocalidades);
            this.Controls.Add(this.lblNomLocalidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblNomBarrio);
            this.Controls.Add(this.txtbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmABMBarrios";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmABMBarrios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton btnCancelar;
        private CustomControls.RJControls.RJButton btnAceptar;
        private CustomControls.RJControls.RJButton btnLimpiar;
        private DiseñosElemGUI.TransparentLabel lblNomBarrio;
        private System.Windows.Forms.TextBox txtbNombre;
        private DiseñosElemGUI.TransparentLabel lblNomLocalidad;
        private System.Windows.Forms.DataGridView dgvLocalidades;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomLocalidad;
    }
}