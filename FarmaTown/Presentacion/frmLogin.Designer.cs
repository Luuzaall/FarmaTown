
namespace FarmaTown
{
    partial class frmLogin
    //
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtbUsuario = new JMaterialTextbox.JMaterialTextbox();
            this.txtbClave = new JMaterialTextbox.JMaterialTextbox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.btnSalir = new CustomControls.RJControls.RJButton();
            this.btnIngresar = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(40, 81);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(87, 23);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(12, 130);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(129, 23);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Contraseña:";
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtbUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtbUsuario.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtbUsuario.ForeColors = System.Drawing.Color.Black;
            this.txtbUsuario.HintText = null;
            this.txtbUsuario.IsPassword = false;
            this.txtbUsuario.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbUsuario.LineThickness = 2;
            this.txtbUsuario.Location = new System.Drawing.Point(160, 81);
            this.txtbUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbUsuario.MaxLength = 32767;
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.OnFocusedColor = System.Drawing.Color.Black;
            this.txtbUsuario.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbUsuario.ReadOnly = false;
            this.txtbUsuario.Size = new System.Drawing.Size(244, 23);
            this.txtbUsuario.TabIndex = 6;
            this.txtbUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbUsuario.TextName = "";
            // 
            // txtbClave
            // 
            this.txtbClave.BackColor = System.Drawing.Color.Transparent;
            this.txtbClave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtbClave.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtbClave.ForeColors = System.Drawing.Color.Black;
            this.txtbClave.HintText = null;
            this.txtbClave.IsPassword = false;
            this.txtbClave.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbClave.LineThickness = 2;
            this.txtbClave.Location = new System.Drawing.Point(160, 130);
            this.txtbClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbClave.MaxLength = 32767;
            this.txtbClave.Name = "txtbClave";
            this.txtbClave.OnFocusedColor = System.Drawing.Color.Black;
            this.txtbClave.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtbClave.ReadOnly = false;
            this.txtbClave.Size = new System.Drawing.Size(244, 23);
            this.txtbClave.TabIndex = 7;
            this.txtbClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbClave.TextName = "";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblIngreso.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(108, 21);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(252, 32);
            this.lblIngreso.TabIndex = 10;
            this.lblIngreso.Text = "Ingreso al Sistema";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(185)))), ((int)(((byte)(15)))));
            this.btnSalir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(185)))), ((int)(((byte)(15)))));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(185)))), ((int)(((byte)(15)))));
            this.btnSalir.BorderRadius = 20;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.Location = new System.Drawing.Point(85, 195);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 40);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.Black;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(185)))), ((int)(((byte)(15)))));
            this.btnIngresar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(185)))), ((int)(((byte)(15)))));
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIngresar.BorderColor = System.Drawing.Color.White;
            this.btnIngresar.BorderRadius = 20;
            this.btnIngresar.BorderSize = 0;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.Black;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngresar.Location = new System.Drawing.Point(247, 185);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(157, 50);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextColor = System.Drawing.Color.Black;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::FarmaTown.Properties.Resources.FondoFarmaTown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnIngresar;
            this.ClientSize = new System.Drawing.Size(462, 259);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtbClave);
            this.Controls.Add(this.txtbUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private JMaterialTextbox.JMaterialTextbox txtbUsuario;
        private JMaterialTextbox.JMaterialTextbox txtbClave;
        private CustomControls.RJControls.RJButton btnIngresar;
        private CustomControls.RJControls.RJButton btnSalir;
        private System.Windows.Forms.Label lblIngreso;
    }
}

